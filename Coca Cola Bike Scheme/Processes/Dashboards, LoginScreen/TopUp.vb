Imports System.IO

Public Class TopUp


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim allButtons As New List(Of Button) From {MenuButton, AddTopUp}
        For Each singleButton In allButtons
            singleButton.BackColor = Color.Transparent
            singleButton.FlatAppearance.MouseOverBackColor = Color.Transparent
            AddHandler singleButton.MouseLeave, AddressOf Buttons
            AddHandler singleButton.MouseEnter, AddressOf ButtonHover
            AddHandler singleButton.Click, AddressOf Clicks
        Next
        '
        Balance.Text = XGetBalance()
    End Sub
    '
    '    Retrieves balance
    ' -> UserDashboard Load


    Private Sub Clicks(sender As Object, e As EventArgs)
        Dim x As String = CType(sender, Button).Name.ToString
        '
        If x = "AddTopUp" Then
            Cost = 0
            If Not String.IsNullOrEmpty(TopUpAmount.Text) Then Cost = TopUpAmount.Text
            '
            IncreaseBalance = True
            XUpdateBalance()
            TopUpAmount.Text = ""
            Balance.Text = XGetBalance()
        End If
        '
        If x = "MenuButton" Then MenuMore.Show()
        If x = "MenuButton" Then Close()
    End Sub
    '
    ' -> Button Click


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.UsrDasButton(Button))
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.UsrDasButtonHover(Button))
    End Sub
    '
    ' -> Button Images


    Private Sub KeyInput(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TopUpAmount.KeyPress
        e.Handled = LimitChars(e.KeyChar, "NUM")
    End Sub


End Class