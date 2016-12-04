Public Class frmNewQuizWarning

    Private Sub frmNewQuizWarning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblExitText.Text = "Are you sure you wish to start a new quiz? All data will be lost!"
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        frmChooseChapter.Show()
        frmQuiz.Close()
        Me.Close()
    End Sub
End Class