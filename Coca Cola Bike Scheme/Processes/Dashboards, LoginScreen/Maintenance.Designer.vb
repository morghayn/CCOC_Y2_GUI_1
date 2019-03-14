<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maintenance))
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.BrokenBikes = New System.Windows.Forms.ListBox()
        Me.Description = New System.Windows.Forms.RichTextBox()
        Me.StationsUnderFive = New System.Windows.Forms.ListBox()
        Me.Repaired = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MenuButton
        '
        Me.MenuButton.BackgroundImage = CType(resources.GetObject("MenuButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.FlatAppearance.BorderSize = 0
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.Location = New System.Drawing.Point(257, 419)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(685, 83)
        Me.MenuButton.TabIndex = 25
        Me.MenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'BrokenBikes
        '
        Me.BrokenBikes.AllowDrop = True
        Me.BrokenBikes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BrokenBikes.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrokenBikes.FormattingEnabled = True
        Me.BrokenBikes.ItemHeight = 47
        Me.BrokenBikes.Location = New System.Drawing.Point(472, 150)
        Me.BrokenBikes.Name = "BrokenBikes"
        Me.BrokenBikes.Size = New System.Drawing.Size(230, 94)
        Me.BrokenBikes.TabIndex = 1
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.White
        Me.Description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Description.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description.ForeColor = System.Drawing.Color.Black
        Me.Description.Location = New System.Drawing.Point(816, 146)
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Description.Size = New System.Drawing.Size(263, 198)
        Me.Description.TabIndex = 4
        Me.Description.Text = ""
        '
        'StationsUnderFive
        '
        Me.StationsUnderFive.AllowDrop = True
        Me.StationsUnderFive.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StationsUnderFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StationsUnderFive.FormattingEnabled = True
        Me.StationsUnderFive.ItemHeight = 31
        Me.StationsUnderFive.Location = New System.Drawing.Point(119, 184)
        Me.StationsUnderFive.MultiColumn = True
        Me.StationsUnderFive.Name = "StationsUnderFive"
        Me.StationsUnderFive.Size = New System.Drawing.Size(247, 155)
        Me.StationsUnderFive.TabIndex = 3
        '
        'Repaired
        '
        Me.Repaired.BackgroundImage = CType(resources.GetObject("Repaired.BackgroundImage"), System.Drawing.Image)
        Me.Repaired.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Repaired.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Repaired.FlatAppearance.BorderSize = 0
        Me.Repaired.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Repaired.Location = New System.Drawing.Point(446, 294)
        Me.Repaired.Name = "Repaired"
        Me.Repaired.Size = New System.Drawing.Size(287, 79)
        Me.Repaired.TabIndex = 2
        Me.Repaired.TabStop = False
        Me.Repaired.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Repaired.UseVisualStyleBackColor = False
        '
        'Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.Repaired)
        Me.Controls.Add(Me.StationsUnderFive)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.BrokenBikes)
        Me.Controls.Add(Me.MenuButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignIn"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuButton As Button
    Friend WithEvents BrokenBikes As ListBox
    Friend WithEvents Description As RichTextBox
    Friend WithEvents StationsUnderFive As ListBox
    Friend WithEvents Repaired As Button
End Class
