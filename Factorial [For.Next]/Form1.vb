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
    Friend WithEvents fac As System.Windows.Forms.TextBox
    Friend WithEvents facres As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Go As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.fac = New System.Windows.Forms.TextBox
        Me.facres = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Go = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'fac
        '
        Me.fac.Location = New System.Drawing.Point(56, 8)
        Me.fac.Name = "fac"
        Me.fac.Size = New System.Drawing.Size(40, 20)
        Me.fac.TabIndex = 0
        Me.fac.Text = ""
        '
        'facres
        '
        Me.facres.Location = New System.Drawing.Point(8, 40)
        Me.facres.Name = "facres"
        Me.facres.Size = New System.Drawing.Size(272, 24)
        Me.facres.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "#"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Go
        '
        Me.Go.Location = New System.Drawing.Point(104, 8)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(168, 24)
        Me.Go.TabIndex = 3
        Me.Go.Text = "Calculate"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 69)
        Me.Controls.Add(Me.Go)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.facres)
        Me.Controls.Add(Me.fac)
        Me.Name = "Form1"
        Me.Text = "Factorials"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Go.Click
        Dim factory As Long = 1

        Dim intno As Integer
        intno = Val(fac.Text) 'use val to indicate number?
        Dim intcount As Integer

        For intcount = 1 To intno
            factory = factory * intcount
        Next intcount
        facres.Text = factory
    End Sub
End Class
