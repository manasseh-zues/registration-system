Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.Drawing
Imports System.IO
Imports System.Data
Imports System.Reflection
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports DBLC_OBSI



Public Class datagrid_view
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

    Public Property id As Object

    Private Sub Cy_datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub Registration_load_button_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Registration_load_button_Click_1(sender As Object, e As EventArgs) Handles registration_load_button.Click
        'populate data to datagridview
        Dim connectionString As String = "datasource=localhost;port=3306;username=root;password=;database=dblc_obsi"
        Dim query As String = "SELECT * FROM registration"
        Using conn As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, conn)
                Dim ds As New DataSet()
                adapter.Fill(ds)
                cy_datagridview.DataSource = ds.Tables(0)
            End Using
        End Using

    End Sub

    Private Sub Datagrid_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If cy_datagridview.Columns.Contains("ID") Then
        'cy_datagridview.Columns("ID").Visible = False
        ' End If

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

            Dim r As System.Drawing.Rectangle = Me.Bounds
            r.Inflate(2, 2)
            .Bounds = r
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
            r = New System.Drawing.Rectangle(3, 3, Me.Width - 4, Me.Height - 4)
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
        Dim r As New System.Drawing.Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub


    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        Me.Close()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs)
        '
    End Sub


    Private Sub search_button_Click(sender As Object, e As EventArgs) Handles search_button.Click

        Dim temp As Integer = 0
        For i As Integer = 0 To cy_datagridview.RowCount - 1
            For j As Integer = 0 To cy_datagridview.ColumnCount - 1
                If cy_datagridview.Rows(i).Cells(j).Value.ToString = search_textbox.Text Then
                    cy_datagridview.Rows(i).Selected = True
                    temp = 1
                    MsgBox("Item found")
                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("Item not found")
        End If
    End Sub

    Private Sub DisplaySelectedItems()
        For Each row As DataGridViewRow In cy_datagridview.Rows
            If row.Index < cy_datagridview.Rows.Count - 1 Then
                Dim selectedItems As New List(Of String)()
                For Each item As Object In registration.ListBox1.SelectedItems
                    selectedItems.Add(item.ToString())
                Next
                Dim cell As DataGridViewCell = row.Cells(8)
                cell.Value = String.Join(", ", selectedItems.ToArray())
            End If
        Next
    End Sub



    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        Dim result As DialogResult = MessageBox.Show("Do you want to delete this row?", "Delete", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' Get the ID value from the selected row
            Dim id As Integer = Convert.ToInt32(cy_datagridview.CurrentRow.Cells("Id").Value)

            ' Connect to the database
            Dim connectionString As String = "datasource=localhost;port=3306;username=root;password=;database=dblc_obsi"
            Using connection As New MySqlConnection(connectionString)
                ' Delete the row from the database
                Dim deleteQuery As String = "DELETE FROM registration WHERE Id = @Id"

                connection.Open()
                Using command As New MySqlCommand(deleteQuery, connection)
                    ' Add the ID parameter to the command
                    command.Parameters.AddWithValue("@Id", id)

                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Remove the row from the DataGridView
            cy_datagridview.Rows.Remove(cy_datagridview.CurrentRow)
        End If
    End Sub

    Private Sub Cy_datagridview_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles cy_datagridview.CellContentClick
        ''  cy_datagridview.Columns("ID").Visible = False


    End Sub

    Private Sub Cy_datagridview_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles cy_datagridview.CellEndEdit

    End Sub

    Private Sub Cy_datagridview_SelectionChanged(sender As Object, e As EventArgs) Handles cy_datagridview.SelectionChanged

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub


    Private registrationForms As Dictionary(Of Integer, registration) = New Dictionary(Of Integer, registration)()

    Private Sub Cy_datagridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles cy_datagridview.CellDoubleClick
        Dim rowIndex As Integer = e.RowIndex

        If rowIndex >= 0 AndAlso rowIndex < cy_datagridview.RowCount Then
            Dim row As DataGridViewRow = cy_datagridview.Rows(rowIndex)

            If registrationForms.ContainsKey(rowIndex) AndAlso Not registrationForms(rowIndex).IsDisposed Then
                Dim registrationForm As registration = registrationForms(rowIndex)
                registrationForm.PopulateData(row)
                registrationForm.Focus()
            Else
                Dim registrationForm As registration = New registration()
                registrationForm.SelectedRowIndex = rowIndex
                registrationForm.PopulateData(row)
                registrationForms(rowIndex) = registrationForm
                login.mainAppForm.show(Me)
            End If
        End If
    End Sub
End Class

