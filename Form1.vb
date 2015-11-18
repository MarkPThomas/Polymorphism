Option Explicit On
Option Strict On

Public Class Form1

    Private _owner As New Owner

    Private Sub btnClassA_Click(sender As Object, e As EventArgs) Handles btnClassA.Click
        _owner.MethodA()
    End Sub

    Private Sub btnClassB_Click(sender As Object, e As EventArgs) Handles btnClassB.Click
        Dim newClassB As New ClassB
        _owner.castMe = newClassB

        _owner.MethodB()
    End Sub

    Private Sub btnClassC_Click(sender As Object, e As EventArgs) Handles btnClassC.Click
        Dim newClassC As New ClassC
        _owner.castMe = newClassC

        _owner.MethodC()
    End Sub

    Private Sub btnClassBasC_Click(sender As Object, e As EventArgs) Handles btnClassBasC.Click
        Dim newClassC As New ClassC
        _owner.castMe = newClassC

        _owner.MethodB()
    End Sub

    Private Sub btnClassCasB_Click(sender As Object, e As EventArgs) Handles btnClassCasB.Click
        Dim newClassB As New ClassB
        _owner.castMe = newClassB

        _owner.MethodC()
    End Sub

    ''' <summary>
    ''' This tests whether property assignments are lost in the casting, or if they perservere. 
    ''' Also tests that casting preserves the reference so that once assigned as a property of a derived type, that object's properties of its specific type can still be changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClassBChangeProperties_Click(sender As Object, e As EventArgs) Handles btnClassBChangeProperties.Click
        Console.WriteLine()

        ' First property assignment
        Dim originalClassB As New ClassB
        originalClassB.PropertyB = "Property B - Pre-assigned"

        Console.WriteLine("First property assignment - Original {0}", originalClassB)
        Console.WriteLine("I am {0}'s {1}", originalClassB, originalClassB.PropertyB)
        originalClassB.MethodB()
        Console.WriteLine()

        ' Assign object
        _owner.castMe = originalClassB

        Console.WriteLine("Assign object - {0}", _owner)
        _owner.MethodB()
        Console.WriteLine()

        ' Second property assignment
        Dim newClassB As ClassB = CType(_owner.castMe, ClassB)
        newClassB.PropertyB = "Property B - Post-assigned"

        Console.WriteLine("Second property assignment - New {0}", newClassB)
        Console.WriteLine("I am New {0}'s {1}", newClassB, newClassB.PropertyB)
        newClassB.MethodB()
        Console.WriteLine()

        Console.WriteLine("Second property assignment - {0}", _owner)
        _owner.MethodB()
        Console.WriteLine()
    End Sub
End Class
