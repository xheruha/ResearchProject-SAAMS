Imports System.Data.SqlClient
Public Class Form1
    Public Shared LoginUsername As String
    Public Shared LoginSection As String
    Public Shared LoginFirstname As String
    Public Shared LoginLastname As String
    Public Shared LoginUserID As Integer
    Public Shared LoginSchoolYear As String
    Public Shared LoginSchoolYear2 As String

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
            Form1.LoginUsername = dr("Username").ToString()
            Form1.LoginFirstname = dr("Firstname").ToString()
            Form1.LoginLastname = dr("Lastname").ToString()
            Form1.LoginUserID = Convert.ToInt32(dr("UserID"))
            Form1.LoginSection = dr("Section").ToString()
            Form1.LoginSchoolYear = dr("SchoolYear").ToString()
            Form1.LoginSchoolYear2 = dr("SchoolYear2").ToString()
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