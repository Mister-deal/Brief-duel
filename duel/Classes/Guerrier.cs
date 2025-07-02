namespace duel.Classes;

public class Guerrier
{
    // Champs privés
    private string _nom;
    private int _pointsDeVie;
    private int _nbDesAttaque;

    // Constructeur
    public Guerrier(string nom, int pointsDeVie, int nbDesAttaque)
    {
        _nom = nom;
        _pointsDeVie = pointsDeVie;
        _nbDesAttaque = nbDesAttaque;
    }

    // Propriétés publiques
    public string Nom
    {
        get => _nom;
        set => _nom = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int PointsDeVie
    {
        get => _pointsDeVie;
        set => _pointsDeVie = value;
    }

    public int NbDesAttaque
    {
        get => _nbDesAttaque;
        set => _nbDesAttaque = value;
    }


    public string GetNom()
    {
        return $"{Nom} est le guerrier que vous avez selectionné";
    }

    public int GetPointsDeVie()
    {
        return PointsDeVie;
    }

    public void SetPointDeVie(int pointsDeVie)
    {
        PointsDeVie = pointsDeVie;
        Console.WriteLine($"les points de vie attribués sont: {pointsDeVie}");
    }

    public int GetNbDesAttaques()
    {
        return NbDesAttaque;
    }

    public void AfficherInfos()
    {
        Console.WriteLine($"{Nom}: [PV= {PointsDeVie}, Nbr= {NbDesAttaque}]");
    }

    public int Attaquer()
    {
        Random random  = new Random();
        int totalDamage = 0;
        for (int i = 0; i < NbDesAttaque; i++)
        {
            totalDamage += random.Next(1, 7);
        }
        return totalDamage;
    }

    public void SubirDegats(int degats)
    {
        Console.Write(PointsDeVie);
        PointsDeVie -= degats;
        Console.WriteLine($" - {degats} = {PointsDeVie} de point de vie actuel");
        if (PointsDeVie <= 0)
        {
            Console.WriteLine($"{Nom} a été vaincu !");
        }
    }
    
    
}