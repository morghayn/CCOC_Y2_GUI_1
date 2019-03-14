Imports System.IO

Public Class TransferTemp
    '   Implement Userbalance

    ' -> TransferTemp Load
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        TransferData()
        nameBox.Text = XGetFullName()
        usernameBox.Text = GetUsername()
        chargedBox.Text = AmountCharged

        Dim buttons As New List(Of Button) _
        From {ContinueButton}
        For Each button In buttons
            button.BackColor = Color.Transparent
            button.FlatAppearance.MouseOverBackColor = Color.Transparent
        Next
    End Sub
    '
    ' FormLoad() utilizes TranferData()
    '
    Private AmountCharged As String
    Private Sub TransferData()
        Builders.TransferData(TempData, Data, True)
        Builders.TransferData(TempLogins, Logins, False)
        Builders.TransferData(TempCardDetails, CardDetails, True)

        ' -> Form Streamy.VB Stream for this
        Using sr As New FileIO.TextFieldParser(TempCardDetails)
            sr.TextFieldType = FileIO.FieldType.Delimited
            sr.SetDelimiters(",")
            Dim currentRow As String() = sr.ReadFields()
            AmountCharged = currentRow(0) + If(currentRow(1) = "Annual", 10, 3)
            sr.Close()
        End Using
        WriteData(UserBalance, True, AmountCharged)
    End Sub


    ' -> Continue Button
    Private Sub ContinueMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles ContinueButton.MouseEnter
        ContinueButton.BackgroundImage = Image.FromFile("..\..\Resources\SignUp\TransferTemp\continueMouseEnter.png")
    End Sub
    Private Sub ContinueLeave(ByVal sender As Object, ByVal e As EventArgs) Handles ContinueButton.MouseLeave
        ContinueButton.BackgroundImage = Image.FromFile("..\..\Resources\SignUp\TransferTemp\continue.png")
    End Sub
    Private Sub ContinueClick(sender As Object, e As EventArgs) Handles ContinueButton.Click
        MainMenu.Show()
        DataCollect.Close()
        CreateLogin.Close()
        Terms.Close()
        Payments.Close()
        Close()
    End Sub
End Class