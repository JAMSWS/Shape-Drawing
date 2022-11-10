Imports System
Imports System.ComponentModel.Design
Imports System.Drawing

Module Program
    Sub Main(args As String())
here:
        Dim choice, i, j, l, input As Integer
        Dim line, stripedline, square As String


        line = "*"
        square = "*****"
        stripedline = "_"


        Console.WriteLine("SHAPE DRAWING")
        Console.WriteLine("[1] Draw line")
        Console.WriteLine("[2] Draw StripedLine")
        Console.WriteLine("[3] Draw Square")
        Console.WriteLine("[4] Draw Parallelogram")
        Console.WriteLine("[5] Draw Triagle")
        Console.WriteLine("[6] Draw Reverse triangle")
        Console.WriteLine("[0] Exit" + vbNewLine)

        Console.WriteLine("Enter your choice to draw: ")
        choice = CInt(Console.ReadLine)

        Select Case choice
            'Done
            Case "1"
retry1:
                Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
                input = CInt(Console.ReadLine)
                If input Mod 2 <> 0 And input > 3 Then
                    For i = 1 To input
                        Console.Write(line)
                    Next
                    Console.WriteLine()
                    GoTo here
                Else
                    GoTo retry1

                End If



                'done
            Case "2"
retry2:
                Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
                input = CInt(Console.ReadLine)
                If input Mod 2 <> 0 And input > 3 Then

                    For i = 1 To input
                        If (i Mod 2 = 0) Then
                            Console.Write(line)
                        Else
                            Console.Write(stripedline)
                        End If
                    Next

                    Console.WriteLine()



                    GoTo here
                Else
                    GoTo retry2

                End If


                'DONE
            Case "3"
retry3:
                Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
                input = CInt(Console.ReadLine)
                If input Mod 2 <> 0 And input > 3 Then

                    For i = 1 To input
                        For j = 1 To input
                            Console.Write(line)
                        Next
                        Console.WriteLine(" ")

                    Next
                    Console.ReadLine()
                    GoTo here
                Else
                    GoTo retry3
                End If

                'Done
            Case "4"
retry4:
                Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
                input = CInt(Console.ReadLine)
                If input Mod 2 <> 0 And input > 3 Then

                    For i = input To 1 Step -1
                        For j = i To 1 Step -1
                            Console.Write(stripedline)
                        Next
                        For k = 1 To input
                            Console.Write(line)
                        Next
                        For l = i To input Step +1
                            Console.Write(stripedline)
                        Next
                        Console.WriteLine("")
                    Next
                    Console.WriteLine(" ")
                    GoTo here

                Else
                    GoTo retry4
                End If

            Case "5"

retry5:
                Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
                input = CInt(Console.ReadLine)
                If input Mod 2 <> 0 And input > 3 Then

                    For i = input To 1 Step -1
                        For l = i To 1 Step -1
                            Console.Write(line)
                        Next

                        For j = i To input - 1 Step +1
                            Console.Write(stripedline)
                        Next
                        Console.WriteLine("")




                    Next

                    Console.WriteLine(" ")
                    GoTo here

                Else
                    GoTo retry5
                End If
                'done
            Case "6"

retry6:
                Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
                input = CInt(Console.ReadLine)
                If input Mod 2 <> 0 And input > 3 Then

                    For i = input To 1 Step -1
                        For j = i To input - 1 Step +1
                            Console.Write(line)
                        Next
                        For k = i To 1 Step -1
                            Console.Write(stripedline)
                        Next
                        Console.WriteLine("")
                    Next

                    Console.WriteLine(" ")
                    GoTo here
                Else
                    GoTo retry6

                End If


            Case "0"

                Console.WriteLine("Thank you!")


            Case Else
                GoTo here



        End Select

        Console.ReadKey()

    End Sub



End Module
