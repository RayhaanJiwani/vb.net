Module Module1

    Sub Main()
        Dim s_length, counter, limit As Integer
        Dim str As String
        Dim Array_Str(30) As Char
        counter = 1
        str = Console.ReadLine()
        s_length = Len(str)
        If s_length Mod 2 = 0 Then
            limit = (s_length) / 2
        Else
            limit = ((s_length) + 1) / 2
        End If
        For counter = 1 To s_length
            Array_Str(counter) = Mid(str, counter, 1)
        Next
        If (((s_length) Mod (2)) = 0) Then
            Reverse(limit, s_length, Array_Str)
        ElseIf (((s_length) + 1) Mod (2)) = 0 Then
            Reverse(limit, s_length, Array_Str)
        End If

    End Sub

    Sub Reverse(ByVal l, ByVal a, ByVal Array_Str)
        Dim i, j, counter As Integer
        Dim temp As Char
        i = 1
        j = a
        counter = 1
        While (i < l) And (j > l)
            temp = Array_Str(i)
            Array_Str(i) = Array_Str(j)
            Array_Str(j) = temp
            i = i + 1
            j = j - 1
        End While
        For counter = 1 To a
            Console.Write(Array_Str(counter))
        Next
        Console.ReadLine()
    End Sub

End Module

