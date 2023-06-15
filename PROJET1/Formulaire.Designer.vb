<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulaire
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblDesignation = New System.Windows.Forms.Label()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.lblDateCreation = New System.Windows.Forms.Label()
        Me.lblFormulaire = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(38, 60)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(49, 36)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID"
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
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(308, 60)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(438, 40)
        Me.txtID.TabIndex = 1
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
        'btnAjouter
        '
        Me.btnAjouter.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.Location = New System.Drawing.Point(191, 355)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(151, 39)
        Me.btnAjouter.TabIndex = 2
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.Location = New System.Drawing.Point(445, 355)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(151, 39)
        Me.btnModifier.TabIndex = 2
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.txtPrix)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblFormulaire)
        Me.Controls.Add(Me.lblDateCreation)
        Me.Controls.Add(Me.lblPrix)
        Me.Controls.Add(Me.lblDesignation)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblId)
        Me.Name = "Formulaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents lblDesignation As Label
    Friend WithEvents lblPrix As Label
    Friend WithEvents lblDateCreation As Label
    Friend WithEvents lblFormulaire As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtDesignation As TextBox
    Friend WithEvents txtPrix As TextBox
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
