Module _3_6
    Sub main()
        Dim suma, a As Integer
        Do
            Console.Write("Ingrese un número: ")
            a = Console.ReadLine()
            If valida_entero(a) Then
                suma += calcula_sumatoria(a)
            End If
        Loop Until a = 0
        Console.WriteLine("La suma total es: " & suma)
        Console.ReadKey()
    End Sub
    Private Function calcula_sumatoria(ByRef a)
        a = a ^ 2
        Return a
    End Function
    Private Function valida_entero(a As Integer)
        If a > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
