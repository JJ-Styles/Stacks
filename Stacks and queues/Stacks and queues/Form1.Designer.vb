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
        Me.LBoxStack = New System.Windows.Forms.ListBox()
        Me.BttStack = New System.Windows.Forms.Button()
        Me.TxtAddStack = New System.Windows.Forms.TextBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBoxStack
        '
        Me.LBoxStack.FormattingEnabled = True
        Me.LBoxStack.Location = New System.Drawing.Point(54, 398)
        Me.LBoxStack.Name = "LBoxStack"
        Me.LBoxStack.Size = New System.Drawing.Size(527, 147)
        Me.LBoxStack.TabIndex = 1
        '
        'BttStack
        '
        Me.BttStack.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttStack.Location = New System.Drawing.Point(54, 210)
        Me.BttStack.Name = "BttStack"
        Me.BttStack.Size = New System.Drawing.Size(340, 139)
        Me.BttStack.TabIndex = 2
        Me.BttStack.Text = "Stack"
        Me.BttStack.UseVisualStyleBackColor = True
        '
        'TxtAddStack
        '
        Me.TxtAddStack.Location = New System.Drawing.Point(561, 120)
        Me.TxtAddStack.Name = "TxtAddStack"
        Me.TxtAddStack.Size = New System.Drawing.Size(530, 20)
        Me.TxtAddStack.TabIndex = 3
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.Location = New System.Drawing.Point(415, 114)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(140, 25)
        Me.Lbl.TabIndex = 4
        Me.Lbl.Text = "Enter A Word"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.TxtAddStack)
        Me.Controls.Add(Me.BttStack)
        Me.Controls.Add(Me.LBoxStack)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBoxStack As System.Windows.Forms.ListBox
    Friend WithEvents BttStack As System.Windows.Forms.Button
    Friend WithEvents TxtAddStack As System.Windows.Forms.TextBox
    Friend WithEvents Lbl As System.Windows.Forms.Label

End Class
