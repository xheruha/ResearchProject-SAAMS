Imports System.Data.SqlClient
Public Class Form3

    Public Shared LoggedInUsername As String
    Public Shared LoggedInSection As String
    Public Shared LoggedInFirstname As String
    Public Shared LoggedInLastname As String
    Public Shared LoggedInUserID As Integer
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT UserID, Firstname, Lastname, SchoolYear, Section FROM tblUser WHERE Username = @Username"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Username", LoggedInUsername)

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            Label2.Text = "SY: " & dr("SchoolYear").ToString()
            Label4.Text = "Section: " & dr("Section").ToString()
            LoggedInSection = dr("Section").ToString()
            LoggedInFirstname = dr("Firstname").ToString()
            LoggedInLastname = dr("Lastname").ToString()
            LoggedInUserID = Convert.ToInt32(dr("UserID"))
        Else
            MsgBox("User not found.", MsgBoxStyle.Exclamation)
        End If

        dr.Close()
        cn.Close()
    End Sub



    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        pnlMain.Controls.Clear()
        FormMain.TopLevel = False
        FormMain.FormBorderStyle = FormBorderStyle.None
        FormMain.Dock = DockStyle.Fill
        pnlMain.Controls.Add(FormMain)
        FormMain.Show()

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        pnlMain.Controls.Clear()
        FormProfile.TopLevel = False
        FormProfile.FormBorderStyle = FormBorderStyle.None
        FormProfile.Dock = DockStyle.Fill
        pnlMain.Controls.Add(FormProfile)
        FormProfile.Show()
    End Sub

    Private Sub btnCM_Click(sender As Object, e As EventArgs) Handles btnCM.Click
        pnlMain.Controls.Clear()
        FormCM.TopLevel = False
        FormCM.FormBorderStyle = FormBorderStyle.None
        FormCM.Dock = DockStyle.Fill
        pnlMain.Controls.Add(FormCM)
        FormCM.Show()
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        pnlMain.Controls.Clear()
        FormStats.TopLevel = False
        FormStats.FormBorderStyle = FormBorderStyle.None
        FormStats.Dock = DockStyle.Fill
        pnlMain.Controls.Add(FormStats)
        FormStats.Show()
    End Sub
End Class