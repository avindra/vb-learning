Public Class Form1
    Inherits System.Windows.Forms.Form

#Region "WINDOW CODE"
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents rock As System.Windows.Forms.RadioButton
    Friend WithEvents paper As System.Windows.Forms.RadioButton
    Friend WithEvents scissors As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents outcome As System.Windows.Forms.Label
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comp As System.Windows.Forms.Label
    Friend WithEvents exitus As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rock = New System.Windows.Forms.RadioButton
        Me.paper = New System.Windows.Forms.RadioButton
        Me.scissors = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.outcome = New System.Windows.Forms.Label
        Me.go = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.comp = New System.Windows.Forms.Label
        Me.exitus = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rock
        '
        Me.rock.Location = New System.Drawing.Point(16, 24)
        Me.rock.Name = "rock"
        Me.rock.Size = New System.Drawing.Size(72, 16)
        Me.rock.TabIndex = 0
        Me.rock.Text = "rock"
        '
        'paper
        '
        Me.paper.Location = New System.Drawing.Point(88, 24)
        Me.paper.Name = "paper"
        Me.paper.Size = New System.Drawing.Size(64, 16)
        Me.paper.TabIndex = 1
        Me.paper.Text = "paper"
        '
        'scissors
        '
        Me.scissors.Location = New System.Drawing.Point(160, 24)
        Me.scissors.Name = "scissors"
        Me.scissors.Size = New System.Drawing.Size(64, 16)
        Me.scissors.TabIndex = 2
        Me.scissors.Text = "scissors"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Outcome:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rock)
        Me.GroupBox1.Controls.Add(Me.paper)
        Me.GroupBox1.Controls.Add(Me.scissors)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 48)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choice"
        '
        'outcome
        '
        Me.outcome.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.outcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outcome.Location = New System.Drawing.Point(80, 112)
        Me.outcome.Name = "outcome"
        Me.outcome.Size = New System.Drawing.Size(128, 16)
        Me.outcome.TabIndex = 5
        '
        'go
        '
        Me.go.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.go.Cursor = System.Windows.Forms.Cursors.Cross
        Me.go.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.go.Location = New System.Drawing.Point(80, 56)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(128, 24)
        Me.go.TabIndex = 6
        Me.go.Text = "FIGHT!"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Computer:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'comp
        '
        Me.comp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.comp.Location = New System.Drawing.Point(80, 88)
        Me.comp.Name = "comp"
        Me.comp.Size = New System.Drawing.Size(128, 16)
        Me.comp.TabIndex = 8
        '
        'exitus
        '
        Me.exitus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitus.Location = New System.Drawing.Point(200, 136)
        Me.exitus.Name = "exitus"
        Me.exitus.Size = New System.Drawing.Size(40, 16)
        Me.exitus.TabIndex = 9
        Me.exitus.Text = "done"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(242, 154)
        Me.Controls.Add(Me.exitus)
        Me.Controls.Add(Me.comp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.go)
        Me.Controls.Add(Me.outcome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        Const cRock As Integer = 1 '"change" text inputs to single integers
        Const cPaper As Integer = 2
        Const cSciss As Integer = 3
        Dim cChoice As Integer

        Randomize() 'computer choice maker
        cChoice = Int(3 * Rnd()) + 1
        If cChoice = 1 Then
            comp.Text = "Rock"
        ElseIf cChoice = 2 Then
            comp.Text = "Paper"
        ElseIf cChoice = 3 Then
            comp.Text = "Scissors"
        End If

        If rock.Checked And cChoice = cRock Then 'Rock outcomes
            outcome.Text = "Draw!"
        ElseIf rock.Checked And cChoice = cPaper Then
            outcome.Text = "You lose!"
        ElseIf rock.Checked And cChoice = cSciss Then
            outcome.Text = "You win!"
        End If

        If paper.Checked And cChoice = cRock Then 'paper outcomes
            outcome.Text = "You Win!"
        ElseIf paper.Checked And cChoice = cPaper Then
            outcome.Text = "Draw!"
        ElseIf paper.Checked And cChoice = cSciss Then
            outcome.Text = "You Lose!"
        End If

        If scissors.Checked And cChoice = cRock Then 'scissor outcomes
            outcome.Text = "You Lose!"
        ElseIf scissors.Checked And cChoice = cPaper Then
            outcome.Text = "You Win!!!"
        ElseIf scissors.Checked And cChoice = cSciss Then
            outcome.Text = "Draw...."
        End If
    End Sub

    Private Sub exitus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitus.Click
        End
    End Sub
End Class
