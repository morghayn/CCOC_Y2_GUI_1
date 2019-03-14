<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataCollect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataCollect))
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.birthDay = New System.Windows.Forms.ComboBox()
        Me.birthMonth = New System.Windows.Forms.ComboBox()
        Me.birthYear = New System.Windows.Forms.ComboBox()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.phoneNumber = New System.Windows.Forms.TextBox()
        Me.emailAddress = New System.Windows.Forms.TextBox()
        Me.addressOne = New System.Windows.Forms.TextBox()
        Me.addressTwo = New System.Windows.Forms.TextBox()
        Me.addressThree = New System.Windows.Forms.TextBox()
        Me.lstCounty = New System.Windows.Forms.ListBox()
        Me.FemaleButton = New System.Windows.Forms.Button()
        Me.MaleButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.lstCountry = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'firstName
        '
        Me.firstName.BackColor = System.Drawing.Color.White
        Me.firstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.Location = New System.Drawing.Point(291, 38)
        Me.firstName.MaxLength = 35
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(194, 33)
        Me.firstName.TabIndex = 0
        Me.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'birthDay
        '
        Me.birthDay.AllowDrop = True
        Me.birthDay.DropDownHeight = 150
        Me.birthDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.birthDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.birthDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthDay.FormattingEnabled = True
        Me.birthDay.IntegralHeight = False
        Me.birthDay.Location = New System.Drawing.Point(691, 81)
        Me.birthDay.MaxLength = 2
        Me.birthDay.Name = "birthDay"
        Me.birthDay.Size = New System.Drawing.Size(43, 26)
        Me.birthDay.TabIndex = 1
        '
        'birthMonth
        '
        Me.birthMonth.AllowDrop = True
        Me.birthMonth.DropDownHeight = 150
        Me.birthMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.birthMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.birthMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthMonth.FormattingEnabled = True
        Me.birthMonth.IntegralHeight = False
        Me.birthMonth.ItemHeight = 20
        Me.birthMonth.Location = New System.Drawing.Point(865, 80)
        Me.birthMonth.MaxLength = 2
        Me.birthMonth.Name = "birthMonth"
        Me.birthMonth.Size = New System.Drawing.Size(43, 28)
        Me.birthMonth.TabIndex = 2
        '
        'birthYear
        '
        Me.birthYear.DropDownHeight = 150
        Me.birthYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.birthYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.birthYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthYear.FormattingEnabled = True
        Me.birthYear.IntegralHeight = False
        Me.birthYear.ItemHeight = 20
        Me.birthYear.Location = New System.Drawing.Point(1010, 80)
        Me.birthYear.MaxLength = 2
        Me.birthYear.Name = "birthYear"
        Me.birthYear.Size = New System.Drawing.Size(69, 28)
        Me.birthYear.TabIndex = 3
        '
        'lastName
        '
        Me.lastName.BackColor = System.Drawing.Color.White
        Me.lastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastName.Location = New System.Drawing.Point(295, 121)
        Me.lastName.MaxLength = 35
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(189, 33)
        Me.lastName.TabIndex = 4
        Me.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'phoneNumber
        '
        Me.phoneNumber.BackColor = System.Drawing.Color.White
        Me.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.phoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNumber.Location = New System.Drawing.Point(227, 291)
        Me.phoneNumber.MaxLength = 15
        Me.phoneNumber.Name = "phoneNumber"
        Me.phoneNumber.Size = New System.Drawing.Size(258, 33)
        Me.phoneNumber.TabIndex = 5
        Me.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'emailAddress
        '
        Me.emailAddress.BackColor = System.Drawing.Color.White
        Me.emailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.emailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailAddress.Location = New System.Drawing.Point(207, 378)
        Me.emailAddress.Name = "emailAddress"
        Me.emailAddress.Size = New System.Drawing.Size(332, 33)
        Me.emailAddress.TabIndex = 6
        Me.emailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'addressOne
        '
        Me.addressOne.BackColor = System.Drawing.Color.White
        Me.addressOne.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.addressOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressOne.Location = New System.Drawing.Point(755, 163)
        Me.addressOne.Margin = New System.Windows.Forms.Padding(0)
        Me.addressOne.MaxLength = 35
        Me.addressOne.Name = "addressOne"
        Me.addressOne.Size = New System.Drawing.Size(319, 24)
        Me.addressOne.TabIndex = 7
        Me.addressOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'addressTwo
        '
        Me.addressTwo.BackColor = System.Drawing.Color.White
        Me.addressTwo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.addressTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTwo.Location = New System.Drawing.Point(754, 195)
        Me.addressTwo.MaxLength = 35
        Me.addressTwo.Name = "addressTwo"
        Me.addressTwo.Size = New System.Drawing.Size(319, 24)
        Me.addressTwo.TabIndex = 8
        Me.addressTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'addressThree
        '
        Me.addressThree.BackColor = System.Drawing.Color.White
        Me.addressThree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.addressThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressThree.Location = New System.Drawing.Point(754, 227)
        Me.addressThree.MaxLength = 35
        Me.addressThree.Name = "addressThree"
        Me.addressThree.Size = New System.Drawing.Size(319, 24)
        Me.addressThree.TabIndex = 9
        Me.addressThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstCounty
        '
        Me.lstCounty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCounty.FormattingEnabled = True
        Me.lstCounty.ItemHeight = 18
        Me.lstCounty.Location = New System.Drawing.Point(659, 309)
        Me.lstCounty.Name = "lstCounty"
        Me.lstCounty.Size = New System.Drawing.Size(170, 72)
        Me.lstCounty.TabIndex = 10
        '
        'FemaleButton
        '
        Me.FemaleButton.BackgroundImage = CType(resources.GetObject("FemaleButton.BackgroundImage"), System.Drawing.Image)
        Me.FemaleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FemaleButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FemaleButton.FlatAppearance.BorderSize = 0
        Me.FemaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FemaleButton.Location = New System.Drawing.Point(248, 196)
        Me.FemaleButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FemaleButton.Name = "FemaleButton"
        Me.FemaleButton.Size = New System.Drawing.Size(129, 49)
        Me.FemaleButton.TabIndex = 0
        Me.FemaleButton.TabStop = False
        Me.FemaleButton.UseVisualStyleBackColor = False
        '
        'MaleButton
        '
        Me.MaleButton.BackgroundImage = CType(resources.GetObject("MaleButton.BackgroundImage"), System.Drawing.Image)
        Me.MaleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MaleButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaleButton.FlatAppearance.BorderSize = 0
        Me.MaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaleButton.Location = New System.Drawing.Point(388, 196)
        Me.MaleButton.Name = "MaleButton"
        Me.MaleButton.Size = New System.Drawing.Size(101, 49)
        Me.MaleButton.TabIndex = 0
        Me.MaleButton.TabStop = False
        Me.MaleButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(92, 448)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(321, 75)
        Me.BackButton.TabIndex = 13
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
        Me.ContinueButton.Location = New System.Drawing.Point(783, 448)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(321, 75)
        Me.ContinueButton.TabIndex = 14
        Me.ContinueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ContinueButton.UseVisualStyleBackColor = False
        '
        'lstCountry
        '
        Me.lstCountry.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCountry.FormattingEnabled = True
        Me.lstCountry.ItemHeight = 18
        Me.lstCountry.Location = New System.Drawing.Point(885, 309)
        Me.lstCountry.Name = "lstCountry"
        Me.lstCountry.Size = New System.Drawing.Size(170, 72)
        Me.lstCountry.TabIndex = 15
        '
        'DataCollect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.lstCountry)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.MaleButton)
        Me.Controls.Add(Me.FemaleButton)
        Me.Controls.Add(Me.lstCounty)
        Me.Controls.Add(Me.addressThree)
        Me.Controls.Add(Me.addressTwo)
        Me.Controls.Add(Me.addressOne)
        Me.Controls.Add(Me.emailAddress)
        Me.Controls.Add(Me.phoneNumber)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.birthYear)
        Me.Controls.Add(Me.birthMonth)
        Me.Controls.Add(Me.birthDay)
        Me.Controls.Add(Me.firstName)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DataCollect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstName As TextBox
    Friend WithEvents birthDay As ComboBox
    Friend WithEvents birthMonth As ComboBox
    Friend WithEvents birthYear As ComboBox
    Friend WithEvents lastName As TextBox
    Friend WithEvents phoneNumber As TextBox
    Friend WithEvents emailAddress As TextBox
    Friend WithEvents addressOne As TextBox
    Friend WithEvents addressTwo As TextBox
    Friend WithEvents addressThree As TextBox
    Friend WithEvents lstCounty As ListBox
    Friend WithEvents FemaleButton As Button
    Friend WithEvents MaleButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents ContinueButton As Button
    Friend WithEvents lstCountry As ListBox
End Class
