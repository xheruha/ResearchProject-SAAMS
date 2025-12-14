Imports System.Data.SqlClient
Public Class FormLeaderboard

    Private ReadOnly cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Private cmd As SqlCommand
    Private sql As String


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

        cmbSect.SelectedIndex = 0
        cmbSem.Items.Clear()
        cmbSem.Items.Add("First Semester")
        cmbSem.Items.Add("Second Semester")
        cmbSem.SelectedIndex = 0

        cmbTerm.Items.Clear()
        cmbTerm.Items.Add("Prelim")
        cmbTerm.Items.Add("Midterm")
        cmbTerm.Items.Add("Final")
        cmbTerm.SelectedIndex = 0
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbSect.SelectedIndex = -1
        cmbSem.SelectedIndex = -1
        cmbTerm.SelectedIndex = -1
        dvLB.DataSource = Nothing
    End Sub


    Private Sub btnOV_Click(sender As Object, e As EventArgs) Handles btnOV.Click
        Dim sectionFilter As String = cmbSect.Text.Trim()
        Dim yearFilter As String = Form1.LoginSchoolYear.Trim()
        Dim semFilter As String = cmbSem.Text.Trim()
        Dim termFilter As String = cmbTerm.Text.Trim()

        If termFilter = "" Or termFilter = "Overall" Then
            LoadPeriodic(sectionFilter, yearFilter, semFilter, "")
        Else
            LoadPeriodic(sectionFilter, yearFilter, semFilter, termFilter)
        End If
    End Sub


    Private Sub LoadPeriodic(section As String, yearLevel As String, semester As String, term As String)
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "
    SELECT 
        u.UserID,
        u.Firstname,
        u.Lastname,
        u.Section,
        u.SchoolYear,
        LEAST(100, ROUND(AVG(SubjectGrade), 2)) AS ComputedGrade
    FROM tblUser u
    JOIN (
        SELECT 
            s.UserID,
            s.Subject,
            (
                (SUM(CASE WHEN s.Category IN ('Quiz','Activity','Assignment') THEN s.Score ELSE 0 END) * 2
                + MAX(CASE WHEN s.Category = 'Exam' THEN s.Score ELSE 0 END)
            ) / 3
        ) AS SubjectGrade
        FROM tblScore s
        WHERE s.Semester = @Semester
    "
        If term <> "" Then
            sql &= " AND s.Term = @Term"
        End If

        sql &= "
        GROUP BY s.UserID, s.Subject
    ) G ON u.UserID = G.UserID
    "

        Dim filters As New List(Of String)
        If section <> "" Then filters.Add("u.Section = @Section")
        If yearLevel <> "" Then filters.Add("u.SchoolYear = @Year")
        If filters.Count > 0 Then
            sql &= " WHERE " & String.Join(" AND ", filters)
        End If

        sql &= "
        GROUP BY u.UserID, u.Firstname, u.Lastname, u.Section, u.SchoolYear
        ORDER BY ComputedGrade DESC
    "

        cmd = New SqlCommand(sql, cn)
        If section <> "" Then cmd.Parameters.AddWithValue("@Section", section)
        If yearLevel <> "" Then cmd.Parameters.AddWithValue("@Year", yearLevel)
        cmd.Parameters.AddWithValue("@Semester", semester)
        If term <> "" Then cmd.Parameters.AddWithValue("@Term", term)


        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adpt.Fill(tbl)
        dvLB.DataSource = tbl

        If dvLB.Columns.Contains("UserID") Then dvLB.Columns("UserID").Visible = False
        If tbl.Rows.Count > 0 Then
            Dim grade As Double = Convert.ToDouble(tbl.Rows(0)("ComputedGrade"))
            Dim statusMessage As String = ""

            Select Case grade
                Case < 65
                    statusMessage = "Performance below expectations."
                Case 65 To 74.99
                    statusMessage = "Needs improvement."
                Case 75 To 80
                    statusMessage = "Satisfactory standing."
                Case 80.01 To 89.99
                    statusMessage = "Good progress."
                Case >= 90
                    statusMessage = "Excellent performance."
            End Select

            lblStatus.Text = statusMessage
        Else
            lblStatus.Text = "No records found."
        End If

        cn.Close()
    End Sub
End Class
