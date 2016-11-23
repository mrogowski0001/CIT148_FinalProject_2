
Public Class comparer
    Implements IComparer(Of String)

    Public Function Compare(ByVal x As String, ByVal y As String) As Integer Implements System.Collections.Generic.IComparer(Of String).Compare
        If x = Nothing And y <> Nothing Then
            Return 1
        ElseIf y = Nothing And x <> Nothing Then
            Return -1
        ElseIf y = Nothing And x = Nothing Then
            Return 0
        Else
            Return x.CompareTo(y)
        End If
    End Function

End Class

