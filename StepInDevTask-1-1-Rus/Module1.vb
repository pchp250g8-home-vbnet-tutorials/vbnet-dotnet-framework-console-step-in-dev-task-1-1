Module Module1

    Sub Main()
        Dim n As UInteger ' количество блоков
        Dim k As UInteger ' количество башен
        Console.Clear() ' Очистка экрана
        Console.WriteLine("Введите количество блоков")
        UInt32.TryParse(Console.ReadLine(), n)
        Console.WriteLine("Введите количество блоков на башню")
        UInt32.TryParse(Console.ReadLine(), k)
        Dim t As UInteger = n \ k ' Максимальное количество башен
        Dim b As UInteger = t * k ' Количесво блоков
        Console.WriteLine($"Из {n} блоков можно построить максимум {t} башен(ни))")
        Console.WriteLine($"На это уйдёт {b} блоков.")
        Console.Read() ' Задержка вывода до нажатия клавиши "Ввод"
    End Sub

End Module
