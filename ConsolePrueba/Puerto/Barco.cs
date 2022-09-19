namespace ConsolePrueba.Puerto;

public abstract class Barco
{
    private String _matricula;
    private int _eslora;
    private int _annoFabricacion;

    public Barco()
    {
    }

    public Barco(string matricula, int eslora, int annoFabricacion)
    {
        _matricula = matricula;
        _eslora = eslora;
        _annoFabricacion = annoFabricacion;
    }

    public string Matricula => _matricula;

    public int Eslora => _eslora;

    public int AnnoFabricacion => _annoFabricacion;
    public abstract int CalcularModulo();
}