Public Class Test1

    Public re As String = vbNullString
    Public ticker As Integer = 0
    Public output As String = "_3_1_5_4_6_2"
    Public start As Integer = 0
    Public timetaken(6) As Integer
    Public imgs(6) As Image


    Private Sub Test1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Return Then
            PictureBox1.Show()
            PictureBox1.Image = imgs(0)
            start = DateTime.Now().Ticks Mod 10000000
            Timer1.Start()


        End If
        If e.KeyCode = Keys.B Then
            re = re + "_1"
            timetaken(0) = (Math.Abs((DateTime.Now().Ticks) Mod 10000000 - start Mod 10000000) Mod 10000000) / 100
            Timer1.Interval = "500"
        End If
        If e.KeyCode = Keys.G Then
            re = re + "_2"
            timetaken(1) = (Math.Abs((DateTime.Now().Ticks) Mod 10000000 - start Mod 10000000) Mod 10000000) / 100
            Timer1.Interval = "500"
        End If
        If e.KeyCode = Keys.O Then
            re = re + "_3"
            timetaken(2) = (Math.Abs((DateTime.Now().Ticks) Mod 10000000 - start Mod 10000000) Mod 10000000) / 100
            Timer1.Interval = "500"
        End If
        If e.KeyCode = Keys.P Then
            re = re + "_4"
            timetaken(3) = (Math.Abs((DateTime.Now().Ticks) Mod 10000000 - start Mod 10000000) Mod 10000000) / 100
            Timer1.Interval = "500"
        End If
        If e.KeyCode = Keys.R Then
            re = re + "_5"
            timetaken(4) = (Math.Abs((DateTime.Now().Ticks) Mod 10000000 - start Mod 10000000) Mod 10000000) / 100
            Timer1.Interval = "500"
        End If
        If e.KeyCode = Keys.Y Then
            re = re + "_6"
            timetaken(5) = (Math.Abs((DateTime.Now().Ticks) Mod 10000000 - start Mod 10000000) Mod 10000000) / 100
            Timer1.Interval = "500"
        End If
    End Sub







    Private Sub Test1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Focus()
        imgs(0) = My.Resources.Resource1._33
        imgs(1) = My.Resources.Resource1._11
        imgs(2) = My.Resources.Resource1._55
        imgs(3) = My.Resources.Resource1._44
        imgs(4) = My.Resources.Resource1._66
        imgs(5) = My.Resources.Resource1._22


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ticker = 0 Then
            PictureBox1.Image = imgs(1)
            start = DateTime.Now().Ticks Mod 10000000
            Timer1.Interval = "5000"
        End If
        If ticker = 1 Then
            PictureBox1.Image = imgs(2)
            start = DateTime.Now().Ticks Mod 10000000
            Timer1.Interval = "5000"
        End If
        If ticker = 2 Then
            PictureBox1.Image = imgs(3)
            start = DateTime.Now().Ticks Mod 10000000
            Timer1.Interval = "5000"
        End If
        If ticker = 3 Then
            PictureBox1.Image = imgs(4)
            start = DateTime.Now().Ticks Mod 10000000
            Timer1.Interval = "5000"
        End If
        If ticker = 4 Then
            PictureBox1.Image = imgs(5)
            start = DateTime.Now().Ticks Mod 10000000
            Timer1.Interval = "5000"
        End If
        If ticker = 5 Then
            Timer1.Interval = "500"
            If re = output Then
                For i As Integer = 0 To 5
                    Chart1.Series(0).Points.AddXY(i, timetaken(i))
                Next
                Chart1.Show()
                btnCtn.Visible = True
            Else
                Label2.Text = re + output

            End If
            Timer1.Stop()
        End If
        ticker = ticker + 1
    End Sub

    Private Sub btnCtn_Click(sender As Object, e As EventArgs) Handles btnCtn.Click
        Me.Close()
    End Sub
End Class