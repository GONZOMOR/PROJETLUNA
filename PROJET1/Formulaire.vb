Imports System.Data.SqlClient
Imports System.IO

Public Class Formulaire


    Dim _Article As New Gcm_article
    Dim cn_serveurCentrale As SqlConnection

    Dim connexionString As String = File.ReadAllLines("config.ini")(0)
    Dim _lstRubriqueArticle As New List(Of Gcm_article)


    Private Shared _instance As Formulaire = Nothing
    Private _code As String
    Private _dtagridArticles As DataGridView
    Dim chargement As Boolean = False
    Dim _dupliquer As Boolean

    Public Shared Function getFrame(Optional ByVal code As String = "", Optional ByRef ListesArticlesDataGridView1 As DataGridView = Nothing) As Formulaire
        If _instance Is Nothing Then
            _instance = New Formulaire(code, ListesArticlesDataGridView1)
        Else
            _instance.Close()
            _instance = New Formulaire(code, ListesArticlesDataGridView1)
        End If
        Return _instance
    End Function
    Public Sub New(Optional ByVal code As String = "", Optional ByRef ListesArticlesDataGridView1 As DataGridView = Nothing)
        _code = code
        _dtagridArticles = ListesArticlesDataGridView1
        InitializeComponent()
    End Sub

    Public Sub setField(ByRef modele As Gcm_article)


        If modele.id > 0 Then

            Me.Text = "Article : [" & txtCode.Text & "] " & txtDesignation.Text

            txtCode.Text = modele.code
            txtDesignation.Text = modele.désignation
            txtPrix.Text = modele.prix
            DateTimePicker1.Text = modele.date_creation


            'loadGrid(modele.code)

            txtCode.Enabled = False

        Else
        End If

    End Sub


    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        ''loadGrid()
        ''Liste_Article.Show()
        ''Me.Close()
        Try
            _Article.code = txtCode.Text.Trim
            _Article.désignation = txtDesignation.Text.Trim
            _Article.prix = txtPrix.Text.Trim
            _Article.date_creation = DateTimePicker1.Text.Trim

            'Try
            '    Dim cn As New SqlConnection(connexionString)
            '    LUNA.LunaContext.Connection = cn
            '    cn.Open()
            '    Save(_Article)
            '    cn.Close()

            'Catch ex As Exception

            'End Try
            If _Article.Save() < 1 Then
                MsgBox("Echec de l'opération de validation!", 1)
                Return
            Else
                Me.Close()

            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Function getFrame() As Liste_Article
        Dim F As New Liste_Article()
        F.Visible = True
        Return F
    End Function
    Private Sub loadGrid()
        Liste_Article.table.Rows.Add(txtCode.Text, txtDesignation.Text, txtPrix.Text, DateTimePicker1.Value, txtID.Text)
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        MessageBox.Show($"{Liste_Article.index}")
        'update()
        'Me.Close()
    End Sub
    Private Sub update()
        Dim newDataRow As DataGridViewRow
        newDataRow.Cells(4).Value = txtID.Text
        newDataRow.Cells(0).Value = txtCode.Text
        newDataRow.Cells(1).Value = txtDesignation.Text
        newDataRow.Cells(2).Value = txtPrix.Text
        newDataRow.Cells(3).Value = DateTimePicker1.Value
        newDataRow = Liste_Article.table.Rows(Liste_Article.index)
    End Sub
End Class
