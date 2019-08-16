Public Class Form1
    Private Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)

    Dim UserInterval As Integer = Nothing
    Private Const mouseclickdown = 3
    Private Const mouseclickup = 2
    Dim Test As Integer

    Public Property getInterval As Integer
        Get
            Return UserInterval
        End Get
        Set(UserInterval As Integer)
            Timer1.Interval = UserInterval
        End Set
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Strt_Click(sender As Object, e As EventArgs) Handles strt.Click
        Timer1.Start()
    End Sub

    Private Sub Stp_Click(sender As Object, e As EventArgs) Handles stp.Click
        Timer1.Stop()
        Timer1.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub Tst_Click(sender As Object, e As EventArgs) Handles tst.Click
        Test = Test + 1
        cntr.Text = Test
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = UserInterval + 1
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
    End Sub

    Private Sub Ntrvl_TextChanged(sender As Object, e As EventArgs) Handles ntrvl.TextChanged
        UserInterval = ntrvl.Text
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class