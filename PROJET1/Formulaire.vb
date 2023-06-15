Public Class Formulaire
    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        loadGrid()
        Liste_Article.Show()
        Me.Close()
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
