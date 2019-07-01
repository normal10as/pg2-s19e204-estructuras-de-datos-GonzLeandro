Imports System

Module media
    Dim array(4) As Integer
    Dim media As Integer
    Sub Main(args As String())
        calcular()
        Console.WriteLine("El contenido de la array es: ")
        For Each n In array
            Console.WriteLine("Elemento: " & n & " - (Elemento: " & n & " - Media: " & (media / array.Count) & " = " & n - (media / array.Count) & ")")
        Next
    End Sub
    Sub calcular()
        For x = 0 To array.Length - 1
            Console.Write("Ingrese un valor: ")
            array(x) = Console.ReadLine
            media += array(x)
        Next
    End Sub
End Module
