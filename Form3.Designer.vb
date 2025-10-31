<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnCM = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.btnStats)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Controls.Add(Me.btnCM)
        Me.Panel1.Controls.Add(Me.btnMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 576)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SchoolYear"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(417, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department of Computer Studies"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel2.Size = New System.Drawing.Size(1083, 51)
        Me.Panel2.TabIndex = 1
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(243, 51)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(840, 576)
        Me.pnlMain.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Sans JP", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(44, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DashBoard"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Section"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.ResearchProject.My.Resources.Resources.student__1_
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(58, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(92, 89)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStats.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStats.Image = Global.ResearchProject.My.Resources.Resources.graph
        Me.btnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStats.Location = New System.Drawing.Point(0, 409)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(243, 59)
        Me.btnStats.TabIndex = 2
        Me.btnStats.TabStop = False
        Me.btnStats.Text = "Statistics"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProfile.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnProfile.Image = Global.ResearchProject.My.Resources.Resources.student3
        Me.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfile.Location = New System.Drawing.Point(0, 279)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(243, 59)
        Me.btnProfile.TabIndex = 4
        Me.btnProfile.TabStop = False
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnCM
        '
        Me.btnCM.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCM.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCM.Image = Global.ResearchProject.My.Resources.Resources.multiple_users_silhouette
        Me.btnCM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCM.Location = New System.Drawing.Point(0, 344)
        Me.btnCM.Name = "btnCM"
        Me.btnCM.Size = New System.Drawing.Size(243, 59)
        Me.btnCM.TabIndex = 1
        Me.btnCM.TabStop = False
        Me.btnCM.Text = "Classmates"
        Me.btnCM.UseVisualStyleBackColor = False
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMain.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMain.Image = Global.ResearchProject.My.Resources.Resources.main_page
        Me.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMain.Location = New System.Drawing.Point(0, 214)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(243, 59)
        Me.btnMain.TabIndex = 5
        Me.btnMain.TabStop = False
        Me.btnMain.Text = "Main (DB)"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.ResearchProject.My.Resources.Resources.list
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 42)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.ResearchProject.My.Resources.Resources._1761053176048
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(698, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 49)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ResearchProject.My.Resources.Resources._1761220390816
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(359, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 627)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCM As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnMain As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
