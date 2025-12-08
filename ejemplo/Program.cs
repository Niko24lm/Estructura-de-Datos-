// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

namespace FigurasGeometricas
{
    // Clase Circulo: Representa un círculo con encapsulación de su radio.
    // El radio es un dato primitivo (double) que se accede mediante propiedades.
    public class Circulo
    {
        // Propiedad privada para encapsular el radio del círculo.
        // Se utiliza un campo privado y una propiedad pública para controlar el acceso.
        private double _radio;

        // Propiedad pública para acceder y modificar el radio.
        // Incluye validación para asegurar que el radio sea positivo.
        public double Radio
        {
            get { return _radio; }
            set
            {
                if (value > 0)
                    _radio = value;
                else
                    throw new ArgumentException("El radio debe ser un valor positivo.");
            }
        }

        // Constructor para inicializar el círculo con un radio dado.
        // Requiere como argumento el radio del círculo.
        public Circulo(double radio)
        {
            Radio = radio;
        }

        // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un círculo, requiere como argumento el radio del círculo.
        // La fórmula es Área = π * radio².
        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro de un círculo, requiere como argumento el radio del círculo.
        // La fórmula es Perímetro = 2 * π * radio.
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }

    // Clase Rectangulo: Representa un rectángulo con encapsulación de su ancho y alto.
    // El ancho y alto son datos primitivos (double) que se acceden mediante propiedades.
    public class Rectangulo
    {
        // Propiedades privadas para encapsular el ancho y alto del rectángulo.
        // Se utilizan campos privados y propiedades públicas para controlar el acceso.
        private double _ancho;
        private double _alto;

        // Propiedad pública para acceder y modificar el ancho.
        // Incluye validación para asegurar que el ancho sea positivo.
        public double Ancho
        {
            get { return _ancho; }
            set
            {
                if (value > 0)
                    _ancho = value;
                else
                    throw new ArgumentException("El ancho debe ser un valor positivo.");
            }
        }

        // Propiedad pública para acceder y modificar el alto.
        // Incluye validación para asegurar que el alto sea positivo.
        public double Alto
        {
            get { return _alto; }
            set
            {
                if (value > 0)
                    _alto = value;
                else
                    throw new ArgumentException("El alto debe ser un valor positivo.");
            }
        }

        // Constructor para inicializar el rectángulo con ancho y alto dados.
        // Requiere como argumentos el ancho y el alto del rectángulo.
        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un rectángulo, requiere como argumentos el ancho y el alto del rectángulo.
        // La fórmula es Área = ancho * alto.
        public double CalcularArea()
        {
            return Ancho * Alto;
        }

        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro de un rectángulo, requiere como argumentos el ancho y el alto del rectángulo.
        // La fórmula es Perímetro = 2 * (ancho + alto).
        public double CalcularPerimetro()
        {
            return 2 * (Ancho + Alto);
        }
    }

    // Clase principal para probar las figuras.
    // Esta clase contiene el método Main para ejecutar el programa y mostrar resultados.
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Circulo con radio 5.
            Circulo circulo = new Circulo(5.0);
            Console.WriteLine("Círculo:");
            Console.WriteLine($"Radio: {circulo.Radio}");
            Console.WriteLine($"Área: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}");
            Console.WriteLine();

            // Crear una instancia de Rectangulo con ancho 4 y alto 6.
            Rectangulo rectangulo = new Rectangulo(4.0, 6.0);
            Console.WriteLine("Rectángulo:");
            Console.WriteLine($"Ancho: {rectangulo.Ancho}, Alto: {rectangulo.Alto}");
            Console.WriteLine($"Área: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}");
            Console.WriteLine();

            // Esperar a que el usuario presione una tecla para cerrar.
            Console.ReadKey();
        }
    }
}

