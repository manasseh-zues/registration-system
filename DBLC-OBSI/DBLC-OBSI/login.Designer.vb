<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.username_textbox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.password_textbox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.login_button = New System.Windows.Forms.Button()
        Me.signup_label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.exit_button = New System.Windows.Forms.PictureBox()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exit_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username_textbox
        '
        Me.username_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.username_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.username_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.username_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username_textbox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_textbox.ForeColor = System.Drawing.Color.Black
        Me.username_textbox.HintForeColor = System.Drawing.Color.Gray
        Me.username_textbox.HintText = "Username"
        Me.username_textbox.isPassword = False
        Me.username_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username_textbox.LineIdleColor = System.Drawing.Color.Gray
        Me.username_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username_textbox.LineThickness = 3
        Me.username_textbox.Location = New System.Drawing.Point(23, 162)
        Me.username_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.username_textbox.MaxLength = 32767
        Me.username_textbox.Name = "username_textbox"
        Me.username_textbox.Size = New System.Drawing.Size(264, 33)
        Me.username_textbox.TabIndex = 2
        Me.username_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.password_textbox.Location = New System.Drawing.Point(23, 210)
        Me.password_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.password_textbox.MaxLength = 32767
        Me.password_textbox.Name = "password_textbox"
        Me.password_textbox.Size = New System.Drawing.Size(264, 33)
        Me.password_textbox.TabIndex = 3
        Me.password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'login_button
        '
        Me.login_button.Location = New System.Drawing.Point(84, 273)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(136, 36)
        Me.login_button.TabIndex = 4
        Me.login_button.Text = "Login"
        Me.login_button.UseVisualStyleBackColor = True
        '
        'signup_label
        '
        Me.signup_label.AutoSize = True
        Me.signup_label.Location = New System.Drawing.Point(28, 331)
        Me.signup_label.Name = "signup_label"
        Me.signup_label.Size = New System.Drawing.Size(252, 17)
        Me.signup_label.TabIndex = 5
        Me.signup_label.Text = "Don't have account? click here to signup"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Your spiritual welfare if our concern"
        '
        'minimize
        '
        Me.minimize.Image = Global.DBLC_OBSI.My.Resources.Resources.PhotoRoom_20230719_204941
        Me.minimize.Location = New System.Drawing.Point(254, 8)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(26, 21)
        Me.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimize.TabIndex = 11
        Me.minimize.TabStop = False
        '
        'exit_button
        '
        Me.exit_button.Image = Global.DBLC_OBSI.My.Resources.Resources.PhotoRoom_20230719_204941__2_
        Me.exit_button.Location = New System.Drawing.Point(277, 8)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(26, 21)
        Me.exit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exit_button.TabIndex = 10
        Me.exit_button.TabStop = False
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
        Me.BunifuPictureBox1.TabIndex = 6
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(315, 396)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.signup_label)
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.password_textbox)
        Me.Controls.Add(Me.username_textbox)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exit_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents username_textbox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents password_textbox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents login_button As Button
    Friend WithEvents signup_label As Label
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents exit_button As PictureBox
    Friend WithEvents minimize As PictureBox
End Class
