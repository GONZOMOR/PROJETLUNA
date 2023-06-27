#Region "Author"
'Class created with Luna 3.4.0.0
'Author: Diego Lunadei
'Date: 23/06/2023
#End Region

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb

Partial Public Class Gcm_article
    Inherits LUNA.LunaBaseClassEntity
    '******IMPORTANT: Don't write your code here. Write your code in the Class object that use this Partial Class.
    '******So you can replace DAOClass and EntityClass without lost your code

    Public Sub New()

    End Sub

#Region "Database Field Map"

    Protected _id As Integer = 0

    <XmlElementAttribute("id")>
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            If _id <> value Then
                IsChanged = True
                _id = value
            End If
        End Set
    End Property

    Protected _code As String = ""

    <XmlElementAttribute("code")>
    Public Property code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            If _code <> value Then
                IsChanged = True
                _code = value
            End If
        End Set
    End Property

    Protected _désignation As String = ""

    <XmlElementAttribute("désignation")>
    Public Property désignation() As String
        Get
            Return _désignation
        End Get
        Set(ByVal value As String)
            If _désignation <> value Then
                IsChanged = True
                _désignation = value
            End If
        End Set
    End Property

    Protected _prix As Integer = 0

    <XmlElementAttribute("prix")>
    Public Property prix() As Integer
        Get
            Return _prix
        End Get
        Set(ByVal value As Integer)
            If _prix <> value Then
                IsChanged = True
                _prix = value
            End If
        End Set
    End Property

    Protected _date_creation As DateTime = Nothing

    <XmlElementAttribute("date_creation")>
    Public Property date_creation() As DateTime
        Get
            Return _date_creation
        End Get
        Set(ByVal value As DateTime)
            If _date_creation <> value Then
                IsChanged = True
                _date_creation = value
            End If
        End Set
    End Property
#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Gcm_article from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Dim Mgr As New Gcm_articleDAO
            Dim int As Gcm_article = Mgr.Read(Id)
            _id = int.id
            _code = int.code
            _désignation = int.désignation
            _prix = int.prix
            _date_creation = int.date_creation
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Gcm_article on DB.
    ''' </summary>
    ''' <returns>
    '''Return Id insert in DB if all ok, 0 if error
    ''' </returns>
    Public Overridable Function Save() As Integer
        'Return the id Inserted
        Dim Ris As Integer = 0
        Try
            Dim Mgr As New Gcm_articleDAO
            Ris = Mgr.Save(Me)
        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ris
    End Function

#End Region

#Region "Embedded Class"

#End Region

End Class

''' <summary>
'''This class manage persistency on db of Gcm_article object
''' </summary>
''' <remarks>
'''
''' </remarks>
Partial Public Class Gcm_articleDAO
    Inherits LUNA.LunaBaseClassDAO(Of Gcm_article)

    ''' <summary>
    '''New() create an istance of this class. Use default DB Connection
    ''' </summary>
    ''' <returns>
    '''
    ''' </returns>
    Public Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    '''New() create an istance of this class and specify a DB connection
    ''' </summary>
    ''' <returns>
    '''
    ''' </returns>
    Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
        MyBase.New(Connection)
    End Sub

    ''' <summary>
    '''New() create an istance of this class and specify a DB connectionstring
    ''' </summary>
    ''' <returns>
    '''
    ''' </returns>
    Public Sub New(ByVal ConnectionString As String)
        MyBase.New(ConnectionString)
    End Sub

    ''' <summary>
    '''Read from DB table Gcm_article
    ''' </summary>
    ''' <returns>
    '''Return an Gcm_article object
    ''' </returns>
    Public Overrides Function Read(Id As Integer) As Gcm_article
        Dim cls As New Gcm_article

        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = "SELECT * FROM Gcm_article where id = " & Id
            If Not DbTransaction Is Nothing Then myCommand.Transaction = DbTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                cls.id = myReader("id")
                If Not myReader("code") Is DBNull.Value Then
                    cls.code = myReader("code")
                End If
                If Not myReader("désignation") Is DBNull.Value Then
                    cls.désignation = myReader("désignation")
                End If
                If Not myReader("prix") Is DBNull.Value Then
                    cls.prix = myReader("prix")
                End If
                If Not myReader("date_creation") Is DBNull.Value Then
                    cls.date_creation = myReader("date_creation")
                End If
            End If
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function

    ''' <summary>
    '''Save on DB table Gcm_article
    ''' </summary>
    ''' <returns>
    '''Return ID insert in DB
    ''' </returns>
    Public Overrides Function Save(ByRef cls As Gcm_article) As Integer

        Dim Ris As Integer = 0 'in Ris return Insert Id

        If cls.IsChanged Then
            Dim DbCommand As SqlCommand = New SqlCommand()
            Try
                Dim sql As String
                DbCommand.Connection = _cn
                If Not DbTransaction Is Nothing Then DbCommand.Transaction = DbTransaction
                If cls.id = 0 Then
                    sql = "INSERT INTO Gcm_article("
                    sql &= "code,"
                    sql &= "désignation,"
                    sql &= "prix,"
                    sql &= "date_creation"
                    sql &= ") VALUES ("
                    sql &= "@code,"
                    sql &= "@désignation,"
                    sql &= "@prix,"
                    sql &= "@date_creation"
                    sql &= ")"
                Else
                    sql = "UPDATE Gcm_article SET "
                    sql &= "code = @code,"
                    sql &= "désignation = @désignation,"
                    sql &= "prix = @prix,"
                    sql &= "date_creation = @date_creation"
                    sql &= " WHERE id= " & cls.id
                End If
                DbCommand.CommandText = sql
                Dim NomePar As String = String.Empty
                Dim ValuePar As String = String.Empty
                NomePar = "@code"
                ValuePar = cls.code
                DbCommand.Parameters.AddWithValue(NomePar, ValuePar)
                NomePar = "@désignation"
                ValuePar = cls.désignation
                DbCommand.Parameters.AddWithValue(NomePar, ValuePar)
                NomePar = "@prix"
                ValuePar = cls.prix
                DbCommand.Parameters.AddWithValue(NomePar, ValuePar)
                NomePar = "@date_creation"
                If cls.date_creation <> Date.MinValue Then
                    ValuePar = cls.date_creation
                Else
                    ValuePar = "null"
                End If
                DbCommand.Parameters.AddWithValue(NomePar, ValuePar)
                DbCommand.ExecuteNonQuery()

                If cls.id = 0 Then
                    Dim IdInserito As Integer = 0
                    sql = "select @@identity"
                    DbCommand.CommandText = sql
                    IdInserito = DbCommand.ExecuteScalar()
                    cls.id = IdInserito
                    Ris = IdInserito
                Else
                    Ris = cls.id
                End If

                DbCommand.Dispose()
            Catch ex As Exception
                ManageError(ex)
            End Try
        Else
            Ris = cls.id
        End If

        Return Ris
    End Function

    Private Sub DestroyPermanently(Id As Integer)
        Try

            Dim UpdateCommand As SqlCommand = New SqlCommand()
            UpdateCommand.Connection = _cn

            '******IMPORTANT: You can use this commented instruction to make a logical delete .
            '******Replace DELETED Field with your logic deleted field name.
            'Dim Sql As String = "UPDATE Gcm_article SET DELETED=True "
            Dim Sql As String = "DELETE FROM Gcm_article"
            Sql &= " Where id = " & Id

            UpdateCommand.CommandText = Sql
            If Not DbTransaction Is Nothing Then UpdateCommand.Transaction = DbTransaction
            UpdateCommand.ExecuteNonQuery()
            UpdateCommand.Dispose()
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub

    ''' <summary>
    '''Delete from DB table Gcm_article. Accept id of object to delete.
    ''' </summary>
    ''' <returns>
    '''
    ''' </returns>
    Public Overrides Sub Delete(Id As Integer)

        DestroyPermanently(Id)

    End Sub

    ''' <summary>
    '''Delete from DB table Gcm_article. Accept object to delete and optional a List to remove the object from.
    ''' </summary>
    ''' <returns>
    '''
    ''' </returns>
    Public Overrides Sub Delete(ByRef obj As Gcm_article, Optional ByRef ListaObj As List(Of Gcm_article) = Nothing)

        DestroyPermanently(obj.id)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Gcm_article)
        Return FindReal(OrderBy, Parameter)
    End Function

    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Gcm_article)
        Return FindReal("", Parameter)
    End Function

    Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Gcm_article)
        Dim Ls As New List(Of Gcm_article)
        Try

            Dim sql As String = ""
sql ="SELECT id," & _
	"code," & _
	"désignation," & _
	"prix," & _
	"date_creation"
sql &=" from Gcm_article" 
For Each Par As LUNA.LunaSearchParameter In Parameter
	If Not Par Is Nothing Then
		If Sql.IndexOf("WHERE") = -1 Then Sql &= " WHERE " Else Sql &=  " " & Par.LogicOperatorStr & " "
		Sql &= Par.FieldName & " " & Par.SqlOperator & " " & Ap(Par.Value)
	End if
Next

If OrderBy.Length Then Sql &= " ORDER BY " & OrderBy

Ls = GetData(Sql)

Catch ex As Exception
	ManageError(ex)
End Try
Return Ls
End Function

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Gcm_article)
Dim Ls As New List(Of Gcm_article)
Try

            Dim sql As String = ""
            sql = "SELECT id," &
    "code," &
    "désignation," &
    "prix," &
    "date_creation"
            sql &= " from Gcm_article"
            If OrderByField.Length Then
                sql &= " ORDER BY " & OrderByField
            End If

            Ls = GetData(sql, AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function
    Private Function GetData(sql As String, Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of Gcm_article)
        Dim Ls As New List(Of Gcm_article)
        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = sql
            If Not DbTransaction Is Nothing Then myCommand.Transaction = DbTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            If AddEmptyItem Then Ls.Add(New Gcm_article() With {.id = 0, .code = "", .désignation = "", .prix = 0, .date_creation = Nothing})
            While myReader.Read
                Dim classe As New Gcm_article
                If Not myReader("id") Is DBNull.Value Then classe.id = myReader("id")
                If Not myReader("code") Is DBNull.Value Then classe.code = myReader("code")
                If Not myReader("désignation") Is DBNull.Value Then classe.désignation = myReader("désignation")
                If Not myReader("prix") Is DBNull.Value Then classe.prix = myReader("prix")
                If Not myReader("date_creation") Is DBNull.Value Then classe.date_creation = myReader("date_creation")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()
        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function
End Class


