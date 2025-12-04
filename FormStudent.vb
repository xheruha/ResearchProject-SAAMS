Imports System.IO
Imports System.Data.SqlClient
Public Class FormStudent
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String


    Private Sub ProfileInfo()
        lblFname.Text = Form1.LoginFirstname
        lblLname.Text = Form1.LoginLastname
        lblSec.Text = "Section: " & Form1.LoginSection

        If Not String.IsNullOrEmpty(Form1.LoginSchoolYear2) Then
            lblSYdep.Text = "SY: " & Form1.LoginSchoolYear & "/  " & Form1.LoginSchoolYear2 & " - Computer Science"
        Else
            lblSYdep.Text = "SY: " & Form1.LoginSchoolYear & " - Computer Science"
        End If
    End Sub


    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProfileInfo()
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
        cmbCat.Items.Add("Quiz")
        cmbCat.Items.Add("Activity")
        cmbCat.Items.Add("Assignment")
        cmbCat.Items.Add("Exam")
        cmbCat.SelectedIndex = -1

        cmbSub.Items.Clear()
        cmbSub.SelectedIndex = -1
    End Sub


    Private Sub cmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCat.SelectedIndexChanged
        cmbNumber.Items.Clear()
        If cmbCat.Text = "Exam" Then
            cmbNumber.Items.Add("1")
        Else
            For i As Integer = 1 To 10
                cmbNumber.Items.Add(i.ToString())
            Next
        End If
        cmbNumber.SelectedIndex = 0
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

        If dvSrecord.Columns.Contains("Firstname") Then dvSrecord.Columns("Firstname").Visible = False
        If dvSrecord.Columns.Contains("Lastname") Then dvSrecord.Columns("Lastname").Visible = False
        If dvSrecord.Columns.Contains("Section") Then dvSrecord.Columns("Section").Visible = False
        If dvSrecord.Columns.Contains("ScoreID") Then dvSrecord.Columns("ScoreID").Visible = False

        cn.Close()
    End Sub


    Private Sub SubjectsCsv()
        cmbSub.Items.Clear()
        Dim filePath As String = Path.Combine(Application.StartupPath, "Subject_List.csv")
        If Not File.Exists(filePath) Then
            MsgBox("Could not find file in " & filePath, MsgBoxStyle.Critical)
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

                If semester.Equals(userSem, StringComparison.OrdinalIgnoreCase) Then
                    If yearLevel.Equals(userYear1, StringComparison.OrdinalIgnoreCase) OrElse
                   yearLevel.Equals(userYear2, StringComparison.OrdinalIgnoreCase) Then
                        If Not cmbSub.Items.Contains(subjectName) Then cmbSub.Items.Add(subjectName)
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


    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        sql = "SELECT ScoreID, Firstname, Lastname, Section, Semester, Term, Subject, Category, Number, Score, DateSubmitted FROM tblScore WHERE UserID = @UserID"
        If cmbSem.SelectedIndex <> -1 Then sql &= " AND Semester = @Semester"
        If cmbSub.SelectedIndex <> -1 Then sql &= " AND Subject = @Subject"
        If cmbTerm.SelectedIndex <> -1 Then sql &= " AND Term = @Term"
        If cmbCat.SelectedIndex <> -1 Then sql &= " AND Category = @Category"


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
        cn.Close()

        If dvSrecord.Columns.Contains("Firstname") Then dvSrecord.Columns("Firstname").Visible = False
        If dvSrecord.Columns.Contains("Lastname") Then dvSrecord.Columns("Lastname").Visible = False
        If dvSrecord.Columns.Contains("Section") Then dvSrecord.Columns("Section").Visible = False
        If dvSrecord.Columns.Contains("ScoreID") Then dvSrecord.Columns("ScoreID").Visible = False
    End Sub
End Class
