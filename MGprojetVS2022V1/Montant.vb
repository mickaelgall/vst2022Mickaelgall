Module Montant
    Sub Main()
        Dim montant As Double
        Dim remise As Double
        Dim resultat As Double
        Console.WriteLine("Veuillez taper votre montant")
        montant = Console.ReadLine()
        If montant > 2000 And montant < 5000 Then
            remise = 1
            Console.WriteLine("Remise de 1%")
        End If
        If montant > 5000 Then
            remise = 2
            Console.WriteLine("Remise de 2%")
        End If
        If montant < 2000 Then
            Console.WriteLine("Pas de remise")
        End If
        resultat = montant * (1 - remise / 100)
        Console.WriteLine("Le montant net est : " + resultat.ToString())
        Console.WriteLine("Aurevoir")
    End Sub
End Module
