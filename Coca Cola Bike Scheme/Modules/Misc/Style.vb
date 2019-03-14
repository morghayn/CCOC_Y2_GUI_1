Imports System.Windows.Forms

Friend Module Style


    ' Mostly All Images Are Declared In Constants.Vb
    Public Function MainMenuButtons(x As String) As String
        Return If(x = "SignUpButton", SignUpBtn,
               If(x = "RentBikeButton", RenBikeBtn,
               If(x = "ReturnBikeButton", RetBikeBtn,
               If(x = "MoreButton", MoreBtn,
               ExitBtn))))
    End Function
    Public Function MainMenuButtonHover(x As String) As String
        Return If(x = "SignUpButton", SignUpHvr,
               If(x = "RentBikeButton", RenBikeHvr,
               If(x = "ReturnBikeButton", RetBikeHvr,
               If(x = "MoreButton", MoreHvr,
               ExitHvr))))
    End Function
    '
    ' -> Main Menu


    Public Function MenuMoreButtons(x As String) As String
        Return If(x = "SignInButton", SignInImage,
               If(x = "ReportBikeButton", RepBikeImage,
               If(x = "ButtonHelp", HelpImage,
               If(x = "faqButton", faqImage,
               If(x = "BackButton", BackImage,
               ExitBtn)))))
    End Function
    Public Function MenuMoreButtonHover(x As String) As String
        Return If(x = "SignInButton", SignInHover,
               If(x = "ReportBikeButton", RepBikeHover,
               If(x = "ButtonHelp", HelpHover,
               If(x = "faqButton", faqHover,
               If(x = "BackButton", BackImageHover,
               ExitHvr)))))
    End Function
    '
    ' -> Menu More


    Public Function CnstButtonHover(x As String, ButtonLock As Boolean) As String
        Return If(x = "ContinueButton" And ButtonLock = True, CntnuHvr,
               If(x = "ContinueButton" And ButtonLock = False, CntnuLkd,
               If(x = "BackButton", BckHvr,
               "")))
    End Function
    Public Function CnstButtons(x As String, ButtonLock As Boolean) As String
        Return If(x = "ContinueButton" And ButtonLock = True, CntnuBtn,
               If(x = "ContinueButton" And ButtonLock = False, CntnuLkd,
               If(x = "BackButton", BckBtn,
               "")))
    End Function
    '
    ' -> Sign Ins


    Public Function RtnBikButtons(x As String) As String
        Return If(x = "MenuButton", BigMenuButton,
               If(x = "TopUp", TopUpButton,
               ""))
    End Function
    Public Function RtnBikButtonHover(x As String) As String
        Return If(x = "MenuButton", BigMenuHover,
               If(x = "TopUp", TopUpHover,
               ""))
    End Function
    '
    ' -> Return Bike


    Public Function UsrDasButton(x As String) As String
        Return If(x = "MenuButton", BigMenuButton,
               If(x = "AddTopUp", AddButton,
               ""))
    End Function
    Public Function UsrDasButtonHover(x As String) As String
        Return If(x = "MenuButton", BigMenuHover,
               If(x = "AddTopUp", AddHover,
               ""))
    End Function
    '
    ' -> User Dashboard Buttons


    Public Function MaintenanceButtons(x As String, ButtonLock As Boolean) As String
        Return If(x = "MenuButton", BigMenuButton,
               If(x = "Repaired" And ButtonLock = True, NoRepaireds,
               If(x = "Repaired" And ButtonLock = False, MarkRepaired,
               MarkRepaired)))
    End Function
    Public Function MaintenanceHover(x As String, ButtonLock As Boolean) As String
        Return If(x = "MenuButton", BigMenuHover,
               If(x = "Repaired" And ButtonLock = True, NoRepaireds,
               If(x = "Repaired" And ButtonLock = False, RepairedHover,
        RepairedHover)))
    End Function
    '
    ' -> Maintenance Buttons

End Module
