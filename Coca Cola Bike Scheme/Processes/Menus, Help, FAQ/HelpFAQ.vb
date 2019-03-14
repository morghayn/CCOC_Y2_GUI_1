Imports System.IO

Public Class HelpFAQ


    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        If HelpOrFAQ = "FAQ" Then BackgroundImage = Image.FromFile(FAQTemplate)
        If HelpOrFAQ = "Help" Then BackgroundImage = Image.FromFile(HelpTemplate)
        '
        MenuButton.BackColor = Color.Transparent
        MenuButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        AddHandler MenuButton.MouseLeave, AddressOf Buttons
        AddHandler MenuButton.MouseEnter, AddressOf ButtonHover
        AddHandler MenuButton.Click, AddressOf Clicks
        '
        Dim x As String = ""
        If HelpOrFAQ = "FAQ" Then x = FaqTXT
        If HelpOrFAQ = "Help" Then x = HelpTXT
        '
        Using sr As StreamReader = New StreamReader(x)
            While Not sr.EndOfStream
                HelpOrFAQBox.AppendText(sr.ReadLine & Environment.NewLine)
            End While
            sr.Close()
        End Using
        HelpOrFAQBox.SelectionStart = HelpOrFAQBox.GetFirstCharIndexFromLine(0)
    End Sub
    '
    ' -> Either Help Or FAQ Load


    Private Sub Buttons(ByVal sender As Object, ByVal e As EventArgs)
        CType(sender, Button).BackgroundImage = Image.FromFile(BigMenuButton)
    End Sub
    Private Sub ButtonHover(ByVal sender As Object, ByVal e As EventArgs)
        CType(sender, Button).BackgroundImage = Image.FromFile(BigMenuHover)
    End Sub
    Private Sub Clicks(sender As Object, e As EventArgs)
        MenuMore.Show()
        Close()
    End Sub
    '
    ' -> Button


End Class