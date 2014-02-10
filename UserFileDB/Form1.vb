Imports System.IO

Public Class Form1

    Private Sub newPlainBtn_Click(sender As Object, e As EventArgs) Handles newPlainBtn.Click
        Dim plainPath As String = "C:\Work\Research\Visual Basic\UserFileDB\Resources\userPlain.ccorp"

        Dim createFileAns
        Dim userString As String

        userString = userTxt.Text & "," & passTxt.Text & vbCrLf

        'Plain Test
        If File.Exists(plainPath) Then
            If checkIfFileEmpty(plainPath) Then
                MsgBox("File is empty.  Writing")
                File.WriteAllText(plainPath, userString)
                'Dim sw As New StreamWriter(plainPath)
                'sw.Write(userString)
                'sw.Close()
            Else
                MsgBox("File is not empty.  Appending.")
                File.AppendAllText(plainPath, userString)
                'Dim sw As New StreamWriter(plainPath)
                'sw.WriteLine(userString)
                'sw.Close()
            End If
        Else
            createFileAns = MsgBox("File doesn't exist.  Create it?", MsgBoxStyle.YesNo)
            If createFileAns = vbYes Then
                MsgBox("File created")
                File.Create(plainPath)
            Else
                MsgBox("File not created")
                userTxt.Clear()
                passTxt.Clear()
                Exit Sub
            End If
        End If

        userTxt.Clear()
        passTxt.Clear()

    End Sub

    Private Sub binBtn_Click(sender As Object, e As EventArgs) Handles binBtn.Click
        Dim binPath As String = "C:\Work\Research\Visual Basic\UserFileDB\Resources\userBin.ccorp"

        Dim writer As BinaryWriter

        Dim createFileAns
        Dim userString As String

        userString = userTxt.Text & "," & passTxt.Text & vbCrLf


        'Binary
        If File.Exists(binPath) Then
            If checkIfFileEmpty(binPath) Then
                MsgBox("File is empty.  Writing")
                writer = New BinaryWriter(File.Open(binPath, FileMode.Create))
                writer.Write(userString)
                writer.Close()
            Else
                MsgBox("File is not empty.  Appending.")
                writer = New BinaryWriter(File.Open(binPath, FileMode.Append))
                writer.Write(userString)
                writer.Close()
            End If
        Else
            createFileAns = MsgBox("File doesn't exist.  Create it?", MsgBoxStyle.YesNo)
            If createFileAns = vbYes Then
                MsgBox("File created")
                File.Create(binPath)
            Else
                MsgBox("File not created")
                userTxt.Clear()
                passTxt.Clear()
                Exit Sub
            End If
        End If

        userTxt.Clear()
        passTxt.Clear()

    End Sub

    Private Function checkIfFileEmpty(tempPath As String) As Boolean
        Dim tempContent As String
        Dim sr As New StreamReader(tempPath)

        tempContent = sr.ReadToEnd
        sr.Close()

        If tempContent.Equals(String.Empty) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub loadPlainBtn_Click(sender As Object, e As EventArgs) Handles loadPlainBtn.Click

        Dim userSet As New DataTable
        Dim userRow As DataRow

        userSet.Columns.Add("Username", GetType(String))
        userSet.Columns.Add("Password", GetType(String))

        Dim plainPath As String = "C:\Work\Research\Visual Basic\UserFileDB\Resources\userPlain.ccorp"
        Dim tempContent As String
        Dim splitString

        If File.Exists(plainPath) Then
            If checkIfFileEmpty(plainPath) Then
                MsgBox("File is empty, nothing to read")
                Exit Sub
            Else
                Dim sr As New StreamReader(plainPath)
                Do
                    tempContent = sr.ReadLine()
                    If IsNothing(tempContent) Then
                        Exit Do
                    Else
                        userRow = userSet.NewRow
                        splitString = Split(tempContent, ",")
                        userRow("Username") = splitString(0)
                        userRow("Password") = splitString(1)
                        userSet.Rows.Add(userRow)
                    End If
                Loop
                sr.Close()
                DataGridView1.DataSource = userSet
            End If
        Else
            MsgBox("File doesn't exist")
            Exit Sub
        End If

    End Sub

    Private Sub loadBinBtn_Click(sender As Object, e As EventArgs) Handles loadBinBtn.Click
        Dim userSet As New DataTable
        Dim userRow As DataRow

        userSet.Columns.Add("Username", GetType(String))
        userSet.Columns.Add("Password", GetType(String))

        Dim binPath As String = "C:\Work\Research\Visual Basic\UserFileDB\Resources\userBin.ccorp"
        Dim tempContent As String
        Dim splitString

        If File.Exists(binPath) Then
            If checkIfFileEmpty(binPath) Then
                MsgBox("File is empty, nothing to read")
                Exit Sub
            Else
                Dim reader As New BinaryReader(File.Open(binPath, FileMode.Open))

                Do
                    If reader.PeekChar() <> -1 Then
                        tempContent = Trim(reader.ReadString)
                        userRow = userSet.NewRow
                        splitString = Split(tempContent, ",")
                        userRow("Username") = splitString(0)
                        userRow("Password") = splitString(1)
                        userSet.Rows.Add(userRow)
                    Else
                        Exit Do
                    End If
                Loop
                reader.Close()
                DataGridView1.DataSource = userSet
            End If
        Else
            MsgBox("File doesn't exist")
            Exit Sub
        End If
    End Sub

    Private Sub userEncyptedBtn_Click(sender As Object, e As EventArgs) Handles userEncyptedBtn.Click
        Dim plainPath As String = "C:\Work\Research\Visual Basic\UserFileDB\Resources\userEnc.ccorp"

        Dim createFileAns
        Dim userString As String
        Dim keyString As String = "checkEng00"

        userString = userTxt.Text & "," & passTxt.Text

        'Plain Test
        If File.Exists(plainPath) Then
            If checkIfFileEmpty(plainPath) Then
                MsgBox("File is empty.  Writing")
                Dim wrapper As New Simple3Des(keyString)
                Dim cipherText As String = wrapper.encryptData(userString)
                File.WriteAllText(plainPath, cipherText & vbCrLf)
            Else
                MsgBox("File is not empty.  Appending.")
                Dim wrapper As New Simple3Des(keyString)
                Dim cipherText As String = wrapper.encryptData(userString)
                File.AppendAllText(plainPath, cipherText & vbCrLf)
            End If
        Else
            createFileAns = MsgBox("File doesn't exist.  Create it?", MsgBoxStyle.YesNo)
            If createFileAns = vbYes Then
                MsgBox("File created")
                File.Create(plainPath)
            Else
                MsgBox("File not created")
                userTxt.Clear()
                passTxt.Clear()
                Exit Sub
            End If
        End If

        userTxt.Clear()
        passTxt.Clear()

    End Sub

    Private Sub loadEncryptedBtn_Click(sender As Object, e As EventArgs) Handles loadEncryptedBtn.Click
        Dim userSet As New DataTable
        Dim userRow As DataRow

        userSet.Columns.Add("Username", GetType(String))
        userSet.Columns.Add("Password", GetType(String))

        Dim plainPath As String = "C:\Work\Research\Visual Basic\UserFileDB\Resources\userEnc.ccorp"
        Dim tempContent As String
        Dim splitString
        Dim decText As String

        If File.Exists(plainPath) Then
            If checkIfFileEmpty(plainPath) Then
                MsgBox("File is empty, nothing to read")
                Exit Sub
            Else
                Dim wrapper As New Simple3Des("checkEng00")
                Dim sr As New StreamReader(plainPath)
                Do
                    tempContent = sr.ReadLine()
                    If IsNothing(tempContent) Then
                        Exit Do
                    Else
                        decText = wrapper.decryptData(tempContent)
                        userRow = userSet.NewRow
                        splitString = Split(decText, ",")
                        userRow("Username") = splitString(0)
                        userRow("Password") = splitString(1)
                        userSet.Rows.Add(userRow)
                    End If
                Loop
                sr.Close()
                DataGridView1.DataSource = userSet
            End If
        Else
            MsgBox("File doesn't exist")
            Exit Sub
        End If
        'Read the file
        'Decrpyt the data
        'Show the data
    End Sub
End Class
