Imports System.IO

Public Class LoginScreen


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        If WhichLogin = "RentBike" Then BackgroundImage = Image.FromFile(LoginRentBike)
        If WhichLogin = "ReturnBike" Then BackgroundImage = Image.FromFile(LoginReturnBike)
        If WhichLogin = "Dashboard" Then BackgroundImage = Image.FromFile(LoginDash)
        '
        Dim allButtons As New List(Of Button) From {ContinueButton, BackButton}
        For Each singleButton In allButtons
            singleButton.BackColor = Color.Transparent
            singleButton.FlatAppearance.MouseOverBackColor = Color.Transparent
            AddHandler singleButton.Click, AddressOf Clicks
            AddHandler singleButton.MouseLeave, AddressOf Buttons
            AddHandler singleButton.MouseEnter, AddressOf ButtonHover
        Next
        '
        Dim allTextBx As New List(Of TextBox) _
        From {Username, PIN}
        For Each TextBx In allTextBx
            AddHandler TextBx.KeyPress, AddressOf KeyInput
            AddHandler TextBx.TextChanged, AddressOf ButtonUnlock
        Next
    End Sub
    '
    ' -> Handles All Login Options Rent/Return/Topup/Manager/Maintenance


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.CnstButtons(Button, ButtonUnlock()))
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.CnstButtonHover(Button, ButtonUnlock()))
    End Sub
    '
    ' -> Button Images


    Private Sub Clicks(sender As Object, e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        Dim U As String = Username.Text
        Dim P As String = PIN.Text
        '
        If Button = "ContinueButton" And ButtonUnlock() = True Then
            WipeFile(TempLogins)
            If WhichLogin = "RentBike" Or WhichLogin = "Dashboard" Then WriteData(TempLogins, False, U)
            If WhichLogin = "ReturnBike" Then WriteData(TempLogins, False, U & "," & DateTime.Now.ToString("HH:mm"))
            XConfirmLogin(U, P)
            '
            If LoginApproved = False Then U = ""
            If U = "" Then Username.Text = ""
            If U = "" Then PIN.Text = ""
            If ButtonUnlock() = False Then Exit Sub
            '
            If Not U = "Manager" And Not U = "Maintenance" Then
                If WhichLogin = "RentBike" Then XUserRentStatus(U, "Rent")
                If WhichLogin = "ReturnBike" Then XUserRentStatus(U, "Return")
                If WhichLogin = "RentBike" Then If RentStatus = True Then U = ""
                If WhichLogin = "ReturnBike" Then If RentStatus = False Then U = ""
            End If
            '
            If U = "Manager" And P = "1234" Then
                Manager.Show()
                Close()
            ElseIf U = "Maintenance" And P = "1234" Then
                Maintenance.Show()
                Close()
            ElseIf WhichLogin = "Dashboard" Then
                TopUp.Show()
                Close()
            End If
            '
            If U = "" Then Username.Text = ""
            If U = "" Then PIN.Text = ""
            If ButtonUnlock() = False Then Exit Sub
            If WhichLogin = "RentBike" Then RentBike.Show()
            If WhichLogin = "ReturnBike" Then ReturnBike.Show()
            Close()
        End If
        '
        If Button = "BackButton" Then MainMenu.Show()
        If Button = "BackButton" Then Close()
    End Sub
    '
    ' -> Button Clicks


    Private Sub KeyInput(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim Field As String = CType(sender, TextBox).Name.ToString
        e.Handled = LimitChars(e.KeyChar, Field)
    End Sub
    '
    ' -> Username and PIN
    '
    Private Function ButtonUnlock() As Boolean
        Dim ButtonLock As Boolean = If(PIN.Text.Length = 4 And Not String.IsNullOrEmpty(Username.Text), True, False)
        ContinueButton.BackgroundImage = Image.FromFile(Style.CnstButtons("ContinueButton", ButtonLock))
        Return ButtonLock
    End Function
End Class