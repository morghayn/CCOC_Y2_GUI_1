<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentBike
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentBike))
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.StationList = New System.Windows.Forms.ListBox()
        Me.FullName = New System.Windows.Forms.Label()
        Me.BikeQuantity = New System.Windows.Forms.ListBox()
        Me.Available = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ContinueButton
        '
        Me.ContinueButton.BackgroundImage = CType(resources.GetObject("ContinueButton.BackgroundImage"), System.Drawing.Image)
        Me.ContinueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ContinueButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ContinueButton.FlatAppearance.BorderSize = 0
        Me.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContinueButton.Location = New System.Drawing.Point(679, 424)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(357, 83)
        Me.ContinueButton.TabIndex = 16
        Me.ContinueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ContinueButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(170, 425)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(357, 83)
        Me.BackButton.TabIndex = 17
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'StationList
        '
        Me.StationList.AllowDrop = True
        Me.StationList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StationList.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StationList.FormattingEnabled = True
        Me.StationList.ItemHeight = 37
        Me.StationList.Location = New System.Drawing.Point(355, 183)
        Me.StationList.Name = "StationList"
        Me.StationList.Size = New System.Drawing.Size(418, 37)
        Me.StationList.TabIndex = 18
        '
        'FullName
        '
        Me.FullName.AutoSize = True
        Me.FullName.BackColor = System.Drawing.Color.Transparent
        Me.FullName.Font = New System.Drawing.Font("Rockwell", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName.ForeColor = System.Drawing.Color.Black
        Me.FullName.Location = New System.Drawing.Point(589, 52)
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(376, 59)
        Me.FullName.TabIndex = 21
        Me.FullName.Text = "GetFullname()"
        '
        'BikeQuantity
        '
        Me.BikeQuantity.AllowDrop = True
        Me.BikeQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BikeQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BikeQuantity.FormattingEnabled = True
        Me.BikeQuantity.ItemHeight = 37
        Me.BikeQuantity.Location = New System.Drawing.Point(194, 294)
        Me.BikeQuantity.Name = "BikeQuantity"
        Me.BikeQuantity.Size = New System.Drawing.Size(69, 37)
        Me.BikeQuantity.TabIndex = 22
        '
        'Available
        '
        Me.Available.AutoSize = True
        Me.Available.BackColor = System.Drawing.Color.Transparent
        Me.Available.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Available.ForeColor = System.Drawing.Color.Black
        Me.Available.Location = New System.Drawing.Point(890, 189)
        Me.Available.Name = "Available"
        Me.Available.Size = New System.Drawing.Size(36, 39)
        Me.Available.TabIndex = 23
        Me.Available.Text = "0"
        Me.Available.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RentBike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.Available)
        Me.Controls.Add(Me.BikeQuantity)
        Me.Controls.Add(Me.FullName)
        Me.Controls.Add(Me.StationList)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RentBike"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContinueButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents StationList As ListBox
    Friend WithEvents FullName As Label
    Friend WithEvents BikeQuantity As ListBox
    Friend WithEvents Available As Label
End Class
