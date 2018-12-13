Module Module1

    Sub Main()
        Dim FileRead1, FileRead2 As IO.StreamReader
        Dim FileWrite As IO.StreamWriter
        Dim str1, str2, str3 As String
        FileRead1 = New IO.StreamReader("C:\Users\rayhaan.jiwani\Desktop\Sample2.txt")
        FileRead2 = New IO.StreamReader("C:\Users\rayhaan.jiwani\Desktop\Names.txt")
        FileWrite = New IO.StreamWriter("C:\Users\rayhaan.jiwani\Desktop\Concat_Sentences.txt")
        While (FileRead1.EndOfStream = False) Or (FileRead2.EndOfStream = False)
            str1 = FileRead1.ReadLine()
            str2 = FileRead2.ReadLine()
            str3 = str1 + " " + str2
            FileWrite.WriteLine(str3)
        End While
        FileRead1.Close()
        FileRead2.Close()
        FileWrite.Close()
        Console.WriteLine("The two files have been merged")
        Console.ReadLine()
    End Sub

End Module
