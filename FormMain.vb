Imports System.Data.SqlClient
Public Class FormMain
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If cmbSem.Text = "" Or txtSub.Text = "" Or cmbCat.Text = "" Or cmbTerm.Text = "" Or cmbNumber.Text = "" Or txtScore.Text = "" Then
            MsgBox("Please fill in all fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim numberVal As Integer, scoreVal As Double
        If Not Integer.TryParse(cmbNumber.Text.Trim(), numberVal) OrElse Not Double.TryParse(txtScore.Text.Trim(), scoreVal) Then
            MsgBox("Invalid number or score format.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim catVal As String = cmbCat.Text.Trim()
        Dim termVal As String = cmbTerm.Text.Trim()
        Dim semVal As String = cmbSem.Text.Trim()
        Dim subjVal As String = txtSub.Text.Trim()

        Try
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Open()

            sql = "INSERT INTO tblScore (UserID, Firstname, Lastname, Section, Semester, Term, Subject, Category, Number, Score, DateSubmitted)
               VALUES (@UserID, @Firstname, @Lastname, @Section, @Semester, @Term, @Subject, @Category, @Number, @Score, @DateSubmitted)"

            cmd = New SqlCommand(sql, cn)
            With cmd.Parameters
                .AddWithValue("@UserID", Form3.LoggedInUserID)
                .AddWithValue("@Firstname", Form3.LoggedInFirstname)
                .AddWithValue("@Lastname", Form3.LoggedInLastname)
                .AddWithValue("@Section", Form3.LoggedInSection)
                .AddWithValue("@Semester", semVal)
                .AddWithValue("@Term", termVal)
                .AddWithValue("@Subject", subjVal)
                .AddWithValue("@Category", catVal)
                .AddWithValue("@Number", numberVal)
                .AddWithValue("@Score", scoreVal)
                .AddWithValue("@DateSubmitted", dtpSM.Value.Date)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("Saved successfully!", MsgBoxStyle.Information)

            sql = "SELECT ScoreID, Firstname, Lastname, Section, Semester, Term, Subject, Category, Number, Score, DateSubmitted 
               FROM tblScore WHERE UserID = @UserID"
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@UserID", Form3.LoggedInUserID)

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            dvSrecord.DataSource = dt

        Catch ex As SqlException
            If ex.Number = 2627 Then
                MsgBox("Duplicate entry: This number already exists for this term and semester.", MsgBoxStyle.Exclamation)
            Else
                MsgBox("SQL Error: " & ex.Message, MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Unexpected Error: " & ex.Message, MsgBoxStyle.Critical)

        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dvSrecord.SelectedRows.Count = 0 Then
            MsgBox("Select a row to delete.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim scoreID = Convert.ToInt32(dvSrecord.SelectedRows(0).Cells("ScoreID").Value)
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "DELETE FROM tblScore WHERE ScoreID = @id"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@id", scoreID)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Deleted successfully.", MsgBoxStyle.Information)
            btnVS.PerformClick()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnVS_Click(sender As Object, e As EventArgs) Handles btnVS.Click
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "SELECT ScoreID, Firstname, Lastname, Section, Semester, Term, Subject, Category, Number, Score, DateSubmitted FROM tblScore WHERE Firstname=@Firstname AND Lastname=@Lastname"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Firstname", Form3.LoggedInFirstname)
        cmd.Parameters.AddWithValue("@Lastname", Form3.LoggedInLastname)

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        dvSrecord.DataSource = dt
        cn.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub
End Class