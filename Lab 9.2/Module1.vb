Module Module1

    Sub Main()

        'declaring variables
        Dim pingCounter As Integer = 0
        generateRandom(pingCounter)
        Console.WriteLine("The server was pinged " & pingCounter & " times.")
        Console.WriteLine("This concludes the test.  Press enter to exit.")
        Console.ReadLine()

    End Sub

    Function generateRandom(ByRef pingCounter As Integer)

        Dim randomNumber As Integer = 0
        Dim loopCounter As Integer = 0
        Dim loopsLeft As Integer = 0

        Do While loopCounter < 200

            loopsLeft = 200 - loopCounter
            randomNumber = Int((Rnd() * 20) + 1)
            Console.WriteLine("The random number is " & randomNumber & " There are " & loopsLeft & " attempts left.")
            Console.WriteLine("")

            If randomNumber = 5 Then
                pingMe()
                pingCounter = pingCounter + 1
            End If

            System.Threading.Thread.Sleep(1000)
            loopCounter = loopCounter + 1
        Loop

        Return pingCounter

    End Function

    Sub pingMe()

        Shell("Ping.exe 127.0.0.1", , True)
        Console.WriteLine("")

    End Sub

End Module
