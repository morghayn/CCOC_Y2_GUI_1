<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Terms))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.AcceptBox = New System.Windows.Forms.Button()
        Me.TermsNConditions = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
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
        Me.BackButton.TabIndex = 3
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BackButton.UseVisualStyleBackColor = False
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
        Me.ContinueButton.TabIndex = 4
        Me.ContinueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ContinueButton.UseVisualStyleBackColor = False
        '
        'AcceptBox
        '
        Me.AcceptBox.BackgroundImage = CType(resources.GetObject("AcceptBox.BackgroundImage"), System.Drawing.Image)
        Me.AcceptBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AcceptBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AcceptBox.FlatAppearance.BorderSize = 0
        Me.AcceptBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AcceptBox.Location = New System.Drawing.Point(692, 330)
        Me.AcceptBox.Name = "AcceptBox"
        Me.AcceptBox.Size = New System.Drawing.Size(44, 42)
        Me.AcceptBox.TabIndex = 2
        Me.AcceptBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AcceptBox.UseVisualStyleBackColor = False
        '
        'TermsNConditions
        '
        Me.TermsNConditions.BackColor = System.Drawing.Color.White
        Me.TermsNConditions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TermsNConditions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TermsNConditions.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TermsNConditions.ForeColor = System.Drawing.Color.Black
        Me.TermsNConditions.Location = New System.Drawing.Point(340, 134)
        Me.TermsNConditions.Name = "TermsNConditions"
        Me.TermsNConditions.ReadOnly = True
        Me.TermsNConditions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TermsNConditions.Size = New System.Drawing.Size(545, 150)
        Me.TermsNConditions.TabIndex = 1
        Me.TermsNConditions.Text = ""
        '
        'Terms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.TermsNConditions)
        Me.Controls.Add(Me.AcceptBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Terms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents ContinueButton As Button
    Friend WithEvents AcceptBox As Button
    Friend WithEvents TermsNConditions As RichTextBox
End Class
