using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static int movimientos = 0;

    /// <summary>
    /// Resuelve el problema de las Torres de Hanoi usando pilas
    /// </summary>
    static void Hanoi(int n, Stack<int> origen, Stack<int> auxiliar, Stack<int> destino,
                      string nombreOrigen, string nombreAuxiliar, string nombreDestino)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino, nombreOrigen, nombreDestino);
            return;
        }

        Hanoi(n - 1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);
        MoverDisco(origen, destino, nombreOrigen, nombreDestino);
        Hanoi(n - 1, auxiliar, origen, destino, nombreAuxiliar, nombreOrigen, nombreDestino);
    }

    /// <summary>
    /// Mueve un disco entre torres y muestra el movimiento
    /// </summary>
    static void MoverDisco(Stack<int> origen, Stack<int> destino,
                           string nombreOrigen, string nombreDestino)
    {
        int disco = origen.Pop();
        destino.Push(disco);
        movimientos++;
        Console.WriteLine($"Movimiento {movimientos}: Disco {disco} de {nombreOrigen} a {nombreDestino}");
    }

    static void Main()
    {
        int numDiscos = 3;

        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        // Inicializar torre A
        for (int i = numDiscos; i >= 1; i--)
            torreA.Push(i);

        Console.WriteLine("Resolución de las Torres de Hanoi:\n");
        Hanoi(numDiscos, torreA, torreB, torreC, "A", "B", "C");

        Console.WriteLine($"\nTotal de movimientos: {movimientos}");
    }
}

