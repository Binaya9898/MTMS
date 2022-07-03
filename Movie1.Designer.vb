<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movie1
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Mnam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Mshowtime = New System.Windows.Forms.TextBox()
        Me.Mdate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Mgenre = New System.Windows.Forms.TextBox()
        Me.Mhall = New System.Windows.Forms.TextBox()
        Me.Mname = New System.Windows.Forms.TextBox()
        Me.Mid = New System.Windows.Forms.TextBox()
        Me.Minsert = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Mseat = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        CType(Me.Mseat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(18, 499)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 38)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Seat Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(18, 428)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 38)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hall"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(23, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Movie ID"
        '
        'Mnam
        '
        Me.Mnam.AutoSize = True
        Me.Mnam.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mnam.Location = New System.Drawing.Point(23, 194)
        Me.Mnam.Name = "Mnam"
        Me.Mnam.Size = New System.Drawing.Size(185, 38)
        Me.Mnam.TabIndex = 1
        Me.Mnam.Text = "Movie Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(552, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insert Movie"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Mseat)
        Me.Panel1.Controls.Add(Me.Mshowtime)
        Me.Panel1.Controls.Add(Me.Mdate)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Mgenre)
        Me.Panel1.Controls.Add(Me.Mhall)
        Me.Panel1.Controls.Add(Me.Mname)
        Me.Panel1.Controls.Add(Me.Mid)
        Me.Panel1.Controls.Add(Me.Minsert)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Mnam)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 750)
        Me.Panel1.TabIndex = 6
        '
        'Mshowtime
        '
        Me.Mshowtime.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mshowtime.Location = New System.Drawing.Point(264, 353)
        Me.Mshowtime.Name = "Mshowtime"
        Me.Mshowtime.Size = New System.Drawing.Size(351, 38)
        Me.Mshowtime.TabIndex = 15
        '
        'Mdate
        '
        Me.Mdate.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mdate.Location = New System.Drawing.Point(264, 272)
        Me.Mdate.Name = "Mdate"
        Me.Mdate.Size = New System.Drawing.Size(351, 38)
        Me.Mdate.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(18, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 38)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Show Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(18, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 38)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Release Date"
        '
        'Mgenre
        '
        Me.Mgenre.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mgenre.Location = New System.Drawing.Point(264, 585)
        Me.Mgenre.Name = "Mgenre"
        Me.Mgenre.Size = New System.Drawing.Size(351, 38)
        Me.Mgenre.TabIndex = 11
        '
        'Mhall
        '
        Me.Mhall.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mhall.Location = New System.Drawing.Point(264, 430)
        Me.Mhall.Name = "Mhall"
        Me.Mhall.Size = New System.Drawing.Size(351, 38)
        Me.Mhall.TabIndex = 9
        '
        'Mname
        '
        Me.Mname.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mname.Location = New System.Drawing.Point(264, 194)
        Me.Mname.Name = "Mname"
        Me.Mname.Size = New System.Drawing.Size(351, 38)
        Me.Mname.TabIndex = 8
        '
        'Mid
        '
        Me.Mid.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mid.Location = New System.Drawing.Point(264, 114)
        Me.Mid.Name = "Mid"
        Me.Mid.Size = New System.Drawing.Size(351, 38)
        Me.Mid.TabIndex = 7
        '
        'Minsert
        '
        Me.Minsert.Location = New System.Drawing.Point(552, 685)
        Me.Minsert.Name = "Minsert"
        Me.Minsert.Size = New System.Drawing.Size(194, 62)
        Me.Minsert.TabIndex = 6
        Me.Minsert.Text = "Insert Movie"
        Me.Minsert.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(18, 583)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 38)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Genre"
        '
        'Mseat
        '
        Me.Mseat.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mseat.Location = New System.Drawing.Point(264, 499)
        Me.Mseat.Name = "Mseat"
        Me.Mseat.Size = New System.Drawing.Size(351, 43)
        Me.Mseat.TabIndex = 16
        '
        'Movie1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 759)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Movie1"
        Me.Text = "Movie1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Mseat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Mnam As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Mshowtime As TextBox
    Friend WithEvents Mdate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Mgenre As TextBox
    Friend WithEvents Mhall As TextBox
    Friend WithEvents Mname As TextBox
    Friend WithEvents Mid As TextBox
    Friend WithEvents Minsert As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Mseat As NumericUpDown
End Class
