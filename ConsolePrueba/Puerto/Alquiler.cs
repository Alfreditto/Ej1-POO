namespace ConsolePrueba.Puerto;

public class Alquiler
{
    private String _nombreCliente;
    private String _dniCliente;
    private DateTime _fechaInicio;
    private DateTime _fechaFin;
    private int _posicion;
    private Barco _barco;

    public Barco Barco => _barco;

    public Alquiler(string nombreCliente, string dniCliente, DateTime fechaInicio, DateTime fechaFin, int posicion,
        Barco barco)
    {
        _nombreCliente = nombreCliente;
        _dniCliente = dniCliente;
        _fechaInicio = fechaInicio;
        _fechaFin = fechaFin;
        _posicion = posicion;
        _barco = barco;
    }

    public int CalcularPrecioAlquiler()
    {
        int diasAlquiler = (_fechaFin - _fechaInicio).Days;
        int modulo = _barco.CalcularModulo();
        return diasAlquiler * modulo * 12;
    }
}