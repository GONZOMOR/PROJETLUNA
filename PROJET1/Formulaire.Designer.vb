<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulaire
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblDesignation = New System.Windows.Forms.Label()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.lblDateCreation = New System.Windows.Forms.Label()
        Me.lblFormulaire = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(38, 110)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(82, 36)
        Me.lblCode.TabIndex = 0
        Me.lblCode.Text = "Code"
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoSize = True
        Me.lblDesignation.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignation.Location = New System.Drawing.Point(38, 165)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(165, 36)
        Me.lblDesignation.TabIndex = 0
        Me.lblDesignation.Text = "Désignation"
        '
        'lblPrix
        '
        Me.lblPrix.AutoSize = True
        Me.lblPrix.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrix.Location = New System.Drawing.Point(38, 219)
        Me.lblPrix.Name = "lblPrix"
        Me.lblPrix.Size = New System.Drawing.Size(68, 36)
        Me.lblPrix.TabIndex = 0
        Me.lblPrix.Text = "Prix"
        '
        'lblDateCreation
        '
        Me.lblDateCreation.AutoSize = True
        Me.lblDateCreation.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateCreation.Location = New System.Drawing.Point(38, 279)
        Me.lblDateCreation.Name = "lblDateCreation"
        Me.lblDateCreation.Size = New System.Drawing.Size(223, 36)
        Me.lblDateCreation.TabIndex = 0
        Me.lblDateCreation.Text = "Date de création"
        '
        'lblFormulaire
        '
        Me.lblFormulaire.AutoSize = True
        Me.lblFormulaire.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFormulaire.Font = New System.Drawing.Font("Arial", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulaire.Location = New System.Drawing.Point(267, 9)
        Me.lblFormulaire.Name = "lblFormulaire"
        Me.lblFormulaire.Size = New System.Drawing.Size(266, 42)
        Me.lblFormulaire.TabIndex = 0
        Me.lblFormulaire.Text = "FORMULAIRE"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(308, 106)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(438, 40)
        Me.txtCode.TabIndex = 1
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation.Location = New System.Drawing.Point(308, 161)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(438, 40)
        Me.txtDesignation.TabIndex = 1
        '
        'txtPrix
        '
        Me.txtPrix.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrix.Location = New System.Drawing.Point(308, 215)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(438, 40)
        Me.txtPrix.TabIndex = 1
        '
        'btnValider
        '
        Me.btnValider.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.Location = New System.Drawing.Point(308, 347)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(151, 39)
        Me.btnValider.TabIndex = 2
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(308, 275)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(438, 40)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Formulaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 446)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.txtPrix)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblFormulaire)
        Me.Controls.Add(Me.lblDateCreation)
        Me.Controls.Add(Me.lblPrix)
        Me.Controls.Add(Me.lblDesignation)
        Me.Controls.Add(Me.lblCode)
        Me.Name = "Formulaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire"
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub
    Friend WithEvents lblCode As Label
    Friend WithEvents lblDesignation As Label
    Friend WithEvents lblPrix As Label
    Friend WithEvents lblDateCreation As Label
    Friend WithEvents lblFormulaire As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtDesignation As TextBox
    Friend WithEvents txtPrix As TextBox
    Friend WithEvents btnValider As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
