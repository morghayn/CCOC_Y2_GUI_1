<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payments))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.Digits = New System.Windows.Forms.TextBox()
        Me.CodeOne = New System.Windows.Forms.TextBox()
        Me.CodeTwo = New System.Windows.Forms.TextBox()
        Me.CodeThree = New System.Windows.Forms.TextBox()
        Me.ExpMonth = New System.Windows.Forms.ListBox()
        Me.ExpYear = New System.Windows.Forms.ListBox()
        Me.AnnualBox = New System.Windows.Forms.Button()
        Me.ThreeDayBox = New System.Windows.Forms.Button()
        Me.DepositBox = New System.Windows.Forms.Button()
        Me.TopUpAmount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(61, 422)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(357, 83)
        Me.BackButton.TabIndex = 20
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
        Me.ContinueButton.Location = New System.Drawing.Point(747, 422)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(357, 83)
        Me.ContinueButton.TabIndex = 19
        Me.ContinueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ContinueButton.UseVisualStyleBackColor = False
        '
        'Digits
        '
        Me.Digits.BackColor = System.Drawing.Color.White
        Me.Digits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Digits.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Digits.Location = New System.Drawing.Point(295, 137)
        Me.Digits.MaxLength = 16
        Me.Digits.Name = "Digits"
        Me.Digits.Size = New System.Drawing.Size(361, 42)
        Me.Digits.TabIndex = 1
        Me.Digits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CodeOne
        '
        Me.CodeOne.BackColor = System.Drawing.Color.White
        Me.CodeOne.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodeOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeOne.Location = New System.Drawing.Point(408, 323)
        Me.CodeOne.MaxLength = 1
        Me.CodeOne.Name = "CodeOne"
        Me.CodeOne.Size = New System.Drawing.Size(61, 42)
        Me.CodeOne.TabIndex = 4
        Me.CodeOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CodeTwo
        '
        Me.CodeTwo.BackColor = System.Drawing.Color.White
        Me.CodeTwo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodeTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeTwo.Location = New System.Drawing.Point(496, 323)
        Me.CodeTwo.MaxLength = 1
        Me.CodeTwo.Name = "CodeTwo"
        Me.CodeTwo.Size = New System.Drawing.Size(61, 42)
        Me.CodeTwo.TabIndex = 5
        Me.CodeTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CodeThree
        '
        Me.CodeThree.BackColor = System.Drawing.Color.White
        Me.CodeThree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodeThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeThree.Location = New System.Drawing.Point(583, 323)
        Me.CodeThree.MaxLength = 1
        Me.CodeThree.Name = "CodeThree"
        Me.CodeThree.Size = New System.Drawing.Size(61, 42)
        Me.CodeThree.TabIndex = 6
        Me.CodeThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExpMonth
        '
        Me.ExpMonth.AllowDrop = True
        Me.ExpMonth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ExpMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpMonth.FormattingEnabled = True
        Me.ExpMonth.ItemHeight = 37
        Me.ExpMonth.Location = New System.Drawing.Point(352, 233)
        Me.ExpMonth.Name = "ExpMonth"
        Me.ExpMonth.Size = New System.Drawing.Size(144, 37)
        Me.ExpMonth.TabIndex = 2
        '
        'ExpYear
        '
        Me.ExpYear.AllowDrop = True
        Me.ExpYear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ExpYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpYear.FormattingEnabled = True
        Me.ExpYear.ItemHeight = 37
        Me.ExpYear.Location = New System.Drawing.Point(513, 233)
        Me.ExpYear.Name = "ExpYear"
        Me.ExpYear.Size = New System.Drawing.Size(144, 37)
        Me.ExpYear.TabIndex = 3
        '
        'AnnualBox
        '
        Me.AnnualBox.BackgroundImage = CType(resources.GetObject("AnnualBox.BackgroundImage"), System.Drawing.Image)
        Me.AnnualBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AnnualBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnnualBox.FlatAppearance.BorderSize = 0
        Me.AnnualBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnnualBox.Location = New System.Drawing.Point(1006, 204)
        Me.AnnualBox.Name = "AnnualBox"
        Me.AnnualBox.Size = New System.Drawing.Size(44, 42)
        Me.AnnualBox.TabIndex = 21
        Me.AnnualBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AnnualBox.UseVisualStyleBackColor = False
        '
        'ThreeDayBox
        '
        Me.ThreeDayBox.BackgroundImage = CType(resources.GetObject("ThreeDayBox.BackgroundImage"), System.Drawing.Image)
        Me.ThreeDayBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ThreeDayBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ThreeDayBox.FlatAppearance.BorderSize = 0
        Me.ThreeDayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ThreeDayBox.Location = New System.Drawing.Point(1006, 255)
        Me.ThreeDayBox.Name = "ThreeDayBox"
        Me.ThreeDayBox.Size = New System.Drawing.Size(44, 42)
        Me.ThreeDayBox.TabIndex = 22
        Me.ThreeDayBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ThreeDayBox.UseVisualStyleBackColor = False
        '
        'DepositBox
        '
        Me.DepositBox.BackgroundImage = CType(resources.GetObject("DepositBox.BackgroundImage"), System.Drawing.Image)
        Me.DepositBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DepositBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DepositBox.FlatAppearance.BorderSize = 0
        Me.DepositBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DepositBox.Location = New System.Drawing.Point(1006, 328)
        Me.DepositBox.Name = "DepositBox"
        Me.DepositBox.Size = New System.Drawing.Size(44, 42)
        Me.DepositBox.TabIndex = 23
        Me.DepositBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.DepositBox.UseVisualStyleBackColor = False
        '
        'TopUpAmount
        '
        Me.TopUpAmount.BackColor = System.Drawing.Color.White
        Me.TopUpAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TopUpAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopUpAmount.Location = New System.Drawing.Point(969, 133)
        Me.TopUpAmount.MaxLength = 3
        Me.TopUpAmount.Name = "TopUpAmount"
        Me.TopUpAmount.Size = New System.Drawing.Size(84, 33)
        Me.TopUpAmount.TabIndex = 24
        Me.TopUpAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PaymentTemp
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.TopUpAmount)
        Me.Controls.Add(Me.DepositBox)
        Me.Controls.Add(Me.ThreeDayBox)
        Me.Controls.Add(Me.AnnualBox)
        Me.Controls.Add(Me.ExpYear)
        Me.Controls.Add(Me.ExpMonth)
        Me.Controls.Add(Me.CodeThree)
        Me.Controls.Add(Me.CodeTwo)
        Me.Controls.Add(Me.CodeOne)
        Me.Controls.Add(Me.Digits)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PaymentTemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents ContinueButton As Button
    Friend WithEvents Digits As TextBox
    Friend WithEvents CodeOne As TextBox
    Friend WithEvents CodeTwo As TextBox
    Friend WithEvents CodeThree As TextBox
    Friend WithEvents ExpMonth As ListBox
    Friend WithEvents ExpYear As ListBox
    Friend WithEvents AnnualBox As Button
    Friend WithEvents ThreeDayBox As Button
    Friend WithEvents DepositBox As Button
    Friend WithEvents TopUpAmount As TextBox
End Class
