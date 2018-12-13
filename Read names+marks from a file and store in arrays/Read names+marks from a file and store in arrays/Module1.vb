Module Module1

    Sub Main()
        Dim FileRead As IO.StreamReader
        Dim temp, concat As String
        Dim counter2, counter3, i, element As Integer
        Dim marks(3), names(3) As String
        concat = ""
        element = 0
        counter3 = 1
        FileRead = New IO.StreamReader("C:\Users\rayhaan.jiwani\Desktop\Names+Marks.txt")
        While FileRead.EndOfStream = False
            element = element + 1
            temp = FileRead.ReadLine
            i = Len(temp)

            Do Until Mid(temp, counter3, 1) = " "
                concat = concat + Mid(temp, counter3, 1)
                counter3 = counter3 + 1
            Loop
            names(element) = concat
            concat = ""

            For counter2 = counter3 To i
                concat = concat + Mid(temp, counter2, 1)
            Next
            marks(element) = concat
            concat = ""

            counter3 = 1
            Console.Write(names(element))
            Console.Write(marks(element))
            Console.WriteLine()
        End While
        FileRead.Close()
        Console.ReadLine()
    End Sub

End Module
