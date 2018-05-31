Module _3_1
    Friend fecha As DateTime = DateTime.Today
    Sub main()


        fecha_actual()
        hora_actual()
        Console.ReadKey()

    End Sub
    Private Sub fecha_actual()
        Console.WriteLine("La fecha actual es: " & fecha.ToString("D"))
    End Sub

    Private Function hora_actual()
        Console.WriteLine("La hora actual es: " & Now.ToString("HH:mm:ss"))
    End Function

End Module
