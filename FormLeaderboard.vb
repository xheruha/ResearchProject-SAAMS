Imports System.Data.SqlClient
Public Class FormLeaderboard
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim sql As String

    Private Sub FormLeaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbYear.Items.Clear()
        cmbYear.Items.AddRange(New String() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        cmbYear.SelectedIndex = -1
        cmbSect.Items.Clear()
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        If cmbYear.SelectedItem Is Nothing Then Exit Sub
        cmbSect.Items.Clear()

        Select Case cmbYear.SelectedItem.ToString()
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
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim sectionFilter As String = cmbSect.Text.Trim()
        Dim yearFilter As String = cmbYear.Text.Trim()
        LoadLeaderboard(sectionFilter, yearFilter)
    End Sub

    Private Sub LoadLeaderboard(section As String, yearLevel As String)
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "SELECT u.UserID, u.Firstname, u.Lastname, u.Section, u.SchoolYear, SUM(s.Score) AS TotalScore " &
              "FROM tblUser u JOIN tblScore s ON u.UserID = s.UserID "

        Dim filters As New List(Of String)
        If section <> "" Then filters.Add("u.Section = @Section")
        If yearLevel <> "" Then filters.Add("u.SchoolYear = @Year")

        If filters.Count > 0 Then
            sql &= "WHERE " & String.Join(" AND ", filters)
        End If

        sql &= " GROUP BY u.UserID, u.Firstname, u.Lastname, u.Section, u.SchoolYear " &
               " ORDER BY TotalScore DESC"

        cmd = New SqlCommand(sql, cn)
        If section <> "" Then cmd.Parameters.AddWithValue("@Section", section)
        If yearLevel <> "" Then cmd.Parameters.AddWithValue("@Year", yearLevel)

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adpt.Fill(tbl)
        dvLB.DataSource = tbl

        If dvLB.Columns.Contains("UserID") Then
            dvLB.Columns("UserID").Visible = False
        End If


        cn.Close()
    End Sub
End Class