Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class login

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



    'rounded form'
    Private borderForm As New Form
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

    'login button'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_button.Click
        ' before the user can login we need to check if the textboxes are empty
        ' if they contains the default values( username & password )
        ' check if this user exist in the database

        Dim conn As New mysql_connect()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `users` WHERE `username` = @usn AND `password` = @pass", conn.getConnection())

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username_textbox.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password_textbox.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If username_textbox.Text.Trim() = "" Or username_textbox.Text.Trim().ToLower() = "username" Then

            MessageBox.Show("Enter Your Username To Login", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf password_textbox.Text.Trim() = "" Or username_textbox.Text.Trim().ToLower() = "password" Then

            MessageBox.Show("Enter Your Password To Login", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            'Me.Hide()
            Dim mainAppForm As New registration()
            mainAppForm.show(Me) '

        Else

            MessageBox.Show("Enter username and password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles signup_label.Click

        Me.Hide()
        Dim login As New signup()
        signup.Show()
    End Sub

    Private Sub Username_textbox_OnValueChanged(sender As Object, e As EventArgs) Handles username_textbox.OnValueChanged
        username_textbox.MaxLength = 10

    End Sub

    Private Sub Exit_button_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Minimize_button_Click(sender As Object, e As EventArgs)
        Dim unused = True
    End Sub

    Private Sub Login_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter

    End Sub

    Private Sub Username_textbox_MouseEnter(sender As Object, e As EventArgs) Handles username_textbox.MouseEnter

    End Sub

    Private Sub Username_textbox_MouseLeave(sender As Object, e As EventArgs) Handles username_textbox.MouseLeave

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





    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Password_textbox_OnValueChanged(sender As Object, e As EventArgs) Handles password_textbox.OnValueChanged
        password_textbox.MaxLength = 25

    End Sub

    Private Sub Username_textbox_GotFocus(sender As Object, e As EventArgs) Handles username_textbox.GotFocus
        If username_textbox.Text = username_textbox.HintText Then
            username_textbox.Text = " "
        End If

    End Sub

    Private Sub Username_textbox_LostFocus(sender As Object, e As EventArgs) Handles username_textbox.LostFocus
        If String.IsNullOrEmpty(username_textbox.Text) Then
            username_textbox.Text = username_textbox.HintText
        End If

    End Sub


End Class
