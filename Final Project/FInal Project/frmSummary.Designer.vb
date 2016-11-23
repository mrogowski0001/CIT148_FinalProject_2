<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.lstSummary = New System.Windows.Forms.ListBox()
        Me.lblSummartText = New System.Windows.Forms.Label()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.btnExitQuiz = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSummary
        '
        Me.lstSummary.FormattingEnabled = True
        Me.lstSummary.Location = New System.Drawing.Point(12, 131)
        Me.lstSummary.Name = "lstSummary"
        Me.lstSummary.Size = New System.Drawing.Size(558, 251)
        Me.lstSummary.TabIndex = 0
        '
        'lblSummartText
        '
        Me.lblSummartText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummartText.Location = New System.Drawing.Point(12, 59)
        Me.lblSummartText.Name = "lblSummartText"
        Me.lblSummartText.Size = New System.Drawing.Size(558, 69)
        Me.lblSummartText.TabIndex = 1
        Me.lblSummartText.Text = "Summary"
        '
        'lblTitle1
        '
        Me.lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.Location = New System.Drawing.Point(12, 13)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(558, 23)
        Me.lblTitle1.TabIndex = 2
        Me.lblTitle1.Text = "Title"
        Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle2
        '
        Me.lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Location = New System.Drawing.Point(12, 36)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(558, 23)
        Me.lblTitle2.TabIndex = 3
        Me.lblTitle2.Text = "Title"
        Me.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExitQuiz
        '
        Me.btnExitQuiz.Location = New System.Drawing.Point(260, 401)
        Me.btnExitQuiz.Name = "btnExitQuiz"
        Me.btnExitQuiz.Size = New System.Drawing.Size(75, 23)
        Me.btnExitQuiz.TabIndex = 4
        Me.btnExitQuiz.Text = "Exit Quiz"
        Me.btnExitQuiz.UseVisualStyleBackColor = True
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExitQuiz)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.lblTitle1)
        Me.Controls.Add(Me.lblSummartText)
        Me.Controls.Add(Me.lstSummary)
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSummary As System.Windows.Forms.ListBox
    Friend WithEvents lblSummartText As System.Windows.Forms.Label
    Public WithEvents lblTitle1 As System.Windows.Forms.Label
    Public WithEvents lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents btnExitQuiz As System.Windows.Forms.Button
End Class
