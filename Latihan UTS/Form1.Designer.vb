<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GroupBox1 = New GroupBox()
        selectPosition = New ComboBox()
        txtBirthDate = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtBirthPlace = New TextBox()
        Label2 = New Label()
        txtName = New TextBox()
        Label1 = New Label()
        txtEmpNumber = New TextBox()
        GroupBox2 = New GroupBox()
        Label10 = New Label()
        txtHonorCommision = New TextBox()
        Label9 = New Label()
        txtAmountCommision = New TextBox()
        Label8 = New Label()
        txtDate = New DateTimePicker()
        txtNumClosing = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        txtHonor = New TextBox()
        ListView1 = New ListView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(selectPosition)
        GroupBox1.Controls.Add(txtBirthDate)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtBirthPlace)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtEmpNumber)
        GroupBox1.ForeColor = Color.Blue
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(386, 267)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Marketing Data"
        ' 
        ' selectPosition
        ' 
        selectPosition.AccessibleRole = AccessibleRole.None
        selectPosition.DropDownStyle = ComboBoxStyle.DropDownList
        selectPosition.FormattingEnabled = True
        selectPosition.Items.AddRange(New Object() {"Staff", "Supervisor", "Manager"})
        selectPosition.Location = New Point(129, 186)
        selectPosition.Name = "selectPosition"
        selectPosition.Size = New Size(241, 28)
        selectPosition.TabIndex = 12
        ' 
        ' txtBirthDate
        ' 
        txtBirthDate.Format = DateTimePickerFormat.Short
        txtBirthDate.Location = New Point(132, 149)
        txtBirthDate.Name = "txtBirthDate"
        txtBirthDate.Size = New Size(175, 27)
        txtBirthDate.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 20)
        Label5.TabIndex = 9
        Label5.Text = "Position"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 20)
        Label4.TabIndex = 7
        Label4.Text = "Birth Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(17, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 5
        Label3.Text = "Birth Place"
        ' 
        ' txtBirthPlace
        ' 
        txtBirthPlace.Location = New Point(131, 112)
        txtBirthPlace.Name = "txtBirthPlace"
        txtBirthPlace.Size = New Size(238, 27)
        txtBirthPlace.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 3
        Label2.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(131, 73)
        txtName.Name = "txtName"
        txtName.Size = New Size(238, 27)
        txtName.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 20)
        Label1.TabIndex = 1
        Label1.Text = "Emp Number"
        ' 
        ' txtEmpNumber
        ' 
        txtEmpNumber.Location = New Point(129, 36)
        txtEmpNumber.Name = "txtEmpNumber"
        txtEmpNumber.Size = New Size(175, 27)
        txtEmpNumber.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(txtHonorCommision)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(txtAmountCommision)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtDate)
        GroupBox2.Controls.Add(txtNumClosing)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.ForeColor = Color.Coral
        GroupBox2.Location = New Point(404, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(384, 196)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Closing Data"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 157)
        Label10.Name = "Label10"
        Label10.Size = New Size(176, 20)
        Label10.TabIndex = 16
        Label10.Text = "Honor + Commision (Rp)"
        ' 
        ' txtHonorCommision
        ' 
        txtHonorCommision.Enabled = False
        txtHonorCommision.HideSelection = False
        txtHonorCommision.Location = New Point(191, 154)
        txtHonorCommision.Name = "txtHonorCommision"
        txtHonorCommision.Size = New Size(176, 27)
        txtHonorCommision.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 118)
        Label9.Name = "Label9"
        Label9.Size = New Size(173, 20)
        Label9.TabIndex = 14
        Label9.Text = "Amount Commision (Rp)"
        ' 
        ' txtAmountCommision
        ' 
        txtAmountCommision.Enabled = False
        txtAmountCommision.Location = New Point(191, 115)
        txtAmountCommision.Name = "txtAmountCommision"
        txtAmountCommision.Size = New Size(176, 27)
        txtAmountCommision.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 76)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 20)
        Label8.TabIndex = 12
        Label8.Text = "Num Closing"
        ' 
        ' txtDate
        ' 
        txtDate.Format = DateTimePickerFormat.Short
        txtDate.Location = New Point(191, 32)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(175, 27)
        txtDate.TabIndex = 12
        ' 
        ' txtNumClosing
        ' 
        txtNumClosing.Location = New Point(191, 73)
        txtNumClosing.Name = "txtNumClosing"
        txtNumClosing.Size = New Size(176, 27)
        txtNumClosing.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(11, 37)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 20)
        Label7.TabIndex = 11
        Label7.Text = "Date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Blue
        Label6.Location = New Point(30, 240)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 20)
        Label6.TabIndex = 11
        Label6.Text = "Honor (Rp)"
        ' 
        ' txtHonor
        ' 
        txtHonor.Enabled = False
        txtHonor.Location = New Point(144, 237)
        txtHonor.Name = "txtHonor"
        txtHonor.Size = New Size(238, 27)
        txtHonor.TabIndex = 10
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(13, 288)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1272, 150)
        ListView1.TabIndex = 13
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(404, 214)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 14
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(504, 214)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 15
        Button2.Text = "Clear Input"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(604, 214)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 16
        Button3.Text = "Close Form"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1206, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListView1)
        Controls.Add(Label6)
        Controls.Add(GroupBox2)
        Controls.Add(txtHonor)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBirthPlace As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmpNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHonor As TextBox
    Friend WithEvents txtBirthDate As DateTimePicker

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles txtBirthDate.ValueChanged

    End Sub

    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label7 As Label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("EMP NUMBER", 100)
        ListView1.Columns.Add("EMP NAME", 100)
        ListView1.Columns.Add("POSITION", 100)
        ListView1.Columns.Add("HONOR", 150)
        ListView1.Columns.Add("DATE CLOSING", 200)
        ListView1.Columns.Add("NUM CLOSING", 200)
        ListView1.Columns.Add("COMISSION", 200)
        ListView1.Columns.Add("HONOR + COMMISION", 200)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Dim honor As Integer
    Dim commision As Decimal
    Dim dataList As New List(Of String())()

    Friend WithEvents Label10 As Label
    Friend WithEvents txtHonorCommision As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAmountCommision As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNumClosing As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents selectPosition As ComboBox

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectPosition.SelectedIndexChanged
        Dim position As String
        position = selectPosition.Text

        If position = "Staff" Then
            honor = 1500000
        ElseIf position = "Supervisor" Then
            honor = 5000000
        ElseIf position = "Manager" Then
            honor = 8000000
        End If
        Calculate()
        txtHonor.Text = honor.ToString("N0", Globalization.CultureInfo.GetCultureInfo("id-ID"))
    End Sub

    Private Sub txtNumClosing_TextChanged(sender As Object, e As EventArgs) Handles txtNumClosing.TextChanged
        Call Calculate()
    End Sub


    Sub Calculate()
        Dim numClosing As Integer = If(String.IsNullOrWhiteSpace(txtNumClosing.Text), 0, Convert.ToInt32(txtNumClosing.Text))
        Dim rate As Decimal = (5 / 100)
        Dim foundData As String() = dataList.FirstOrDefault(Function(row) row(0) = txtEmpNumber.Text())
        If foundData IsNot Nothing Then
            rate = (8 / 100)
        End If

        commision = numClosing * rate * honor

        Debug.WriteLine(commision)
        txtAmountCommision.Text = commision.ToString("N0", Globalization.CultureInfo.GetCultureInfo("id-ID"))
        txtHonorCommision.Text = (commision + honor).ToString("N0", Globalization.CultureInfo.GetCultureInfo("id-ID"))
    End Sub

    Private Function ValidateInput() As Boolean
        Dim empNumberPattern As String = "^MRK\d{3}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtEmpNumber.Text, empNumberPattern) Then
            MessageBox.Show("Employee Number harus berformat 'MRK' diikuti 3 digit angka. Contoh: MRK123", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Nama tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtBirthPlace.Text) Then
            MessageBox.Show("Tempat Lahir tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim honor As Decimal
        If Not Decimal.TryParse(txtHonor.Text, honor) OrElse honor <= 0 Then
            MessageBox.Show("Honor harus berupa angka positif.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim numClosing As Integer
        If Not Integer.TryParse(txtNumClosing.Text, numClosing) OrElse numClosing < 0 Then
            MessageBox.Show("Jumlah Closing harus berupa angka bulat positif.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim foundData As String() = dataList.FirstOrDefault(Function(row) row(0) = txtEmpNumber.Text() And row(4) = txtDate.Text())
        If foundData IsNot Nothing Then
            MessageBox.Show("Employee with same date was exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function


    Sub clearInput()
        txtEmpNumber.Text = ""
        txtName.Text = ""
        txtBirthDate.Text = ""
        txtBirthPlace.Text = ""
        txtNumClosing.Text = ""
        txtDate.Text = ""
        txtHonor.Text = ""
        honor = 0
        txtHonorCommision.Text = ""
        selectPosition.SelectedIndex = -1
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateInput() Then

            Dim rowData(7) As String
            rowData(0) = txtEmpNumber.Text
            rowData(1) = txtName.Text
            rowData(2) = selectPosition.Text
            rowData(3) = txtHonor.Text
            rowData(4) = txtDate.Text
            rowData(5) = txtNumClosing.Text
            rowData(6) = commision.ToString("N0", Globalization.CultureInfo.GetCultureInfo("id-ID"))
            rowData(7) = txtHonorCommision.Text

            ' Tambah ke ListView
            Dim listitem As ListViewItem = ListView1.Items.Add(rowData(0))
            For i As Integer = 1 To 7
                listitem.SubItems.Add(rowData(i))
            Next

            ' Simpan ke List (opsional)
            dataList.Add(rowData)


            'listitem = New ListViewItem
            'listitem = ListView1.Items.Add(txtEmpNumber.Text)
            'listitem.SubItems.Add(txtName.Text)
            'listitem.SubItems.Add(selectPosition.Text)
            'listitem.SubItems.Add(txtHonor.Text)
            'listitem.SubItems.Add(txtDate.Text)
            'listitem.SubItems.Add(txtNumClosing.Text)
            'listitem.SubItems.Add(commision.ToString("N0", Globalization.CultureInfo.GetCultureInfo("id-ID")))
            'listitem.SubItems.Add(txtHonorCommision.Text)

            clearInput()

            MessageBox.Show("Berhasil")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clearInput()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

End Class
