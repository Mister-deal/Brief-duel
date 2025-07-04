using duel.Interfaces;

namespace duel.Classes.Sous_Classes;

public abstract class Monstre: IMonstre
{
    //Attributs
    
    public static List<IMonstre> Monstres = new List<IMonstre>();
    
    private string _nom;
    private int _pointsDeVie;
    private int _nbDesAttaque;
    private int _pointsDeVieInitial;
    private int experienceDonnee;
    
    
    protected int niveau = 1;
    protected int experience = 0;

    protected Monstre(string nom, int pointsDeVie, int nbDesAttaque, int pointsDeVieInitial, int experience)
    {
        _nom = nom;
        _pointsDeVie = pointsDeVie;
        _nbDesAttaque = nbDesAttaque;
        _pointsDeVieInitial = pointsDeVieInitial;
        experienceDonnee = experience;
    }


    public string GetNom()
    {
        throw new NotImplementedException();
    }

    public int GetPV()
    {
        throw new NotImplementedException();
    }

    public int Attaquer()
    {
        throw new NotImplementedException();
    }

    public int DonnerExperience()
    {
        throw new NotImplementedException();
    }

    public void SubirDegats(int degats)
    {
        throw new NotImplementedException();
    }

    public bool EstVivant()
    {
        if (_pointsDeVie > 0)
        {
            return true;
        };
        return false;
    }
}