namespace duel.Classes;

public class Berserker : Guerrier
{
    private bool furieUtilisee = false;
    private int pointsDeVieMax;

    public Berserker(string nom, int pointsDeVie, int nbDesAttaque)
        : base(nom, pointsDeVie, nbDesAttaque)
    {
        pointsDeVieMax = pointsDeVie;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"\n{nom}, le Berserker entre en combat !");
        Console.ResetColor();
    }

    public override int Attaquer()
    {
        int degats = base.Attaquer();

        if (PointsDeVie < pointsDeVieMax * 0.5)
        {
            Console.WriteLine(" Le Berserker frappe plus fort dans sa rage !");
            degats += 4;
        }

        if (!furieUtilisee && PointsDeVie < pointsDeVieMax * 0.3)
        {
            furieUtilisee = true;
            Console.WriteLine(" Le Berserker entre en furie ! Dégâts doublés !");
            degats *= 2;
        }

        return degats;
    }

    public override void Reset()
    {
        base.Reset();
        furieUtilisee = false;
        PointsDeVie = pointsDeVieMax;
    }
}