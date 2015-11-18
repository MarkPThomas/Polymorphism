Option Explicit On
Option Strict On

Public Class ClassA
    Friend Property PropertyA As String = "Property A"


    Friend Sub MethodA()
        Console.WriteLine("I am {0}'s method A", Me)
    End Sub
End Class
