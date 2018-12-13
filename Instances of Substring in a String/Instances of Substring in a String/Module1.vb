Module Module1

    Sub Main()

        Dim s_string, str, compare As String
        Dim length_str, length_s_str, iterations, instances As Integer
        Dim tempArray(50) As Char
        instances = 0
        compare = ""
        Console.Writeline("Please enter a string")
        str = Console.Readline()
        Console.Writeline("Please enter the substring you are looking for")
        s_string = Console.Readline()
        length_str = Len(str)
        length_s_str = Len(s_string)
        iterations = length_str - (length_s_str) + 1

        For counter = 1 To length_str
            tempArray(counter) = Mid(str, counter, 1)
        Next

        For count = 1 To iterations
            For c = count To (count + length_s_str - 1)
                compare = compare + (tempArray(c))
            Next
            If compare = s_string Then
                instances = instances + 1
            End If
            compare = ""
        Next

        Console.Writeline("The substring appeared " & instances & " times in the string")
        Console.ReadLine()

    End Sub

End Module


