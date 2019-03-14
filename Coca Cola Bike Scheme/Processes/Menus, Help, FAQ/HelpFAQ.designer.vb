<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelpFAQ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpFAQ))
        Me.HelpOrFAQBox = New System.Windows.Forms.RichTextBox()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HelpOrFAQBox
        '
        Me.HelpOrFAQBox.BackColor = System.Drawing.Color.White
        Me.HelpOrFAQBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HelpOrFAQBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HelpOrFAQBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpOrFAQBox.ForeColor = System.Drawing.Color.Black
        Me.HelpOrFAQBox.Location = New System.Drawing.Point(289, 140)
        Me.HelpOrFAQBox.Name = "HelpOrFAQBox"
        Me.HelpOrFAQBox.ReadOnly = True
        Me.HelpOrFAQBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.HelpOrFAQBox.Size = New System.Drawing.Size(620, 203)
        Me.HelpOrFAQBox.TabIndex = 1
        Me.HelpOrFAQBox.Text = ""
        '
        'MenuButton
        '
        Me.MenuButton.BackgroundImage = CType(resources.GetObject("MenuButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.FlatAppearance.BorderSize = 0
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.Location = New System.Drawing.Point(256, 420)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(685, 83)
        Me.MenuButton.TabIndex = 2
        Me.MenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'HelpFAQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.HelpOrFAQBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HelpFAQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HelpOrFAQBox As RichTextBox
    Friend WithEvents MenuButton As Button
End Class
