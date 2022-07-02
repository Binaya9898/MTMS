<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.SInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SName = New System.Windows.Forms.TextBox()
        Me.SAddress = New System.Windows.Forms.TextBox()
        Me.SUname = New System.Windows.Forms.TextBox()
        Me.Spassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SInsert
        '
        Me.SInsert.Location = New System.Drawing.Point(214, 551)
        Me.SInsert.Name = "SInsert"
        Me.SInsert.Size = New System.Drawing.Size(150, 62)
        Me.SInsert.TabIndex = 0
        Me.SInsert.Text = "Insert"
        Me.SInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(588, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 460)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Label5"
        '
        'SName
        '
        Me.SName.Location = New System.Drawing.Point(366, 118)
        Me.SName.Name = "SName"
        Me.SName.Size = New System.Drawing.Size(125, 27)
        Me.SName.TabIndex = 6
        '
        'SAddress
        '
        Me.SAddress.Location = New System.Drawing.Point(366, 227)
        Me.SAddress.Name = "SAddress"
        Me.SAddress.Size = New System.Drawing.Size(125, 27)
        Me.SAddress.TabIndex = 7
        '
        'SUname
        '
        Me.SUname.Location = New System.Drawing.Point(366, 344)
        Me.SUname.Name = "SUname"
        Me.SUname.Size = New System.Drawing.Size(125, 27)
        Me.SUname.TabIndex = 8
        '
        'Spassword
        '
        Me.Spassword.Location = New System.Drawing.Point(366, 457)
        Me.Spassword.Name = "Spassword"
        Me.Spassword.Size = New System.Drawing.Size(125, 27)
        Me.Spassword.TabIndex = 9
        '
        'Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 721)
        Me.Controls.Add(Me.Spassword)
        Me.Controls.Add(Me.SUname)
        Me.Controls.Add(Me.SAddress)
        Me.Controls.Add(Me.SName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SInsert)
        Me.Name = "Create"
        Me.Text = "Create"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SInsert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SName As TextBox
    Friend WithEvents SAddress As TextBox
    Friend WithEvents SUname As TextBox
    Friend WithEvents Spassword As TextBox
End Class
