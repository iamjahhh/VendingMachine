Public Class CLI
    Public Sub Welcome()
        Console.WriteLine("Welcome to the Vending Machine!")
        Console.WriteLine()
    End Sub

    Public Sub DisplayItems(itemsArr As Object)
        Console.WriteLine("Available Items:")

        For i As Integer = 0 To 5
            Dim item As New Items.Item
            item = itemsArr(i)

            Console.WriteLine("    * A" + (i + 1).ToString() + " - " + item.Name + " - $" + item.Price.ToString())
        Next
    End Sub
End Class
