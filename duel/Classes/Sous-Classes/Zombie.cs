namespace duel.Classes.Sous_Classes;

public class Zombie: Monstre
{
    protected int _niveau = 4;
    public Zombie() : base("Zombie", 25, 2, 8)
    {
        _niveau = niveau;
    }
    
}