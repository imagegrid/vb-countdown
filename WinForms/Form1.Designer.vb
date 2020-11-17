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
        Me.TmrEvent = New System.Windows.Forms.Timer(Me.components)
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.Divider1 = New System.Windows.Forms.Label()
        Me.Divider2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TmrEvent
        '
        '
        'lblHours
        '
        Me.lblHours.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(54, 67)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(105, 73)
        Me.lblHours.TabIndex = 0
        Me.lblHours.Text = "00"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMinutes
        '
        Me.lblMinutes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(233, 67)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(104, 73)
        Me.lblMinutes.TabIndex = 1
        Me.lblMinutes.Text = "00"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSeconds
        '
        Me.lblSeconds.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(418, 67)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(104, 73)
        Me.lblSeconds.TabIndex = 2
        Me.lblSeconds.Text = "00"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Divider1
        '
        Me.Divider1.AutoSize = True
        Me.Divider1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider1.Location = New System.Drawing.Point(167, 63)
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(50, 73)
        Me.Divider1.TabIndex = 3
        Me.Divider1.Text = ":"
        '
        'Divider2
        '
        Me.Divider2.AutoSize = True
        Me.Divider2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider2.Location = New System.Drawing.Point(351, 63)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(50, 73)
        Me.Divider2.TabIndex = 4
        Me.Divider2.Text = ":"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.lblHours)
        Me.GroupBox1.Controls.Add(Me.lblSeconds)
        Me.GroupBox1.Controls.Add(Me.Divider2)
        Me.GroupBox1.Controls.Add(Me.Divider1)
        Me.GroupBox1.Controls.Add(Me.lblMinutes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(144, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 202)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(862, 455)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHours As Label
    Private WithEvents TmrEvent As Timer
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents Divider1 As Label
    Friend WithEvents Divider2 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
