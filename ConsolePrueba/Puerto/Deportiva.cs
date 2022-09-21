namespace ConsolePrueba.Puerto;

public class Deportiva : Barco, modCalc
{
    private int _cv;

    public Deportiva(string matricula, int eslora, int annoFabricacion, int cv) : base(matricula, eslora,
        annoFabricacion)
    {
        _cv = cv;
    }

    public int Cv
    {
        get => _cv;
        set => _cv = value;
    }

    public int CalcularModulo()
    {
        return 10 * Eslora + _cv;
    }
}