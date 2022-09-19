
namespace ConsolePrueba
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Que ejercicio quieres ejecutar 1, 2 o 3");
            switch (Console.ReadLine())
            {
                case "1":
                    new Calendario();
                    break;
                case "2": new Biblioteca.Biblioteca();
                    break;
                //case "3":;
            }
        }
    }
}