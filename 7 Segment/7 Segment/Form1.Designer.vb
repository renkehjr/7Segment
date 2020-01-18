Option Explicit On
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.L4 = New System.Windows.Forms.Label()
        Me.L7 = New System.Windows.Forms.Label()
        Me.L6 = New System.Windows.Forms.Label()
        Me.L5 = New System.Windows.Forms.Label()
        Me.L3 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.L1 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.L4)
        Me.Panel1.Controls.Add(Me.L7)
        Me.Panel1.Controls.Add(Me.L6)
        Me.Panel1.Controls.Add(Me.L5)
        Me.Panel1.Controls.Add(Me.L3)
        Me.Panel1.Controls.Add(Me.L2)
        Me.Panel1.Controls.Add(Me.L1)
        Me.Panel1.Location = New System.Drawing.Point(145, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 349)
        Me.Panel1.TabIndex = 0
        '
        'L4
        '
        Me.L4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.L4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L4.Location = New System.Drawing.Point(79, 275)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(83, 16)
        Me.L4.TabIndex = 9
        '
        'L7
        '
        Me.L7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.L7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L7.Location = New System.Drawing.Point(79, 166)
        Me.L7.Name = "L7"
        Me.L7.Size = New System.Drawing.Size(83, 16)
        Me.L7.TabIndex = 8
        '
        'L6
        '
        Me.L6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.L6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L6.Location = New System.Drawing.Point(61, 75)
        Me.L6.Name = "L6"
        Me.L6.Size = New System.Drawing.Size(17, 91)
        Me.L6.TabIndex = 7
        '
        'L5
        '
        Me.L5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.L5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L5.Location = New System.Drawing.Point(61, 182)
        Me.L5.Name = "L5"
        Me.L5.Size = New System.Drawing.Size(17, 91)
        Me.L5.TabIndex = 6
        '
        'L3
        '
        Me.L3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.L3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L3.Location = New System.Drawing.Point(163, 184)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(17, 91)
        Me.L3.TabIndex = 5
        '
        'L2
        '
        Me.L2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.L2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L2.Location = New System.Drawing.Point(163, 75)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(17, 91)
        Me.L2.TabIndex = 2
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.L1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L1.Location = New System.Drawing.Point(79, 59)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(83, 16)
        Me.L1.TabIndex = 0
        '
        'Timer
        '
        Me.Timer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Timer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Timer.ForeColor = System.Drawing.Color.Black
        Me.Timer.Location = New System.Drawing.Point(459, 225)
        Me.Timer.Name = "Timer"
        Me.Timer.Size = New System.Drawing.Size(84, 32)
        Me.Timer.TabIndex = 1
        Me.Timer.Text = "Start"
        Me.Timer.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(589, 450)
        Me.Controls.Add(Me.Timer)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents L1 As Label
    Friend WithEvents L2 As Label

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles L1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents L6 As Label
    Friend WithEvents L5 As Label
    Friend WithEvents L3 As Label

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents L7 As Label

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles L6.Click

    End Sub

    Friend WithEvents L4 As Label
    Friend WithEvents Timer As Button


    Private N As Integer

    Private Sub cmdpump_Click()
        Timer.Enabled = True
    End Sub

    Private Sub Cmdstop_Click()
        Timer.Enabled = False
    End Sub

    Private Sub Form_Load()
        N = 0
    End Sub

    Private Sub Timer_Click(sender As Object, e As EventArgs) Handles Timer.Click

        If N = 0 Then
            L1.Visible = True   '0
            L2.Visible = True
            L3.Visible = True
            L4.Visible = True
            L5.Visible = True
            L6.Visible = True
            L7.Visible = False
            N = 1

        ElseIf N = 1 Then
            L1.Visible = False  '1
            L2.Visible = True
            L3.Visible = True
            L4.Visible = False
            L5.Visible = False
            L6.Visible = False
            L7.Visible = False
            N = 2


        ElseIf N = 2 Then
            L1.Visible = True '2
            L2.Visible = True
            L3.Visible = False
            L4.Visible = True
            L5.Visible = True
            L6.Visible = False
            L7.Visible = True
            N = 3


        ElseIf N = 3 Then
            L1.Visible = True  '3
            L2.Visible = True
            L3.Visible = True
            L4.Visible = True
            L5.Visible = False
            L6.Visible = False
            L7.Visible = True
            N = 4


        ElseIf N = 4 Then
            L1.Visible = False  '4
            L2.Visible = True
            L3.Visible = True
            L4.Visible = False
            L5.Visible = False
            L6.Visible = True
            L7.Visible = True
            N = 5


        ElseIf N = 5 Then
            L1.Visible = True  '5
            L2.Visible = False
            L3.Visible = True
            L4.Visible = True
            L5.Visible = False
            L6.Visible = True
            L7.Visible = True
            N = 6


        ElseIf N = 6 Then
            L1.Visible = True  '6
            L2.Visible = False
            L3.Visible = True
            L4.Visible = True
            L5.Visible = True
            L6.Visible = True
            L7.Visible = True
            N = 7


        ElseIf N = 7 Then
            L1.Visible = True '7
            L2.Visible = True
            L3.Visible = True
            L4.Visible = False
            L5.Visible = False
            L6.Visible = False
            L7.Visible = False
            N = 8


        ElseIf N = 8 Then
            L1.Visible = True  '8
            L2.Visible = True
            L3.Visible = True
            L4.Visible = True
            L5.Visible = True
            L6.Visible = True
            L7.Visible = True
            N = 9


        ElseIf N = 9 Then
            L1.Visible = True  '9
            L2.Visible = True
            L3.Visible = True
            L4.Visible = True
            L5.Visible = False
            L6.Visible = True
            L7.Visible = True
            N = 0
        End If
    End Sub
End Class