Module _3_2
    Private resultado As DateTime
    Sub main()
        resultado = sumar_dias(Now, 5)
        Console.WriteLine("La fecha de hoy sumado 5 dias mas = " & resultado)
        Console.ReadKey()
    End Sub
    Private Function sumar_dias(fecha As DateTime, n As Integer)
        Return fecha.AddDays(n)
    End Function
End Module
