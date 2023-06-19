Imports PROJET1.LUNA
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Text
#Region "Author"
'Class created with Luna 3.4.0.0
'Author: Diego Lunadei
'Date: 18/06/2023
#End Region

''' <summary>
'''Entity Class for table Gcm_article
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>
Public Class Gcm_article

#Region "Logic Field"

#End Region

#Region "Method"

#End Region

End Class

''' <summary>
'''DAO Class for table Gcm_article
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class Gcm_articleDAO
    ''' <summary>
    ''' unique instance de la dao partagee sur toute l'application.
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared _instance As Gcm_articleDAO = Nothing

    ''' <summary>
    ''' Unique instance de la classe ArticleDAO
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getDao() As Gcm_articleDAO
        If (_instance Is Nothing) Then
            _instance = New Gcm_articleDAO()
        End If
        Return _instance
    End Function

    Private Function GetDataH(ByVal sql As String) As DataTable
        Dim Ls As New DataTable
        Try
            Ls = LunaBaseClassDAO(Of Gcm_article).execSelect(sql, CommandType.Text, Nothing, Nothing, 0, 0, _cn)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Public Function GetAllArticle(ByVal whereClause As String) As DataTable
        Try
            Dim sql As String = ""

            sql = " SELECT code AS Code, designation AS Intitulé ,prix AS [Prix Article] ,date_creation AS [Date creation de l'article], "
            sql += " id AS [numero] "
            sql += " From Article  " & whereClause


            Return GetDataH(sql)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class


''' <summary>
''' Classe controleur de l'objet
''' </summary>
''' <remarks></remarks>
Public Module articleCTRL
    Public Sub articleCTRL()

    End Sub

    ''' <summary>
    '''Save on DB table Article
    ''' </summary>
    ''' <returns>
    '''Return ID insert in DB
    ''' </returns>
    Public Function Save(ByRef cls As Gcm_article) As Integer
        Return Gcm_articleDAO.getDao().Save(cls)
    End Function

    ''' <summary>
    '''Read from DB table Article
    ''' </summary>
    ''' <returns>
    '''Return an Article object
    ''' </returns>
    Public Function Read(ByVal Id As Integer) As Gcm_article
        Return Gcm_articleDAO.getDao().Read(Id)
    End Function

    ''' <summary>
    ''' Retourne un article en fonction de son code
    ''' </summary>
    ''' <param name="code ">String</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getArticleByCode(ByVal code As String) As Gcm_article
        Try
            Dim _article As Gcm_article = New Gcm_article

            Dim parameter As LunaSearchParameter = New LunaSearchParameter("deleted", "False")
            Dim parameter2 As LunaSearchParameter = New LunaSearchParameter("code", code)

            Dim _articles As List(Of Gcm_article) = Find("id", parameter, parameter2)
            If _articles IsNot Nothing And _articles.Count > 0 Then
                _article = _articles(0)
            End If
            Return _article
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Gcm_article)
        Return Gcm_articleDAO.getDao().Find(OrderBy, Parameter)
    End Function

    ''Public Function Find(ByVal Top As Integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Article)
    ''    Return Gcm_articleDAO.getDao().Find(Top, OrderBy, Parameter)
    ''End Function

    Public Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Gcm_article)
        Return Gcm_articleDAO.getDao().Find(Parameter)
    End Function

    Public Function GetAll() As DataTable
        Return Gcm_articleDAO.getDao().GetAll()
    End Function


    Public Function GetAllArticle(_whereClause As String) As DataTable
        Return Gcm_articleDAO.getDao().GetAllArticle(_whereClause)
    End Function


End Module

