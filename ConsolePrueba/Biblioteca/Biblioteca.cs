using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrueba.Biblioteca
{
    internal class Biblioteca
    {
        private List<Libro> biblioteca = new List<Libro>();

        public Biblioteca()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Que quieres hacer?\n" +
                                  "1. Agrgar un libro\n" +
                                  "2. Ver el listado de libros\n" +
                                  "3. Modificar algun libro\n" +
                                  "4. Eliminar algun libro\n" +
                                  "5. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce el titulo: ");
                        String titulo = Console.ReadLine();
                        Console.Write("Autor :");
                        String autor = Console.ReadLine();
                        Console.Write("Estilo: ");
                        String estilo = Console.ReadLine();
                        Console.Write("Editorial: ");
                        String editorial = Console.ReadLine();
                        biblioteca.Add(new Libro(titulo, autor, estilo, editorial));
                        break;
                }
            } while (opcion != 5);
        }
    }
}