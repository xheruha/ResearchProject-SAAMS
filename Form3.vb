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

    Private Sub btnLeaderboard_Click(sender As Object, e As EventArgs) Handles btnLB.Click
        pnlMain.Controls.Clear()
        FormLeaderboard.TopLevel = False
        FormLeaderboard.FormBorderStyle = FormBorderStyle.None
        FormLeaderboard.Dock = DockStyle.Fill
        pnlMain.Controls.Add(FormLeaderboard)
        FormLeaderboard.Show()
    End Sub
End Class