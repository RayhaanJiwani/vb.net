Module Module1

    Sub Main()
        Dim FileHandle_W As IO.StreamWriter
        Dim FileHandle_R As IO.StreamReader
        FileHandle_W = New IO.StreamWriter("C:\Users\rayhaan.jiwani\Desktop\Sample.txt", True)
        FileHandle_R = New IO.StreamReader("C:\Users\rayhaan.jiwani\Desktop\Sample2.txt")
        Do Until FileHandle_R.EndOfStream
            Str = 
        Loop
    End Sub

End Module
