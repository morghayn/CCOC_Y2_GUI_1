Imports System.IO

Public Class RentBike


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        XStationInfo()
        FullName.Text = XGetFullName()
        Dim allButtons As New List(Of Button) _
        From {ContinueButton, BackButton}
        For Each singleButton In allButtons
            singleButton.BackColor = Color.Transparent
            singleButton.FlatAppearance.MouseOverBackColor = Color.Transparent
            AddHandler singleButton.MouseLeave, AddressOf Buttons
            AddHandler singleButton.MouseEnter, AddressOf ButtonHover
        Next
        '
        For x = 0 To 19
            StationList.Items.Add(StationName(x))
        Next
        StationList.SelectedIndex = 0
        BikeQuantity.SelectedIndex = 0
    End Sub
    '
    ' -> RentBike Load


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        Dim TempButton As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(CnstButtons(TempButton, True))
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        Dim TempButton As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(CnstButtonHover(TempButton, True))
    End Sub
    Private Sub BackClick(sender As Object, e As EventArgs) Handles BackButton.Click
        MainMenu.Show()
        Close()
    End Sub
    '
    ' -> Button Images


    Private Sub ContinueClick(sender As Object, e As EventArgs) Handles ContinueButton.Click
        If BikeQuantity.SelectedItem = 0 Then
            MsgBox("No Bikes At Chosen Station")
            MainMenu.Show()
        Else
            XRemoveBikes()
            MainMenu.Show()
        End If
        Close()
    End Sub
    '
    ' -> Continue Button Click Event


    Private Sub GetBikeQuanitity(sender As Object, e As EventArgs) Handles BikeQuantity.SelectedIndexChanged
        BikesBeingTaken = BikeQuantity.SelectedItem
    End Sub
    '
    Private Sub GetBikeLocation(sender As Object, e As EventArgs) Handles StationList.SelectedIndexChanged
        StationNum = StationList.SelectedIndex
        '
        Available.Text = NonVoidBikesPer(StationNum)
        BikeQuantity.Items.Clear()
        '
        If NonVoidBikesPer(StationNum) = 0 Then
            BikeQuantity.Items.Add(0)
        Else
            For x = 1 To NonVoidBikesPer(StationNum)
                BikeQuantity.Items.Add(x)
            Next
        End If
        BikeQuantity.SelectedIndex = 0
    End Sub
    '
    ' -> Extracting vital information into global variables on SelectedIndexChanged
End Class