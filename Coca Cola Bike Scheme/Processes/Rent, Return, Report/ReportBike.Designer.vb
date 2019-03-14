<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportBike
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportBike))
        Me.SerialInput = New System.Windows.Forms.TextBox()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialInput
        '
        Me.SerialInput.BackColor = System.Drawing.Color.White
        Me.SerialInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SerialInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialInput.Location = New System.Drawing.Point(659, 86)
        Me.SerialInput.MaxLength = 7
        Me.SerialInput.Name = "SerialInput"
        Me.SerialInput.Size = New System.Drawing.Size(186, 42)
        Me.SerialInput.TabIndex = 1
        Me.SerialInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.White
        Me.Description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description.Location = New System.Drawing.Point(330, 229)
        Me.Description.MaxLength = 105
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(507, 119)
        Me.Description.TabIndex = 2
        Me.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.MenuButton.TabIndex = 24
        Me.MenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'ReportBike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.SerialInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportBike"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialInput As TextBox
    Friend WithEvents Description As TextBox
    Friend WithEvents MenuButton As Button
End Class
