Option Strict On
Option Explicit On

Public Class Owner
    Friend Property castMe As New ClassA

    Friend Sub MethodA()
        Console.WriteLine("I am {0}'s {1}", castMe, castMe.PropertyA)
        castMe.MethodA()
    End Sub

    Friend Sub MethodB()
        Dim newclass As ClassB = TryCast(castMe, ClassB)
        If newclass IsNot Nothing Then
            Console.WriteLine("I am {0}'s {1}", newclass, newclass.PropertyB)
            newclass.MethodB()
        Else
            Console.WriteLine("Invalid cast!")
        End If
    End Sub

    Friend Sub MethodC()
        Dim newclass As ClassC = TryCast(castMe, ClassC)
        If newclass IsNot Nothing Then
            Console.WriteLine("I am {0}'s {1}", newclass, newclass.PropertyC)
            newclass.MethodC()
        Else
            Console.WriteLine("Invalid cast!")
        End If
    End Sub


End Class
