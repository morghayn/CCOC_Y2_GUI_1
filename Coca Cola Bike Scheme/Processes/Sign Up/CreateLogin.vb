Imports System.IO

Public Class CreateLogin


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim allButtons As New List(Of Button) _
        From {ContinueButton, BackButton}
        For Each singleButton In allButtons
            singleButton.BackColor = Color.Transparent
            singleButton.FlatAppearance.MouseOverBackColor = Color.Transparent
            AddHandler singleButton.Click, AddressOf Clicks
            AddHandler singleButton.MouseLeave, AddressOf Buttons
            AddHandler singleButton.MouseEnter, AddressOf ButtonHover
        Next
        '
        Dim allTextBx As New List(Of TextBox) _
        From {Username, PIN, ConfirmPIN}
        For Each TextBx In allTextBx
            AddHandler TextBx.TextChanged, AddressOf CheckPin
            AddHandler TextBx.KeyPress, AddressOf KeyInput
        Next
    End Sub
    '
    ' -> LoginTemp Load


    Private Sub Clicks(sender As Object, e As EventArgs)
        If CType(sender, Button).Name.ToString = "ContinueButton" Then
            Dim U As String = Username.Text
            Dim P As String = PIN.Text
            Dim CP As String = ConfirmPIN.Text
            If XAvailableU(U) = False Then U = ""
            If U = "" Then Username.Text = ""
            If U = "" Then PIN.Text = ""
            ConfirmPIN.Text = If(U = "", "", CP)
            '
            If ButtonUnlock() = False Then Exit Sub
            ExportList = {U, P}
            ExportListToTemp(TempLogins)
            Terms.Show()
            Hide()
        Else
            DataCollect.Show()
            Hide()
        End If
    End Sub
    '
    ' -> Button Clicks


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        Dim TempButton As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.CnstButtons(TempButton, ButtonUnlock()))
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        Dim TempButton As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.CnstButtonHover(TempButton, ButtonUnlock()))
    End Sub
    '
    ' -> Button Images


    Private Sub KeyInput(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim TempText As String = CType(sender, TextBox).Name.ToString
        e.Handled = LimitChars(e.KeyChar, TempText)
    End Sub
    '
    Private Sub CheckPin()
        If ConfirmPIN.Text.Length() = 4 And PIN.Text.Length = 4 Then
            If ConfirmPIN.Text = PIN.Text Then
            Else
                Username.Select()
                MsgBox("PIN Doesn't Match")
                PIN.Text = ""
                ConfirmPIN.Text = ""
            End If
        End If
        ButtonUnlock()
    End Sub
    '
    ' -> Checks Username and PIN Entry 
    '
    Private Function ButtonUnlock() As Boolean
        Dim ButtonLock As Boolean = If(PIN.Text.Length = 4 And ConfirmPIN.Text.Length = 4 And Not String.IsNullOrEmpty(Username.Text), True, False)
        ContinueButton.BackgroundImage = Image.FromFile(Style.CnstButtons("ContinueButton", ButtonLock))
        Return ButtonLock
    End Function


End Class