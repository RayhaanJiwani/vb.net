Module Module1

    Sub Main()
        Dim Names(10) As Char
        Dim write, write_name, write_marks As String
        Dim Marks(10), write_marks As Integer
        Dim FileWrite As IO.StreamWriter
        FileWrite = New IO.StreamWriter("C:\Users\rayhaan.jiwani\Desktop\Names+Marks.txt", True)
        For counter = 1 To 10
            write_name = Console.ReadLine()
            Names(counter) = write_name
            write_marks = Console.ReadLine()
            Marks(counter) = write_marks
            write = write_name + write_marks
        Next
    End Sub

End Module
