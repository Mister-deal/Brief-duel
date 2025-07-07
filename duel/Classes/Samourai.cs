namespace duel.Classes;

public class Samourai : Guerrier
{
    private int pointsDeVieMax;
    private bool postureDefensive = false;

    public Samourai(string nom, int pointsDeVie, int nbDesAttaque)
        : base(nom, pointsDeVie, nbDesAttaque)
    {
        pointsDeVieMax = pointsDeVie;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\n {nom}, le Samouraï, entre en scène avec honneur !");
        Console.ResetColor();
    }

    public override int Attaquer()
    {
        int degats = base.Attaquer();

        if (PointsDeVie < pointsDeVieMax * 0.4 && !postureDefensive)
        {
            postureDefensive = true;
            Console.WriteLine(" Le Samouraï adopte une posture défensive pour réduire les dégâts reçus !");
        }

        if (postureDefensive)
        {
            degats += 3; // attaque plus précise et plus forte en défense
            Console.WriteLine(" Attaque concentrée et précise !");
        }

        return degats;
    }

    public override void SubirDegats(int degats)
    {
        if (postureDefensive)
        {
            degats = (int)(degats * 0.7); // réduit les dégâts de 30%
        }

        base.SubirDegats(degats);
    }

    public override void Reset()
    {
        base.Reset();
        postureDefensive = false;
        PointsDeVie = pointsDeVieMax;
    }
}