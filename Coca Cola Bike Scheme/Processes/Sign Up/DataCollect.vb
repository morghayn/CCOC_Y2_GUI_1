Imports System.IO

Public Class DataCollect


    Private Sub FormLoad() Handles MyBase.Load
        Dim allButtons As New List(Of Button) From {FemaleButton, MaleButton, BackButton, ContinueButton}
        For Each singleButton In allButtons
            singleButton.BackColor = Color.Transparent
            singleButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        Next
        '
        Dim lists As New List(Of ComboBox) From {birthDay, birthMonth, birthYear}
        For Each lst In lists
            AddHandler lst.SelectedIndexChanged, AddressOf XCheckBirthday
        Next
        '
        For x = 1 To 31
            birthDay.Items.Add(x)
            If x < 13 Then birthMonth.Items.Add(x)
        Next
        For x = 2018 To 1900 Step -1
            birthYear.Items.Add(x)
        Next
        '
        Dim W As Boolean = False
        For x = 1 To 2
            Dim Place As String = If(W = False, CountriesTXT, CountiesTXT)
            Using sr As StreamReader = New StreamReader(Place)
                While Not sr.EndOfStream
                    If W = False Then lstCountry.Items.Add(sr.ReadLine)
                    If W = True Then lstCounty.Items.Add(sr.ReadLine)
                End While
                sr.Close()
            End Using
            W = True
        Next
    End Sub
    '
    ' -> DetailsTemp Load


    Private Sub NameFieldInput(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles firstName.KeyPress, lastName.KeyPress
        Dim x As String = CType(sender, TextBox).Text
        e.Handled = LimitChars(e.KeyChar, "TextField")
        Dim a As Boolean = If(x.Contains("'"), True, False)
        If a = False And Asc(e.KeyChar) = 39 Then e.Handled = If(Asc(e.KeyChar) = 39, False, True)
    End Sub
    '    a = "apostrophe count"
    ' -> Name Fields 


    ' -> Gender Buttons
    Private Sub GenderMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles FemaleButton.MouseEnter, MaleButton.MouseEnter
        Dim TempButton As String = CType(sender, Button).Name.ToString
        CType(sender, Button).BackgroundImage = If(TempButton = "FemaleButton", Image.FromFile(FemaleHover), Image.FromFile(MaleHover))
    End Sub
    Private Sub GenderClick(sender As Object, e As EventArgs) Handles FemaleButton.Click, MaleButton.Click
        Dim TempButton As String = CType(sender, Button).Name.ToString
        Gender(If(TempButton = "FemaleButton", True, False))
    End Sub
    '
    '   GenderClick() utilize Gender()
    '
    Public ChosenGender As String
    Private Sub Gender(isFemale As Boolean)
        If isFemale = True Then
            FemaleButton.Tag = If(FemaleButton.Tag = 0, 1, 0)
            MaleButton.Tag = If(FemaleButton.Tag = 1, 0, 1)
        End If

        If isFemale = False Then
            MaleButton.Tag = If(MaleButton.Tag = 0, 1, 0)
            FemaleButton.Tag = If(MaleButton.Tag = 1, 0, 1)
        End If

        ChosenGender = If(FemaleButton.Tag = 1, "Female", "Male")
        ' Debug   ->  MsgBox(ChosenGender)
        ButtonUnlock()
        GenderColor()
    End Sub
    Private Sub GenderButtonMouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles MaleButton.MouseLeave, FemaleButton.MouseLeave
        GenderColor()
    End Sub
    '
    '   Gender() and GenderButtonMouseLeave() utilizes GenderColor()
    '
    Private Sub GenderColor()
        MaleButton.BackgroundImage = If(MaleButton.Tag = 0, Image.FromFile(Male), Image.FromFile(MaleTagged))
        FemaleButton.BackgroundImage = If(FemaleButton.Tag = 0, Image.FromFile(Female), Image.FromFile(FemaleTagged))
    End Sub


    Private Sub Phone(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles phoneNumber.KeyPress
        e.Handled = LimitChars(e.KeyChar, "NUM")
    End Sub
    '
    ' -> Phone Number


    Private Sub EmailAddressInput(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles emailAddress.KeyPress
        e.Handled = LimitChars(e.KeyChar, "EAddress")
    End Sub
    '
    ' -> Email Address


    Private Sub XCheckBirthday(sender As Object, e As EventArgs)
        If birthDay.Focused Then Day = birthDay.SelectedItem
        If birthMonth.Focused Then Month = birthMonth.SelectedItem
        If birthYear.Focused Then Year = birthYear.SelectedItem
        '
        CheckBirthday()
        ButtonUnlock()
    End Sub
    '    Check if age is above 14
    ' -> If age above 14, convert date of birth to String


    Private Sub AddressKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles addressOne.KeyPress,
    addressTwo.KeyPress, addressThree.KeyPress
        e.Handled = LimitChars(e.KeyChar, "Address")
    End Sub
    '
    ' -> Address Line One, Two, Three


    Private Sub BackButtonMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles BackButton.MouseEnter
        BackButton.BackgroundImage = Image.FromFile(BackHvr)
    End Sub
    Private Sub BackButtonLeave(ByVal sender As Object, ByVal e As EventArgs) Handles BackButton.MouseLeave
        BackButton.BackgroundImage = Image.FromFile(BackBtn)
    End Sub
    Private Sub BackButtonClick(sender As Object, e As EventArgs) Handles BackButton.Click
        MainMenu.Show()
        Dim SUForms As New List(Of Form) From {CreateLogin, Terms, Payments, TransferTemp, Me}
        For Each SUForm In SUForms
            SUForm.Close()
        Next
    End Sub
    '
    ' -> BackButton


    Private Sub ContinueMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles ContinueButton.MouseEnter
        ContinueButton.BackgroundImage = If(ButtonLock = True, Image.FromFile(CntnueHvr), Image.FromFile(CntnueLkd))
    End Sub
    Private Sub ContinueLeave(ByVal sender As Object, ByVal e As EventArgs) Handles ContinueButton.MouseLeave
        ContinueButton.BackgroundImage = If(ButtonLock = True, Image.FromFile(CntnueBtn), Image.FromFile(CntnueLkd))
    End Sub
    Private Sub ContinueClick(sender As Object, e As EventArgs) Handles ContinueButton.Click
        If ButtonLock = True Then
            AddressTwoAndThree()
            WriteTempData()
            CreateLogin.Show()
            Hide()
        End If
    End Sub
    '
    ' -> ContinueButton


    Public Sub AddressTwoAndThree()
        If addressTwo.Text = "" Then addressTwo.Text = "Null"
        If addressThree.Text = "" Then addressThree.Text = "Null"
    End Sub
    '
    ' ContinueClick() utilizes TempData()
    '
    Public Sub WriteTempData()
        ExportList = {firstName.Text, lastName.Text, ChosenGender, phoneNumber.Text, emailAddress.Text,
        DateOfBirth, addressOne.Text, addressTwo.Text, addressThree.Text, CountyCountry}
        ExportListToTemp(TempData)
    End Sub


    ' -> ButtonUnlock
    Dim ButtonLock As Boolean
    Private Sub ButtonUnlock()
        ButtonLock = FieldCheck()
        ContinueButton.BackgroundImage = If(ButtonLock = True, Image.FromFile(CntnueBtn), Image.FromFile(CntnueLkd))
    End Sub
    '
    '   ButtonUnlock() utilizes FieldCheck()
    '
    Public Function FieldCheck() As Boolean
        Dim AreFieldsFilled As New List(Of String) _
        From {firstName.Text, lastName.Text, ChosenGender, phoneNumber.Text, emailAddress.Text, DateOfBirth, addressOne.Text, CountyCountry}
        Dim beans As SByte
        For Each item As String In AreFieldsFilled
            If String.IsNullOrEmpty(item) Then beans += 1
        Next
        Return If(beans = 0, True, False)
    End Function
    '
    ' ButtonUnlock() Triggers
    '
    Private Sub TextBoxTrigger(sender As Object, e As EventArgs) Handles firstName.TextChanged, lastName.TextChanged,
        addressOne.TextChanged, emailAddress.TextChanged, phoneNumber.TextChanged
        ButtonUnlock()
    End Sub
    '
    Dim CountyCountry As String
    Private Sub ListBoxTrigger(sender As Object, e As EventArgs) Handles lstCountry.SelectedIndexChanged, lstCounty.SelectedIndexChanged
        If lstCounty.Focused Then lstCountry.ClearSelected()
        If lstCountry.Focused Then lstCounty.ClearSelected()
        CountyCountry = CType(sender, ListBox).SelectedItem
        ButtonUnlock()
    End Sub
End Class