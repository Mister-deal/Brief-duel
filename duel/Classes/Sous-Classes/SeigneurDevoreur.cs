namespace duel.Classes.Sous_Classes;

public class SeigneurDevoreur : Monstre
{
    private string titre;
    private int pointsDeVieMax;
    private bool aUtiliseAttaqueUltime = false;

    public SeigneurDevoreur(string nom, string titre, int pointsDeVie, int nbDesAttaque, int experience)
        : base(nom, pointsDeVie, nbDesAttaque, experience)
    {
        this.titre = titre;
        this.pointsDeVieMax = pointsDeVie;

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"\n️ {titre} {Nom} émerge des ténèbres ! Tremblez, misérables ! ⚠️\n");
        Console.ResetColor();
    }

    public override void AfficherInfos()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{titre} {Nom} : [PV = {PointsDeVie}, Dés = {NbDesAttaque}]");
        Console.ResetColor();
    }

    public override int Attaquer()
    {
        int totalDamage = 0;
        int nbDes = NbDesAttaque;

        if (PointsDeVie < pointsDeVieMax * 0.3)
        {
            nbDes += 2;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n {titre} {Nom} entre en RAGE ! Ses attaques deviennent féroces ! 🔥");
            Console.ResetColor();
        }

        if (!aUtiliseAttaqueUltime && PointsDeVie < pointsDeVieMax * 0.2)
        {
            aUtiliseAttaqueUltime = true;
            return AttaqueUltime();
        }

        Random random = new Random();
        for (int i = 0; i < nbDes; i++)
        {
            totalDamage += random.Next(1, 7);
        }

        if (totalDamage <= NbDesAttaque)
        {
            totalDamage = NbDesAttaque;
        }

        return totalDamage;
    }

    private int AttaqueUltime()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"\n {titre} {Nom} libère son ATTAQUE ULTIME : 'Jugement Obscur' ! 💀");
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.WriteLine(" Un déluge de ténèbres s'abat sur le champ de bataille !");
        Thread.Sleep(1000);
        Console.WriteLine(" L'air se fissure, la terre tremble...");

        Thread.Sleep(1000);
        return 15 + new Random().Next(20, 41); // Dégâts entre 35 et 55
    }

    public override void SubirDegats(int degats)
    {
        base.SubirDegats(degats);
        if (PointsDeVie > 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"{titre} {Nom} gronde de fureur... il ne tombera pas si facilement !");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n {titre} {Nom} s'effondre dans un dernier râle de haine... ☠️");
            Console.ResetColor();
        }
    }

    public override void Reset()
    {
        base.Reset();
        PointsDeVie = pointsDeVieMax;
        aUtiliseAttaqueUltime = false;
    }

    public new string GetNom()
    {
        return $"{titre} {Nom}";
    }
}