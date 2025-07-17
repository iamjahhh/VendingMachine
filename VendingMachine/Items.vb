Imports System.Reflection.Metadata.Ecma335

Public Class Items
    Public Class Item
        Public Property Name As String
        Public Property Price As Integer
    End Class

    Public Function GetItems() As Object
        Dim items(5) As Item

        items(0) = New Item() With {
            .Name = "Coke Mismo",
            .Price = 20
        }

        items(1) = New Item() With {
            .Name = "Sprite Mismo",
            .Price = 20
        }

        items(2) = New Item() With {
            .Name = "Royal Mismo",
            .Price = 20
        }

        items(3) = New Item() With {
            .Name = "Burger",
            .Price = 35
        }

        items(4) = New Item() With {
            .Name = "French Fries",
            .Price = 75
        }

        items(5) = New Item() With {
            .Name = "Milk Boba",
            .Price = 110
        }

        Return items
    End Function
End Class
