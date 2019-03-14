Friend Module Functions


    Public Function LimitChars(e As Object, x As String) As Boolean
        If x = "NUM" Then x = "PIN"
        If x = "ConfirmPIN" Then x = "PIN"
        '
        Return If(x = "PIN", OnlyNumbers(e),
               If(x = "Username", OnlyLetters(e),
               If(x = "TextField", TextField(e),
               If(x = "EAddress", EAddress(e),
               If(x = "Address", Address(e), False)))))
        '
        If OnlyNumbers(e.KeyChar) = True Then
            MsgBox("Error, only numbers allowed")
        End If
    End Function
    '
    ' -> Returns True False From Ascii Limiters Below


    Private Function OnlyLetters(e) As Boolean
        Return If(Asc(e) = 8, False,
               If(Asc(e) >= 65 And Asc(e) <= 90, False,
               If(Asc(e) >= 97 And Asc(e) <= 122, False, True)))
    End Function
    Private Function OnlyNumbers(e) As Boolean
        Return If(Asc(e) = 8, False,
               If(Asc(e) >= 48 And Asc(e) <= 57, False, True))
    End Function
    Private Function TextField(e) As Boolean
        Return If(Asc(e) = 8 Or Asc(e) = 32, False,
               If(Asc(e) >= 65 And Asc(e) <= 90, False,
               If(Asc(e) >= 97 And Asc(e) <= 122, False, True)))
    End Function
    Private Function Address(e) As Boolean
        Return If(Asc(e) = 8 Or Asc(e) = 32, False,
               If(Asc(e) >= 48 And Asc(e) <= 57, False,
               If(Asc(e) >= 65 And Asc(e) <= 90, False,
               If(Asc(e) >= 97 And Asc(e) <= 122, False, True))))
    End Function
    Private Function EAddress(e) As Boolean
        Return If(Asc(e) = 8 Or Asc(e) = 32, False,
               If(Asc(e) >= 48 And Asc(e) <= 57, False,
               If(Asc(e) >= 65 And Asc(e) <= 90, False,
               If(Asc(e) = 64 Or Asc(e) = 46, False,
               If(Asc(e) >= 97 And Asc(e) <= 122, False, True)))))
    End Function
    '
    ' -> My Ascii Limiters


    Public Sub CheckBirthday()
        DateOfBirth = ""
        Dim B As Boolean = False
        Dim T As Boolean = False
        Dim xYear As Short = Date.Now.Year
        Dim xMonth As SByte = Date.Now.Month
        Dim xDay As SByte = Date.Now.Day
        '
        If Day > 0 And Month > 0 And Year > 0 Then
            If Year >= (xYear - 13) Then B = False
            If Year = (xYear - 14) Then
                If Month < xMonth Then B = True
                If Month > xMonth Then B = False
                If Month = xMonth And Day <= xDay Then B = True
                If Month = xMonth And Day > xDay Then B = False
            End If
            If Year < (xYear - 14) Then B = True
            T = True
        End If
        '
        If B = False And T = True Then MsgBox("You are too young to sign up!")
        If B = True And T = True Then DateOfBirth = Day & "-" & Month & "-" & Year
    End Sub
    '
    '    Check if age is above 14
    ' -> If age above 14, convert date of birth to String


    Public Sub GetRideTime()
        ParseFields(TempData)
        TimeBefore = ParsedFields(1)
        '
        ParseFields(TempLogins)
        TimeAfter = ParsedFields(1)

        Dim TimeArray1 As String() = TimeBefore.Split(":".ToCharArray())
        Dim TimeArray2 As String() = TimeAfter.Split(":".ToCharArray())
        BeforeMinutes = (TimeArray1(0) * 60) + TimeArray1(1)
        AfterMinutes = (TimeArray2(0) * 60) + TimeArray2(1)
    End Sub
    '
    ' -> Retrieves A Users Ride Time Data, Also Convers Time Data To Minutes


    Public Function GetCost() As Decimal
        Cost = 0
        Dim RideTime = AfterMinutes - BeforeMinutes
        If RideTime <= 30 Then Cost = 0
        If RideTime >= 30 And RideTime <= 60 Then Cost = 0.5
        If RideTime >= 60 And RideTime <= 120 Then Cost = 1.5
        If RideTime >= 120 And RideTime <= 180 Then Cost = 6.5
        If RideTime > 180 Then
            RideTime -= 180
            RideTime /= 30
            Cost = (RideTime * 2) + 6.5
        End If
        '
        ParseFields(TempData)
        BikesTaken = ParsedFields.Count - 2
        Cost = BikesTaken * Cost
        Return Cost
    End Function
    '
    ' -> Using A Series Of If Statements To Calculate Ride Cost


    ' -=-=-=- Variables -=-=-=- '
    Public Day As SByte
    Public Month As SByte
    Public Year As Short
    Public DateOfBirth As String
    '
    Public TimeBefore As String
    Public BeforeMinutes As Short
    Public TimeAfter As String
    Public AfterMinutes As Short
End Module