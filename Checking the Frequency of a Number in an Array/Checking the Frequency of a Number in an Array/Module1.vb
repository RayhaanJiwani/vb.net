Module Module1

    Sub Main()

        'Assuming that 'array_length' is known and ArrayNum() has values in it'

        Dim compare, Array_Num(30), frequency, array_length As Integer
        frequency = 0
        Console.WriteLine("Please enter the number you are looking for")
        compare = Console.ReadLine()
        'array_length = 10'
        'For Counter = 1 To 10'
        'Array_Num(Counter) = Console.ReadLine()'
        'Next'

        For counter = 1 To array_length
            If compare = Array_Num(counter) Then
                frequency = frequency + 1
            End If
        Next

        Console.WriteLine("The number appeared " & frequency & " time(s) in the array")
        Console.ReadLine()

    End Sub

End Module
