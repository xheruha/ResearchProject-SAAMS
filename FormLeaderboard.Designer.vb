<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLeaderboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblSYdep = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblCollege = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 318)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(989, 256)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Wheat
        Me.Panel2.Controls.Add(Me.lblSec)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.lblSYdep)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.lblCollege)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lblUser)
        Me.Panel2.Controls.Add(Me.lblLname)
        Me.Panel2.Controls.Add(Me.lblFname)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(989, 104)
        Me.Panel2.TabIndex = 24
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.Location = New System.Drawing.Point(359, 69)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(76, 25)
        Me.lblSec.TabIndex = 34
        Me.lblSec.Text = "Section"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.ResearchProject.My.Resources.Resources.multiple_users_silhouette
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(327, 36)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(26, 27)
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'lblSYdep
        '
        Me.lblSYdep.AutoSize = True
        Me.lblSYdep.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSYdep.Location = New System.Drawing.Point(359, 36)
        Me.lblSYdep.Name = "lblSYdep"
        Me.lblSYdep.Size = New System.Drawing.Size(70, 25)
        Me.lblSYdep.TabIndex = 32
        Me.lblSYdep.Text = "SY-Dep"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.ResearchProject.My.Resources.Resources.main_page
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(327, 4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox6.TabIndex = 31
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.ResearchProject.My.Resources.Resources.student
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(327, 69)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(26, 27)
        Me.PictureBox7.TabIndex = 30
        Me.PictureBox7.TabStop = False
        '
        'lblCollege
        '
        Me.lblCollege.AutoSize = True
        Me.lblCollege.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollege.Location = New System.Drawing.Point(359, 4)
        Me.lblCollege.Name = "lblCollege"
        Me.lblCollege.Size = New System.Drawing.Size(398, 25)
        Me.lblCollege.TabIndex = 29
        Me.lblCollege.Text = "St. Rose College Educational Foundation, Inc. "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ResearchProject.My.Resources.Resources.user1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(21, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 67)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUser.Location = New System.Drawing.Point(15, 72)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(86, 21)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "Username"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.Location = New System.Drawing.Point(83, 42)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(100, 25)
        Me.lblLname.TabIndex = 1
        Me.lblLname.Text = "Last Name"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Location = New System.Drawing.Point(83, 16)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(102, 25)
        Me.lblFname.TabIndex = 0
        Me.lblFname.Text = "First Name"
        '
        'FormLeaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1013, 586)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormLeaderboard"
        Me.Text = "Leaderboard"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSec As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblSYdep As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblCollege As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents lblFname As Label
End Class
