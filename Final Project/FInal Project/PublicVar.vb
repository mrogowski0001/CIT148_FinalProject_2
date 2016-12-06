Module PublicVar


    Public totalQuestions As Integer                        'Hold the tolal numer of questions when frmQuiz loads
    Public arraySize As Integer                             'size of arrays based on total questions, calculated when frmQuiz loads

    Public numChapters As Integer
    Public chapters() As String
    Public currentQNum As Integer
    Public qTotal As Integer
    Public qIDNums() As Integer
    Public cq As Integer

    'All arrays are ReDimed on frmQuiz_Load to calculate the array sizes when the variable arraySize is calculated after the QuizdataSet is populated
    Public allQuestions() As String                        'logs each question for use in the summary form
    Public gradedAnswers() As String                        'Variable to hold "correct" and "incorrect answers
    Public gradedAnswersTemp As String
    Public answerChecked() As Boolean                       'Variable to hold status of checked(graded) answers
    Public questionsAnswered() As Integer                   'Keeps a count of all answered questions to determine if there are any unanswered question qhwn the user submits the quiz
    Public incorrectCount As Integer
    Public incorrectOnly As Boolean = False
    Public incorrectAmount As Integer = 1

    Public multiSelect As Boolean
    Public numAnswers As Integer
    Public rad1Check() As Boolean
    Public rad2Check() As Boolean
    Public rad3Check() As Boolean
    Public rad4Check() As Boolean
    Public rad5Check() As Boolean
    Public rad6Check() As Boolean
    Public rad7Check() As Boolean
    Public rad8Check() As Boolean
    Public radCheckTemp(7) As Boolean

    Public answerKey(7) As String
    Public answerKeyString As String

    Public currentAnswersTemp(7) As String
    Public currentAnswers(7) As String
    Public correctAnswer(7) As String
    Public selectedAnswers(7) As String
    Public selectedAnswers2(7) As String
    Public selectedAnswersString() As String

    'Declare varialbes to be used for the quiz
    Public querySelect As String                            'What the queryQuiz function is to query from the database
    Public exitForm As New frmExit
    Public position As Integer = 1                          'This is the number of the current question (Default is 1)
    Public qNum As String = CStr(position)                  'A string version of the current question in position above
    Public currentQuestion As String = ""
    'Variable to hold the correct answer for the current question
    Public totalCorrect As Integer = 0                      'total of correct answers
    Public totalIncorrect As Integer = 0                    'Total of incorrect answers
    Public average As Double = 0                            'The average score fofr the test based on 100%
    Public timeLeft As Integer                              'calculates the total time allowed for the quiz in seconds( 20 seconds per questions)
    Public bNum As Integer = 0                              'Counter for loop to determine if there is a blank answer
    Public blankAnswer As Integer                           'total of blank answers
    Public checkedCorrectCount As Integer = 0               'Total of correct answers that have been checked
    Public checkedIncorrectCount As Integer = 0              'Total of incorrect answers that have been checked

    Public timerEnabled As Boolean = False
    Public timePerQuestion As Integer = 60

    Public currentAnswerCount As Integer
    Public randomQuestions As Boolean = False

    'Function to calculate the average based on the total questions in the questions text file
    Public Function AverageScore(totalCorrect As Integer, totalQuestions As Integer) As Double
        Dim average As Double

        average = Math.Round((totalCorrect / totalQuestions) * 100, 2)
        Return average

    End Function

    'Function to control the countdown timer
    Public Function GetTime(timeLeft As Integer) As String
        Dim Hrs As Double           'number of hours   '
        Dim Min As Double           'number of Minutes '
        Dim Sec As Integer          'number of Sec     '

        'Seconds'
        Sec = timeLeft Mod 60

        'Minutes'
        Min = ((timeLeft - Sec) / 60) Mod 60

        'Hours'
        Hrs = ((timeLeft - (Sec + (Min * 60))) / 3600) Mod 60

        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    End Function
End Module
