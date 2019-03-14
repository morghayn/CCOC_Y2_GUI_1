Imports System.IO

Public Class Manager


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuButton.BackColor = Color.Transparent
        MenuButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        AddHandler MenuButton.MouseLeave, AddressOf Buttons
        AddHandler MenuButton.MouseEnter, AddressOf ButtonHover
        AddHandler MenuButton.Click, AddressOf Clicks

        XGetTotalRevenue()
        TotalRevenue.Text = Cost
    End Sub
    '    Gets Total Revenue and Then Displays Value Retrieved
    ' -> Manager Dashboard Load


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        CType(sender, Button).BackgroundImage = Image.FromFile(BigMenuButton)
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        CType(sender, Button).BackgroundImage = Image.FromFile(BigMenuHover)
    End Sub
    '
    Private Sub Clicks(sender As Object, e As EventArgs)
        MainMenu.Show()
        Close()
    End Sub
    '
    ' -> Button


End Class