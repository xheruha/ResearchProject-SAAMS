Imports System.Data.SqlClient

Public Class FormLeaderboard
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim sql As String

    Private Sub FormLeaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSect.Items.Clear()
        Select Case Form1.LoginSchoolYear.Trim()
            Case "1st Year"
                cmbSect.Items.Add("Mega")
                cmbSect.Items.Add("Kilo")
            Case "2nd Year"
                cmbSect.Items.Add("Deca")
                cmbSect.Items.Add("Penta")
            Case "3rd Year"
                cmbSect.Items.Add("Hexa")
                cmbSect.Items.Add("Octa")
            Case "4th Year"
                cmbSect.Items.Add("Sigma")
        End Select
        cmbSect.SelectedIndex = -1

        cmbSem.Items.Clear()
        cmbSem.Items.Add("First Semester")
        cmbSem.Items.Add("Second Semester")
        cmbSem.SelectedIndex = -1

        cmbTerm.Items.Clear()
        cmbTerm.Items.Add("Prelim")
        cmbTerm.Items.Add("Midterm")
        cmbTerm.Items.Add("Final")
        cmbTerm.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbSect.SelectedIndex = -1
        cmbSem.SelectedIndex = -1
        cmbTerm.SelectedIndex = -1
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim sectionFilter As String = cmbSect.Text.Trim()
        Dim yearFilter As String = Form1.LoginSchoolYear.Trim()
        Dim semFilter As String = cmbSem.Text.Trim()
        Dim termFilter As String = cmbTerm.Text.Trim()

        Select Case termFilter
            Case "Prelim"
                LoadPrelim(sectionFilter, yearFilter, semFilter)
            Case "Midterm"
                LoadMidterm(sectionFilter, yearFilter, semFilter)
            Case "Final"
                LoadFinal(sectionFilter, yearFilter, semFilter)
        End Select
    End Sub

    Private Sub btnOV_Click(sender As Object, e As EventArgs) Handles btnOV.Click
        Dim sectionFilter As String = cmbSect.Text.Trim()
        Dim yearFilter As String = Form1.LoginSchoolYear.Trim()
        Dim semFilter As String = cmbSem.Text.Trim()

        If String.IsNullOrEmpty(sectionFilter) Then
            MsgBox("Please select a section.", vbExclamation, "Validation Error")
            Exit Sub
        End If

        If String.IsNullOrEmpty(semFilter) Then
            MsgBox("Please select a semester.", vbExclamation, "Validation Error")
            Exit Sub
        End If
        LoadOverall(sectionFilter, yearFilter, semFilter)
    End Sub

    Private Sub LoadPrelim(section As String, yearLevel As String, semester As String)
        LoadRawTerm(section, yearLevel, semester, "Prelim")
    End Sub

    Private Sub LoadMidterm(section As String, yearLevel As String, semester As String)
        LoadRawTerm(section, yearLevel, semester, "Midterm")
    End Sub

    Private Sub LoadFinal(section As String, yearLevel As String, semester As String)
        LoadRawTerm(section, yearLevel, semester, "Final")
    End Sub

    Private Sub LoadRawTerm(section As String, yearLevel As String, semester As String, term As String)
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "SELECT u.UserID, u.Firstname, u.Lastname, u.Section, u.SchoolYear, " &
              "ROUND((SUM(CASE WHEN s.Category IN ('Quiz','Activity','Assignment') THEN s.Score ELSE 0 END) * 0.4 + " &
              "MAX(CASE WHEN s.Category = 'Exam' THEN s.Score ELSE 0 END) * 0.6), 2) AS ComputedGrade " &
              "FROM tblUser u JOIN tblScore s ON u.UserID = s.UserID "

        Dim filters As New List(Of String)
        If section <> "" Then filters.Add("u.Section = @Section")
        If yearLevel <> "" Then filters.Add("u.SchoolYear = @Year")
        If semester <> "" Then filters.Add("s.Semester = @Semester")
        If term <> "" Then filters.Add("s.Term = @Term")

        If filters.Count > 0 Then sql &= " WHERE " & String.Join(" AND ", filters)

        sql &= " GROUP BY u.UserID, u.Firstname, u.Lastname, u.Section, u.SchoolYear ORDER BY ComputedGrade DESC"

        cmd = New SqlCommand(sql, cn)
        If section <> "" Then cmd.Parameters.AddWithValue("@Section", section)
        If yearLevel <> "" Then cmd.Parameters.AddWithValue("@Year", yearLevel)
        If semester <> "" Then cmd.Parameters.AddWithValue("@Semester", semester)
        If term <> "" Then cmd.Parameters.AddWithValue("@Term", term)

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adpt.Fill(tbl)
        dvLB.DataSource = tbl

        If dvLB.Columns.Contains("UserID") Then dvLB.Columns("UserID").Visible = False
        cn.Close()
    End Sub

    Private Sub LoadOverall(section As String, yearLevel As String, semester As String)
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "SELECT u.UserID, u.Firstname, u.Lastname, u.Section, u.SchoolYear, " &
              "ROUND((" &
              "(SUM(CASE WHEN s.Category IN ('Quiz','Activity','Assignment') THEN s.Score ELSE 0 END) * 0.4 + " &
              "MAX(CASE WHEN s.Category = 'Exam' THEN s.Score ELSE 0 END) * 0.6) + " &
              "ISNULL((" &
              "SELECT ROUND((" &
              "(SUM(CASE WHEN s2.Category IN ('Quiz','Activity','Assignment') THEN s2.Score ELSE 0 END) * 0.4 + " &
              "MAX(CASE WHEN s2.Category = 'Exam' THEN s2.Score ELSE 0 END) * 0.6) + " &
              "ISNULL((" &
              "SELECT ROUND((" &
              "SUM(CASE WHEN s3.Category IN ('Quiz','Activity','Assignment') THEN s3.Score ELSE 0 END) * 0.4 + " &
              "MAX(CASE WHEN s3.Category = 'Exam' THEN s3.Score ELSE 0 END) * 0.6), 2) " &
              "FROM tblScore s3 WHERE s3.UserID = u.UserID AND s3.Semester = s.Semester AND s3.Term = 'Prelim' GROUP BY s3.UserID), 0) / 2" &
              "), 2) " &
              "FROM tblScore s2 WHERE s2.UserID = u.UserID AND s2.Semester = s.Semester AND s2.Term = 'Midterm' GROUP BY s2.UserID), 0) / 2" &
              "), 2) AS ComputedGrade " &
              "FROM tblUser u JOIN tblScore s ON u.UserID = s.UserID "

        Dim filters As New List(Of String)
        If section <> "" Then filters.Add("u.Section = @Section")
        If yearLevel <> "" Then filters.Add("u.SchoolYear = @Year")
        If semester <> "" Then filters.Add("s.Semester = @Semester")

        If filters.Count > 0 Then sql &= " WHERE " & String.Join(" AND ", filters)

        sql &= " GROUP BY u.UserID, u.Firstname, u.Lastname, u.Section, u.SchoolYear, s.Semester ORDER BY ComputedGrade DESC"

        cmd = New SqlCommand(sql, cn)
        If section <> "" Then cmd.Parameters.AddWithValue("@Section", section)
        If yearLevel <> "" Then cmd.Parameters.AddWithValue("@Year", yearLevel)
        If semester <> "" Then cmd.Parameters.AddWithValue("@Semester", semester)

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adpt.Fill(tbl)
        dvLB.DataSource = tbl

        If dvLB.Columns.Contains("UserID") Then dvLB.Columns("UserID").Visible = False
        cn.Close()
    End Sub

End Class