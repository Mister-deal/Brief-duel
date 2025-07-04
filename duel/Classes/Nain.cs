using duel.Interfaces;

namespace duel.Classes;

public class Nain : Guerrier, Icombattant
{
    private bool armureLourde;
    public Nain(string nom, int pointsDeVie, int nbDesAttaque, bool armureLourde) : base(nom, pointsDeVie, nbDesAttaque)
    {
        this.armureLourde = armureLourde;
    }

    public override void SubirDegats(int degats)
    {
        if (armureLourde != false)
        {
            degats /= 2;
        }
        base.SubirDegats(degats);
    }
}