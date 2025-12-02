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
        ElseIf chkIrreg.Checked And cmbSyear2.SelectedIndex = -1 Then
            MsgBox("Please select second school year for irregular student", MsgBoxStyle.Exclamation)
        ElseIf chkIrreg.Checked And cmbSyear.Text = cmbSyear2.Text Then
            MsgBox("School year cannot be the same", MsgBoxStyle.Exclamation)
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
        sql = "INSERT INTO tblUser (Firstname, Lastname, Email, Gender, SchoolYear, SchoolYear2, Section, Password, Role) " &
              "VALUES (@Firstname, @Lastname, @Email, @Gender, @SchoolYear, @SchoolYear2, @Section, @Password, @Role)"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text.Trim())
        cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text.Trim())
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
        cmd.Parameters.AddWithValue("@SchoolYear", cmbSyear.Text)
        cmd.Parameters.AddWithValue("@SchoolYear2", If(chkIrreg.Checked, cmbSyear2.Text, ""))
        cmd.Parameters.AddWithValue("@Section", cmbSection.Text.Trim())
        cmd.Parameters.AddWithValue("@Password", txtPass.Text.Trim())
        cmd.Parameters.AddWithValue("@Role", "Student")

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

        MsgBox("Account created successfully!", MsgBoxStyle.Information)
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
        cmbSyear2.SelectedIndex = -1
        cmbSection.SelectedIndex = -1
        txtPass.Clear()
        txtCpass.Clear()
        chkIrreg.Checked = False
    End Sub

    Private Sub cmbItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGender.Items.Clear()
        cmbSyear.Items.Clear()
        cmbSyear2.Items.Clear()

        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
        cmbGender.Items.Add("Other")

        cmbSyear.Items.Add("1st Year")
        cmbSyear.Items.Add("2nd Year")
        cmbSyear.Items.Add("3rd Year")
        cmbSyear.Items.Add("4th Year")

        cmbSyear2.Items.Add("1st Year")
        cmbSyear2.Items.Add("2nd Year")
        cmbSyear2.Items.Add("3rd Year")
        cmbSyear2.Items.Add("4th Year")
        cmbSyear2.Enabled = False
    End Sub

    Private Sub cmbSyear_Item(sender As Object, e As EventArgs) Handles cmbSyear.SelectedIndexChanged
        If cmbSyear.SelectedItem Is Nothing Then Exit Sub
        cmbSection.Items.Clear()

        Select Case cmbSyear.SelectedItem.ToString()
            Case "1st Year"
                cmbSection.Items.Add("Mega")
                cmbSection.Items.Add("Kilo")
            Case "2nd Year"
                cmbSection.Items.Add("Deca")
                cmbSection.Items.Add("Penta")
            Case "3rd Year"
                cmbSection.Items.Add("Hexa")
                cmbSection.Items.Add("Octa")
            Case "4th Year"
                cmbSection.Items.Add("Sigma")
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub chkIrreg_CheckedChanged(sender As Object, e As EventArgs) Handles chkIrreg.CheckedChanged
        If chkIrreg.Checked Then
            cmbSyear2.Enabled = True
        Else
            cmbSyear2.Enabled = False
            cmbSyear2.SelectedIndex = -1
        End If
    End Sub

End Class