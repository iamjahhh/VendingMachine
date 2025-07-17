Public Class Vending
    Public Enum ReturnCode As Integer
        SUCCESS
        NOT_ENOUGH_MONEY
    End Enum

    Public Sub Process()
Again:
        Console.Clear()
        Dim itemsArr As Object

        Dim itemsObj As New Items()
        itemsArr = itemsObj.GetItems()

        Dim cli As New CLI()
        cli.Welcome()
        cli.DisplayItems(itemsArr)

        Dim userInput As New UserInput()

        Dim itemIndex As Integer
        itemIndex = userInput.AskCode(itemsArr)

        Dim userMoney As Integer
        userMoney = userInput.AskMoney()

        Dim vending As New Vending()
        Dim vendingCode As Integer
        vendingCode = vending.DispenseItem(itemsArr(itemIndex), userMoney)

        Console.WriteLine()

        For i As Integer = 5 To 1 Step -1
            Console.WriteLine("You will be redirected in " + i.ToString())
            Threading.Thread.Sleep(1000)
        Next

        GoTo Again
    End Sub

    Public Function DispenseItem(item As Items.Item, money As Integer) As Integer
        Console.WriteLine()
        Console.WriteLine("Dispensing " + item.Name + "...")

        If (item.Price > money) Then
            Console.WriteLine("You don't have enough money to purchase " + item.Name + " :(")
            Return ReturnCode.NOT_ENOUGH_MONEY
        Else
            Console.WriteLine("You have successfully purchased " + item.Name + " for $" + item.Price.ToString())
            Console.WriteLine("Change: $" + (money - item.Price).ToString())
            Return ReturnCode.SUCCESS
        End If
    End Function
End Class
