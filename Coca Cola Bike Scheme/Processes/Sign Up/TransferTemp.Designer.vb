<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransferTemp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferTemp))
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.usernameBox = New System.Windows.Forms.TextBox()
        Me.chargedBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ContinueButton
        '
        Me.ContinueButton.BackgroundImage = CType(resources.GetObject("ContinueButton.BackgroundImage"), System.Drawing.Image)
        Me.ContinueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ContinueButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ContinueButton.FlatAppearance.BorderSize = 0
        Me.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContinueButton.Location = New System.Drawing.Point(248, 421)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(743, 83)
        Me.ContinueButton.TabIndex = 20
        Me.ContinueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ContinueButton.UseVisualStyleBackColor = False
        '
        'nameBox
        '
        Me.nameBox.BackColor = System.Drawing.Color.White
        Me.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nameBox.Enabled = False
        Me.nameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameBox.ForeColor = System.Drawing.Color.Black
        Me.nameBox.Location = New System.Drawing.Point(490, 145)
        Me.nameBox.MaxLength = 35
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(385, 42)
        Me.nameBox.TabIndex = 22
        Me.nameBox.TabStop = False
        Me.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'usernameBox
        '
        Me.usernameBox.BackColor = System.Drawing.Color.White
        Me.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usernameBox.Enabled = False
        Me.usernameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameBox.ForeColor = System.Drawing.Color.Black
        Me.usernameBox.Location = New System.Drawing.Point(580, 235)
        Me.usernameBox.MaxLength = 35
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(295, 42)
        Me.usernameBox.TabIndex = 23
        Me.usernameBox.TabStop = False
        Me.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chargedBox
        '
        Me.chargedBox.BackColor = System.Drawing.Color.White
        Me.chargedBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chargedBox.Enabled = False
        Me.chargedBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chargedBox.ForeColor = System.Drawing.Color.Black
        Me.chargedBox.Location = New System.Drawing.Point(720, 324)
        Me.chargedBox.MaxLength = 35
        Me.chargedBox.Name = "chargedBox"
        Me.chargedBox.Size = New System.Drawing.Size(128, 42)
        Me.chargedBox.TabIndex = 24
        Me.chargedBox.TabStop = False
        Me.chargedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TransferTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.chargedBox)
        Me.Controls.Add(Me.usernameBox)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.ContinueButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransferTemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContinueButton As Button
    Friend WithEvents nameBox As TextBox
    Friend WithEvents usernameBox As TextBox
    Friend WithEvents chargedBox As TextBox
End Class
