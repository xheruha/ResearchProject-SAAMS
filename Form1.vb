Imports System.Data.SqlClient
Public Class Form1
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        sql = "SELECT * FROM tblUser WHERE Username = @Username AND Password = @Password"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Username", txtUser.Text.Trim())
        cmd.Parameters.AddWithValue("@Password", txtPass.Text.Trim())

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            MsgBox("Login Successful", MsgBoxStyle.Information)
            Form3.LoggedInUsername = dr("Username").ToString()
            Form3.LoggedInFirstname = dr("Firstname").ToString()
            Form3.LoggedInLastname = dr("Lastname").ToString()
            Form3.LoggedInUserID = Convert.ToInt32(dr("UserID"))
            Form3.LoggedInSection = dr("Section").ToString()
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("Login Failed", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class