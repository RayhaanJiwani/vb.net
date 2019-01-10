Module Module1

    Sub Main()
        Dim counter, temp_line_length As Integer
        Dim email, studentID, compareID, temp_line, compareEmail As String
        Dim studentID_check, email_check, found As Boolean
        Dim FileWrite As IO.StreamWriter
        FileWrite = New IO.StreamWriter("C:\Users\Rayhaan Jiwani\Desktop\StudentDetails.txt")
        studentID_check = False
        email_check = False
        found = False
        compareEmail = ""

        For counter = 1 To 3
            Console.WriteLine("Please enter your student ID and email address in order on separate lines")
            studentID = Console.ReadLine()
            studentID_check = studentID_validation(studentID)
            While studentID_check = False
                Console.WriteLine("Incorrect format, please re-enter student ID")
                studentID = ""
                studentID = Console.ReadLine()
                studentID_check = studentID_validation(studentID)
            End While
            email = Console.ReadLine()
            email_check = email_validation(email)
            While email_check = False
                Console.WriteLine("Invalid email ID, please re-enter")
                email = ""
                email = Console.ReadLine()
                email_check = email_validation(email)
            End While
            FileWrite.WriteLine(studentID & "#" & email)
            studentID = ""
            email = ""
        Next
        FileWrite.Close()

        Console.WriteLine("Please enter the student ID whose corresponding email you want")
        compareID = Console.ReadLine()
        Dim FileRead As IO.StreamReader
        FileRead = New IO.StreamReader("C:\Users\Rayhaan Jiwani\Desktop\StudentDetails.txt")
        Console.WriteLine("Student IDs with the same starting letters")

        While FileRead.EndOfStream = False
            temp_line = FileRead.ReadLine()
            temp_line_length = Len(temp_line)
            If Left(compareID, 2) = Left(temp_line, 2) Then
                Console.WriteLine(Left(temp_line, 6))
            End If
            If compareID = Left(temp_line, 6) Then
                compareEmail = Right(temp_line, (temp_line_length - 7))
                found = True
            Else
                found = False
            End If
            temp_line = ""
            temp_line_length = 0
        End While
        Console.WriteLine("Email of student with student ID " & compareID & " is: " & compareEmail)

        If found = False Then
            Console.WriteLine("Entered student ID does not exist")
        End If
        FileRead.Close()

        FileWrite = New IO.StreamWriter("C:\Users\Rayhaan Jiwani\Desktop\StudentDetails.txt", True)
        studentID = ""
        email = ""
        Console.WriteLine("If you wish to add more students' details then enter them below as before or enter " & -1 & " in the same way")
        studentID = Console.ReadLine()
        email = Console.ReadLine()
        While studentID <> "-1" And email <> "-1"
            studentID = Console.ReadLine()
            studentID_check = studentID_validation(studentID)
            While studentID_check = False
                Console.WriteLine("Incorrect format, please re-enter student ID")
                studentID = ""
                studentID = Console.ReadLine()
                studentID_check = studentID_validation(studentID)
            End While
            email = Console.ReadLine()
            email_check = email_validation(email)
            While email_check = False
                Console.WriteLine("Invalid email ID, please re-enter")
                email = ""
                email = Console.ReadLine()
                email_check = email_validation(email)
            End While
            FileWrite.WriteLine(studentID & "#" & email)
            studentID = ""
            email = ""
        End While
        FileWrite.Close()

    End Sub

    Function studentID_validation(ByVal studentID) As Boolean
        If ((Asc(Mid(studentID, 1, 1)) >= 65) And (Asc(Mid(studentID, 1, 1)) <= 90)) And
           ((Asc(Mid(studentID, 2, 1)) >= 65) And (Asc(Mid(studentID, 2, 1)) <= 90)) And
           ((Asc(Mid(studentID, 3, 1)) >= 48) And (Asc(Mid(studentID, 3, 1)) <= 57)) And
           ((Asc(Mid(studentID, 4, 1)) >= 48) And (Asc(Mid(studentID, 4, 1)) <= 57)) And
           ((Asc(Mid(studentID, 5, 1)) >= 48) And (Asc(Mid(studentID, 5, 1)) <= 57)) And
           ((Asc(Mid(studentID, 6, 1)) >= 48) And (Asc(Mid(studentID, 6, 1)) <= 57)) Then
            studentID_validation = True
        Else
            studentID_validation = False
        End If
    End Function

    Function email_validation(ByVal email) As Boolean
        Dim email_length, counter As Integer
        Dim AtSignFound As Boolean
        AtSignFound = False
        counter = 1
        email_length = 0
        email_length = Len(email)
        While (counter <= email_length) And (AtSignFound = False)
            If Mid(email, counter, 1) = "@" Then
                AtSignFound = True
            Else
                AtSignFound = False
            End If
            counter = counter + 1
        End While
        If ((Right(email, 4)) <> ".com") Or (AtSignFound = False) Then
            email_validation = False
        Else
            email_validation = True
        End If
    End Function

End Module