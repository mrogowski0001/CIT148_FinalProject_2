<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuiz
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
        Me.grpCheck = New System.Windows.Forms.GroupBox()
        Me.lblAns8_1 = New System.Windows.Forms.Label()
        Me.chkAns8 = New System.Windows.Forms.CheckBox()
        Me.lblAns7_1 = New System.Windows.Forms.Label()
        Me.chkAns7 = New System.Windows.Forms.CheckBox()
        Me.lblAns1_1 = New System.Windows.Forms.Label()
        Me.lblAns5_1 = New System.Windows.Forms.Label()
        Me.lblAns6_1 = New System.Windows.Forms.Label()
        Me.lblAns2_1 = New System.Windows.Forms.Label()
        Me.lblAns4_1 = New System.Windows.Forms.Label()
        Me.lblAns3_1 = New System.Windows.Forms.Label()
        Me.chkAns1 = New System.Windows.Forms.CheckBox()
        Me.chkAns4 = New System.Windows.Forms.CheckBox()
        Me.chkAns2 = New System.Windows.Forms.CheckBox()
        Me.chkAns5 = New System.Windows.Forms.CheckBox()
        Me.chkAns6 = New System.Windows.Forms.CheckBox()
        Me.chkAns3 = New System.Windows.Forms.CheckBox()
        Me.txtTimeLeft = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpRadio = New System.Windows.Forms.GroupBox()
        Me.lblAns8 = New System.Windows.Forms.Label()
        Me.lblAns7 = New System.Windows.Forms.Label()
        Me.radAns8 = New System.Windows.Forms.RadioButton()
        Me.radAns7 = New System.Windows.Forms.RadioButton()
        Me.lblAns1 = New System.Windows.Forms.Label()
        Me.lblAns5 = New System.Windows.Forms.Label()
        Me.lblAns6 = New System.Windows.Forms.Label()
        Me.lblAns2 = New System.Windows.Forms.Label()
        Me.lblAns4 = New System.Windows.Forms.Label()
        Me.lblAns3 = New System.Windows.Forms.Label()
        Me.radAns6 = New System.Windows.Forms.RadioButton()
        Me.radAns1 = New System.Windows.Forms.RadioButton()
        Me.radAns3 = New System.Windows.Forms.RadioButton()
        Me.radAns4 = New System.Windows.Forms.RadioButton()
        Me.radAns5 = New System.Windows.Forms.RadioButton()
        Me.radAns2 = New System.Windows.Forms.RadioButton()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizDataSet = New FInal_Project.QuizDataSet()
        Me.grpNav = New System.Windows.Forms.GroupBox()
        Me.grpControl = New System.Windows.Forms.GroupBox()
        Me.btnNewQuiz = New System.Windows.Forms.Button()
        Me.QuestionsTableAdapter = New FInal_Project.QuizDataSetTableAdapters.QuestionsTableAdapter()
        Me.txtIncorrectCount = New System.Windows.Forms.TextBox()
        Me.grpCheckedAnswers.SuspendLayout()
        Me.grpCheck.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpRadio.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNav.SuspendLayout()
        Me.grpControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubmit.Location = New System.Drawing.Point(114, 19)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(101, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit Quiz"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(369, 19)
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
        Me.btnNext.Location = New System.Drawing.Point(126, 19)
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
        Me.lblTimeRemaining.Location = New System.Drawing.Point(695, 24)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(72, 13)
        Me.lblTimeRemaining.TabIndex = 22
        Me.lblTimeRemaining.Text = "Time Remain:"
        Me.lblTimeRemaining.Visible = False
        '
        'Timer2
        '
        '
        'btnPrevious
        '
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevious.Location = New System.Drawing.Point(6, 19)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(101, 23)
        Me.btnPrevious.TabIndex = 24
        Me.btnPrevious.Text = "Previous Question"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCheckAnswer.Location = New System.Drawing.Point(6, 19)
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
        Me.grpCheckedAnswers.Location = New System.Drawing.Point(857, 51)
        Me.grpCheckedAnswers.Name = "grpCheckedAnswers"
        Me.grpCheckedAnswers.Size = New System.Drawing.Size(141, 107)
        Me.grpCheckedAnswers.TabIndex = 32
        Me.grpCheckedAnswers.TabStop = False
        Me.grpCheckedAnswers.Text = "Checked Answers"
        '
        'lblIncorrectAnswers
        '
        Me.lblIncorrectAnswers.AutoSize = True
        Me.lblIncorrectAnswers.Location = New System.Drawing.Point(6, 70)
        Me.lblIncorrectAnswers.Name = "lblIncorrectAnswers"
        Me.lblIncorrectAnswers.Size = New System.Drawing.Size(95, 13)
        Me.lblIncorrectAnswers.TabIndex = 2
        Me.lblIncorrectAnswers.Text = "Incorrect Answers:"
        '
        'lblCorrectAnswers
        '
        Me.lblCorrectAnswers.AutoSize = True
        Me.lblCorrectAnswers.Location = New System.Drawing.Point(6, 34)
        Me.lblCorrectAnswers.Name = "lblCorrectAnswers"
        Me.lblCorrectAnswers.Size = New System.Drawing.Size(87, 13)
        Me.lblCorrectAnswers.TabIndex = 0
        Me.lblCorrectAnswers.Text = "Correct Answers:"
        '
        'grpCheck
        '
        Me.grpCheck.BackColor = System.Drawing.Color.Transparent
        Me.grpCheck.Controls.Add(Me.lblAns8_1)
        Me.grpCheck.Controls.Add(Me.chkAns8)
        Me.grpCheck.Controls.Add(Me.lblAns7_1)
        Me.grpCheck.Controls.Add(Me.chkAns7)
        Me.grpCheck.Controls.Add(Me.lblAns1_1)
        Me.grpCheck.Controls.Add(Me.lblAns5_1)
        Me.grpCheck.Controls.Add(Me.lblAns6_1)
        Me.grpCheck.Controls.Add(Me.lblAns2_1)
        Me.grpCheck.Controls.Add(Me.lblAns4_1)
        Me.grpCheck.Controls.Add(Me.lblAns3_1)
        Me.grpCheck.Controls.Add(Me.chkAns1)
        Me.grpCheck.Controls.Add(Me.chkAns4)
        Me.grpCheck.Controls.Add(Me.chkAns2)
        Me.grpCheck.Controls.Add(Me.chkAns5)
        Me.grpCheck.Controls.Add(Me.chkAns6)
        Me.grpCheck.Controls.Add(Me.chkAns3)
        Me.grpCheck.Location = New System.Drawing.Point(1, 12)
        Me.grpCheck.Name = "grpCheck"
        Me.grpCheck.Size = New System.Drawing.Size(824, 435)
        Me.grpCheck.TabIndex = 40
        Me.grpCheck.TabStop = False
        Me.grpCheck.Text = "Select the correct answers below:"
        Me.grpCheck.Visible = False
        '
        'lblAns8_1
        '
        Me.lblAns8_1.AutoSize = True
        Me.lblAns8_1.Location = New System.Drawing.Point(14, 383)
        Me.lblAns8_1.Name = "lblAns8_1"
        Me.lblAns8_1.Size = New System.Drawing.Size(16, 13)
        Me.lblAns8_1.TabIndex = 44
        Me.lblAns8_1.Text = "8."
        '
        'chkAns8
        '
        Me.chkAns8.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns8.Location = New System.Drawing.Point(36, 381)
        Me.chkAns8.Name = "chkAns8"
        Me.chkAns8.Size = New System.Drawing.Size(632, 48)
        Me.chkAns8.TabIndex = 43
        Me.chkAns8.Text = "chkAns8"
        Me.chkAns8.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns8.UseVisualStyleBackColor = True
        Me.chkAns8.Visible = False
        '
        'lblAns7_1
        '
        Me.lblAns7_1.AutoSize = True
        Me.lblAns7_1.Location = New System.Drawing.Point(14, 329)
        Me.lblAns7_1.Name = "lblAns7_1"
        Me.lblAns7_1.Size = New System.Drawing.Size(16, 13)
        Me.lblAns7_1.TabIndex = 42
        Me.lblAns7_1.Text = "7."
        '
        'chkAns7
        '
        Me.chkAns7.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns7.Location = New System.Drawing.Point(36, 327)
        Me.chkAns7.Name = "chkAns7"
        Me.chkAns7.Size = New System.Drawing.Size(632, 48)
        Me.chkAns7.TabIndex = 41
        Me.chkAns7.Text = "chkAns7"
        Me.chkAns7.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns7.UseVisualStyleBackColor = True
        Me.chkAns7.Visible = False
        '
        'lblAns1_1
        '
        Me.lblAns1_1.AutoSize = True
        Me.lblAns1_1.BackColor = System.Drawing.Color.Transparent
        Me.lblAns1_1.Location = New System.Drawing.Point(14, 21)
        Me.lblAns1_1.Name = "lblAns1_1"
        Me.lblAns1_1.Size = New System.Drawing.Size(16, 13)
        Me.lblAns1_1.TabIndex = 35
        Me.lblAns1_1.Text = "1."
        '
        'lblAns5_1
        '
        Me.lblAns5_1.AutoSize = True
        Me.lblAns5_1.Location = New System.Drawing.Point(14, 225)
        Me.lblAns5_1.Name = "lblAns5_1"
        Me.lblAns5_1.Size = New System.Drawing.Size(16, 13)
        Me.lblAns5_1.TabIndex = 39
        Me.lblAns5_1.Text = "5."
        '
        'lblAns6_1
        '
        Me.lblAns6_1.AutoSize = True
        Me.lblAns6_1.Location = New System.Drawing.Point(14, 276)
        Me.lblAns6_1.Name = "lblAns6_1"
        Me.lblAns6_1.Size = New System.Drawing.Size(16, 13)
        Me.lblAns6_1.TabIndex = 40
        Me.lblAns6_1.Text = "6."
        '
        'lblAns2_1
        '
        Me.lblAns2_1.AutoSize = True
        Me.lblAns2_1.Location = New System.Drawing.Point(14, 72)
        Me.lblAns2_1.Name = "lblAns2_1"
        Me.lblAns2_1.Size = New System.Drawing.Size(16, 13)
        Me.lblAns2_1.TabIndex = 36
        Me.lblAns2_1.Text = "2."
        '
        'lblAns4_1
        '
        Me.lblAns4_1.AutoSize = True
        Me.lblAns4_1.Location = New System.Drawing.Point(14, 174)
        Me.lblAns4_1.Name = "lblAns4_1"
        Me.lblAns4_1.Size = New System.Drawing.Size(16, 13)
        Me.lblAns4_1.TabIndex = 38
        Me.lblAns4_1.Text = "4."
        '
        'lblAns3_1
        '
        Me.lblAns3_1.AutoSize = True
        Me.lblAns3_1.Location = New System.Drawing.Point(14, 123)
        Me.lblAns3_1.Name = "lblAns3_1"
        Me.lblAns3_1.Size = New System.Drawing.Size(16, 13)
        Me.lblAns3_1.TabIndex = 37
        Me.lblAns3_1.Text = "3."
        '
        'chkAns1
        '
        Me.chkAns1.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns1.Location = New System.Drawing.Point(36, 19)
        Me.chkAns1.Name = "chkAns1"
        Me.chkAns1.Size = New System.Drawing.Size(632, 48)
        Me.chkAns1.TabIndex = 6
        Me.chkAns1.Text = "chkAns1"
        Me.chkAns1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns1.UseVisualStyleBackColor = True
        Me.chkAns1.Visible = False
        '
        'chkAns4
        '
        Me.chkAns4.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns4.Location = New System.Drawing.Point(36, 172)
        Me.chkAns4.Name = "chkAns4"
        Me.chkAns4.Size = New System.Drawing.Size(632, 48)
        Me.chkAns4.TabIndex = 9
        Me.chkAns4.Text = "chkAns4"
        Me.chkAns4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns4.UseVisualStyleBackColor = True
        Me.chkAns4.Visible = False
        '
        'chkAns2
        '
        Me.chkAns2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns2.Location = New System.Drawing.Point(36, 70)
        Me.chkAns2.Name = "chkAns2"
        Me.chkAns2.Size = New System.Drawing.Size(632, 48)
        Me.chkAns2.TabIndex = 7
        Me.chkAns2.Text = "chkAns2"
        Me.chkAns2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns2.UseVisualStyleBackColor = True
        Me.chkAns2.Visible = False
        '
        'chkAns5
        '
        Me.chkAns5.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns5.Location = New System.Drawing.Point(36, 223)
        Me.chkAns5.Name = "chkAns5"
        Me.chkAns5.Size = New System.Drawing.Size(632, 48)
        Me.chkAns5.TabIndex = 10
        Me.chkAns5.Text = "chkAns5"
        Me.chkAns5.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns5.UseVisualStyleBackColor = True
        Me.chkAns5.Visible = False
        '
        'chkAns6
        '
        Me.chkAns6.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns6.Location = New System.Drawing.Point(36, 274)
        Me.chkAns6.Name = "chkAns6"
        Me.chkAns6.Size = New System.Drawing.Size(632, 48)
        Me.chkAns6.TabIndex = 11
        Me.chkAns6.Text = "chkAns6"
        Me.chkAns6.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns6.UseVisualStyleBackColor = True
        Me.chkAns6.Visible = False
        '
        'chkAns3
        '
        Me.chkAns3.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns3.Location = New System.Drawing.Point(36, 121)
        Me.chkAns3.Name = "chkAns3"
        Me.chkAns3.Size = New System.Drawing.Size(632, 48)
        Me.chkAns3.TabIndex = 8
        Me.chkAns3.Text = "chkAns3"
        Me.chkAns3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkAns3.UseVisualStyleBackColor = True
        Me.chkAns3.Visible = False
        '
        'txtTimeLeft
        '
        Me.txtTimeLeft.BackColor = System.Drawing.SystemColors.Control
        Me.txtTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimeLeft.Location = New System.Drawing.Point(773, 24)
        Me.txtTimeLeft.Name = "txtTimeLeft"
        Me.txtTimeLeft.Size = New System.Drawing.Size(59, 13)
        Me.txtTimeLeft.TabIndex = 23
        Me.txtTimeLeft.Visible = False
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(3, 5)
        Me.lblQuestion.MaximumSize = New System.Drawing.Size(824, 178)
        Me.lblQuestion.MinimumSize = New System.Drawing.Size(824, 16)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(824, 20)
        Me.lblQuestion.TabIndex = 58
        Me.lblQuestion.Text = "Questions"
        Me.lblQuestion.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lblQuestion, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 51)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(837, 577)
        Me.TableLayoutPanel1.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grpRadio)
        Me.Panel1.Controls.Add(Me.grpCheck)
        Me.Panel1.Location = New System.Drawing.Point(3, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 549)
        Me.Panel1.TabIndex = 60
        '
        'grpRadio
        '
        Me.grpRadio.BackColor = System.Drawing.Color.Transparent
        Me.grpRadio.Controls.Add(Me.lblAns8)
        Me.grpRadio.Controls.Add(Me.lblAns7)
        Me.grpRadio.Controls.Add(Me.radAns8)
        Me.grpRadio.Controls.Add(Me.radAns7)
        Me.grpRadio.Controls.Add(Me.lblAns1)
        Me.grpRadio.Controls.Add(Me.lblAns5)
        Me.grpRadio.Controls.Add(Me.lblAns6)
        Me.grpRadio.Controls.Add(Me.lblAns2)
        Me.grpRadio.Controls.Add(Me.lblAns4)
        Me.grpRadio.Controls.Add(Me.lblAns3)
        Me.grpRadio.Controls.Add(Me.radAns6)
        Me.grpRadio.Controls.Add(Me.radAns1)
        Me.grpRadio.Controls.Add(Me.radAns3)
        Me.grpRadio.Controls.Add(Me.radAns4)
        Me.grpRadio.Controls.Add(Me.radAns5)
        Me.grpRadio.Controls.Add(Me.radAns2)
        Me.grpRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpRadio.Location = New System.Drawing.Point(1, 12)
        Me.grpRadio.Name = "grpRadio"
        Me.grpRadio.Padding = New System.Windows.Forms.Padding(10)
        Me.grpRadio.Size = New System.Drawing.Size(824, 435)
        Me.grpRadio.TabIndex = 13
        Me.grpRadio.TabStop = False
        Me.grpRadio.Text = "Select the correct answer below:"
        '
        'lblAns8
        '
        Me.lblAns8.AutoSize = True
        Me.lblAns8.Location = New System.Drawing.Point(15, 383)
        Me.lblAns8.Name = "lblAns8"
        Me.lblAns8.Size = New System.Drawing.Size(16, 13)
        Me.lblAns8.TabIndex = 38
        Me.lblAns8.Text = "8."
        '
        'lblAns7
        '
        Me.lblAns7.AutoSize = True
        Me.lblAns7.Location = New System.Drawing.Point(15, 329)
        Me.lblAns7.Name = "lblAns7"
        Me.lblAns7.Size = New System.Drawing.Size(16, 13)
        Me.lblAns7.TabIndex = 37
        Me.lblAns7.Text = "7."
        '
        'radAns8
        '
        Me.radAns8.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns8.Location = New System.Drawing.Point(37, 381)
        Me.radAns8.Name = "radAns8"
        Me.radAns8.Size = New System.Drawing.Size(632, 48)
        Me.radAns8.TabIndex = 36
        Me.radAns8.TabStop = True
        Me.radAns8.Text = "radAns8"
        Me.radAns8.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns8.UseCompatibleTextRendering = True
        Me.radAns8.UseVisualStyleBackColor = False
        Me.radAns8.Visible = False
        '
        'radAns7
        '
        Me.radAns7.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns7.Location = New System.Drawing.Point(37, 327)
        Me.radAns7.Name = "radAns7"
        Me.radAns7.Size = New System.Drawing.Size(632, 48)
        Me.radAns7.TabIndex = 35
        Me.radAns7.TabStop = True
        Me.radAns7.Text = "radAns7"
        Me.radAns7.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns7.UseCompatibleTextRendering = True
        Me.radAns7.UseVisualStyleBackColor = False
        Me.radAns7.Visible = False
        '
        'lblAns1
        '
        Me.lblAns1.AutoSize = True
        Me.lblAns1.BackColor = System.Drawing.Color.Transparent
        Me.lblAns1.Location = New System.Drawing.Point(15, 21)
        Me.lblAns1.Name = "lblAns1"
        Me.lblAns1.Size = New System.Drawing.Size(16, 13)
        Me.lblAns1.TabIndex = 29
        Me.lblAns1.Text = "1."
        '
        'lblAns5
        '
        Me.lblAns5.AutoSize = True
        Me.lblAns5.Location = New System.Drawing.Point(15, 225)
        Me.lblAns5.Name = "lblAns5"
        Me.lblAns5.Size = New System.Drawing.Size(16, 13)
        Me.lblAns5.TabIndex = 33
        Me.lblAns5.Text = "5."
        '
        'lblAns6
        '
        Me.lblAns6.AutoSize = True
        Me.lblAns6.Location = New System.Drawing.Point(15, 276)
        Me.lblAns6.Name = "lblAns6"
        Me.lblAns6.Size = New System.Drawing.Size(16, 13)
        Me.lblAns6.TabIndex = 34
        Me.lblAns6.Text = "6."
        '
        'lblAns2
        '
        Me.lblAns2.AutoSize = True
        Me.lblAns2.Location = New System.Drawing.Point(15, 72)
        Me.lblAns2.Name = "lblAns2"
        Me.lblAns2.Size = New System.Drawing.Size(16, 13)
        Me.lblAns2.TabIndex = 30
        Me.lblAns2.Text = "2."
        '
        'lblAns4
        '
        Me.lblAns4.AutoSize = True
        Me.lblAns4.Location = New System.Drawing.Point(15, 174)
        Me.lblAns4.Name = "lblAns4"
        Me.lblAns4.Size = New System.Drawing.Size(16, 13)
        Me.lblAns4.TabIndex = 32
        Me.lblAns4.Text = "4."
        '
        'lblAns3
        '
        Me.lblAns3.AutoSize = True
        Me.lblAns3.Location = New System.Drawing.Point(15, 123)
        Me.lblAns3.Name = "lblAns3"
        Me.lblAns3.Size = New System.Drawing.Size(16, 13)
        Me.lblAns3.TabIndex = 31
        Me.lblAns3.Text = "3."
        '
        'radAns6
        '
        Me.radAns6.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns6.Location = New System.Drawing.Point(37, 274)
        Me.radAns6.Name = "radAns6"
        Me.radAns6.Size = New System.Drawing.Size(632, 48)
        Me.radAns6.TabIndex = 5
        Me.radAns6.TabStop = True
        Me.radAns6.Text = "radAns6"
        Me.radAns6.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns6.UseCompatibleTextRendering = True
        Me.radAns6.UseVisualStyleBackColor = False
        Me.radAns6.Visible = False
        '
        'radAns1
        '
        Me.radAns1.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns1.Location = New System.Drawing.Point(37, 19)
        Me.radAns1.Name = "radAns1"
        Me.radAns1.Size = New System.Drawing.Size(632, 48)
        Me.radAns1.TabIndex = 0
        Me.radAns1.TabStop = True
        Me.radAns1.Text = "radAns1"
        Me.radAns1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns1.UseVisualStyleBackColor = True
        Me.radAns1.Visible = False
        '
        'radAns3
        '
        Me.radAns3.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns3.Location = New System.Drawing.Point(37, 121)
        Me.radAns3.Name = "radAns3"
        Me.radAns3.Size = New System.Drawing.Size(632, 48)
        Me.radAns3.TabIndex = 2
        Me.radAns3.TabStop = True
        Me.radAns3.Text = "radAns3"
        Me.radAns3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns3.UseVisualStyleBackColor = True
        Me.radAns3.Visible = False
        '
        'radAns4
        '
        Me.radAns4.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns4.Location = New System.Drawing.Point(37, 172)
        Me.radAns4.Name = "radAns4"
        Me.radAns4.Size = New System.Drawing.Size(632, 48)
        Me.radAns4.TabIndex = 3
        Me.radAns4.TabStop = True
        Me.radAns4.Text = "radAns4"
        Me.radAns4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns4.UseVisualStyleBackColor = True
        Me.radAns4.Visible = False
        '
        'radAns5
        '
        Me.radAns5.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns5.Location = New System.Drawing.Point(37, 223)
        Me.radAns5.Name = "radAns5"
        Me.radAns5.Size = New System.Drawing.Size(632, 48)
        Me.radAns5.TabIndex = 4
        Me.radAns5.TabStop = True
        Me.radAns5.Text = "radAns5"
        Me.radAns5.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns5.UseVisualStyleBackColor = True
        Me.radAns5.Visible = False
        '
        'radAns2
        '
        Me.radAns2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns2.Location = New System.Drawing.Point(37, 70)
        Me.radAns2.Name = "radAns2"
        Me.radAns2.Size = New System.Drawing.Size(632, 48)
        Me.radAns2.TabIndex = 29
        Me.radAns2.TabStop = True
        Me.radAns2.Text = "ranAns2"
        Me.radAns2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radAns2.UseVisualStyleBackColor = True
        Me.radAns2.Visible = False
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
        'grpNav
        '
        Me.grpNav.Controls.Add(Me.btnPrevious)
        Me.grpNav.Controls.Add(Me.btnNext)
        Me.grpNav.Location = New System.Drawing.Point(14, 634)
        Me.grpNav.Name = "grpNav"
        Me.grpNav.Size = New System.Drawing.Size(233, 52)
        Me.grpNav.TabIndex = 63
        Me.grpNav.TabStop = False
        Me.grpNav.Text = "Quiz Navigation:"
        '
        'grpControl
        '
        Me.grpControl.Controls.Add(Me.btnNewQuiz)
        Me.grpControl.Controls.Add(Me.btnCheckAnswer)
        Me.grpControl.Controls.Add(Me.btnExit)
        Me.grpControl.Controls.Add(Me.btnSubmit)
        Me.grpControl.Location = New System.Drawing.Point(365, 634)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Size = New System.Drawing.Size(476, 52)
        Me.grpControl.TabIndex = 64
        Me.grpControl.TabStop = False
        Me.grpControl.Text = "Quiz Control:"
        '
        'btnNewQuiz
        '
        Me.btnNewQuiz.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNewQuiz.Location = New System.Drawing.Point(261, 19)
        Me.btnNewQuiz.Name = "btnNewQuiz"
        Me.btnNewQuiz.Size = New System.Drawing.Size(102, 23)
        Me.btnNewQuiz.TabIndex = 4
        Me.btnNewQuiz.Text = "New Quiz"
        Me.btnNewQuiz.UseVisualStyleBackColor = True
        '
        'QuestionsTableAdapter
        '
        Me.QuestionsTableAdapter.ClearBeforeFill = True
        '
        'txtIncorrectCount
        '
        Me.txtIncorrectCount.Location = New System.Drawing.Point(866, 13)
        Me.txtIncorrectCount.Name = "txtIncorrectCount"
        Me.txtIncorrectCount.Size = New System.Drawing.Size(100, 20)
        Me.txtIncorrectCount.TabIndex = 65
        Me.txtIncorrectCount.Visible = False
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 691)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtIncorrectCount)
        Me.Controls.Add(Me.grpControl)
        Me.Controls.Add(Me.grpNav)
        Me.Controls.Add(Me.grpCheckedAnswers)
        Me.Controls.Add(Me.txtTimeLeft)
        Me.Controls.Add(Me.lblTimeRemaining)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Project Quiz"
        Me.grpCheckedAnswers.ResumeLayout(False)
        Me.grpCheckedAnswers.PerformLayout()
        Me.grpCheck.ResumeLayout(False)
        Me.grpCheck.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.grpRadio.ResumeLayout(False)
        Me.grpRadio.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNav.ResumeLayout(False)
        Me.grpControl.ResumeLayout(False)
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
    Friend WithEvents grpCheck As System.Windows.Forms.GroupBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtTimeLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpRadio As System.Windows.Forms.GroupBox
    Friend WithEvents lblAns1 As System.Windows.Forms.Label
    Friend WithEvents lblAns5 As System.Windows.Forms.Label
    Friend WithEvents lblAns6 As System.Windows.Forms.Label
    Friend WithEvents lblAns2 As System.Windows.Forms.Label
    Friend WithEvents lblAns4 As System.Windows.Forms.Label
    Friend WithEvents lblAns3 As System.Windows.Forms.Label
    Friend WithEvents chkAns3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAns6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAns1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAns5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAns2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAns4 As System.Windows.Forms.CheckBox
    Friend WithEvents radAns6 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns1 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns3 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns4 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns5 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns2 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAns1_1 As System.Windows.Forms.Label
    Friend WithEvents lblAns5_1 As System.Windows.Forms.Label
    Friend WithEvents lblAns6_1 As System.Windows.Forms.Label
    Friend WithEvents lblAns2_1 As System.Windows.Forms.Label
    Friend WithEvents lblAns4_1 As System.Windows.Forms.Label
    Friend WithEvents lblAns3_1 As System.Windows.Forms.Label
    Friend WithEvents radAns7 As System.Windows.Forms.RadioButton
    Friend WithEvents lblAns8_1 As System.Windows.Forms.Label
    Friend WithEvents chkAns8 As System.Windows.Forms.CheckBox
    Friend WithEvents lblAns7_1 As System.Windows.Forms.Label
    Friend WithEvents chkAns7 As System.Windows.Forms.CheckBox
    Friend WithEvents lblAns8 As System.Windows.Forms.Label
    Friend WithEvents lblAns7 As System.Windows.Forms.Label
    Friend WithEvents radAns8 As System.Windows.Forms.RadioButton
    Friend WithEvents grpNav As System.Windows.Forms.GroupBox
    Friend WithEvents grpControl As System.Windows.Forms.GroupBox
    Friend WithEvents btnNewQuiz As System.Windows.Forms.Button
    Friend WithEvents QuizDataSet As FInal_Project.QuizDataSet
    Friend WithEvents QuestionsTableAdapter As FInal_Project.QuizDataSetTableAdapters.QuestionsTableAdapter
    Friend WithEvents txtIncorrectCount As System.Windows.Forms.TextBox
End Class
