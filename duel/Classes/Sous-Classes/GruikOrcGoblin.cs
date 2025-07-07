namespace duel.Classes.Sous_Classes;

public class GruikOrcGoblin : Monstre
{
    private readonly int _pointsDeVieMax;
    private bool _aUtiliseAttaqueUltime = false;
    private readonly string _titre;

    public GruikOrcGoblin(string nom, string titre, int pointsDeVie, int nbDesAttaque, int experience)
        : base(nom, pointsDeVie, nbDesAttaque, experience)
    {
        _pointsDeVieMax = pointsDeVie;
        _titre = titre;
    }

    public override void AfficherInfos()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{Nom} « {_titre} » : [PV= {PointsDeVie}/{_pointsDeVieMax}, Nbr dés= {NbDesAttaque}]");
        Console.ResetColor();
    }

    public override int Attaquer()
    {
        // Si moins de 50% de vie et attaque ultime pas encore utilisée
        if (!_aUtiliseAttaqueUltime && PointsDeVie < _pointsDeVieMax / 2)
        {
            _aUtiliseAttaqueUltime = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Nom} hurle : \"GRUIIIIIK !!!\" et lance son attaque ultime !");
            Console.ResetColor();

            // Attaque boostée : +20 dégâts en plus des dés
            return base.Attaquer() + 20;
        }
        return base.Attaquer();
    }

    public override void SubirDegats(int degats)
    {
        if (!_aUtiliseAttaqueUltime)
        {
            int degatsReduits = Math.Max(0, degats - 5); // Réduit les dégâts de 5 points max
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Nom} encaisse moins de dégâts grâce à sa résistance naturelle (-5 dégâts).");
            Console.ResetColor();
            base.SubirDegats(degatsReduits);
        }
        else
        {
            // Après avoir utilisé l'attaque ultime, il subit les dégâts normaux
            base.SubirDegats(degats);
        }
    }

    public override void Reset()
    {
        base.Reset();
        _aUtiliseAttaqueUltime = false;  // Reset de l’attaque ultime pour un nouveau combat
    }
}