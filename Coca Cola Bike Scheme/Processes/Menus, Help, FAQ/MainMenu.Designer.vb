<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MoreButton = New System.Windows.Forms.Button()
        Me.SignUpButton = New System.Windows.Forms.Button()
        Me.RentBikeButton = New System.Windows.Forms.Button()
        Me.ReturnBikeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(870, 373)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(136, 127)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'MoreButton
        '
        Me.MoreButton.BackgroundImage = CType(resources.GetObject("MoreButton.BackgroundImage"), System.Drawing.Image)
        Me.MoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MoreButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MoreButton.FlatAppearance.BorderSize = 0
        Me.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MoreButton.Location = New System.Drawing.Point(870, 46)
        Me.MoreButton.Name = "MoreButton"
        Me.MoreButton.Size = New System.Drawing.Size(136, 127)
        Me.MoreButton.TabIndex = 1
        Me.MoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MoreButton.UseVisualStyleBackColor = False
        '
        'SignUpButton
        '
        Me.SignUpButton.BackgroundImage = CType(resources.GetObject("SignUpButton.BackgroundImage"), System.Drawing.Image)
        Me.SignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignUpButton.FlatAppearance.BorderSize = 0
        Me.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignUpButton.Location = New System.Drawing.Point(213, 48)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(534, 125)
        Me.SignUpButton.TabIndex = 2
        Me.SignUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SignUpButton.UseVisualStyleBackColor = False
        '
        'RentBikeButton
        '
        Me.RentBikeButton.BackgroundImage = CType(resources.GetObject("RentBikeButton.BackgroundImage"), System.Drawing.Image)
        Me.RentBikeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RentBikeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RentBikeButton.FlatAppearance.BorderSize = 0
        Me.RentBikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RentBikeButton.Location = New System.Drawing.Point(212, 212)
        Me.RentBikeButton.Name = "RentBikeButton"
        Me.RentBikeButton.Size = New System.Drawing.Size(534, 125)
        Me.RentBikeButton.TabIndex = 3
        Me.RentBikeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RentBikeButton.UseVisualStyleBackColor = False
        '
        'ReturnBikeButton
        '
        Me.ReturnBikeButton.BackgroundImage = CType(resources.GetObject("ReturnBikeButton.BackgroundImage"), System.Drawing.Image)
        Me.ReturnBikeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ReturnBikeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnBikeButton.FlatAppearance.BorderSize = 0
        Me.ReturnBikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnBikeButton.Location = New System.Drawing.Point(212, 373)
        Me.ReturnBikeButton.Name = "ReturnBikeButton"
        Me.ReturnBikeButton.Size = New System.Drawing.Size(534, 125)
        Me.ReturnBikeButton.TabIndex = 4
        Me.ReturnBikeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ReturnBikeButton.UseVisualStyleBackColor = False
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.ReturnBikeButton)
        Me.Controls.Add(Me.RentBikeButton)
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.MoreButton)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents MoreButton As Button
    Friend WithEvents SignUpButton As Button
    Friend WithEvents RentBikeButton As Button
    Friend WithEvents ReturnBikeButton As Button
End Class
