<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager))
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.TotalRevenue = New System.Windows.Forms.TextBox()
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
        'TotalRevenue
        '
        Me.TotalRevenue.BackColor = System.Drawing.Color.White
        Me.TotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TotalRevenue.Enabled = False
        Me.TotalRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalRevenue.ForeColor = System.Drawing.Color.Black
        Me.TotalRevenue.Location = New System.Drawing.Point(709, 237)
        Me.TotalRevenue.MaxLength = 35
        Me.TotalRevenue.Name = "TotalRevenue"
        Me.TotalRevenue.Size = New System.Drawing.Size(135, 37)
        Me.TotalRevenue.TabIndex = 26
        Me.TotalRevenue.TabStop = False
        Me.TotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ManagerDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.TotalRevenue)
        Me.Controls.Add(Me.MenuButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ManagerDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuButton As Button
    Friend WithEvents TotalRevenue As TextBox
End Class
