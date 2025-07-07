
using duel.Interfaces;

namespace duel.Classes;

public abstract class Guerrier : Icombattant, IEvolutif
{
    // Attributs 

    public static List<Icombattant> guerriers = new List<Icombattant>();

    // Champs privés
    private string _nom;
    private int _pointsDeVie;
    private int _nbDesAttaque;
    private int _pointsDeVieInitial;
    
    // Champs protégés
    protected int niveau = 1;
    protected int experience = 0;
    protected int experienceMax = 10;

    protected Guerrier()
    {
    }

    // Constructeur
    public Guerrier(string nom, int pointsDeVie, int nbDesAttaque)
    {
        _nom = nom;
        _pointsDeVie = pointsDeVie;
        _pointsDeVieInitial = pointsDeVie;
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

    public virtual void Reset()
    {
        PointsDeVie = _pointsDeVieInitial;
    }

    public int GetNbDesAttaques()
    {
        return NbDesAttaque;
    }

    public virtual void AfficherInfos()
    {
        Console.WriteLine($"{Nom}: [PV= {PointsDeVie}, Nbr= {NbDesAttaque}]");
    }
    public virtual void GagnerExperience(int points)
    {
        experience += points;
        Console.WriteLine($"{Nom} a gagné {points} d'experience !");
        while (experience >= experienceMax)
        {
            MonterNiveau();
        }
    }

    public int GetNiveau()
    {
        return niveau;
    }

    public int GetExperience()
    {
        return experience;
    }

    public int GetExperienceMax()
    {
        return experienceMax;
    }

    public virtual void MonterNiveau()
    {
        experience -= experienceMax;
        niveau++;
        
        experienceMax = (int)(experienceMax * 1.25);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"✨ {Nom} passe au niveau {niveau} !");
        Console.ResetColor();

        _pointsDeVie += 10;
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

    public virtual void SubirDegats(int degats)
    {
        if ((PointsDeVie -= degats) <= 0)
        {
            PointsDeVie = 0;
        }
        Console.WriteLine($"{Nom} a reçu {degats} points de dégats. PV Restants = {PointsDeVie} ");
    }


}