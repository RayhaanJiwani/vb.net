Module Module1

    Sub Main()
        Dim len, t1, t2, t3 As Integer
        Console.WriteLine("Please enter the number of terms in your sequence")
        len = Console.ReadLine()
        t1 = 1
        t2 = 2
        t3 = 0

        If len = 1 Then
            Console.WriteLine("1")
        ElseIf len = 2 Then
            Console.WriteLine("1 1")
        ElseIf len = 3 Then
            Console.WriteLine("1 1 2")
        Else
            Console.Write("1 1 2")
            For counter = 4 To len
                t3 = t1 + t2
                Console.Write(" " & t3 & " ")
                t1 = t1 + t2
                t2 = t1 + t2
                Console.Write(t2)
            Next
        End If

        Console.ReadLine()
    End Sub

End Module
