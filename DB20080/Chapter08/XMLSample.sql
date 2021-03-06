-- Make sure to change file paths to the locations where you installed the sample files

USE MASTER
GO


-- Create a new database for our samples
DROP DATABASE xmldb

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'xmldb') 
	CREATE DATABASE xmldb
GO

USE xmldb
GO

--Declare our variable for our XML
declare @x XML
-- Open our XSD Schema, make sure to change the location to your location for the file
SELECT @x = s
FROM OPENROWSET (
 BULK 'C:\Customer.xsd',
 SINGLE_BLOB) AS TEMP(s)

select @x
-- Make sure our schema does not exist already
IF EXISTS(select * from sys.xml_schema_collections where name='Customer')
  DROP XML SCHEMA COLLECTION Customer
-- Create the schema in the schema collection for the database
CREATE XML SCHEMA COLLECTION Customer AS @x
GO
-- Create a table that uses our schema on an XML datatype
CREATE TABLE xmltbl2 (pk INT IDENTITY PRIMARY KEY, xmlColWithSchema XML (CONTENT Customer))
GO

--Use Dynamic Management Views to view our schema and namespaces
SELECT * FROM sys.xml_schema_collections
go

SELECT * FROM sys.xml_schema_namespaces
go


--Return our schema
USE xmldb
go
SELECT xml_schema_namespace(N'dbo',N'Customer')
Go


--Insert data into the new table

--This succeeds, make sure to change the location to your location for the file
INSERT INTO xmltbl2 (xmlColWithSchema)
SELECT *
FROM OPENROWSET (
 BULK 'C:\Customer1.xml',
 SINGLE_BLOB) AS TEMP
GO

--This fails because of schema validation
INSERT INTO xmltbl2 (xmlColWithSchema)
SELECT *
FROM OPENROWSET (
 BULK 'C:\Customer2.xml',
 SINGLE_BLOB) AS TEMP
GO

--Insert XML directly using inline XML
INSERT INTO xmltbl2(xmlColWithSchema) VALUES(
	'<doc id="d1" xmlns="urn:example/customer">
       <customer id="c7">
         <name>Tom</name>
         <order id="1" year="2002"></order>
         <order id="2" year="2003"></order>
         <notes>
           <buys>gizmos</buys>
           <saleslead>Bob</saleslead>
           <competitor>Acme</competitor>
         </notes>
       </customer>
     </doc>
    ')
Go

--SCHEMA Permissions sample
-- Grant permissions on the relational schema in the database
GRANT ALTER ON SCHEMA::dbo TO User1
go
-- Grant permission to create xml schema collections in the database
GRANT CREATE XML SCHEMA COLLECTION 
TO User1
go


--Create a constraint (use with builds before June CTP)
--CREATE TABLE xmltbl3 (pk INT IDENTITY PRIMARY KEY, xmlColWithConstraint XML CHECK(xmlColWithConstraint.exist('declare namespace cust="urn:example/customer";
--     /cust:doc/cust:customer/cust:name') = 1 
--	))
--Go

--Create a UDF for our constraint
create function CheckCustomerName(@x xml)
returns bit
as
begin
  return @x.exist('declare namespace
cust="urn:example/customer";
/cust:doc/cust:customer/cust:name')
end;
Go

--Create a constraint
CREATE TABLE xmltbl3 (pk INT IDENTITY PRIMARY KEY,
xmlColWithConstraint XML CHECK(dbo.CheckCustomerName(xmlColWithConstraint) = 1))
Go


-- This fails due to the constraint
INSERT INTO xmltbl3 (xmlColWithConstraint)
SELECT *
FROM OPENROWSET (
 BULK 'C:\Customer3.xml',
 SINGLE_BLOB) AS TEMP
GO

-- This works!
INSERT INTO xmltbl3 (xmlColWithConstraint)
SELECT *
FROM OPENROWSET (
 BULK 'C:\Customer4.xml',
 SINGLE_BLOB) AS TEMP
GO


-- XQUERY SAMPLES

-- Create a new table
CREATE TABLE xmltblnew (pk INT IDENTITY PRIMARY KEY, people XML)
GO

--Insert data into the new table, change location to your location of the file
INSERT INTO xmltblnew (people)
SELECT *
FROM OPENROWSET (
 BULK 'C:\peopleXML.xml',
 SINGLE_BLOB) AS TEMP
GO


--Run an XQuery for people with Age elements
SELECT people.query(
'for $p in //people
where $p//age
return
  <person>
    <name>{$p//givenName}</name>
  </person>
'
)
FROM xmltblnew

--Use the Count function in XQuery
SELECT people.query(
'count(//person)
')
FROM XMLtblnew
go


--Use other functions such as round and avg
SELECT people.query(
'round(avg(//age))
')
FROM XMLtblnew
go


--Use the exist function

SELECT pk, people FROM xmltblnew
  WHERE (people.exist('/people/person/name/givenName[.="Tom"]') = 1)

--Use Value function
SELECT people.value('/people[1]/person[2]/age[1][text()]', 'integer') as age FROM XMLtblnew
Go

--This causes a singleton error
SELECT people.value('/people/person[2]/age[1][text()]', 'integer') as age FROM XMLtblnew
Go

--Use more advanced functions like string functions
SELECT people.query(
'for $c in (/people)
where $c//age
return
  <customers>
	<name>
     {$c//givenName}
    </name>
    <match>{contains($c,"Martin")}</match>
    <maxage>{max($c//age)}</maxage>
  </customers>
')
FROM xmltblnew
Go

-- CROSS DOMAIN QUERIES


-- CREATE A TABLE AND INSERT SOME VALUES

CREATE TABLE xmlTable (id int IDENTITY PRIMARY KEY,
                       CustomerID char(5),
                       Name varchar(50),
                       Address varchar(100),
                       xmlCustomer XML);
GO
INSERT INTO xmlTable
VALUES ('AP', 'Apress LP', 'Berkeley CA', '<Customer />');

-- USE THE VALUES IN XQUERY

GO
DECLARE @numemployees int;
SET @numemployees=500;
SELECT id, xmlCustomer.query(' 
declare namespace pd="urn:example/customer"; 
       <Customer
           CustomerID=       "{ sql:column("T.CustomerID") }" 
           CustomerName=     "{ sql:column("T.Name") }"
           CustomerAddress=  "{ sql:column("T.Address") }"
           NumEmployees=     "{ sql:variable("@numemployees") }">
        </Customer> 
') as Result FROM xmlTable T;
GO


--DML using XQuery

--First insert a new value
UPDATE xmltblnew SET people.modify(
'insert <favoriteColor>Red</favoriteColor> 
  as last into (/people/person[3])[1]')
where pk=1
go

--Select the data to show the change
SELECT * FROM xmltblnew
go

--Modify the value
UPDATE xmltblnew SET people.modify(
'replace value of (/people/person[3]/favoriteColor[1]/text())[1]
  with "Blue"')
where pk=1
go

--Select the data to show the change
SELECT * FROM xmltblnew
go

--Now delete the value
UPDATE xmltblnew SET people.modify(
'delete /people/person[3]/favoriteColor')
where pk=1
go

--Select the data to show the change
SELECT * FROM xmltblnew
go


--INDEXING SECTION

--Create a primary XML Index
CREATE PRIMARY XML INDEX idx_xmlCol on xmltblnew(people)
go

--Create a PATH secondary index
CREATE XML INDEX idx_xmlCol_PATH on xmltblnew(people)
  USING XML INDEX idx_xmlCol FOR PATH
go
-- Query that would use this index
SELECT people FROM xmltblnew
  WHERE (people.exist('/people/person/name/givenName[.="Tom"]') = 1)


--Create a PROPERTY secondary index
CREATE XML INDEX idx_xmlCol_PROPERTY on xmltblnew(people)
  USING XML INDEX idx_xmlCol FOR PROPERTY
go
-- Query that would use this index
SELECT people.value('(/people/person/age)[1]', 'int') FROM xmltblnew
go

--Create a VALUE secondary index
CREATE XML INDEX idx_xmlCol_VALUE on xmltblnew(people)
  USING XML INDEX idx_xmlCol FOR VALUE
go
-- Query that would use this index
SELECT people FROM xmltblnew WHERE people.exist('//age') = 1
go

-- DYNAMIC MANAGEMENT VIEWS SAMPLES

SELECT * FROM sys.xml_schema_collections
SELECT * FROM sys.xml_schema_elements
SELECT * FROM sys.xml_schema_attributes
SELECT * FROM sys.xml_schema_namespaces
SELECT * FROM sys.xml_indexes
go

--Use some of the views
SELECT *
FROM sys.xml_schema_collections xmlSchemaCollection 
       JOIN sys.xml_schema_namespaces xmlSchemaName
       ON (xmlSchemaName.xml_collection_id = xmlSchemaName.xml_collection_id)
WHERE xmlSchemaCollection.name = 'Customer'   
go


-- ENDPOINT SAMPLE

--Make sure to run this section before attempting to the Windows Forms sample Web Services application

-- Create our stored procedure
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE usp_SQLWS
(@msg nvarchar(256))
AS BEGIN
   select @msg as 'message'
END 

GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO



--Create an endpoint
CREATE ENDPOINT SQLWS_endpoint
STATE = STARTED
  AS HTTP(
	PATH = '/sql/sample',
	AUTHENTICATION= ( INTEGRATED ),
    PORTS = ( CLEAR )
  )
FOR SOAP (
  WEBMETHOD
    'http://tempuri.org/'.'SQLWS' 
    (NAME = 'xmldb.dbo.usp_SQLWS'),
    BATCHES = ENABLED,
    WSDL = DEFAULT
  )
go

