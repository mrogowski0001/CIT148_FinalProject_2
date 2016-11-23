<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChooseChapter
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
        Me.lstChapters = New System.Windows.Forms.ListBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.QuizDataSet = New FInal_Project.QuizDataSet()
        Me.QuestionsTableAdapter = New FInal_Project.QuizDataSetTableAdapters.QuestionsTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstChapters
        '
        Me.lstChapters.FormattingEnabled = True
        Me.lstChapters.Location = New System.Drawing.Point(12, 132)
        Me.lstChapters.Name = "lstChapters"
        Me.lstChapters.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstChapters.Size = New System.Drawing.Size(181, 147)
        Me.lstChapters.TabIndex = 0
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Questions"
        Me.BindingSource1.DataSource = Me.QuizDataSet
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(199, 132)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 43)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Selected to Quiz"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(307, 181)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 43)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove Selected from Quiz"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(307, 132)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 43)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Remove All from Quiz"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(199, 248)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(208, 31)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start Quiz"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnAllQuestions
        '
        Me.btnAllQuestions.Location = New System.Drawing.Point(199, 181)
        Me.btnAllQuestions.Name = "btnAllQuestions"
        Me.btnAllQuestions.Size = New System.Drawing.Size(100, 43)
        Me.btnAllQuestions.TabIndex = 9
        Me.btnAllQuestions.Text = "Add All to Quiz"
        Me.btnAllQuestions.UseVisualStyleBackColor = True
        '
        'lstSelected
        '
        Me.lstSelected.FormattingEnabled = True
        Me.lstSelected.Location = New System.Drawing.Point(413, 132)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSelected.Size = New System.Drawing.Size(181, 147)
        Me.lstSelected.TabIndex = 11
        '
        'lblAvailableChapters
        '
        Me.lblAvailableChapters.AutoSize = True
        Me.lblAvailableChapters.Location = New System.Drawing.Point(12, 116)
        Me.lblAvailableChapters.Name = "lblAvailableChapters"
        Me.lblAvailableChapters.Size = New System.Drawing.Size(98, 13)
        Me.lblAvailableChapters.TabIndex = 12
        Me.lblAvailableChapters.Text = "Available Chapters:"
        '
        'lblSelectedChapters
        '
        Me.lblSelectedChapters.AutoSize = True
        Me.lblSelectedChapters.Location = New System.Drawing.Point(413, 116)
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
        'QuizDataSet
        '
        Me.QuizDataSet.DataSetName = "QuizDataSet"
        Me.QuizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuestionsTableAdapter
        '
        Me.QuestionsTableAdapter.ClearBeforeFill = True
        '
        'frmChooseChapter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 331)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstChapters As System.Windows.Forms.ListBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
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
    Friend WithEvents QuizDataSet As FInal_Project.QuizDataSet
    Friend WithEvents QuestionsTableAdapter As FInal_Project.QuizDataSetTableAdapters.QuestionsTableAdapter
End Class
