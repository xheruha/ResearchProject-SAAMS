Imports System.IO
Imports System.Data.SqlClient
Public Class FormMain
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Private Sub ProfileInfo()
        lblUser.Text = "Username: " & Form1.LoginUsername
        lblFname.Text = Form1.LoginFirstname
        lblLname.Text = Form1.LoginLastname
        lblSec.Text = "Section: " & Form1.LoginSection
        lblSYdep.Text = "SY: " & Form1.LoginSchoolYear & "- Computer Science"
    End Sub

    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProfileInfo()
    End Sub

    Private Sub MainItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSem.Items.Clear()
        cmbSem.Items.Add("First Semester")
        cmbSem.Items.Add("Second Semester")

        cmbTerm.Items.Clear()
        cmbTerm.Items.Add("Prelim")
        cmbTerm.Items.Add("Midterm")
        cmbTerm.Items.Add("Final")

        cmbNumber.Items.Clear()
        For i As Integer = 1 To 10
            cmbNumber.Items.Add(i.ToString())
        Next

        cmbCat.Items.Clear()
        cmbCat.Items.Add("Quiz")
        cmbCat.Items.Add("Exam")
        cmbCat.Items.Add("Activity")
        cmbCat.Items.Add("Assignment")

        cmbSub.Items.Clear()
        cmbSem.SelectedIndex = -1
        cmbSub.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbSem.SelectedIndex = -1
        cmbTerm.SelectedIndex = -1
        cmbNumber.SelectedIndex = -1
        cmbCat.SelectedIndex = -1
        cmbSub.SelectedIndex = -1
        txtScore.Clear()
        dtpSM.Value = Date.Today
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbSem.Text = "" Or cmbTerm.Text = "" Or cmbCat.Text = "" Or cmbNumber.Text = "" Or cmbSub.Text = "" Or txtScore.Text = "" Then
            MsgBox("Please fill all the fields first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim num As Integer
        Dim score As Double

        If Not Integer.TryParse(cmbNumber.Text.Trim, num) Then
            MsgBox("Invalid number format.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Not Double.TryParse(txtScore.Text.Trim, score) Then
            MsgBox("Invalid score format.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim cat = cmbCat.Text.Trim
        Dim term = cmbTerm.Text.Trim
        Dim sem = cmbSem.Text.Trim
        Dim subj = cmbSub.Text.Trim

        Try
            cn.Open()
            sql = "INSERT INTO tblScore (UserID, Firstname, Lastname, Section, Semester, Term, Subject, Category, Number, Score, DateSubmitted)" &
          "VALUES (@uid, @fname, @lname, @section, @sem, @term, @subj, @cat, @num, @score, @date)"

            Using cmd As New SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@Uid", Form1.LoginUserID)
                cmd.Parameters.AddWithValue("@fname", Form1.LoginFirstname)
                cmd.Parameters.AddWithValue("@lname", Form1.LoginLastname)
                cmd.Parameters.AddWithValue("@section", Form1.LoginSection)
                cmd.Parameters.AddWithValue("@sem", sem)
                cmd.Parameters.AddWithValue("@term", term)
                cmd.Parameters.AddWithValue("@subj", subj)
                cmd.Parameters.AddWithValue("@cat", cat)
                cmd.Parameters.AddWithValue("@num", num)
                cmd.Parameters.AddWithValue("@score", score)
                cmd.Parameters.AddWithValue("@date", dtpSM.Value.Date)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Saved successfully.", MsgBoxStyle.Information)
            btnVS.PerformClick()
        Catch ex As Exception
            MsgBox("Error while saving: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dvSrecord.SelectedRows.Count = 0 Then
            MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
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

        MsgBox("Record deleted successfully.", MsgBoxStyle.Information)
        btnVS.PerformClick()
    End Sub

    Private Sub btnViewScore_Click(sender As Object, e As EventArgs) Handles btnVS.Click
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        sql = "SELECT ScoreID, Firstname, Lastname, Section, Semester, Term, Subject, Category, Number, Score, DateSubmitted FROM tblScore WHERE UserID=@UserID"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@UserID", Form1.LoginUserID)

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adpt.Fill(tbl)
        dvSrecord.DataSource = tbl

        If dvSrecord.Columns.Contains("Firstname") Then
            dvSrecord.Columns("Firstname").Visible = False
        End If
        If dvSrecord.Columns.Contains("Lastname") Then
            dvSrecord.Columns("Lastname").Visible = False
        End If
        If dvSrecord.Columns.Contains("Section") Then
            dvSrecord.Columns("Section").Visible = False
        End If
        cn.Close()
    End Sub

    Private Sub SubjectsCsv()
        Try
            cmbSub.Items.Clear()
            Dim filePath As String = Path.Combine(Application.StartupPath, "Subject_List.csv")

            If Not File.Exists(filePath) Then
                MsgBox("Could not find Subject_List.csv in " & filePath, MsgBoxStyle.Critical, "Missing File")
                Exit Sub
            End If

            Dim lines() As String = File.ReadAllLines(filePath)
            If lines.Length < 2 Then Exit Sub

            Dim userYear As String = Form1.LoginSchoolYear.Trim()
            Dim currentSem As String = cmbSem.Text.Trim()
            For i As Integer = 1 To lines.Length - 1
                Dim row() As String = lines(i).Split(","c)

                If row.Length >= 3 Then
                    Dim yearLevel As String = row(0).Trim()
                    Dim semester As String = row(1).Trim()
                    Dim subjectName As String = row(2).Trim()

                    If yearLevel.Equals(userYear, StringComparison.OrdinalIgnoreCase) AndAlso
                       semester.Equals(currentSem, StringComparison.OrdinalIgnoreCase) Then

                        If Not cmbSub.Items.Contains(subjectName) Then
                            cmbSub.Items.Add(subjectName)
                        End If
                    End If
                End If
            Next

            If cmbSub.Items.Count > 0 Then
                cmbSub.SelectedIndex = 0
            End If

        Catch err As Exception
            MsgBox("Something went wrong" & vbCrLf & err.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSem.SelectedIndexChanged
        SubjectsCsv()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Open()
            sql = "SELECT ScoreID, Firstname, Lastname, Section, Semester, Term, Subject, Category, Number, Score, DateSubmitted FROM tblScore WHERE UserID = @UserID"

            If cmbSem.SelectedIndex <> -1 Then
                sql &= " AND Semester = @Semester"
            End If
            If cmbSub.SelectedIndex <> -1 Then
                sql &= " AND Subject = @Subject"
            End If
            If cmbTerm.SelectedIndex <> -1 Then
                sql &= " AND Term = @Term"
            End If
            If cmbCat.SelectedIndex <> -1 Then
                sql &= " AND Category = @Category"
            End If

            Using cmd As New SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@UserID", Form1.LoginUserID)

                If cmbSem.SelectedIndex <> -1 Then cmd.Parameters.AddWithValue("@Semester", cmbSem.Text.Trim())
                If cmbSub.SelectedIndex <> -1 Then cmd.Parameters.AddWithValue("@Subject", cmbSub.Text.Trim())
                If cmbTerm.SelectedIndex <> -1 Then cmd.Parameters.AddWithValue("@Term", cmbTerm.Text.Trim())
                If cmbCat.SelectedIndex <> -1 Then cmd.Parameters.AddWithValue("@Category", cmbCat.Text.Trim())

                Dim adpt As New SqlDataAdapter(cmd)
                Dim tbl As New DataTable()
                adpt.Fill(tbl)
                dvSrecord.DataSource = tbl
            End Using

            If dvSrecord.Columns.Contains("Firstname") Then dvSrecord.Columns("Firstname").Visible = False
            If dvSrecord.Columns.Contains("Lastname") Then dvSrecord.Columns("Lastname").Visible = False
            If dvSrecord.Columns.Contains("Section") Then dvSrecord.Columns("Section").Visible = False

        Catch ex As Exception
            MsgBox("Error while filtering: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub
End Class
