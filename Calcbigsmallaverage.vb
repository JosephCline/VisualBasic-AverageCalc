Module Module1

    Sub Main()
        Dim iNumber As Integer
        Dim iBig As Integer
        Dim iSmall As Integer
        Dim iTotal As Integer
        Dim iCount As Integer
        Dim dAverage As Integer


        iBig = 0
        iSmall = 1000
        iCount = 0
        While iNumber <> -1
            Console.Write("Please enter a positive number: ")
            iNumber = Console.ReadLine
            If iNumber = -1 Then
                Exit While
            End If
            If iNumber > iBig Then
                iBig = iNumber
            End If
            If iNumber < iSmall Then
                iSmall = iNumber
            End If

            iCount = iCount + 1
            iTotal = iNumber + iTotal

        End While
        dAverage = (iTotal / iCount)
        Console.WriteLine("The largest number entered is: " & iBig)
        Console.ReadKey()
        Console.WriteLine("The smallest number entered is: " & iSmall)
        Console.ReadKey()
        Console.WriteLine("The average number entered is: " & dAverage)
        Console.ReadKey()

    End Sub

End Module
