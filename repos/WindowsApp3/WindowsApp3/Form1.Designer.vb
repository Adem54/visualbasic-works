<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyFrm1
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
        Me.MyLbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MyBtn1
        '
        Me.MyBtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyBtn1.Location = New System.Drawing.Point(392, 144)
        Me.MyBtn1.Name = "MyBtn1"
        Me.MyBtn1.Size = New System.Drawing.Size(211, 69)
        Me.MyBtn1.TabIndex = 0
        Me.MyBtn1.Text = "MyButton1"
        Me.MyBtn1.UseVisualStyleBackColor = True
        '
        'MyLbl1
        '
        Me.MyLbl1.AutoSize = True
        Me.MyLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLbl1.Location = New System.Drawing.Point(80, 170)
        Me.MyLbl1.Name = "MyLbl1"
        Me.MyLbl1.Size = New System.Drawing.Size(123, 31)
        Me.MyLbl1.TabIndex = 1
        Me.MyLbl1.Text = "MyLabel1"
        '
        'MyFrm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MyLbl1)
        Me.Controls.Add(Me.MyBtn1)
        Me.Name = "MyFrm1"
        Me.Text = "MyForm1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyBtn1 As Button
    Friend WithEvents MyLbl1 As Label
End Class
