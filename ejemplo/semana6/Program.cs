using System;

namespace ListasEnlazadas
{
    // Nodo de la lista
    class Nodo
    {
        public int Dato;
        public Nodo Siguiente;

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Lista Enlazada
    class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Agregar elemento al final
        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // =========================
        // EJERCICIO 1:
        // Contar elementos de la lista
        // =========================
        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        // =========================
        // EJERCICIO 2:
        // Invertir la lista enlazada
        // =========================
        public void Invertir()
        {
            Nodo anterior = null;
            Nodo actual = cabeza;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }

            cabeza = anterior;
        }

        // Mostrar lista
        public void Mostrar()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            lista.Agregar(10);
            lista.Agregar(20);
            lista.Agregar(30);
            lista.Agregar(40);

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            Console.WriteLine("\nNúmero de elementos: " + lista.ContarElementos());

            lista.Invertir();
            Console.WriteLine("\nLista invertida:");
            lista.Mostrar();

            Console.ReadKey();
        }
    }
}

