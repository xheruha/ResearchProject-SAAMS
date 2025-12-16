<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dvSrecord = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.cmbSub = New System.Windows.Forms.ComboBox()
        Me.btnVS = New System.Windows.Forms.Button()
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
        Me.dtpSM = New System.Windows.Forms.DateTimePicker()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cmbSem = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbNumber = New System.Windows.Forms.ComboBox()
        Me.cmbTerm = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dvSrecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvSrecord
        '
        Me.dvSrecord.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dvSrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvSrecord.Location = New System.Drawing.Point(12, 375)
        Me.dvSrecord.Name = "dvSrecord"
        Me.dvSrecord.RowHeadersWidth = 51
        Me.dvSrecord.RowTemplate.Height = 24
        Me.dvSrecord.Size = New System.Drawing.Size(1005, 249)
        Me.dvSrecord.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.btnFilter)
        Me.Panel1.Controls.Add(Me.cmbSub)
        Me.Panel1.Controls.Add(Me.btnVS)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.dtpSM)
        Me.Panel1.Controls.Add(Me.cmbCat)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.cmbSem)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbNumber)
        Me.Panel1.Controls.Add(Me.cmbTerm)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtScore)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 348)
        Me.Panel1.TabIndex = 22
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(13, 308)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(101, 38)
        Me.btnFilter.TabIndex = 25
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'cmbSub
        '
        Me.cmbSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSub.FormattingEnabled = True
        Me.cmbSub.Location = New System.Drawing.Point(163, 170)
        Me.cmbSub.Name = "cmbSub"
        Me.cmbSub.Size = New System.Drawing.Size(204, 24)
        Me.cmbSub.TabIndex = 24
        '
        'btnVS
        '
        Me.btnVS.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVS.Font = New System.Drawing.Font("Noto Sans JP", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVS.Location = New System.Drawing.Point(227, 307)
        Me.btnVS.Name = "btnVS"
        Me.btnVS.Size = New System.Drawing.Size(101, 38)
        Me.btnVS.TabIndex = 19
        Me.btnVS.Text = "View Score"
        Me.btnVS.UseVisualStyleBackColor = False
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
        Me.Panel2.Controls.Add(Me.lblLname)
        Me.Panel2.Controls.Add(Me.lblFname)
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(976, 104)
        Me.Panel2.TabIndex = 23
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
        'dtpSM
        '
        Me.dtpSM.Location = New System.Drawing.Point(55, 263)
        Me.dtpSM.Name = "dtpSM"
        Me.dtpSM.Size = New System.Drawing.Size(273, 22)
        Me.dtpSM.TabIndex = 22
        '
        'cmbCat
        '
        Me.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(163, 212)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(204, 24)
        Me.cmbCat.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(120, 308)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 38)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'cmbSem
        '
        Me.cmbSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSem.FormattingEnabled = True
        Me.cmbSem.Location = New System.Drawing.Point(163, 126)
        Me.cmbSem.Name = "cmbSem"
        Me.cmbSem.Size = New System.Drawing.Size(204, 24)
        Me.cmbSem.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(528, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "No:"
        '
        'cmbNumber
        '
        Me.cmbNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNumber.FormattingEnabled = True
        Me.cmbNumber.Location = New System.Drawing.Point(586, 169)
        Me.cmbNumber.Name = "cmbNumber"
        Me.cmbNumber.Size = New System.Drawing.Size(204, 24)
        Me.cmbNumber.TabIndex = 10
        '
        'cmbTerm
        '
        Me.cmbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTerm.FormattingEnabled = True
        Me.cmbTerm.Location = New System.Drawing.Point(586, 128)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Size = New System.Drawing.Size(204, 24)
        Me.cmbTerm.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Subject:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(498, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Period:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Semester:"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(586, 212)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(204, 22)
        Me.txtScore.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(505, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Score:"
        '
        'FormStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1013, 586)
        Me.Controls.Add(Me.dvSrecord)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormStudent"
        Me.Text = "FormStudent"
        CType(Me.dvSrecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvSrecord As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFilter As Button
    Friend WithEvents cmbSub As ComboBox
    Friend WithEvents btnVS As Button
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
    Friend WithEvents dtpSM As DateTimePicker
    Friend WithEvents cmbCat As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents cmbSem As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbNumber As ComboBox
    Friend WithEvents cmbTerm As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtScore As TextBox
    Friend WithEvents Label6 As Label
End Class
