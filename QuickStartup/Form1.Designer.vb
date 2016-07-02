<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startupForm
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
        Me.startupLabel = New System.Windows.Forms.Label()
        Me.nameFileTextbox = New System.Windows.Forms.TextBox()
        Me.FilesGroup = New System.Windows.Forms.GroupBox()
        Me.filesListBox = New System.Windows.Forms.ListBox()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.addFileButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FilesGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'startupLabel
        '
        Me.startupLabel.AutoSize = True
        Me.startupLabel.Location = New System.Drawing.Point(4, 12)
        Me.startupLabel.Name = "startupLabel"
        Me.startupLabel.Size = New System.Drawing.Size(101, 13)
        Me.startupLabel.TabIndex = 0
        Me.startupLabel.Text = "Name of startup file:"
        '
        'nameFileTextbox
        '
        Me.nameFileTextbox.Location = New System.Drawing.Point(111, 9)
        Me.nameFileTextbox.Name = "nameFileTextbox"
        Me.nameFileTextbox.Size = New System.Drawing.Size(355, 20)
        Me.nameFileTextbox.TabIndex = 1
        '
        'FilesGroup
        '
        Me.FilesGroup.Controls.Add(Me.filesListBox)
        Me.FilesGroup.Location = New System.Drawing.Point(2, 48)
        Me.FilesGroup.Name = "FilesGroup"
        Me.FilesGroup.Size = New System.Drawing.Size(471, 197)
        Me.FilesGroup.TabIndex = 2
        Me.FilesGroup.TabStop = False
        Me.FilesGroup.Text = "Files in Startup"
        '
        'filesListBox
        '
        Me.filesListBox.FormattingEnabled = True
        Me.filesListBox.Location = New System.Drawing.Point(7, 19)
        Me.filesListBox.Name = "filesListBox"
        Me.filesListBox.Size = New System.Drawing.Size(457, 173)
        Me.filesListBox.TabIndex = 0
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(12, 251)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(109, 29)
        Me.generateButton.TabIndex = 3
        Me.generateButton.Text = "Generate Startup"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'addFileButton
        '
        Me.addFileButton.Location = New System.Drawing.Point(127, 251)
        Me.addFileButton.Name = "addFileButton"
        Me.addFileButton.Size = New System.Drawing.Size(109, 29)
        Me.addFileButton.TabIndex = 4
        Me.addFileButton.Text = "Add File"
        Me.addFileButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(242, 251)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(109, 29)
        Me.closeButton.TabIndex = 5
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'startupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 302)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.addFileButton)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.FilesGroup)
        Me.Controls.Add(Me.nameFileTextbox)
        Me.Controls.Add(Me.startupLabel)
        Me.Name = "startupForm"
        Me.Text = "Quick Startup"
        Me.FilesGroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startupLabel As System.Windows.Forms.Label
    Friend WithEvents nameFileTextbox As System.Windows.Forms.TextBox
    Friend WithEvents FilesGroup As System.Windows.Forms.GroupBox
    Friend WithEvents filesListBox As System.Windows.Forms.ListBox
    Friend WithEvents generateButton As System.Windows.Forms.Button
    Friend WithEvents addFileButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
