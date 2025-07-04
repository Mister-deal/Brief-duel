
using duel.Interfaces;

namespace duel.Classes;

public abstract class Guerrier : Icombattant
{
    // Attributs 

    public static List<Icombattant> guerriers = new List<Icombattant>();

    // Champs privés
    private string _nom;
    private int _pointsDeVie;
    private int _nbDesAttaque;
    private int _pointsDeVieInitial;

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