<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MCRUD
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Mstatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Mshowtime = New System.Windows.Forms.ComboBox()
        Me.Mgenre = New System.Windows.Forms.ComboBox()
        Me.Mhall = New System.Windows.Forms.ComboBox()
        Me.Mdate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Mname = New System.Windows.Forms.TextBox()
        Me.Mid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Mnam = New System.Windows.Forms.Label()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.BtnSrch = New FontAwesome.Sharp.IconButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.smname = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSearchAll = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Indigo
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(309, 605)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 57)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(61, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 38)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Update Details"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Mstatus)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Mshowtime)
        Me.Panel1.Controls.Add(Me.Mgenre)
        Me.Panel1.Controls.Add(Me.Mhall)
        Me.Panel1.Controls.Add(Me.Mdate)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Mname)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Mid)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Mnam)
        Me.Panel1.Location = New System.Drawing.Point(12, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 665)
        Me.Panel1.TabIndex = 20
        '
        'Mstatus
        '
        Me.Mstatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mstatus.FormattingEnabled = True
        Me.Mstatus.Items.AddRange(New Object() {"Yes", "No"})
        Me.Mstatus.Location = New System.Drawing.Point(279, 545)
        Me.Mstatus.Name = "Mstatus"
        Me.Mstatus.Size = New System.Drawing.Size(351, 36)
        Me.Mstatus.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(61, 543)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 38)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Stauts"
        '
        'Mshowtime
        '
        Me.Mshowtime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mshowtime.FormattingEnabled = True
        Me.Mshowtime.Items.AddRange(New Object() {"12pm", "3pm", "6pm"})
        Me.Mshowtime.Location = New System.Drawing.Point(292, 314)
        Me.Mshowtime.Name = "Mshowtime"
        Me.Mshowtime.Size = New System.Drawing.Size(351, 36)
        Me.Mshowtime.TabIndex = 48
        '
        'Mgenre
        '
        Me.Mgenre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mgenre.FormattingEnabled = True
        Me.Mgenre.Items.AddRange(New Object() {"Romantic", "Action", "Crime and Horror", "Psychology "})
        Me.Mgenre.Location = New System.Drawing.Point(290, 459)
        Me.Mgenre.Name = "Mgenre"
        Me.Mgenre.Size = New System.Drawing.Size(351, 36)
        Me.Mgenre.TabIndex = 47
        '
        'Mhall
        '
        Me.Mhall.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mhall.FormattingEnabled = True
        Me.Mhall.Items.AddRange(New Object() {"East", "West"})
        Me.Mhall.Location = New System.Drawing.Point(292, 387)
        Me.Mhall.Name = "Mhall"
        Me.Mhall.Size = New System.Drawing.Size(351, 36)
        Me.Mhall.TabIndex = 46
        '
        'Mdate
        '
        Me.Mdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Mdate.Location = New System.Drawing.Point(290, 235)
        Me.Mdate.Name = "Mdate"
        Me.Mdate.Size = New System.Drawing.Size(353, 34)
        Me.Mdate.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(51, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 38)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Show Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(51, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 38)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Release Date"
        '
        'Mname
        '
        Me.Mname.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mname.Location = New System.Drawing.Point(292, 155)
        Me.Mname.Name = "Mname"
        Me.Mname.Size = New System.Drawing.Size(351, 38)
        Me.Mname.TabIndex = 42
        '
        'Mid
        '
        Me.Mid.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mid.Location = New System.Drawing.Point(292, 73)
        Me.Mid.Name = "Mid"
        Me.Mid.Size = New System.Drawing.Size(351, 38)
        Me.Mid.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(61, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 38)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Genre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(61, 383)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 38)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Hall"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(51, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 38)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Movie ID"
        '
        'Mnam
        '
        Me.Mnam.AutoSize = True
        Me.Mnam.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mnam.ForeColor = System.Drawing.SystemColors.Control
        Me.Mnam.Location = New System.Drawing.Point(51, 155)
        Me.Mnam.Name = "Mnam"
        Me.Mnam.Size = New System.Drawing.Size(185, 38)
        Me.Mnam.TabIndex = 37
        Me.Mnam.Text = "Movie Name"
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.Indigo
        Me.IconButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.Location = New System.Drawing.Point(1502, 0)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(70, 60)
        Me.IconButton3.TabIndex = 19
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Indigo
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(-2, 0)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(69, 71)
        Me.IconButton2.TabIndex = 18
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'BtnSrch
        '
        Me.BtnSrch.BackColor = System.Drawing.Color.Indigo
        Me.BtnSrch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSrch.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSrch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.BtnSrch.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnSrch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSrch.Location = New System.Drawing.Point(951, 6)
        Me.BtnSrch.Name = "BtnSrch"
        Me.BtnSrch.Size = New System.Drawing.Size(83, 60)
        Me.BtnSrch.TabIndex = 17
        Me.BtnSrch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(722, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(821, 514)
        Me.DataGridView1.TabIndex = 16
        '
        'smname
        '
        Me.smname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.smname.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.smname.Location = New System.Drawing.Point(341, 12)
        Me.smname.Name = "smname"
        Me.smname.PlaceholderText = "Enter Movie Name"
        Me.smname.Size = New System.Drawing.Size(604, 54)
        Me.smname.TabIndex = 15
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Indigo
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnDelete.Location = New System.Drawing.Point(405, 72)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(146, 57)
        Me.BtnDelete.TabIndex = 14
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Indigo
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnUpdate.Location = New System.Drawing.Point(580, 72)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(151, 57)
        Me.BtnUpdate.TabIndex = 13
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnSearchAll
        '
        Me.BtnSearchAll.BackColor = System.Drawing.Color.Indigo
        Me.BtnSearchAll.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSearchAll.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSearchAll.Location = New System.Drawing.Point(749, 72)
        Me.BtnSearchAll.Name = "BtnSearchAll"
        Me.BtnSearchAll.Size = New System.Drawing.Size(172, 57)
        Me.BtnSearchAll.TabIndex = 12
        Me.BtnSearchAll.Text = "Search All"
        Me.BtnSearchAll.UseVisualStyleBackColor = False
        '
        'MCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1584, 858)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.BtnSrch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.smname)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSearchAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MCRUD"
        Me.Text = "MCRUD"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnSrch As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents smname As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSearchAll As Button
    Friend WithEvents Mshowtime As ComboBox
    Friend WithEvents Mgenre As ComboBox
    Friend WithEvents Mhall As ComboBox
    Friend WithEvents Mdate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Mname As TextBox
    Friend WithEvents Mid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Mnam As Label
    Friend WithEvents Mstatus As ComboBox
    Friend WithEvents Label2 As Label
End Class
