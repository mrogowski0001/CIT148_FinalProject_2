Public Class frmSubmitVerify

    Private Sub SubmitVerify_Load() Handles MyBase.Load

        'Warn the user that they will be submitting the quiz with blank answers
        lblWarnText.Text = "You are about to submit your quiz with unanswered questions. If you choose to continue, your quiz qill be graded with the unanswered questions and will lower your overall score. If you wish to finish the quiz, please click the continue Quiz button below. Otherwise, you may click the Submit button below to grade your quiz with the unanswered questions."

    End Sub

    Private Sub btnContinue_Click() Handles btnContinue.Click

        'If the user chooses to continue the quiz and answer the remaining questions, hide this form
        Me.Hide()

    End Sub

    Private Sub btnSubmit_Click() Handles btnSubmit.Click

        'If the user chooses to submit the quiz with the unanswered questions 
        Dim frmQuiz As frmQuiz = DirectCast(Me.Owner, frmQuiz)              'Take ownership of the frmQuiz to ba able to stop the timers
        frmQuiz.Timer1.Enabled = False                                      'Stop Timer1
        frmQuiz.Timer2.Enabled = False                                      'Stop Timer2
        frmQuiz.Hide()                                                      'Hide the quiz form
        frmSummary.Show()                                                   'Show the summary form
        Me.Hide()                                                           'Hide the warning form

    End Sub

End Class