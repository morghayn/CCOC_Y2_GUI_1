Friend Module Algorithms


    Public Sub TriggerParse(CSV As String, X As String)
        Using sr As New FileIO.TextFieldParser(CSV)
            While Not sr.EndOfData
                sr.TextFieldType = FileIO.FieldType.Delimited
                sr.SetDelimiters(",")
                Slice = sr.ReadFields()
                '
                If X = "Username Availability" Then AvailableU(Username)
                '
                If X = "Confirm User Login" Then ConfirmLogin(Username, PIN)
                '
                If X = "Get Full Name" Then GetFullName()
                '
                If X = "Get User Balance" Then GetBalance()
                '
                If X = "Increase User Balance" Then UpdateBalance()
                '
                If X = "Reduce User Balance" Then UpdateBalance()
                '
                If X = "Get Total Revenue" Then GetTotalRevenue()
                '
                If X = "Users Rent Status" Then UserRentStatus(Username)
                '
                If X = "Get Station Info" Then StationInfo()
                '
                If X = "Retrieve List Of Broken Bikes" Then GetBrokenBikes()
                '
                If X = "Repair Bike" Then UpdateRepairLog()
                '
                If X = "Return Fixed Bike" Then ReturnFixedBike()
                '
                If X = "Remove Rented Bikes" Then RemoveBikes()
                '
                If X = "Return Rented Bikes" Then ReturnRentedBikes()
                '
                If X = "Delete User Rent Entry" Then DeleteRentEntry(Username)
                '
                If X = "Lock Reported Bike" Then LockBike(Temp, TempTwo)
                '
            End While
            sr.Close()
        End Using
    End Sub
    '
    '    If Statements Probably Unnecessary, However It Makes It Very Maintainable
    ' -> This One Stream Runs 90% Of Algorithms Below


    Public Sub AvailableU(U As String)
        If Slice(0) = U Then
            UAvailable = False
        End If
    End Sub
    '...


    Public Sub ConfirmLogin(U As String, P As String)
        If Slice(0) = U And Slice(1) = P Then
            LoginApproved = True
        End If
    End Sub
    '...


    Public Sub GetFullName()
        If Slice(0) = GetUsername() Then
            Temp = (Slice(1) & " " & Slice(2))
        End If
    End Sub
    '...


    Public Sub GetBalance()
        If Slice(0) = GetUsername() Then
            Temp = (Slice(1))
        End If
    End Sub
    '...


    Public Sub UpdateBalance()
        MyString = ""
        If Slice(0) = GetUsername() Then
            If IncreaseBalance = True Then MyString += Slice(0) & "," & (Slice(1) + Cost)
            If IncreaseBalance = False Then MyString += Slice(0) & "," & (Slice(1) - Cost)
            WriteData(TempReturn, False, MyString)
        Else
            MyString += Slice(0) & "," & Slice(1)
            WriteData(TempReturn, False, MyString)
        End If
    End Sub
    '...


    Public Sub GetTotalRevenue()
        If IsNumeric(Slice(1)) Then
            Cost += Slice(1)
        End If
    End Sub
    '...


    Public Sub UserRentStatus(U As String)
        If Slice(0) = U Then RentStatus = True
    End Sub
    '...


    Public Sub StationInfo()
        StationName(StationNum) = Slice(0)
        For x = 1 To 15
            If Not String.IsNullOrEmpty(Slice(x)) Then BikesPer(StationNum) += 1
            NonVoidBikesPer(StationNum) = BikesPer(StationNum)
        Next
        '
        For x = 1 To 15
            If Slice(x) = "VOID" Then NonVoidBikesPer(StationNum) -= 1
        Next
        '
        StationNum += 1
    End Sub
    '...


    Public Sub GetBrokenBikes()
        If SkipRow = True Then
            Maintenance.BrokenBikes.Items.Add(Slice(1))
            OfStation.Add(Slice(2))
        End If
        SkipRow = True
        If Not TempShortt = 0 Then DescriptionList.Add(Slice(2))
        TempShortt += 1
    End Sub
    '...


    Public Sub UpdateRepairLog()
        If Slice(1) = TempTwo Then
            For x = 0 To 2
                MyString += Slice(x) & If(Not x = 2, ",", "")
            Next
            WriteData(TempData, False, MyString)
        Else
            For x = 0 To 2
                MyString += Slice(x) & If(Not x = 2, ",", "")
            Next
            WriteData(TempReturn, False, MyString)
        End If
    End Sub
    '...


    Public Sub ReturnFixedBike()
        Dim Y As SByte = ParsedFields(0)
        If Counter = Y Then
            For x = 0 To 15
                If x = BikesPer(Y) - NonVoidBikesPer(Y) Then
                    MyString += ParsedFields(1) & If(x < 15, ",", "")
                Else
                    MyString += Slice(x) & If(x < 15, ",", "")
                End If
            Next
        Else
            For x = 0 To 15
                MyString += Slice(x) & If(x < 15, ",", "")
            Next
        End If
        Counter += 1
        WriteData(TempLogins, False, MyString)
    End Sub
    '...


    Public Sub RemoveBikes()
        Dim C As Boolean = True
        If StationNum = Focused Then
            For x = BikesLeft + 1 To BikesPer(StationNum)
                If C = True Then MyString += DateTime.Now.ToString("HH:mm") & ","
                If C = True Then C = False
                MyString += Slice(x) & If(x < BikesPer(StationNum), ",", "")
            Next
            WriteData(Bikes, True, MyString)
            '
            For x = 0 To 14
                MyString += If(x <= BikesLeft, Slice(x) & If(x < 15, ",", ""), ",")
            Next
            WriteData(TempData, False, MyString)
        Else
            For x = 0 To 15
                MyString += (Slice(x) & If(x < 15, ",", ""))
            Next
            WriteData(TempData, False, MyString)
        End If
        Focused += 1
    End Sub
    '...


    Public Sub ReturnRentedBikes()
        MyString = ""
        If BikesPer(StationNum) < 16 Then
            For x = 0 To BikesPer(StationNum)
                MyString += Slice(x) & If(x = 15, "", ",")
            Next
            '
            For x = BikesPer(StationNum) + 1 To 15
                If BikesTaken > 0 Then
                    MyString += ParsedFields(BikesTaken + 1) & If(x = 15, "", ",")
                    BikesTaken -= 1
                Else MyString += If(x = 15, "", ",")
                End If
            Next
            WriteData(TempReturn, False, MyString)
        End If
        StationNum += 1
    End Sub
    '...


    Public Sub DeleteRentEntry(User As String)
        If Slice(0) = User Then
            For x = 0 To Slice.Length - 1
                MyString += (Slice(x) & If(x = Slice.Length - 1, "", ","))
            Next
            WriteData(TempData, False, MyString)
        Else
            For x = 0 To Slice.Length - 1
                MyString += (Slice(x) & If(x = Slice.Length - 1, "", ","))
            Next
            WriteData(TempBikes, False, MyString)
        End If
    End Sub
    '...


    Public Sub LockBike(Serial As String, Description As String)
        MyString = ""
        Dim Temp As SByte = 0
        Dim VoidBoolean As Boolean = False
        '
        For X = 1 To 15
            If Slice(X) = Serial Then
                Temp = X
                VoidBoolean = True
                SerialExist = True
                MyString = StationNum & "," & Serial & "," & If(String.IsNullOrEmpty(Description), "No Description Given", Description)
                WriteData(RepairLog, False, MyString)
            End If
        Next
        MyString = ""
        '
        MyString += Slice(0) & ","
        If VoidBoolean = True Then MyString += "VOID" & ","
        For X = 1 To 15
            If Not X = (Temp) And VoidBoolean = True Then
                MyString += Slice(X) & If(X = 15, "", If(Temp = 15 And X = 14, "", ","))
            ElseIf VoidBoolean = False Then
                MyString += Slice(X) & If(X = 15, "", ",")
            End If
        Next
        WriteData(TempData, False, MyString)
        StationNum += 1
    End Sub
    '...


    ' -=-=-=- Variables -=-=-=- '
    Public TempShortt As Short
    Public Slice As String()
    Public SkipRow As Boolean
    Public OfStation As New List(Of String)()
    Public DescriptionList As New List(Of String)()

End Module
