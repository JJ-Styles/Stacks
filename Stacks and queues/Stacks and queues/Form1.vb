Public Class Form1

    Private Sub BttStack_Click(sender As Object, e As EventArgs) Handles BttStack.Click
        Dim stack As Stack(Of Integer) = New Stack(Of Integer)
        stack.Push(10)
        stack.Push(100)
        stack.Push(1000)
        For Each value As Integer In stack
            LBoxStack.Items.Add(value)
        Next
    End Sub

    Private Sub TxtAddStack_TextChanged(sender As Object, e As EventArgs) Handles TxtAddStack.TextChanged

    End Sub
End Class
