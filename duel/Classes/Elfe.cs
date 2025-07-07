using duel.Interfaces;

namespace duel.Classes;

public class Elfe: Guerrier, Icombattant
{
    private int magie;
    
    public Elfe(string nom, int pointsDeVie, int nbDesAttaque, int magie) : base(nom, pointsDeVie, nbDesAttaque)
    {
        this.magie = magie;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\n{nom}, l'elfe guerrier se prépare pour combattre pour son peuple !");
        Console.ResetColor();
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