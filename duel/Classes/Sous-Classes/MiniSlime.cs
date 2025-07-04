namespace duel.Classes.Sous_Classes;

public class MiniSlime: Monstre
{
    public MiniSlime(): base("Mini slime", 11, 1, 3)
    {
    }

    public override Monstre Clone()
    {
        return new MiniSlime();
    }
}