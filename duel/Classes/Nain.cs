using duel.Interfaces;

namespace duel.Classes;

public class Nain: Guerrier, Icombattant
{
    private bool armureLourde;
    public Nain(string nom, int pointsDeVie, int nbDesAttaque, bool armureLourde) : base(nom, pointsDeVie, nbDesAttaque)
    {
        this.armureLourde = armureLourde;
    }

    public override void SubirDegats(int degats)
    {
        Console.Write(PointsDeVie);
        PointsDeVie -= degats;
        Console.WriteLine($" - {degats} = {PointsDeVie} de point de vie actuel");
        if (armureLourde != false)
        {
            degats = degats / 2;
        }
    }
}