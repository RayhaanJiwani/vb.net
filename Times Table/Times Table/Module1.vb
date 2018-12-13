Module Module1

    Sub Main()

        Dim multiplier, iterations As Integer
        Console.Writeline("Please enter the number whose times table you want")
        multiplier = Console.Readline()
        Console.Writeline("Please enter the number till which you want multiples")
        iterations = Console.Readline()

        For counter = 1 To iterations
            Console.Writeline(multiplier & " * " & counter & " = " & (multiplier * counter))
        Next

        Console.ReadLine()

    End Sub


End Module
