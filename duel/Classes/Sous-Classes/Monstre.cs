using duel.Interfaces;

namespace duel.Classes.Sous_Classes;

public abstract class Monstre: Icombattant
{
    //Attributs
    
    public static List<Icombattant> monstres = new List<Icombattant>();
    
    private string _nom;
    private int _pointsDeVie;
    private int _nbDesAttaque;
    private int _pointsDeVieInitial;
    private int experienceDonnee;
    private string titre;
    
    
    protected int niveau = 1;
    protected int experience = 0;

    protected Monstre(string nom, int pointsDeVie, int nbDesAttaque, int experience)
    {
        _nom = nom;
        _pointsDeVie = pointsDeVie;
        _nbDesAttaque = nbDesAttaque;
        _pointsDeVieInitial = pointsDeVie;
        experienceDonnee = experience;
    }
    

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
        return $"{Nom}";
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
    public virtual void AfficherInfos()
    {
        Console.WriteLine($"{Nom}: [PV= {PointsDeVie}, Nbr= {NbDesAttaque}, Niveau = {niveau}]");
    }
    
    public virtual int Attaquer()
    {
        Random random = new Random();
        int totalDamage = 0;
        for (int i = 0; i < NbDesAttaque; i++)
        {
            totalDamage += random.Next(1, 7);
        }
        if (totalDamage <= NbDesAttaque)
        {
            totalDamage = NbDesAttaque;
        }
        return totalDamage;
    }

    public int DonnerExperience()
    {
        return experienceDonnee;
    }

    public virtual void SubirDegats(int degats)
    {
        if ((PointsDeVie -= degats) <= 0)
        {
            PointsDeVie = 0;
        }
        Console.WriteLine($"{Nom} a reçu {degats} points de dégats. PV Restants = {PointsDeVie} ");
    }
    
    public virtual void Reset()
    {
        PointsDeVie = _pointsDeVieInitial;
    }
    
}