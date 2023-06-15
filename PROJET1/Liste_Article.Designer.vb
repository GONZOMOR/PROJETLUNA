<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Article
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.table = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Désignation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_création = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        CType(Me.table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'table
        '
        Me.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.Désignation, Me.Prix, Me.Date_création, Me.id})
        Me.table.Location = New System.Drawing.Point(1, 1)
        Me.table.Name = "table"
        Me.table.Size = New System.Drawing.Size(544, 292)
        Me.table.TabIndex = 0
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        '
        'Désignation
        '
        Me.Désignation.HeaderText = "Désignation"
        Me.Désignation.Name = "Désignation"
        '
        'Prix
        '
        Me.Prix.HeaderText = "Prix"
        Me.Prix.Name = "Prix"
        '
        'Date_création
        '
        Me.Date_création.HeaderText = "Date de création"
        Me.Date_création.Name = "Date_création"
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'btnAjouter
        '
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.Location = New System.Drawing.Point(83, 319)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(137, 38)
        Me.btnAjouter.TabIndex = 1
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.Location = New System.Drawing.Point(333, 319)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(137, 38)
        Me.btnModifier.TabIndex = 1
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'Liste_Article
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 385)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.table)
        Me.Name = "Liste_Article"
        Me.Text = "Liste_Article"
        CType(Me.table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents table As DataGridView
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Désignation As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents Date_création As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
End Class
