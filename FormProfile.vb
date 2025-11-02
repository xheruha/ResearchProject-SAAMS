Imports System.Data.SqlClient

Public Class FormProfile
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        sql = "SELECT Username, Firstname, Lastname, SchoolYear FROM tblUser WHERE Username = @Username"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Username", Form3.LoggedInUsername)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            lblUser.Text = dr("Username").ToString()
            lblFname.Text = dr("Firstname").ToString()
            lblLname.Text = dr("Lastname").ToString()
            lblSYdep.Text = dr("SchoolYear").ToString() & "- Computer Science"
        Else
            MsgBox("User not found.", MsgBoxStyle.Exclamation)
        End If

        dr.Close()
        cn.Close()
    End Sub
End Class