<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnCheckAnswer = New System.Windows.Forms.Button()
        Me.grpCheckedAnswers = New System.Windows.Forms.GroupBox()
        Me.lblIncorrectAnswers = New System.Windows.Forms.Label()
        Me.lblCorrectAnswers = New System.Windows.Forms.Label()
        Me.grpRadio = New System.Windows.Forms.GroupBox()
        Me.radAns2 = New System.Windows.Forms.RadioButton()
        Me.radAns6 = New System.Windows.Forms.RadioButton()
        Me.radAns1 = New System.Windows.Forms.RadioButton()
        Me.radAns3 = New System.Windows.Forms.RadioButton()
        Me.radAns4 = New System.Windows.Forms.RadioButton()
        Me.radAns5 = New System.Windows.Forms.RadioButton()
        Me.lblAns6 = New System.Windows.Forms.Label()
        Me.lblAns5 = New System.Windows.Forms.Label()
        Me.lblAns4 = New System.Windows.Forms.Label()
        Me.lblAns3 = New System.Windows.Forms.Label()
        Me.lblAns2 = New System.Windows.Forms.Label()
        Me.lblAns1 = New System.Windows.Forms.Label()
        Me.chkAns6 = New System.Windows.Forms.CheckBox()
        Me.chkAns5 = New System.Windows.Forms.CheckBox()
        Me.chkAns4 = New System.Windows.Forms.CheckBox()
        Me.chkAns3 = New System.Windows.Forms.CheckBox()
        Me.chkAns2 = New System.Windows.Forms.CheckBox()
        Me.chkAns1 = New System.Windows.Forms.CheckBox()
        Me.grpCheck = New System.Windows.Forms.GroupBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTimeLeft = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.QuizDataSet = New FInal_Project.QuizDataSet()
        Me.QuestionsTableAdapter = New FInal_Project.QuizDataSetTableAdapters.QuestionsTableAdapter()
        Me.grpCheckedAnswers.SuspendLayout()
        Me.grpRadio.SuspendLayout()
        Me.grpCheck.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubmit.Location = New System.Drawing.Point(415, 441)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(101, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit Quiz"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(609, 441)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit Quiz"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(11, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(183, 24)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Question"
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Location = New System.Drawing.Point(119, 441)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next Question"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.AutoSize = True
        Me.lblTimeRemaining.Location = New System.Drawing.Point(573, 24)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(72, 13)
        Me.lblTimeRemaining.TabIndex = 22
        Me.lblTimeRemaining.Text = "Time Remain:"
        '
        'Timer2
        '
        '
        'btnPrevious
        '
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevious.Location = New System.Drawing.Point(12, 441)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(101, 23)
        Me.btnPrevious.TabIndex = 24
        Me.btnPrevious.Text = "Previous Question"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCheckAnswer.Location = New System.Drawing.Point(307, 441)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(102, 23)
        Me.btnCheckAnswer.TabIndex = 1
        Me.btnCheckAnswer.Text = "Check Answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = True
        '
        'grpCheckedAnswers
        '
        Me.grpCheckedAnswers.Controls.Add(Me.lblIncorrectAnswers)
        Me.grpCheckedAnswers.Controls.Add(Me.lblCorrectAnswers)
        Me.grpCheckedAnswers.Location = New System.Drawing.Point(12, 472)
        Me.grpCheckedAnswers.Name = "grpCheckedAnswers"
        Me.grpCheckedAnswers.Size = New System.Drawing.Size(703, 46)
        Me.grpCheckedAnswers.TabIndex = 32
        Me.grpCheckedAnswers.TabStop = False
        Me.grpCheckedAnswers.Text = "Checked Answers"
        '
        'lblIncorrectAnswers
        '
        Me.lblIncorrectAnswers.AutoSize = True
        Me.lblIncorrectAnswers.Location = New System.Drawing.Point(574, 21)
        Me.lblIncorrectAnswers.Name = "lblIncorrectAnswers"
        Me.lblIncorrectAnswers.Size = New System.Drawing.Size(95, 13)
        Me.lblIncorrectAnswers.TabIndex = 2
        Me.lblIncorrectAnswers.Text = "Incorrect Answers:"
        '
        'lblCorrectAnswers
        '
        Me.lblCorrectAnswers.AutoSize = True
        Me.lblCorrectAnswers.Location = New System.Drawing.Point(7, 21)
        Me.lblCorrectAnswers.Name = "lblCorrectAnswers"
        Me.lblCorrectAnswers.Size = New System.Drawing.Size(87, 13)
        Me.lblCorrectAnswers.TabIndex = 0
        Me.lblCorrectAnswers.Text = "Correct Answers:"
        '
        'grpRadio
        '
        Me.grpRadio.BackColor = System.Drawing.Color.Transparent
        Me.grpRadio.Controls.Add(Me.radAns2)
        Me.grpRadio.Controls.Add(Me.radAns6)
        Me.grpRadio.Controls.Add(Me.radAns1)
        Me.grpRadio.Controls.Add(Me.radAns3)
        Me.grpRadio.Controls.Add(Me.radAns4)
        Me.grpRadio.Controls.Add(Me.radAns5)
        Me.grpRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpRadio.Location = New System.Drawing.Point(12, 109)
        Me.grpRadio.Name = "grpRadio"
        Me.grpRadio.Padding = New System.Windows.Forms.Padding(0)
        Me.grpRadio.Size = New System.Drawing.Size(703, 320)
        Me.grpRadio.TabIndex = 13
        Me.grpRadio.TabStop = False
        Me.grpRadio.Text = "Select an answer below:"
        Me.grpRadio.Visible = False
        '
        'radAns2
        '
        Me.radAns2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns2.Location = New System.Drawing.Point(37, 70)
        Me.radAns2.Name = "radAns2"
        Me.radAns2.Size = New System.Drawing.Size(632, 32)
        Me.radAns2.TabIndex = 29
        Me.radAns2.TabStop = True
        Me.radAns2.Text = "ranAns2"
        Me.radAns2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns2.UseVisualStyleBackColor = True
        '
        'radAns6
        '
        Me.radAns6.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns6.Location = New System.Drawing.Point(37, 274)
        Me.radAns6.Name = "radAns6"
        Me.radAns6.Size = New System.Drawing.Size(632, 32)
        Me.radAns6.TabIndex = 5
        Me.radAns6.TabStop = True
        Me.radAns6.Text = "radAns6"
        Me.radAns6.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns6.UseCompatibleTextRendering = True
        Me.radAns6.UseVisualStyleBackColor = False
        '
        'radAns1
        '
        Me.radAns1.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns1.Location = New System.Drawing.Point(37, 19)
        Me.radAns1.Name = "radAns1"
        Me.radAns1.Size = New System.Drawing.Size(632, 32)
        Me.radAns1.TabIndex = 0
        Me.radAns1.TabStop = True
        Me.radAns1.Text = "radAns1"
        Me.radAns1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns1.UseVisualStyleBackColor = True
        '
        'radAns3
        '
        Me.radAns3.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns3.Location = New System.Drawing.Point(37, 121)
        Me.radAns3.Name = "radAns3"
        Me.radAns3.Size = New System.Drawing.Size(632, 32)
        Me.radAns3.TabIndex = 2
        Me.radAns3.TabStop = True
        Me.radAns3.Text = "radAns3"
        Me.radAns3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns3.UseVisualStyleBackColor = True
        '
        'radAns4
        '
        Me.radAns4.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns4.Location = New System.Drawing.Point(37, 172)
        Me.radAns4.Name = "radAns4"
        Me.radAns4.Size = New System.Drawing.Size(632, 32)
        Me.radAns4.TabIndex = 3
        Me.radAns4.TabStop = True
        Me.radAns4.Text = "radAns4"
        Me.radAns4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns4.UseVisualStyleBackColor = True
        '
        'radAns5
        '
        Me.radAns5.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns5.Location = New System.Drawing.Point(37, 223)
        Me.radAns5.Name = "radAns5"
        Me.radAns5.Size = New System.Drawing.Size(632, 32)
        Me.radAns5.TabIndex = 4
        Me.radAns5.TabStop = True
        Me.radAns5.Text = "radAns5"
        Me.radAns5.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns5.UseVisualStyleBackColor = True
        '
        'lblAns6
        '
        Me.lblAns6.AutoSize = True
        Me.lblAns6.Location = New System.Drawing.Point(13, 276)
        Me.lblAns6.Name = "lblAns6"
        Me.lblAns6.Size = New System.Drawing.Size(16, 13)
        Me.lblAns6.TabIndex = 34
        Me.lblAns6.Text = "6."
        '
        'lblAns5
        '
        Me.lblAns5.AutoSize = True
        Me.lblAns5.Location = New System.Drawing.Point(13, 225)
        Me.lblAns5.Name = "lblAns5"
        Me.lblAns5.Size = New System.Drawing.Size(16, 13)
        Me.lblAns5.TabIndex = 33
        Me.lblAns5.Text = "5."
        '
        'lblAns4
        '
        Me.lblAns4.AutoSize = True
        Me.lblAns4.Location = New System.Drawing.Point(13, 174)
        Me.lblAns4.Name = "lblAns4"
        Me.lblAns4.Size = New System.Drawing.Size(16, 13)
        Me.lblAns4.TabIndex = 32
        Me.lblAns4.Text = "4."
        '
        'lblAns3
        '
        Me.lblAns3.AutoSize = True
        Me.lblAns3.Location = New System.Drawing.Point(13, 123)
        Me.lblAns3.Name = "lblAns3"
        Me.lblAns3.Size = New System.Drawing.Size(16, 13)
        Me.lblAns3.TabIndex = 31
        Me.lblAns3.Text = "3."
        '
        'lblAns2
        '
        Me.lblAns2.AutoSize = True
        Me.lblAns2.Location = New System.Drawing.Point(13, 72)
        Me.lblAns2.Name = "lblAns2"
        Me.lblAns2.Size = New System.Drawing.Size(16, 13)
        Me.lblAns2.TabIndex = 30
        Me.lblAns2.Text = "2."
        '
        'lblAns1
        '
        Me.lblAns1.AutoSize = True
        Me.lblAns1.BackColor = System.Drawing.Color.Transparent
        Me.lblAns1.Location = New System.Drawing.Point(13, 20)
        Me.lblAns1.Name = "lblAns1"
        Me.lblAns1.Size = New System.Drawing.Size(16, 13)
        Me.lblAns1.TabIndex = 29
        Me.lblAns1.Text = "1."
        '
        'chkAns6
        '
        Me.chkAns6.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns6.Location = New System.Drawing.Point(37, 275)
        Me.chkAns6.Name = "chkAns6"
        Me.chkAns6.Size = New System.Drawing.Size(632, 32)
        Me.chkAns6.TabIndex = 11
        Me.chkAns6.Text = "chkAns6"
        Me.chkAns6.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns6.UseVisualStyleBackColor = True
        '
        'chkAns5
        '
        Me.chkAns5.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns5.Location = New System.Drawing.Point(37, 224)
        Me.chkAns5.Name = "chkAns5"
        Me.chkAns5.Size = New System.Drawing.Size(632, 32)
        Me.chkAns5.TabIndex = 10
        Me.chkAns5.Text = "chkAns5"
        Me.chkAns5.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns5.UseVisualStyleBackColor = True
        '
        'chkAns4
        '
        Me.chkAns4.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns4.Location = New System.Drawing.Point(37, 173)
        Me.chkAns4.Name = "chkAns4"
        Me.chkAns4.Size = New System.Drawing.Size(632, 32)
        Me.chkAns4.TabIndex = 9
        Me.chkAns4.Text = "chkAns4"
        Me.chkAns4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns4.UseVisualStyleBackColor = True
        '
        'chkAns3
        '
        Me.chkAns3.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns3.Location = New System.Drawing.Point(37, 122)
        Me.chkAns3.Name = "chkAns3"
        Me.chkAns3.Size = New System.Drawing.Size(632, 32)
        Me.chkAns3.TabIndex = 8
        Me.chkAns3.Text = "chkAns3"
        Me.chkAns3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns3.UseVisualStyleBackColor = True
        '
        'chkAns2
        '
        Me.chkAns2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns2.Location = New System.Drawing.Point(37, 71)
        Me.chkAns2.Name = "chkAns2"
        Me.chkAns2.Size = New System.Drawing.Size(632, 32)
        Me.chkAns2.TabIndex = 7
        Me.chkAns2.Text = "chkAns2"
        Me.chkAns2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns2.UseVisualStyleBackColor = True
        '
        'chkAns1
        '
        Me.chkAns1.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns1.Location = New System.Drawing.Point(37, 20)
        Me.chkAns1.Name = "chkAns1"
        Me.chkAns1.Size = New System.Drawing.Size(632, 32)
        Me.chkAns1.TabIndex = 6
        Me.chkAns1.Text = "chkAns1"
        Me.chkAns1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns1.UseVisualStyleBackColor = True
        '
        'grpCheck
        '
        Me.grpCheck.BackColor = System.Drawing.Color.Transparent
        Me.grpCheck.Controls.Add(Me.lblAns1)
        Me.grpCheck.Controls.Add(Me.lblAns5)
        Me.grpCheck.Controls.Add(Me.lblAns6)
        Me.grpCheck.Controls.Add(Me.chkAns3)
        Me.grpCheck.Controls.Add(Me.chkAns6)
        Me.grpCheck.Controls.Add(Me.lblAns4)
        Me.grpCheck.Controls.Add(Me.chkAns1)
        Me.grpCheck.Controls.Add(Me.lblAns3)
        Me.grpCheck.Controls.Add(Me.chkAns5)
        Me.grpCheck.Controls.Add(Me.lblAns2)
        Me.grpCheck.Controls.Add(Me.chkAns2)
        Me.grpCheck.Controls.Add(Me.chkAns4)
        Me.grpCheck.Location = New System.Drawing.Point(11, 109)
        Me.grpCheck.Name = "grpCheck"
        Me.grpCheck.Size = New System.Drawing.Size(704, 320)
        Me.grpCheck.TabIndex = 40
        Me.grpCheck.TabStop = False
        Me.grpCheck.Text = "Select correct answers below:"
        Me.grpCheck.Visible = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Questions"
        Me.BindingSource1.DataSource = Me.QuizDataSet
        '
        'txtTimeLeft
        '
        Me.txtTimeLeft.BackColor = System.Drawing.SystemColors.Control
        Me.txtTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimeLeft.Location = New System.Drawing.Point(651, 24)
        Me.txtTimeLeft.Name = "txtTimeLeft"
        Me.txtTimeLeft.Size = New System.Drawing.Size(59, 13)
        Me.txtTimeLeft.TabIndex = 23
        '
        'lblQuestion
        '
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(11, 48)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(704, 55)
        Me.lblQuestion.TabIndex = 58
        Me.lblQuestion.Text = "Questions"
        Me.lblQuestion.UseCompatibleTextRendering = True
        '
        'QuizDataSet
        '
        Me.QuizDataSet.DataSetName = "QuizDataSet"
        Me.QuizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuestionsTableAdapter
        '
        Me.QuestionsTableAdapter.ClearBeforeFill = True
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 531)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.grpCheckedAnswers)
        Me.Controls.Add(Me.btnCheckAnswer)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtTimeLeft)
        Me.Controls.Add(Me.lblTimeRemaining)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpCheck)
        Me.Controls.Add(Me.grpRadio)
        Me.Name = "frmQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Project Quiz"
        Me.grpCheckedAnswers.ResumeLayout(False)
        Me.grpCheckedAnswers.PerformLayout()
        Me.grpRadio.ResumeLayout(False)
        Me.grpCheck.ResumeLayout(False)
        Me.grpCheck.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimeRemaining As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnCheckAnswer As System.Windows.Forms.Button
    Friend WithEvents grpCheckedAnswers As System.Windows.Forms.GroupBox
    Friend WithEvents lblCorrectAnswers As System.Windows.Forms.Label
    Friend WithEvents lblIncorrectAnswers As System.Windows.Forms.Label
    Friend WithEvents grpRadio As System.Windows.Forms.GroupBox
    Friend WithEvents radAns6 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns5 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns4 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns3 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns1 As System.Windows.Forms.RadioButton
    Friend WithEvents chkAns6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAns5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAns4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAns3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAns2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAns1 As System.Windows.Forms.CheckBox
    Friend WithEvents grpCheck As System.Windows.Forms.GroupBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtTimeLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblAns6 As System.Windows.Forms.Label
    Friend WithEvents lblAns5 As System.Windows.Forms.Label
    Friend WithEvents lblAns4 As System.Windows.Forms.Label
    Friend WithEvents lblAns3 As System.Windows.Forms.Label
    Friend WithEvents lblAns2 As System.Windows.Forms.Label
    Friend WithEvents lblAns1 As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents radAns2 As System.Windows.Forms.RadioButton
    Friend WithEvents QuizDataSet As FInal_Project.QuizDataSet
    Friend WithEvents QuestionsTableAdapter As FInal_Project.QuizDataSetTableAdapters.QuestionsTableAdapter
End Class
