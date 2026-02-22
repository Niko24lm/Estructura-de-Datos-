using System;
using System.Collections.Generic;
using System.Linq;

namespace VacunacionCOVID
{
    class Program
    {
        static void Main(string[] args)
        {
            // Universo: 500 ciudadanos
            HashSet<string> ciudadanos = new HashSet<string>();
            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add($"Ciudadano {i}");
            }

            // Conjunto Pfizer (75 ciudadanos)
            HashSet<string> pfizer = new HashSet<string>();
            for (int i = 1; i <= 75; i++)
            {
                pfizer.Add($"Ciudadano {i}");
            }

            // Conjunto AstraZeneca (75 ciudadanos)
            HashSet<string> astraZeneca = new HashSet<string>();
            for (int i = 50; i < 125; i++)
            {
                astraZeneca.Add($"Ciudadano {i}");
            }

            // Operaciones de teoría de conjuntos

            // Vacunados con ambas dosis
            HashSet<string> ambasDosis = new HashSet<string>(pfizer);
            ambasDosis.IntersectWith(astraZeneca);

            // Solo Pfizer
            HashSet<string> soloPfizer = new HashSet<string>(pfizer);
            soloPfizer.ExceptWith(astraZeneca);

            // Solo AstraZeneca
            HashSet<string> soloAstraZeneca = new HashSet<string>(astraZeneca);
            soloAstraZeneca.ExceptWith(pfizer);

            // No vacunados
            HashSet<string> vacunados = new HashSet<string>(pfizer);
            vacunados.UnionWith(astraZeneca);

            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunados);

            // Mostrar resultados
            MostrarListado("Ciudadanos no vacunados", noVacunados);
            MostrarListado("Ciudadanos con ambas dosis", ambasDosis);
            MostrarListado("Ciudadanos solo Pfizer", soloPfizer);
            MostrarListado("Ciudadanos solo AstraZeneca", soloAstraZeneca);
        }

        static void MostrarListado(string titulo, HashSet<string> lista)
        {
            Console.WriteLine($"\n{titulo} (Total: {lista.Count})");
            Console.WriteLine(new string('-', 40));
            foreach (var ciudadano in lista)
            {
                Console.WriteLine(ciudadano);
            }
        }
    }
}