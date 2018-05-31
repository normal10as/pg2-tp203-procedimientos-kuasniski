Module _3_3
    Private result As Integer
    Sub main()
        Console.Write("Ingrese un numero: ")
        potencia(Console.ReadLine)
        Console.ReadKey()
    End Sub
    Private Function potencia(num As Integer)
        For exponente = 2 To 6
            result = num ^ exponente
            Console.WriteLine("{0} elevado a la {1} = {2}", num, exponente, result)
        Next
    End Function
End Module
