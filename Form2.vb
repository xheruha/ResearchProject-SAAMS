Imports System.Data.SqlClient
Public Class Form2

    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If txtEmail.Text = "" Or txtPass.Text = "" Or txtCpass.Text = "" Then
            MsgBox("Please fill in all required fields", MsgBoxStyle.Critical)
        ElseIf txtPass.Text <> txtCpass.Text Then
            MsgBox("Passwords do not match", MsgBoxStyle.Critical)
        ElseIf txtPass.Text.Length < 6 Then
            MsgBox("Password must be at least 6 characters", MsgBoxStyle.Exclamation)
        Else
            CheckEmail()
        End If
    End Sub

    Private Sub CheckEmail()
        sql = "SELECT Email FROM tblUser WHERE Email = @Email"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            MsgBox("Email already exists. Use a different one.", MsgBoxStyle.Exclamation)
            dr.Close()
            cn.Close()
        Else
            dr.Close()
            cn.Close()
            SaveUserData()
        End If
    End Sub

    Private Sub SaveUserData()
        sql = "INSERT INTO tblUser (Firstname, Lastname, Email, SchoolYear, Section, Password) VALUES (@Firstname, @Lastname, @Email, @SchoolYear, @Section, @Password)"
        cmd = New SqlCommand(sql, cn)
        With cmd.Parameters
            .AddWithValue("@Firstname", txtFirstname.Text.Trim())
            .AddWithValue("@Lastname", txtLastname.Text.Trim())
            .AddWithValue("@Email", txtEmail.Text.Trim())
            .AddWithValue("@SchoolYear", txtSyear.Text.Trim())
            .AddWithValue("@Section", txtSection.Text.Trim())
            .AddWithValue("@Password", txtPass.Text.Trim())
        End With
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Account created succesfully!", MsgBoxStyle.Information)
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtEmail.Clear()
        txtSyear.Clear()
        txtSection.Clear()
        txtPass.Clear()
        txtCpass.Clear()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtEmail.Text = ""
        txtSyear.Text = ""
        txtSection.Text = ""
        txtPass.Text = ""
        txtCpass.Text = ""
    End Sub
End Class