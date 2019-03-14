Public Class MenuMore


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim allButtons As New List(Of Button) From {SignInButton, faqButton, ButtonHelp, ReportBikeButton, BackButton, ExitButton}
        For Each singleButton In allButtons
            singleButton.BackColor = Color.Transparent
            singleButton.FlatAppearance.MouseOverBackColor = Color.Transparent
            AddHandler singleButton.MouseLeave, AddressOf Buttons
            AddHandler singleButton.MouseEnter, AddressOf ButtonHover
            AddHandler singleButton.Click, AddressOf Clicks
        Next
    End Sub
    '
    ' -> MenuMore Load


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.MenuMoreButtons(Button))
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = Image.FromFile(Style.MenuMoreButtonHover(Button))
    End Sub
    '
    ' -> Button Images


    Private Sub Clicks(sender As Object, e As EventArgs)
        Dim Button As String = CType(sender, Button).Name.ToString
        If Button = "SignInButton" Then WhichLogin = "Dashboard"
        If Button = "SignInButton" Then LoginScreen.Show()
        '
        If Button = "ReportBikeButton" Then ReportBike.Show()
        '
        If Button = "faqButton" Then HelpOrFAQ = "FAQ"
        If Button = "faqButton" Then HelpFAQ.Show()
        '
        If Button = "ButtonHelp" Then HelpOrFAQ = "Help"
        If Button = "ButtonHelp" Then HelpFAQ.Show()
        '
        If Button = "BackButton" Then MainMenu.Show()
        If Button = "ExitButton" Then Application.Exit()
        Close()
    End Sub
    '
    ' -> Events on Button Click


End Class