Option Explicit On
Option Strict On

Public Class ClassB
    Inherits ClassA

    Friend Property PropertyB As String = "Property B"

    Friend Sub MethodB()
        Console.WriteLine("I am {0}'s method B", Me)
    End Sub
End Class
