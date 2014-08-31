<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Labelr = New System.Windows.Forms.Label()
        Me.Labelg = New System.Windows.Forms.Label()
        Me.Labelb = New System.Windows.Forms.Label()
        Me.Labely = New System.Windows.Forms.Label()
        Me.Labelp = New System.Windows.Forms.Label()
        Me.Labelo = New System.Windows.Forms.Label()
        Me.Labelen = New System.Windows.Forms.Label()
        Me.btnCtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identify The Colours Displayed"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.stroopTask.My.Resources.Resource1._11
        Me.PictureBox1.Location = New System.Drawing.Point(452, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Labelr
        '
        Me.Labelr.AutoSize = True
        Me.Labelr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelr.Location = New System.Drawing.Point(448, 63)
        Me.Labelr.Name = "Labelr"
        Me.Labelr.Size = New System.Drawing.Size(122, 20)
        Me.Labelr.TabIndex = 4
        Me.Labelr.Text = "Press R for Red"
        '
        'Labelg
        '
        Me.Labelg.AutoSize = True
        Me.Labelg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelg.Location = New System.Drawing.Point(448, 83)
        Me.Labelg.Name = "Labelg"
        Me.Labelg.Size = New System.Drawing.Size(138, 20)
        Me.Labelg.TabIndex = 5
        Me.Labelg.Text = "Press G for Green"
        '
        'Labelb
        '
        Me.Labelb.AutoSize = True
        Me.Labelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelb.Location = New System.Drawing.Point(448, 103)
        Me.Labelb.Name = "Labelb"
        Me.Labelb.Size = New System.Drawing.Size(123, 20)
        Me.Labelb.TabIndex = 6
        Me.Labelb.Text = "Press B for Blue"
        '
        'Labely
        '
        Me.Labely.AutoSize = True
        Me.Labely.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labely.Location = New System.Drawing.Point(448, 143)
        Me.Labely.Name = "Labely"
        Me.Labely.Size = New System.Drawing.Size(137, 20)
        Me.Labely.TabIndex = 7
        Me.Labely.Text = "Press Y for Yellow"
        '
        'Labelp
        '
        Me.Labelp.AutoSize = True
        Me.Labelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelp.Location = New System.Drawing.Point(448, 163)
        Me.Labelp.Name = "Labelp"
        Me.Labelp.Size = New System.Drawing.Size(120, 20)
        Me.Labelp.TabIndex = 8
        Me.Labelp.Text = "Press P for Pink"
        '
        'Labelo
        '
        Me.Labelo.AutoSize = True
        Me.Labelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelo.Location = New System.Drawing.Point(448, 123)
        Me.Labelo.Name = "Labelo"
        Me.Labelo.Size = New System.Drawing.Size(145, 20)
        Me.Labelo.TabIndex = 9
        Me.Labelo.Text = "Press O for Orange"
        '
        'Labelen
        '
        Me.Labelen.AutoSize = True
        Me.Labelen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelen.Location = New System.Drawing.Point(448, 183)
        Me.Labelen.Name = "Labelen"
        Me.Labelen.Size = New System.Drawing.Size(146, 20)
        Me.Labelen.TabIndex = 10
        Me.Labelen.Text = "Press Enter to start"
        '
        'btnCtn
        '
        Me.btnCtn.Location = New System.Drawing.Point(483, 434)
        Me.btnCtn.Name = "btnCtn"
        Me.btnCtn.Size = New System.Drawing.Size(75, 23)
        Me.btnCtn.TabIndex = 11
        Me.btnCtn.Text = "Continue"
        Me.btnCtn.UseVisualStyleBackColor = True
        Me.btnCtn.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 12
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(45, 298)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Time Taken"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(351, 211)
        Me.Chart1.TabIndex = 13
        Me.Chart1.Text = "Result"
        Me.Chart1.Visible = False
        '
        'Test1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 691)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCtn)
        Me.Controls.Add(Me.Labelen)
        Me.Controls.Add(Me.Labelo)
        Me.Controls.Add(Me.Labelp)
        Me.Controls.Add(Me.Labely)
        Me.Controls.Add(Me.Labelb)
        Me.Controls.Add(Me.Labelg)
        Me.Controls.Add(Me.Labelr)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Test1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test 1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Labelr As System.Windows.Forms.Label
    Friend WithEvents Labelg As System.Windows.Forms.Label
    Friend WithEvents Labelb As System.Windows.Forms.Label
    Friend WithEvents Labely As System.Windows.Forms.Label
    Friend WithEvents Labelp As System.Windows.Forms.Label
    Friend WithEvents Labelo As System.Windows.Forms.Label
    Friend WithEvents Labelen As System.Windows.Forms.Label
    Friend WithEvents btnCtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart

End Class
