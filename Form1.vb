Imports System.Data.SqlClient
Public Class Form1
    Public Shared LoginEmail As String
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
        If txtEmail.Text = "" Or txtPass.Text = "" Then
            MsgBox("Please fill in all required fields", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        sql = "SELECT * FROM tblUser WHERE Email = @Email"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Dim pass As String = dr("Password").ToString()
            Dim email As String = dr("Email").ToString()
            Dim fname As String = dr("Firstname").ToString()
            Dim lname As String = dr("Lastname").ToString()
            Dim uid As Integer = Convert.ToInt32(dr("UserID"))
            Dim sec As String = dr("Section").ToString()
            Dim sy As String = dr("SchoolYear").ToString()
            Dim sy2 As String = dr("SchoolYear2").ToString()

            dr.Close()
            cn.Close()

            If pass.Trim() <> txtPass.Text.Trim() Then
                MsgBox("Password is incorrect", MsgBoxStyle.Critical)
                Exit Sub
            End If

            MsgBox("Login Successful", MsgBoxStyle.Information)
            Form1.LoginEmail = Email
            Form1.LoginFirstname = fname
            Form1.LoginLastname = lname
            Form1.LoginUserID = uid
            Form1.LoginSection = sec
            Form1.LoginSchoolYear = sy
            Form1.LoginSchoolYear2 = sy2
            Me.Hide()

            Dim mail As String = Form1.LoginEmail.Trim().ToLower()
            If mail = "admin1" OrElse mail = "admin2" OrElse mail = "admin3" OrElse mail = "admin4" Then
                Dim fMain As New FormMain()
                fMain.Show()
            Else
                Dim fStudent As New Form3()
                fStudent.Show()
            End If

        Else
            dr.Close()
            cn.Close()
            MsgBox("Email does not exist", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class