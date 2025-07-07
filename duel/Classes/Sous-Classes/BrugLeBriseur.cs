namespace duel.Classes.Sous_Classes;

public class BrugLeBriseur: Monstre
{
    private string titre;
    public BrugLeBriseur(string nom, string titre, int pointsDeVie, int nbDesAttaque, int experience)
        : base(nom, pointsDeVie, nbDesAttaque, experience)
    {
        this.titre = titre;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($" l’Ogre Massif {Nom} se jette sur le combattant fatigué, prêt à l'assommer avec sa massue !");
        Console.ResetColor();
    }
}