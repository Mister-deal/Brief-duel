namespace duel.Classes.Sous_Classes;

public class AzarothLeFleau : Monstre
{
    private int pointsDeVieMax;
    private bool aUtiliseAttaqueUltime = false;
    private string titre;

    public AzarothLeFleau(string nom, string titre, int pointsDeVie, int nbDesAttaque, int experience)
        : base(nom, pointsDeVie, nbDesAttaque, experience)
    {
        this.titre = titre;
        pointsDeVieMax = pointsDeVie;

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"\n🌌 Une brèche s'ouvre dans le tissu de la réalité... Azaroth, le Fléau du Néant, apparaît !");
        Thread.Sleep(1000);
        Console.WriteLine("🌑 Sa présence seule fait vaciller les âmes faibles...");
        Console.ResetColor();
    }

    public override void AfficherInfos()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"☠️ Azaroth le Fléau : [PV = {PointsDeVie}, Dés = {NbDesAttaque}]");
        Console.ResetColor();
    }

    public override int Attaquer()
    {
        int totalDamage = 0;
        int nbDes = NbDesAttaque;

        if (PointsDeVie < pointsDeVieMax * 0.5)
        {
            nbDes += 3;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n💢 Azaroth s'enrage ! Le Néant se tord sous sa volonté !");
            Console.ResetColor();
        }

        if (!aUtiliseAttaqueUltime && PointsDeVie < pointsDeVieMax * 0.3)
        {
            aUtiliseAttaqueUltime = true;
            return AttaqueUltime();
        }

        Random random = new Random();
        for (int i = 0; i < nbDes; i++)
        {
            totalDamage += random.Next(1, 8); // Dés plus puissants
        }

        return totalDamage;
    }

    private int AttaqueUltime()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"\n🌠 Azaroth invoque son ATTAQUE ULTIME : 'Anéantissement Cosmique' !");
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.WriteLine("☄️ Les cieux s'assombrissent, le sol s'effondre...");
        Thread.Sleep(1000);
        Console.WriteLine("🕳️ Le néant aspire la lumière elle-même !");
        Thread.Sleep(1500);

        return 30 + new Random().Next(30, 51); // Dégâts de 60 à 80
    }

    public override void SubirDegats(int degats)
    {
        base.SubirDegats(degats);
        if (PointsDeVie > 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"🩸 Azaroth ne saigne pas... il absorbe vos attaques avec mépris.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n🔥 Azaroth pousse un hurlement cosmique alors qu'il est renvoyé dans l'abîme !");
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
        return $"Azaroth le Fléau";
    }
}