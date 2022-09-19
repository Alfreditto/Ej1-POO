namespace ConsolePrueba.Puerto;

public class Velero : Barco
{
    private int _numMastiles;


    public Velero(string matricula, int eslora, int annoFabricacion, int numMastiles) : base(matricula, eslora,
        annoFabricacion)
    {
        _numMastiles = numMastiles;
    }

    public int NumMastiles => _numMastiles;
    public override int CalcularModulo()
    {
       return 10 * Eslora + _numMastiles;
    }
}