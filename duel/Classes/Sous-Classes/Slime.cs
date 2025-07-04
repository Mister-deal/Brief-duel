namespace duel.Classes.Sous_Classes;

public class Slime: Monstre
{
    protected int _niveau = 3;
    public Slime() : base("Slime", 22, 1, 5)
    {
        _niveau = niveau;
    }
    

    public override void SubirDegats(int degats)
    {
        base.SubirDegats(degats);

        if (PointsDeVie <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Nom} se divise en deux mini-slimes !");
            Console.ResetColor();

            MonstreManager.AjouterMonstre(new MiniSlime());
            MonstreManager.AjouterMonstre(new MiniSlime());
        }
    }
}