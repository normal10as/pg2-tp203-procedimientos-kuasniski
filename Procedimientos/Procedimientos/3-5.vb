Module _3_5
    Const pi As Single = 3.14159265
    Dim r, h As Integer
    Dim v As Single
    Sub main()
        Do
            Console.Write("Ingrese la base del radio: ")
            r = Console.ReadLine
            Console.Write("Ingrese la altura: ")
            h = Console.ReadLine

        Loop Until validar_enteros(r, h)
        v = calcular_volumen(r, h)
        Console.WriteLine("EL valor es: " & v)
        Console.ReadKey()
    End Sub
    Private Function calcular_volumen(r As Integer, h As Integer)
        Return pi * (r ^ 2) * h
    End Function

End Module
