<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuMore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuMore))
        Me.SignInButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ReportBikeButton = New System.Windows.Forms.Button()
        Me.faqButton = New System.Windows.Forms.Button()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SignInButton
        '
        Me.SignInButton.BackgroundImage = CType(resources.GetObject("SignInButton.BackgroundImage"), System.Drawing.Image)
        Me.SignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignInButton.FlatAppearance.BorderSize = 0
        Me.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignInButton.Location = New System.Drawing.Point(213, 48)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(534, 125)
        Me.SignInButton.TabIndex = 3
        Me.SignInButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SignInButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(870, 372)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(136, 127)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(870, 47)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(136, 127)
        Me.BackButton.TabIndex = 5
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ReportBikeButton
        '
        Me.ReportBikeButton.BackgroundImage = CType(resources.GetObject("ReportBikeButton.BackgroundImage"), System.Drawing.Image)
        Me.ReportBikeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ReportBikeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReportBikeButton.FlatAppearance.BorderSize = 0
        Me.ReportBikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReportBikeButton.Location = New System.Drawing.Point(212, 373)
        Me.ReportBikeButton.Name = "ReportBikeButton"
        Me.ReportBikeButton.Size = New System.Drawing.Size(534, 125)
        Me.ReportBikeButton.TabIndex = 6
        Me.ReportBikeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ReportBikeButton.UseVisualStyleBackColor = False
        '
        'faqButton
        '
        Me.faqButton.BackgroundImage = CType(resources.GetObject("faqButton.BackgroundImage"), System.Drawing.Image)
        Me.faqButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.faqButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.faqButton.FlatAppearance.BorderSize = 0
        Me.faqButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.faqButton.Location = New System.Drawing.Point(496, 212)
        Me.faqButton.Name = "faqButton"
        Me.faqButton.Size = New System.Drawing.Size(250, 125)
        Me.faqButton.TabIndex = 7
        Me.faqButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.faqButton.UseVisualStyleBackColor = False
        '
        'ButtonHelp
        '
        Me.ButtonHelp.BackgroundImage = CType(resources.GetObject("ButtonHelp.BackgroundImage"), System.Drawing.Image)
        Me.ButtonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHelp.FlatAppearance.BorderSize = 0
        Me.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHelp.Location = New System.Drawing.Point(213, 212)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(250, 125)
        Me.ButtonHelp.TabIndex = 8
        Me.ButtonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonHelp.UseVisualStyleBackColor = False
        '
        'MenuMore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.faqButton)
        Me.Controls.Add(Me.ReportBikeButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SignInButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuMore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SignInButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents ReportBikeButton As Button
    Friend WithEvents faqButton As Button
    Friend WithEvents ButtonHelp As Button
End Class
