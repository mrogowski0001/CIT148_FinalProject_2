<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChooseChapter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstChapters = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnAllQuestions = New System.Windows.Forms.Button()
        Me.lstSelected = New System.Windows.Forms.ListBox()
        Me.lblAvailableChapters = New System.Windows.Forms.Label()
        Me.lblSelectedChapters = New System.Windows.Forms.Label()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizDataSet = New FInal_Project.QuizDataSet()
        Me.chkIncorrectOnly = New System.Windows.Forms.CheckBox()
        Me.lblNumberOfIncorrect = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.chkTimerEnable = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkRandomQuestions = New System.Windows.Forms.CheckBox()
        Me.QuestionsTableAdapter = New FInal_Project.QuizDataSetTableAdapters.QuestionsTableAdapter()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstChapters
        '
        Me.lstChapters.FormattingEnabled = True
        Me.lstChapters.Location = New System.Drawing.Point(12, 142)
        Me.lstChapters.Name = "lstChapters"
        Me.lstChapters.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstChapters.Size = New System.Drawing.Size(181, 147)
        Me.lstChapters.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(199, 142)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 43)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Selected to Quiz"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(307, 142)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 43)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove Selected from Quiz"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(307, 209)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 43)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Remove All from Quiz"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(199, 258)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(208, 31)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start Quiz"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnAllQuestions
        '
        Me.btnAllQuestions.Location = New System.Drawing.Point(199, 209)
        Me.btnAllQuestions.Name = "btnAllQuestions"
        Me.btnAllQuestions.Size = New System.Drawing.Size(100, 43)
        Me.btnAllQuestions.TabIndex = 9
        Me.btnAllQuestions.Text = "Add All to Quiz"
        Me.btnAllQuestions.UseVisualStyleBackColor = True
        '
        'lstSelected
        '
        Me.lstSelected.FormattingEnabled = True
        Me.lstSelected.Location = New System.Drawing.Point(413, 142)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSelected.Size = New System.Drawing.Size(181, 147)
        Me.lstSelected.TabIndex = 11
        '
        'lblAvailableChapters
        '
        Me.lblAvailableChapters.AutoSize = True
        Me.lblAvailableChapters.Location = New System.Drawing.Point(12, 126)
        Me.lblAvailableChapters.Name = "lblAvailableChapters"
        Me.lblAvailableChapters.Size = New System.Drawing.Size(98, 13)
        Me.lblAvailableChapters.TabIndex = 12
        Me.lblAvailableChapters.Text = "Available Chapters:"
        '
        'lblSelectedChapters
        '
        Me.lblSelectedChapters.AutoSize = True
        Me.lblSelectedChapters.Location = New System.Drawing.Point(413, 126)
        Me.lblSelectedChapters.Name = "lblSelectedChapters"
        Me.lblSelectedChapters.Size = New System.Drawing.Size(97, 13)
        Me.lblSelectedChapters.TabIndex = 13
        Me.lblSelectedChapters.Text = "Selected Chapters:"
        '
        'lblInstruction
        '
        Me.lblInstruction.Location = New System.Drawing.Point(15, 41)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(579, 66)
        Me.lblInstruction.TabIndex = 14
        Me.lblInstruction.Text = "Instructions:"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(582, 26)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Chapter Selection"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Questions"
        Me.BindingSource1.DataSource = Me.QuizDataSet
        '
        'QuizDataSet
        '
        Me.QuizDataSet.DataSetName = "QuizDataSet"
        Me.QuizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkIncorrectOnly
        '
        Me.chkIncorrectOnly.AutoSize = True
        Me.chkIncorrectOnly.Location = New System.Drawing.Point(12, 313)
        Me.chkIncorrectOnly.Name = "chkIncorrectOnly"
        Me.chkIncorrectOnly.Size = New System.Drawing.Size(301, 17)
        Me.chkIncorrectOnly.TabIndex = 16
        Me.chkIncorrectOnly.Text = "Select only questions that have been answered incorrectly"
        Me.chkIncorrectOnly.UseVisualStyleBackColor = True
        '
        'lblNumberOfIncorrect
        '
        Me.lblNumberOfIncorrect.AutoSize = True
        Me.lblNumberOfIncorrect.Location = New System.Drawing.Point(363, 314)
        Me.lblNumberOfIncorrect.Name = "lblNumberOfIncorrect"
        Me.lblNumberOfIncorrect.Size = New System.Drawing.Size(72, 13)
        Me.lblNumberOfIncorrect.TabIndex = 18
        Me.lblNumberOfIncorrect.Text = "or more times."
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(319, 312)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(38, 20)
        Me.NumericUpDown1.TabIndex = 20
        '
        'chkTimerEnable
        '
        Me.chkTimerEnable.AutoSize = True
        Me.chkTimerEnable.Location = New System.Drawing.Point(12, 336)
        Me.chkTimerEnable.Name = "chkTimerEnable"
        Me.chkTimerEnable.Size = New System.Drawing.Size(87, 17)
        Me.chkTimerEnable.TabIndex = 21
        Me.chkTimerEnable.Text = "Enable timer:"
        Me.chkTimerEnable.UseVisualStyleBackColor = True
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown2.Location = New System.Drawing.Point(105, 335)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(38, 20)
        Me.NumericUpDown2.TabIndex = 22
        Me.NumericUpDown2.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Seconds per question."
        '
        'chkRandomQuestions
        '
        Me.chkRandomQuestions.AutoSize = True
        Me.chkRandomQuestions.Location = New System.Drawing.Point(12, 359)
        Me.chkRandomQuestions.Name = "chkRandomQuestions"
        Me.chkRandomQuestions.Size = New System.Drawing.Size(129, 17)
        Me.chkRandomQuestions.TabIndex = 25
        Me.chkRandomQuestions.Text = "Randomize Questions"
        Me.chkRandomQuestions.UseVisualStyleBackColor = True
        '
        'QuestionsTableAdapter
        '
        Me.QuestionsTableAdapter.ClearBeforeFill = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(543, 359)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(51, 23)
        Me.BtnExit.TabIndex = 26
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'frmChooseChapter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 394)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.chkRandomQuestions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.chkTimerEnable)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lblNumberOfIncorrect)
        Me.Controls.Add(Me.chkIncorrectOnly)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.lblSelectedChapters)
        Me.Controls.Add(Me.lblAvailableChapters)
        Me.Controls.Add(Me.lstSelected)
        Me.Controls.Add(Me.btnAllQuestions)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstChapters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmChooseChapter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chapter Selection"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstChapters As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnAllQuestions As System.Windows.Forms.Button
    Friend WithEvents lstSelected As System.Windows.Forms.ListBox
    Friend WithEvents lblAvailableChapters As System.Windows.Forms.Label
    Friend WithEvents lblSelectedChapters As System.Windows.Forms.Label
    Friend WithEvents lblInstruction As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents chkIncorrectOnly As System.Windows.Forms.CheckBox
    Friend WithEvents lblNumberOfIncorrect As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkTimerEnable As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkRandomQuestions As System.Windows.Forms.CheckBox
    Friend WithEvents QuizDataSet As FInal_Project.QuizDataSet
    Friend WithEvents QuestionsTableAdapter As FInal_Project.QuizDataSetTableAdapters.QuestionsTableAdapter
    Friend WithEvents BtnExit As System.Windows.Forms.Button
End Class
