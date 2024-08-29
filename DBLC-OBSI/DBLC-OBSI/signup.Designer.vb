<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signup
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.login_label = New System.Windows.Forms.Label()
        Me.signup_button = New System.Windows.Forms.Button()
        Me.uname_textbox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.fname_textbox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.password_textbox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.retype_textbox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.exit_button = New System.Windows.Forms.PictureBox()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exit_button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Your spiritual welfare if our concern"
        '
        'login_label
        '
        Me.login_label.AutoSize = True
        Me.login_label.Location = New System.Drawing.Point(23, 421)
        Me.login_label.Name = "login_label"
        Me.login_label.Size = New System.Drawing.Size(271, 17)
        Me.login_label.TabIndex = 13
        Me.login_label.Text = "Already having account? click here to login."
        '
        'signup_button
        '
        Me.signup_button.Location = New System.Drawing.Point(88, 371)
        Me.signup_button.Name = "signup_button"
        Me.signup_button.Size = New System.Drawing.Size(136, 36)
        Me.signup_button.TabIndex = 12
        Me.signup_button.Text = "signup"
        Me.signup_button.UseVisualStyleBackColor = True
        '
        'uname_textbox
        '
        Me.uname_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.uname_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.uname_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.uname_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.uname_textbox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uname_textbox.ForeColor = System.Drawing.Color.Black
        Me.uname_textbox.HintForeColor = System.Drawing.Color.Gray
        Me.uname_textbox.HintText = "Username"
        Me.uname_textbox.isPassword = False
        Me.uname_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.uname_textbox.LineIdleColor = System.Drawing.Color.Gray
        Me.uname_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.uname_textbox.LineThickness = 3
        Me.uname_textbox.Location = New System.Drawing.Point(26, 210)
        Me.uname_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.uname_textbox.MaxLength = 32767
        Me.uname_textbox.Name = "uname_textbox"
        Me.uname_textbox.Size = New System.Drawing.Size(254, 33)
        Me.uname_textbox.TabIndex = 11
        Me.uname_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'fname_textbox
        '
        Me.fname_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.fname_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.fname_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.fname_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fname_textbox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname_textbox.ForeColor = System.Drawing.Color.Black
        Me.fname_textbox.HintForeColor = System.Drawing.Color.Gray
        Me.fname_textbox.HintText = "Full Name"
        Me.fname_textbox.isPassword = False
        Me.fname_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fname_textbox.LineIdleColor = System.Drawing.Color.Gray
        Me.fname_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fname_textbox.LineThickness = 3
        Me.fname_textbox.Location = New System.Drawing.Point(26, 169)
        Me.fname_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.fname_textbox.MaxLength = 32767
        Me.fname_textbox.Name = "fname_textbox"
        Me.fname_textbox.Size = New System.Drawing.Size(255, 33)
        Me.fname_textbox.TabIndex = 10
        Me.fname_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'password_textbox
        '
        Me.password_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.password_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.password_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_textbox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_textbox.ForeColor = System.Drawing.Color.Black
        Me.password_textbox.HintForeColor = System.Drawing.Color.Gray
        Me.password_textbox.HintText = "Password"
        Me.password_textbox.isPassword = True
        Me.password_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password_textbox.LineIdleColor = System.Drawing.Color.Gray
        Me.password_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password_textbox.LineThickness = 3
        Me.password_textbox.Location = New System.Drawing.Point(26, 251)
        Me.password_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.password_textbox.MaxLength = 32767
        Me.password_textbox.Name = "password_textbox"
        Me.password_textbox.Size = New System.Drawing.Size(255, 36)
        Me.password_textbox.TabIndex = 17
        Me.password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'retype_textbox
        '
        Me.retype_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.retype_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.retype_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.retype_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.retype_textbox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retype_textbox.ForeColor = System.Drawing.Color.Black
        Me.retype_textbox.HintForeColor = System.Drawing.Color.Gray
        Me.retype_textbox.HintText = "Retype"
        Me.retype_textbox.isPassword = True
        Me.retype_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.retype_textbox.LineIdleColor = System.Drawing.Color.Gray
        Me.retype_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.retype_textbox.LineThickness = 3
        Me.retype_textbox.Location = New System.Drawing.Point(26, 295)
        Me.retype_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.retype_textbox.MaxLength = 32767
        Me.retype_textbox.Name = "retype_textbox"
        Me.retype_textbox.Size = New System.Drawing.Size(255, 37)
        Me.retype_textbox.TabIndex = 19
        Me.retype_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = Global.DBLC_OBSI.My.Resources.Resources.cropped_DLCM_Logo_512x512
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(110, 8)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(95, 95)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 14
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'minimize
        '
        Me.minimize.Image = Global.DBLC_OBSI.My.Resources.Resources.PhotoRoom_20230719_204941
        Me.minimize.Location = New System.Drawing.Point(254, 8)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(26, 21)
        Me.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimize.TabIndex = 21
        Me.minimize.TabStop = False
        '
        'exit_button
        '
        Me.exit_button.Image = Global.DBLC_OBSI.My.Resources.Resources.PhotoRoom_20230719_204941__2_
        Me.exit_button.Location = New System.Drawing.Point(277, 8)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(26, 21)
        Me.exit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exit_button.TabIndex = 20
        Me.exit_button.TabStop = False
        '
        'signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(315, 460)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.retype_textbox)
        Me.Controls.Add(Me.password_textbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.login_label)
        Me.Controls.Add(Me.signup_button)
        Me.Controls.Add(Me.uname_textbox)
        Me.Controls.Add(Me.fname_textbox)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "signup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signup"
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exit_button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents login_label As Label
    Friend WithEvents signup_button As Button
    Friend WithEvents uname_textbox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents fname_textbox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents password_textbox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents retype_textbox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents minimize As PictureBox
    Friend WithEvents exit_button As PictureBox
End Class
