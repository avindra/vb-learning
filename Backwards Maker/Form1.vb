Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wordup As System.Windows.Forms.TextBox
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents result As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.wordup = New System.Windows.Forms.TextBox
        Me.go = New System.Windows.Forms.Button
        Me.result = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text to Reverse:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'wordup
        '
        Me.wordup.Location = New System.Drawing.Point(96, 24)
        Me.wordup.Name = "wordup"
        Me.wordup.Size = New System.Drawing.Size(312, 20)
        Me.wordup.TabIndex = 1
        Me.wordup.Text = "Avindra Goolcharan"
        '
        'go
        '
        Me.go.Location = New System.Drawing.Point(8, 112)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(400, 32)
        Me.go.TabIndex = 2
        Me.go.Text = "Show Backwards"
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(16, 64)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(392, 24)
        Me.result.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 157)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.go)
        Me.Controls.Add(Me.wordup)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Text Reverser"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        result.Text = "" 'wash the box clean to make way

        Dim init As Integer 'variable declarations
        Dim letter As String
        Dim counter As Integer
        Dim length As Integer
        Dim final As String

        length = wordup.Text.Length

        For counter = 1 To length 'building reverse text
            letter = wordup.Text.Chars(length - counter)
            final = result.Text.PadRight(length - counter, letter)
        Next counter

        result.Text = final 'plugin reverse result
    End Sub
End Class
