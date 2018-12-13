Module Module1

    Sub Main()
        Dim num, factorial As Integer
        Console.WriteLine("Please enter the number you want a factorial of")
        num = Console.ReadLine()
        factorial = 1

        For counter = 0 To (num - 1)
            factorial = factorial + (factorial * counter)
        Next

        Console.WriteLine("The factorial of the number is " & factorial)
        Console.ReadLine()
    End Sub

End Module
