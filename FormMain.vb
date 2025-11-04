Imports System.Data.SqlClient
Public Class FormMain
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

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
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbSem.SelectedIndex = -1
        cmbTerm.SelectedIndex = -1
        cmbNumber.SelectedIndex = -1
        cmbCat.SelectedIndex = -1
        txtSub.Clear()
        txtScore.Clear()
        dtpSM.Value = Date.Today
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbSem.Text = "" Or cmbTerm.Text = "" Or cmbCat.Text = "" Or cmbNumber.Text = "" Or txtSub.Text = "" Or txtScore.Text = "" Then
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
        Dim subj = txtSub.Text.Trim

        Try
            cn.Open()
            sql = "SELECT COUNT(*) FROM tblScore WHERE UserID=@Uid AND Number=@num AND Semester=@sem AND Term=@term AND Category=@cat"
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Uid", Form3.LoggedInUserID)
            cmd.Parameters.AddWithValue("@num", num)
            cmd.Parameters.AddWithValue("@sem", sem)
            cmd.Parameters.AddWithValue("@term", term)
            cmd.Parameters.AddWithValue("@cat", cat)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MsgBox("That number already exists under the same Semester, Term, or Category. Pick a different one", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            sql = "INSERT INTO tblScore (UserID, Firstname, Lastname, Section, Semester, Term, Subject, Category, Number, Score, DateSubmitted)" &
              "VALUES (@uid, @fname, @lname, @section, @sem, @term, @subj, @cat, @num, @score, @date)"
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Uid", Form3.LoggedInUserID)
            cmd.Parameters.AddWithValue("@fname", Form3.LoggedInFirstname)
            cmd.Parameters.AddWithValue("@lname", Form3.LoggedInLastname)
            cmd.Parameters.AddWithValue("@section", Form3.LoggedInSection)
            cmd.Parameters.AddWithValue("@sem", sem)
            cmd.Parameters.AddWithValue("@term", term)
            cmd.Parameters.AddWithValue("@subj", subj)
            cmd.Parameters.AddWithValue("@cat", cat)
            cmd.Parameters.AddWithValue("@num", num)
            cmd.Parameters.AddWithValue("@score", score)
            cmd.Parameters.AddWithValue("@date", dtpSM.Value.Date)
            cmd.ExecuteNonQuery()
            MsgBox("Saved successfully.", MsgBoxStyle.Information)

            sql = "SELECT ScoreID, Firstname, Lastname, Section, Semester, Term, Subject, Category, Number, Score, DateSubmitted " &
              "FROM tblScore WHERE UserID=@Uid"
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Uid", Form3.LoggedInUserID)

            Dim adpt As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable
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

        Catch ex As Exception
            MsgBox("Error while saving: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
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
        sql = "SELECT ScoreID, Firstname, Lastname, Section, Semester, Term, Subject, Category, Number, Score, DateSubmitted FROM tblScore WHERE Firstname=@Firstname AND Lastname=@Lastname"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Firstname", Form3.LoggedInFirstname)
        cmd.Parameters.AddWithValue("@Lastname", Form3.LoggedInLastname)

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

    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        sql = "SELECT Username, Firstname, Lastname, SchoolYear, Section FROM tblUser WHERE Username = @Username"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Username", Form3.LoggedInUsername)
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            lblUser.Text = "Username: " & dr("Username").ToString()
            lblFname.Text = dr("Firstname").ToString()
            lblLname.Text = dr("Lastname").ToString()
            lblSYdep.Text = "SY: " & dr("SchoolYear").ToString() & "- Computer Science"
            lblSec.Text = "Section: " & dr("Section").ToString()
        Else
            MsgBox("User not found.", MsgBoxStyle.Exclamation)
        End If
        dr.Close()
        cn.Close()
    End Sub
End Class