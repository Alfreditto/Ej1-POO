namespace ConsolePrueba.Puerto;

public class Deportiva : Barco
{
    private int _cv;

    public Deportiva(string matricula, int eslora, int annoFabricacion, int cv) : base(matricula, eslora,
        annoFabricacion)
    {
        _cv = cv;
    }

    public override int CalcularModulo()
    {
        return 10 * Eslora + _cv;
    }
}