Imports System.Data.SqlClient
Public Class Form3

    Public Shared LoggedInEmail As String
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT SchoolYear, Section FROM tblUser WHERE Email=@Email"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Email", LoggedInEmail)

        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Label2.Text = "SY: " & dr("SchoolYear").ToString()
            Label4.Text = "Section: " & dr("Section").ToString()
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
End Class