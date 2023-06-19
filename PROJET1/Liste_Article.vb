Public Class Liste_Article
    Public index As Integer
    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Dim form As Formulaire = getFramebtnModifier()
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
        fo.txtID.Text = selectedRow.Cells(4).Value.ToString()
        fo.txtCode.Text = selectedRow.Cells(0).Value.ToString()
        fo.txtDesignation.Text = selectedRow.Cells(1).Value.ToString()
        fo.txtPrix.Text = selectedRow.Cells(2).Value.ToString()
        fo.DateTimePicker1.Value = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim form As Formulaire = getFrame()
        form.btnModifier.Enabled = False
    End Sub

    Private Sub Table_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles table.CellClick
        'getFrame()
        'setField(e)
    End Sub
End Class