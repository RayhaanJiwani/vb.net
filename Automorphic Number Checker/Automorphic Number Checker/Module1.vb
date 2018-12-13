Module Module1

    Sub Main()

        Dim num, tempsq, counter As Integer
        Dim templen, length, square As String
        Dim automorphic_yes As Boolean
        automorphic_yes = True
        counter = 1
        Console.WriteLine("Please enter the number to be checked")
        num = Console.ReadLine()
        templen = CStr(num)
        tempsq = num ^ 2
        square = CStr(tempsq)
        length = Len(templen)

        While (counter <= length) And (automorphic_yes = True)
            If Right(templen, counter) = Right(square, counter) Then
                automorphic_yes = True
            Else
                automorphic_yes = False
            End If
            counter = counter + 1
        End While

        If automorphic_yes = True Then
            Console.WriteLine("The number input is automorphic")
        Else
            Console.WriteLine("The number input is not automorphic")
        End If
        Console.ReadLine()

    End Sub

End Module
