<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateLogin))
        Me.Username = New System.Windows.Forms.TextBox()
        Me.PIN = New System.Windows.Forms.TextBox()
        Me.ConfirmPIN = New System.Windows.Forms.TextBox()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.White
        Me.Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(614, 136)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(229, 42)
        Me.Username.TabIndex = 1
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PIN
        '
        Me.PIN.BackColor = System.Drawing.Color.White
        Me.PIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PIN.Location = New System.Drawing.Point(646, 229)
        Me.PIN.MaxLength = 4
        Me.PIN.Name = "PIN"
        Me.PIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PIN.Size = New System.Drawing.Size(197, 42)
        Me.PIN.TabIndex = 2
        Me.PIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ConfirmPIN
        '
        Me.ConfirmPIN.BackColor = System.Drawing.Color.White
        Me.ConfirmPIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConfirmPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPIN.Location = New System.Drawing.Point(646, 321)
        Me.ConfirmPIN.MaxLength = 4
        Me.ConfirmPIN.Name = "ConfirmPIN"
        Me.ConfirmPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPIN.Size = New System.Drawing.Size(197, 42)
        Me.ConfirmPIN.TabIndex = 4
        Me.ConfirmPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContinueButton
        '
        Me.ContinueButton.BackgroundImage = CType(resources.GetObject("ContinueButton.BackgroundImage"), System.Drawing.Image)
        Me.ContinueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ContinueButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ContinueButton.FlatAppearance.BorderSize = 0
        Me.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContinueButton.Location = New System.Drawing.Point(634, 421)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(357, 83)
        Me.ContinueButton.TabIndex = 15
        Me.ContinueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ContinueButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(248, 421)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(357, 83)
        Me.BackButton.TabIndex = 16
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'LoginTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.ConfirmPIN)
        Me.Controls.Add(Me.PIN)
        Me.Controls.Add(Me.Username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginTemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Username As TextBox
    Friend WithEvents PIN As TextBox
    Friend WithEvents ConfirmPIN As TextBox
    Friend WithEvents ContinueButton As Button
    Friend WithEvents BackButton As Button
End Class
