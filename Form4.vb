Imports System.Data.SqlClient

Public Class Form4
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtEmail.Text = "" Or txtNew.Text = "" Or txtCP.Text = "" Then
            MsgBox("Please fill in all required fields", MsgBoxStyle.Critical)
        ElseIf txtNew.Text <> txtCP.Text Then
            MsgBox("Passwords do not match", MsgBoxStyle.Critical)
        ElseIf txtNew.Text.Length < 6 Then
            MsgBox("Password must be at least 6 characters", MsgBoxStyle.Exclamation)
        Else
            CheckEmailExists()
        End If
    End Sub

    Private Sub CheckEmailExists()
        sql = "SELECT Email FROM tblUser WHERE Email = @Email"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            dr.Close()
            cn.Close()
            UpdatePassword()
        Else
            dr.Close()
            cn.Close()
            MsgBox("Email not found. Please check and try again.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub UpdatePassword()
        sql = "UPDATE tblUser SET Password = @Password WHERE Email = @Email"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Password", txtNew.Text.Trim())
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

        MsgBox("Password updated successfully!", MsgBoxStyle.Information)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class