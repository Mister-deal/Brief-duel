// See https://aka.ms/new-console-template for more information

using duel.Classes;
using duel.Interfaces;


List<Nain> guerriersNains = new List<Nain>();
List<Elfe> guerriersElfes = new List<Elfe>();
Guerrier.guerriers.Add(guerriersNains.Cast<Icombattant>().ToList());
Guerrier.guerriers.Add(guerriersElfes.Cast<Icombattant>().ToList());

int choix = 0;
AfficherMenuPrincipal();

void AfficherMenuPrincipal()
{
    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║                             NAINS VS ELFES                           ║");
    Console.WriteLine("║                 L'Internationale de la Chicanerie des Hautes terres  ║");
    Console.WriteLine("║                            Nain VS Elfe                              ║");
    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝\n");

    Console.WriteLine("Bienvenue, valeureux guerriers et sages stratèges.");
    Console.WriteLine("Dans ces terres anciennes, où la rancune entre Nains et Elfes perdure,");
    Console.WriteLine("le moment est venu de clore ces querelles ancestrales.");
    Console.WriteLine("Un tournoi sera organisé, où chaque champion combattra pour la gloire,");
    Console.WriteLine("l’honneur et la suprématie de sa race.");

    Console.WriteLine("\nQue les dés soient lancés, que les armes s’entrechoquent,");
    Console.WriteLine("et que le plus digne triomphe dans ce combat sans merci.");

    Console.WriteLine("\nPréparez-vous, car l’épopée commence ici même, et l’histoire s’écrira au fil du sang et du courage.\n");
    while (true)
    {
        Console.WriteLine("\n=== MENU PRINCIPAL ===");
        Console.WriteLine("1. Créer un guerrier nain");
        Console.WriteLine("2. Créer un guerrier elfe ");
        Console.WriteLine("3. Afficher les guerriers");
        Console.WriteLine("4. Lancer un duel");
        Console.WriteLine("5. Lancer un tournoi");
        Console.WriteLine("6. Quitter");

        choix = DemanderEntier("Faites votre choix: ", 1, 6);

        switch (choix)
        {
            case 1:
                AjouterNain();
                break;

            case 2:
                AjouterElfe();
                break;

            case 3:
                AfficherListeguerriersElfes();
                AfficherListeGuerriersNains();
                break;

            case 4:
                LancerDuel();
                break;
            case 5:
                
                break;
            case 6:
                Console.WriteLine("Merci et à bientôt");
                return;
        }

    }
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

 if (gimli.GetPointsDeVie() > 0)
    Console.WriteLine($"{gimli.GetNom()} a gagné !");
else
    Console.WriteLine($"{legolas.GetNom()} a gagné !");
*/



void AjouterNain()
{
    string nom = DemanderTexte("Nom du Guerrier Nain: ");

    int pv = DemanderEntier("Points de vie: ", 10, 100);

    int nbDes = DemanderEntier("Nombre de dés d'attaque: ", 1, 10);

    bool armureLourde = DemanderBool("Souhaitez-vous donner une armure lourdre à votre nain ? (oui/non): ");

    Nain nain = new Nain(nom, pv, nbDes, armureLourde);
    guerriersNains.Add(nain); // Attention : ici c’est bien la liste `Guerriers`

    Console.WriteLine($"{nom} a été ajouté à la liste.");
}

void AjouterElfe()
{

    string nom = DemanderTexte("Nom du Guerrier Elfe: ");

    int pv = DemanderEntier("Points de vie: ", 10, 100);

    int nbDes = DemanderEntier("Nombre de dés d'attaque (1-10): ", 1, 10);

    int magie = DemanderEntier("Points de magie(10 - 40): ", 10, 40);

    Elfe elfe = new Elfe(nom, pv, nbDes, magie);
    guerriersElfes.Add(elfe);

    Console.WriteLine($"{nom} a été ajouté à la liste.");
}

void AfficherListeGuerriersNains()
{
    if (guerriersNains.Count == 0)
    {
        Console.WriteLine("Aucun guerrier créé pour l’instant.");
        return;
    }

    Console.WriteLine("--- Liste des Guerriers nains ---");
    for (int i = 0; i < guerriersNains.Count; i++)
    {
        Console.Write($"{i + 1}. ");
        guerriersNains[i].AfficherInfos();
    }
}

void AfficherListeguerriersElfes()
{
    if (guerriersElfes.Count == 0)
    {
        Console.WriteLine("Aucun guerrier créé pour l’instant.");
        return;
    }

    Console.WriteLine("--- Liste des Guerriers elfes ---");
    for (int i = 0; i < guerriersElfes.Count; i++)
    {
        Console.Write($"{i + 1}. ");
        guerriersElfes[i].AfficherInfos();
    }
}

string DemanderTexte(string message, int longueurMin = 2, int longueurMax = 20)
{
    string texte;
    do
    {
        Console.Write(message);
        texte = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(texte))
        {
            Console.WriteLine("Le texte ne peut pas être vide !");
        }
        else if (texte.Length < longueurMin)
        {
            Console.WriteLine($"Le texte doit contenir au moins {longueurMin} caractères !");
        }
        else if (texte.Length > longueurMax)
        {
            Console.WriteLine($"Le texte ne peut pas dépasser {longueurMax} caractères !");
        }
    } while (string.IsNullOrWhiteSpace(texte) || texte.Length < longueurMin || texte.Length > longueurMax);

    Console.Clear();

    return texte;
}

static int DemanderEntier(string message, int min, int max)
{
    int valeur;
    do
    {
        Console.Write(message);
        string entree = Console.ReadLine();

        if (int.TryParse(entree, out valeur))
        {
            if (valeur < min || valeur > max)
            {
                Console.WriteLine($"La valeur doit être entre {min} et {max} !");
            }
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre valide !");
            valeur = min - 1;
        }
    } while (valeur < min || valeur > max);

    Console.Clear();
    return valeur;
}

bool DemanderBool(string message)
{
    string reponse;
    do
    {
        Console.Write(message);
        reponse = Console.ReadLine().ToLower().Trim();

        if (reponse != "oui" && reponse != "non" && reponse != "o" && reponse != "n")
        {
            Console.WriteLine("Veuillez répondre par 'oui' ou 'non' !");
        }
    } while (reponse != "oui" && reponse != "non" && reponse != "o" && reponse != "n");

    Console.Clear();

    return (reponse == "oui" || reponse == "o");
}

void LancerDuel()
{
    List<Icombattant> tousLesCombattants = Guerrier.guerriers.SelectMany(liste => liste).ToList();
    if (Guerrier.guerriers.Count < 2)
    {
        Console.WriteLine("Pas assez de combattants pour un duel !");
        return;
    }

    Console.WriteLine("--- Choisissez les deux combattants ---");

    for (int i = 0; i < Guerrier.guerriers.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Guerrier.guerriers[i]}");
    }

    int index1 = DemanderEntier("Combatant 1 (index) : ", 1, Guerrier.guerriers.Count) - 1;
    int index2 = DemanderEntier("Combatant 2 (index) : ", 1, Guerrier.guerriers.Count) - 1;

    while (index1 == index2)
    {
        Console.WriteLine("Vous devez choisir deux combattants différents !");
        index2 = DemanderEntier("Combatant 2 (index) : ", 1, Guerrier.guerriers.Count) - 1;
    }

    Icombattant gagnant = Combattre(tousLesCombattants[index1], tousLesCombattants[index2]);
    Console.WriteLine($"\n🏆 Le gagnant est {gagnant.GetNom()} !");
}

Icombattant Combattre(Icombattant c1, Icombattant c2)
{
    c1.Reset();
    c2.Reset();

    Console.WriteLine($"\n⚔️ Début du duel : {c1.GetNom()} VS {c2.GetNom()}\n");
    
    while (c1.GetPointsDeVie() > 0 && c2.GetPointsDeVie() > 0)
    {
        c2.SubirDegats(c1.Attaquer());
        if (c2.GetPointsDeVie() <= 0) break;

        c1.SubirDegats(c2.Attaquer());
    }

    Icombattant vainqueur = c1.GetPointsDeVie() > 0 ? c1 : c2;
    Console.WriteLine($"\n🏆 Vainqueur : {vainqueur.GetNom()}\n");
return vainqueur;
}