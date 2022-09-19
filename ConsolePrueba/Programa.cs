namespace ConsolePrueba
{
    class Programa
    {
        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Que ejercicio quieres ejecutar\n" +
                                  "1. Calendario.\n" +
                                  "2. Biblioteca.\n" +
                                  "3. Alquiler Puerto.\n" +
                                  "4. Salir.");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Calendario cal = new Calendario();
                        break;
                    case 2:
                        Biblioteca.Biblioteca bib = new Biblioteca.Biblioteca();
                        break;
                    case 3:
                        Puerto.Puerto puerto = new Puerto.Puerto();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }
            } while (opcion != 4);
        }
    }
}