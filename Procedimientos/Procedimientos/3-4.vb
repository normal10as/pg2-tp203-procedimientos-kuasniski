Module _3_4
    Sub main()
        Dim a, b, c As Integer
        Do
            Console.Write("Ingrese el lado A: ")
            a = Console.ReadLine()
            Console.Write("Ingrese el lado B: ")
            b = Console.ReadLine()
            Console.Clear()
        Loop Until validar_enteros(a, b)
        c = a ^ 2 + b ^ 2
        Console.WriteLine("La hipotenusa es: " & c)
        Console.ReadKey()
    End Sub
    Friend Function validar_enteros(a As Integer, b As Integer)
        If a > 0 And b > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
