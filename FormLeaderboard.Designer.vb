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
        Me.dvLB = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOV = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSem = New System.Windows.Forms.ComboBox()
        Me.cmbTerm = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSect = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblSYdep = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblCollege = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.dvLB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvLB
        '
        Me.dvLB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvLB.Location = New System.Drawing.Point(12, 122)
        Me.dvLB.Name = "dvLB"
        Me.dvLB.RowHeadersWidth = 51
        Me.dvLB.RowTemplate.Height = 24
        Me.dvLB.Size = New System.Drawing.Size(737, 485)
        Me.dvLB.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.btnOV)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbSem)
        Me.Panel1.Controls.Add(Me.cmbTerm)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbSect)
        Me.Panel1.Location = New System.Drawing.Point(755, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 406)
        Me.Panel1.TabIndex = 25
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(0, 271)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(261, 132)
        Me.Panel6.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(156, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 16)
        Me.Label5.TabIndex = 1
        '
        'btnOV
        '
        Me.btnOV.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnOV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOV.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOV.Location = New System.Drawing.Point(17, 213)
        Me.btnOV.Name = "btnOV"
        Me.btnOV.Size = New System.Drawing.Size(102, 41)
        Me.btnOV.TabIndex = 39
        Me.btnOV.Text = "Overall"
        Me.btnOV.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(261, 10)
        Me.Panel3.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(261, 10)
        Me.Panel4.TabIndex = 26
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(144, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 41)
        Me.btnClear.TabIndex = 38
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 25)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Period:"
        '
        'cmbSem
        '
        Me.cmbSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSem.FormattingEnabled = True
        Me.cmbSem.Location = New System.Drawing.Point(124, 46)
        Me.cmbSem.Name = "cmbSem"
        Me.cmbSem.Size = New System.Drawing.Size(122, 24)
        Me.cmbSem.TabIndex = 34
        '
        'cmbTerm
        '
        Me.cmbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTerm.FormattingEnabled = True
        Me.cmbTerm.Location = New System.Drawing.Point(124, 99)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Size = New System.Drawing.Size(122, 24)
        Me.cmbTerm.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Semester:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Section:"
        '
        'cmbSect
        '
        Me.cmbSect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSect.FormattingEnabled = True
        Me.cmbSect.Location = New System.Drawing.Point(124, 156)
        Me.cmbSect.Name = "cmbSect"
        Me.cmbSect.Size = New System.Drawing.Size(122, 24)
        Me.cmbSect.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.lblSec)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.lblSYdep)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.lblCollege)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lblLname)
        Me.Panel2.Controls.Add(Me.lblFname)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1002, 104)
        Me.Panel2.TabIndex = 26
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
        Me.PictureBox1.BackgroundImage = Global.ResearchProject.My.Resources.Resources.user
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(10, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 90)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Font = New System.Drawing.Font("Noto Sans JP", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.Location = New System.Drawing.Point(107, 54)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(104, 26)
        Me.lblLname.TabIndex = 1
        Me.lblLname.Text = "Last Name"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Noto Sans JP", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Location = New System.Drawing.Point(107, 26)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(107, 26)
        Me.lblFname.TabIndex = 0
        Me.lblFname.Text = "First Name"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.lblStatus)
        Me.Panel5.Location = New System.Drawing.Point(755, 122)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(259, 73)
        Me.Panel5.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Status:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Orange
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(1, 45)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 16)
        Me.lblStatus.TabIndex = 0
        '
        'FormLeaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1013, 586)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dvLB)
        Me.Name = "FormLeaderboard"
        Me.Text = "Leaderboard"
        CType(Me.dvLB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvLB As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbSect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbTerm As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSem As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnOV As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSec As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblSYdep As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblCollege As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblLname As Label
    Friend WithEvents lblFname As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
End Class
