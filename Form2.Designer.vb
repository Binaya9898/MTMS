<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Srole = New System.Windows.Forms.ComboBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Spassword = New System.Windows.Forms.TextBox()
        Me.SUname = New System.Windows.Forms.TextBox()
        Me.SAddress = New System.Windows.Forms.TextBox()
        Me.SName = New System.Windows.Forms.TextBox()
        Me.Sid = New System.Windows.Forms.TextBox()
        Me.SInsert = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(287, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create New User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(90, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(90, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(90, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 38)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(90, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 38)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "UserName"
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Srole)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.Spassword)
        Me.Panel1.Controls.Add(Me.SUname)
        Me.Panel1.Controls.Add(Me.SAddress)
        Me.Panel1.Controls.Add(Me.SName)
        Me.Panel1.Controls.Add(Me.Sid)
        Me.Panel1.Controls.Add(Me.SInsert)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 705)
        Me.Panel1.TabIndex = 5
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.IconButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.Location = New System.Drawing.Point(721, 3)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(70, 60)
        Me.IconButton3.TabIndex = 16
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(-1, -3)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(69, 71)
        Me.IconButton2.TabIndex = 15
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(90, 572)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 38)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Role"
        '
        'Srole
        '
        Me.Srole.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Srole.FormattingEnabled = True
        Me.Srole.Items.AddRange(New Object() {"Admin", "User"})
        Me.Srole.Location = New System.Drawing.Point(261, 576)
        Me.Srole.Name = "Srole"
        Me.Srole.Size = New System.Drawing.Size(351, 36)
        Me.Srole.TabIndex = 13
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 80
        Me.IconButton1.Location = New System.Drawing.Point(363, 112)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(94, 87)
        Me.IconButton1.TabIndex = 12
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Spassword
        '
        Me.Spassword.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Spassword.Location = New System.Drawing.Point(261, 515)
        Me.Spassword.Name = "Spassword"
        Me.Spassword.Size = New System.Drawing.Size(351, 38)
        Me.Spassword.TabIndex = 11
        '
        'SUname
        '
        Me.SUname.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SUname.Location = New System.Drawing.Point(261, 448)
        Me.SUname.Name = "SUname"
        Me.SUname.Size = New System.Drawing.Size(351, 38)
        Me.SUname.TabIndex = 10
        '
        'SAddress
        '
        Me.SAddress.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SAddress.Location = New System.Drawing.Point(261, 385)
        Me.SAddress.Name = "SAddress"
        Me.SAddress.Size = New System.Drawing.Size(351, 38)
        Me.SAddress.TabIndex = 9
        '
        'SName
        '
        Me.SName.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SName.Location = New System.Drawing.Point(257, 319)
        Me.SName.Name = "SName"
        Me.SName.Size = New System.Drawing.Size(351, 38)
        Me.SName.TabIndex = 8
        '
        'Sid
        '
        Me.Sid.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sid.Location = New System.Drawing.Point(257, 256)
        Me.Sid.Name = "Sid"
        Me.Sid.Size = New System.Drawing.Size(351, 38)
        Me.Sid.TabIndex = 7
        '
        'SInsert
        '
        Me.SInsert.Location = New System.Drawing.Point(363, 641)
        Me.SInsert.Name = "SInsert"
        Me.SInsert.Size = New System.Drawing.Size(94, 41)
        Me.SInsert.TabIndex = 6
        Me.SInsert.Text = "Insert"
        Me.SInsert.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(90, 513)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 38)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Password"
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 735)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Spassword As TextBox
    Friend WithEvents SUname As TextBox
    Friend WithEvents SAddress As TextBox
    Friend WithEvents SName As TextBox
    Friend WithEvents Sid As TextBox
    Friend WithEvents SInsert As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Srole As ComboBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
End Class
