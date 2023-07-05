Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.IO
Public Class Liste_Article
    Dim _Article As New Gcm_article
    Public index As Integer = -1
    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        If index < 0 Then
            MessageBox.Show("Veuillez selectionner la ligne que vous voulez modifier!")
        Else
            Dim F As New Formulaire(, table)
            F._Article = _Article
            F.ShowDialog()
        End If
    End Sub
    Private Sub setField(fo As Formulaire)
        index = table.CurrentCell.RowIndex
        Dim selectedRow As DataGridViewRow = table.Rows(index)
        fo.txtCode.Text = selectedRow.Cells(0).Value.ToString()
        fo.txtDesignation.Text = selectedRow.Cells(1).Value.ToString()
        fo.txtPrix.Text = selectedRow.Cells(2).Value.ToString()
        fo.DateTimePicker1.Value = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim F As New Formulaire()
        F.ShowDialog()
    End Sub

    Private Sub Table_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table.CellClick
        index = table.CurrentCell.RowIndex
        Dim selectedRow As DataGridViewRow = table.Rows(index)
        _Article = getArticle(Int(selectedRow.Cells(0).Value))
        'MessageBox.Show(_Article.id.ToString())
    End Sub
    Public Sub loadGrid()
        Try
            Dim connexionString As String = File.ReadAllLines("config.ini")(0)
            LUNA.LunaContext.DateFormat = File.ReadAllLines("config.ini")(2)
            Dim cn As New SqlConnection(connexionString)
            LUNA.LunaContext.Connection = cn
            cn.Open()
            table.DataSource = GetAll()
            'cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        loadGrid()
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If index < 0 Then
            MessageBox.Show("Veuillez selectionner la ligne que vous voulez supprimer!")
        Else
            Try
                Dim connexionString As String = File.ReadAllLines("config.ini")(0)
                LUNA.LunaContext.DateFormat = File.ReadAllLines("config.ini")(2)
                Dim cn As New SqlConnection(connexionString)
                LUNA.LunaContext.Connection = cn
                cn.Open()
                Delete(_Article)
                'cn.Close()
                load()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

        End If
    End Sub
    Private Sub Liste_Article_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadGrid()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim clause As String = "WHERE code LIKE '%" & TextBox1.Text & "%'"
            Dim connexionString As String = File.ReadAllLines("config.ini")(0)
            LUNA.LunaContext.DateFormat = File.ReadAllLines("config.ini")(2)
            Dim cn As New SqlConnection(connexionString)
            LUNA.LunaContext.Connection = cn
            cn.Open()
            table.DataSource = GetAllArticle(clause)
            'cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        'TryCast(table.DataSource, DataTable).DefaultView.RowFilter =
        '    String.Format("Code LIKE '" & TextBox1.Text & " %'")
    End Sub
    Public Sub load()
        Try
            Dim connexionString As String = File.ReadAllLines("config.ini")(0)
            LUNA.LunaContext.DateFormat = File.ReadAllLines("config.ini")(2)
            Dim cn As New SqlConnection(connexionString)
            LUNA.LunaContext.Connection = cn
            cn.Open()
            table.DataSource = GetLoad()
            'cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class