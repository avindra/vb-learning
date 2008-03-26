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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents group As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents stox As System.Windows.Forms.TextBox
    Friend WithEvents b1 As System.Windows.Forms.Button
    Friend WithEvents labell As System.Windows.Forms.Label
    Friend WithEvents storex As System.Windows.Forms.TextBox
    Friend WithEvents storey As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.group = New System.Windows.Forms.GroupBox
        Me.storex = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.storey = New System.Windows.Forms.TextBox
        Me.b1 = New System.Windows.Forms.Button
        Me.labell = New System.Windows.Forms.Label
        Me.group.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "&File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "E&xit"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4})
        Me.MenuItem3.Text = "&Help"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "&About"
        '
        'group
        '
        Me.group.Controls.Add(Me.storex)
        Me.group.Controls.Add(Me.Label2)
        Me.group.Controls.Add(Me.Label1)
        Me.group.Controls.Add(Me.storey)
        Me.group.Location = New System.Drawing.Point(32, 80)
        Me.group.Name = "group"
        Me.group.Size = New System.Drawing.Size(344, 80)
        Me.group.TabIndex = 0
        Me.group.TabStop = False
        Me.group.Text = "Input Data"
        '
        'storex
        '
        Me.storex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.storex.Location = New System.Drawing.Point(56, 40)
        Me.storex.Name = "storex"
        Me.storex.Size = New System.Drawing.Size(96, 20)
        Me.storex.TabIndex = 4
        Me.storex.Text = "FIRST NUMBER"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(184, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "y"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(8, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "x"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'storey
        '
        Me.storey.Location = New System.Drawing.Point(216, 40)
        Me.storey.Name = "storey"
        Me.storey.Size = New System.Drawing.Size(104, 20)
        Me.storey.TabIndex = 1
        Me.storey.Text = "SECOND NUMBER"
        '
        'b1
        '
        Me.b1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b1.Location = New System.Drawing.Point(48, 192)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(160, 32)
        Me.b1.TabIndex = 1
        Me.b1.Text = "Lets DO IT!"
        '
        'labell
        '
        Me.labell.Location = New System.Drawing.Point(40, 16)
        Me.labell.Name = "labell"
        Me.labell.Size = New System.Drawing.Size(344, 32)
        Me.labell.TabIndex = 2
        Me.labell.Text = "The answer will appear momentarily..."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 245)
        Me.Controls.Add(Me.labell)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.group)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "Program One"
        Me.group.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Exit Commands
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        End
    End Sub
    'what pressing the button does
    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        Dim x As Single
        Dim y As Single
        x = storex.Text
        y = storey.Text
        labell.Text = x + y
        If labell.Text = 108 Then
            GoTo Cool
        Else
            GoTo Nope
        End If
Cool:
        MessageBox.Show("You are a lost fan, arent you?", "You jerk")
Nope:
    End Sub


    'end of program
End Class
