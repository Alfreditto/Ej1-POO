using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrueba.Biblioteca
{
    internal class Libro
    {
        private String titulo;
        private string autor;
        private String estilo;
        private String editorial;

        public Libro(string titulo, string autor, string estilo, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.estilo = estilo;
            this.editorial = editorial;
        }
    }
}