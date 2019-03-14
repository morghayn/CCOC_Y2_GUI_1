<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnBike
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnBike))
        Me.StartTime = New System.Windows.Forms.TextBox()
        Me.FinishTime = New System.Windows.Forms.TextBox()
        Me.FullName = New System.Windows.Forms.TextBox()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.RideFee = New System.Windows.Forms.TextBox()
        Me.Before = New System.Windows.Forms.TextBox()
        Me.After = New System.Windows.Forms.TextBox()
        Me.Debited = New System.Windows.Forms.TextBox()
        Me.TopUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartTime
        '
        Me.StartTime.BackColor = System.Drawing.Color.White
        Me.StartTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StartTime.Enabled = False
        Me.StartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartTime.ForeColor = System.Drawing.Color.Black
        Me.StartTime.Location = New System.Drawing.Point(151, 234)
        Me.StartTime.MaxLength = 35
        Me.StartTime.Name = "StartTime"
        Me.StartTime.Size = New System.Drawing.Size(199, 42)
        Me.StartTime.TabIndex = 0
        Me.StartTime.TabStop = False
        Me.StartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FinishTime
        '
        Me.FinishTime.BackColor = System.Drawing.Color.White
        Me.FinishTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FinishTime.Enabled = False
        Me.FinishTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinishTime.ForeColor = System.Drawing.Color.Black
        Me.FinishTime.Location = New System.Drawing.Point(437, 234)
        Me.FinishTime.MaxLength = 35
        Me.FinishTime.Name = "FinishTime"
        Me.FinishTime.Size = New System.Drawing.Size(199, 42)
        Me.FinishTime.TabIndex = 0
        Me.FinishTime.TabStop = False
        Me.FinishTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FullName
        '
        Me.FullName.BackColor = System.Drawing.Color.White
        Me.FullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FullName.Enabled = False
        Me.FullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName.ForeColor = System.Drawing.Color.Black
        Me.FullName.Location = New System.Drawing.Point(289, 148)
        Me.FullName.MaxLength = 35
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(347, 42)
        Me.FullName.TabIndex = 0
        Me.FullName.TabStop = False
        Me.FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuButton
        '
        Me.MenuButton.BackgroundImage = CType(resources.GetObject("MenuButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.FlatAppearance.BorderSize = 0
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.Location = New System.Drawing.Point(265, 421)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(685, 83)
        Me.MenuButton.TabIndex = 0
        Me.MenuButton.TabStop = False
        Me.MenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'RideFee
        '
        Me.RideFee.BackColor = System.Drawing.Color.White
        Me.RideFee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RideFee.Enabled = False
        Me.RideFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RideFee.ForeColor = System.Drawing.Color.Black
        Me.RideFee.Location = New System.Drawing.Point(534, 319)
        Me.RideFee.MaxLength = 35
        Me.RideFee.Name = "RideFee"
        Me.RideFee.Size = New System.Drawing.Size(99, 42)
        Me.RideFee.TabIndex = 0
        Me.RideFee.TabStop = False
        Me.RideFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Before
        '
        Me.Before.BackColor = System.Drawing.Color.White
        Me.Before.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Before.Enabled = False
        Me.Before.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Before.ForeColor = System.Drawing.Color.Black
        Me.Before.Location = New System.Drawing.Point(912, 165)
        Me.Before.MaxLength = 35
        Me.Before.Name = "Before"
        Me.Before.Size = New System.Drawing.Size(104, 37)
        Me.Before.TabIndex = 0
        Me.Before.TabStop = False
        Me.Before.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'After
        '
        Me.After.BackColor = System.Drawing.Color.White
        Me.After.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.After.Enabled = False
        Me.After.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.After.ForeColor = System.Drawing.Color.Black
        Me.After.Location = New System.Drawing.Point(912, 238)
        Me.After.MaxLength = 35
        Me.After.Name = "After"
        Me.After.Size = New System.Drawing.Size(104, 37)
        Me.After.TabIndex = 0
        Me.After.TabStop = False
        Me.After.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Debited
        '
        Me.Debited.BackColor = System.Drawing.Color.White
        Me.Debited.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Debited.Enabled = False
        Me.Debited.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Debited.ForeColor = System.Drawing.Color.Black
        Me.Debited.Location = New System.Drawing.Point(923, 313)
        Me.Debited.MaxLength = 35
        Me.Debited.Name = "Debited"
        Me.Debited.Size = New System.Drawing.Size(63, 37)
        Me.Debited.TabIndex = 0
        Me.Debited.TabStop = False
        Me.Debited.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TopUp
        '
        Me.TopUp.BackgroundImage = CType(resources.GetObject("TopUp.BackgroundImage"), System.Drawing.Image)
        Me.TopUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TopUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TopUp.FlatAppearance.BorderSize = 0
        Me.TopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopUp.Location = New System.Drawing.Point(129, 304)
        Me.TopUp.Name = "TopUp"
        Me.TopUp.Size = New System.Drawing.Size(219, 72)
        Me.TopUp.TabIndex = 1
        Me.TopUp.TabStop = False
        Me.TopUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TopUp.UseVisualStyleBackColor = False
        '
        'ReturnBike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 543)
        Me.Controls.Add(Me.TopUp)
        Me.Controls.Add(Me.Debited)
        Me.Controls.Add(Me.After)
        Me.Controls.Add(Me.Before)
        Me.Controls.Add(Me.RideFee)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.FullName)
        Me.Controls.Add(Me.FinishTime)
        Me.Controls.Add(Me.StartTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReturnBike"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartTime As TextBox
    Friend WithEvents FinishTime As TextBox
    Friend WithEvents FullName As TextBox
    Friend WithEvents MenuButton As Button
    Friend WithEvents RideFee As TextBox
    Friend WithEvents Before As TextBox
    Friend WithEvents After As TextBox
    Friend WithEvents Debited As TextBox
    Friend WithEvents TopUp As Button
End Class
