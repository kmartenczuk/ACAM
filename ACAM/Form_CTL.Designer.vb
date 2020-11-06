<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_CTL
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Button1.Location = New System.Drawing.Point(698, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "New Mill Tool"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(113, 415)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "New Mill Holder"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(11, 209)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "New"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(214, 40)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(574, 369)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(12, 13)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(195, 195)
        Me.ListView2.TabIndex = 6
        Me.ListView2.TileSize = New System.Drawing.Size(168, 16)
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Tile
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Name", "Diameter", "Type"})
        Me.ComboBox1.Location = New System.Drawing.Point(215, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(343, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(693, 11)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(76, 209)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(67, 23)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Rename"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(141, 209)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(67, 23)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "Delete"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(343, 184)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(319, 10)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 15
        Me.ProgressBar1.UseWaitCursor = True
        Me.ProgressBar1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(214, 40)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(574, 369)
        Me.TextBox2.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "User : -"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 166)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(195, 20)
        Me.TextBox3.TabIndex = 18
        Me.TextBox3.Visible = False
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button10.Location = New System.Drawing.Point(11, 185)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(98, 23)
        Me.Button10.TabIndex = 19
        Me.Button10.Text = "Accept"
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button11.Location = New System.Drawing.Point(108, 185)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(99, 23)
        Me.Button11.TabIndex = 20
        Me.Button11.Text = "Cancel"
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "New Library | Name:"
        Me.Label2.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox4.Location = New System.Drawing.Point(215, 418)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(319, 14)
        Me.TextBox4.TabIndex = 22
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button12
        '
        Me.Button12.Enabled = False
        Me.Button12.Location = New System.Drawing.Point(540, 415)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(55, 23)
        Me.Button12.TabIndex = 23
        Me.Button12.Text = "Copy"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Enabled = False
        Me.Button13.Location = New System.Drawing.Point(593, 415)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(55, 23)
        Me.Button13.TabIndex = 24
        Me.Button13.Text = "Delete"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(495, 435)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Visible = False
        '
        'Form_CTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.Name = "Form_CTL"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoCAD CAM Tool Library"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents ListView1 As Windows.Forms.ListView
    Friend WithEvents ListView2 As Windows.Forms.ListView
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Button6 As Windows.Forms.Button
    Friend WithEvents Button8 As Windows.Forms.Button
    Friend WithEvents Button9 As Windows.Forms.Button
    Friend WithEvents ProgressBar1 As Windows.Forms.ProgressBar
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
    Friend WithEvents Button10 As Windows.Forms.Button
    Friend WithEvents Button11 As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TextBox4 As Windows.Forms.TextBox
    Friend WithEvents Button12 As Windows.Forms.Button
    Friend WithEvents Button13 As Windows.Forms.Button
    Friend WithEvents Label3 As Windows.Forms.Label
End Class
