<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopUp))
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.Balance = New System.Windows.Forms.TextBox()
        Me.TopUpAmount = New System.Windows.Forms.TextBox()
        Me.AddTopUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MenuButton
        '
        Me.MenuButton.BackgroundImage = CType(resources.GetObject("MenuButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.FlatAppearance.BorderSize = 0
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.Location = New System.Drawing.Point(250, 419)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(685, 83)
        Me.MenuButton.TabIndex = 25
        Me.MenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'Balance
        '
        Me.Balance.BackColor = System.Drawing.Color.White
        Me.Balance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Balance.Enabled = False
        Me.Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Balance.ForeColor = System.Drawing.Color.Black
        Me.Balance.Location = New System.Drawing.Point(727, 182)
        Me.Balance.MaxLength = 35
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(103, 42)
        Me.Balance.TabIndex = 26
        Me.Balance.TabStop = False
        Me.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TopUpAmount
        '
        Me.TopUpAmount.BackColor = System.Drawing.Color.White
        Me.TopUpAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TopUpAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopUpAmount.Location = New System.Drawing.Point(540, 294)
        Me.TopUpAmount.MaxLength = 3
        Me.TopUpAmount.Name = "TopUpAmount"
        Me.TopUpAmount.Size = New System.Drawing.Size(93, 42)
        Me.TopUpAmount.TabIndex = 27
        Me.TopUpAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddTopUp
        '
        Me.AddTopUp.BackgroundImage = CType(resources.GetObject("AddTopUp.BackgroundImage"), System.Drawing.Image)
        Me.AddTopUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddTopUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddTopUp.FlatAppearance.BorderSize = 0
        Me.AddTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTopUp.Location = New System.Drawing.Point(705, 274)
        Me.AddTopUp.Name = "AddTopUp"
        Me.AddTopUp.Size = New System.Drawing.Size(167, 79)
        Me.AddTopUp.TabIndex = 28
        Me.AddTopUp.TabStop = False
        Me.AddTopUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AddTopUp.UseVisualStyleBackColor = False
        '
        'UserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.AddTopUp)
        Me.Controls.Add(Me.TopUpAmount)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.MenuButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuButton As Button
    Friend WithEvents Balance As TextBox
    Friend WithEvents TopUpAmount As TextBox
    Friend WithEvents AddTopUp As Button
End Class
