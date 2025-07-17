Public Class UserInput
    Public Function AskCode(itemsArr As Object) As Integer
AskCodeAgain:
        Console.WriteLine()
        Console.Write("Enter item code: ")

        Dim code As String = Console.ReadLine().ToUpper

        Try
            Dim item As Object = itemsArr(code.Substring(1) - 1)
            Return Integer.Parse(code.Substring(1) - 1)
        Catch ex As Exception
            Console.WriteLine("Please input a right item code.")
            GoTo AskCodeAgain
        End Try
    End Function
    Public Function AskMoney() As Integer
AskMoneyAgain:
        Console.Write("Enter money amount: ")

        Dim input As String = Console.ReadLine()

        If IsNumeric(input) Then
            Return Integer.Parse(input)
        Else
            Console.WriteLine("Please input a right amount of money.")
            GoTo AskMoneyAgain
        End If
    End Function
End Class
