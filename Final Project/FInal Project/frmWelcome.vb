Public Class frmWelcome

    'Declare variables for welcome text and quizForm
    Dim counter As Integer = 0
    Dim welcomeText() As String = IO.File.ReadAllLines("Data\WelcomeText.txt")


    Private Sub btnBegin_Click() Handles btnBegin.Click

        'Open the quiz form and hides the welcome form
        frmChooseChapter.Show()
        Me.Hide()

    End Sub

    Private Sub frmWelcome_Load() Handles MyBase.Load

        'Set welcome label text.
        lblWelcomeText.Text = welcomeText(0) & Environment.NewLine
        'Set instructions label text.
        lblInstructionsText.Text = welcomeText(2) & Environment.NewLine & Environment.NewLine & welcomeText(4) & Environment.NewLine & Environment.NewLine & welcomeText(6)

    End Sub

End Class
