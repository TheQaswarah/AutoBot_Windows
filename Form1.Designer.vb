<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.strt = New System.Windows.Forms.Button()
        Me.ntrvl = New System.Windows.Forms.TextBox()
        Me.stp = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tst = New System.Windows.Forms.Button()
        Me.cntr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'strt
        '
        Me.strt.Location = New System.Drawing.Point(12, 12)
        Me.strt.Name = "strt"
        Me.strt.Size = New System.Drawing.Size(75, 82)
        Me.strt.TabIndex = 0
        Me.strt.Text = "Start"
        Me.strt.UseVisualStyleBackColor = True
        '
        'ntrvl
        '
        Me.ntrvl.Location = New System.Drawing.Point(163, 91)
        Me.ntrvl.MaxLength = 9999
        Me.ntrvl.Name = "ntrvl"
        Me.ntrvl.Size = New System.Drawing.Size(57, 20)
        Me.ntrvl.TabIndex = 1
        Me.ntrvl.WordWrap = False
        '
        'stp
        '
        Me.stp.Location = New System.Drawing.Point(12, 112)
        Me.stp.Name = "stp"
        Me.stp.Size = New System.Drawing.Size(75, 83)
        Me.stp.TabIndex = 2
        Me.stp.Text = "Stop"
        Me.stp.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'tst
        '
        Me.tst.Location = New System.Drawing.Point(361, 91)
        Me.tst.Name = "tst"
        Me.tst.Size = New System.Drawing.Size(99, 23)
        Me.tst.TabIndex = 3
        Me.tst.Text = "Test"
        Me.tst.UseVisualStyleBackColor = True
        '
        'cntr
        '
        Me.cntr.AutoSize = True
        Me.cntr.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.cntr.Location = New System.Drawing.Point(398, 117)
        Me.cntr.Name = "cntr"
        Me.cntr.Size = New System.Drawing.Size(24, 27)
        Me.cntr.TabIndex = 4
        Me.cntr.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(241, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Auto Clicker by OSA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Interval"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(537, 207)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cntr)
        Me.Controls.Add(Me.tst)
        Me.Controls.Add(Me.stp)
        Me.Controls.Add(Me.ntrvl)
        Me.Controls.Add(Me.strt)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "AutoClicker by OSA"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents strt As Button
    Friend WithEvents ntrvl As TextBox
    Friend WithEvents stp As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tst As Button
    Friend WithEvents cntr As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
