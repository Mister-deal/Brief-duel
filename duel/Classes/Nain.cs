using duel.Interfaces;

namespace duel.Classes;

public class Nain : Guerrier, Icombattant
{
    private bool armureLourde;
    
    public Nain(string nom, int pointsDeVie, int nbDesAttaque, bool armureLourde) : base(nom, pointsDeVie, nbDesAttaque)
    {
        this.armureLourde = armureLourde;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\n{nom}, le saint guerrier nain est prêt à tout pour le royaume nain !");
        Console.ResetColor();
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