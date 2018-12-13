Module Module1

    Sub Main()
        Dim FileRead As IO.StreamReader
        Dim FileWrite As IO.StreamWriter
        Dim str As String
        FileRead = New IO.StreamReader("C:\Users\rayhaan.jiwani\Desktop\Text.txt")
        FileWrite = New IO.StreamWriter("C:\Users\rayhaan.jiwani\Desktop\Text_Copy.txt")
        While FileRead.EndOfStream = False
            str = FileRead.ReadLine
            FileWrite.WriteLine(str)
        End While
        FileRead.Close()
        FileWrite.Close()
        Console.WriteLine("The contents of the file have been copied")
        Console.ReadLine()
    End Sub

End Module
