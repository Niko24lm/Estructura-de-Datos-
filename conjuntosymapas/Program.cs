using System;
using System.Collections.Generic;

namespace BibliotecaUEA
{
    // Clase que representa la entidad Libro
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }

        public override string ToString()
        {
            return $"[ID: {Id}] Título: {Titulo} | Autor: {Autor} | Categoría: {Categoria}";
        }
    }

    // Estructura 1: Árbol Binario de Búsqueda (BST) para organización jerárquica
    public class Nodo
    {
        public Libro Libro;
        public Nodo Izquierdo, Derecho;
        public Nodo(Libro libro) { Libro = libro; }
    }

    public class ArbolLibros
    {
        public Nodo Raiz;

        public void Insertar(Libro nuevoLibro)
        {
            Raiz = InsertarRecursivo(Raiz, nuevoLibro);
        }

        private Nodo InsertarRecursivo(Nodo raiz, Libro libro)
        {
            if (raiz == null) return new Nodo(libro);
            if (libro.Id < raiz.Libro.Id) raiz.Izquierdo = InsertarRecursivo(raiz.Izquierdo, libro);
            else if (libro.Id > raiz.Libro.Id) raiz.Derecho = InsertarRecursivo(raiz.Derecho, libro);
            return raiz;
        }

        public void MostrarEnOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                MostrarEnOrden(raiz.Izquierdo);
                Console.WriteLine(raiz.Libro);
                MostrarEnOrden(raiz.Derecho);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Estructura 2: Mapa (Dictionary) para acceso directo y reportería eficiente
            Dictionary<int, Libro> mapaLibros = new Dictionary<int, Libro>();

            // Estructura 3: Conjunto (HashSet) para categorías únicas sin duplicados
            HashSet<string> categoriasUnicas = new HashSet<string>();

            ArbolLibros arbol = new ArbolLibros();

            // Simulación de ingreso de datos
            AgregarLibro(101, "Estructuras de Datos", "Joyanes Aguilar", "Programación", arbol, mapaLibros, categoriasUnicas);
            AgregarLibro(105, "C# Avanzado", "Anders Hejlsberg", "Software", arbol, mapaLibros, categoriasUnicas);
            AgregarLibro(103, "Algoritmos Genéticos", "John Holland", "IA", arbol, mapaLibros, categoriasUnicas);

            // REPORTERÍA
            Console.WriteLine("=== REPORTE DE BIBLIOTECA (Ordenado por ID vía Árbol Binario) ===");
            arbol.MostrarEnOrden(arbol.Raiz);

            Console.WriteLine("\n=== CONSULTA RÁPIDA (Vía Mapa/Dictionary) ===");
            int buscarId = 103;
            if (mapaLibros.ContainsKey(buscarId))
                Console.WriteLine($"Libro Encontrado: {mapaLibros[buscarId].Titulo}");

            Console.WriteLine("\n=== CATEGORÍAS DISPONIBLES (Vía Conjuntos/HashSet) ===");
            foreach (var cat in categoriasUnicas)
                Console.WriteLine($"- {cat}");
        }

        static void AgregarLibro(int id, string titulo, string autor, string categoria, 
                                ArbolLibros arbol, Dictionary<int, Libro> mapa, HashSet<string> categorias)
        {
            Libro nuevo = new Libro { Id = id, Titulo = titulo, Autor = autor, Categoria = categoria };
            arbol.Insertar(nuevo);
            mapa.Add(id, nuevo);
            categorias.Add(categoria);
        }
    }
}