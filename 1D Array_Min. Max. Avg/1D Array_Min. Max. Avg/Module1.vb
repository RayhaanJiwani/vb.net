Module Module1

    Sub Main()
        'Assuming that 'array_length' is known and Array_Weight() has values in it'

        Dim Array_Weight(30), array_length, max, min, sum As Integer
        max = 0
        min = 1000
        array_length = 10

        Console.WriteLine("Please enter the students' weights")
        For count = 1 To array_length
            Array_Weight(count) = Console.ReadLine()
        Next

        For counter = 1 To array_length
            If Array_Weight(counter) < min Then
                min = Array_Weight(counter)
            End If
            If Array_Weight(counter) > max Then
                max = Array_Weight(counter)
            End If
            sum = sum + Array_Weight(counter)
        Next

        Console.WriteLine("The maximum weight is " & max & " kg")
        Console.WriteLine("The minimum weight is " & min & " kg")
        Console.WriteLine("The average weight is " & (sum / array_length) & " kg")

        Console.ReadLine()

    End Sub

End Module
