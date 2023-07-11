<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyForm1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyForm1))
        Me.MyButton = New System.Windows.Forms.Button()
        Me.MyButton2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Contextmeu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Contextmenu2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Menuitem1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menuitem2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog3 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog4 = New System.Windows.Forms.ColorDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyButton
        '
        Me.MyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MyButton.Location = New System.Drawing.Point(685, 48)
        Me.MyButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MyButton.Name = "MyButton"
        Me.MyButton.Size = New System.Drawing.Size(277, 91)
        Me.MyButton.TabIndex = 0
        Me.MyButton.Text = "MyBtnTxt"
        Me.MyButton.UseVisualStyleBackColor = True
        '
        'MyButton2
        '
        Me.MyButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MyButton2.Location = New System.Drawing.Point(125, 557)
        Me.MyButton2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(170, 49)
        Me.MyButton2.TabIndex = 1
        Me.MyButton2.Text = "MyBtnTxt2"
        Me.MyButton2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(466, 248)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Hello"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Contextmeu1ToolStripMenuItem, Me.Contextmenu2ToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(157, 70)
        '
        'Contextmeu1ToolStripMenuItem
        '
        Me.Contextmeu1ToolStripMenuItem.Name = "Contextmeu1ToolStripMenuItem"
        Me.Contextmeu1ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.Contextmeu1ToolStripMenuItem.Text = "context-meu1"
        '
        'Contextmenu2ToolStripMenuItem
        '
        Me.Contextmenu2ToolStripMenuItem.Name = "Contextmenu2ToolStripMenuItem"
        Me.Contextmenu2ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.Contextmenu2ToolStripMenuItem.Text = "context-menu2"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menuitem1ToolStripMenuItem, Me.Menuitem2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(988, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menuitem1ToolStripMenuItem
        '
        Me.Menuitem1ToolStripMenuItem.Name = "Menuitem1ToolStripMenuItem"
        Me.Menuitem1ToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.Menuitem1ToolStripMenuItem.Text = "menu-item-1"
        '
        'Menuitem2ToolStripMenuItem
        '
        Me.Menuitem2ToolStripMenuItem.Name = "Menuitem2ToolStripMenuItem"
        Me.Menuitem2ToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.Menuitem2ToolStripMenuItem.Text = "menu-item-2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ColorDialog2
        '
        Me.ColorDialog2.AnyColor = True
        Me.ColorDialog2.Color = System.Drawing.Color.DeepPink
        Me.ColorDialog2.FullOpen = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(598, 350)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 207)
        Me.Panel1.TabIndex = 6
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'MyForm1
        '
        Me.AcceptButton = Me.MyButton2
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.MyButton
        Me.ClientSize = New System.Drawing.Size(1008, 629)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.MyButton)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "MyForm1"
        Me.Padding = New System.Windows.Forms.Padding(20, 0, 0, 20)
        Me.Text = "MyForm1Txt"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyButton As Button
    Friend WithEvents MyButton2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Contextmeu1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Contextmenu2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Menuitem1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menuitem2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents ColorDialog3 As ColorDialog
    Friend WithEvents ColorDialog4 As ColorDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
