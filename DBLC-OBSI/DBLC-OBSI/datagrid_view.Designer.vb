<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class datagrid_view
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
        Me.registration_load_button = New System.Windows.Forms.Button()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.exit_button = New System.Windows.Forms.PictureBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.cy_datagridview = New System.Windows.Forms.DataGridView()
        Me.search_textbox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.search_button = New System.Windows.Forms.Button()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exit_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cy_datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout
        '
        'registration_load_button
        '
        Me.registration_load_button.Location = New System.Drawing.Point(573, 616)
        Me.registration_load_button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.registration_load_button.Name = "registration_load_button"
        Me.registration_load_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.registration_load_button.Size = New System.Drawing.Size(76, 22)
        Me.registration_load_button.TabIndex = 16
        Me.registration_load_button.Text = "Load"
        Me.registration_load_button.UseVisualStyleBackColor = True
        '
        'minimize
        '
        Me.minimize.Image = Global.DBLC_OBSI.My.Resources.Resources.PhotoRoom_20230719_204941
        Me.minimize.Location = New System.Drawing.Point(1242, 12)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(26, 21)
        Me.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimize.TabIndex = 18
        Me.minimize.TabStop = False
        '
        'exit_button
        '
        Me.exit_button.Image = Global.DBLC_OBSI.My.Resources.Resources.PhotoRoom_20230719_204941__2_
        Me.exit_button.Location = New System.Drawing.Point(1265, 12)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(26, 21)
        Me.exit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exit_button.TabIndex = 17
        Me.exit_button.TabStop = False
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(655, 616)
        Me.Delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Delete.Name = "Delete"
        Me.Delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Delete.Size = New System.Drawing.Size(76, 22)
        Me.Delete.TabIndex = 20
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'cy_datagridview
        '
        Me.cy_datagridview.AllowUserToAddRows = False
        Me.cy_datagridview.AllowUserToDeleteRows = False
        Me.cy_datagridview.BackgroundColor = System.Drawing.Color.White
        Me.cy_datagridview.Location = New System.Drawing.Point(12, 48)
        Me.cy_datagridview.Name = "cy_datagridview"
        Me.cy_datagridview.ReadOnly = True
        Me.cy_datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.cy_datagridview.Size = New System.Drawing.Size(1279, 551)
        Me.cy_datagridview.TabIndex = 22
        '
        'search_textbox
        '
        Me.search_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.search_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.search_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.search_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.search_textbox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.search_textbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.search_textbox.HintForeColor = System.Drawing.Color.Empty
        Me.search_textbox.HintText = ""
        Me.search_textbox.isPassword = False
        Me.search_textbox.LineFocusedColor = System.Drawing.Color.Blue
        Me.search_textbox.LineIdleColor = System.Drawing.Color.Gray
        Me.search_textbox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.search_textbox.LineThickness = 3
        Me.search_textbox.Location = New System.Drawing.Point(94, 8)
        Me.search_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.search_textbox.MaxLength = 32767
        Me.search_textbox.Name = "search_textbox"
        Me.search_textbox.Size = New System.Drawing.Size(287, 33)
        Me.search_textbox.TabIndex = 23
        Me.search_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'search_button
        '
        Me.search_button.Location = New System.Drawing.Point(12, 18)
        Me.search_button.Name = "search_button"
        Me.search_button.Size = New System.Drawing.Size(75, 23)
        Me.search_button.TabIndex = 24
        Me.search_button.Text = "Search"
        Me.search_button.UseVisualStyleBackColor = True
        '
        'datagrid_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1303, 651)
        Me.Controls.Add(Me.search_button)
        Me.Controls.Add(Me.search_textbox)
        Me.Controls.Add(Me.cy_datagridview)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.registration_load_button)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "datagrid_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datagrid view"
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exit_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cy_datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents registration_load_button As Button
    Friend WithEvents minimize As PictureBox
    Friend WithEvents exit_button As PictureBox
    Friend WithEvents Delete As Button
    Friend WithEvents cy_datagridview As DataGridView
    Friend WithEvents search_textbox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents search_button As Button
End Class
