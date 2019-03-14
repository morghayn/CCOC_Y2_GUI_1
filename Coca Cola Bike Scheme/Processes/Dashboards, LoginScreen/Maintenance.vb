Imports System.IO

Public Class Maintenance

    ' I made this Form on the day of submission so sorry if the code is ugly and messy haha

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        XStationInfo()
        Dim allButtons As New List(Of Button) From {MenuButton, Repaired}
        For Each singleButton In allButtons
            singleButton.BackColor = Color.Transparent
            singleButton.FlatAppearance.MouseOverBackColor = Color.Transparent
            AddHandler singleButton.MouseLeave, AddressOf Buttons
            AddHandler singleButton.MouseEnter, AddressOf ButtonHover
        Next
        AddHandler MenuButton.Click, AddressOf Clicks

        For x = 0 To 19
            If NonVoidBikesPer(x) < 5 Then StationsUnderFive.Items.Add(StationName(x))
        Next

        XGetBrokenBikes()
        Dim y As Short = BrokenBikes.SelectedIndex
        If BrokenBikes.Items.Count < 0 Then
            BrokenBikes.SelectedIndex = -1
        Else
            XStationInfo()
            If Not y < 0 Then XUpdateRepairLog(BrokenBikes.SelectedItem)
            If BrokenBikes.Items.Count = 0 Then BrokenBikes.SelectedIndex = -1
            If BrokenBikes.Items.Count = 1 Then BrokenBikes.SelectedIndex = 0
            If BrokenBikes.Items.Count > 1 Then BrokenBikes.SelectedIndex = 0
        End If
        Repaired.BackgroundImage = Image.FromFile(Style.MaintenanceButtons("Repaired", ButtonUnlock()))
        UpdateDescription()
    End Sub
    '
    '    Lists Stations With Under Five Bikes
    '    Lists All Broken Bikes In the RepairLog
    ' -> MaintenanceDashboard Load

    Private Function ButtonUnlock()
        Dim x As Short = BrokenBikes.SelectedIndex

        If BrokenBikes.Items.Count < 0 Then
            Return If(BrokenBikes.SelectedIndex = -1, True, False)
        Else
            Return If(BrokenBikes.SelectedIndex > -1, False, True)
        End If
        UpdateDescription()
    End Function


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        Dim x As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.MaintenanceButtons(x, ButtonUnlock()))
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        Dim x As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.MaintenanceHover(x, ButtonUnlock()))
    End Sub
    '
    Private Sub Clicks(sender As Object, e As EventArgs)
        MainMenu.Show()
        Close()
    End Sub


    Private Sub BrokenBikesIndex(sender As Object, e As EventArgs) Handles BrokenBikes.SelectedIndexChanged
        UpdateDescription()
    End Sub


    Private Sub RepairClick(sender As Object, e As EventArgs) Handles Repaired.Click
        Dim x As Short = BrokenBikes.SelectedIndex
        If BrokenBikes.Items.Count < 0 Then
            BrokenBikes.SelectedIndex = -1
        Else
            XStationInfo()
            If Not x < 0 Then XUpdateRepairLog(BrokenBikes.SelectedItem)
            If BrokenBikes.Items.Count = 0 Then BrokenBikes.SelectedIndex = -1
            If BrokenBikes.Items.Count = 1 Then BrokenBikes.SelectedIndex = 0
            If BrokenBikes.Items.Count > 1 Then BrokenBikes.SelectedIndex = 0
        End If

        UpdateDescription()
    End Sub
    '
    ' -> Repair Button Click


    Private Sub UpdateDescription()
        Dim x As Short = 0
        Dim DescriptionString(1000) As String
        For Each Item In DescriptionList
            x += 1
            DescriptionString(x) = Item
        Next

        Description.Text = DescriptionString(BrokenBikes.SelectedIndex + 1)
        If BrokenBikes.Items.Count = 0 Then Description.Text = "Broken Bike Descriptions Go Here"
    End Sub


End Class