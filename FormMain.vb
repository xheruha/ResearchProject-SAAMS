Imports System.Data.SqlClient

Public Class FormMain
    Dim cn As New SqlConnection("Server=.\SQLEXPRESS;Database=amsDB;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSem.Items.Clear()
        cmbSem.Items.Add("First Semester")
        cmbSem.Items.Add("Second Semester")

        cmbTerm.Items.Clear()
        cmbTerm.Items.Add("First")
        cmbTerm.Items.Add("Midterm")
        cmbTerm.Items.Add("Final")

        cmbNumber.Items.Clear()
        For i As Integer = 1 To 10
            cmbNumber.Items.Add(i.ToString())
        Next

        cmbCat.Items.Clear()
        cmbCat.Items.Add("Quiz")
        cmbCat.Items.Add("Exam")
        cmbCat.Items.Add("Activity")
        cmbCat.Items.Add("Assignment")

        sql = "SELECT AssessmentType FROM tblAssessment"
        cmd = New SqlCommand(sql, cn)
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbCat.Items.Add(dr("AssessmentType").ToString())
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnVS.Click

    End Sub
End Class