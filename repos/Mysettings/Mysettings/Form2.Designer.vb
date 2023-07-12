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
        Me.InputName = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MySaveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InputName
        '
        Me.InputName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Mysettings.My.MySettings.Default, "Name", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.InputName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputName.Location = New System.Drawing.Point(176, 210)
        Me.InputName.Name = "InputName"
        Me.InputName.Size = New System.Drawing.Size(448, 30)
        Me.InputName.TabIndex = 5
        Me.InputName.Text = Global.Mysettings.My.MySettings.Default.Name
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Mysettings.My.MySettings.Default, "FirstName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(415, 145)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = Global.Mysettings.My.MySettings.Default.FirstName
        '
        'MySaveBtn
        '
        Me.MySaveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MySaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MySaveBtn.Location = New System.Drawing.Point(268, 294)
        Me.MySaveBtn.Name = "MySaveBtn"
        Me.MySaveBtn.Size = New System.Drawing.Size(218, 65)
        Me.MySaveBtn.TabIndex = 10
        Me.MySaveBtn.Text = "Save"
        Me.MySaveBtn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MySaveBtn)
        Me.Controls.Add(Me.InputName)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents InputName As TextBox
    Friend WithEvents MySaveBtn As Button
End Class
