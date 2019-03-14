Public Class MainMenu


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim allButtons As New List(Of Button) From {SignUpButton, RentBikeButton, ReturnBikeButton, MoreButton, ExitButton}
        For Each singleButton In allButtons
            singleButton.BackColor = Color.Transparent
            singleButton.FlatAppearance.MouseOverBackColor = Color.Transparent
            AddHandler singleButton.MouseLeave, AddressOf Buttons
            AddHandler singleButton.MouseEnter, AddressOf ButtonHover
            AddHandler singleButton.Click, AddressOf Clicks
        Next
    End Sub
    '
    ' -> Main Menu Form Load


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.MainMenuButtons(Button))
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.MainMenuButtonHover(Button))
    End Sub
    '
    ' -> Button Images


    Private Sub Clicks(sender As Object, e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        If Button = "SignUpButton" Then DataCollect.Show()
        '
        If Button = "RentBikeButton" Then WhichLogin = "RentBike"
        If Button = "RentBikeButton" Then LoginScreen.Show()
        '
        If Button = "ReturnBikeButton" Then WhichLogin = "ReturnBike"
        If Button = "ReturnBikeButton" Then LoginScreen.Show()
        '
        If Button = "MoreButton" Then MenuMore.Show()
        If Button = "ExitButton" Then Application.Exit()
        Hide()
    End Sub
    '
    ' -> Events on Button Click


End Class