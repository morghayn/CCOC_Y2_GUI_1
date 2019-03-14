Imports System.IO

Public Class ReturnBike


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        FullName.Text = XGetFullName()
        Before.Text = XGetBalance()
        XReturnRentedBikes()
        '
        GetRideTime()
        StartTime.Text = TimeBefore
        FinishTime.Text = TimeAfter
        '
        Dim allButtons As New List(Of Button) From {MenuButton, TopUp}
        For Each singleButton In allButtons
            singleButton.BackColor = Color.Transparent
            singleButton.FlatAppearance.MouseOverBackColor = Color.Transparent
            AddHandler singleButton.MouseLeave, AddressOf Buttons
            AddHandler singleButton.MouseEnter, AddressOf ButtonHover
            AddHandler singleButton.Click, AddressOf Clicks
        Next
        '
        RideFee.Text = GetCost()
        After.Text = XGetBalance() - GetCost()
        If (XGetBalance() - GetCost()) < 0 Then Debited.Text = "Yes"
        If (XGetBalance() - GetCost()) >= 0 Then Debited.Text = "No"
        IncreaseBalance = False
        XUpdateBalance()
        '
        Dim x As String = GetCost() & "," & TimeBefore & "," & TimeAfter & "," & BikesTaken
        WriteData(RevenueLog, True, x)
    End Sub
    '
    '    Getting The Users Ride Time And Balance
    '    Calculating The Ride Cost And Updating The Users Balance
    '    Then creates an entry in the revenue log
    ' -> Return Bike Load


    Private Sub Clicks(sender As Object, e As EventArgs)
        Dim x As String = CType(sender, Button).Name.ToString
        If x = "TopUp" Then TopUp.Show()
        If x = "MenuButton" Then MainMenu.Show()
        Close()
    End Sub
    '
    ' -> Button Click


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.RtnBikButtons(Button))
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.RtnBikButtonHover(Button))
    End Sub
    '
    ' -> Button Images


End Class