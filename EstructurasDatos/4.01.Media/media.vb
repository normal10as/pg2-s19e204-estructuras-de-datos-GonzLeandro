Imports System

Module media
    Dim array(4) As Integer
    Dim media As Integer
    Sub Main(args As String())
        calcular()
        Console.Write("El contenido de la array es: ")
        For index = 0 To array.Length - 1
            Console.Write(array(index) & " ")
        Next
        Console.WriteLine()
        Console.WriteLine("Elemento:  -  (Elemento  -  Media  =   Desviacion)")

        For Each n In array
            Console.WriteLine("Elemento: " & n & " - (Elemento: " & n & " -  " & (media / array.Count) & " = " & n - (media / array.Count) & ")")
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
