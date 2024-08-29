Imports DBLC_OBSI
Imports MySql.Data.MySqlClient
Public Class registration

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
    Private conn As Object




    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BunifuGroupBox3_Enter(sender As Object, e As EventArgs) Handles BunifuGroupBox3.Enter

    End Sub

    Private Sub BunifuMaterialTextbox13_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox13.OnValueChanged
        BunifuMaterialTextbox13.MaxLength = 25

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        Me.Close()
    End Sub
    Public Property SelectedRowIndex As Integer

    Public Sub PopulateData(selectedRow As DataGridViewRow)
        ' Populate data to textboxes and comboboxes
        ComboBox1.Text = selectedRow.Cells(1).Value.ToString()
        BunifuMaterialTextbox1.Text = selectedRow.Cells(2).Value.ToString()
        DateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells(3).Value)
        BunifuMaterialTextbox2.Text = selectedRow.Cells(4).Value.ToString()
        DateTimePicker2.Value = Convert.ToDateTime(selectedRow.Cells(5).Value)
        BunifuMaterialTextbox3.Text = selectedRow.Cells(6).Value.ToString()
        BunifuMaterialTextbox4.Text = selectedRow.Cells(7).Value.ToString()
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(selectedRow.Cells(8).Value.ToString().Split(","c))
        BunifuMaterialTextbox5.Text = selectedRow.Cells(9).Value.ToString()
        BunifuMaterialTextbox6.Text = selectedRow.Cells(10).Value.ToString()
        BunifuMaterialTextbox7.Text = selectedRow.Cells(11).Value.ToString()
        BunifuMaterialTextbox8.Text = selectedRow.Cells(12).Value.ToString()
        BunifuMaterialTextbox9.Text = selectedRow.Cells(13).Value.ToString()
        ComboBox2.Text = selectedRow.Cells(14).Value.ToString()
        DateTimePicker3.Value = Convert.ToDateTime(selectedRow.Cells(15).Value.ToString())
        ComboBox3.Text = selectedRow.Cells(16).Value.ToString()
        DateTimePicker4.Value = Convert.ToDateTime(selectedRow.Cells(17).Value.ToString())
        ComboBox4.Text = selectedRow.Cells(18).Value.ToString()
        DateTimePicker5.Value = Convert.ToDateTime(selectedRow.Cells(19).Value.ToString())
        ComboBox5.Text = selectedRow.Cells(20).Value.ToString()
        ComboBox6.Text = selectedRow.Cells(21).Value.ToString()
        BunifuMaterialTextbox10.Text = selectedRow.Cells(22).Value.ToString()
        BunifuMaterialTextbox12.Text = selectedRow.Cells(23).Value.ToString()
        BunifuMaterialTextbox11.Text = selectedRow.Cells(24).Value.ToString()
        ComboBox7.Text = selectedRow.Cells(25).Value.ToString()
        BunifuMaterialTextbox13.Text = selectedRow.Cells(26).Value.ToString()
        BunifuMaterialTextbox14.Text = selectedRow.Cells(27).Value.ToString()
        ' Populate data to other controls...

        ' Populate data to the ListBox
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(selectedRow.Cells(8).Value.ToString().Split(","c))

        ' Update the underlying data source for the DataGridView
        Dim additionalData As String = selectedRow.Cells(9).Value.ToString()
        Dim dataRows() As String = additionalData.Split(","c)

        ' Assuming the DataGridView is bound to a DataTable
        Dim dt As DataTable = CType(datagrid_view.cy_datagridview.DataSource, DataTable)

        For Each dataRow As String In dataRows
            ' Create a new row in the DataTable
            Dim newDataRow As DataRow = dt.NewRow()
            newDataRow("languages") = dataRow
            dt.Rows.Add(newDataRow)
        Next
    End Sub



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.SelectionMode = SelectionMode.MultiSimple
        ListBox1.Items.Add("English")
        ListBox1.Items.Add("French")
        ListBox1.Items.Add("Ewe")
        ListBox1.Items.Add("Dagaare")
        ListBox1.Items.Add("Twi")
        ListBox1.Items.Add("Dagbani")
        Dim selectedItems As New List(Of String)()

        For Each selectedItem As Object In ListBox1.SelectedItems
            selectedItems.Add(selectedItem.ToString())
        Next

        datagrid_view.cy_datagridview.DataSource = selectedItems

        ' Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Create the base SQL query
        'Dim query As String = "SELECT * FROM registration WHERE Languages IN ("

        ' Create placeholder and parameters for each selected language
        'Dim parameters As New List(Of MySqlParameter)()
        'For Each item As Object In ListBox1.SelectedItems
        'Dim paramName As String = "@lang" & parameters.Count.ToString()
        'query += paramName & ","
        'parameters.Add(New MySqlParameter(paramName, item.ToString()))
        'Next

        ' Remove the trailing comma and close the parentheses
        'query = query.TrimEnd(","c) & ")"

        ' Create a new DataTable to hold the results
        '        Dim dataTable As New DataTable()

        'Try
        ' Create a new connection
        'Dim connectionString As String = "datasource=localhost;port=3306;username=root;password=;database=dblc_obsi"
        'Using connection As New MySqlConnection(connectionString)
        ' Create a new command with the query and connection
        'Dim command As New MySqlCommand(query, connection)
        'Command.Parameters.AddRange(parameters.ToArray())

        ' Open the connection
        'connection.Open()

        ' Execute the query and fill the DataTable
        'Dim adapter As New MySqlDataAdapter(command)
        'adapter.Fill(dataTable)
        'End Using
        'Catch ex As Exception
        ' Handle any exceptions
        'MessageBox.Show("Error: " & ex.Message)
        'End Try

        ' Display the results in a DataGridView
        'DataGridView1.DataSource = dataTable
    End Sub



    ' Save the data to the database
    ' ...
    ' Display success message or perform other actions

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles registration_save.Click


        ' Check if any required fields are empty
        If String.IsNullOrWhiteSpace(ComboBox1.Text) OrElse
       String.IsNullOrWhiteSpace(BunifuMaterialTextbox1.Text) OrElse
       String.IsNullOrWhiteSpace(DateTimePicker1.Value) OrElse
        String.IsNullOrWhiteSpace(BunifuMaterialTextbox2.Text) OrElse
         String.IsNullOrWhiteSpace(DateTimePicker2.Value) OrElse
          String.IsNullOrWhiteSpace(BunifuMaterialTextbox3.Text) OrElse
           String.IsNullOrWhiteSpace(BunifuMaterialTextbox4.Text) OrElse
            String.IsNullOrWhiteSpace(ListBox1.Text) OrElse
             String.IsNullOrWhiteSpace(BunifuMaterialTextbox5.Text) OrElse
              String.IsNullOrWhiteSpace(BunifuMaterialTextbox6.Text) OrElse
               String.IsNullOrWhiteSpace(BunifuMaterialTextbox7.Text) OrElse
              String.IsNullOrWhiteSpace(BunifuMaterialTextbox8.Text) OrElse
              String.IsNullOrWhiteSpace(BunifuMaterialTextbox9.Text) OrElse
              String.IsNullOrWhiteSpace(ComboBox2.Text) OrElse
              String.IsNullOrWhiteSpace(DateTimePicker3.Value) OrElse
              String.IsNullOrWhiteSpace(DateTimePicker3.Value) OrElse
            String.IsNullOrWhiteSpace(ComboBox3.Text) OrElse
            String.IsNullOrWhiteSpace(DateTimePicker4.Value) OrElse
            String.IsNullOrWhiteSpace(ComboBox4.Text) OrElse
               String.IsNullOrWhiteSpace(DateTimePicker5.Value) OrElse
                  String.IsNullOrWhiteSpace(ComboBox5.Text) OrElse
                     String.IsNullOrWhiteSpace(ComboBox6.Text) OrElse
                        String.IsNullOrWhiteSpace(BunifuMaterialTextbox10.Text) OrElse
                           String.IsNullOrWhiteSpace(BunifuMaterialTextbox12.Text) OrElse
                             String.IsNullOrWhiteSpace(BunifuMaterialTextbox11.Text) OrElse
                               String.IsNullOrWhiteSpace(ComboBox7.Text) OrElse
                                 String.IsNullOrWhiteSpace(BunifuMaterialTextbox13.Text) OrElse
                                   String.IsNullOrWhiteSpace(BunifuMaterialTextbox14.Text) Then

            MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check for duplicate data
        Dim District As String = ComboBox1.Text
        Dim Location As String = BunifuMaterialTextbox1.Text
        Dim DOR As DateTime = DateTimePicker1.Value
        Dim Fullname As String = BunifuMaterialTextbox2.Text
        Dim DOB As DateTime = DateTimePicker2.Value
        Dim Hometown As String = BunifuMaterialTextbox3.Text
        Dim Phone As String = Integer.Parse(BunifuMaterialTextbox4.Text)
        Dim Languages As String = ListBox1.SelectionMode
        Dim Hse_address As String = BunifuMaterialTextbox5.Text
        Dim Father As String = BunifuMaterialTextbox6.Text
        Dim fphone As String = Integer.Parse(BunifuMaterialTextbox7.Text)
        Dim Mother As String = BunifuMaterialTextbox8.Text
        Dim mphone As String = Integer.Parse(BunifuMaterialTextbox9.Text)
        Dim Salvation As String = ComboBox2.Text
        Dim DateOf_salvation As DateTime = DateTimePicker3.Value
        Dim Sanctification As String = ComboBox3.Text
        Dim DateOf_sanctification As DateTime = DateTimePicker4.Value
        Dim HGB As String = ComboBox4.Text
        Dim DateOf_hgb As DateTime = DateTimePicker5.Value
        Dim Orestitution As String = ComboBox5.Text
        Dim Sproblems As String = ComboBox6.Text
        Dim School As String = BunifuMaterialTextbox10.Text
        Dim Class_Form As String = BunifuMaterialTextbox12.Text
        Dim Sch_address As String = BunifuMaterialTextbox11.Text
        Dim Boarder_Day As String = ComboBox7.Text
        Dim Hostel As String = BunifuMaterialTextbox13.Text
        Dim Room As String = BunifuMaterialTextbox14.Text
        ' Connect to the database
        Dim connectionString As String = "datasource=localhost;port=3306;username=root;password=;database=dblc_obsi"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Check if duplicate data exists
            Dim duplicateQuery As String = "SELECT COUNT(*) FROM registration WHERE District = @district AND Location = @loc AND DOR = @dor AND Fullname = @fname AND Hometown = @hometown AND Languages = @lang AND Hse_address = @add AND Father = @father AND fphone = @fphone AND Mother = @mother AND mphone = @mphone AND Salvation = @sal AND DateOf_salvation = @d_sal AND Sanctification = @san AND DateOf_sanctification = @d_san AND HGB = @hgb AND DateOf_hgb = @d_hgb AND Orestitution = @or AND Sproblems = @sp AND School = @sch AND Class_Form = @cf AND Sch_address = @sch_add AND Boarder_Day = @stats AND Hostel = @hos AND Room = @rm"
            Using command As New MySqlCommand(duplicateQuery, connection)
                ' Add parameters to the command
                command.Parameters.AddWithValue("@district", District)
                command.Parameters.AddWithValue("@loc", Location)
                command.Parameters.AddWithValue("@dor", DOR)
                command.Parameters.AddWithValue("@fname", Fullname)
                command.Parameters.AddWithValue("@dob", DOB)
                command.Parameters.AddWithValue("@hometown", Hometown)
                command.Parameters.AddWithValue("@phone", Phone)
                command.Parameters.AddWithValue("@lang", Languages)
                command.Parameters.AddWithValue("@add", Hse_address)
                command.Parameters.AddWithValue("@father", Father)
                command.Parameters.AddWithValue("@fphone", fphone)
                command.Parameters.AddWithValue("@mother", Mother)
                command.Parameters.AddWithValue("@mphone", mphone)
                command.Parameters.AddWithValue("@sal", Salvation)
                command.Parameters.AddWithValue("@d_sal", DateOf_salvation)
                command.Parameters.AddWithValue("@san", Sanctification)
                command.Parameters.AddWithValue("@d_san", DateOf_sanctification)
                command.Parameters.AddWithValue("@hgb", HGB)
                command.Parameters.AddWithValue("@d_hgb", DateOf_hgb)
                command.Parameters.AddWithValue("@or", Orestitution)
                command.Parameters.AddWithValue("@sp", Sproblems)
                command.Parameters.AddWithValue("@sch", School)
                command.Parameters.AddWithValue("@cf", Class_Form)
                command.Parameters.AddWithValue("@sch_add", Sch_address)
                command.Parameters.AddWithValue("@stats", Boarder_Day)
                command.Parameters.AddWithValue("@hos", Hostel)
                command.Parameters.AddWithValue("@rm", Room)
                ' Execute the command to check for duplicates
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' If duplicate data exists, show an error message and return
                If count > 0 Then
                    MessageBox.Show("Duplicate data found. Please enter unique data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            ' Save the data if no duplicates exist
            Dim saveQuery As String = "INSERT INTO registration (`District`, `Location`, `DOR`, `Fullname`, `DOB`, `Hometown`, `Phone`, `Languages`, `Hse_address`, `Father`, `fphone`, `Mother`, `mphone`, `Salvation`, `DateOf_salvation`, `Sanctification`, `DateOf_sanctification`, `HGB`, `DateOf_hgb`, `Orestitution`, `Sproblems`, `School`, `Class_Form`, `Sch_address`, `Boarder_Day`, `Hostel`, `Room`) VALUES (@district,@loc,@dor,@fname,@dob,@hometown,@phone,@lang,@add,@father,@fphone,@mother,@mphone,@sal,@d_sal,@san,@d_san,@hgb,@d_hgb,@or,@sp,@sch,@cf,@sch_add,@stats,@hos,@rm)"
            Using command As New MySqlCommand(saveQuery, connection)
                ' Add parameters to the command
                command.Parameters.AddWithValue("@district", District)
                command.Parameters.AddWithValue("@loc", Location)
                command.Parameters.AddWithValue("@dor", DOR)
                command.Parameters.AddWithValue("@fname", Fullname)
                command.Parameters.AddWithValue("@dob", DOB)
                command.Parameters.AddWithValue("@hometown", Hometown)
                command.Parameters.AddWithValue("@phone", Phone)
                command.Parameters.AddWithValue("@lang", Languages)
                command.Parameters.AddWithValue("@add", Hse_address)
                command.Parameters.AddWithValue("@father", Father)
                command.Parameters.AddWithValue("@fphone", fphone)
                command.Parameters.AddWithValue("@mother", Mother)
                command.Parameters.AddWithValue("@mphone", mphone)
                command.Parameters.AddWithValue("@sal", Salvation)
                command.Parameters.AddWithValue("@d_sal", DateOf_salvation)
                command.Parameters.AddWithValue("@san", Sanctification)
                command.Parameters.AddWithValue("@d_san", DateOf_sanctification)
                command.Parameters.AddWithValue("@hgb", HGB)
                command.Parameters.AddWithValue("@d_hgb", DateOf_hgb)
                command.Parameters.AddWithValue("@or", Orestitution)
                command.Parameters.AddWithValue("@sp", Sproblems)
                command.Parameters.AddWithValue("@sch", School)
                command.Parameters.AddWithValue("@cf", Class_Form)
                command.Parameters.AddWithValue("@sch_add", Sch_address)
                command.Parameters.AddWithValue("@stats", Boarder_Day)
                command.Parameters.AddWithValue("@hos", Hostel)
                command.Parameters.AddWithValue("@rm", Room)
                ' Execute the command to save the data
                command.ExecuteNonQuery()

                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
        Dim query As String = "SELECT * FROM registration"
        Using conn As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, conn)
                Dim ds As New DataSet()
                adapter.Fill(ds)
                datagrid_view.cy_datagridview.DataSource = ds.Tables(0)
            End Using
        End Using
        ComboBox1.Items.Clear()
        ComboBox1.Text = String.Empty
        BunifuMaterialTextbox1.Text = String.Empty
        BunifuMaterialTextbox2.Text = String.Empty
        BunifuMaterialTextbox3.Text = String.Empty
        BunifuMaterialTextbox4.Text = String.Empty
        BunifuMaterialTextbox5.Text = String.Empty
        BunifuMaterialTextbox6.Text = String.Empty
        BunifuMaterialTextbox7.Text = String.Empty
        BunifuMaterialTextbox8.Text = String.Empty
        BunifuMaterialTextbox9.Text = String.Empty
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()
        BunifuMaterialTextbox10.Text = String.Empty
        BunifuMaterialTextbox12.Text = String.Empty
        BunifuMaterialTextbox11.Text = String.Empty
        ComboBox7.Items.Clear()
        BunifuMaterialTextbox13.Text = String.Empty
        BunifuMaterialTextbox14.Text = String.Empty
    End Sub
    Private Sub UpdateDataInDatabase()
        If datagrid_view.cy_datagridview.SelectedCells.Count > 0 Then
            Dim rowIndex As Integer = datagrid_view.cy_datagridview.SelectedCells(0).RowIndex
            If rowIndex >= 0 AndAlso rowIndex < datagrid_view.cy_datagridview.Rows.Count Then
                Dim selectedRow As DataGridViewRow = datagrid_view.cy_datagridview.Rows(rowIndex)
                Dim District As String = ComboBox1.SelectedItem
                Dim Location As String = BunifuMaterialTextbox1.Text
                Dim DOR As Date = DateTimePicker1.Value
                Dim Fullname As String = BunifuMaterialTextbox2.Text
                Dim DOB As Date = DateTimePicker2.Value
                Dim Hometown As String = BunifuMaterialTextbox3.Text
                Dim Phone As String = BunifuMaterialTextbox4.Text
                Dim Languages As String = ListBox1.SelectionMode
                Dim Hse_add As String = BunifuMaterialTextbox5.Text
                Dim Father As String = BunifuMaterialTextbox6.Text
                Dim fphone As String = BunifuMaterialTextbox7.Text
                Dim Mother As String = BunifuMaterialTextbox8.Text
                Dim mphone As String = BunifuMaterialTextbox9.Text
                Dim Salvation As String = ComboBox2.SelectedItem
                Dim DateOf_salvation As Date = DateTimePicker3.Value
                Dim Sanctification As String = ComboBox3.SelectedItem
                Dim DateOf_sanctification As Date = DateTimePicker4.Value
                Dim HGB As String = ComboBox4.SelectedItem
                Dim DateOf_hgb As Date = DateTimePicker5.Value
                Dim Orestitution As String = ComboBox5.SelectedItem
                Dim Sproblems As String = ComboBox6.SelectedItem
                Dim School As String = BunifuMaterialTextbox10.Text
                Dim Class_Form As String = BunifuMaterialTextbox12.Text
                Dim Sch_address As String = BunifuMaterialTextbox11.Text
                Dim Boarder_Day As String = ComboBox7.SelectedItem
                Dim Hostel As String = BunifuMaterialTextbox13.Text
                Dim Room As String = BunifuMaterialTextbox14.Text

                Dim updateQuery As String = "UPDATE registration SET District = @District, Location = @Loc, DOR = @DOR, Fullname = @Fname, DOB = @DOB, Hometown = @HT, Phone = @Phone, Languages = @Langs, Hse_address = @HseAdd, Father = @Father, fphone = @fphone, Mother = @Mother, mphone = @mphone, Salvation = @Saved, DateOf_salvation = @d_sal, Sanctification = @Sanctified, DateOf_sanctification = @d_sanct, HGB = @HGB, DateOf_hgb = @d_hgb, Orestitution = @o_r, Sproblems = @sp, School = @Sch, Class_Form = @c_f, Sch_address = @Address, Boarder_Day = @Stats, Hostel = @Hostel, Room = @Room WHERE ID = @ID"
                Using conn As MySqlConnection = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=dblc_obsi")
                    Using command As MySqlCommand = New MySqlCommand(updateQuery, conn)

                        command.Parameters.AddWithValue("@District", ComboBox1.SelectedItem)
                        command.Parameters.AddWithValue("@Loc", BunifuMaterialTextbox1.Text)
                        command.Parameters.AddWithValue("@DOR", DateTimePicker1.Value)
                        command.Parameters.AddWithValue("@Fname", BunifuMaterialTextbox2.Text)
                        command.Parameters.AddWithValue("@DOB", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@HT", BunifuMaterialTextbox3.Text)
                        command.Parameters.AddWithValue("@Phone", BunifuMaterialTextbox4.Text)
                        command.Parameters.AddWithValue("@Langs", ListBox1.Text)
                        command.Parameters.AddWithValue("@HseAdd", BunifuMaterialTextbox5.Text)
                        command.Parameters.AddWithValue("@Father", BunifuMaterialTextbox6.Text)
                        command.Parameters.AddWithValue("@fphone", BunifuMaterialTextbox7.Text)
                        command.Parameters.AddWithValue("@Mother", BunifuMaterialTextbox8.Text)
                        command.Parameters.AddWithValue("@mphone", BunifuMaterialTextbox9.Text)
                        command.Parameters.AddWithValue("@Saved", ComboBox2.Text)
                        command.Parameters.AddWithValue("@d_sal", DateTimePicker3.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@Sanctified", ComboBox3.Text)
                        command.Parameters.AddWithValue("@d_sanct", DateTimePicker4.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@HGB", ComboBox4.SelectedItem)
                        command.Parameters.AddWithValue("@d_hgb", DateTimePicker5.Value)
                        command.Parameters.AddWithValue("@O_R", ComboBox5.SelectedItem)
                        command.Parameters.AddWithValue("@SP", ComboBox6.SelectedItem)
                        command.Parameters.AddWithValue("@Sch", BunifuMaterialTextbox10.Text)
                        command.Parameters.AddWithValue("@C_F", BunifuMaterialTextbox12.Text)
                        command.Parameters.AddWithValue("@Address", BunifuMaterialTextbox11.Text)
                        command.Parameters.AddWithValue("@Stats", ComboBox7.SelectedItem)
                        command.Parameters.AddWithValue("@Hostel", BunifuMaterialTextbox13.Text)
                        command.Parameters.AddWithValue("@Room", BunifuMaterialTextbox14.Text)
                        command.Parameters.AddWithValue("@ID", datagrid_view.cy_datagridview.Rows(rowIndex).Cells("ID").Value)
                        conn.Open()

                        command.ExecuteNonQuery()
                    End Using
                End Using

                Dim selectSQL As String = "SELECT * FROM registration"
                Using conn As MySqlConnection = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=dblc_obsi")
                    Using adapter As New MySqlDataAdapter(selectSQL, conn)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        datagrid_view.cy_datagridview.DataSource = table
                        MessageBox.Show("Record updated successfully.")
                    End Using
                End Using
            End If
        End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UpdateDataInDatabase()
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged
        BunifuMaterialTextbox1.MaxLength = 25


    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox3.OnValueChanged
        BunifuMaterialTextbox3.MaxLength = 25

    End Sub

    Private Sub BunifuMaterialTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox3.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox4.OnValueChanged

        BunifuMaterialTextbox4.MaxLength = 10

    End Sub


    Private Sub BunifuMaterialTextbox8_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox8.OnValueChanged

    End Sub

    Private Sub BunifuMaterialTextbox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox8.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox10.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox11.KeyPress

    End Sub

    Private Sub BunifuMaterialTextbox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox13.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox6.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox5.KeyPress

    End Sub

    Private Sub BunifuMaterialTextbox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox7.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox9_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox9.OnValueChanged

    End Sub

    Private Sub BunifuMaterialTextbox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox9.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged
        BunifuMaterialTextbox2.MaxLength = 25
    End Sub

    Private Sub BunifuMaterialTextbox5_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox5.OnValueChanged
        BunifuMaterialTextbox5.MaxLength = 25
    End Sub

    Private Sub BunifuMaterialTextbox10_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox10.OnValueChanged
        BunifuMaterialTextbox10.MaxLength = 50
    End Sub

    Private Sub BunifuMaterialTextbox12_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox12.OnValueChanged
        BunifuMaterialTextbox12.MaxLength = 3
    End Sub

    Private Sub BunifuMaterialTextbox11_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox11.OnValueChanged
        BunifuMaterialTextbox11.MaxLength = 25

    End Sub

    Private Sub BunifuMaterialTextbox14_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox14.OnValueChanged
        BunifuMaterialTextbox14.MaxLength = 4

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        datagrid_view.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub Label32_Click_1(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub BunifuMaterialTextbox7_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox7.OnValueChanged

    End Sub
End Class
