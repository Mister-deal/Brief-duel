// See https://aka.ms/new-console-template for more information

using duel.Classes;

List<Guerrier> guerriers = new List<Guerrier>();

while (true)
{
    Console.WriteLine("\n=== MENU PRINCIPAL ===");
    Console.WriteLine("1. Créer un guerrier");
    Console.WriteLine("2. Afficher les guerriers");
    Console.WriteLine("3. Lancer un duel");
    Console.WriteLine("4. Quitter");

    Console.Write("faites votre choix");
    string choix = Console.ReadLine();

    /*
    switch (choix)
    {
        case "1":
            
    }
    */
}
{
    
}
/*
Guerrier lancelot = new Guerrier("Lancelot", 35, 3);
Guerrier galahad = new Guerrier("galahad", 30, 4);
Elfe legolas = new Elfe("legolas", 25, 5, 5);
Nain gimli = new Nain("gimli", 38, 3, true);

int count = 1;
Console.WriteLine($"\n--- Début du Combat N°{count} ---");


while (lancelot.GetPointsDeVie() > 0 && galahad.GetPointsDeVie() > 0)
{
    Console.WriteLine("\n--- Nouveau Tour ---");

    // Lancelot attaque Galahad
    int degats1 = lancelot.Attaquer();
    galahad.SubirDegats(degats1);
    Console.WriteLine($"{lancelot.GetNom()} inflige {degats1} dégâts à {galahad.GetNom()}.");
    galahad.AfficherInfos();

    if (galahad.GetPointsDeVie() <= 0)
        break;

    // Galahad attaque Lancelot
    int degats2 = galahad.Attaquer();
    lancelot.SubirDegats(degats2);
    Console.WriteLine($"{galahad.GetNom()} inflige {degats2} dégâts à {lancelot.GetNom()}.");
    lancelot.AfficherInfos();
}

count++;

Console.WriteLine("\n--- Fin du Combat ---");

 if (lancelot.GetPointsDeVie() > 0)
    Console.WriteLine($"{lancelot.GetNom()} a gagné !");
else
    Console.WriteLine($"{galahad.GetNom()} a gagné !");


Console.WriteLine($"\n--- Début du Combat N°{count} ---");


while (gimli.GetPointsDeVie() > 0 && legolas.GetPointsDeVie() > 0)
{
    Console.WriteLine("\n--- Nouveau Tour ---");

    // Gimli attaque Legolas
    int degats1 = gimli.Attaquer();
    legolas.SubirDegats(degats1);
    Console.WriteLine($"{gimli.GetNom()} inflige {degats1} dégâts à {legolas.GetNom()}.");
    legolas.AfficherInfos();

    if (legolas.GetPointsDeVie() <= 0)
        break;

    //appel de la fonction polymorphique Attaquer() provenant de la classe enfant Elfe
    // Legolas attaque Gimli
    
    int degats2 = legolas.Attaquer();
    //appel de la fonction polymorphique SubirDegats() provenant de la classe enfant Nain
    gimli.SubirDegats(degats2);
    Console.WriteLine($"{legolas.GetNom()} inflige {degats2} dégâts à {gimli.GetNom()}.");
    gimli.AfficherInfos();
}

Console.WriteLine("\n--- Fin du Combat ---");
*/

