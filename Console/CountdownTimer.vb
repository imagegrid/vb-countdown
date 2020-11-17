
Module CountdownTimer

    Private secondsRemaining As Integer
    Private hours As Integer
    Private minutes As Integer
    Private seconds As Integer

    Public Sub Start(seconds)

        secondsRemaining = seconds

        Do
            If secondsRemaining > 0 Then
                DisplayTime(secondsRemaining)
                secondsRemaining -= 1 '// decrement the value
            Else
                Complete()
                Exit Do
            End If

            Threading.Thread.Sleep(1000)
            'If the above line doesn't work try this
            'Sleep 1000

        Loop While True

    End Sub

    Private Sub DisplayTime(secondsRemaining)

        hours = Fix(secondsRemaining / 3600)
        minutes = Format(Fix((secondsRemaining Mod 3600) / 60), "00")
        seconds = Format(Fix((secondsRemaining Mod 3600) Mod 60), "00")

        Console.WriteLine(hours & " : " & minutes & " : " & seconds)

    End Sub

    Private Sub Complete()

        Console.WriteLine("Time Elapsed")

    End Sub

End Module
