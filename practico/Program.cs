using System;
using System.Collections.Generic;

// 1. LÓGICA DIRECTA (Punto de entrada)
AtraccionParque montañaRusa = new AtraccionParque();

Console.WriteLine("--- SIMULACIÓN DE ATRACCIÓN (30 ASIENTOS) ---");

// Registro de prueba
montañaRusa.RegistrarVisitante("Ana López");
montañaRusa.RegistrarVisitante("Pedro Vaca");
montañaRusa.RegistrarVisitante("Luis Ortiz");

// Mostrar Reporte
montañaRusa.MostrarReporte();

// 2. DEFINICIÓN DE CLASES
public class Visitante
{
    public string Nombre { get; set; } = string.Empty; 
    public int NumeroAsiento { get; set; }

    public Visitante(string nombre, int asiento)
    {
        Nombre = nombre;
        NumeroAsiento = asiento;
    }
}

public class AtraccionParque
{
    private Queue<Visitante> colaEspera = new Queue<Visitante>();
    private const int LimiteAsientos = 30; 
    private int contadorAsientos = 0;

    public void RegistrarVisitante(string nombre)
    {
        if (contadorAsientos < LimiteAsientos)
        {
            contadorAsientos++;
            Visitante nuevo = new Visitante(nombre, contadorAsientos);
            colaEspera.Enqueue(nuevo);
            Console.WriteLine($"[OK] {nombre} registrado. Asiento: {contadorAsientos}");
        }
        else
        {
            Console.WriteLine("[ERROR] Capacidad máxima alcanzada.");
        }
    }

    public void MostrarReporte()
    {
        Console.WriteLine("\n--- LISTA DE PASAJEROS ---");
        foreach (var v in colaEspera)
        {
            Console.WriteLine($"Asiento #{v.NumeroAsiento}: {v.Nombre}");
        }
        Console.WriteLine($"\nEstado: {colaEspera.Count}/{LimiteAsientos} asientos ocupados.");
    }
}
