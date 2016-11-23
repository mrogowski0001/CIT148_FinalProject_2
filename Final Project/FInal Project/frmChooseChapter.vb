Public Class frmChooseChapter
    Dim addCount As Integer = 0
    Dim currentChapter As String

    Private Sub frmChooseChapter_Load() Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuizDataSet.Questions' table. You can move, or remove it, as needed.
        Me.QuestionsTableAdapter.Fill(Me.QuizDataSet.Questions)
        'TODO: This line of code loads data into the 'QuizDataSet.Questions' table. You can move, or remove it, as needed.
        Me.QuestionsTableAdapter.Fill(Me.QuizDataSet.Questions)

        'Set the text for the instructions label
        lblInstruction.Text = "To add a chapter, select the chapter on the left and click 'Add to Quiz'"

        'Query the total number of chapters and REDim the chapters array to equal the total number of chapters
        numChapters = ChapterCount()
        ReDim chapters(numChapters - 1)

        'Query the chapters (titles) and display them in the list box
        QueryChapters()

    End Sub
    'Get a count of all the chapters
    Function ChapterCount() As Integer
        Dim query = From chap In QuizDataSet.Questions
                        Select chap.chapter Distinct
        Return query.Count
    End Function
    'Query the chapter text and fill the chapters array
    Private Sub QueryChapters()

        Dim query = From chap In QuizDataSet.Questions
                    Order By chap.chapter
                       Select chap.chapter Distinct

        For Each Chap As String In query
            lstChapters.Items.Add(Chap)
        Next

    End Sub

    'Add the selected item(s) in the list box to the quiz
    Private Sub btnAdd_Click() Handles btnAdd.Click
        Dim flag As Boolean = False

        If addCount = numChapters Then
            'MessageBox.Show("You have already addded all the chapters to the quiz.", "Message")
        Else
            For i As Integer = 0 To (numChapters - 1)
                If chapters(i) = currentChapter Then
                    flag = True
                End If
            Next
        End If

        If addCount = numChapters Then
            MessageBox.Show("You have already addded all the chapters to the quiz.", "Message")
        Else
            If flag = True Then
                MessageBox.Show("You have already added this chapter.", "Error")
                flag = False
            Else
                For Each item As String In lstChapters.SelectedItems
                    If chapters(addCount) = "" Then
                        chapters(addCount) = item
                        lstSelected.Items.Add(item)
                        addCount += 1
                    End If
                Next
            End If
        End If
        btnStart.Enabled = True
    End Sub
    'Remove selected chapters from the selected chapters
    Private Sub btnRemove_Click() Handles btnRemove.Click
        If addCount = 0 Then
            MessageBox.Show("You have already removed all the chapters to the quiz.", "Message")

        Else
            For i As Integer = 0 To (numChapters - 1)
                If chapters(i) Is lstSelected.SelectedItem Then
                    chapters(i) = ""
                    addCount -= 1
                    If addCount = 0 Then
                        btnStart.Enabled = False
                    End If
                End If
            Next
            Array.Sort(chapters, New comparer)
            lstSelected.Items.Clear()
            For i As Integer = 0 To (numChapters - 1)
                If chapters(i) = "" Then
                Else
                    lstSelected.Items.Add(chapters(i))
                End If
            Next
        End If
    End Sub

    '
    Private Sub lstChapters_SelectedIndexChanged() Handles lstChapters.SelectedIndexChanged
        currentChapter = lstChapters.Text
    End Sub

    'Starts the quiz
    Private Sub btnStart_Click() Handles btnStart.Click
        frmQuiz.Show()
        Me.Hide()
    End Sub

    Private Sub btnAllQuestions_Click() Handles btnAllQuestions.Click
        'Add all of the chapters available to the quiz
        ReDim chapters(numChapters - 1)
        lstSelected.Items.Clear()
        addCount = 0
        For i As Integer = 0 To Me.lstChapters.Items.Count - 1
            Me.lstChapters.SetSelected(i, True)
        Next

        btnAdd_Click()

    End Sub

    Private Sub btnReset_Click() Handles btnReset.Click
        'Removes all chapters from the selection and resets the chapters array
        ReDim chapters(numChapters - 1)
        lstSelected.Items.Clear()
        addCount = 0
        btnStart.Enabled = False
    End Sub

End Class