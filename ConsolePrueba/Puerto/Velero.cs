namespace ConsolePrueba.Puerto;

public class Velero : Barco, modCalc
{
    private int _numMastiles;


    public Velero(string matricula, int eslora, int annoFabricacion, int numMastiles) : base(matricula, eslora,
        annoFabricacion)
    {
        _numMastiles = numMastiles;
    }

    public int NumMastiles
    {
        get => _numMastiles;
        set => _numMastiles = value;
    }

    public int CalcularModulo()
    {
       return 10 * Eslora + _numMastiles;
    }
}