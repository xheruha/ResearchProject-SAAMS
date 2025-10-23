Imports System.Data.SqlClient

Public Class Form1
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        sql = "SELECT * FROM tblUser WHERE Email = @Email AND Password = @Password"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
        cmd.Parameters.AddWithValue("@Password", txtPass.Text.Trim())

        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            MsgBox("Login Successful", MsgBoxStyle.Information)
            Form3.LoggedInEmail = dr("Email").ToString()
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("Login Failed", MsgBoxStyle.Critical)
        End If

        dr.Close()
        cn.Close()
    End Sub


    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class