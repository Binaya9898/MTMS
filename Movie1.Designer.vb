<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsMovie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsMovie))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Mnam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Mshowtime = New System.Windows.Forms.ComboBox()
        Me.Mpicture = New System.Windows.Forms.PictureBox()
        Me.Mgenre = New System.Windows.Forms.ComboBox()
        Me.Mhall = New System.Windows.Forms.ComboBox()
        Me.Mdate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Mname = New System.Windows.Forms.TextBox()
        Me.Mid = New System.Windows.Forms.TextBox()
        Me.Minsert = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Mpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(28, 485)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 38)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hall"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(33, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Movie ID"
        '
        'Mnam
        '
        Me.Mnam.AutoSize = True
        Me.Mnam.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mnam.ForeColor = System.Drawing.SystemColors.Control
        Me.Mnam.Location = New System.Drawing.Point(33, 251)
        Me.Mnam.Name = "Mnam"
        Me.Mnam.Size = New System.Drawing.Size(185, 38)
        Me.Mnam.TabIndex = 1
        Me.Mnam.Text = "Movie Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(552, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Movie"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Mshowtime)
        Me.Panel1.Controls.Add(Me.Mpicture)
        Me.Panel1.Controls.Add(Me.Mgenre)
        Me.Panel1.Controls.Add(Me.Mhall)
        Me.Panel1.Controls.Add(Me.Mdate)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Mname)
        Me.Panel1.Controls.Add(Me.Mid)
        Me.Panel1.Controls.Add(Me.Minsert)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Mnam)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1221, 747)
        Me.Panel1.TabIndex = 6
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.Indigo
        Me.IconButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.Location = New System.Drawing.Point(1134, 20)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(70, 60)
        Me.IconButton3.TabIndex = 28
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
        Me.IconButton2.Location = New System.Drawing.Point(3, 15)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(69, 71)
        Me.IconButton2.TabIndex = 27
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(885, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 70)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Browse Picture"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Mshowtime
        '
        Me.Mshowtime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mshowtime.FormattingEnabled = True
        Me.Mshowtime.Items.AddRange(New Object() {"12pm", "3pm", "6pm"})
        Me.Mshowtime.Location = New System.Drawing.Point(274, 412)
        Me.Mshowtime.Name = "Mshowtime"
        Me.Mshowtime.Size = New System.Drawing.Size(351, 36)
        Me.Mshowtime.TabIndex = 25
        '
        'Mpicture
        '
        Me.Mpicture.BackgroundImage = CType(resources.GetObject("Mpicture.BackgroundImage"), System.Drawing.Image)
        Me.Mpicture.Location = New System.Drawing.Point(857, 194)
        Me.Mpicture.Name = "Mpicture"
        Me.Mpicture.Size = New System.Drawing.Size(228, 225)
        Me.Mpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Mpicture.TabIndex = 23
        Me.Mpicture.TabStop = False
        '
        'Mgenre
        '
        Me.Mgenre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mgenre.FormattingEnabled = True
        Me.Mgenre.Items.AddRange(New Object() {"Romantic", "Action", "Crime and Horror", "Psychology "})
        Me.Mgenre.Location = New System.Drawing.Point(274, 563)
        Me.Mgenre.Name = "Mgenre"
        Me.Mgenre.Size = New System.Drawing.Size(351, 36)
        Me.Mgenre.TabIndex = 22
        '
        'Mhall
        '
        Me.Mhall.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mhall.FormattingEnabled = True
        Me.Mhall.Items.AddRange(New Object() {"East", "West"})
        Me.Mhall.Location = New System.Drawing.Point(274, 485)
        Me.Mhall.Name = "Mhall"
        Me.Mhall.Size = New System.Drawing.Size(351, 36)
        Me.Mhall.TabIndex = 21
        '
        'Mdate
        '
        Me.Mdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Mdate.Location = New System.Drawing.Point(272, 333)
        Me.Mdate.Name = "Mdate"
        Me.Mdate.Size = New System.Drawing.Size(353, 34)
        Me.Mdate.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(28, 412)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 38)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Show Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(28, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 38)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Release Date"
        '
        'Mname
        '
        Me.Mname.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mname.Location = New System.Drawing.Point(274, 253)
        Me.Mname.Name = "Mname"
        Me.Mname.Size = New System.Drawing.Size(351, 38)
        Me.Mname.TabIndex = 8
        '
        'Mid
        '
        Me.Mid.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mid.Location = New System.Drawing.Point(274, 171)
        Me.Mid.Name = "Mid"
        Me.Mid.Size = New System.Drawing.Size(351, 38)
        Me.Mid.TabIndex = 7
        '
        'Minsert
        '
        Me.Minsert.BackColor = System.Drawing.Color.Indigo
        Me.Minsert.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Minsert.ForeColor = System.Drawing.SystemColors.Control
        Me.Minsert.Location = New System.Drawing.Point(552, 654)
        Me.Minsert.Name = "Minsert"
        Me.Minsert.Size = New System.Drawing.Size(194, 62)
        Me.Minsert.TabIndex = 6
        Me.Minsert.Text = "Insert Movie"
        Me.Minsert.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(33, 559)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 38)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Genre"
        '
        'InsMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 759)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InsMovie"
        Me.Text = "Add Movie"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Mpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Mnam As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Mname As TextBox
    Friend WithEvents Mid As TextBox
    Friend WithEvents Minsert As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Mpicture As PictureBox
    Friend WithEvents Mgenre As ComboBox
    Friend WithEvents Mhall As ComboBox
    Friend WithEvents Mdate As DateTimePicker
    Friend WithEvents Mshowtime As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
End Class
