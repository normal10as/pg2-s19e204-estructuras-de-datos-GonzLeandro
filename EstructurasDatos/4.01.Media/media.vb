Imports System

Module media
    Dim array(4) As Integer
    Dim media As Integer

    Sub Main(args As String())
        For x = 0 To array.Length - 1
            Console.Write("Ingrese un valor: ")
            calcular(x)
        Next

        Console.WriteLine("El contenido de la array es: ")
        For Each n In array
            Console.WriteLine("Elemento: " & n & " - (Elemento: " & n & " - Media: " & (media / array.Count) & " = " & n - (media / array.Count) & ")")
        Next

    End Sub

    Sub calcular(x)
        array(x) = Console.ReadLine
        media += array(x)
    End Sub
End Module
