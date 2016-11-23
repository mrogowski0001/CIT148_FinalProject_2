<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubmitVerify
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
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.lblWarnText = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWarning
        '
        Me.lblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.Location = New System.Drawing.Point(12, 32)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(384, 23)
        Me.lblWarning.TabIndex = 0
        Me.lblWarning.Text = "WARNING!"
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWarnText
        '
        Me.lblWarnText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarnText.Location = New System.Drawing.Point(12, 70)
        Me.lblWarnText.Name = "lblWarnText"
        Me.lblWarnText.Size = New System.Drawing.Size(384, 124)
        Me.lblWarnText.TabIndex = 1
        Me.lblWarnText.Text = "warning text"
        Me.lblWarnText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(55, 210)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit Quiz"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(281, 209)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 3
        Me.btnContinue.Text = "Continue Quiz"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'frmSubmitVerify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblWarnText)
        Me.Controls.Add(Me.lblWarning)
        Me.Name = "frmSubmitVerify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WARNING!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents lblWarnText As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
End Class
