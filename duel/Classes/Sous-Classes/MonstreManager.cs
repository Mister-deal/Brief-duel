namespace duel.Classes.Sous_Classes;

public static class MonstreManager
{
    private static List<Monstre> monstres = new List<Monstre>();
    private static Random rnd = new Random();

    public static void AjouterMonstre(Monstre monstre)
    {
        monstres.Add(monstre);
        Console.WriteLine($"➡️ Un nouveau monstre apparaît : {monstre.Nom} !");
    }

    public static void SupprimerMonstre(Monstre monstre)
    {
        monstres.Remove(monstre);
        Console.WriteLine($"{monstre.Nom} a été vaincu !");
    }

    public static List<Monstre> GetMonstres()
    {
        return monstres;
    }
    
    public static Monstre GetMonstreAleatoire()
    {
        var modele = monstres[rnd.Next(monstres.Count)];
        return modele;
    }

    public static void Reset()
    {
        monstres.Clear();
    }

    public static bool ADesMonstres()
    {
        return monstres.Count > 0;
    }

    public static Monstre ChoisirMonstreAleatoire()
    {
        if (monstres.Count == 0) return null;
        return monstres[rnd.Next(monstres.Count)];
    }
}