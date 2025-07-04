using duel.Interfaces;

namespace duel.Classes;

public class Sorcier: Guerrier, Icombattant
{
    private int _mana;
    private bool bouclierActif = false;
    private List<string> Sorts = new List<string>() { "Boule de feu", "Soin", "Bouclier magique" };
    public Sorcier(string nom, int pointsDeVie, int nbDesAttaque, int mana) : base(nom, pointsDeVie, nbDesAttaque)
    {
        _mana = mana;
    }
    
    public override int Attaquer()
    {
        Random random  = new Random();
       

        if (_mana < 10)
        {
            Console.WriteLine($"{Nom} ne dispose pas d'assez de mana pour effectuer ce sort.");
            return base.Attaquer();
        }

        _mana -= 10;
        string sortChoisi = Sorts[random.Next(Sorts.Count)];
        Console.WriteLine($"{Nom} lance le sort: {sortChoisi}");

        switch (sortChoisi)
        {
            case "Boule de feu":
                return base.Attaquer() + 10;
            case "Soin":
                int soin = 15;
                PointsDeVie += soin;
                Console.WriteLine($"{Nom} lance le soin: {soin}; {Nom} se soigne {soin} ses points de vie.");
                return 0;
            case "Bouclier magique":
                bouclierActif = true;
                Console.WriteLine($"{Nom} active son bouclier magique !");
                return 0;
            
            default:
                return base.Attaquer();
        }
       
    }
    public override void SubirDegats(int degats)
    {

        if (bouclierActif == true)
        {
            degats /= 2;
            Console.WriteLine($"{Nom} est protégé par un bouclier magique ! dégats réduits à {degats}");
            bouclierActif = false;
        }
        base.SubirDegats(degats);
    }
    
    public override void AfficherInfos()
    {
        Console.WriteLine($"{Nom}: [PV = {PointsDeVie}, Mana = {_mana}, Nbr Dés = {NbDesAttaque}]");
    }
}