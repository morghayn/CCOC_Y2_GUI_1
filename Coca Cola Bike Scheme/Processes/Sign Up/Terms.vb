Imports System.IO

Public Class Terms


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim allButtons As New List(Of Button) _
        From {ContinueButton, BackButton, AcceptBox}
        For Each singleButton In allButtons
            singleButton.BackColor = Color.Transparent
            singleButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        Next
        '
        Dim twoButtons As New List(Of Button) _
            From {ContinueButton, BackButton}
        For Each singleButton In twoButtons
            AddHandler singleButton.MouseLeave, AddressOf Buttons
            AddHandler singleButton.MouseEnter, AddressOf ButtonHover
            AddHandler singleButton.Click, AddressOf Clicks
        Next
        '
        Using sr As StreamReader = New StreamReader(TermsTXT)
            While Not sr.EndOfStream
                TermsNConditions.AppendText(sr.ReadLine & Environment.NewLine)
            End While
            sr.Close()
        End Using
    End Sub
    '
    ' -> TermsAccept Load


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        Dim Temp As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = If(AcceptBoolean() = False And Temp = "ContinueButton", Image.FromFile(Constants.CntnuBtn),
        If(Temp = "BackButton", Image.FromFile(Constants.BckBtn), Image.FromFile(CntnuLkd)))
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        Dim Temp As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = If(AcceptBoolean() = False And Temp = "ContinueButton", Image.FromFile(CntnuHvr),
        If(Temp = "BackButton", Image.FromFile(BckHvr), Image.FromFile(CntnuLkd)))
    End Sub
    Private Sub Clicks(sender As Object, e As EventArgs)
        Dim Temp As String = CType(sender, Button).Name.ToString
        If AcceptBoolean() = False And Temp = "ContinueButton" Then
            Payments.Show()
            Hide()
        ElseIf Temp = "BackButton" Then
            CreateLogin.Show()
            Hide()
        End If
    End Sub
    '
    ' -> Buttons


    Private Sub AcceptMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles AcceptBox.MouseEnter
        AcceptBox.BackgroundImage = Image.FromFile(AcptCnfrmd)
    End Sub
    '
    Private Sub AcceptLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AcceptBox.MouseLeave
        AcceptBoxImage()
    End Sub
    '
    Private Sub AcceptClick(sender As Object, e As EventArgs) Handles AcceptBox.Click
        AcceptBox.Tag = If(AcceptBox.Tag = 0, 1, 0)
        ContinueButton.BackgroundImage = If(AcceptBoolean() = False, Image.FromFile(Constants.CntnuBtn), Image.FromFile(CntnuLkd))
        AcceptBoxImage()
    End Sub
    '
    ' AcceptLeave() and AcceptClick() utilize AcceptBoxImage()
    '
    Public Sub AcceptBoxImage()
        AcceptBox.BackgroundImage = If(AcceptBox.Tag = 0, Image.FromFile(AcptBx), Image.FromFile(AcptCnfrmd))
    End Sub
    '
    Function AcceptBoolean() As Boolean
        Return If(AcceptBox.Tag = 1, False, True)
    End Function
    '
    ' -> AcceptButton
End Class