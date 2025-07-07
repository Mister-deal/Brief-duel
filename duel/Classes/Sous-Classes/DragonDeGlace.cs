namespace duel.Classes.Sous_Classes;

public class DragonDeGlace : Monstre
{
    private int pointsDeVieMax;
    private bool aUtiliseAttaqueUltime = false;
    private string titre;

    public DragonDeGlace(string nom, string titre, int pointsDeVie, int nbDesAttaque, int experience)
        : base(nom, pointsDeVie, nbDesAttaque, experience)
    {
        this.titre = titre;
        pointsDeVieMax = pointsDeVie;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($" Le Dragon de Glace {Nom} surgit des montagnes gelées ! Préparez-vous au froid glacial !");
        Console.ResetColor();
    }

    public override void AfficherInfos()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Dragon de Glace {Nom} : [PV = {PointsDeVie}, Dés = {NbDesAttaque}]");
        Console.ResetColor();
    }

    public override int Attaquer()
    {
        int totalDamage = 0;
        int nbDes = NbDesAttaque;

        if (PointsDeVie < pointsDeVieMax * 0.3)
        {
            nbDes += 2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" Dragon de Glace {Nom} est en furie glaciale ! Ses attaques se renforcent !");
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
            totalDamage = NbDesAttaque;

        return totalDamage;
    }

    private int AttaqueUltime()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($" Dragon de Glace {Nom} déclenche son ATTAQUE ULTIME : 'Tempête de Glace' !");
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.WriteLine(" Un blizzard furieux enveloppe le champ de bataille !");
        Thread.Sleep(1000);
        Console.WriteLine(" Le froid mordant gèle tout sur son passage...");
        Thread.Sleep(1000);

        return 15 + new Random().Next(15, 36); // Dégâts entre 30 et 50 environ
    }

    public override void SubirDegats(int degats)
    {
        base.SubirDegats(degats);
        if (PointsDeVie > 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Dragon de Glace {Nom} rugit malgré la douleur... le gel ne le brisera pas !");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($" Dragon de Glace {Nom} s'effondre, emporté par la chaleur ennemie...");
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
        return $"Dragon de Glace {Nom}";
    }
}