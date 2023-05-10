Imports SimpleMC.SimpleMC




Public Class MCMonitor


    Public initarg As Boolean = False
    Public ins1 As New SimpleMC.SimpleMC



    Public Function ネットワーク接続警告() As Boolean
        Dim result As DialogResult = MessageBox.Show("指定ポートが疎通しているか確認しましたか。ファイアウォールで遮断される場合があります。", _
                                             "ポート確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            Return True
        ElseIf result = DialogResult.No Then
            Return False
        ElseIf result = DialogResult.Cancel Then
            Return False
        End If

    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles 実行.Click





        If ネットワーク接続警告() Then

            If 読込ラジオ.Checked Then
                読込(ins1, True)
            End If


            If 書込ラジオ.Checked Then
                書込(ins1, True)
            End If


        End If







    End Sub


    Public Function 読書Init(ins As SimpleMC.SimpleMC) As SimpleMC.SimpleMC

        ins.TimeOutMessage = "タイムアウトしました"
        ins.TimeOutMessageDisplay = True
        ins.TIMEOUT = TimeOutBOX.Value



        ins.ActHostAddress = IPAddrTextBox.Text
        ins.ActPortNumber = PortNumBOX.Value

        If COMBINARY.Text = "binary" Then
            ins.BinaryASCII = EnumBinaryASCII.Binary
        Else
            ins.BinaryASCII = EnumBinaryASCII.ASCII
        End If

        ins.MCProtocol = EnumMCProtocol.フレーム4E  'Ethernet(3E,4E)のﾊﾞｲﾅﾘ, 形式5(4Cﾌﾚｰﾑﾊﾞｲﾅﾘ)に対応しています。





        Return ins



    End Function





    Public Function 読込(ins As SimpleMC.SimpleMC, alarm As Boolean) As SimpleMC.SimpleMC

        '    ソート(0)
        ins = MAKETABLE(ins)
        ins = 読書Init(ins)




        If ins.ExDeviceCodes(DeviceCombo.Text + NumBox.Text).BITWORD = EnumBITWORD.WORD Then

            If ダブルワード.Checked Then

                Dim rtnDWORD As New ReturnDWORD

                Dim data(PointsBOX.Value - 1) As UInteger
                rtnDWORD = ins.ReadDeviceBlock2DWord(DeviceCombo.Text + NumBox.Text, PointsBOX.Value)


                While Not rtnDWORD.Finished = True : End While
                data = rtnDWORD.UIntegerArray




                For i = 0 To CInt(PointsBOX.Value - 1)
                    If 符号付表示.Checked Then
                        Grid1(1, i).Value = ins.符号無32ビットデータから変換(data(i))
                    Else
                        Grid1(1, i).Value = data(i)
                    End If
                Next i

            Else
                Dim data(PointsBOX.Value - 1) As UShort
                Dim rtnWORD As New ReturnWORD

                rtnWORD = ins.ReadDeviceBlock2(DeviceCombo.Text + NumBox.Text, PointsBOX.Value)

                While Not rtnWORD.Finished = True : End While

                data = rtnWORD.UShortArray




                For i = 0 To CInt(PointsBOX.Value - 1)
                    If 符号付表示.Checked Then
                        Grid1(1, i).Value = ins.符号無16ビットデータから変換(data(i))

                    Else
                        Grid1(1, i).Value = data(i)
                    End If
                Next i
            End If

        Else 'BIT



            Dim data(PointsBOX.Value - 1) As Byte
            Dim rtnBIT As New ReturnBIT

            rtnBIT = ins.ReadDeviceBlock2ArrayBit(DeviceCombo.Text + NumBox.Text, PointsBOX.Value)

            While Not rtnBIT.Finished = True : End While

            data = rtnBIT.ByteArray



            For i = 0 To CInt(PointsBOX.Value - 1)
                Grid1(1, i).Value = data(i)
            Next i






        End If




        列設定(0)


        Return ins
    End Function

    Public Sub 列設定(i)
        Grid1.Columns(i).DefaultCellStyle.BackColor = Color.LightGray
        Grid1.Columns(i).ReadOnly = True
    End Sub


    Public Function 書込(ins As SimpleMC.SimpleMC, alarm As Boolean) As SimpleMC.SimpleMC
        '     ソート(0)
        ins = 読書Init(ins)




        If ins.ExDeviceCodes(DeviceCombo.Text + NumBox.Text).BITWORD = EnumBITWORD.WORD Then



            If ダブルワード.Checked Then
                Dim Data(PointsBOX.Value - 1) As UInteger
                For i = 0 To CInt(PointsBOX.Value - 1)
                    Data(i) = ins.符号無32ビットデータへ変換(Grid1(1, i).Value)
                Next i
                ins.WriteDeviceBlock2DWord(DeviceCombo.Text + NumBox.Text, Data, PointsBOX.Value)
            Else
                Dim Data(PointsBOX.Value - 1) As UShort
                For i = 0 To CInt(PointsBOX.Value - 1)
                    Data(i) = ins.符号無16ビットデータへ変換(Grid1(1, i).Value)
                Next i


                ins.WriteDeviceBlock2(DeviceCombo.Text + NumBox.Text, Data, PointsBOX.Value)

            End If

        Else
            Dim Data(PointsBOX.Value - 1) As Byte
            For i = 0 To CInt(PointsBOX.Value - 1)
                Data(i) = Grid1(1, i).Value
            Next i

            ins.WriteDeviceBlock2ArrayBit(DeviceCombo.Text + NumBox.Text, Data, PointsBOX.Value)

        End If

        Return 読込(ins, False)

    End Function


    Public Function DeviceNumDiscrict(ins As SimpleMC.SimpleMC) As SimpleMC.SimpleMC
        Dim buf As String



        Try
            If ins.ExDeviceCodes(DeviceCombo.Text + NumBox.Text).HEXDEC = EnumHEXDEC.HEX Then
                buf = Convert.ToInt32(NumBox.Text, 16)
            End If

            If ins.ExDeviceCodes(DeviceCombo.Text + NumBox.Text).HEXDEC = EnumHEXDEC.DEC Then
                buf = Convert.ToInt32(NumBox.Text, 10)
            End If

            If Not NumBox.Text = "0" And NumBox.Text.Substring(0, 1) = "0" Then
                NumBox.Text = NumBox.Text.Substring(1)
            End If


            NumBox.Select(NumBox.Text.Length, 0)
        Catch ex As Exception
            NumBox.Text = "0"
        End Try






        NumBox.Select(NumBox.Text.Length, 0)


        Return ins
    End Function








    Public Function MAKETABLE(ins As SimpleMC.SimpleMC) As SimpleMC.SimpleMC
        Grid1.Rows.Clear()
        Grid1.Columns.Clear()
        Grid1.Columns.Add("Device", "Device")
        Grid1.Columns.Add("Value", "Value")


        Dim j As Short


        For i = 0 To CInt(PointsBOX.Value - 1)
            If ins.ExDeviceCodes(DeviceCombo.Text + NumBox.Text).BITWORD = EnumBITWORD.WORD And Not DeviceCombo.Text = "TN" And Not DeviceCombo.Text = "CN" And ダブルワード.Checked Then
                j = 2 * i
            Else
                j = i
            End If



            If ins.ExDeviceCodes(DeviceCombo.Text + NumBox.Text).HEXDEC = EnumHEXDEC.DEC Then
                Grid1.Rows.Add(DeviceCombo.Text & (Convert.ToInt32(NumBox.Text, 10) + j), 0)
            End If
            If ins.ExDeviceCodes(DeviceCombo.Text + NumBox.Text).HEXDEC = EnumHEXDEC.HEX Then
                Grid1.Rows.Add(DeviceCombo.Text & (Hex(Convert.ToInt32(NumBox.Text, 16) + j)), 0)

            End If

        Next

        Return ins

    End Function



    Public Function イベント(ins As SimpleMC.SimpleMC) As SimpleMC.SimpleMC




        If ins.ExDeviceCodes(DeviceCombo.Text + NumBox.Text).BITWORD = EnumBITWORD.BIT And PointsBOX.Value > 7160 Then
            PointsBOX.Value = 7160
        ElseIf ins.ExDeviceCodes(DeviceCombo.Text + NumBox.Text).BITWORD = EnumBITWORD.WORD And PointsBOX.Value > 960 Then
            PointsBOX.Value = 960

        Else

            '  ソート(0)

            ins = DeviceNumDiscrict(ins)
            ins = MAKETABLE(ins)

            If 表更新と同時に読込.Checked Then
                ins = 読込(ins, True)
            End If

            列設定(0)

        End If



        Return ins
    End Function


    Public Sub ソート(i)
        Grid1.Sort(Grid1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub






    Private Sub DeviceCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeviceCombo.SelectedIndexChanged

        イベント(ins1)

    End Sub

    Private Sub PointsBOX_ValueChanged(sender As Object, e As EventArgs) Handles PointsBOX.ValueChanged




        イベント(ins1)



    End Sub











    Private Sub NumBox_TextChanged(sender As Object, e As EventArgs) Handles NumBox.TextChanged
        イベント(ins1)
    End Sub




    Private Sub 符号付表示_CheckedChanged(sender As Object, e As EventArgs) Handles 符号付表示.CheckedChanged
        イベント(ins1)
    End Sub


    Private Sub Grid1_CellCHanged(sender As Object, e As EventArgs) Handles Grid1.CellValueChanged
        If initarg = True Then

            If Grid1.CurrentCell.ColumnIndex = 1 Then

                Grid1(Grid1.CurrentCell.ColumnIndex, Grid1.CurrentCell.RowIndex).Style.BackColor = Color.Yellow

            End If



        End If

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initarg = True
        列設定(0)


        MsgBox("PLC以外のネットワークを切断を実施してください" & vbCrLf & "実施せず利用した場合, セキュリティ上の問題が発生するおそれがあります。", 1, "利用注意")



    End Sub


    Private Sub ダブルワード_CheckedChanged(sender As Object, e As EventArgs) Handles ダブルワード.CheckedChanged
        イベント(ins1)
    End Sub

    Private Sub 表更新と同時に読込_CheckedChanged(sender As Object, e As EventArgs) Handles 表更新と同時に読込.CheckedChanged

        If 表更新と同時に読込.Checked Then
            If ネットワーク接続警告() And 表更新と同時に読込.Checked Then
                イベント(ins1)
            Else
                表更新と同時に読込.Checked = False
            End If

        End If





    End Sub



End Class
