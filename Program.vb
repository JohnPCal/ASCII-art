Imports System

Module ASCII_Art
    Const int_screenwidth As Integer = 80 'width of console screen in characters
    Sub Main()
        Dim int_pos As Integer = 0 'position of the car
        Dim int_pos2 As Integer = 0
        'set the size of the command window (Width, heigh)
        Console.SetWindowSize(int_screenwidth + 1, 30)

        'display message and wait  for user input
        Console.WriteLine(getCar(0))
        Console.WriteLine(vbCrLf & vbCrLf & vbCrLf)
        Console.ForegroundColor = ConsoleColor.Gray
        Console.Clear()

        'loop until car leaves screen
        For int_pos = 1 To (int_screenwidth + 20)

            'draw car
            Console.WriteLine(getCar(int_pos))

            'and pause
            Threading.Thread.Sleep(30)

            'clear for next interation
            Console.Clear()
        Next

        For int_pos = 0 To (int_screenwidth - 40)

            'draw car
            Console.WriteLine(getCar2(int_pos))

            'and pause
            Threading.Thread.Sleep(30)

            'clear for next interation
            Console.Clear()
        Next

        Console.WriteLine("Bye bye!")
        Console.ReadKey()

    End Sub

    Public Function getCar(int_spaces As Integer)

        'function that returns the ASCII art car - parameter specifies the number of spaces prefixing it)
        'the space appears depending on the side it was placed in relation to the printed text
        Dim str_result As String = ""
        str_result = str_result & Left(Space(int_spaces) & "            _______________          ", int_screenwidth) & vbCrLf
        str_result = str_result & Left(Space(int_spaces) & "           / /   | | |   \ \         ", int_screenwidth) & vbCrLf
        str_result = str_result & Left(Space(int_spaces) & "     _____/ /____| | |____\ \_______ ", int_screenwidth) & vbCrLf
        str_result = str_result & Left(Space(int_spaces) & "    |    _   -     |  -       _    ||", int_screenwidth) & vbCrLf
        str_result = str_result & Left(Space(int_spaces) & "    |___/ \________|_________/ \___||", int_screenwidth) & vbCrLf
        str_result = str_result & Left(Space(int_spaces) & "        \_/                  \_/     ", int_screenwidth) & vbCrLf

        Return str_result
    End Function
    Public Function getCar2(int_spaces As Integer)

        'function that returns the ASCII art car - parameter specifies the number of spaces prefixing it)
        Dim str_result As String = ""
        str_result = str_result & "            _______________          " & Right(Space(int_spaces), int_screenwidth) & vbCrLf
        str_result = str_result & "           / /   | | |   \ \         " & Right(Space(int_spaces), int_screenwidth) & vbCrLf
        str_result = str_result & "     _____/ /____| | |____\ \_______ " & Right(Space(int_spaces), int_screenwidth) & vbCrLf
        str_result = str_result & "    |    _   -     |  -       _    ||" & Right(Space(int_spaces), int_screenwidth) & vbCrLf
        str_result = str_result & "    |___/ \________|_________/ \___||" & Right(Space(int_spaces), int_screenwidth) & vbCrLf
        str_result = str_result & "        \_/                  \_/     " & Right(Space(int_spaces), int_screenwidth) & vbCrLf

        Return str_result
    End Function

    'John Calverley
End Module
