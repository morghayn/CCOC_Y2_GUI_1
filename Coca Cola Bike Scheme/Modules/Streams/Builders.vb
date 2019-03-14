Imports System.IO

Module Builders

    ' - Globally Used Variables
    Public MyString As String = ""
    Public ExportList As String()
    Public RowScanner As String()
    Public ParsedFields As String()


    Public Sub WipeFile(CSV As String)
        Using sw As StreamWriter = File.CreateText(CSV)
            sw.Close()
        End Using
    End Sub
    '
    ' -> Wipes CSV Passed Through Parameters


    Public Sub TransferData(A As String, B As String, C As Boolean)
        Using sr As New StreamReader(A)
            Dim currentRow As String = sr.ReadLine()
            WriteData(B, C, currentRow)
            sr.Close()
        End Using
    End Sub
    '
    ' -> Reads One-Line CSV files and Exports Them To WriteTempData()
    '
    Public Sub WriteData(B As String, C As Boolean, currentRow As String)
        currentRow = If(C = True, GetUsername() & "," & currentRow, currentRow)
        Using sw As StreamWriter = File.AppendText(B)
            sw.Write(currentRow)
            sw.WriteLine()
            sw.Close()
        End Using
        MyString = ""
    End Sub
    '
    ' -> Appends Text to a CSV-file (B)


    Public Sub ExportEntireCSV(CSV As String, ExportTo As String)
        Using sr As New StreamReader(CSV)
            While Not sr.EndOfStream
                MyString = sr.ReadLine
                WriteData(ExportTo, False, MyString)
            End While
            sr.Close()
        End Using
    End Sub
    '
    ' -> Exports CSV-File To Another (**Usually Temp -> Permanent)


    Public Sub ExportListToTemp(CSV As String)
        Using sw As StreamWriter = File.CreateText(CSV)
            For item = 0 To (ExportList.Length - 2)
                sw.Write(ExportList(item) & ",")
            Next
            sw.Write(ExportList(ExportList.Length - 1))
            sw.Close()
        End Using
        Array.Clear(ExportList, 0, ExportList.Length)
    End Sub
    '
    ' -> ExportList which is a globally available array is written to a CSV


    Public Sub ParseFields(CSV As String)
        Using sr As New FileIO.TextFieldParser(CSV)
            sr.TextFieldType = FileIO.FieldType.Delimited
            sr.SetDelimiters(",")
            ParsedFields = sr.ReadFields()
            sr.Close()
        End Using
    End Sub
    '
    ' -> Parses single lined temp files
End Module