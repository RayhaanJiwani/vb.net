Module Module1

    Sub Main()
        Dim FileRead As IO.StreamReader
        Dim str, find As String
        Dim i, n As Integer
        Dim found As Boolean
        found = False
        FileRead = New IO.StreamReader("C:\Users\rayhaan.jiwani\Desktop\Sample.txt")
        Console.WriteLine("Please enter the word you are looking for")
        find = Console.ReadLine()
        n = Len(find)
        While FileRead.EndOfStream = False
            str = FileRead.ReadLine()
            i = Len(str)
            For counter = 1 To i
                If Mid(str, counter, n) = find Then
                    found = True
                End If
            Next
        End While

        If found = True Then
            Console.WriteLine("The word is present in the file")
        Else
            Console.WriteLine("The word is not present in the file")
        End If
        Console.ReadLine()
    End Sub

End Module
