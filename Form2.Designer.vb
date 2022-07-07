<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1.Location = New System.Drawing.Point(544, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create New User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(18, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(18, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(18, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 38)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(18, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 38)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "UserName"
        '
        'Panel1
        '
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
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1208, 700)
        Me.Panel1.TabIndex = 5
        '
        'Spassword
        '
        Me.Spassword.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Spassword.Location = New System.Drawing.Point(203, 516)
        Me.Spassword.Name = "Spassword"
        Me.Spassword.Size = New System.Drawing.Size(351, 38)
        Me.Spassword.TabIndex = 11
        '
        'SUname
        '
        Me.SUname.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SUname.Location = New System.Drawing.Point(203, 423)
        Me.SUname.Name = "SUname"
        Me.SUname.Size = New System.Drawing.Size(351, 38)
        Me.SUname.TabIndex = 10
        '
        'SAddress
        '
        Me.SAddress.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SAddress.Location = New System.Drawing.Point(203, 346)
        Me.SAddress.Name = "SAddress"
        Me.SAddress.Size = New System.Drawing.Size(351, 38)
        Me.SAddress.TabIndex = 9
        '
        'SName
        '
        Me.SName.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SName.Location = New System.Drawing.Point(203, 253)
        Me.SName.Name = "SName"
        Me.SName.Size = New System.Drawing.Size(351, 38)
        Me.SName.TabIndex = 8
        '
        'Sid
        '
        Me.Sid.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sid.Location = New System.Drawing.Point(203, 178)
        Me.Sid.Name = "Sid"
        Me.Sid.Size = New System.Drawing.Size(351, 38)
        Me.Sid.TabIndex = 7
        '
        'SInsert
        '
        Me.SInsert.Location = New System.Drawing.Point(203, 638)
        Me.SInsert.Name = "SInsert"
        Me.SInsert.Size = New System.Drawing.Size(94, 29)
        Me.SInsert.TabIndex = 6
        Me.SInsert.Text = "Insert"
        Me.SInsert.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(18, 536)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 38)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Password"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 728)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
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
End Class
