Module Module1

    Sub Main()
        Dim FileRead1, FileRead2 As IO.StreamReader
        Dim FileWrite As IO.StreamWriter
        Dim str As String
        FileWrite = New IO.StreamWriter("C:\Users\rayhaan.jiwani\Desktop\Append_File.txt", True)
        FileRead1 = New IO.StreamReader("C:\Users\rayhaan.jiwani\Desktop\Text.txt")
        FileRead2 = New IO.StreamReader("C:\Users\rayhaan.jiwani\Desktop\Sample2.txt")

        While FileRead1.EndOfStream = False
            str = FileRead1.ReadLine
            FileWrite.WriteLine(str)
        End While
        Console.WriteLine()
        While FileRead2.EndOfStream = False
            str = FileRead2.ReadLine
            FileWrite.WriteLine(str)
        End While

        FileRead1.Close()
        FileRead2.Close()
        FileWrite.Close()
        Console.WriteLine("The contents of the files have been appended")
        Console.ReadLine()
    End Sub

End Module
