Module Module1

    Sub Main()
        Dim FileRead As IO.StreamReader
        Dim str As String
        Dim str_len, words As Integer
        words = 0
        FileRead = New IO.StreamReader("C:\Users\rayhaan.jiwani\Desktop\Counting words.txt")
        Do Until FileRead.EndOfStream
            str = FileRead.ReadLine()
            str_len = Len(str)
            For counter = 1 To str_len
                If Mid(str, counter, 1) = " " Then
                    words = words + 1
                End If
            Next
            words = words + 1
        Loop
        Console.WriteLine("The number of words in the file is " & (words))
        Console.ReadLine()
    End Sub

End Module
