using duel.Interfaces;

namespace duel.Classes;

public class Nain : Guerrier, Icombattant
{
    private bool armureLourde;
    
    public Nain() : base() {} // nécessaire pour la désérialisation
    public Nain(string nom, int pointsDeVie, int nbDesAttaque, bool armureLourde) : base(nom, pointsDeVie, nbDesAttaque)
    {
        this.armureLourde = armureLourde;
    }
    
    public bool ArmureLourde { get => armureLourde; set => armureLourde = value; }

    public override void SubirDegats(int degats)
    {
        if (ArmureLourde != false)
        {
            degats /= 2;
        }
        base.SubirDegats(degats);
    }
}