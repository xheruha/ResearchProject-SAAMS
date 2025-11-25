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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.cmbSect = New System.Windows.Forms.ComboBox()
        CType(Me.dvLB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvLB
        '
        Me.dvLB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvLB.Location = New System.Drawing.Point(12, 122)
        Me.dvLB.Name = "dvLB"
        Me.dvLB.RowHeadersWidth = 51
        Me.dvLB.RowTemplate.Height = 24
        Me.dvLB.Size = New System.Drawing.Size(784, 485)
        Me.dvLB.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Wheat
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1002, 104)
        Me.Panel2.TabIndex = 24
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(92, 2)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(122, 24)
        Me.cmbYear.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Wheat
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnFilter)
        Me.Panel1.Controls.Add(Me.cmbSect)
        Me.Panel1.Controls.Add(Me.cmbYear)
        Me.Panel1.Location = New System.Drawing.Point(797, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 485)
        Me.Panel1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Noto Sans JP", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Section:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Noto Sans JP", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Year Level:"
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Noto Sans JP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(103, 92)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(89, 34)
        Me.btnFilter.TabIndex = 32
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'cmbSect
        '
        Me.cmbSect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSect.FormattingEnabled = True
        Me.cmbSect.Location = New System.Drawing.Point(92, 53)
        Me.cmbSect.Name = "cmbSect"
        Me.cmbSect.Size = New System.Drawing.Size(122, 24)
        Me.cmbSect.TabIndex = 31
        '
        'FormLeaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1013, 586)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dvLB)
        Me.Name = "FormLeaderboard"
        Me.Text = "Leaderboard"
        CType(Me.dvLB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvLB As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFilter As Button
    Friend WithEvents cmbSect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
