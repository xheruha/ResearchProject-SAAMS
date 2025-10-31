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

        If cn.State = ConnectionState.Open Then cn.Close()
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
        sql = "INSERT INTO tblUser (Firstname, Lastname, Email, Gender, SchoolYear, Section, Password) VALUES (@Firstname, @Lastname, @Email, @Gender, @SchoolYear, @Section, @Password)"
        cmd = New SqlCommand(sql, cn)
        With cmd.Parameters
            .AddWithValue("@Firstname", txtFirstname.Text.Trim())
            .AddWithValue("@Lastname", txtLastname.Text.Trim())
            .AddWithValue("@Email", txtEmail.Text.Trim())
            .AddWithValue("@Gender", cmbGender.SelectedItem.ToString())
            .AddWithValue("@SchoolYear", cmbSyear.SelectedItem.ToString())
            .AddWithValue("@Section", cmbSection.Text.Trim())
            .AddWithValue("@Password", txtPass.Text.Trim())
        End With

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Account created succesfully!", MsgBoxStyle.Information)
        Me.Hide()
        Form1.Show()
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtEmail.Clear()
        cmbGender.SelectedIndex = -1
        cmbSyear.SelectedIndex = -1
        cmbSection.SelectedIndex = -1
        txtPass.Clear()
        txtCpass.Clear()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGender.Items.Clear()
        cmbSyear.Items.Clear()
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
        cmbGender.Items.Add("Other")
        cmbSyear.Items.Add("1st Year")
        cmbSyear.Items.Add("2nd Year")
        cmbSyear.Items.Add("3rd Year")
        cmbSyear.Items.Add("4th Year")
    End Sub

    Private Sub cmbSyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSyear.SelectedIndexChanged
        If cmbSyear.SelectedItem Is Nothing Then Exit Sub
        cmbSection.Items.Clear()

        Select Case cmbSyear.SelectedItem.ToString()
            Case "1st Year"
                cmbSection.Items.Add("Mega")
                cmbSection.Items.Add("Kilo")
            Case "2nd Year"
                cmbSection.Items.Add("Giga")
                cmbSection.Items.Add("Tera")
            Case "3rd Year"
                cmbSection.Items.Add("Peta")
                cmbSection.Items.Add("Exxa")
            Case "4th Year"
                cmbSection.Items.Add("Zeta")
                cmbSection.Items.Add("Yota")
        End Select
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub


End Class