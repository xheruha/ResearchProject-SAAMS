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
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        sql = "SELECT UserID, Username, Firstname, Lastname, Section FROM tblUser WHERE Username = @Username"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Username", LoggedInUsername)
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            lblUser.Text = dr("Username").ToString()
            LoggedInFirstname = dr("Firstname").ToString()
            LoggedInLastname = dr("Lastname").ToString()
            LoggedInUserID = Convert.ToInt32(dr("UserID"))
            LoggedInSection = dr("Section").ToString()
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

    Private Sub btnLeaderboard_Click(sender As Object, e As EventArgs) Handles btnLB.Click
        pnlMain.Controls.Clear()
        FormLeaderboard.TopLevel = False
        FormLeaderboard.FormBorderStyle = FormBorderStyle.None
        FormLeaderboard.Dock = DockStyle.Fill
        pnlMain.Controls.Add(FormLeaderboard)
        FormLeaderboard.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim out As DialogResult = MsgBox("Would you like to log out?", MsgBoxStyle.YesNo, "Logout")
        If out = DialogResult.Yes Then
            LoggedInUsername = Nothing
            LoggedInFirstname = Nothing
            LoggedInLastname = Nothing
            LoggedInSection = Nothing
            LoggedInUserID = Nothing
            lblUser.Text = ""
            pnlMain.Controls.Clear()

            If Not FormMain.IsDisposed Then FormMain.Close()
            If Not FormLeaderboard.IsDisposed Then FormLeaderboard.Close()

            Form1.txtUser.Clear()
            Form1.txtPass.Clear()
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class
