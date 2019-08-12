Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim codigo = New Integer() {1, 2, 3}
        Dim nombre = New String() {"papa", "manzana", "uva"}
        Dim precio = New Single() {2.6, 1.2, 4.5}
        Dim buscar As UShort
        Console.WriteLine("Ingrese un valor : ")
        buscar = Console.ReadLine
        Do While buscar <> 0
            For x = 0 To codigo.GetUpperBound(0)
                If buscar = codigo(x) Then
                    Console.WriteLine("{0} - {1}     - {2} ", codigo(x), nombre(x), precio(x))
                End If
            Next
        Loop


    End Sub
End Module
