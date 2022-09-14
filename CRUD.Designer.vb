<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class crud
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
        Me.BtnSearchAll = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Cusername = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnSrch = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Crole = New System.Windows.Forms.Label()
        Me.Srole = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Spassword = New System.Windows.Forms.TextBox()
        Me.SUname = New System.Windows.Forms.TextBox()
        Me.SAddress = New System.Windows.Forms.TextBox()
        Me.SName = New System.Windows.Forms.TextBox()
        Me.Sid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSearchAll
        '
        Me.BtnSearchAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSearchAll.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSearchAll.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSearchAll.Location = New System.Drawing.Point(700, 120)
        Me.BtnSearchAll.Name = "BtnSearchAll"
        Me.BtnSearchAll.Size = New System.Drawing.Size(172, 57)
        Me.BtnSearchAll.TabIndex = 2
        Me.BtnSearchAll.Text = "Search All"
        Me.BtnSearchAll.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnUpdate.Location = New System.Drawing.Point(513, 120)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(151, 57)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnDelete.Location = New System.Drawing.Point(339, 120)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(146, 57)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Cusername
        '
        Me.Cusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cusername.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cusername.Location = New System.Drawing.Point(327, 41)
        Me.Cusername.Name = "Cusername"
        Me.Cusername.PlaceholderText = "Enter UserName"
        Me.Cusername.Size = New System.Drawing.Size(604, 54)
        Me.Cusername.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(743, 236)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(785, 500)
        Me.DataGridView1.TabIndex = 7
        '
        'BtnSrch
        '
        Me.BtnSrch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSrch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSrch.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSrch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.BtnSrch.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnSrch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSrch.Location = New System.Drawing.Point(937, 35)
        Me.BtnSrch.Name = "BtnSrch"
        Me.BtnSrch.Size = New System.Drawing.Size(83, 60)
        Me.BtnSrch.TabIndex = 8
        Me.BtnSrch.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(2, 1)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(69, 71)
        Me.IconButton2.TabIndex = 9
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.Location = New System.Drawing.Point(1458, 1)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(70, 60)
        Me.IconButton3.TabIndex = 10
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Crole)
        Me.Panel1.Controls.Add(Me.Srole)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Spassword)
        Me.Panel1.Controls.Add(Me.SUname)
        Me.Panel1.Controls.Add(Me.SAddress)
        Me.Panel1.Controls.Add(Me.SName)
        Me.Panel1.Controls.Add(Me.Sid)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(29, 236)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 571)
        Me.Panel1.TabIndex = 11
        '
        'Crole
        '
        Me.Crole.AutoSize = True
        Me.Crole.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Crole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Crole.Location = New System.Drawing.Point(30, 425)
        Me.Crole.Name = "Crole"
        Me.Crole.Size = New System.Drawing.Size(74, 38)
        Me.Crole.TabIndex = 38
        Me.Crole.Text = "Role"
        '
        'Srole
        '
        Me.Srole.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Srole.FormattingEnabled = True
        Me.Srole.Items.AddRange(New Object() {"Admin", "User"})
        Me.Srole.Location = New System.Drawing.Point(179, 429)
        Me.Srole.Name = "Srole"
        Me.Srole.Size = New System.Drawing.Size(351, 36)
        Me.Srole.TabIndex = 37
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(255, 490)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 57)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Spassword
        '
        Me.Spassword.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Spassword.Location = New System.Drawing.Point(179, 359)
        Me.Spassword.Name = "Spassword"
        Me.Spassword.Size = New System.Drawing.Size(351, 38)
        Me.Spassword.TabIndex = 35
        '
        'SUname
        '
        Me.SUname.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SUname.Location = New System.Drawing.Point(179, 295)
        Me.SUname.Name = "SUname"
        Me.SUname.Size = New System.Drawing.Size(351, 38)
        Me.SUname.TabIndex = 34
        '
        'SAddress
        '
        Me.SAddress.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SAddress.Location = New System.Drawing.Point(179, 219)
        Me.SAddress.Name = "SAddress"
        Me.SAddress.Size = New System.Drawing.Size(351, 38)
        Me.SAddress.TabIndex = 33
        '
        'SName
        '
        Me.SName.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SName.Location = New System.Drawing.Point(179, 148)
        Me.SName.Name = "SName"
        Me.SName.Size = New System.Drawing.Size(351, 38)
        Me.SName.TabIndex = 32
        '
        'Sid
        '
        Me.Sid.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sid.Location = New System.Drawing.Point(179, 88)
        Me.Sid.Name = "Sid"
        Me.Sid.Size = New System.Drawing.Size(351, 38)
        Me.Sid.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(466, 639)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(20, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 38)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(20, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 38)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "UserName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 38)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 38)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 38)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "User ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(196, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 38)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Update Details"
        '
        'crud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1573, 829)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.BtnSrch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Cusername)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSearchAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "crud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Pannel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnSearchAll As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Cusername As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnSrch As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Spassword As TextBox
    Friend WithEvents SUname As TextBox
    Friend WithEvents SAddress As TextBox
    Friend WithEvents SName As TextBox
    Friend WithEvents Sid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Crole As Label
    Friend WithEvents Srole As ComboBox
End Class
