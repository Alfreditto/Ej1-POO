namespace ConsolePrueba.Puerto;

public class Puerto
{
    private List<Alquiler> _alquileres = new List<Alquiler>();

    public Puerto()
    {
        Alquiler alquiler = ConseguirAlquilerBarco();
        _alquileres.Add(alquiler);
        Alquiler alquiler2 = ConseguirAlquilerVelero();
        _alquileres.Add(alquiler2);
        _alquileres.ForEach(x => Console.WriteLine(x.CalcularPrecioAlquiler()));
    }

    private Alquiler ConseguirAlquilerVelero()
    {
        string nombreCliente = "Antonio";
        string dniCliente = "0999999";
        DateTime fechaInicio = DateTime.Today;
        DateTime fechaFin = DateTime.Today.AddDays(15);
        int posicion = 15;
        Barco barco = new Velero("123", 2, 15, 2020);
        Alquiler alquiler = new Alquiler(nombreCliente, dniCliente, fechaInicio, fechaFin, posicion, barco);
        return alquiler;
    }

    private static Alquiler ConseguirAlquilerBarco()
    {
        string nombreCliente = "Antonio";
        string dniCliente = "0999999";
        DateTime fechaInicio = DateTime.Today;
        DateTime fechaFin = DateTime.Today.AddDays(15);
        int posicion = 15;
        Barco barco = new Simple("123", 15, 2020);
        Alquiler alquiler = new Alquiler(nombreCliente, dniCliente, fechaInicio, fechaFin, posicion, barco);
        return alquiler;
    }
}