Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.IO
Public Class Liste_Article
    Public index As Integer
    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        index = table.CurrentCell.RowIndex
        Dim selectedRow As DataGridViewRow = table.Rows(index)
        Dim str As String = selectedRow.Cells(4).Value.ToString()
        Dim F As New Formulaire(str)
    End Sub

    Private Function getFrame() As Formulaire
        Dim F As New Formulaire()
        F.ShowDialog()
        Return F
    End Function
    Private Function getFramebtnModifier() As Formulaire
        Dim F As New Formulaire()
        F.ShowDialog()
        setField(F)
        Return F
    End Function
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
        'getFrame()
        'setField(e)
    End Sub
    Private Sub loadGrid()
        Try
            Dim connexionString As String = File.ReadAllLines("config.ini")(0)
            LUNA.LunaContext.DateFormat = File.ReadAllLines("config.ini")(2)
            Dim cn As New SqlConnection(connexionString)
            LUNA.LunaContext.Connection = cn
            cn.Open()
            table.DataSource = GetAll()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadGrid()
    End Sub
End Class