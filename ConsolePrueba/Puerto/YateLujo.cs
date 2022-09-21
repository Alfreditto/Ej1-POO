namespace ConsolePrueba.Puerto;

public class YateLujo : Barco, modCalc
{
    private int _numCamarotes;
    private int _cv;

    public YateLujo(int numCamarotes, int cv)
    {
        _numCamarotes = numCamarotes;
        _cv = cv;
    }

    public YateLujo(string matricula, int eslora, int annoFabricacion, int numCamarotes, int cv) : base(matricula,
        eslora, annoFabricacion)
    {
        _numCamarotes = numCamarotes;
        _cv = cv;
    }

    public int NumCamarotes
    {
        get => _numCamarotes;
        set => _numCamarotes = value;
    }

    public int Cv
    {
        get => _cv;
        set => _cv = value;
    }

    public int CalcularModulo()
    {
        return 10 * Eslora + _cv + _numCamarotes;
    }
}