Public Class ColorBlindnessTest
    Public re As String
    Public ticker As Integer = 0
    Public rndimgs(6) As Image
    Public output As String
    Public imgs(6) As Image


    Private Sub ColorBlindnessTest_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Return Then
            PictureBox1.Show()
            PictureBox1.Image = rndimgs(0)
            Timer1.Start()

        End If
        If e.KeyCode = Keys.B Then
            re = re + "_1"
            Timer1.Interval = "500"
        End If
        If e.KeyCode = Keys.G Then
            re = re + "_2"
            Timer1.Interval = "500"
        End If
        If e.KeyCode = Keys.O Then
            re = re + "_3"
            Timer1.Interval = "500"
        End If
        If e.KeyCode = Keys.P Then
            re = re + "_4"
            Timer1.Interval = "500"
        End If
        If e.KeyCode = Keys.R Then
            re = re + "_5"
            Timer1.Interval = "500"
        End If
        If e.KeyCode = Keys.Y Then
            re = re + "_6"
            Timer1.Interval = "500"
        End If
    End Sub

   

    

   

    Private Sub ColorBlindnessTest_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Focus()
        imgs(0) = My.Resources.Resource1._1
        imgs(1) = My.Resources.Resource1._2
        imgs(2) = My.Resources.Resource1._3
        imgs(3) = My.Resources.Resource1._4
        imgs(4) = My.Resources.Resource1._5
        imgs(5) = My.Resources.Resource1._6
        Dim x As Integer = 0
        For i As Integer = 0 To 5
            '  Randomize()
            x = i
            rndimgs(i) = imgs(x)
            output = output + "_" + (x + 1).ToString()
        Next
       

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ticker = 0 Then
            PictureBox1.Image = rndimgs(1)
            Timer1.Interval = "5000"
        End If
        If ticker = 1 Then
            PictureBox1.Image = rndimgs(2)
            Timer1.Interval = "5000"
        End If
        If ticker = 2 Then
            PictureBox1.Image = rndimgs(3)
            Timer1.Interval = "5000"
        End If
        If ticker = 3 Then
            PictureBox1.Image = rndimgs(4)
            Timer1.Interval = "5000"
        End If
        If ticker = 4 Then
            PictureBox1.Image = rndimgs(5)
            Timer1.Interval = "5000"
        End If
        If ticker = 5 Then
            Timer1.Interval = "500"
            If re = output Then
                btnCtn.Visible = True
            Else
                Label2.Text = re

            End If
            Timer1.Stop()
        End If
        ticker = ticker + 1

    End Sub

   
   
    Private Sub btnCtn_Click(sender As Object, e As EventArgs) Handles btnCtn.Click
        Test1.Show()
        Me.Close()
    End Sub
End Class