using duel.Interfaces;

namespace duel.Classes;

public class Elfe: Guerrier, Icombattant
{
    private int magie;
    
    public Elfe() : base() {} // nécessaire pour la désérialisation
    public Elfe(string nom, int pointsDeVie, int nbDesAttaque, int magie) : base(nom, pointsDeVie, nbDesAttaque)
    {
        this.magie = magie;
    }
    
    public int Magie { get => this.magie; set => this.magie = value; }

    public override int Attaquer()
    {
        Random random  = new Random();
        int totalDamage = 0;
        for (int i = 0; i < NbDesAttaque; i++)
        {
            totalDamage += random.Next(1, 7);
        }

        if (totalDamage <= NbDesAttaque)
        {
            totalDamage =  NbDesAttaque;
        }

        totalDamage += Magie / 3;
        
        return totalDamage;
    }
    
    
}