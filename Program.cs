var generadorAleatorio = new Random();
int numeroParaAdivinar = generadorAleatorio.Next(1, 15);
int vidas  = 3;
Console.WriteLine("Bienvenido al juego de adivinar el número!");
Console.WriteLine();
Console.WriteLine("Este juego consiste en que tu tendrás que adivinar un número aleatorio, pero solo dispones de 3 intentos ");
Console.WriteLine("Escoge un número del 1 al 15");
for (vidas = 3; vidas > 0; vidas--)
    {
        string opcionElegida = Console.ReadLine();
        int numeroElegido = Int32.Parse(opcionElegida);
        if (numeroElegido == numeroParaAdivinar)
        {
    Console.WriteLine("Bravo, a la primera, felicidades!!");
        }
        else if (numeroElegido > numeroParaAdivinar)
        {
            int vidasRestantes = (vidas-1);
            Console.WriteLine($"Lo siento, te has pasado, te quedan {vidasRestantes} vidas");
        }
        else if (numeroElegido < numeroParaAdivinar)
        {
            int vidasRestantes = (vidas-1);
            Console.WriteLine($"Lo siento, te has quedado corto, te quedan {vidasRestantes} vidas");
        }
    }


if (vidas == 0)
Console.WriteLine($"El número a adivinar era {numeroParaAdivinar}");