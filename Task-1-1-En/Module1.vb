Module Module1

    Sub Main()
        Dim n As UInteger  ' number Of blocks
        Dim k As UInteger ' number Of towers
        Console.Clear() ' Clear screen
        Console.WriteLine("Enter the number of blocks")
        UInt32.TryParse(Console.ReadLine(), n)
        Console.WriteLine("Enter the number of blocks for 1 tower")
        UInt32.TryParse(Console.ReadLine(), k)
        Dim t As UInteger = n \ k ' Maximum number Of towers
        Dim b As UInteger = t * k ' Number Of blocks
        Console.WriteLine($"From {n} blocks, you can build a maximum of {t} towers")
        Console.WriteLine($"This will take {b} blocks.")
        Console.Read() ' Delay output until key "Enter" Not pressed
    End Sub

End Module
