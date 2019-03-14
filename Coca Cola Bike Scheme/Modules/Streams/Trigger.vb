Friend Module Trigger


    Public Function XAvailableU(U As String) As Boolean
        UAvailable = True
        Username = U
        TriggerParse(Logins, "Username Availability")
        '
        ErrMsg = U & " has already been taken!"
        If UAvailable = False Then MsgBox(ErrMsg)
        Return UAvailable
    End Function
    '
    ' -> Checks if a username is availabile


    Public Sub XConfirmLogin(U As String, P As String)
        LoginApproved = False
        Username = U
        PIN = P
        TriggerParse(Logins, "Confirm User Login")
        '
        ErrMsg = "Error! Your username and/or PIN is wrong."
        If LoginApproved = False Then MsgBox(ErrMsg)
    End Sub
    '
    ' -> Approves Login If It Exists And Is Valid


    Public Function GetUsername() As String
        ParseFields(TempLogins)
        Return ParsedFields(0)
    End Function
    '
    ' -> Returns Username From TempLogins.CSV - Alway 0,0


    Public Function XGetFullName() As String
        Temp = ""
        TriggerParse(Data, "Get Full Name")
        Return Temp
    End Function
    '
    ' -> Builds Users Name Scanning For Username In Data


    Public Function XGetBalance() As String
        Temp = ""
        TriggerParse(UserBalance, "Get User Balance")
        Return Temp
    End Function
    '
    ' -> Gets A Users Balance


    Public Sub XUpdateBalance()
        WipeFile(TempReturn)
        Dim x As String = ""
        If IncreaseBalance = True Then x = "Increase User Balance"
        If IncreaseBalance = False Then x = "Reduce User Balance"
        '
        TriggerParse(UserBalance, x)
        WipeFile(UserBalance)
        ExportEntireCSV(TempReturn, UserBalance)
    End Sub
    '
    '    If IncreaseBalance = True -- Increase Balance
    '    If IncreaseBalance = False -- Reduce Balance
    ' -> Updates A Users Balance


    Public Sub XGetTotalRevenue()
        Cost = 0
        TriggerParse(RevenueLog, "Get Total Revenue")
    End Sub
    '
    ' -> Gets Total Revenue From Revenue Log


    Public Function XUserRentStatus(U As String, X As String) As Boolean
        Username = U
        RentStatus = False
        TriggerParse(Bikes, "Users Rent Status")
        '
        If X = "Return" Then ErrMsg = "You haven't rented any bikes yet!"
        If X = "Return" And RentStatus = False Then MsgBox(ErrMsg)
        If X = "Return" And RentStatus = True Then XDeleteRentEntry(U)
        If X = "Rent" Then ErrMsg = "You are currently renting! Please return bikes before renting!"
        If X = "Rent" And RentStatus = True Then MsgBox(ErrMsg)
        Return RentStatus
    End Function
    '
    ' -> Returns a User's Rent Status -- True/False


    Public Sub XStationInfo()
        For x = 0 To 19
            BikesPer(x) = 0
            NonVoidBikesPer(x) = 0
            StationName(x) = ""
        Next
        StationNum = 0
        '
        TriggerParse(Stations, "Get Station Info")
    End Sub
    '
    ' -> Retrieving information from Station.CSV


    Public Sub XGetBrokenBikes()
        TempShortt = 0
        SkipRow = False
        TriggerParse(RepairLog, "Retrieve List Of Broken Bikes")
    End Sub
    '
    ' -> Retrieves A List Of Broken Bikes


    Public Sub XUpdateRepairLog(SelectedBrokenBike As String)
        TempTwo = SelectedBrokenBike
        WipeFile(TempReturn)
        WipeFile(TempData)
        '
        TriggerParse(RepairLog, "Repair Bike")
        '
        WipeFile(RepairLog)
        ExportEntireCSV(TempReturn, RepairLog)
        XReturnFixedBike()
        Maintenance.BrokenBikes.Items.Clear()
        DescriptionList.Clear()
        XGetBrokenBikes()
    End Sub
    '
    ' -> Retrieves A List Of Broken Bikes


    Public Sub XReturnFixedBike()
        Counter = 0
        MyString = ""
        ParseFields(TempData)
        '
        WipeFile(TempLogins)
            TriggerParse(Stations, "Return Fixed Bike")
            '
            WipeFile(Stations)
        ExportEntireCSV(TempLogins, Stations)
    End Sub
    '
    ' -> Retrieves A List Of Broken Bikes


    Public Sub XRemoveBikes()
        WipeFile(TempData)
        BikesLeft = BikesPer(StationNum) - BikesBeingTaken
        Focused = 0
        '
        TriggerParse(Stations, "Remove Rented Bikes")
        '
        WipeFile(Stations)
        ExportEntireCSV(TempData, Stations)
    End Sub
    '
    '    Removes Bikes From Stations On Rent
    ' -> Makes User Rent Entry in Bikes.CSV


    Public Sub XReturnRentedBikes()
        XStationInfo()
        WipeFile(TempReturn)
        ParseFields(TempData)
        BikesTaken = ParsedFields.Count - 2
        StationNum = 0
        '
        TriggerParse(Stations, "Return Rented Bikes")
        '
        WipeFile(Stations)
        ExportEntireCSV(TempReturn, Stations)
    End Sub
    '
    ' -> Puts The Bike(s) Which User Took, Back In Station


    Public Sub XDeleteRentEntry(U As String)
        Username = U
        WipeFile(TempBikes)
        WipeFile(TempData)
        '
        TriggerParse(Bikes, "Delete User Rent Entry")
        '
        WipeFile(Bikes)
        ExportEntireCSV(TempBikes, Bikes)
    End Sub
    '
    ' -> On Return, Deletes User's Rent Entry In Bikes.CSV


    Public Sub XLockBike(x As String, y As String)
        Temp = x
        TempTwo = y
        StationNum = 0
        SerialExist = False
        TriggerParse(Stations, "Lock Reported Bike")
        '
        WipeFile(Stations)
        ExportEntireCSV(TempData, Stations)
        '
        ErrMsg = "Sorry, but the serial you gave matched no bike. Your bike may have already been reported. But also, please note serials are case sensitive. Bike Serials take the format of ' BIKE000 '"
        If SerialExist = False And Not x = "" Then MsgBox(ErrMsg)
    End Sub
    '
    ' -> On Bike Report, Bike Is Set as "VOID" nd' Moved To Column 2 in CSV


    ' -=-=-=- Variables -=-=-=- '
    Public Cost As Decimal
    Public BikesPer(19) As Short
    Public Counter As Short
    Public NonVoidBikesPer(19) As Short
    Public StationName(19) As String
    Public ErrMsg As String
    Public PIN As String
    Public Temp As String
    Public TempTwo As String
    Public Username As String
    Public Focused As SByte
    Public BikesLeft As SByte
    Public StationNum As SByte
    Public BikesTaken As SByte
    Public BikesBeingTaken As SByte
    Public IncreaseBalance As Boolean
    Public SerialExist As Boolean
    Public UAvailable As Boolean
    Public RentStatus As Boolean
    Public LoginApproved As Boolean
End Module