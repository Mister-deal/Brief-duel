// See https://aka.ms/new-console-template for more information

using System.Media;
using duel.Classes;
using duel.Interfaces;



List<Nain> guerriersNains = new List<Nain>();
List<Elfe> guerriersElfes = new List<Elfe>();
List<Sorcier> sorciers = new List<Sorcier>();

List<string> historiqueCombats = new List<string>();

int choix = 0;
int choixClass = 0;

void InitialiserCombattants()
{
    Console.WriteLine("Invocation des anciens champions...");
    Thread.Sleep(500);

    Nain Thorin = new Nain("Thorin Forgefeu", 90, 5, true);
    Guerrier.guerriers.Add(new Nain("Thorin Forgefeu", 90, 5, true));
    Guerrier.guerriers.Add(new Nain("Grimbald Marteau-d'Argent", 75, 7, true));
    Guerrier.guerriers.Add(new Nain("Durgin Barbelac", 100, 8, false));
    Guerrier.guerriers.Add(new Nain("Baldrick le Tenace", 65, 10, true));

    Guerrier.guerriers.Add(new Elfe("Elandor Ventargent",85, 7, 30));
    Guerrier.guerriers.Add(new Elfe("Luthien Sèveclaire", 100, 5, 25));
    Guerrier.guerriers.Add(new Elfe("Faelar Ombreciel", 85, 8, 35));
    Guerrier.guerriers.Add(new Elfe("Thalor de la Lune", 55, 10, 40));

    Console.WriteLine("Les champions sont prêts à en découdre.\n");
    Thread.Sleep(500);
    Console.Clear();
}
AfficherMenuPrincipal();

void AfficherMenuPrincipal()
{
    Console.Write("Chargement : [");

    int totalBlocks = 30;

    for (int i = 0; i <= totalBlocks; i++)
    {
        Console.Write("#");
        Thread.Sleep(100);
    }

    Console.WriteLine("] Terminé !");
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
    Console.Clear();
    
    InitialiserCombattants();
    Console.WriteLine();
    while (true)
    {
        var player = new SoundPlayer("Dragon Quest III.wav");
        player.Play(); // Joue la musique et bloque jusqu'à la fin
        Console.WriteLine("\n=== MENU PRINCIPAL ===");
        Console.WriteLine("1. Ajouter un guerrier");
        Console.WriteLine("2. Afficher les guerriers");
        Console.WriteLine("3. Lancer un duel");
        Console.WriteLine("4. Lancer un tournoi");
        Console.WriteLine("5. Supprimer un guerrier");
        Console.WriteLine("6. Afficher historique");
        Console.WriteLine("7. Afficher le guide de jeu");
        Console.WriteLine("8. Quitter");

        choix = DemanderEntier("Faites votre choix: ", 1, 8);

        switch (choix)
        {
            case 1:
                Console.WriteLine("Que voulez-vous ajouter \n" +
                    "  1. Ajouter un guerrier saint nain \n" +
                    "  2. Ajouter un guerrier saint elfe");
                choixClass = DemanderEntier("Donnez un chiffre: ", 1, 2);

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
                SupprimerGuerrier();
                break;
            case 6:
                AfficherHistorique();
                break;
            case 7:
                AfficherGuideUtilisateur();
                break;
            case 8:
                Console.WriteLine("Reposez vous, combattant ! et revenez nous vaillant et courageux !");
                return;
        }

    }
}

{

}

void SupprimerGuerrier()
{
    if (Guerrier.guerriers.Count == 0)
    {
        Console.WriteLine("Il n'y a aucun combattant à supprimer.");
        return;
    }

    Console.WriteLine(" Menu de Suppression de Guerriers");
    Console.WriteLine("Quel guerrier souhaitez-vous envoyer rejoindre ses ancêtres ?");
    Console.WriteLine("Appuyez sur une touche pour continuer...");
    Console.ReadKey(true);

    // Affichage des guerriers disponibles
    for (int i = 0; i < Guerrier.guerriers.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Guerrier.guerriers[i].GetNom()}");
    }

    int index = DemanderEntier("Combattant à supprimer (index) : ", 1, Guerrier.guerriers.Count) - 1;

    if (index >= 0 && index < Guerrier.guerriers.Count)
    {
        string nomSupprime = Guerrier.guerriers[index].GetNom();
        Guerrier.guerriers.RemoveAt(index);

        Console.WriteLine($"\n{nomSupprime} a été choisi pour quitter l’arène...\n");
        var player = new SoundPlayer("Final Fantasy Tactics Game Over.wav");
        player.PlayLooping(); // Joue la musique et bloque jusqu'à la fin
        Thread.Sleep(2000);

        string[] animation = {
            "Le silence s'installe...",
            $"{nomSupprime} regarde une dernière fois l’arène...",
            "Une brume épaisse s’élève sous ses pieds...",
            "Les tambours s’arrêtent.",
            $"{nomSupprime} disparaît lentement dans l'ombre..."
        };
        
        foreach (var ligne in animation)
        {
            Console.WriteLine(ligne);
            Thread.Sleep(2500);
        }
        Console.WriteLine($"\n{nomSupprime} combattra peut-être ailleurs... ou veillera depuis l’au-delà.\n");
        Console.WriteLine();
        Console.WriteLine("Appuyez sur une touche pour continuer...");
        Console.ReadKey(true);
    }
    else
    {
        Console.WriteLine("Index invalide.");
    }
}

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
    AnimationChargement();
    var player = new SoundPlayer("Final Fantasy IX OST - Battle 1.wav");
    player.Play();

    if (Guerrier.guerriers.Count < 2)
    {
        Console.WriteLine("Pas assez de combattants pour un duel !");
        return;
    }

    AfficherCombattant();

    int index1 = DemanderEntier("Combattant 1 (index) : ", 1, Guerrier.guerriers.Count) - 1;

    AfficherCombattant();

    int index2 = DemanderEntier("Combattant 2 (index) : ", 1, Guerrier.guerriers.Count) - 1;

    while (index1 == index2)
    {
        Console.WriteLine("Vous devez choisir deux combattants différents !");
        index2 = DemanderEntier("Combattant 2 (index) : ", 1, Guerrier.guerriers.Count) - 1;
    }

    Icombattant gagnant = Combattre(Guerrier.guerriers[index1], Guerrier.guerriers[index2]);

    AjouterHistorique(gagnant, Guerrier.guerriers[index1], Guerrier.guerriers[index2]);

    Console.WriteLine($"\nLe gagnant est {gagnant.GetNom()} !");
    player.Stop();
}

void LancerTournoi()
{
    AnimationChargement();
    var player = new SoundPlayer("Tactics Ogre： Championship theme.wav");
    player.PlayLooping();

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
        player.PlayLooping();
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

            AjouterHistorique(vainqueur, c1, c2);

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
        AnimationAttaqueEnCours();
        c2.SubirDegats(c1.Attaquer());

        if (c2.GetPointsDeVie() <= 0) break;


        Console.WriteLine($"{c2.GetNom()} contre-attaque !");
        AnimationAttaqueEnCours();
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
    player.Play();

    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
    Console.ReadKey(true);
    player.Stop();
    Console.Clear();
}

void AnimationAttaqueEnCours(int dureeEnMs = 2000, int intervalle = 300)
{
    int iterations = dureeEnMs / intervalle;
    Console.Write("Attaque en cours ");

    var couleurs = new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Magenta };

    for (int i = 0; i < iterations; i++)
    {
        Console.ForegroundColor = couleurs[i % couleurs.Length];
        Console.Write(".");
        Console.ResetColor();
        Thread.Sleep(intervalle);
    }

    Console.WriteLine();
}

void AnimationChargement(int dureeEnMs = 2000, int intervalle = 300)
{
    int iterations = dureeEnMs / intervalle;
    Console.Write("Chargement ");

    var couleurs = new ConsoleColor[] { ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.White, ConsoleColor.Gray };

    for (int i = 0; i < iterations; i++)
    {
        Console.ForegroundColor = couleurs[i % couleurs.Length];
        Console.Write(".");
        Console.ResetColor();
        Thread.Sleep(intervalle);
    }

    Console.WriteLine();
}

void AfficherCombattant()
{
    Console.WriteLine("\n--- Choisissez les deux combattants ---\n");

    for (int i = 0; i < Guerrier.guerriers.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Guerrier.guerriers[i].GetNom()}");
    }
}

void AfficherHistorique()
{
    if (historiqueCombats.Count == 0)
    {
        Console.WriteLine("Aucun combat n’a encore été enregistré dans les annales...");
        return;
    }

    
    Console.WriteLine("\n *** HISTORIQUE DES COMBATS ***\n");
    var player = new SoundPlayer("page turn.wav");
    player.Play();
    Thread.Sleep(1000);

    int index = 1;
    foreach (string combat in historiqueCombats)
    {
        var player1 = new SoundPlayer("Secunda.wav");
        player1.PlayLooping();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"⚔️ Combat {index}: ");
        Console.ResetColor();

        foreach (char c in combat)
        {
            Console.Write(c);
            Thread.Sleep(25); // Effet de frappe lente
        }

        Console.WriteLine();
        Thread.Sleep(600); // Petite pause entre les combats
        index++;
    }

    Console.WriteLine("\n Fin de l’historique.\n");
}

void AjouterHistorique(Icombattant gagnant, Icombattant combattant1, Icombattant combattant2)
{
    string ligneCombat;

    if (gagnant == combattant1)
    {
        ligneCombat = $"{combattant1.GetNom()} affronta {combattant2.GetNom()} —  Victorieux : {combattant1.GetNom()}";
    }
    else
    {
        ligneCombat = $"{combattant1.GetNom()} affronta {combattant2.GetNom()} —  Victorieux : {combattant2.GetNom()}";
    }

    historiqueCombats.Add(ligneCombat);
}

void AfficherGuideUtilisateur()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║                 GUIDE DU JOUEUR - GUERRES DES PEUPLES ANCESTRAUX        ║");
    Console.WriteLine("║              (Nains, Elfes, Sorciers... et l’Équilibre des Lames)       ║");
    Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝\n");
    Console.ResetColor();

    Console.WriteLine("Bienvenue dans le grand tournoi de la Chicanerie des Hautes Terres !");
    Console.WriteLine("Ce jeu console vous propose de créer des combattants et de les faire s'affronter\n" +
                      "dans des duels épiques ou dans un tournoi sans pitié.\n");

    Console.WriteLine("⚔️ TYPES DE COMBATTANTS DISPONIBLES :");

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("• Guerrier : Classe de base avec attaque aléatoire.");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("• Nain : Armure lourde, subit moins de dégâts.");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("• Elfe : Attaque toujours avec un minimum garanti.");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("• Sorcier : Utilise des sorts (soin, feu, bouclier) et gère du mana.");
    Console.ResetColor();

    Console.WriteLine("\n📏 RÈGLES DE CRÉATION :");
    Console.WriteLine("- Les points de vie (PV) doivent être compris entre 10 et 100.");
    Console.WriteLine("- Le nom du guerrier doit être unique et représentatif.");
    Console.WriteLine("- Vous pouvez créer autant de combattants que vous le souhaitez.");

    Console.WriteLine("\n📖 APRÈS CHAQUE ACTION :");
    Console.WriteLine("- Un message vous indique ce qui s’est passé.");
    Console.WriteLine("- Vous pouvez revenir au menu à tout moment.");
    Console.WriteLine("- Les combats sont automatiques et commentés.\n");

    Console.WriteLine("🎯 OBJECTIF :");
    Console.WriteLine("Créez vos champions, faites-les progresser, et imposez la suprématie de votre peuple\n" +
                      "dans le plus grand tournoi des Hautes Terres !");

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\nBonne chance, stratège. Que vos guerriers tombent avec gloire ou triomphent avec honneur !");
    Console.ResetColor();
    Console.WriteLine("\nAppuyez sur une touche pour revenir au menu principal...");
    Console.ReadKey(true);
    Console.Clear();
}
