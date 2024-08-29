Imports MySql.Data.MySqlClient
Public Class signup

    Inherits Form

    Private isDragging As Boolean = False
    Private clickPosition As Point


    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If (e.Button = MouseButtons.Left) Then
            isDragging = True
            clickPosition = e.Location
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If (isDragging) Then
            Dim position As Point = Me.PointToScreen(e.Location)
            Me.Location = New Point(position.X - clickPosition.X, position.Y - clickPosition.Y)
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        isDragging = False
    End Sub



    Private borderForm As New Form
    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With

        With borderForm
            .ShowInTaskbar = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .StartPosition = FormStartPosition.Manual
            .BackColor = Color.Black
            .Opacity = 0.01

            Dim r As Rectangle = Me.Bounds
            r.Inflate(2, 2)
            .Bounds = r
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
            r = New Rectangle(3, 3, Me.Width - 4, Me.Height - 4)
            .Region.Exclude(RoundedRectangle(r, 48))
            .Show(Me)
        End With
    End Sub

    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath
        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
        path.CloseFigure()
        Return path
    End Function
    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Signup_button_Click_1(sender As Object, e As EventArgs) Handles signup_button.Click

        ' check if the fields are empty
        ' check if the password = the confirm password
        ' check if the username already exists

        ' get textboxes values
        Dim fname As String = fname_textbox.Text
        Dim username As String = uname_textbox.Text
        Dim password As String = password_textbox.Text
        Dim cpassword As String = retype_textbox.Text


        If fname.Trim() = "" Or username.Trim() = "" Or password.Trim() = "" Then

            MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Not String.Equals(password, cpassword) Then

            MessageBox.Show("Password unmatched", "password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf usernameExist(username) Then

            MessageBox.Show("This Username Already Exists", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            ' add the new user
            Dim conn As New mysql_connect()


            Dim command As New MySqlCommand("INSERT INTO `users`(`full_name`, `username`, `password`) VALUES (@fn, @usn, @pass)", conn.getConnection)

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

            conn.openConnection()
            Dim duplicateQuery As String = "SELECT COUNT(*) FROM users WHERE full_name = @fn AND username = @usn AND password = @pass "
            Using cmDsql As New MySqlCommand(duplicateQuery, conn.getConnection)
                ' Add parameters to the command
                cmDsql.Parameters.AddWithValue("@fn", fname)
                cmDsql.Parameters.AddWithValue("@usn", username)
                cmDsql.Parameters.AddWithValue("@pass", password)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' If duplicate data exists, show an error message and return
                If count > 0 Then
                    MessageBox.Show("Duplicate data found. Please enter unique data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Signup Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()

                Me.Hide()
                Dim signup As New login()
                login.Show()

            Else

                MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()

            End If


        End If

    End Sub

    ' create a function to check if the username already exists
    Public Function usernameExist(ByVal username As String) As Boolean

        Dim con As New mysql_connect()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        ' if the username exist return true
        If table.Rows.Count > 0 Then

            Return True

            ' if not return false  
        Else

            Return False

        End If

    End Function

    Private Sub signup_label(sender As Object, e As EventArgs) Handles login_label.Click
        Me.Hide()
        Dim signup As New login()
        login.Show()
    End Sub

    Private Sub fname_textbox_GotFocus(sender As Object, e As EventArgs) Handles fname_textbox.GotFocus
        If fname_textbox.Text = fname_textbox.HintText Then
            fname_textbox.Text = " "
        End If

    End Sub

    Private Sub fname_textbox_LostFocus(sender As Object, e As EventArgs) Handles fname_textbox.LostFocus
        If String.IsNullOrEmpty(fname_textbox.Text) Then
            fname_textbox.Text = fname_textbox.HintText
        End If
    End Sub
    Private Sub Uname_textbox_OnValueChanged(sender As Object, e As EventArgs) Handles uname_textbox.OnValueChanged
        uname_textbox.MaxLength = 10

    End Sub

    Private Sub uname_textbox_GotFocus(sender As Object, e As EventArgs) Handles uname_textbox.GotFocus
        If uname_textbox.Text = uname_textbox.HintText Then
            uname_textbox.Text = " "
        End If

    End Sub

    Private Sub uname_textbox_LostFocus(sender As Object, e As EventArgs) Handles uname_textbox.LostFocus
        If String.IsNullOrEmpty(uname_textbox.Text) Then
            uname_textbox.Text = uname_textbox.HintText
        End If
    End Sub

    Private Sub Password_textbox_GotFocus(sender As Object, e As EventArgs) Handles password_textbox.GotFocus
        If password_textbox.Text = password_textbox.HintText Then
            password_textbox.Text = " "
        End If

    End Sub

    Private Sub Password_textbox_LostFocus(sender As Object, e As EventArgs) Handles password_textbox.LostFocus
        If String.IsNullOrEmpty(password_textbox.Text) Then
            password_textbox.Text = password_textbox.HintText
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        Me.Close()
    End Sub

    Private Sub retype_textbox_GotFocus(sender As Object, e As EventArgs) Handles retype_textbox.GotFocus
        If retype_textbox.Text = retype_textbox.HintText Then
            retype_textbox.Text = " "
        End If

    End Sub

    Private Sub retype_textbox_LostFocus(sender As Object, e As EventArgs) Handles retype_textbox.LostFocus
        If String.IsNullOrEmpty(retype_textbox.Text) Then
            retype_textbox.Text = retype_textbox.HintText
        End If
    End Sub



    Private Sub Fname_textbox_OnValueChanged(sender As Object, e As EventArgs) Handles fname_textbox.OnValueChanged
        fname_textbox.MaxLength = 25

    End Sub

    Private Sub Password_textbox_OnValueChanged(sender As Object, e As EventArgs) Handles password_textbox.OnValueChanged
        password_textbox.MaxLength = 25

    End Sub

    Private Sub Retype_textbox_OnValueChanged(sender As Object, e As EventArgs) Handles retype_textbox.OnValueChanged
        retype_textbox.MaxLength = 25

    End Sub
End Class

