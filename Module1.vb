Module Module1
    Public Class PruebaVecor13
        Private sueldo() As Integer
        Public Sub Cargar()
            Dim cuantosSueldos As Integer

            Console.SetCursorPosition(10, 5)
            Console.Write("Cuatos Sueldo Vamos a introducior (-1 salir): ")
            cuantosSueldos = Console.ReadLine
            If cuantosSueldos = -1 Then

                Borrado()
                Ejercicio20ManualVisualBasic2019Jorge()

            End If
            ReDim sueldo(cuantosSueldos)
            Dim f As Integer
            For f = 0 To cuantosSueldos
                Console.SetCursorPosition(10, 7)
                Console.Write("el Sueldo {0} de {0}: " & f, cuantosSueldos)
                sueldo(f) = Console.ReadLine

            Next


        End Sub
        Public Sub ordenar()

        End Sub
    End Class
    Sub Main()
        ' Plantilla Ejercicio20ManualVisualBasic2019Jorge
        ' En esta plantilla tendrás lo basico para crear un menu
        ' con un marco que podras ver como se crear mas rapido lento
        ' segundo aumentes o bajes el valor del for en el metodo Temprizador
        Ejercicio20ManualVisualBasic2019Jorge()

    End Sub
    Sub Ejercicio20ManualVisualBasic2019Jorge()

        Marco()
        'El menu que haty aqui lo puedes modidicarr a tu gusto 
        'Conserva la numeraracion y sustitulle el resto del texto a tus necesidads
        Console.SetCursorPosition(10, 2)
        Console.Write("Ejercicio20ManualVisualBasic2019Jorge")
        Console.SetCursorPosition(5, 5)
        Console.Write("0.- Salida")
        Console.SetCursorPosition(5, 7)
        Console.Write("1.- Oocion 1")
        Console.SetCursorPosition(5, 9)
        Console.Write("2. -Opcion 2")
        'Añadrir mas opciones segun vuestras necesidades

        Dim Opcion As Integer
        Dim verdad As Boolean
        ' el sigyiente codigo controla que se introduzca un valor correcto
        Do
            Try
                Console.SetCursorPosition(10, 15)
                Console.Write("elija opcion: ")
                Opcion = Console.ReadLine()
                Eleccion(Opcion)
                verdad = True

            Catch ex As Exception
                Console.SetCursorPosition(10, 17)
                Console.Write("valor introducido no valido")
                verdad = False

            End Try

        Loop Until verdad = True


    End Sub
    Sub Marco()
        Dim Fila As Integer
        Dim Columna As Integer
        For Columna = 0 To 80
            Console.SetCursorPosition(Columna, 0)
            Console.Write("*")
            Temporizador()

        Next
        For Fila = 0 To 21
            Console.SetCursorPosition(80, Fila)
            Console.Write("*")
            Temporizador()

        Next
        For Columna = 80 To 0 Step -1

            Console.SetCursorPosition(Columna, 21)
            Console.Write("*")
            Temporizador()

        Next
        For Fila = 21 To 0 Step -1
            Console.SetCursorPosition(0, Fila)
            Console.Write("*")
            Temporizador()

        Next

    End Sub
    Sub Temporizador()
        ' Este pequello codigo hace la vez de temporizador 
        Dim tempo As Double
        For tempo = 0 To 100000000

        Next
    End Sub
    Sub Eleccion(opcion)
        ' este codigo distribulle el resto de opcines de codigo
        Select Case opcion
            Case 0
                Salida()
                Return
            Case 1
                ' Aqui meter nuevo codigo
            Case 2
                'Aqui metes nevo codigo

            Case Else

                'Una opcion para Controlar  las ociones no aceptadas
                OpcionErronea()
        End Select
    End Sub

    Private Sub OpcionErronea()
        'En  este Metodo controlamos si los numeros introduciodos no son reconocido por el select Case anterior 
        Borrado()
        Marco()


        Console.SetCursorPosition(10, 10)
        Console.Write("OPcion no reconocida")
        Console.ReadKey()
        Borrado()

        Ejercicio20ManualVisualBasic2019Jorge()
    End Sub

    Private Sub Salida()
        Borrado()
        Marco()
        Console.SetCursorPosition(10, 10)
        Console.Write("Gracias pr utilizar la aplicacon")
        Console.ReadKey()
        Borrado()
        End
    End Sub

    Sub Borrado()
        ' este cdigo hace una subifda de pantalla imitando un borrado hasta el efectvo
        Dim Borra As Integer
        For Borra = 0 To 50
            Console.WriteLine()
            Temporizador()

        Next
        Console.Clear()

    End Sub
End Module
