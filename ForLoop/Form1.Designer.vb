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
        Me.Tut_Cmd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tut_Cmd
        '
        Me.Tut_Cmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tut_Cmd.Location = New System.Drawing.Point(238, 108)
        Me.Tut_Cmd.Name = "Tut_Cmd"
        Me.Tut_Cmd.Size = New System.Drawing.Size(335, 206)
        Me.Tut_Cmd.TabIndex = 0
        Me.Tut_Cmd.Text = "FOR LOOP"
        Me.Tut_Cmd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tut_Cmd)
        Me.Name = "Form1"
        Me.Text = "For Loop Tutorial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tut_Cmd As Button
End Class
