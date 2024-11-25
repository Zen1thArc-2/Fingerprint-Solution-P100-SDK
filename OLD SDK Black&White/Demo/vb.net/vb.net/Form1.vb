Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str As String
        str = ""

        If (Button1.Text = "Disconnect") Then
            AxCZKEM1.Disconnect()
            Button1.Text = "Connect"
            connect1 = False
            Return
        End If

        If (RadioButton1.Checked = True) Then
            connect1 = AxCZKEM1.Connect_Net(TextBox1.Text, Val(TextBox2.Text))
        Else
            connect1 = AxCZKEM1.Connect_Com(Val(ComboBox1.Text), 1, Val(ComboBox2.Text))
        End If



        If (connect1) Then
            MsgBox("Connect Successed", MsgBoxStyle.Exclamation, "information")
            Button1.Text = "Disconnect"
            AxCZKEM1.GetSDKVersion(str)
            ToolStripStatusLabel1.Text = "Connect Successed"
            ToolStripStatusLabel2.Text = "SDKVersion : " + str
        Else
            'MsgBox("Connect Successed", MsgBoxStyle.Exclamation)
            MsgBox("Connect Failed", MsgBoxStyle.Critical, "information")
            ToolStripStatusLabel1.Text = "Connect Failed"
            'ToolStripStatusLabel1.Text = "SDKVersion : " + str
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim errorcode As Integer = 0
        If (AxCZKEM1.ClearGLog(1)) Then
            MsgBox("Data has been cleared from the terminal", MsgBoxStyle.Exclamation, "information")

        Else
            MsgBox("Unable clear data from terminal", MsgBoxStyle.Critical, "information")
        End If
        ListView1.Items.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ListView1.Items.Clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'System::Text::StringBuilder  _data;

        ' int _errorCode = 0;
        '	int _machineNumber = 0;
        'int _enrollNumber = 0;
        'int _enrollMachineNumber = 0;
        '	int _verifyMode = 0;
        'int _inOutMode = 0;
        '	int _year = 0;
        'int _month = 0;
        'int _day = 0;
        'int _hour = 0;
        'int _minute = 0;
        Dim _data As New System.Text.StringBuilder
        Dim _errorCode As Integer = 0
        Dim _machineNumber As Integer = 0
        Dim _enrollNumber As Integer = 0

        Dim _enrollMachineNumber As Integer = 0
        Dim _verifyMode As Integer = 0
        Dim _inOutMode As Integer = 0

        Dim _year As Integer = 0
        Dim _month As Integer = 0
        Dim _day As Integer = 0
        Dim _hour As Integer = 0
        Dim _minute As Integer = 0


        If (connect1 = False) Then

            Return

        End If

        AxCZKEM1.ReadMark = True

        If (AxCZKEM1.ReadGeneralLogData(1)) Then

            ListView1.Items.Clear()
            ListView1.BeginUpdate()
            AxCZKEM1.GetLastError(_errorCode)
            While (_errorCode <> 0)

                If (AxCZKEM1.GetGeneralLogData(1, _machineNumber, _enrollNumber, _enrollMachineNumber, _verifyMode, _inOutMode, _year, _month, _day, _hour, _minute)) Then


                    _data.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7}",_enrollNumber,_verifyMode,_inOutMode,_year,_month,_day,_hour,_minute)

                    'listView1->Items->Add(System::Convert::ToString (_enrollNumber),
                    'System::Convert::ToString (_verifyMode))
                    ListView1.Items.Add(_data.ToString())
                    _data.Remove(0, _data.Length)


                End If


                AxCZKEM1.GetLastError(_errorCode)

            End While

            ListView1.EndUpdate()

        Else
            AxCZKEM1.GetLastError(_errorCode)
            If (_errorCode <> 0) Then

                MsgBox("Unable to collect data from terminal", MsgBoxStyle.Critical, "information")
            Else
                MsgBox("Terminal is empty", MsgBoxStyle.Exclamation, "information")

            End If


        End If



    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

        Dim _transaction As String = ""
        Dim _data() As String
        Dim _date As System.DateTime
        If (ListView1.SelectedItems.Count >= 1) Then
            _transaction = ListView1.SelectedItems(0).Text
            _data = _transaction.Split(",")
            TextBox3.Text = _data(0).ToString
            TextBox4.Text = _data(1).ToString

            If (_data.Length = 8) Then

                _date = New DateTime(System.Convert.ToInt32(_data(3)), System.Convert.ToInt32(_data(4)), System.Convert.ToInt32(_data(5)), System.Convert.ToInt32(_data(6)), System.Convert.ToInt32(_data(7)), 0)

            Else

                _date = New DateTime(System.Convert.ToInt32(_data(3)), System.Convert.ToInt32(_data(4)), System.Convert.ToInt32(_data(5)), System.Convert.ToInt32(_data(6)), System.Convert.ToInt32(_data(7)), System.Convert.ToInt32(_data(8)))



            End If
            TextBox5.Text = System.Convert.ToString(_date.ToString())
        End If

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged


        Dim _errorCode As Integer = 0
        Dim _enrollNumber As Integer = 0
        Dim _enrollMachineNumber As Integer = 0
        Dim _backupNumber As Integer = 0
        Dim _machinePrivilege As Integer = 0
        Dim _enable As Integer = 0
        Dim _value As Integer = 0
        Dim _year As Integer = 0
        Dim _month As Integer = 0
        Dim _day As Integer = 0
        Dim _hour As Integer = 0
        Dim _minute As Integer = 0
        Dim _dayOfWeek As Integer = 0
        Dim _firmwareVersion As String = ""
        Dim _serialNumber As String = ""
        Dim _ipAddress As String = ""
        Dim _password As String = ""
        Dim _name As String = ""
        Dim _privileges As String = ""
        Dim _enabled As Boolean = False

        '  ListViewItem(_item = New ListViewItem("item1", 0))
        Dim _item As New ListViewItem("item1", 0)

        If (Button1.Text = "Connect") Then

            Return

        End If


        Select Case TabControl1.SelectedIndex

            Case 1
                ListView2.Items.Clear()

                If (AxCZKEM1.ReadAllUserID(1)) Then
                    ListView2.BeginUpdate()
                    AxCZKEM1.GetLastError(_errorCode)


                    While (_errorCode <> 0)

                        If (AxCZKEM1.GetAllUserID(1, _enrollNumber, _enrollMachineNumber, _backupNumber, _machinePrivilege, _enable)) Then

                            AxCZKEM1.GetUserInfo(1, _enrollNumber, _name, _password, _machinePrivilege, _enabled)

                            _item = ListView2.Items.Add(_enrollNumber.ToString())
                            _item.SubItems.Add(_name.ToString())
                            _item.SubItems.Add(_password.ToString())


                            Select Case _machinePrivilege

                                Case 0
                                    _privileges = "General User"

                                Case 1
                                    _privileges = "Admin Level 1"


                                Case 2
                                    _privileges = "Admin Level 2"

                                Case 3
                                    _privileges = "Admin Level 3"


                                Case Else
                                    _privileges = "Unknown"


                            End Select
                            _item.SubItems.Add(_privileges)

                            If (_enable = 1) Then
                                _item.SubItems.Add("Y")
                            Else
                                _item.SubItems.Add("N")

                            End If


                        End If
                        AxCZKEM1.GetLastError(_errorCode)

                    End While
                    ListView2.EndUpdate()

                Else

                    AxCZKEM1.GetLastError(_errorCode)

                    If (_errorCode <> 0) Then
                        MsgBox("Unable to collect data from terminal,  Error Code: ")
                    Else
                        MsgBox("Terminal is empty")
                    End If




                End If



            Case 2
              
                'AxCZKEM1.RegEvent



                If (AxCZKEM1.GetDeviceStatus(1, 1, _value)) Then
                    TextBox14.Text = _value.ToString()
                Else
                    TextBox14.Text = "N/A"
                End If
                '
                If (AxCZKEM1.GetDeviceStatus(1, 2, _value)) Then
                    TextBox15.Text = _value.ToString()
                Else
                    TextBox15.Text = "N/A"
                End If
                If (AxCZKEM1.GetDeviceStatus(1, 3, _value)) Then
                    TextBox16.Text = _value.ToString()
                Else
                    TextBox16.Text = "N/A"
                End If

                If (AxCZKEM1.GetDeviceStatus(1, 4, _value)) Then
                    TextBox17.Text = _value.ToString()
                Else
                    TextBox17.Text = "N/A"
                End If

                If (AxCZKEM1.GetDeviceStatus(1, 5, _value)) Then
                    TextBox18.Text = _value.ToString()
                Else
                    TextBox18.Text = "N/A"
                End If

                If (AxCZKEM1.GetDeviceStatus(1, 6, _value)) Then
                    TextBox19.Text = _value.ToString()
                    setingchange = False
                Else
                    TextBox19.Text = "N/A"
                End If


                If (AxCZKEM1.GetDeviceIP(1, _ipAddress)) Then
                    TextBox11.Text = _ipAddress
                    ipaddress = False
                Else
                    TextBox11.Text = "N/A"
                End If

                If (AxCZKEM1.GetDeviceTime(1, _year, _month, _day, _hour, _minute, _dayOfWeek)) Then
                    TextBox10.Text = New DateTime(_year, _month, _day, _hour, _minute, 0, 0).ToString()
                    timechange = False
                Else
                    TextBox10.Text = "N/A"
                End If



                If (AxCZKEM1.GetSerialNumber(1, _serialNumber)) Then
                    TextBox12.Text = _serialNumber
                Else
                    TextBox12.Text = "N/A"
                End If

                If (AxCZKEM1.GetFirmwareVersion(1, _firmwareVersion)) Then

                    TextBox13.Text = _firmwareVersion

                Else

                    TextBox13.Text = "N/A"
                End If



                '  If (connect1) Then
                'AxCZKEM1.GetDeviceInfo(1, 1, _value)
                ' TextBox9.Text = _value.ToString()
                '  End If



        End Select




    End Sub

    Private Sub AxCZKEM1_OnAttTransaction_2(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles AxCZKEM1.OnAttTransaction
        ' MsgBox("事件的发生")


        If (sssj) Then
            Dim _data As New System.Text.StringBuilder
            _data.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7},{8}", e.enrollNumber, e.verifyMethod, e.isInValid, e.year, e.month, e.day, e.hour, e.minute, e.second)
            ListView1.Items.Add(_data.ToString())
            ListView1.Update()
        Else
            Return
        End If


    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click


        If (connect1) Then
            sssj = True
            ListView1.Items.Clear()
            MsgBox("Collect Live Data Start", MsgBoxStyle.Exclamation, "information")


        Else
            MsgBox("Connect Failed", MsgBoxStyle.Critical, "information")
            sssj = False
        End If


    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim _value As Integer = 0


        If (connect1) Then
            AxCZKEM1.GetDeviceInfo(1, ComboBox4.SelectedIndex + 1, _value)
            TextBox9.Text = _value.ToString()
        End If

        ' _settingChanged = False
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click


        If (connect1) Then
            AxCZKEM1.Beep(150)
        Else
            MsgBox("Connect Failed", MsgBoxStyle.Critical, "information")
        End If


    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click

        If (connect1) Then
            AxCZKEM1.PowerOffDevice(1)
        Else
            MsgBox("Connect Failed", MsgBoxStyle.Critical, "information")
        End If

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click


        If (connect1) Then



            If (Button19.Text = "ClockOff") Then


                AxCZKEM1.EnableClock(False)
                Button19.Text = "ClockOn"

            Else

                AxCZKEM1.EnableClock(True)
                Button19.Text = "ClockOff"
            End If



        Else


            MsgBox("Connect Failed", MsgBoxStyle.Critical, "information")
            Return

        End If







    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click


        If (connect1) Then
            AxCZKEM1.RestartDevice(1)
        Else
            MsgBox("Connect Failed", MsgBoxStyle.Critical, "information")
        End If


    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click

        If (connect1) Then
            AxCZKEM1.PlayVoiceByIndex(0)
        Else
            MsgBox("Connect Failed", MsgBoxStyle.Critical, "information")
        End If

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click

        If (connect1) Then
            AxCZKEM1.EnableClock(False)
            AxCZKEM1.ClearLCD()
        Else
            MsgBox("Connect Failed", MsgBoxStyle.Critical, "information")
        End If

    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click

        If (connect1) Then

            AxCZKEM1.WriteLCD(1, 1, TextBox20.Text)

        Else
            MsgBox("Connect Failed", MsgBoxStyle.Critical, "information")

        End If


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        Dim _date As System.DateTime

        Dim _errorCode As Integer = 0



        If (connect1) Then
            If (ipaddress) Then
                AxCZKEM1.SetDeviceIP(1, TextBox11.Text)
            End If

            If (timechange) Then
                Try
                    If (TextBox10.Text <> "") Then
                        _date = Convert.ToDateTime(TextBox10.Text)
                    End If
                Catch ex As Exception

                    MsgBox("Invalid date/time format" + ex.Message)

                End Try
                AxCZKEM1.SetDeviceTime2(1, _date.Year, _date.Month, _date.Day, _date.Hour, _date.Minute, _date.Second)
            End If

            If (setingchange) Then
                AxCZKEM1.SetDeviceInfo(1, ComboBox4.SelectedIndex + 1, Convert.ToInt32(TextBox9.Text))
            End If


            AxCZKEM1.GetLastError(_errorCode)


            If (_errorCode <> 1) Then
                MsgBox("Unable to update terminal settings,  Error Code: " + _errorCode.ToString())
            Else
                MsgBox("Terminal settings updated")
            End If
        Else
            MsgBox("Connect Failed", MsgBoxStyle.Critical, "information")
        End If
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        ipaddress = True
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        timechange = True
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        setingchange = True
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ' OpenFileDialog1
        '   Dim _errorCode As Integer = 0

        OpenFileDialog1.Filter = "Terminal Firmware Files (.cfg)|*.cfg"
        OpenFileDialog1.Title = "Select a Firmware Files"
        OpenFileDialog1.FileName = ""

        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel) Then

            Return

        End If


        If (AxCZKEM1.UpdateFirmware(OpenFileDialog1.FileName)) Then

            MsgBox("Terminal firmware loaded, Please reset terminal")

        Else

            MsgBox("Unable to load terminal firmware")


        End If


    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        If (AxCZKEM1.BackupData("terminal.bak")) Then
            MsgBox("Terminal information saved to backup.dat")
        Else
            MsgBox("Unable to backup terminal data")
        End If

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        OpenFileDialog1.Filter = "Terminal Firmware Files (.bak)|*.bak"
        OpenFileDialog1.Title = "Select a Firmware Files"
        OpenFileDialog1.FileName = ""

        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel) Then
            Return
        End If
        If (AxCZKEM1.RestoreData(OpenFileDialog1.FileName)) Then

            MsgBox("Terminal data has been restored")
        Else
            MsgBox("Unable to restore terminal data")

        End If


    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click

        If (AxCZKEM1.ClearAdministrators(1)) Then

            MsgBox("Administrators cleared from terminal")
        Else
            MsgBox("Unable to clear administrators")

        End If

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        If (AxCZKEM1.ClearKeeperData(1)) Then

            MsgBox("All information cleared from terminal")
        Else

            MsgBox("Unable to clear terminal information")

        End If

    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

        If (ListView2.SelectedItems.Count >= 1) Then


            TextBox6.Text = ListView2.SelectedItems(0).Text
            TextBox7.Text = ListView2.SelectedItems(0).SubItems(1).Text
            TextBox8.Text = ListView2.SelectedItems(0).SubItems(2).Text


            If (ListView2.SelectedItems(0).SubItems(3).Text = "General User") Then
                ComboBox3.SelectedIndex = 0

            ElseIf (ListView2.SelectedItems(0).SubItems(3).Text = "Admin Level 1") Then
                ComboBox3.SelectedIndex = 1

            ElseIf (ListView2.SelectedItems(0).SubItems(3).Text = "Admin Level 2") Then
                ComboBox3.SelectedIndex = 2
            Else
                ComboBox3.SelectedIndex = 3

            End If


        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'int[] _enrollData = new int[73];		
        'int _password = 0;
        'int _machinePrivilege = 0;
        Dim _enrollData(73) As Integer
        Dim _password As Integer = 0
        Dim _machinePrivilege As Integer = 0

        Dim _stream As System.IO.FileStream
        Dim _writer As System.IO.BinaryWriter
        Dim _fingerIndex As Integer
        Dim _index As Integer

        If (TextBox6.Text = "") Then
            MsgBox("Please select a user")
            Return
        End If

        AxCZKEM1.EnableDevice(1, False)
        For _fingerIndex = 0 To 9
            If (AxCZKEM1.GetEnrollData(1, Val(TextBox6.Text), 1, _fingerIndex, _machinePrivilege, _enrollData(0), _password)) Then

                _stream = New IO.FileStream("Template_" + _fingerIndex.ToString() + ".dat", IO.FileMode.Create)

                _writer = New IO.BinaryWriter(_stream)

                For _index = 0 To _index < _enrollData.Length

                    _writer.Write(_enrollData(_index))

                Next

                '	for int _index = 0; _index < _enrollData.Length; _index++ )
                '_writer.Write(_enrollData[_index]);

                _stream.Close()
                _writer.Close()


            End If

            'CtrlBioComm.GetEnrollData
        Next

        MsgBox("Templates have been uploaded")


        AxCZKEM1.EnableDevice(1, True)


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        If (TextBox6.Text = "") Then
            MsgBox("Please select a user")
            Return
        End If

        AxCZKEM1.EnableDevice(1, False)

        If (AxCZKEM1.SetUserInfo(1, Val(TextBox6.Text), TextBox7.Text, TextBox8.Text, ComboBox3.SelectedIndex, True)) Then

            MsgBox("User information updated")

        Else

            MsgBox("Unable to update user information")


        End If

        AxCZKEM1.EnableDevice(1, True)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        If (TextBox6.Text = "") Then

            MsgBox("Please select a user")
            Return

        End If

        AxCZKEM1.EnableDevice(1, False)

        If (AxCZKEM1.DeleteEnrollData(1, Val(TextBox6.Text), 1, 12)) Then
            MsgBox("User removed from terminal")
        Else
            MsgBox("Unable to delete user from terminal")

        End If

        AxCZKEM1.EnableDevice(1, True)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim _fingerIndex As Integer

        If (TextBox6.Text = "") Then
            MsgBox("Please select a user")
            Return

        End If
        AxCZKEM1.EnableDevice(1, False)
        'if(axczkem1.del
        For _fingerIndex = 0 To 9

            AxCZKEM1.DelUserTmp(1, Val(TextBox6.Text), _fingerIndex)

        Next

        MsgBox("Templates deleted from terminal")

        AxCZKEM1.EnableDevice(1, True)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'byte[] _enrollData = new byte[292];
        '	int _errorCode = 0;
        'FileStream _stream = null;
        'BinaryReader _reader = null;
        Dim _enrollData(292) As Byte
        Dim _stream As System.IO.FileStream
        Dim _reader As System.IO.BinaryReader

        Dim _index As Integer

        If (TextBox6.Text = "") Then
            MsgBox("Please select a user")
            Return

        End If

        ' Dim _stream As System.IO.FileStream
        '  Dim _writer As System.IO.BinaryWriter

        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel) Then
            Return
        End If
        AxCZKEM1.EnableDevice(1, False)

        _stream = OpenFileDialog1.OpenFile()

        _reader = New IO.BinaryReader(_stream)

        For _index = 0 To _index < _stream.Length

            If (_reader.PeekChar() <> -1) Then

                _enrollData(_index) = _reader.ReadByte()

            End If




        Next

        _reader.Close()
        _stream.Close()




        AxCZKEM1.EnableDevice(1, True)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Dim _width As Integer = 0
        Dim _height As Integer = 0
        Dim _errorCode As Integer = 0
        ' Dim _image(83512) As Byte
        Dim _image(93512) As Byte
        Dim _imageFile As String = "Image.bmp"
        'FileStream _stream = null;
        'Dim _stream As System.IO.FileStream

        AxCZKEM1.EnableDevice(1, False)

        MsgBox("Place finger on sensor")

        If (AxCZKEM1.CaptureImage(False, _width, _height, _image(0), _imageFile)) Then

            ' _stream = New System.IO.FileStream("Image.bmp", IO.FileMode.Open)
            'PicFinger.Image = FixedSize(Image.FromStream(_stream),PicFinger.Width,PicFinger.Height);
            MsgBox("Remove finger from sensor")
            AxCZKEM1.EnableDevice(1, True)


        Else
            MsgBox("Unable to capture fingerprint")
            Return

        End If


        If (CheckBox1.Checked) Then

            ShowMyImage(_imageFile, 120, 100)
            Return

        End If

      

    End Sub


    Private MyImage As Bitmap

    Public Sub ShowMyImage(ByVal fileToDisplay As String, ByVal xSize As Integer, ByVal ySize As Integer)

        If (MyImage IsNot Nothing) Then
            MyImage.Dispose()
        End If


        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        MyImage = New Bitmap(fileToDisplay)
        PictureBox1.ClientSize = New Size(xSize, ySize)
        PictureBox1.Image = CType(MyImage, Image)

        'MyImage.Clone()




    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
