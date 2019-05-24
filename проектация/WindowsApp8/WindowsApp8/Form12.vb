Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub SSChk_Tick(sender As Object, e As EventArgs) Handles SSChk.Tick
        If (GetAsyncKeyState(117)) Then
            Timer1.Start()

        End If
        If (GetAsyncKeyState(118)) Then
            Timer1.Stop()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim BMP As New Drawing.Bitmap(1, 1)
        Dim GFX As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(BMP)
        GFX.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y),
        New Drawing.Point(0, 0), BMP.Size)
        Dim Pixel As Drawing.Color = BMP.GetPixel(0, 0)
        Panel1.BackColor = Pixel
        TextBox1.Text = Pixel.R
        TextBox2.Text = Pixel.G
        TextBox3.Text = Pixel.B
    End Sub
End Class