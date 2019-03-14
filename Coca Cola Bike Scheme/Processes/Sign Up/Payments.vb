Imports System.IO

Public Class Payments



    '   /   /   PaymentTemp Load  /   /
    '
    '
    '
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim buttons As New List(Of Button) _
        From {ContinueButton, BackButton, AnnualBox, ThreeDayBox, DepositBox}
        For Each button In buttons
            button.BackColor = Color.Transparent
            button.FlatAppearance.MouseOverBackColor = Color.Transparent
        Next

        Using sr As StreamReader = New StreamReader(MonthsTXT)
            While Not sr.EndOfStream
                ExpMonth.Items.Add(sr.ReadLine)
            End While
            sr.Close()
        End Using

        Using sr As StreamReader = New StreamReader(YearsTXT)
            While Not sr.EndOfStream
                ExpYear.Items.Add(sr.ReadLine)
            End While
            sr.Close()
        End Using
        ExpMonth.SelectedIndex = 0
        ExpYear.SelectedIndex = 0
    End Sub



    '   /   /   Number Fields  /   /
    '
    '
    '
    Private Sub NumberKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Digits.KeyPress, CodeOne.KeyPress,
        CodeTwo.KeyPress, CodeThree.KeyPress, TopUpAmount.KeyPress
        e.Handled = If(Asc(e.KeyChar) = 8, False, If(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 58, False, True))
    End Sub



    '   /   /   Deposit Button  /   /
    '
    '  
    '
    Private Deposit As String
    Private Sub DepositMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles DepositBox.MouseEnter
        DepositBox.BackgroundImage = Image.FromFile(AcptCnfrmd)
    End Sub
    Private Sub DepositLeave(ByVal sender As Object, ByVal e As EventArgs) Handles DepositBox.MouseLeave
        DepositBox.BackgroundImage = If(DepositBox.Tag = 0, Image.FromFile(AcptBx), Image.FromFile(AcptCnfrmd))
    End Sub
    Private Sub DepositClick(sender As Object, e As EventArgs) Handles DepositBox.Click
        DepositBox.Tag = If(DepositBox.Tag = 0, 1, 0)
        DepositBox.BackgroundImage = If(DepositBox.Tag = 0, Image.FromFile(AcptBx), Image.FromFile(AcptCnfrmd))
        Deposit = If(DepositBox.Tag = 0, "", "Yes")
    End Sub



    '   /   /   Annual and Three Day Pass Buttons   /   /
    '
    '
    '
    Private Sub PassBoxesMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles AnnualBox.MouseEnter, ThreeDayBox.MouseEnter
        Dim TempButton As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = If(TempButton = "AnnualBox", Image.FromFile(AcptCnfrmd), Image.FromFile(AcptCnfrmd))
    End Sub
    Private Sub PassBoxesClick(sender As Object, e As EventArgs) Handles AnnualBox.Click, ThreeDayBox.Click
        Dim TempButton As String = CType(sender, Button).Name.ToString
        AnnualPass(If(TempButton = "AnnualBox", True, False))
    End Sub
    '
    '   AnnualClick and ThreeDayClick utilize AnnualPass()
    '
    Public ChosenPass As String
    Private Sub AnnualPass(isAnnualPass As Boolean)
        If isAnnualPass = True Then
            AnnualBox.Tag = If(AnnualBox.Tag = 0, 1, 0)
            ThreeDayBox.Tag = If(AnnualBox.Tag = 1, 0, 1)
        End If

        If isAnnualPass = False Then
            ThreeDayBox.Tag = If(ThreeDayBox.Tag = 0, 1, 0)
            AnnualBox.Tag = If(ThreeDayBox.Tag = 1, 0, 1)
        End If

        ChosenPass = If(AnnualBox.Tag = 1, "Annual", "Three-Day")
        ' Debug   ->  MsgBox(ChosenPass)
        WhichPassIsClicked()
    End Sub
    Private Sub PassBoxesMouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles AnnualBox.MouseLeave, ThreeDayBox.MouseLeave
        WhichPassIsClicked()
    End Sub
    '
    '   AnnualPass() and PassBoxesMouseLeave() utilizes WhichPassIsClicked()
    '
    Private Sub WhichPassIsClicked()
        ThreeDayBox.BackgroundImage = If(ThreeDayBox.Tag = 0, Image.FromFile(AcptBx), Image.FromFile(AcptCnfrmd))
        AnnualBox.BackgroundImage = If(AnnualBox.Tag = 0, Image.FromFile(AcptBx), Image.FromFile(AcptCnfrmd))
    End Sub



    '   /   /   Back Button  /   /
    '
    '
    '
    Private Sub BackMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles BackButton.MouseEnter
        BackButton.BackgroundImage = Image.FromFile(BckHvr)
    End Sub
    Private Sub BackLeave(ByVal sender As Object, ByVal e As EventArgs) Handles BackButton.MouseLeave
        BackButton.BackgroundImage = Image.FromFile(Constants.BckBtn)
    End Sub
    Private Sub BackClick(sender As Object, e As EventArgs) Handles BackButton.Click
        Terms.Show()
        Hide()
    End Sub



    '   /   /   Continue Button  /   /
    '
    '
    '
    Private Sub ContinueMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles ContinueButton.MouseEnter
        ContinueButton.BackgroundImage = If(ButtonLock = True, Image.FromFile(CntnuHvr), Image.FromFile(CntnuLkd))
    End Sub
    Private Sub ContinueLeave(ByVal sender As Object, ByVal e As EventArgs) Handles ContinueButton.MouseLeave
        ContinueButton.BackgroundImage = If(ButtonLock = True, Image.FromFile(Constants.CntnuBtn), Image.FromFile(CntnuLkd))
    End Sub
    Private Sub ContinueClick(sender As Object, e As EventArgs) Handles ContinueButton.Click
        Dim temp As Short = 0
        If Not String.IsNullOrEmpty(TopUpAmount.Text) Then temp = Integer.Parse(TopUpAmount.Text)
        '
        If temp < 10 And ButtonLock = True Then
            MsgBox("Top-Up amount must be greater than €10!")
            TopUpAmount.Text = ""
            ButtonLock = False
        End If
        '
        If ButtonLock = True Then
            TempData()
            TransferTemp.Show()
            Hide()
        End If
    End Sub
    '
    ' ContinueClick() utilizes TempData()
    '
    Public Sub TempData()
        ExportList = {TopUpAmount.Text, ChosenPass, ExpMonth.SelectedItem, ExpYear.SelectedItem,
        CodeOne.Text, CodeTwo.Text, CodeThree.Text, Digits.Text, Deposit}
        ExportListToTemp(TempCardDetails)
    End Sub



    '   /   /   Button Lock  /   /
    '
    '
    '
    Dim IsDigitValid As String = ""
    Private Sub TriggerUnlock(sender As Object, e As EventArgs) Handles ExpMonth.SelectedIndexChanged,
        ExpYear.SelectedIndexChanged, AnnualBox.Click, ThreeDayBox.Click, DepositBox.Click, Digits.TextChanged,
        CodeOne.TextChanged, CodeTwo.TextChanged, CodeThree.TextChanged, TopUpAmount.TextChanged
        IsDigitValid = If(Digits.TextLength <> 16, "", "Valid")
        ButtonUnlock()
    End Sub
    '
    ' TriggerUnlock() triggers Button Unlocked()
    '
    Dim ButtonLock As Boolean
    Private Sub ButtonUnlock()
        ButtonLock = FieldCheck()
        ContinueButton.BackgroundImage = If(ButtonLock = True, Image.FromFile(Constants.CntnuBtn), Image.FromFile(CntnuLkd))
    End Sub
    '
    '   ButtonUnlock() utilizes FieldCheck()
    '
    Public Function FieldCheck() As Boolean
        Dim AreFieldsFilled As New List(Of String) _
        From {IsDigitValid, ExpMonth.SelectedItem, ExpYear.SelectedItem, CodeOne.Text, CodeTwo.Text,
        CodeThree.Text, TopUpAmount.Text, ChosenPass, Deposit}
        '
        Dim beans As SByte
        For Each item As String In AreFieldsFilled
            If String.IsNullOrEmpty(item) Then
                beans += 1
                ' Debug   ->  MsgBox(beans)
            End If
        Next
        '
        Return If(beans = 0, True, False)
    End Function
End Class