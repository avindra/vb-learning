Public Class Form1
    Inherits System.Windows.Forms.Form
#Region "Window Code"

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents first As System.Windows.Forms.Label
    Friend WithEvents middle As System.Windows.Forms.Label
    Friend WithEvents last As System.Windows.Forms.Label
    Friend WithEvents word As System.Windows.Forms.TextBox
    Friend WithEvents Go As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.first = New System.Windows.Forms.Label
        Me.middle = New System.Windows.Forms.Label
        Me.last = New System.Windows.Forms.Label
        Me.word = New System.Windows.Forms.TextBox
        Me.Go = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Word to Check:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1st"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'first
        '
        Me.first.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.first.Location = New System.Drawing.Point(64, 48)
        Me.first.Name = "first"
        Me.first.Size = New System.Drawing.Size(24, 16)
        Me.first.TabIndex = 4
        '
        'middle
        '
        Me.middle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.middle.Location = New System.Drawing.Point(64, 64)
        Me.middle.Name = "middle"
        Me.middle.Size = New System.Drawing.Size(24, 16)
        Me.middle.TabIndex = 5
        '
        'last
        '
        Me.last.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.last.Location = New System.Drawing.Point(64, 80)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(24, 16)
        Me.last.TabIndex = 6
        '
        'word
        '
        Me.word.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.word.Location = New System.Drawing.Point(104, 16)
        Me.word.MaxLength = 100
        Me.word.Name = "word"
        Me.word.Size = New System.Drawing.Size(176, 20)
        Me.word.TabIndex = 7
        Me.word.Text = ""
        '
        'Go
        '
        Me.Go.Location = New System.Drawing.Point(176, 72)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(80, 24)
        Me.Go.TabIndex = 8
        Me.Go.Text = "Lets Do it!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(288, 109)
        Me.Controls.Add(Me.Go)
        Me.Controls.Add(Me.word)
        Me.Controls.Add(Me.last)
        Me.Controls.Add(Me.middle)
        Me.Controls.Add(Me.first)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Word Analyzer"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Sub Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Go.Click

        Dim length As Single
        Dim mid As Single
        length = word.Text.Length - 1
        mid = length / 2

        If word.Text = "" Then
            MessageBox.Show("Please input a word to analyze.", "Attention!")
            Return
        End If


        first.Text = word.Text.Chars(0)
        middle.Text = word.Text.Chars(mid)
        last.Text = word.Text.Chars(length)
    End Sub
End Class
