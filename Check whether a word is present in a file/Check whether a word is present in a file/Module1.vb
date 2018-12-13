Module Module1

    Sub Main()
        Dim FileRead As IO.StreamReader
        Dim str As String
        Dim found As Boolean
        found = False
        FileRead = New IO.StreamReader("C:\Users\rayhaan.jiwani\Desktop\Text.txt")
        Console.WriteLine("Please enter the word you are looking for")
        str = Console.ReadLine()
        Do Until FileRead.EndOfStream
            If FileRead.ReadLine = str Then
                found = True
            End If
        Loop
        FileRead.Close()
        If found = True Then
            Console.WriteLine("The word is present in the file")
        Else
            Console.WriteLine("The word is not present in the file")
        End If
        Console.ReadLine()
    End Sub

End Module
