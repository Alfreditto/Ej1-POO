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

    public string Matricula
    {
        get => _matricula;
        set => _matricula = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Eslora
    {
        get => _eslora;
        set => _eslora = value;
    }

    public int AnnoFabricacion
    {
        get => _annoFabricacion;
        set => _annoFabricacion = value;
    }

    public abstract int CalcularModulo();
}