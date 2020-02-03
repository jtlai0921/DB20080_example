﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50215.312
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.ComponentModel.ToolboxItem(true),  _
 System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 System.Xml.Serialization.XmlRootAttribute("AdventureWorksDataSet"),  _
 System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet"),  _
 System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly")>  _
Partial Public Class AdventureWorksDataSet
    Inherits System.Data.DataSet
    
    Private tableGetProducts As GetProductsDataTable
    
    Private _schemaSerializationMode As System.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>  _
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("GetProducts")) Is Nothing) Then
                MyBase.Tables.Add(New GetProductsDataTable(ds.Tables("GetProducts")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property GetProducts() As GetProductsDataTable
        Get
            Return Me.tableGetProducts
        End Get
    End Property
    
    Public Overrides Property SchemaSerializationMode() As System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <System.ComponentModel.DefaultValueAttribute(true)>  _
    Public Shadows Property EnforceConstraints() As Boolean
        Get
            Return MyBase.EnforceConstraints
        End Get
        Set
            MyBase.EnforceConstraints = value
        End Set
    End Property
    
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    Public Overrides Function Clone() As System.Data.DataSet
        Dim cln As AdventureWorksDataSet = CType(MyBase.Clone,AdventureWorksDataSet)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("GetProducts")) Is Nothing) Then
                MyBase.Tables.Add(New GetProductsDataTable(ds.Tables("GetProducts")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableGetProducts = CType(MyBase.Tables("GetProducts"),GetProductsDataTable)
        If (initTable = true) Then
            If (Not (Me.tableGetProducts) Is Nothing) Then
                Me.tableGetProducts.InitVars
            End If
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "AdventureWorksDataSet"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/AdventureWorksDataSet.xsd"
        Me.EnforceConstraints = true
        Me.tableGetProducts = New GetProductsDataTable
        MyBase.Tables.Add(Me.tableGetProducts)
    End Sub
    
    Private Function ShouldSerializeGetProducts() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Shared Function GetTypedDataSetSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
        Dim ds As AdventureWorksDataSet = New AdventureWorksDataSet
        Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
        xs.Add(ds.GetSchemaSerializable)
        Dim any As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Return type
    End Function
    
    Public Delegate Sub GetProductsRowChangeEventHandler(ByVal sender As Object, ByVal e As GetProductsRowChangeEvent)
    
    <System.Serializable(),  _
     System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class GetProductsDataTable
        Inherits System.Data.DataTable
        Implements System.Collections.IEnumerable
        
        Private columnName As System.Data.DataColumn
        
        Private columnCategoryName As System.Data.DataColumn
        
        Private columnSubCategoryName As System.Data.DataColumn
        
        Private columnProductNumber As System.Data.DataColumn
        
        Private columnColor As System.Data.DataColumn
        
        Private columnStandardCost As System.Data.DataColumn
        
        Private columnListPrice As System.Data.DataColumn
        
        Private columnSize As System.Data.DataColumn
        
        Private columnWeight As System.Data.DataColumn
        
        Private columnClass As System.Data.DataColumn
        
        Private columnStyle As System.Data.DataColumn
        
        Private columnProductID As System.Data.DataColumn
        
        Public Sub New()
            MyBase.New
            Me.TableName = "GetProducts"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        Friend Sub New(ByVal table As System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        Public ReadOnly Property NameColumn() As System.Data.DataColumn
            Get
                Return Me.columnName
            End Get
        End Property
        
        Public ReadOnly Property CategoryNameColumn() As System.Data.DataColumn
            Get
                Return Me.columnCategoryName
            End Get
        End Property
        
        Public ReadOnly Property SubCategoryNameColumn() As System.Data.DataColumn
            Get
                Return Me.columnSubCategoryName
            End Get
        End Property
        
        Public ReadOnly Property ProductNumberColumn() As System.Data.DataColumn
            Get
                Return Me.columnProductNumber
            End Get
        End Property
        
        Public ReadOnly Property ColorColumn() As System.Data.DataColumn
            Get
                Return Me.columnColor
            End Get
        End Property
        
        Public ReadOnly Property StandardCostColumn() As System.Data.DataColumn
            Get
                Return Me.columnStandardCost
            End Get
        End Property
        
        Public ReadOnly Property ListPriceColumn() As System.Data.DataColumn
            Get
                Return Me.columnListPrice
            End Get
        End Property
        
        Public ReadOnly Property SizeColumn() As System.Data.DataColumn
            Get
                Return Me.columnSize
            End Get
        End Property
        
        Public ReadOnly Property WeightColumn() As System.Data.DataColumn
            Get
                Return Me.columnWeight
            End Get
        End Property
        
        Public ReadOnly Property ClassColumn() As System.Data.DataColumn
            Get
                Return Me.columnClass
            End Get
        End Property
        
        Public ReadOnly Property StyleColumn() As System.Data.DataColumn
            Get
                Return Me.columnStyle
            End Get
        End Property
        
        Public ReadOnly Property ProductIDColumn() As System.Data.DataColumn
            Get
                Return Me.columnProductID
            End Get
        End Property
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As GetProductsRow
            Get
                Return CType(Me.Rows(index),GetProductsRow)
            End Get
        End Property
        
        Public Event GetProductsRowChanged As GetProductsRowChangeEventHandler
        
        Public Event GetProductsRowChanging As GetProductsRowChangeEventHandler
        
        Public Event GetProductsRowDeleted As GetProductsRowChangeEventHandler
        
        Public Event GetProductsRowDeleting As GetProductsRowChangeEventHandler
        
        Public Overloads Sub AddGetProductsRow(ByVal row As GetProductsRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddGetProductsRow(ByVal Name As String, ByVal CategoryName As String, ByVal SubCategoryName As String, ByVal ProductNumber As String, ByVal Color As String, ByVal StandardCost As Decimal, ByVal ListPrice As Decimal, ByVal Size As String, ByVal Weight As Decimal, ByVal _Class As String, ByVal Style As String) As GetProductsRow
            Dim rowGetProductsRow As GetProductsRow = CType(Me.NewRow,GetProductsRow)
            rowGetProductsRow.ItemArray = New Object() {Name, CategoryName, SubCategoryName, ProductNumber, Color, StandardCost, ListPrice, Size, Weight, _Class, Style, Nothing}
            Me.Rows.Add(rowGetProductsRow)
            Return rowGetProductsRow
        End Function
        
        Public Function FindByProductID(ByVal ProductID As Integer) As GetProductsRow
            Return CType(Me.Rows.Find(New Object() {ProductID}),GetProductsRow)
        End Function
        
        Public Overridable Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As System.Data.DataTable
            Dim cln As GetProductsDataTable = CType(MyBase.Clone,GetProductsDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As System.Data.DataTable
            Return New GetProductsDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnName = MyBase.Columns("Name")
            Me.columnCategoryName = MyBase.Columns("CategoryName")
            Me.columnSubCategoryName = MyBase.Columns("SubCategoryName")
            Me.columnProductNumber = MyBase.Columns("ProductNumber")
            Me.columnColor = MyBase.Columns("Color")
            Me.columnStandardCost = MyBase.Columns("StandardCost")
            Me.columnListPrice = MyBase.Columns("ListPrice")
            Me.columnSize = MyBase.Columns("Size")
            Me.columnWeight = MyBase.Columns("Weight")
            Me.columnClass = MyBase.Columns("Class")
            Me.columnStyle = MyBase.Columns("Style")
            Me.columnProductID = MyBase.Columns("ProductID")
        End Sub
        
        Private Sub InitClass()
            Me.columnName = New System.Data.DataColumn("Name", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnName)
            Me.columnCategoryName = New System.Data.DataColumn("CategoryName", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCategoryName)
            Me.columnSubCategoryName = New System.Data.DataColumn("SubCategoryName", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnSubCategoryName)
            Me.columnProductNumber = New System.Data.DataColumn("ProductNumber", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnProductNumber)
            Me.columnColor = New System.Data.DataColumn("Color", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnColor)
            Me.columnStandardCost = New System.Data.DataColumn("StandardCost", GetType(Decimal), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnStandardCost)
            Me.columnListPrice = New System.Data.DataColumn("ListPrice", GetType(Decimal), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnListPrice)
            Me.columnSize = New System.Data.DataColumn("Size", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnSize)
            Me.columnWeight = New System.Data.DataColumn("Weight", GetType(Decimal), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnWeight)
            Me.columnClass = New System.Data.DataColumn("Class", GetType(String), Nothing, System.Data.MappingType.Element)
            Me.columnClass.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_Class")
            Me.columnClass.ExtendedProperties.Add("Generator_UserColumnName", "Class")
            MyBase.Columns.Add(Me.columnClass)
            Me.columnStyle = New System.Data.DataColumn("Style", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnStyle)
            Me.columnProductID = New System.Data.DataColumn("ProductID", GetType(Integer), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnProductID)
            Me.Constraints.Add(New System.Data.UniqueConstraint("Constraint1", New System.Data.DataColumn() {Me.columnProductID}, true))
            Me.columnName.AllowDBNull = false
            Me.columnName.MaxLength = 50
            Me.columnCategoryName.AllowDBNull = false
            Me.columnCategoryName.MaxLength = 50
            Me.columnSubCategoryName.AllowDBNull = false
            Me.columnSubCategoryName.MaxLength = 50
            Me.columnProductNumber.AllowDBNull = false
            Me.columnProductNumber.MaxLength = 25
            Me.columnColor.MaxLength = 15
            Me.columnStandardCost.AllowDBNull = false
            Me.columnListPrice.AllowDBNull = false
            Me.columnSize.MaxLength = 5
            Me.columnClass.MaxLength = 2
            Me.columnStyle.MaxLength = 2
            Me.columnProductID.AutoIncrement = true
            Me.columnProductID.AllowDBNull = false
            Me.columnProductID.ReadOnly = true
            Me.columnProductID.Unique = true
        End Sub
        
        Public Function NewGetProductsRow() As GetProductsRow
            Return CType(Me.NewRow,GetProductsRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As System.Data.DataRowBuilder) As System.Data.DataRow
            Return New GetProductsRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(GetProductsRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.GetProductsRowChangedEvent) Is Nothing) Then
                RaiseEvent GetProductsRowChanged(Me, New GetProductsRowChangeEvent(CType(e.Row,GetProductsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.GetProductsRowChangingEvent) Is Nothing) Then
                RaiseEvent GetProductsRowChanging(Me, New GetProductsRowChangeEvent(CType(e.Row,GetProductsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.GetProductsRowDeletedEvent) Is Nothing) Then
                RaiseEvent GetProductsRowDeleted(Me, New GetProductsRowChangeEvent(CType(e.Row,GetProductsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.GetProductsRowDeletingEvent) Is Nothing) Then
                RaiseEvent GetProductsRowDeleting(Me, New GetProductsRowChangeEvent(CType(e.Row,GetProductsRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveGetProductsRow(ByVal row As GetProductsRow)
            Me.Rows.Remove(row)
        End Sub
        
        Public Shared Function GetTypedTableSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
            Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
            Dim ds As AdventureWorksDataSet = New AdventureWorksDataSet
            xs.Add(ds.GetSchemaSerializable)
            Dim any1 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "GetProductsDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Return type
        End Function
    End Class
    
    Partial Public Class GetProductsRow
        Inherits System.Data.DataRow
        
        Private tableGetProducts As GetProductsDataTable
        
        Friend Sub New(ByVal rb As System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableGetProducts = CType(Me.Table,GetProductsDataTable)
        End Sub
        
        Public Property Name() As String
            Get
                Return CType(Me(Me.tableGetProducts.NameColumn),String)
            End Get
            Set
                Me(Me.tableGetProducts.NameColumn) = value
            End Set
        End Property
        
        Public Property CategoryName() As String
            Get
                Return CType(Me(Me.tableGetProducts.CategoryNameColumn),String)
            End Get
            Set
                Me(Me.tableGetProducts.CategoryNameColumn) = value
            End Set
        End Property
        
        Public Property SubCategoryName() As String
            Get
                Return CType(Me(Me.tableGetProducts.SubCategoryNameColumn),String)
            End Get
            Set
                Me(Me.tableGetProducts.SubCategoryNameColumn) = value
            End Set
        End Property
        
        Public Property ProductNumber() As String
            Get
                Return CType(Me(Me.tableGetProducts.ProductNumberColumn),String)
            End Get
            Set
                Me(Me.tableGetProducts.ProductNumberColumn) = value
            End Set
        End Property
        
        Public Property Color() As String
            Get
                Try 
                    Return CType(Me(Me.tableGetProducts.ColorColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Color' in table 'GetProducts' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGetProducts.ColorColumn) = value
            End Set
        End Property
        
        Public Property StandardCost() As Decimal
            Get
                Return CType(Me(Me.tableGetProducts.StandardCostColumn),Decimal)
            End Get
            Set
                Me(Me.tableGetProducts.StandardCostColumn) = value
            End Set
        End Property
        
        Public Property ListPrice() As Decimal
            Get
                Return CType(Me(Me.tableGetProducts.ListPriceColumn),Decimal)
            End Get
            Set
                Me(Me.tableGetProducts.ListPriceColumn) = value
            End Set
        End Property
        
        Public Property Size() As String
            Get
                Try 
                    Return CType(Me(Me.tableGetProducts.SizeColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Size' in table 'GetProducts' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGetProducts.SizeColumn) = value
            End Set
        End Property
        
        Public Property Weight() As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableGetProducts.WeightColumn),Decimal)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Weight' in table 'GetProducts' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGetProducts.WeightColumn) = value
            End Set
        End Property
        
        Public Property _Class() As String
            Get
                Try 
                    Return CType(Me(Me.tableGetProducts.ClassColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Class' in table 'GetProducts' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGetProducts.ClassColumn) = value
            End Set
        End Property
        
        Public Property Style() As String
            Get
                Try 
                    Return CType(Me(Me.tableGetProducts.StyleColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Style' in table 'GetProducts' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableGetProducts.StyleColumn) = value
            End Set
        End Property
        
        Public Property ProductID() As Integer
            Get
                Return CType(Me(Me.tableGetProducts.ProductIDColumn),Integer)
            End Get
            Set
                Me(Me.tableGetProducts.ProductIDColumn) = value
            End Set
        End Property
        
        Public Function IsColorNull() As Boolean
            Return Me.IsNull(Me.tableGetProducts.ColorColumn)
        End Function
        
        Public Sub SetColorNull()
            Me(Me.tableGetProducts.ColorColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSizeNull() As Boolean
            Return Me.IsNull(Me.tableGetProducts.SizeColumn)
        End Function
        
        Public Sub SetSizeNull()
            Me(Me.tableGetProducts.SizeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsWeightNull() As Boolean
            Return Me.IsNull(Me.tableGetProducts.WeightColumn)
        End Function
        
        Public Sub SetWeightNull()
            Me(Me.tableGetProducts.WeightColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Is_ClassNull() As Boolean
            Return Me.IsNull(Me.tableGetProducts.ClassColumn)
        End Function
        
        Public Sub Set_ClassNull()
            Me(Me.tableGetProducts.ClassColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStyleNull() As Boolean
            Return Me.IsNull(Me.tableGetProducts.StyleColumn)
        End Function
        
        Public Sub SetStyleNull()
            Me(Me.tableGetProducts.StyleColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    Public Class GetProductsRowChangeEvent
        Inherits System.EventArgs
        
        Private eventRow As GetProductsRow
        
        Private eventAction As System.Data.DataRowAction
        
        Public Sub New(ByVal row As GetProductsRow, ByVal action As System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row() As GetProductsRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action() As System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class

Namespace AdventureWorksDataSetTableAdapters
    
    <System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.ComponentModel.ToolboxItem(true),  _
     System.ComponentModel.DataObjectAttribute(true),  _
     System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner"& _ 
        ", Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"),  _
     System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
    Partial Public Class GetProductsTableAdapter
        Inherits System.ComponentModel.Component
        
        Private WithEvents m_adapter As System.Data.SqlClient.SqlDataAdapter
        
        Private m_connection As System.Data.SqlClient.SqlConnection
        
        Private m_commandCollection() As System.Data.SqlClient.SqlCommand
        
        Private m_clearBeforeFill As Boolean
        
        Public Sub New()
            MyBase.New
            Me.m_clearBeforeFill = true
        End Sub
        
        Private ReadOnly Property Adapter() As System.Data.SqlClient.SqlDataAdapter
            Get
                If (Me.m_adapter Is Nothing) Then
                    Me.InitAdapter
                End If
                Return Me.m_adapter
            End Get
        End Property
        
        Friend Property Connection() As System.Data.SqlClient.SqlConnection
            Get
                If (Me.m_connection Is Nothing) Then
                    Me.InitConnection
                End If
                Return Me.m_connection
            End Get
            Set
                Me.m_connection = value
                If (Not (Me.Adapter.InsertCommand) Is Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Not (Me.Adapter.DeleteCommand) Is Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Not (Me.Adapter.UpdateCommand) Is Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                Do While (i < Me.CommandCollection.Length)
                    If (Not (Me.CommandCollection(i)) Is Nothing) Then
                        CType(Me.CommandCollection(i),System.Data.SqlClient.SqlCommand).Connection = value
                    End If
                    i = (i + 1)
                Loop
            End Set
        End Property
        
        Protected ReadOnly Property CommandCollection() As System.Data.SqlClient.SqlCommand()
            Get
                If (Me.m_commandCollection Is Nothing) Then
                    Me.InitCommandCollection
                End If
                Return Me.m_commandCollection
            End Get
        End Property
        
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me.m_clearBeforeFill
            End Get
            Set
                Me.m_clearBeforeFill = value
            End Set
        End Property
        
        Private Sub InitAdapter()
            Me.m_adapter = New System.Data.SqlClient.SqlDataAdapter
            Dim tableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "GetProducts"
            tableMapping.ColumnMappings.Add("Name", "Name")
            tableMapping.ColumnMappings.Add("CategoryName", "CategoryName")
            tableMapping.ColumnMappings.Add("SubCategoryName", "SubCategoryName")
            tableMapping.ColumnMappings.Add("ProductNumber", "ProductNumber")
            tableMapping.ColumnMappings.Add("Color", "Color")
            tableMapping.ColumnMappings.Add("StandardCost", "StandardCost")
            tableMapping.ColumnMappings.Add("ListPrice", "ListPrice")
            tableMapping.ColumnMappings.Add("Size", "Size")
            tableMapping.ColumnMappings.Add("Weight", "Weight")
            tableMapping.ColumnMappings.Add("Class", "Class")
            tableMapping.ColumnMappings.Add("Style", "Style")
            tableMapping.ColumnMappings.Add("ProductID", "ProductID")
            Me.m_adapter.TableMappings.Add(tableMapping)
        End Sub
        
        Private Sub InitConnection()
            Me.m_connection = New System.Data.SqlClient.SqlConnection
            Me.m_connection.ConnectionString = Report_Control_Sample.Settings.Default.AdventureWorksConnectionString
        End Sub
        
        Private Sub InitCommandCollection()
            Me.m_commandCollection = New System.Data.SqlClient.SqlCommand(0) {}
            Me.m_commandCollection(0) = New System.Data.SqlClient.SqlCommand
            Me.m_commandCollection(0).Connection = Me.Connection
            Me.m_commandCollection(0).CommandText = "dbo.GetProducts"
            Me.m_commandCollection(0).CommandType = System.Data.CommandType.StoredProcedure
            Me.m_commandCollection(0).Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, 10, 0, Nothing, System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        End Sub
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, true)>  _
        Public Overloads Overridable Function Fill(ByVal dataTable As AdventureWorksDataSet.GetProductsDataTable) As System.Nullable(Of Integer)
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = True) Then
                dataTable.Clear()
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Overloads Overridable Function GetData() As AdventureWorksDataSet.GetProductsDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As AdventureWorksDataSet.GetProductsDataTable = New AdventureWorksDataSet.GetProductsDataTable
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function
        
        Public Overloads Overridable Function Update(ByVal dataTable As AdventureWorksDataSet.GetProductsDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function
        
        Public Overloads Overridable Function Update(ByVal dataSet As AdventureWorksDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "GetProducts")
        End Function
        
        Public Overloads Overridable Function Update(ByVal dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow() {dataRow})
        End Function
        
        Public Overloads Overridable Function Update(ByVal dataRows() As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function
    End Class
End Namespace
