<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPannel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPannel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SearchUser = New FontAwesome.Sharp.IconButton()
        Me.DeleteUser = New FontAwesome.Sharp.IconButton()
        Me.UpdateUser = New FontAwesome.Sharp.IconButton()
        Me.CreateUser = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DeleteMovie = New FontAwesome.Sharp.IconButton()
        Me.UpdateMovie = New FontAwesome.Sharp.IconButton()
        Me.SearchMovie = New FontAwesome.Sharp.IconButton()
        Me.MovieCreate = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(10, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 779)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightCoral
        Me.Panel3.Location = New System.Drawing.Point(237, 156)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(997, 628)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel5.Controls.Add(Me.SearchUser)
        Me.Panel5.Controls.Add(Me.DeleteUser)
        Me.Panel5.Controls.Add(Me.UpdateUser)
        Me.Panel5.Controls.Add(Me.CreateUser)
        Me.Panel5.Location = New System.Drawing.Point(17, 488)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(220, 299)
        Me.Panel5.TabIndex = 10
        '
        'SearchUser
        '
        Me.SearchUser.BackColor = System.Drawing.Color.Orchid
        Me.SearchUser.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SearchUser.IconChar = FontAwesome.Sharp.IconChar.None
        Me.SearchUser.IconColor = System.Drawing.Color.Black
        Me.SearchUser.IconFont = FontAwesome.Sharp.IconFont.Brands
        Me.SearchUser.Location = New System.Drawing.Point(0, 229)
        Me.SearchUser.Name = "SearchUser"
        Me.SearchUser.Size = New System.Drawing.Size(220, 50)
        Me.SearchUser.TabIndex = 6
        Me.SearchUser.Text = "Search User"
        Me.SearchUser.UseVisualStyleBackColor = False
        '
        'DeleteUser
        '
        Me.DeleteUser.BackColor = System.Drawing.Color.Orchid
        Me.DeleteUser.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteUser.IconChar = FontAwesome.Sharp.IconChar.None
        Me.DeleteUser.IconColor = System.Drawing.Color.Black
        Me.DeleteUser.IconFont = FontAwesome.Sharp.IconFont.Brands
        Me.DeleteUser.Location = New System.Drawing.Point(0, 159)
        Me.DeleteUser.Name = "DeleteUser"
        Me.DeleteUser.Size = New System.Drawing.Size(220, 50)
        Me.DeleteUser.TabIndex = 5
        Me.DeleteUser.Text = "Delete User"
        Me.DeleteUser.UseVisualStyleBackColor = False
        '
        'UpdateUser
        '
        Me.UpdateUser.BackColor = System.Drawing.Color.Orchid
        Me.UpdateUser.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateUser.IconChar = FontAwesome.Sharp.IconChar.None
        Me.UpdateUser.IconColor = System.Drawing.Color.Black
        Me.UpdateUser.IconFont = FontAwesome.Sharp.IconFont.Brands
        Me.UpdateUser.Location = New System.Drawing.Point(0, 92)
        Me.UpdateUser.Name = "UpdateUser"
        Me.UpdateUser.Size = New System.Drawing.Size(220, 50)
        Me.UpdateUser.TabIndex = 4
        Me.UpdateUser.Text = "Update User"
        Me.UpdateUser.UseVisualStyleBackColor = False
        '
        'CreateUser
        '
        Me.CreateUser.BackColor = System.Drawing.Color.Orchid
        Me.CreateUser.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreateUser.IconChar = FontAwesome.Sharp.IconChar.None
        Me.CreateUser.IconColor = System.Drawing.Color.Black
        Me.CreateUser.IconFont = FontAwesome.Sharp.IconFont.Brands
        Me.CreateUser.Location = New System.Drawing.Point(0, 21)
        Me.CreateUser.Name = "CreateUser"
        Me.CreateUser.Size = New System.Drawing.Size(220, 50)
        Me.CreateUser.TabIndex = 3
        Me.CreateUser.Text = "Create User"
        Me.CreateUser.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel4.Controls.Add(Me.DeleteMovie)
        Me.Panel4.Controls.Add(Me.UpdateMovie)
        Me.Panel4.Controls.Add(Me.SearchMovie)
        Me.Panel4.Controls.Add(Me.MovieCreate)
        Me.Panel4.Location = New System.Drawing.Point(13, 167)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(227, 315)
        Me.Panel4.TabIndex = 9
        '
        'DeleteMovie
        '
        Me.DeleteMovie.BackColor = System.Drawing.Color.Orchid
        Me.DeleteMovie.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteMovie.IconChar = FontAwesome.Sharp.IconChar.None
        Me.DeleteMovie.IconColor = System.Drawing.Color.Black
        Me.DeleteMovie.IconFont = FontAwesome.Sharp.IconFont.Brands
        Me.DeleteMovie.Location = New System.Drawing.Point(4, 176)
        Me.DeleteMovie.Name = "DeleteMovie"
        Me.DeleteMovie.Size = New System.Drawing.Size(214, 50)
        Me.DeleteMovie.TabIndex = 8
        Me.DeleteMovie.Text = "Delete Movie"
        Me.DeleteMovie.UseVisualStyleBackColor = False
        '
        'UpdateMovie
        '
        Me.UpdateMovie.BackColor = System.Drawing.Color.Orchid
        Me.UpdateMovie.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateMovie.IconChar = FontAwesome.Sharp.IconChar.None
        Me.UpdateMovie.IconColor = System.Drawing.Color.Black
        Me.UpdateMovie.IconFont = FontAwesome.Sharp.IconFont.Brands
        Me.UpdateMovie.Location = New System.Drawing.Point(4, 100)
        Me.UpdateMovie.Name = "UpdateMovie"
        Me.UpdateMovie.Size = New System.Drawing.Size(214, 50)
        Me.UpdateMovie.TabIndex = 7
        Me.UpdateMovie.Text = "Update Movie"
        Me.UpdateMovie.UseVisualStyleBackColor = False
        '
        'SearchMovie
        '
        Me.SearchMovie.BackColor = System.Drawing.Color.Orchid
        Me.SearchMovie.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SearchMovie.IconChar = FontAwesome.Sharp.IconChar.None
        Me.SearchMovie.IconColor = System.Drawing.Color.Black
        Me.SearchMovie.IconFont = FontAwesome.Sharp.IconFont.Brands
        Me.SearchMovie.Location = New System.Drawing.Point(4, 246)
        Me.SearchMovie.Name = "SearchMovie"
        Me.SearchMovie.Size = New System.Drawing.Size(214, 50)
        Me.SearchMovie.TabIndex = 2
        Me.SearchMovie.Text = "Search Movie"
        Me.SearchMovie.UseVisualStyleBackColor = False
        '
        'MovieCreate
        '
        Me.MovieCreate.BackColor = System.Drawing.Color.Orchid
        Me.MovieCreate.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MovieCreate.IconChar = FontAwesome.Sharp.IconChar.None
        Me.MovieCreate.IconColor = System.Drawing.Color.Black
        Me.MovieCreate.IconFont = FontAwesome.Sharp.IconFont.Brands
        Me.MovieCreate.Location = New System.Drawing.Point(4, 23)
        Me.MovieCreate.Name = "MovieCreate"
        Me.MovieCreate.Size = New System.Drawing.Size(214, 50)
        Me.MovieCreate.TabIndex = 1
        Me.MovieCreate.Text = "Create Movie"
        Me.MovieCreate.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Movie_Ticket_Management_System.My.Resources.Resources.admin
        Me.PictureBox1.Location = New System.Drawing.Point(-16, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(247, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1006, 157)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(154, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(678, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome To Admin Pannel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(281, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 54)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Now Showing"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightCoral
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(250, 178)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1003, 624)
        Me.Panel6.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(610, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 38)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "West Hall"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(184, 480)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 38)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "East Hall"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Movie_Ticket_Management_System.My.Resources.Resources.Thor
        Me.PictureBox3.Location = New System.Drawing.Point(504, 83)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(351, 380)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(100, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(296, 392)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'AdminPannel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1254, 823)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminPannel"
        Me.Text = "AdminPannel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UpdateMovie As FontAwesome.Sharp.IconButton
    Friend WithEvents SearchUser As FontAwesome.Sharp.IconButton
    Friend WithEvents DeleteUser As FontAwesome.Sharp.IconButton
    Friend WithEvents UpdateUser As FontAwesome.Sharp.IconButton
    Friend WithEvents CreateUser As FontAwesome.Sharp.IconButton
    Friend WithEvents SearchMovie As FontAwesome.Sharp.IconButton
    Friend WithEvents MovieCreate As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DeleteMovie As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FontDialog1 As FontDialog
End Class
