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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.rtbMain = New System.Windows.Forms.RichTextBox()
        Me.msTools = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutNoteydToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbFontSize = New System.Windows.Forms.ToolStripComboBox()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.msTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'sfdSave
        '
        Me.sfdSave.Filter = "Rich Text File|*.rtf"
        Me.sfdSave.Title = "Save As..."
        '
        'rtbMain
        '
        Me.rtbMain.DetectUrls = False
        Me.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbMain.Location = New System.Drawing.Point(0, 27)
        Me.rtbMain.Name = "rtbMain"
        Me.rtbMain.Size = New System.Drawing.Size(291, 174)
        Me.rtbMain.TabIndex = 0
        Me.rtbMain.Text = ""
        '
        'msTools
        '
        Me.msTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.cbFontSize})
        Me.msTools.Location = New System.Drawing.Point(0, 0)
        Me.msTools.Name = "msTools"
        Me.msTools.Size = New System.Drawing.Size(291, 27)
        Me.msTools.TabIndex = 1
        Me.msTools.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.WebBrowserToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutNoteydToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem1.Text = "Save..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SaveToolStripMenuItem.Text = "Save As..."
        '
        'WebBrowserToolStripMenuItem
        '
        Me.WebBrowserToolStripMenuItem.Name = "WebBrowserToolStripMenuItem"
        Me.WebBrowserToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.WebBrowserToolStripMenuItem.Text = "Web browser"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'AboutNoteydToolStripMenuItem
        '
        Me.AboutNoteydToolStripMenuItem.Name = "AboutNoteydToolStripMenuItem"
        Me.AboutNoteydToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AboutNoteydToolStripMenuItem.Text = "About Notey..."
        '
        'cbFontSize
        '
        Me.cbFontSize.Items.AddRange(New Object() {"8", "9", "12", "18", "22", "28", "32", "38", "42", "46", "52", "64", "72", "82", "98", "102"})
        Me.cbFontSize.Name = "cbFontSize"
        Me.cbFontSize.Size = New System.Drawing.Size(121, 23)
        Me.cbFontSize.Text = "8"
        '
        'ofdOpen
        '
        Me.ofdOpen.Filter = "Rich Text Format|*.rtf*"
        Me.ofdOpen.Title = "Open..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 201)
        Me.Controls.Add(Me.rtbMain)
        Me.Controls.Add(Me.msTools)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msTools
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Notey"
        Me.msTools.ResumeLayout(False)
        Me.msTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sfdSave As SaveFileDialog
    Friend WithEvents rtbMain As RichTextBox
    Friend WithEvents msTools As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbFontSize As ToolStripComboBox
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutNoteydToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents WebBrowserToolStripMenuItem As ToolStripMenuItem
End Class
