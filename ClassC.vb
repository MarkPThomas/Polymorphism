Option Explicit On
Option Strict On

Public Class ClassC
    Inherits ClassA

    Friend Property PropertyC As String = "Property C"

    Friend Sub MethodC()
        Console.WriteLine("I am {0}'s method C", Me)
    End Sub

End Class
