Module Module1

    Sub Main()

        Dim s_length, passes, i, j As Integer
        Dim str As String
        Dim Array_Str(30), temp As Char
        i = 1
        Console.WriteLine("Please enter the string to be reversed")
        str = Console.ReadLine()
        s_length = Len(str)
        For counter = 1 To s_length
            Array_Str(counter) = Mid(str, counter, 1)
        Next

        If ((s_length Mod 2) = 0) Then
            passes = s_length / 2
        Else
            passes = (s_length + 1) / 2
        End If

        j = s_length

        While (i < passes) And (j > passes)
            temp = Array_Str(i)
            Array_Str(i) = Array_Str(j)
            Array_Str(j) = temp
            i = i + 1
            j = j - 1
        End While

        For count = 1 To s_length
            Console.Write(Array_Str(count))
        Next

        Console.ReadLine()

    End Sub

End Module
