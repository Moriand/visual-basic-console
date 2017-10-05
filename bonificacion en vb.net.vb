Module Module1

    Sub Main()
        Dim sueldobr, neto As Double
        Dim sexo, escivil As Integer

        Console.WriteLine("        ingrese su sexo")
        Console.WriteLine("     1.                hombre")
        Console.WriteLine("     2.                 mujer                   ")

        sexo = Console.ReadLine
        Console.WriteLine("        ingrese su estado civil")
        Console.WriteLine("     1.                casado")
        Console.WriteLine("     2.                 viudo                   ")
        escivil = Console.ReadLine
        Console.WriteLine("        ingrese su sueldo bruto")
        sueldobr = Console.ReadLine
        Console.WriteLine("------------------------------------------------------------")

        If escivil = 1 And sexo = 1 Then
            Console.WriteLine(" se le bonificará un 5% por ser casado y un 7% por se hombre")
            neto = sueldobr + (sueldobr * 0.05) + (sueldobr * 0.07)
            Console.WriteLine("------------------------------------------------------------")
            Console.WriteLine(" su bonificación es --->   " & neto)

        ElseIf escivil = 2 And sexo = 2 Then
            Console.WriteLine("se le bonificará un 5% por ser viuda y un 10% por ser mujer")
            neto = sueldobr + (sueldobr * 0.05) + (sueldobr * 0.1)
            Console.WriteLine("------------------------------------------------------------")
            Console.WriteLine(" su bonificación es --->  " & neto)

        ElseIf escivil = 2 And sexo = 1 Then
            Console.WriteLine("se le bonificará un 5% por ser hombre viudo")
            neto = sueldobr + (sueldobr * 0.05)
            Console.WriteLine("------------------------------------------------------------")
            Console.WriteLine(" su bonificación es --->    " & neto)


        ElseIf escivil = 1 And sexo = 2 Then
            Console.WriteLine("se le bonificará un 5% por ser mujer casada")
            neto = sueldobr + (sueldobr * 0.05)
            Console.WriteLine("------------------------------------------------------------")
            Console.WriteLine(" su bonificación es --->   " & neto)
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" has escrito mal")
            Console.ResetColor()


        End If

        Console.ReadKey()


    End Sub

End Module
