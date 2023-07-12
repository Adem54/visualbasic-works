<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MyName = New System.Windows.Forms.Label()
        Me.MyCity = New System.Windows.Forms.Label()
        Me.MySurname = New System.Windows.Forms.Label()
        Me.MyBorn = New System.Windows.Forms.Label()
        Me.InputCity = New System.Windows.Forms.TextBox()
        Me.InputBorn = New System.Windows.Forms.TextBox()
        Me.InputSurname = New System.Windows.Forms.TextBox()
        Me.MySaveBtn = New System.Windows.Forms.Button()
        Me.MyAddAvatarBtn = New System.Windows.Forms.Button()
        Me.AvatarURL = New System.Windows.Forms.Label()
        Me.ChooseFile = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InputName = New System.Windows.Forms.TextBox()
        Me.MyPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MyPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MyPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AvatarPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.MyPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyName
        '
        Me.MyName.AutoSize = True
        Me.MyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyName.Location = New System.Drawing.Point(124, 86)
        Me.MyName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyName.Name = "MyName"
        Me.MyName.Size = New System.Drawing.Size(64, 25)
        Me.MyName.TabIndex = 0
        Me.MyName.Text = "Name"
        '
        'MyCity
        '
        Me.MyCity.AutoSize = True
        Me.MyCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyCity.Location = New System.Drawing.Point(124, 322)
        Me.MyCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyCity.Name = "MyCity"
        Me.MyCity.Size = New System.Drawing.Size(46, 25)
        Me.MyCity.TabIndex = 1
        Me.MyCity.Text = "City"
        '
        'MySurname
        '
        Me.MySurname.AutoSize = True
        Me.MySurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MySurname.Location = New System.Drawing.Point(124, 159)
        Me.MySurname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MySurname.Name = "MySurname"
        Me.MySurname.Size = New System.Drawing.Size(92, 25)
        Me.MySurname.TabIndex = 2
        Me.MySurname.Text = "Surname"
        '
        'MyBorn
        '
        Me.MyBorn.AutoSize = True
        Me.MyBorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyBorn.Location = New System.Drawing.Point(124, 247)
        Me.MyBorn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyBorn.Name = "MyBorn"
        Me.MyBorn.Size = New System.Drawing.Size(53, 25)
        Me.MyBorn.TabIndex = 3
        Me.MyBorn.Text = "Born"
        '
        'InputCity
        '
        Me.InputCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputCity.Location = New System.Drawing.Point(275, 315)
        Me.InputCity.Name = "InputCity"
        Me.InputCity.Size = New System.Drawing.Size(448, 30)
        Me.InputCity.TabIndex = 5
        '
        'InputBorn
        '
        Me.InputBorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputBorn.Location = New System.Drawing.Point(275, 247)
        Me.InputBorn.Name = "InputBorn"
        Me.InputBorn.Size = New System.Drawing.Size(448, 30)
        Me.InputBorn.TabIndex = 6
        '
        'InputSurname
        '
        Me.InputSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputSurname.Location = New System.Drawing.Point(275, 159)
        Me.InputSurname.Name = "InputSurname"
        Me.InputSurname.Size = New System.Drawing.Size(448, 30)
        Me.InputSurname.TabIndex = 7
        '
        'MySaveBtn
        '
        Me.MySaveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MySaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MySaveBtn.Location = New System.Drawing.Point(385, 433)
        Me.MySaveBtn.Name = "MySaveBtn"
        Me.MySaveBtn.Size = New System.Drawing.Size(218, 65)
        Me.MySaveBtn.TabIndex = 9
        Me.MySaveBtn.Text = "Save"
        Me.MySaveBtn.UseVisualStyleBackColor = False
        '
        'MyAddAvatarBtn
        '
        Me.MyAddAvatarBtn.BackColor = System.Drawing.Color.Aqua
        Me.MyAddAvatarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyAddAvatarBtn.Location = New System.Drawing.Point(751, 242)
        Me.MyAddAvatarBtn.Name = "MyAddAvatarBtn"
        Me.MyAddAvatarBtn.Size = New System.Drawing.Size(215, 43)
        Me.MyAddAvatarBtn.TabIndex = 10
        Me.MyAddAvatarBtn.Text = "Add Avatar"
        Me.MyAddAvatarBtn.UseVisualStyleBackColor = False
        '
        'AvatarURL
        '
        Me.AvatarURL.AutoSize = True
        Me.AvatarURL.Location = New System.Drawing.Point(53, 467)
        Me.AvatarURL.Name = "AvatarURL"
        Me.AvatarURL.Size = New System.Drawing.Size(91, 20)
        Me.AvatarURL.TabIndex = 14
        Me.AvatarURL.Text = "AvatarURL"
        '
        'ChooseFile
        '
        Me.ChooseFile.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(763, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 59)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "OpenForm2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InputName
        '
        Me.InputName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputName.Location = New System.Drawing.Point(275, 86)
        Me.InputName.Name = "InputName"
        Me.InputName.Size = New System.Drawing.Size(448, 30)
        Me.InputName.TabIndex = 4
        '
        'MyPictureBox2
        '
        Me.MyPictureBox2.BackColor = System.Drawing.Color.Fuchsia
        Me.MyPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyPictureBox2.Location = New System.Drawing.Point(828, 315)
        Me.MyPictureBox2.Name = "MyPictureBox2"
        Me.MyPictureBox2.Size = New System.Drawing.Size(60, 38)
        Me.MyPictureBox2.TabIndex = 13
        Me.MyPictureBox2.TabStop = False
        '
        'MyPictureBox3
        '
        Me.MyPictureBox3.BackColor = System.Drawing.Color.Yellow
        Me.MyPictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyPictureBox3.Location = New System.Drawing.Point(906, 315)
        Me.MyPictureBox3.Name = "MyPictureBox3"
        Me.MyPictureBox3.Size = New System.Drawing.Size(60, 38)
        Me.MyPictureBox3.TabIndex = 12
        Me.MyPictureBox3.TabStop = False
        '
        'MyPictureBox1
        '
        Me.MyPictureBox1.BackColor = System.Drawing.Color.Blue
        Me.MyPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyPictureBox1.Location = New System.Drawing.Point(749, 315)
        Me.MyPictureBox1.Name = "MyPictureBox1"
        Me.MyPictureBox1.Size = New System.Drawing.Size(60, 38)
        Me.MyPictureBox1.TabIndex = 11
        Me.MyPictureBox1.TabStop = False
        '
        'AvatarPictureBox
        '
        Me.AvatarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AvatarPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AvatarPictureBox.Location = New System.Drawing.Point(749, 86)
        Me.AvatarPictureBox.Name = "AvatarPictureBox"
        Me.AvatarPictureBox.Size = New System.Drawing.Size(218, 145)
        Me.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AvatarPictureBox.TabIndex = 8
        Me.AvatarPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 809)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MyPictureBox2)
        Me.Controls.Add(Me.MyPictureBox3)
        Me.Controls.Add(Me.MyPictureBox1)
        Me.Controls.Add(Me.MyAddAvatarBtn)
        Me.Controls.Add(Me.MySaveBtn)
        Me.Controls.Add(Me.InputSurname)
        Me.Controls.Add(Me.InputBorn)
        Me.Controls.Add(Me.InputCity)
        Me.Controls.Add(Me.InputName)
        Me.Controls.Add(Me.MyBorn)
        Me.Controls.Add(Me.MySurname)
        Me.Controls.Add(Me.MyCity)
        Me.Controls.Add(Me.MyName)
        Me.Controls.Add(Me.AvatarURL)
        Me.Controls.Add(Me.AvatarPictureBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.MyPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyName As Label
    Friend WithEvents MyCity As Label
    Friend WithEvents MySurname As Label
    Friend WithEvents MyBorn As Label
    Friend WithEvents InputName As TextBox
    Friend WithEvents InputCity As TextBox
    Friend WithEvents InputBorn As TextBox
    Friend WithEvents InputSurname As TextBox
    Friend WithEvents AvatarPictureBox As PictureBox
    Friend WithEvents MySaveBtn As Button
    Friend WithEvents MyAddAvatarBtn As Button
    Friend WithEvents MyPictureBox1 As PictureBox
    Friend WithEvents MyPictureBox3 As PictureBox
    Friend WithEvents MyPictureBox2 As PictureBox
    Friend WithEvents AvatarURL As Label
    Friend WithEvents ChooseFile As OpenFileDialog
    Friend WithEvents Button1 As Button

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
