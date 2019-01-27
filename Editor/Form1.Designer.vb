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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Exit1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Clear1 = New System.Windows.Forms.Button()
        Me.Italic1 = New System.Windows.Forms.Button()
        Me.Bold1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Exit1
        '
        Me.Exit1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Exit1.Font = New System.Drawing.Font("Chiller", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit1.Location = New System.Drawing.Point(738, 405)
        Me.Exit1.Name = "Exit1"
        Me.Exit1.Size = New System.Drawing.Size(146, 53)
        Me.Exit1.TabIndex = 0
        Me.Exit1.Text = "E&xit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Exit1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Location = New System.Drawing.Point(43, 127)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(832, 60)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "This is a Text-Box."
        '
        'Clear1
        '
        Me.Clear1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Clear1.Font = New System.Drawing.Font("Chiller", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear1.Location = New System.Drawing.Point(537, 405)
        Me.Clear1.Name = "Clear1"
        Me.Clear1.Size = New System.Drawing.Size(146, 53)
        Me.Clear1.TabIndex = 2
        Me.Clear1.Text = "&CLEAR"
        Me.Clear1.UseVisualStyleBackColor = False
        '
        'Italic1
        '
        Me.Italic1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Italic1.Font = New System.Drawing.Font("Chiller", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Italic1.Location = New System.Drawing.Point(225, 405)
        Me.Italic1.Name = "Italic1"
        Me.Italic1.Size = New System.Drawing.Size(146, 53)
        Me.Italic1.TabIndex = 3
        Me.Italic1.Text = "&ITALIC"
        Me.Italic1.UseVisualStyleBackColor = False
        '
        'Bold1
        '
        Me.Bold1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Bold1.Font = New System.Drawing.Font("Chiller", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bold1.Location = New System.Drawing.Point(12, 405)
        Me.Bold1.Name = "Bold1"
        Me.Bold1.Size = New System.Drawing.Size(146, 53)
        Me.Bold1.TabIndex = 4
        Me.Bold1.Text = "&BOLD"
        Me.Bold1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.Location = New System.Drawing.Point(274, 9)
        Me.Label1.MinimumSize = New System.Drawing.Size(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 35)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "WELCOME TO THE NEW TEXT EDITOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.g
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(896, 468)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bold1)
        Me.Controls.Add(Me.Italic1)
        Me.Controls.Add(Me.Clear1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Exit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Exit1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Clear1 As Button
    Friend WithEvents Italic1 As Button
    Friend WithEvents Bold1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
