Public Class frmSummary

    Private Sub frmSummary_Load() Handles MyBase.Load

        Dim count As Integer = 0        'Declare a counter variable to get the total number of correctly answered questions to display to the user

        Do
            If gradedAnswers(count) = "Correct" Then
                totalCorrect += 1                       'adds 1 to the total of correct answers
            End If
            count += 1                                  'Adds 1 to the counter variable
        Loop Until count = totalQuestions           'Stops the loop when the counter has reached the total number of questions in the quiz

        'Declare a variable to hold the summary text to display to the user to prevent haveing to have multiple instances of the same information
        Dim sumText As String = ("You correctly answered " & totalCorrect.ToString & " questions out of " & totalQuestions.ToString & ".")

        'Set summary label text
        lblTitle1.Text = "Summary"
        lblTitle2.Text = "Here are the results of your quiz."


        'Calculate the final average score using the AverageScore function located in PublicVar.vb
        average = AverageScore(totalCorrect, totalQuestions)

        'Display message box based on the average score
        If average >= 99 Then
            lblSummartText.Text = ("Woo Hoo! You're a genius! You scored " & CStr(average) & "%" & Environment.NewLine & sumText)
        ElseIf average >= 90 Then
            lblSummartText.Text = ("Sweet!, You totaly scored " & CStr(average) & "%" & Environment.NewLine & sumText)
        ElseIf average >= 80 Then
            lblSummartText.Text = (" Righteous! You scored " & CStr(average) & "%" & Environment.NewLine & sumText)
        ElseIf average >= 70 Then
            lblSummartText.Text = ("Good Job! You scored " & CStr(average) & "%" & Environment.NewLine & sumText)
        Else
            lblSummartText.Text = ("You suck! You only scored a pathetic " & CStr(average) & "%" & Environment.NewLine & sumText)
        End If

        'Clear the list box before populating the list box with the results
        lstSummary.Items.Clear()

        'Get and display the answer status (correct or incorrect) next to the question text
        querySelect = "q"

        For i As Integer = 0 To totalQuestions - 1
            position = (i + 1)
            lstSummary.Items.Add(gradedAnswers(i) & vbTab & vbTab & allQuestions(i))
            lstSummary.Items.Add("")                            'Add a space between questions to make the list easier to read
        Next

    End Sub

    Private Sub btnExitQuiz_Click() Handles btnExitQuiz.Click

        'Exit the application
        Application.Exit()
    End Sub
End Class