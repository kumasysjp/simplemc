Imports System.Xml
Imports SimpleMC.SimpleMC


Public Class Form1

 

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

   

        Dim a As New SimpleMC.SimpleMC






        a.DebugDisplay = True
        Dim data(200) As UShort
        data(0) = &HABCD
        data(1) = &HFFFF

        a.WriteDeviceBlock2BIT("M100", data, 16)



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
