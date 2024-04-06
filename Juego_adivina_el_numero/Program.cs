//Declaración de variables
//Llamar al objeto Random
Random random = new Random();
int numeroSecreto = random.Next(1,101);
int entrada;
int jugadores = 0;
bool repetir = true;
string nuevoint;

//Empezamos a dar la estructura del juego
Console.WriteLine("Bienvenido al juego Adivina el número, disfruta");
Console.WriteLine();

while(repetir == true)
{
    do
    {
        Console.WriteLine("Por favor ingrese la cantidad de jugadores que participarán: ");
        jugadores = Convert.ToInt32(Console.ReadLine());
        if (jugadores == 2)
        {
            Console.WriteLine("El número aleatorio se generará entre 0 y 50");
            numeroSecreto = random.Next(1, 51);
        }
        else if (jugadores == 3)
        {
            Console.WriteLine("El número aleatorio se generará entre 0 y 100");
            numeroSecreto = random.Next(1, 100);
        }
        else if (jugadores == 4)
        {
            Console.WriteLine("El número aleatorio se generará entre 0 y 200");
            numeroSecreto = random.Next(1, 200);
        }
        else Console.WriteLine("La cantidad de jugadores ingresada no es válida");
    } while (jugadores > 4);


    Console.WriteLine("Ya pensé en un número, adivinalo!!");
    bool adivinado = false;
    while (adivinado == false)
    {
        for (int jugadorActual = 1; jugadorActual <= jugadores; jugadorActual++)
        {
            Console.WriteLine($"Jugador {jugadorActual}, es tu turno.");
            entrada = Convert.ToInt32(Console.ReadLine());
            if (entrada < numeroSecreto)
            {
                Console.WriteLine("MAYOR");
            }
            else if (entrada > numeroSecreto)
            {
                Console.WriteLine("MENOR");
            }
            else
            {
                Console.WriteLine("¡HAS GANADO, FELICIDADES!");
                adivinado = true;
                break;
            }
        }
    }
    Console.WriteLine("¿Deseas jugar nuevamente? (s/n)");
    nuevoint = Console.ReadLine();
    if (nuevoint == "s")
    {
        repetir = true;
        Console.Clear();
    }
    else if (nuevoint == "n")
    {
        repetir = false;
    }
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Muchas gracias por jugar, vuelve pronto");
Console.ResetColor();



