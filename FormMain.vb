Imports System.IO
Imports System.Data.SqlClient

Public Class FormMain
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String


    Private Sub ProfileInfo()
        lblFname.Text = Form1.LoginFirstname
        lblLname.Text = Form1.LoginLastname

        If Not String.IsNullOrEmpty(Form1.LoginSchoolYear2) Then
            lblSYdep.Text = "SY: " & Form1.LoginSchoolYear & "/ " & Form1.LoginSchoolYear2 & " - Computer Science"
        Else
            lblSYdep.Text = "SY: " & Form1.LoginSchoolYear & " - Computer Science"
        End If
    End Sub


    Private Sub MainItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSem.Items.Clear()
        cmbSem.Items.Add("First Semester")
        cmbSem.Items.Add("Second Semester")
        cmbSem.SelectedIndex = -1

        cmbTerm.Items.Clear()
        cmbTerm.Items.Add("Prelim")
        cmbTerm.Items.Add("Midterm")
        cmbTerm.Items.Add("Final")
        cmbTerm.SelectedIndex = -1

        cmbCat.Items.Clear()
        cmbCat.Items.Add("Written Works")
        cmbCat.Items.Add("Performance Task")
        cmbCat.Items.Add("Exam")
        cmbCat.SelectedIndex = -1

        cmbSub.Items.Clear()
        cmbSub.SelectedIndex = -1

        cmbSY.Items.Clear()
        cmbSY.Items.Add("1st Year")
        cmbSY.Items.Add("2nd Year")
        cmbSY.Items.Add("3rd Year")
        cmbSY.Items.Add("4th Year")
        cmbSY.SelectedIndex = -1
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProfileInfo()
    End Sub


    Private Sub InitSections()
        cmbSection.Items.Clear()

        If cmbSY.SelectedItem Is Nothing Then
            cmbSection.SelectedIndex = -1
            Return
        End If

        Select Case cmbSY.SelectedItem.ToString()
            Case "1st Year"
                cmbSection.Items.AddRange(New String() {"Mega", "Kilo"})
            Case "2nd Year"
                cmbSection.Items.AddRange(New String() {"Deca", "Penta"})
            Case "3rd Year"
                cmbSection.Items.AddRange(New String() {"Hexa", "Octa"})
            Case "4th Year"
                cmbSection.Items.Add("Sigma")
        End Select

        If cmbSection.Items.Count > 0 Then
            cmbSection.SelectedIndex = 0
        Else
            cmbSection.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmbSY_Load(sender As Object, e As EventArgs) Handles cmbSY.SelectedIndexChanged
        InitSections()
        LoadStudents()
        SubjectsCsv()
    End Sub


    Private Sub cmbCat_No(sender As Object, e As EventArgs) Handles cmbCat.SelectedIndexChanged
        cmbNumber.Items.Clear()

        If cmbCat.Text = "Exam" Then
            cmbNumber.Items.Add("1")
        Else
            For i As Integer = 1 To 10
                cmbNumber.Items.Add(i.ToString())
            Next
        End If

        If cmbNumber.Items.Count > 0 Then
            cmbNumber.SelectedIndex = 0
        Else
            cmbNumber.SelectedIndex = -1
        End If
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbSem.SelectedIndex = -1
        cmbTerm.SelectedIndex = -1
        cmbNumber.SelectedIndex = -1
        cmbCat.SelectedIndex = -1
        cmbSub.SelectedIndex = -1
        cmbSY.SelectedIndex = -1
        cmbSection.SelectedIndex = -1
        cmbStudent.SelectedIndex = -1
        txtScore.Clear()
        dtpSM.Value = Date.Today
    End Sub


    Private Sub LoadStudents()
        If cmbSection.SelectedItem Is Nothing OrElse cmbSY.SelectedItem Is Nothing Then Exit Sub
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "SELECT UserID, Firstname FROM tblUser WHERE SchoolYear = @sy AND Section = @sec"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@sy", cmbSY.Text.Trim())
        cmd.Parameters.AddWithValue("@sec", cmbSection.Text.Trim())

        dr = cmd.ExecuteReader()
        Dim studentList As New List(Of StudentItem)

        While dr.Read()
            Dim firstName As String = dr("Firstname").ToString()
            Dim userID As Integer = Convert.ToInt32(dr("UserID"))
            studentList.Add(New StudentItem(firstName, userID))
        End While

        dr.Close()
        cn.Close()

        cmbStudent.DataSource = Nothing
        cmbStudent.DataSource = studentList
        cmbStudent.DisplayMember = "Name"
        cmbStudent.ValueMember = "ID"
    End Sub


    Private Sub cmbSection_List(sender As Object, e As EventArgs) Handles cmbSection.SelectedIndexChanged
        LoadStudents()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbSem.Text = "" Or cmbTerm.Text = "" Or cmbCat.Text = "" Or cmbNumber.Text = "" Or cmbSub.Text = "" Or txtScore.Text = "" Or cmbStudent.SelectedIndex = -1 Then
            MsgBox("Please fill all the fields first.")
            Exit Sub
        End If

        Dim num As Integer
        Dim score As Double

        If Not Integer.TryParse(cmbNumber.Text.Trim, num) Then
            MsgBox("Invalid number format.")
            Exit Sub
        End If
        If Not Double.TryParse(txtScore.Text.Trim, score) Then
            MsgBox("Invalid score format.")
            Exit Sub
        End If
        If score > 99 Then
            MsgBox("Score is more than 2 digits. Please fix your score.")
            Exit Sub
        End If

        Dim cat As String = cmbCat.Text.Trim()
        Dim term As String = cmbTerm.Text.Trim()
        Dim sem As String = cmbSem.Text.Trim()
        Dim subj As String = cmbSub.Text.Trim()
        Dim selectedStudent = CType(cmbStudent.SelectedItem, StudentItem)
        Dim userID As Integer = selectedStudent.ID

        Try
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Open()

            sql = "INSERT INTO tblScore (UserID, Semester, Term, Subject, Category, Number, Score, DateSubmitted) " &
                  "VALUES (@uid, @sem, @term, @subj, @cat, @num, @score, @date)"

            Using cmd As New SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@uid", userID)
                cmd.Parameters.AddWithValue("@sem", sem)
                cmd.Parameters.AddWithValue("@term", term)
                cmd.Parameters.AddWithValue("@subj", subj)
                cmd.Parameters.AddWithValue("@cat", cat)
                cmd.Parameters.AddWithValue("@num", num)
                cmd.Parameters.AddWithValue("@score", score)
                cmd.Parameters.AddWithValue("@date", dtpSM.Value.Date)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Saved successfully.")
            btnVS.PerformClick()

        Catch ex As Exception
            MsgBox("Error while saving: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dvSrecord.SelectedRows.Count = 0 Then
            MsgBox("Please select a record to delete.")
            Exit Sub
        End If

        Dim scoreID As Integer = dvSrecord.SelectedRows(0).Cells("ScoreID").Value
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        sql = "DELETE FROM tblScore WHERE ScoreID = @ScoreID"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@ScoreID", scoreID)
        cmd.ExecuteNonQuery()
        cn.Close()

        MsgBox("Record deleted successfully.")
        btnVS.PerformClick()
    End Sub


    Private Sub btnViewScore_Click(sender As Object, e As EventArgs) Handles btnVS.Click
        If cmbStudent.SelectedIndex = -1 Then
            MsgBox("Please select a student first.")
            Exit Sub
        End If

        Dim selectedStudent = CType(cmbStudent.SelectedItem, StudentItem)
        Dim userID As Integer = selectedStudent.ID

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "SELECT s.ScoreID, u.Firstname, u.Lastname, s.Semester, s.Term, s.Subject, s.Category, s.Number, s.Score, s.DateSubmitted " &
          "FROM tblScore s INNER JOIN tblUser u ON s.UserID = u.UserID " &
          "WHERE s.UserID = @UserID"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@UserID", userID)

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adpt.Fill(tbl)
        dvSrecord.DataSource = tbl

        If dvSrecord.Columns.Contains("ScoreID") Then
            dvSrecord.Columns("ScoreID").Visible = False
        End If

        cn.Close()
    End Sub


    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If cmbStudent.SelectedIndex = -1 Then
            MsgBox("Please select a student first.")
            Exit Sub
        End If

        Dim selectedStudent = CType(cmbStudent.SelectedItem, StudentItem)
        Dim userID As Integer = selectedStudent.ID

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "SELECT s.ScoreID, u.Firstname, u.Lastname, s.Semester, s.Term, s.Subject, s.Category, s.Number, s.Score, s.DateSubmitted " &
          "FROM tblScore s INNER JOIN tblUser u ON s.UserID = u.UserID " &
          "WHERE s.UserID = @UserID"

        If cmbSem.SelectedIndex <> -1 Then sql &= " AND s.Semester = @Semester"
        If cmbSub.SelectedIndex <> -1 Then sql &= " AND s.Subject = @Subject"
        If cmbTerm.SelectedIndex <> -1 Then sql &= " AND s.Term = @Term"
        If cmbCat.SelectedIndex <> -1 Then sql &= " AND s.Category = @Category"


        Using cmd As New SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@UserID", userID)
            If cmbSem.SelectedIndex <> -1 Then cmd.Parameters.AddWithValue("@Semester", cmbSem.Text.Trim())
            If cmbSub.SelectedIndex <> -1 Then cmd.Parameters.AddWithValue("@Subject", cmbSub.Text.Trim())
            If cmbTerm.SelectedIndex <> -1 Then cmd.Parameters.AddWithValue("@Term", cmbTerm.Text.Trim())
            If cmbCat.SelectedIndex <> -1 Then cmd.Parameters.AddWithValue("@Category", cmbCat.Text.Trim())

            Dim adpt As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()
            adpt.Fill(tbl)
            dvSrecord.DataSource = tbl
        End Using
        cn.Close()

        If dvSrecord.Columns.Contains("ScoreID") Then
            dvSrecord.Columns("ScoreID").Visible = False
        End If
    End Sub


    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        If cmbSY.SelectedIndex = -1 Then
            MsgBox("Please select a year level first.")
            Exit Sub
        End If

        If cmbSection.SelectedIndex = -1 Then
            MsgBox("Please select a section first.")
            Exit Sub
        End If

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "SELECT UserID, Firstname, Lastname, Gender, SchoolYear, Section, Email, Password " &
          "FROM tblUser WHERE SchoolYear = @sy AND Section = @sec"

        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@sy", cmbSY.Text.Trim())
        cmd.Parameters.AddWithValue("@sec", cmbSection.Text.Trim())

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adpt.Fill(tbl)
        dvSrecord.DataSource = tbl

        If dvSrecord.Columns.Contains("UserID") Then dvSrecord.Columns("UserID").Visible = False
        If dvSrecord.Columns.Contains("Email") Then dvSrecord.Columns("Email").Visible = False
        If dvSrecord.Columns.Contains("Password") Then dvSrecord.Columns("Password").Visible = False

        cn.Close()
    End Sub


    Private Sub btnOverall_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If cmbStudent.SelectedIndex = -1 Or cmbSub.SelectedIndex = -1 Then
            MsgBox("Please select both student and subject.")
            Exit Sub
        End If

        Dim userID As Integer = CType(cmbStudent.SelectedItem, StudentItem).ID
        Dim subject As String = cmbSub.Text.Trim()

        Dim writtenAvg As Double = 0
        Dim performAvg As Double = 0
        Dim examScore As Double = 0

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "SELECT AVG(Score) FROM tblScore WHERE UserID = @uid AND Subject = @subj AND Category = 'Written Works'"
        Using cmd1 As New SqlCommand(sql, cn)
            cmd1.Parameters.AddWithValue("@uid", userID)
            cmd1.Parameters.AddWithValue("@subj", subject)
            Dim result1 = cmd1.ExecuteScalar()
            If Not IsDBNull(result1) Then writtenAvg = Convert.ToDouble(result1)
        End Using

        sql = "SELECT AVG(Score) FROM tblScore WHERE UserID = @uid AND Subject = @subj AND Category = 'Performance Task'"
        Using cmd2 As New SqlCommand(sql, cn)
            cmd2.Parameters.AddWithValue("@uid", userID)
            cmd2.Parameters.AddWithValue("@subj", subject)
            Dim result2 = cmd2.ExecuteScalar()
            If Not IsDBNull(result2) Then performAvg = Convert.ToDouble(result2)
        End Using

        sql = "SELECT TOP 1 Score FROM tblScore WHERE UserID = @uid AND Subject = @subj AND Category = 'Exam' ORDER BY DateSubmitted DESC"
        Using cmd3 As New SqlCommand(sql, cn)
            cmd3.Parameters.AddWithValue("@uid", userID)
            cmd3.Parameters.AddWithValue("@subj", subject)
            Dim result3 = cmd3.ExecuteScalar()
            If Not IsDBNull(result3) Then examScore = Convert.ToDouble(result3)
        End Using

        cn.Close()

        Dim overallGrade As Double = (writtenAvg * 0.3) + (performAvg * 0.3) + (examScore * 0.4)
        txtCompute.Text = Math.Round(overallGrade, 2).ToString()
    End Sub


    Private Sub SubjectsCsv()
        cmbSub.Items.Clear()
        Dim filePath As String = Path.Combine(Application.StartupPath, "Subject_List.csv")
        If Not File.Exists(filePath) Then
            MsgBox("Could not find Subject_List.csv in " & filePath, MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim lines() As String = File.ReadAllLines(filePath)
        If lines.Length < 2 Then Exit Sub

        Dim userYear1 As String = Form1.LoginSchoolYear.Trim()
        Dim userYear2 As String = Form1.LoginSchoolYear2.Trim()
        Dim userSem As String = cmbSem.Text.Trim()

        For i As Integer = 1 To lines.Length - 1
            Dim row() As String = lines(i).Split(","c)
            If row.Length >= 3 Then

                Dim yearLevel As String = row(0).Trim()
                Dim semester As String = row(1).Trim()
                Dim subjectName As String = row(2).Trim()
                Dim isAdmin As Boolean = (userYear1 = "Admin")
                Dim semMatch As Boolean = (isAdmin OrElse semester.Equals(userSem, StringComparison.OrdinalIgnoreCase))
                Dim yearMatch As Boolean =
                isAdmin OrElse
                yearLevel.Equals(userYear1, StringComparison.OrdinalIgnoreCase) OrElse
                yearLevel.Equals(userYear2, StringComparison.OrdinalIgnoreCase)

                If semMatch AndAlso yearMatch Then
                    If Not cmbSub.Items.Contains(subjectName) Then
                        cmbSub.Items.Add(subjectName)
                    End If
                End If

            End If
        Next

        If cmbSub.Items.Count > 0 Then
            cmbSub.SelectedIndex = 0
        End If
    End Sub


    Private Sub Subject_Items(sender As Object, e As EventArgs) Handles cmbSem.SelectedIndexChanged
        SubjectsCsv()
    End Sub


    Private Class StudentItem
        Public Property Name As String
        Public Property ID As Integer

        Public Sub New(name As String, id As Integer)
            Me.Name = name
            Me.ID = id
        End Sub
    End Class


    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim out As DialogResult = MsgBox("Would you like to log out?", MsgBoxStyle.YesNo, "Logout")
        If out = DialogResult.Yes Then
            Form1.LoginEmail = Nothing
            Form1.LoginLastname = Nothing
            Form1.LoginSection = Nothing
            Form1.LoginUserID = Nothing

            Form1.txtEmail.Clear()
            Form1.txtPass.Clear()
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class