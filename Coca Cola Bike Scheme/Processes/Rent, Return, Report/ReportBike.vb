Imports System.IO

Public Class ReportBike


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuButton.BackColor = Color.Transparent
        MenuButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        AddHandler MenuButton.MouseLeave, AddressOf Buttons
        AddHandler MenuButton.MouseEnter, AddressOf ButtonHover
        AddHandler MenuButton.Click, AddressOf Clicks
    End Sub
    '
    ' -> Report Bike Load


    Private Sub DescriptionLtrs(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Description.KeyPress
        e.Handled = LimitChars(e.KeyChar, "TextField")
        If e.Handled = True Then e.Handled = If(Asc(e.KeyChar) = 32, False, True)
    End Sub
    '
    ' -> Limiting Key Input For Description


    Private Sub SerialLtrs(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles SerialInput.KeyPress
        e.Handled = LimitChars(e.KeyChar, "Address")
        If e.Handled = True Then e.Handled = If(Asc(e.KeyChar) = 32, False, True)
    End Sub
    '
    ' -> Limiting Key Input For Description


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        CType(sender, Button).BackgroundImage = Image.FromFile(BigMenuButton)
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        CType(sender, Button).BackgroundImage = Image.FromFile(BigMenuHover)
    End Sub
    '
    Private Sub Clicks(sender As Object, e As EventArgs)
        Dim x As String = SerialInput.Text
        Dim y As String = Description.Text
        If String.IsNullOrEmpty(x) Then x = "BIKE301"
        WipeFile(TempData)
        XLockBike(x, y)
        '
        MenuMore.Show()
        Close()
    End Sub
    '
    ' -> Button


End Class