namespace duel.Classes.Sous_Classes;

public class Goblin: Monstre
{
    protected int _niveau = 1;
    public Goblin() : base("Goblin", 12, 1, 3)
    {
        _niveau = niveau;
    }

    public override Monstre Clone()
    {
        return new Goblin();
    }

    public override void SubirDegats(int degats)
    {
        
        degats *= 2;
        Console.WriteLine($"{Nom} a reçu {degats} points de dommage.");
        base.SubirDegats(degats);
        if ((PointsDeVie -= degats) <= 0)
        {
            PointsDeVie = 0;
        }
    }
    
    
}