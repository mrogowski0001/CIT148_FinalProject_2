Public Class frmNewQuizWarning

    Private Sub frmNewQuizWarning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblExitText.Text = "Are you sure you wish to start a new quiz? All data will be lost!"
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        ResetVariables()
        frmChooseChapter.Show()
        frmQuiz.Close()
        Me.Close()

    End Sub

    Private Sub ResetVariables()
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
    End Sub
End Class