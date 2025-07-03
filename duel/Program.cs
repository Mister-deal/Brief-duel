// See https://aka.ms/new-console-template for more information

using System.Media;
using duel.Classes;
using duel.Interfaces;



List<Nain> guerriersNains = new List<Nain>();
List<Elfe> guerriersElfes = new List<Elfe>();
List<Sorcier> sorciers = new List<Sorcier>();

int choix = 0;
int choixClass = 0;
AfficherMenuPrincipal();

void AfficherMenuPrincipal()
{
    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║                      NAINS VS ELFES : LE DESTIN DES CIMES                    ║");
    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝\n");

    Console.WriteLine("  *Récit des Chroniques Anciennes...*\n");

    Console.WriteLine("Il fut un temps, oublié de la plupart, où les hautes terres résonnaient");
    Console.WriteLine("non pas du fracas des armes, mais du chant des alliances. Les Nains,");
    Console.WriteLine("forgerons du roc et bâtisseurs d'empire, partageaient jadis la montagne");
    Console.WriteLine("avec les Elfes, maîtres des arcanes et gardiens des forêts éternelles.");
    
    Console.WriteLine("\nMais le temps corrompt, et l’orgueil creuse des failles plus profondes que la pierre.");
    Console.WriteLine("Un différend ancien, oublié des sages mais nourri par les rancunes séculaires,");
    Console.WriteLine("ressurgit aujourd’hui dans le fracas d’un dernier serment.");
    
    Console.WriteLine("\nLes traités sont rompus. Les anciennes runes de paix se sont éteintes.");
    Console.WriteLine("Les chants elfiques ne résonnent plus que comme des promesses brisées,");
    Console.WriteLine("et les marteaux des Nains battent l’appel à la guerre.");

    Console.WriteLine("\nPlutôt que de voir leurs royaumes s’anéantir, les anciens souverains décidèrent :");
    Console.WriteLine("UN TOURNOI. Une épreuve d'honneur. Un affrontement rituel.");
    Console.WriteLine("Chaque race y enverra ses champions. Et lorsque le sang aura coulé,");
    Console.WriteLine("l’un des peuples sera déclaré vainqueur. L'autre devra plier le genou...");

    Console.WriteLine("\nCe tournoi ne désignera pas simplement un gagnant.");
    Console.WriteLine("Il écrira l’avenir. Il fera taire les poètes. Il scellera le destin des cimes.\n");

    Console.WriteLine("Êtes-vous prêt à forger la légende ? À inscrire votre nom dans les chroniques éternelles ?");
    Console.WriteLine("Prenez les armes, invoquez le courage, et entrez dans l’arène sacrée.");
    
    Console.WriteLine("\nAppuyez sur une touche pour débuter votre ascension dans les cendres de l’Histoire...");
    Console.ReadKey(true);
    while (true)
    {
        var player = new SoundPlayer("Dragon Quest III.wav");
        player.Play(); // Joue la musique et bloque jusqu'à la fin
        Console.WriteLine("\n=== MENU PRINCIPAL ===");
        Console.WriteLine("1. Ajouter un guerrier");
        Console.WriteLine("2. Afficher les guerriers");
        Console.WriteLine("3. Lancer un duel");
        Console.WriteLine("4. Lancer un tournoi");
        Console.WriteLine("5. Quitter");

        choix = DemanderEntier("Faites votre choix: ", 1, 5);

        switch (choix)
        {
            case 1:
                Console.WriteLine("Que voulez-vous ajouter \n" +
                    "  1. Ajouter un guerrier saint nain \n" +
                    "  2. Ajouter un guerrier saint elfe");
               choixClass =  DemanderEntier("Donnez un chiffre: ", 1, 2);

                switch (choixClass)
                {
                    case 1:
                        AjouterNain();
                        break;

                    case 2:
                        AjouterElfe();
                        break;
                }
                break;

            case 2:
                AfficherListeguerriersElfes();
                AfficherListeGuerriersNains();
                break;

            case 3:
                LancerDuel();
                break;
            case 4:
                LancerTournoi();
                break;
            case 5:
                Console.WriteLine("Reposez vous, combattant ! et revenez nous vaillant et courageux !");
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
    var player = new SoundPlayer("Final Fantasy Tactics Menu.wav");
    player.PlayLooping(); // Joue la musique et bloque jusqu'à la fin
    string nom = DemanderTexte("Nom du Guerrier saint Nain: ");

    int pv = DemanderEntier("Points de vie: ", 10, 100);

    int nbDes = DemanderEntier("Nombre de dés d'attaque: ", 1, 10);

    bool armureLourde = DemanderBool("Souhaitez-vous donner une armure lourde à votre nain ? (oui/non): ");

    Nain nain = new Nain(nom, pv, nbDes, armureLourde);
    guerriersNains.Add(nain);
    Guerrier.guerriers.Add(nain);

    Console.WriteLine($"{nom} a été ajouté à la liste. il combattra désormais pour l'alliance des nains");
    player.Stop();
}

void AjouterElfe()
{
    var player = new SoundPlayer("Final Fantasy Tactics Menu.wav");
    player.PlayLooping(); // Joue la musique et bloque jusqu'à la fin
    string nom = DemanderTexte("Nom du saint Guerrier Elfe: ");

    int pv = DemanderEntier("Points de vie: ", 10, 100);

    int nbDes = DemanderEntier("Nombre de dés d'attaque (1-10): ", 1, 10);

    int magie = DemanderEntier("Points de magie(10 - 40): ", 10, 40);

    Elfe elfe = new Elfe(nom, pv, nbDes, magie);
    guerriersElfes.Add(elfe);
    Guerrier.guerriers.Add(elfe);

    Console.WriteLine($"{nom} a été ajouté à la liste. il combattra vaillamment afin de sauvegarder les forêts qui lui sont chères !");
    player.Stop();
}

void AfficherListeGuerriersNains()
{
    if (guerriersNains.Count == 0)
    {
        Console.WriteLine("Aucun guerrier nain créé pour l’instant.");
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
        Console.WriteLine("Aucun guerrier elfe créé pour l’instant.");
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
    var player = new SoundPlayer("Final Fantasy IX OST - Battle 1.wav");
    player.Play();

    if (Guerrier.guerriers.Count < 2)
    {
        Console.WriteLine("Pas assez de combattants pour un duel !");
        return;
    }

    Console.WriteLine("\n--- Choisissez les deux combattants ---\n");

    for (int i = 0; i < Guerrier.guerriers.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Guerrier.guerriers[i].GetNom()}");
    }

    int index1 = DemanderEntier("Combattant 1 (index) : ", 1, Guerrier.guerriers.Count) - 1;
    int index2 = DemanderEntier("Combattant 2 (index) : ", 1, Guerrier.guerriers.Count) - 1;

    while (index1 == index2)
    {
        Console.WriteLine("Vous devez choisir deux combattants différents !");
        index2 = DemanderEntier("Combattant 2 (index) : ", 1, Guerrier.guerriers.Count) - 1;
    }

    Icombattant gagnant = Combattre(Guerrier.guerriers[index1], Guerrier.guerriers[index2]);
    Console.WriteLine($"\n🏆 Le gagnant est {gagnant.GetNom()} !");
    player.Stop();
}

void LancerTournoi()
{
    var player = new SoundPlayer("Tactics Ogre： Championship theme.wav");
    player.Play();
    
    if (Guerrier.guerriers.Count < 2)
    {
        Console.WriteLine("Pas assez de combattants pour lancer un tournoi !");
        return;
    }

    Console.Clear();
    Console.WriteLine("\n --- Le Grand Tournoi des Royaumes débute !!!! ---");
    Console.WriteLine("Les guerriers vont s'affronter dans une série de duels épiques...");
    Console.WriteLine("Mais qui l'emportera t-il ? Elfes ? Nains ? Ce grand tournoi permettra d'en décider, par la grâce et faveurs des dieux !");
    Console.WriteLine("\n --- QUE LE GRAND TOURNOI COMMENCE !!!!!! ---");
    Console.WriteLine();
    Console.WriteLine("Appuyez sur une touche pour commencer !");
    Console.ReadKey(true);
    
    List<Icombattant> participants = Guerrier.guerriers.OrderBy(x => Guid.NewGuid()).ToList(); // mélange aléatoire

    int tour = 1;


    while (participants.Count > 1)
    {
        Console.Clear();
        player.Play();
        Console.WriteLine($"\n--- Tour {tour} du tournoi ---");
        List<Icombattant> vainqueursTour = new List<Icombattant>();
        
        for (int i = 0; i < participants.Count; i += 2)
        {
            if (i + 1 >= participants.Count)
            {
                // Nombre impair : le dernier passe automatiquement au tour suivant
                Console.WriteLine($"⚔️ {participants[i].GetNom()} est qualifié d'office !");
                vainqueursTour.Add(participants[i]);
                continue;
            }

            Icombattant c1 = participants[i];
            Icombattant c2 = participants[i + 1];

            Console.WriteLine($"\nDuel : {c1.GetNom()} VS {c2.GetNom()}");
            Console.WriteLine($"{c1.GetNom()} est prêt à en découdre mais {c2.GetNom()} ne se laisse pas intimider ! nous sommes prêts pour voir du combat de HAUT VOL !");
            Console.WriteLine($"........... COMMENCEZ LE COMBAT !!!");
            Console.WriteLine("Appuyez sur une touche pour lancer le combat...");
            Console.ReadKey(true);

            Icombattant vainqueur = Combattre(c1, c2);
            Victoire(vainqueur);
            vainqueursTour.Add(vainqueur);
        }
        participants = vainqueursTour;
        tour++;

        Console.WriteLine("\nAppuyez sur une touche pour passer au tour suivant...");
        Console.ReadKey(true);
    }
    player.Stop();
    Console.Clear();
    
    var player1 = new SoundPlayer("Tactics Ogre Glory.wav");
    player1.PlayLooping();
    
    Console.WriteLine("╔════════════════════════════════════════════════════╗");
    Console.WriteLine("║           !!!! LE TOURNOI EST TERMINÉ !!!!         ║");
    Console.WriteLine("╚════════════════════════════════════════════════════╝");

    Console.WriteLine($"Le grand champion des hautes terres est : ***{participants[0].GetNom()}*** !!!\n");

    Console.WriteLine("Dans l’arène du destin, face à l’acier, à la magie et au sang,");
    Console.WriteLine($"{participants[0].GetNom()} a triomphé avec bravoure, ruse et puissance.");
    Console.WriteLine("Son nom résonnera dans les montagnes comme dans les forêts éternelles.");
    Console.WriteLine("Les bardes chanteront ses exploits. Les pierres retiendront son nom.");
    Console.WriteLine("Il ne s’agit plus d’un simple combattant...");
    Console.WriteLine("C’est un **héros légendaire**, un symbole vivant de la gloire de son peuple !\n");

    Console.WriteLine("Que les feux s’allument, que les cornes sonnent,");
    Console.WriteLine("le champion est désigné, et les anciens peuvent enfin trouver la paix.\n");
    
    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
    Console.ReadKey(true);
}


Icombattant Combattre(Icombattant c1, Icombattant c2)
{
    c1.Reset();
    c2.Reset();

    Console.WriteLine($"\n⚔️ Début du duel : {c1.GetNom()} VS {c2.GetNom()}\n");

    int tour = 1;

    while (c1.GetPointsDeVie() > 0 && c2.GetPointsDeVie() > 0)
    {
        Console.WriteLine($"\n--- Tour {tour} ---\n");

        Console.WriteLine($"{c1.GetNom()} attaque !");
        c2.SubirDegats(c1.Attaquer());

        if (c2.GetPointsDeVie() <= 0) break;
        

        Console.WriteLine($"{c2.GetNom()} contre-attaque !");
        c1.SubirDegats(c2.Attaquer());

        if (c1.GetPointsDeVie() <= 0) break;

        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
        Console.ReadKey(true);

        tour++;
    }

    Icombattant vainqueur = c1.GetPointsDeVie() > 0 ? c1 : c2;
    Victoire(vainqueur);

    return vainqueur;
}

void Victoire(Icombattant gagnant)
{
    Console.Clear();
    Console.WriteLine("!!!!!! VICTOIRE !!!!!!\n");
    Console.WriteLine($"{gagnant.GetNom()} sort triomphant du combat ! Félicitation à ce fier guerrier !\n");
    
    
    var player = new SoundPlayer("Final Fantasy Fanfare.wav");
    player.PlayLooping();
        
    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
    Console.ReadKey(true);
}