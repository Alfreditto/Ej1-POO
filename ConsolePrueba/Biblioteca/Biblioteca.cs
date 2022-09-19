namespace ConsolePrueba.Biblioteca
{
    internal class Biblioteca
    {
        private readonly List<Libro> _biblioteca = new();

        public Biblioteca()
        {
            int opcion;
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
                        AnnadirLibro();
                        break;
                    case 2:
                        ImprimirLibros();
                        break;
                    case 3:
                        ModificarLibro();
                        break;
                    case 4:
                        EliminarLibro();
                        break;
                    case 5:
                        Console.WriteLine("Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opcion != 5);
        }

        private void EliminarLibro()
        {
            Console.WriteLine("Cual es el titulo del libro a eliminar?");
            ImprimirLibros();
            string tituloSearch = Conseguirdato();
            Libro? libroBorrar = _biblioteca.Find(x => x.Titulo == tituloSearch);
            if (libroBorrar != null)
            {
                _biblioteca.Remove(libroBorrar);
                Console.WriteLine("Libro eliminado");
            }
            else
            {
                Console.WriteLine("No se ha encontrado el libro");
            }
        }

        private void ModificarLibro()
        {
            Console.WriteLine("Introduce el titulo del libro que quieres modificar");
            ImprimirLibros();
            String tituloSearch = Conseguirdato();
            Libro? libroACambiar = _biblioteca.Find(x => x.Titulo == tituloSearch);
            if (libroACambiar is not null)
            {
                Console.WriteLine("Que quieres modificar?\n" +
                                  "1. Titulo\n" +
                                  "2. Autor\n" +
                                  "3. Estilo\n" +
                                  "4. Editorial\n" +
                                  "5. Salir");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Introduce el nuevo titulo");
                        String tituloCambiar = Conseguirdato();
                        _biblioteca[_biblioteca.IndexOf(libroACambiar)].Titulo = tituloCambiar;
                        break;
                    case 2:
                        Console.WriteLine("Introduce el nuevo autor");
                        String autorCambiar = Conseguirdato();
                        _biblioteca[_biblioteca.IndexOf(libroACambiar)].Autor = autorCambiar;
                        break;
                    case 3:
                        Console.WriteLine("Introduce el nuevo estilo");
                        String estiloCambiar = Conseguirdato();
                        _biblioteca[_biblioteca.IndexOf(libroACambiar)].Estilo = estiloCambiar;
                        break;
                    case 4:
                        Console.WriteLine("Introduce la nueva editorial");
                        String editorialCambiar = Conseguirdato();
                        _biblioteca[_biblioteca.IndexOf(libroACambiar)].Editorial = editorialCambiar;
                        break;
                    case 5:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("nombre no valido");
            }
        }

        private static string Conseguirdato()
        {
            String? aux;
            do
            {
                aux = Console.ReadLine();
                if (aux is null or "")
                {
                    Console.WriteLine("Null/Vacios no validos");
                }
            } while (aux == "");

            return aux!;
        }

        private void ImprimirLibros()
        {
            _biblioteca.ForEach(Console.WriteLine);
            Console.WriteLine();
        }

        private void AnnadirLibro()
        {
            Console.Write("Introduce el titulo: ");
            String titulo = Conseguirdato();
            Console.Write("Autor :");
            String autor = Conseguirdato();
            Console.Write("Estilo: ");
            String estilo = Conseguirdato();
            Console.Write("Editorial: ");
            String editorial = Conseguirdato();
            _biblioteca.Add(new Libro(titulo, autor, estilo, editorial));
        }
    }
}