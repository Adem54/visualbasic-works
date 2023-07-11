<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MyBtn1 = New System.Windows.Forms.Button()
        Me.MyTxtBox1 = New System.Windows.Forms.TextBox()
        Me.MyLabel1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MyBtn1
        '
        Me.MyBtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyBtn1.Location = New System.Drawing.Point(575, 100)
        Me.MyBtn1.Name = "MyBtn1"
        Me.MyBtn1.Size = New System.Drawing.Size(182, 59)
        Me.MyBtn1.TabIndex = 0
        Me.MyBtn1.Text = "Save"
        Me.MyBtn1.UseVisualStyleBackColor = True
        '
        'MyTxtBox1
        '
        Me.MyTxtBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyTxtBox1.Location = New System.Drawing.Point(337, 118)
        Me.MyTxtBox1.Name = "MyTxtBox1"
        Me.MyTxtBox1.Size = New System.Drawing.Size(179, 38)
        Me.MyTxtBox1.TabIndex = 1
        '
        'MyLabel1
        '
        Me.MyLabel1.AutoSize = True
        Me.MyLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLabel1.Location = New System.Drawing.Point(176, 123)
        Me.MyLabel1.Name = "MyLabel1"
        Me.MyLabel1.Size = New System.Drawing.Size(123, 31)
        Me.MyLabel1.TabIndex = 2
        Me.MyLabel1.Text = "MyLabel1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(489, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 60)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MyLabel1)
        Me.Controls.Add(Me.MyTxtBox1)
        Me.Controls.Add(Me.MyBtn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyBtn1 As Button
    Friend WithEvents MyTxtBox1 As TextBox
    Friend WithEvents MyLabel1 As Label
    Friend WithEvents Button1 As Button
End Class
