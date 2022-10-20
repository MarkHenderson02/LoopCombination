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
        Me.ListLoop = New System.Windows.Forms.ListBox()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListLoop
        '
        Me.ListLoop.FormattingEnabled = True
        Me.ListLoop.Location = New System.Drawing.Point(53, 91)
        Me.ListLoop.Name = "ListLoop"
        Me.ListLoop.Size = New System.Drawing.Size(221, 329)
        Me.ListLoop.TabIndex = 0
        '
        'btnForNext
        '
        Me.btnForNext.BackColor = System.Drawing.Color.Snow
        Me.btnForNext.Location = New System.Drawing.Point(322, 130)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(106, 42)
        Me.btnForNext.TabIndex = 1
        Me.btnForNext.Text = "FOR NEXT"
        Me.btnForNext.UseVisualStyleBackColor = False
        '
        'btnDoWhile
        '
        Me.btnDoWhile.BackColor = System.Drawing.Color.Snow
        Me.btnDoWhile.Location = New System.Drawing.Point(322, 230)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(106, 42)
        Me.btnDoWhile.TabIndex = 2
        Me.btnDoWhile.Text = "DO WHILE"
        Me.btnDoWhile.UseVisualStyleBackColor = False
        '
        'btnDoUntil
        '
        Me.btnDoUntil.BackColor = System.Drawing.Color.Snow
        Me.btnDoUntil.Location = New System.Drawing.Point(322, 339)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(106, 42)
        Me.btnDoUntil.TabIndex = 3
        Me.btnDoUntil.Text = "DO UNTIL"
        Me.btnDoUntil.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 510)
        Me.Controls.Add(Me.btnDoUntil)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btnForNext)
        Me.Controls.Add(Me.ListLoop)
        Me.Name = "Form1"
        Me.Text = "Looping Combination"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListLoop As ListBox
    Friend WithEvents btnForNext As Button
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents btnDoUntil As Button
End Class
