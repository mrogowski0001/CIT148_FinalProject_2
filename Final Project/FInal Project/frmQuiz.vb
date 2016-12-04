Imports System.Data.OleDb
Public Class frmQuiz
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub frmQuiz_Load() Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuizDataSet.Questions' table. You can move, or remove it, as needed.
        Me.QuestionsTableAdapter.Fill(Me.QuizDataSet.Questions)
        'TODO: This line of code loads data into the 'QuizDataSet.Questions' table. You can move, or remove it, as needed.
        Me.QuestionsTableAdapter.Fill(Me.QuizDataSet.Questions)

        'Query the number of questions in the database 
        totalQuestions = QueryNumQuestion()

        'Set the time limit for the quiz
        timeLeft = (totalQuestions * timePerQuestion)                    'Set time to 60 secones per question
        arraySize = (totalQuestions - 1)                    'Set the size of the arrays based on total number of questions

        'ReDim arrays to resize them to the total number of questions
        ReDim allQuestions(arraySize)
        ReDim gradedAnswers(arraySize)
        ReDim answerChecked(arraySize)
        ReDim questionsAnswered(arraySize)
        ReDim rad1Check(arraySize)
        ReDim rad2Check(arraySize)
        ReDim rad3Check(arraySize)
        ReDim rad4Check(arraySize)
        ReDim rad5Check(arraySize)
        ReDim rad6Check(arraySize)
        ReDim rad7Check(arraySize)
        ReDim rad8Check(arraySize)
        ReDim qIDNums(arraySize)
        ReDim selectedAnswersString(arraySize)

        'sencne the ID number may not equal the position it is queried because it is needed to determine the selection of answers
        'and the how many answers there are as well as determining the correct answer(s).
        'Gets the ID number for each question
        QueryQuestionID()

        'Positio is the current question of the total question. May not be the same as the question ID
        position = 1                                     'Set positipn to 1 for first question

        'Query for all questions in the tables for use in the summary
        For i As Integer = 0 To arraySize
            cq = qIDNums(i)
            allQuestions(i) = QueryQuestion(cq)
        Next

        position = 1
        'TextBox1.Text = arraySize.ToString
        For i As Integer = 0 To arraySize

            'Set all answers to not graded
            gradedAnswers(i) = "N/A"

            'Set radio button checked status for all questions to false
            rad1Check(i) = False
            rad2Check(i) = False
            rad3Check(i) = False
            rad4Check(i) = False
            rad5Check(i) = False
            rad6Check(i) = False

            'Set all answers checked and questions answered to false because no questions have been answered yet
            answerChecked(i) = False
            questionsAnswered(i) = 0
        Next

        btnPrevious.Enabled = False             'Set the back button to disabled because this is the first question
        Timer1.Interval = 1000                  'Set the time interval of the countdown timer to 1000 milliseconds.
        Timer1.Enabled = timerEnabled           'Enable the countdown timer to start counting down when the quiz begns.
        Timer2.Interval = 500                   'Set the blink timer to 500 milliseconds (1/2 second) so the countdown timer will blink on and off every second.
        Timer2.Enabled = timerEnabled           'Disable timer 2, this timer will be enabled in timer 1 when the countdown reaches 60 seconds.

        If timerEnabled = True Then
            lblTimeRemaining.Visible = True
            txtTimeLeft.Visible = True
        Else
            lblTimeRemaining.Visible = False
            txtTimeLeft.Visible = False
        End If
        Randomize_Questions()

        'Sets the title based on the first question 
        lblTitle.Text = ("Question " & position & " of " & totalQuestions & ":")

        'Sets the question text based on the first question        
        position = 1
        cq = qIDNums(position - 1)

        'Dim testText As String = "Windows Deployment Services (WDS) is a software platform and technology that allows you to perform which function?"
        lblQuestion.Text = QueryQuestion(cq)

        'Set all radio buttons and check boxes to stored values if applicable
        multiSelect = QueryMultiSelect(cq)

        'Set the visibility of grpBoxes based on the multiselect query
        If multiSelect = True Then
            grpRadio.Visible = False
            grpCheck.Visible = True
        Else
            grpRadio.Visible = True
            grpCheck.Visible = False
        End If

        'Sets the radio button answers text based on the first question 
        SetCurrentAnswers()

        'Sets the correct answer based on the current question


        'Sets the text if the Check Answer button is clicked. 
        CorrectAnswerTextQuery()
        SetCorrectAnswer()



        incorrectCount = QueryIncorrectCount(cq)

    End Sub


    Private Sub btnNext_Click() Handles btnNext.Click
        WriteDB()
        'Clear the radCheckTemp array (used for Checkboxes) 
        ReDim radCheckTemp(7)

        'Temporarily store current radio button and check box status
        StoreCurrentValues()

        'Clear all radio buttons to prevent carryover from the last question
        ClearRadioButtons()

        'Restore radio button and check box status after all have been cleared
        RestoreCurrentValues()


        'Adds 1 to the current position in the quiz
        position += 1
        cq = qIDNums(position - 1)
        qNum = CStr(position)

        'Determine if this question needs check boxes or radio buttons
        multiSelect = QueryMultiSelect(cq)

        'Set the visibility of grpBoxes based on the multiselect query
        If multiSelect = True Then
            grpRadio.Visible = False
            grpCheck.Visible = True
        Else
            grpRadio.Visible = True
            grpCheck.Visible = False
        End If

        'Disable the next button on the last question to prevent an error and ensure the back button is enabled.
        If position = totalQuestions Then
            btnNext.Enabled = False
        Else
            btnPrevious.Enabled = True
        End If

        'Set title text based on question number (position)
        lblTitle.Text = ("Question " & position & " of " & totalQuestions & ":")

        'Sets the question text based on the current question  
        lblQuestion.Text = QueryQuestion(cq)

        'Sets the radio button answers text based on the first question 
        SetCurrentAnswers()

        'Sets the correct answer based on the current question
        SetCorrectAnswer()

        'Sets the text if the Check Answer button is clicked. 
        CorrectAnswerTextQuery()

        'Disable the answer radio buttons if the answer has been checked.
        If answerChecked(position - 1) = True Then
            grpRadio.Enabled = False
            grpCheck.Enabled = False
            btnCheckAnswer.Enabled = False
        Else
            grpRadio.Enabled = True
            grpCheck.Enabled = True
            btnCheckAnswer.Enabled = True
        End If

        'Set all radio buttons and check boxes to stored values if applicable
        If multiSelect = False Then
            RestoreRadioButtons()
        Else
            RestoreCheckBoxes()
        End If


        incorrectCount = QueryIncorrectCount(cq)
        txtIncorrectCount.Text = incorrectCount.ToString

    End Sub

    Private Sub btnPrevious_Click() Handles btnPrevious.Click
        WriteDB()
        ReDim radCheckTemp(7)

        'Temporarily store current radio button and check box status
        StoreCurrentValues()

        'Clear all radio buttons to prevent carryover from the last question
        ClearRadioButtons()

        'Restore radio button and check box status after all have been cleared
        RestoreCurrentValues()

        'Subtracts 1 from the current position in the quiz
        position -= 1
        cq = qIDNums(position - 1)
        qNum = CStr(position)

        'Determine if this question needs check boxes or radio buttons
        multiSelect = QueryMultiSelect(cq)

        'Set the visibility of grpBoxes based on the multiselect query
        If multiSelect = True Then
            grpRadio.Visible = False
            grpCheck.Visible = True
        Else
            grpRadio.Visible = True
            grpCheck.Visible = False
        End If

        'Disable the previous question button if this is the first question
        If position = 1 Then
            btnPrevious.Enabled = False
        Else
            btnNext.Enabled = True
        End If

        'Set title text based on question number (position)
        lblTitle.Text = ("Question " & position & " of " & totalQuestions & ":")

        lblQuestion.Text = QueryQuestion(cq)

        'Sets the radio button answers text based on the first question 
        SetCurrentAnswers()


        'Sets the correct answer based on the current question
        SetCorrectAnswer()

        'Sets the text if the Check Answer button is clicked. 
        CorrectAnswerTextQuery()

        'Disable the answer radio buttons if the answer has been checked.
        If answerChecked(position - 1) = True Then
            grpRadio.Enabled = False
            grpCheck.Enabled = False
            btnCheckAnswer.Enabled = False
        Else
            grpRadio.Enabled = True
            grpCheck.Enabled = True
            btnCheckAnswer.Enabled = True
        End If

        'Set all radio buttons to stored values if applicable
        If multiSelect = False Then
            RestoreRadioButtons()
        Else
            RestoreCheckBoxes()
        End If


        incorrectCount = QueryIncorrectCount(cq)
        txtIncorrectCount.Text = incorrectCount.ToString

    End Sub

    Private Sub btnSubmit_Click() Handles btnSubmit.Click
        bNum = 0                                    'Set the counter to 0
        'If the question has been answered then the questionsAnswered value for the question should be 1
        'If the question has been answered then add 1 to the blankAnswer variable
        'Repeat this for all questions
        Do
            If questionsAnswered(bNum) = 1 Then
                blankAnswer += 1
            End If
            bNum += 1
        Loop Until bNum = totalQuestions

        'If there is a blank answer give the student a chance to either continue or submit the quiz
        If blankAnswer < totalQuestions Then
            frmSubmitVerify.Show()
            Me.AddOwnedForm(frmSubmitVerify)
        Else
            'If there are no blank answers disable all timers and buttons and open the summary form
            Timer1.Enabled = False
            Timer2.Enabled = False
            grpRadio.Enabled = False
            grpCheck.Enabled = False
            btnPrevious.Enabled = False
            btnCheckAnswer.Enabled = False
            btnNext.Enabled = False

            frmSummary.Show()
            Me.Close()
        End If

        'Reset blank answers to 0
        'This ensures that any answers marked blank will not be marked as blank the next time the submit button is clicked.
        blankAnswer = 0

    End Sub

    Private Sub radAns1_CheckedChanged() Handles radAns1.CheckedChanged
        'Mark the selected question as answered.
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 1 to true and all other radio buttons to false
        rad1Check(position - 1) = True
        rad2Check(position - 1) = False
        rad3Check(position - 1) = False
        rad4Check(position - 1) = False
        rad5Check(position - 1) = False
        rad6Check(position - 1) = False
        rad7Check(position - 1) = False
        rad8Check(position - 1) = False

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub radAns2_CheckedChanged() Handles radAns2.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 2 to true and all other radio buttons to false
        rad1Check(position - 1) = False
        rad2Check(position - 1) = True
        rad3Check(position - 1) = False
        rad4Check(position - 1) = False
        rad5Check(position - 1) = False
        rad6Check(position - 1) = False
        rad7Check(position - 1) = False
        rad8Check(position - 1) = False

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub radAns3_CheckedChanged() Handles radAns3.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 2 to true and all other radio buttons to false
        rad1Check(position - 1) = False
        rad2Check(position - 1) = False
        rad3Check(position - 1) = True
        rad4Check(position - 1) = False
        rad5Check(position - 1) = False
        rad6Check(position - 1) = False
        rad7Check(position - 1) = False
        rad8Check(position - 1) = False

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub radAns4_CheckedChanged() Handles radAns4.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 2 to true and all other radio buttons to false
        rad1Check(position - 1) = False
        rad2Check(position - 1) = False
        rad3Check(position - 1) = False
        rad4Check(position - 1) = True
        rad5Check(position - 1) = False
        rad6Check(position - 1) = False
        rad7Check(position - 1) = False
        rad8Check(position - 1) = False

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub radAns5_CheckedChanged() Handles radAns5.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 2 to true and all other radio buttons to false
        rad1Check(position - 1) = False
        rad2Check(position - 1) = False
        rad3Check(position - 1) = False
        rad4Check(position - 1) = False
        rad5Check(position - 1) = True
        rad6Check(position - 1) = False
        rad7Check(position - 1) = False
        rad8Check(position - 1) = False

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub radAns6_CheckedChanged() Handles radAns6.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 2 to true and all other radio buttons to false
        rad1Check(position - 1) = False
        rad2Check(position - 1) = False
        rad3Check(position - 1) = False
        rad4Check(position - 1) = False
        rad5Check(position - 1) = False
        rad6Check(position - 1) = True
        rad7Check(position - 1) = False
        rad8Check(position - 1) = False

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub radAns7_CheckedChanged() Handles radAns7.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 2 to true and all other radio buttons to false
        rad1Check(position - 1) = False
        rad2Check(position - 1) = False
        rad3Check(position - 1) = False
        rad4Check(position - 1) = False
        rad5Check(position - 1) = False
        rad6Check(position - 1) = False
        rad7Check(position - 1) = True
        rad8Check(position - 1) = False


        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub radAns8_CheckedChanged() Handles radAns8.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 2 to true and all other radio buttons to false
        rad1Check(position - 1) = False
        rad2Check(position - 1) = False
        rad3Check(position - 1) = False
        rad4Check(position - 1) = False
        rad5Check(position - 1) = False
        rad6Check(position - 1) = False
        rad7Check(position - 1) = False
        rad8Check(position - 1) = True

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub radAns1_TextChanged() Handles radAns1.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub radAns2_TextChanged() Handles radAns2.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub radAns3_TextChanged() Handles radAns3.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub radAns4_TextChanged() Handles radAns4.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub radAns5_TextChanged() Handles radAns5.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub radAns6_TextChanged() Handles radAns6.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub radAns7_TextChanged() Handles radAns7.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub radAns8_TextChanged() Handles radAns8.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub chkAns1_CheckedChanged() Handles chkAns1.CheckedChanged
        'Mark the selected question as answered.
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set current check box value to True or False
        If rad1Check(position - 1) = True Then
            rad1Check(position - 1) = False
        Else
            rad1Check(position - 1) = True
        End If

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub chkAns2_CheckedChanged() Handles chkAns2.CheckedChanged
        'Mark the selected question as answered.
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 1 to true and all other radio buttons to false
        If rad2Check(position - 1) = True Then
            rad2Check(position - 1) = False
        Else
            rad2Check(position - 1) = True
        End If

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub chkAns3_CheckedChanged() Handles chkAns3.CheckedChanged
        'Mark the selected question as answered.
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 1 to true and all other radio buttons to false
        If rad3Check(position - 1) = True Then
            rad3Check(position - 1) = False
        Else
            rad3Check(position - 1) = True
        End If

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub chkAns4_CheckedChanged() Handles chkAns4.CheckedChanged
        'Mark the selected question as answered.
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 1 to true and all other radio buttons to false
        If rad4Check(position - 1) = True Then
            rad4Check(position - 1) = False
        Else
            rad4Check(position - 1) = True
        End If

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub chkAns5_CheckedChanged() Handles chkAns5.CheckedChanged
        'Mark the selected question as answered.
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 1 to true and all other radio buttons to false
        If rad5Check(position - 1) = True Then
            rad5Check(position - 1) = False
        Else
            rad5Check(position - 1) = True
        End If

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub chkAns6_CheckedChanged() Handles chkAns6.CheckedChanged
        'Mark the selected question as answered.
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 1 to true and all other radio buttons to false
        If rad6Check(position - 1) = True Then
            rad6Check(position - 1) = False
        Else
            rad6Check(position - 1) = True
        End If

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub chkAns7_CheckedChanged() Handles chkAns7.CheckedChanged
        'Mark the selected question as answered.
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 1 to true and all other radio buttons to false
        If rad7Check(position - 1) = True Then
            rad7Check(position - 1) = False
        Else
            rad7Check(position - 1) = True
        End If

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub chkAns8_CheckedChanged() Handles chkAns8.CheckedChanged
        'Mark the selected question as answered.
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 1 to true and all other radio buttons to false
        If rad8Check(position - 1) = True Then
            rad8Check(position - 1) = False
        Else
            rad8Check(position - 1) = True
        End If

        'Set answer to correct or incorrect
        DetermineIfCorrect()

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub chkAns1_TextChanged() Handles chkAns1.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub chkAns2_TextChanged() Handles chkAns2.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub chkAns3_TextChanged() Handles chkAns3.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub chkAns4_TextChanged() Handles chkAns4.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub chkAns5_TextChanged() Handles chkAns5.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub chkAns6_TextChanged() Handles chkAns6.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub chkAns7_TextChanged() Handles chkAns7.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    Private Sub chkAns8_TextChanged() Handles chkAns8.TextChanged
        'If the text for the answer = "_" then hide the checnbox, radio button and number label
        ShowHide_RadioAndChecks()
    End Sub

    'Control for Timer 1
    Public Sub Timer1_Tick() Handles Timer1.Tick

        If timeLeft <= 0 Then                               'Determine if time has run out
            txtTimeLeft.Text = "00:00:00"                   'Set timer text to all zeros
        Else
            txtTimeLeft.Text = GetTime(timeLeft)            'Gets the current timer if the timer has not reached zero
        End If

        'I set the timeLeft variable to be -1 so the timer would continue to blink on and off until the time reached 0
        'Otherwise the timer would stop blinking at 1 second...
        If timeLeft = -1 Then                               'Determine if the timer has reached -1 
            Timer1.Enabled = False                          'If yes then stop timer
        Else
            timeLeft -= 1                                   'Decrease timer by 1

            If timeLeft < 0 Then                            'Determine if time is less than zero 
                frmSummary.Show()                           'Show the quiz summary
                Me.Hide()                                   'Hide the quiz form
                btnSubmit.Enabled = False                   'Disable the submit button
                Timer2.Enabled = False                      'Disable timer2
                txtTimeLeft.Visible = True                  'Ensure the final time is visible
                txtTimeLeft.ForeColor = Color.Red           'Keep time color red
            ElseIf timeLeft < 60 Then                       'Determine if time left is less than 60 seconds
                Timer2.Enabled = True                       'Enable timer2 (blinking)
                txtTimeLeft.ForeColor = Color.Red           'Set text forcolor to red
            End If
        End If
    End Sub

    'Control for timer 2
    Public Sub Timer2_Tick() Handles Timer2.Tick

        'This timer is used to make the timer start blinking when the timer has 60 seconds or less remaining.
        If timeLeft < 60 Then                               'Determine if the time left is 60 seconds or less
            If txtTimeLeft.Visible = True Then              'If yes, then determine if the timetext is visible
                txtTimeLeft.Visible = False                 'If yes, then set as false
            ElseIf txtTimeLeft.Visible = False Then         'If the timer is not visible
                txtTimeLeft.Visible = True                  'Set timer visibility to true
            End If
        End If
    End Sub

    Private Sub btnCheckAnswer_Click() Handles btnCheckAnswer.Click

        'Determine which radio button is checked then 
        'Set add one to correct or incorrect count to display in the window and display a message box
        'If radAns1.Checked = True Or chkAns1.Checked Then
        If rad1Check(position - 1) = True Or rad2Check(position - 1) = True Or rad3Check(position - 1) = True Or rad4Check(position - 1) = True Or rad5Check(position - 1) = True Or rad6Check(position - 1) = True Then

            If gradedAnswers(position - 1) = "Correct" Then

                checkedCorrectCount += 1
                lblCorrectAnswers.Text = "Correct Answers: " & checkedCorrectCount.ToString
                MessageBox.Show("Correct", "Correct")
            Else
                checkedInorrectCount += 1
                lblIncorrectAnswers.Text = "Incorrect Answers: " & checkedInorrectCount.ToString
                If multiSelect = False Then
                    MessageBox.Show("Incorrect, the correect answer is: " & correctAnswer(0), "Incorrect")
                Else
                    MessageBox.Show("Incorrect, the correect answers are: " & Environment.NewLine & correctAnswer(0) & Environment.NewLine & correctAnswer(1) & Environment.NewLine & correctAnswer(2) & Environment.NewLine & correctAnswer(3) & Environment.NewLine & correctAnswer(4) & Environment.NewLine & correctAnswer(5), "Incorrect")
                End If
            End If
            grpRadio.Enabled = False              'Disable radio buttons for the current answer to prevent changes after grading
            grpCheck.Enabled = False              'Disable radio buttons for the current answer to prevent changes after grading
            answerChecked(position - 1) = True      'Indicate that this answer has been checked (for next and back button use)
            btnCheckAnswer.Enabled = False          'Disable the check answer button for current question (for next and back button use)
        Else
            'If no answer has been checked show a message box to indicate the user must select an answer before grading.
            MessageBox.Show("You must select an answer before you can check the answer.", "Error")
        End If
    End Sub

    'Query to determine if the answer has more than 1 correct answer, if so the check boxes will be displayed and not the radio buttons
    Function QueryIncorrectCount(cq As Integer) As Integer

        Dim result As Integer

        Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.IncorrectCount

        result = query.First
        Return result

    End Function

    'Query to determine if the answer has more than 1 correct answer, if so the check boxes will be displayed and not the radio buttons
    Function QueryMultiSelect(cq As Integer) As Boolean

        Dim result As Boolean

        Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.multiSelect

        result = query.First
        Return result

    End Function

    'Query the total number of questions
    Function QueryNumQuestion() As Integer
        Dim result As Integer

        If incorrectOnly = False Then
            For i As Integer = 0 To (numChapters - 1)
                Dim query = From q In QuizDataSet.Questions
                            Where q.chapter = chapters(i)
                                      Select q.question

                result += query.Count
            Next

        Else
            For i As Integer = 0 To (numChapters - 1)
                Dim query = From q In QuizDataSet.Questions
                            Where q.chapter = chapters(i)
                            Where q.IncorrectCount >= incorrectAmount
                                      Select q.question

                result += query.Count
            Next
        End If
        Return result

    End Function

    'Query the question ID to be used in determining if the answer is correct
    Private Sub QueryQuestionID()
        Dim currentChapter As String
        Dim chapterCount As Integer
        Dim arrayCount As Integer = 0

        If incorrectOnly = False Then
            For j As Integer = 0 To (numChapters - 1)
                currentChapter = chapters(j)

                Dim queryID = From q In QuizDataSet.Questions
                                Where q.chapter = currentChapter
                                Select q.ID

                chapterCount = queryID.Count


                For i As Integer = 0 To (chapterCount - 1)
                    Dim query2 = From q In QuizDataSet.Questions
                                 Where q.chapter = currentChapter
                                 Select q.ID

                    qIDNums(arrayCount) = query2(i)
                    arrayCount += 1
                Next
            Next
        Else
            For j As Integer = 0 To (numChapters - 1)
                currentChapter = chapters(j)

                Dim queryID = From q In QuizDataSet.Questions
                                Where q.chapter = currentChapter
                                Where q.IncorrectCount >= incorrectAmount
                                Select q.ID

                chapterCount = queryID.Count


                For i As Integer = 0 To (chapterCount - 1)
                    Dim query2 = From q In QuizDataSet.Questions
                                 Where q.chapter = currentChapter
                                 Where q.IncorrectCount >= incorrectAmount
                                 Select q.ID

                    qIDNums(arrayCount) = query2(i)
                    arrayCount += 1
                Next
            Next

        End If

    End Sub

    '"query the question text to display in the label
    Function QueryQuestion(cq As Integer) As String

        Dim result As String = ""

        Dim query = From q In QuizDataSet.Questions
                    Where q.ID = cq
                    Select q.question

        result = query.First

        Return result

    End Function

    'Query the answers to display in the radio buttons and check boxes
    Function QueryAnswers(cq As Integer) As String

        Dim result As String = ""

        If querySelect = "1" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer1

            result = query.First


        ElseIf querySelect = "2" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer2

            result = query.First


        ElseIf querySelect = "3" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer3

            result = query.First


        ElseIf querySelect = "4" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer4

            result = query.First


        ElseIf querySelect = "5" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer5

            result = query.First


        ElseIf querySelect = "6" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer6

            result = query.First

        ElseIf querySelect = "7" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer7

            result = query.First


        ElseIf querySelect = "8" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer8

            result = query.First
        End If


        Return result.ToString


    End Function

    '"query to determine the correct answer(s) for the current questions
    Function QueryCorrectAnswers(cq As Integer) As String

        Dim queryResult As Boolean
        Dim result As String = ""

        If querySelect = "1" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.Answerkey1

            queryResult = query.First

            If queryResult = True Then
                Dim query1 = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer1

                result = query1.First
            Else
                result = "_"
            End If

        ElseIf querySelect = "2" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.Answerkey2

            queryResult = query.First

            If queryResult = True Then
                Dim query1 = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer2

                result = query1.First
            Else
                result = "_"
            End If

        ElseIf querySelect = "3" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.Answerkey3

            queryResult = query.First

            If queryResult = True Then
                Dim query1 = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer3

                result = query1.First
            Else
                result = "_"
            End If

        ElseIf querySelect = "4" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.Answerkey4

            queryResult = query.First

            If queryResult = True Then
                Dim query1 = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer4

                result = query1.First
            Else
                result = "_"
            End If

        ElseIf querySelect = "5" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.Answerkey5

            queryResult = query.First

            If queryResult = True Then
                Dim query1 = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer5

                result = query1.First
            Else
                result = "_"
            End If

        ElseIf querySelect = "6" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.Answerkey6

            queryResult = query.First

            If queryResult = True Then
                Dim query1 = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer6

                result = query1.First
            Else
                result = "_"
            End If

        ElseIf querySelect = "7" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.Answerkey7

            queryResult = query.First

            If queryResult = True Then
                Dim query1 = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer7

                result = query1.First
            Else
                result = "_"
            End If

        ElseIf querySelect = "8" Then
            Dim query = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.Answerkey8

            queryResult = query.First

            If queryResult = True Then
                Dim query1 = From q In QuizDataSet.Questions
                              Where q.ID = cq
                              Select q.answer8

                result = query1.First
            Else
                result = "_"
            End If

        End If
        Return result.ToString

    End Function

    'Determines if the answers selected are correct or incorrect
    Private Sub DetermineIfCorrect()

        If rad1Check(position - 1) = True Then
            selectedAnswers(0) = chkAns1.Text
        ElseIf rad1Check(position - 1) = False Then
            selectedAnswers(0) = "_"
        Else
            selectedAnswers(0) = "x"
        End If

        If rad2Check(position - 1) = True Then
            selectedAnswers(1) = chkAns2.Text
        ElseIf rad2Check(position - 1) = False Then
            selectedAnswers(1) = "_"
        Else
            selectedAnswers(1) = "x"
        End If

        If rad3Check(position - 1) = True Then
            selectedAnswers(2) = chkAns3.Text
        ElseIf rad3Check(position - 1) = False Then
            selectedAnswers(2) = "_"
        Else
            selectedAnswers(2) = "x"
        End If

        If rad4Check(position - 1) = True Then
            selectedAnswers(3) = chkAns4.Text
        ElseIf rad4Check(position - 1) = False Then
            selectedAnswers(3) = "_"
        Else
            selectedAnswers(3) = "x"
        End If

        If rad5Check(position - 1) = True Then
            selectedAnswers(4) = chkAns5.Text
        ElseIf rad5Check(position - 1) = False Then
            selectedAnswers(4) = "_"
        Else
            selectedAnswers(4) = "x"
        End If

        If rad6Check(position - 1) = True Then
            selectedAnswers(5) = chkAns6.Text
        ElseIf rad6Check(position - 1) = False Then
            selectedAnswers(5) = "_"
        Else
            selectedAnswers(5) = "x"
        End If

        If rad7Check(position - 1) = True Then
            selectedAnswers(6) = chkAns7.Text
        ElseIf rad7Check(position - 1) = False Then
            selectedAnswers(6) = "_"
        Else
            selectedAnswers(6) = "x"
        End If

        If rad8Check(position - 1) = True Then
            selectedAnswers(7) = chkAns8.Text
        ElseIf rad8Check(position - 1) = False Then
            selectedAnswers(7) = "_"
        Else
            selectedAnswers(7) = "x"
        End If

        answerKeyString = answerKey(0) & answerKey(1) & answerKey(2) & answerKey(3) & answerKey(4) & answerKey(5) & answerKey(6) & answerKey(7)
        selectedAnswersString(position - 1) = selectedAnswers(0) & selectedAnswers(1) & selectedAnswers(2) & selectedAnswers(3) & selectedAnswers(4) & selectedAnswers(5) & selectedAnswers(6) & selectedAnswers(7)



        If answerKeyString = selectedAnswersString(position - 1) Then

            If gradedAnswers(position - 1) = "Incorrect" Then
                incorrectCount -= 1
                txtIncorrectCount.Text = incorrectCount.ToString
            End If
            gradedAnswers(position - 1) = "Correct"
        Else
            If gradedAnswers(position - 1) = "Correct" Or gradedAnswers(position - 1) = "N/A" Then
                incorrectCount += 1
                txtIncorrectCount.Text = incorrectCount.ToString
            End If
            gradedAnswers(position - 1) = "Incorrect"

        End If

    End Sub

    Private Sub WriteDB()
         provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "Data\Quiz.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "update [Questions] set [IncorrectCount]  = '" & txtIncorrectCount.Text & "' Where [ID] = " & qIDNums(position - 1) & "  "
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.QuestionsTableAdapter.Fill(Me.QuizDataSet.Questions)
    End Sub

    'Stores the current values in the arrray for the radio buttons and check boxes. 
    'When the radio button and check boxes are cleared for the next question, these will be altered and must be retored in order to 
    'move back and forth between the questions and have them display the correct selection made by the user.
    Private Sub StoreCurrentValues()
        'Temporarily store current radio button and check box status
        radCheckTemp(0) = rad1Check(position - 1)
        radCheckTemp(1) = rad2Check(position - 1)
        radCheckTemp(2) = rad3Check(position - 1)
        radCheckTemp(3) = rad4Check(position - 1)
        radCheckTemp(4) = rad5Check(position - 1)
        radCheckTemp(5) = rad6Check(position - 1)
        radCheckTemp(6) = rad7Check(position - 1)
        radCheckTemp(7) = rad8Check(position - 1)
        gradedAnswersTemp = gradedAnswers(position - 1)

    End Sub

    'Clears all radio buttons and check boxes
    Private Sub ClearRadioButtons()
        radAns1.Checked = False
        radAns2.Checked = False
        radAns3.Checked = False
        radAns4.Checked = False
        radAns5.Checked = False
        radAns6.Checked = False
        radAns7.Checked = False
        radAns8.Checked = False

        chkAns1.Checked = False
        chkAns2.Checked = False
        chkAns3.Checked = False
        chkAns4.Checked = False
        chkAns5.Checked = False
        chkAns6.Checked = False
        chkAns7.Checked = False
        chkAns8.Checked = False

    End Sub

    'Restores the values of the radio buttons and check boxes after they that been cleared.
    Private Sub RestoreCurrentValues()
        'Restore radio button and check box status after all have been cleared
        rad1Check(position - 1) = radCheckTemp(0)
        rad2Check(position - 1) = radCheckTemp(1)
        rad3Check(position - 1) = radCheckTemp(2)
        rad4Check(position - 1) = radCheckTemp(3)
        rad5Check(position - 1) = radCheckTemp(4)
        rad6Check(position - 1) = radCheckTemp(5)
        rad7Check(position - 1) = radCheckTemp(6)
        rad8Check(position - 1) = radCheckTemp(7)

        gradedAnswers(position - 1) = gradedAnswersTemp
    End Sub

    'When the user clicked the next or back button and retuns to a previously answered question it will show the selection made by the user
    Private Sub RestoreRadioButtons()
        'Restore all radio buttons to the current questions status
        radAns1.Checked = rad1Check(position - 1)
        radAns2.Checked = rad2Check(position - 1)
        radAns3.Checked = rad3Check(position - 1)
        radAns4.Checked = rad4Check(position - 1)
        radAns5.Checked = rad5Check(position - 1)
        radAns6.Checked = rad6Check(position - 1)
        radAns7.Checked = rad7Check(position - 1)
        radAns8.Checked = rad8Check(position - 1)
    End Sub

    'Restore check boxes separtate from radio buttons because they work in a different way
    Private Sub RestoreCheckBoxes()
        'Restore all check boxes to the current questions status
        If rad1Check(position - 1) = True Then
            rad1Check(position - 1) = False
            chkAns1.Checked = True
        End If

        If rad2Check(position - 1) = True Then
            rad2Check(position - 1) = False
            chkAns2.Checked = True
        End If

        If rad3Check(position - 1) = True Then
            rad3Check(position - 1) = False
            chkAns3.Checked = True
        End If

        If rad4Check(position - 1) = True Then
            rad4Check(position - 1) = False
            chkAns4.Checked = True
        End If

        If rad5Check(position - 1) = True Then
            rad5Check(position - 1) = False
            chkAns5.Checked = True
        End If

        If rad6Check(position - 1) = True Then
            rad6Check(position - 1) = False
            chkAns6.Checked = True
        End If

        If rad7Check(position - 1) = True Then
            rad7Check(position - 1) = False
            chkAns7.Checked = True
        End If

        If rad8Check(position - 1) = True Then
            rad8Check(position - 1) = False
            chkAns8.Checked = True
        End If
    End Sub
    'Gets the text to display when the user clicks on the check answer button
    Private Sub CorrectAnswerTextQuery()
        Dim num As Integer = 1

        For i As Integer = 0 To 7
            If answerKey(i) = "_" Then
                correctAnswer(i) = ""
            Else
                correctAnswer(i) = num & ". " & answerKey(i)
            End If
            num += 1
        Next

        Array.Sort(correctAnswer, New comparer)
    End Sub
    'Hide radio buttons and check boxes if there is no answer in that field
    Private Sub ShowHide_RadioAndChecks()
        If radAns1.Text = "_" Or chkAns1.Text = "_" Then
            radAns1.Visible = False
            chkAns1.Visible = False
            lblAns1.Visible = False
            lblAns1_1.Visible = False
        Else
            radAns1.Visible = True
            chkAns1.Visible = True
            lblAns1.Visible = True
            lblAns1_1.Visible = True
        End If

        If radAns2.Text = "_" Or chkAns2.Text = "_" Then
            radAns2.Visible = False
            chkAns2.Visible = False
            lblAns2.Visible = False
            lblAns2_1.Visible = False
        Else
            radAns2.Visible = True
            chkAns2.Visible = True
            lblAns2.Visible = True
            lblAns2_1.Visible = True
        End If

        If radAns3.Text = "_" Or chkAns3.Text = "_" Then
            radAns3.Visible = False
            chkAns3.Visible = False
            lblAns3.Visible = False
            lblAns3_1.Visible = False
        Else
            radAns3.Visible = True
            chkAns3.Visible = True
            lblAns3.Visible = True
            lblAns3_1.Visible = True
        End If

        If radAns4.Text = "_" Or chkAns4.Text = "_" Then
            radAns4.Visible = False
            chkAns4.Visible = False
            lblAns4.Visible = False
            lblAns4_1.Visible = False
        Else
            radAns4.Visible = True
            chkAns4.Visible = True
            lblAns4.Visible = True
            lblAns4_1.Visible = True
        End If

        If radAns5.Text = "_" Or chkAns5.Text = "_" Then
            radAns5.Visible = False
            chkAns5.Visible = False
            lblAns5.Visible = False
            lblAns5_1.Visible = False
        Else
            radAns5.Visible = True
            chkAns5.Visible = True
            lblAns5.Visible = True
            lblAns5_1.Visible = True
        End If

        If radAns6.Text = "_" Or chkAns6.Text = "_" Then
            radAns6.Visible = False
            chkAns6.Visible = False
            lblAns6.Visible = False
            lblAns6_1.Visible = False
        Else
            radAns6.Visible = True
            chkAns6.Visible = True
            lblAns6.Visible = True
            lblAns6_1.Visible = True
        End If

        If radAns7.Text = "_" Or chkAns7.Text = "_" Then
            radAns7.Visible = False
            chkAns7.Visible = False
            lblAns7.Visible = False
            lblAns7_1.Visible = False
        Else
            radAns7.Visible = True
            chkAns7.Visible = True
            lblAns7.Visible = True
            lblAns7_1.Visible = True
        End If

        If radAns8.Text = "_" Or chkAns8.Text = "_" Then
            radAns8.Visible = False
            chkAns8.Visible = False
            lblAns8.Visible = False
            lblAns8_1.Visible = False
        Else
            radAns8.Visible = True
            chkAns8.Visible = True
            lblAns8.Visible = True
            lblAns8_1.Visible = True
        End If
    End Sub
    Private Sub SetCurrentAnswers()

        'Sets the radio button answers text based on the first question 
        Dim num As Integer
        currentAnswerCount = 0
        num = 1
        For i As Integer = 0 To 7
            querySelect = num.ToString
            currentAnswers(i) = QueryAnswers(cq)
            If currentAnswers(i) <> "_" Then
                currentAnswerCount += 1
            End If
            num += 1
        Next

        radAns1.Text = currentAnswers(0)
        radAns2.Text = currentAnswers(1)
        radAns3.Text = currentAnswers(2)
        radAns4.Text = currentAnswers(3)
        radAns5.Text = currentAnswers(4)
        radAns6.Text = currentAnswers(5)
        radAns7.Text = currentAnswers(6)
        radAns8.Text = currentAnswers(7)


        chkAns1.Text = currentAnswers(0)
        chkAns2.Text = currentAnswers(1)
        chkAns3.Text = currentAnswers(2)
        chkAns4.Text = currentAnswers(3)
        chkAns5.Text = currentAnswers(4)
        chkAns6.Text = currentAnswers(5)
        chkAns7.Text = currentAnswers(6)
        chkAns8.Text = currentAnswers(7)

    End Sub
    Private Sub SetCorrectAnswer()

        'Sets the correct answer based on the current question
        Dim num As Integer
        num = 1
        For i As Integer = 0 To 7
            querySelect = num.ToString
            answerKey(i) = QueryCorrectAnswers(cq)
            num += 1
        Next
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click

        'Show the exit form when the exit quiz button is clicked
        exitForm.Show()

    End Sub

    Private Sub Chk_Rad_Visible()
        If multiSelect = True Then
            'grpRadio.Text = "Select the correct answers below:"
            radAns1.Visible = False
            radAns2.Visible = False
            radAns3.Visible = False
            radAns4.Visible = False
            radAns5.Visible = False
            radAns6.Visible = False
            radAns7.Visible = False
            radAns8.Visible = False

            chkAns1.Visible = True
            chkAns2.Visible = True
            chkAns3.Visible = True
            chkAns4.Visible = True
            chkAns5.Visible = True
            chkAns6.Visible = True
            chkAns7.Visible = True
            chkAns8.Visible = True
        Else
            'grpRadio.Text = "Select the correct answer below:"
            radAns1.Visible = True
            radAns2.Visible = True
            radAns3.Visible = True
            radAns4.Visible = True
            radAns5.Visible = True
            radAns6.Visible = True
            radAns7.Visible = True
            radAns8.Visible = True

            chkAns1.Visible = False
            chkAns2.Visible = False
            chkAns3.Visible = False
            chkAns4.Visible = False
            chkAns5.Visible = False
            chkAns6.Visible = False
            chkAns7.Visible = False
            chkAns8.Visible = False
        End If
    End Sub

    Private Sub btnNewQuiz_Click(sender As Object, e As EventArgs) Handles btnNewQuiz.Click
        frmNewQuizWarning.Show()
    End Sub

    Public Sub Randomize_Questions()
        If randomQuestions = True Then
            RandomizeAnswerOrder()
        End If
    End Sub

    Private Sub RandomizeAnswerOrder()
        Dim rnd = New System.Random
        For i = qIDNums.Count - 1 To 0 Step -1
            Dim j = rnd.Next(0, i)
            'swap
            Dim tmp = qIDNums(j)
            qIDNums(j) = qIDNums(i)
            qIDNums(i) = tmp
        Next
    End Sub
End Class
