Imports System.Data.SqlClient
Public Class Form3

    Public Shared LoggedInEmail As String
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT SchoolYear FROM tblUser WHERE Email = @Email"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Email", LoggedInEmail)

        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Label2.Text = "SY: " & dr("SchoolYear").ToString()
        Else
            Label2.Text = "SchoolYear Invalid"
        End If

        dr.Close()
        cn.Close()
    End Sub
End Class