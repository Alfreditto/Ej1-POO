namespace ConsolePrueba.Puerto;

public class Simple : Barco
{
    public Simple()
    {
    }

    public Simple(string matricula, int eslora, int annoFabricacion) : base(matricula, eslora, annoFabricacion)
    {
    }
    

    public override int CalcularModulo()
    {
        return 10 * Eslora;
    }
}