Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strUserInput As String
        Dim strSum As String = ""
        Dim intNumber As Integer
        Dim intSum As Integer
        strUserInput = InputBox("Enter a positive integer value.", "Provide a Value", "10")

        If strUserInput.Length = 0 Then
            MsgBox("Nothing entered.")
        Else
            Try
                intNumber = CInt(strUserInput)

                If intNumber < 0 Then
                    MsgBox("Please enter a positive integer")
                Else
                    For i = 1 To intNumber
                        intSum += i 'calculating sum 
                        strSum = CInt(intSum)
                    Next

                    MsgBox("The sum of numbers 1 through " + strUserInput + " is " + strSum)
                End If
            Catch
                MsgBox("Please enter a valid integer")

            End Try


        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
