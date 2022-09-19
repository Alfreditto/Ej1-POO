// See https://aka.ms/new-console-template for more information

namespace ConsolePrueba
{
    class Calendario

    {
        public Calendario()
        {
            Console.WriteLine("Introduce la fecha dd/mm/aaaa");
            String fechaS = Console.ReadLine();
            String[] fechaA = fechaS.Split('/');
            int dia = Convert.ToInt32(fechaA[0]);
            int mes = Convert.ToInt32(fechaA[1]);
            int anno = Convert.ToInt32(fechaA[2]);
            DateTime fecha = new DateTime(anno, mes, dia);

            //Imprime el dia de la semana
            Console.WriteLine($"En la semana seria el dia: {fecha.DayOfWeek}");
            //Incrementamos la fecha
            Console.WriteLine($"La fecha en 15 dias sera el: {fecha.AddDays(15).ToShortDateString()}");
            //La diferencia de fecha entre hoy y la introducida
            Console.WriteLine(
                $"Hay una diferencia de: {fecha.Year - DateTime.Today.Year} años, {fecha.Month - DateTime.Today.Month} meses, {fecha.Day - DateTime.Today.Day} dias");
            //Conpara la fecha actual y la introducida
            Console.WriteLine(fecha > DateTime.Today
                ? "La fecha introducida es del futuro"
                : "La fecha introducida es del pasado");
            //Pasa la fecha a formato largo
            Console.WriteLine(fecha.ToLongDateString());
        }
    }
}