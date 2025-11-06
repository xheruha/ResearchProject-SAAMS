Imports System.Data.SqlClient
Public Class Form3
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
            Form1.LoginUsername = Nothing
            Form1.LoginLastname = Nothing
            Form1.LoginSection = Nothing
            Form1.LoginUserID = Nothing
            pnlMain.Controls.Clear()

            If Not FormMain.IsDisposed Then
                FormMain.Close()
            End If
            If Not FormLeaderboard.IsDisposed Then
                FormLeaderboard.Close()
            End If
            Form1.txtUser.Clear()
            Form1.txtPass.Clear()
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class
