<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.lblWelcomeText = New System.Windows.Forms.Label()
        Me.lblInstructionsText = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(103, 363)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(237, 23)
        Me.btnBegin.TabIndex = 0
        Me.btnBegin.Text = "Begin the Quiz"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'lblWelcomeText
        '
        Me.lblWelcomeText.Location = New System.Drawing.Point(12, 52)
        Me.lblWelcomeText.Name = "lblWelcomeText"
        Me.lblWelcomeText.Size = New System.Drawing.Size(413, 66)
        Me.lblWelcomeText.TabIndex = 1
        Me.lblWelcomeText.Text = "Welcome"
        '
        'lblInstructionsText
        '
        Me.lblInstructionsText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsText.Location = New System.Drawing.Point(15, 130)
        Me.lblInstructionsText.Name = "lblInstructionsText"
        Me.lblInstructionsText.Size = New System.Drawing.Size(410, 230)
        Me.lblInstructionsText.TabIndex = 2
        Me.lblInstructionsText.Text = "Instructions"
        '
        'lblTitle2
        '
        Me.lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Location = New System.Drawing.Point(15, 96)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(410, 34)
        Me.lblTitle2.TabIndex = 3
        Me.lblTitle2.Text = "Instructions"
        Me.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(413, 34)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Welcome!"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 408)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.lblInstructionsText)
        Me.Controls.Add(Me.lblWelcomeText)
        Me.Controls.Add(Me.btnBegin)
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to the Quiz"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBegin As System.Windows.Forms.Button
    Friend WithEvents lblWelcomeText As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsText As System.Windows.Forms.Label
    Friend WithEvents lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
