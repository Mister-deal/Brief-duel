﻿// See https://aka.ms/new-console-template for more information

using duel.Classes;
using duel.Interfaces;
using System.Media;
using System.Text;
using duel.Classes.Sous_Classes;


// Listes pour stocker les guerriers de chaque race
List<Nain> guerriersNains = new List<Nain>();
List<Elfe> guerriersElfes = new List<Elfe>();
List<Sorcier> sorciers = new List<Sorcier>();

// Listes spécifiques pour catégories de monstres
List<Monstre> monstresSlimes = new List<Monstre>();
List<Monstre> monstresGobelins = new List<Monstre>();
List<Monstre> monstresRats = new List<Monstre>();
List<Monstre> monstresZombies = new List<Monstre>();

// Liste pour enregistrer les combats passés
List<string> historiqueCombats = new List<string>();

int choix = 0;
int choixClass = 0;

// Crée les combattants de départ pour chaque race (Nain, Elfe, Sorcier)
void InitialiserCombattants()
{
    Console.WriteLine("Invocation des anciens champions...");
    Thread.Sleep(500);

    // Création des Nains
    Nain Thorin = new Nain("Thorin Forgefeu", 90, 5, true);
    Nain Grimbald = new Nain("Grimbald Marteau-d'Argent", 75, 7, true);
    Nain Durgin = new Nain("Durgin Barbelac", 100, 8, false);
    Nain Baldrick = new Nain("Baldrick le Tenace", 65, 10, true);

    // Création des Elfes
    Elfe Elandor = new Elfe("Elandor Ventargent", 85, 7, 30);
    Elfe Luthien = new Elfe("Luthien Sèveclaire", 100, 5, 25);
    Elfe Faelar = new Elfe("Faelar Ombreciel", 85, 8, 35);
    Elfe Thalor = new Elfe("Thalor de la Lune", 55, 10, 40);

    // Création des Sorciers
    Sorcier Siri = new Sorcier("Siri Ventador", 95, 6, 45);
    Sorcier Eliogabalus = new Sorcier("Eliogabalus ex", 100, 5, 50);
    Sorcier TheWitch = new Sorcier("the witch of madness", 65, 10, 70);
    Sorcier Yuru = new Sorcier("Yuru higba", 75, 9, 60);

    // Ajout dans les listes spécifiques
    guerriersNains.Add(Thorin);
    guerriersNains.Add(Grimbald);
    guerriersNains.Add(Durgin);
    guerriersNains.Add(Baldrick);

    guerriersElfes.Add(Elandor);
    guerriersElfes.Add(Luthien);
    guerriersElfes.Add(Faelar);
    guerriersElfes.Add(Thalor);

    sorciers.Add(Siri);
    sorciers.Add(Eliogabalus);
    sorciers.Add(TheWitch);
    sorciers.Add(Yuru);

    // Ajout dans la liste générale
    Guerrier.guerriers.Add(Thorin);
    Guerrier.guerriers.Add(Grimbald);
    Guerrier.guerriers.Add(Durgin);
    Guerrier.guerriers.Add(Baldrick);
    Guerrier.guerriers.Add(Elandor);
    Guerrier.guerriers.Add(Luthien);
    Guerrier.guerriers.Add(Faelar);
    Guerrier.guerriers.Add(Thalor);
    Guerrier.guerriers.Add(Siri);
    Guerrier.guerriers.Add(Eliogabalus);
    Guerrier.guerriers.Add(TheWitch);
    Guerrier.guerriers.Add(Yuru);

    Console.WriteLine("Les champions sont prêts à en découdre.\n");
    Thread.Sleep(500);
    Console.Clear();
}

void InitialiserMonstres()
{
    Console.WriteLine("Invocation des créatures sauvages...");
    Thread.Sleep(500);

    // Création des Slimes
    Slime slime = new Slime(); // exemple d’un slime plus fort
    Goblin goblinSimple = new Goblin();
    GoblinBrutal goblinBrutal = new GoblinBrutal(true);
    RatGeant ratGeantNormal = new RatGeant();
    Zombie zombieCommun = new Zombie();

    // Ajout dans les listes spécifiques
    monstresSlimes.Add(slime);
    monstresGobelins.Add(goblinSimple);
    monstresGobelins.Add(goblinBrutal);
    monstresRats.Add(ratGeantNormal);
    monstresZombies.Add(zombieCommun);

    Monstre.monstres.Add(slime);
    Monstre.monstres.Add(goblinBrutal);
    Monstre.monstres.Add(goblinBrutal);
    Monstre.monstres.Add(ratGeantNormal);
    Monstre.monstres.Add(zombieCommun);

    Console.WriteLine("Les monstres rôdent dans les environs.\n");
    Thread.Sleep(500);
}
// Affiche le menu principal du jeu avec ambiance et narration
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

    AppuyerSurUneTouche("\nAppuyez sur une touche pour débuter votre ascension dans les cendres de l’Histoire...");
    Console.Clear();
    
    
    InitialiserMonstres();
    InitialiserCombattants();
    
    // Affiche les options et traite le choix de l'utilisateur en boucle
    while (true)
    {
        var player = new SoundPlayer("Assets/Audio/Dragon Quest III.wav");
        player.Play(); // Joue la musique et bloque jusqu'à la fin
        Console.WriteLine("\n=== MENU PRINCIPAL ===");
        Console.WriteLine("1. Ajouter un guerrier");
        Console.WriteLine("2. Afficher les guerriers");
        Console.WriteLine("3. Lancer un duel");
        Console.WriteLine("4. Lancer un tournoi");
        Console.WriteLine("5. Supprimer un guerrier");
        Console.WriteLine("6. Afficher historique");
        Console.WriteLine("7. Afficher le guide de jeu");
        Console.WriteLine("8. Entrer dans la zone PVE");
        Console.WriteLine("9. Quitter");

        choix = DemanderEntier("Faites votre choix: ", 1, 9);

        switch (choix)
        {
            case 1:
                Console.WriteLine("Que voulez-vous ajouter ? \n" +
                    "  1. Ajouter un guerrier saint nain \n" +
                    "  2. Ajouter un guerrier saint elfe \n" +
                    "  3. Ajouter un sorcier\n");
                choixClass = DemanderEntier("Donnez un chiffre: ", 1, 3);

                switch (choixClass)
                {
                    case 1:
                        // Ajoute un nouveau guerrier Nain avec ses caractéristiques
                        AjouterNain();
                        Console.Clear();
                        break;

                    case 2:
                        // Ajoute un nouveau guerrier Elfe avec ses caractéristiques
                        AjouterElfe();
                        Console.Clear();
                        break;
                    case 3:
                        // Ajoute un nouveau Sorcier avec ses caractéristiques (mana inclus)
                        AjouterSorcier();
                        Console.Clear();
                        break;
                }
                break;

            case 2:
                // Affiche la liste des Nains créés
                // Affiche la liste des Elfes créés
                // Affiche la liste des sorciers créés
                AfficherListeguerriersElfes();
                AfficherListeGuerriersNains();
                AfficherListeSorciers();

                AppuyerSurUneTouche("\nAppuyez sur une touche pour fermer la liste");
                Console.Clear();
                break;

            case 3:
                // Lance un duel entre deux combattants choisis
                LancerDuel();
                Console.Clear();
                break;
            case 4:
                // Lance un tournoi avec tous les combattants disponibles
                LancerTournoi();
                Console.Clear();
                break;
            case 5:
                // Supprime un guerrier de la liste après sélection par l'utilisateur
                SupprimerGuerrier();
                break;
            case 6:
                // Affiche l’historique des duels passés
                AfficherHistorique();
                break;
            case 7:
                // Affiche les règles et explications du jeu
                AfficherGuideUtilisateur();
                break;
            case 8:
                Console.Clear();
                Console.WriteLine("==== Zone PvE ====");
                Console.WriteLine("1. Affronter un monstre");
                Console.WriteLine("2. Affronter un boss");
                Console.WriteLine("3. Affronter une vague de monstres");
                Console.WriteLine("4. Retour au menu principal");
                Console.Write("Votre choix : ");
                choix = DemanderEntier("Faites votre choix: ", 1, 4);
                switch (choix)
                {
                    case 1:
                        LancerCombatContreMonstre();
                        break;
                    case 2:
                        //LancerCombatContreBoss();
                        break;
                    case 3:
                        LancerCombatContreMonstres();
                        break;
                    case 4:
                        Console.WriteLine("Merci et au revoir.");
                        break;
                    default:
                        Console.WriteLine("Choix invalide !");
                        break;
                }
                break;
            case 9:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Reposez vous, combattant ! et revenez nous vaillant et courageux !");
                Console.ResetColor();
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
        MessageAlerte("Il n'y a aucun combattant à supprimer.");
        return;
    }

    Console.WriteLine(" Menu de Suppression de Guerriers");
    Console.WriteLine("Quel guerrier souhaitez-vous envoyer rejoindre ses ancêtres ?");

    AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");

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
        var player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Game Over.wav");
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

        AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
    }
    else
    {
        MessageAlerte("Index invalide.");
    }
}

void AjouterNain()
{
    var player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Menu.wav");
    player.PlayLooping(); // Joue la musique et bloque jusqu'à la fin
    string nom = DemanderTexte("Nom du Guerrier saint Nain: ");

    int pv = DemanderEntier("Points de vie(10 - 100): ", 10, 100);

    int nbDes = DemanderEntier("Nombre de dés d'attaque(1 - 10): ", 1, 10);

    bool armureLourde = DemanderBool("Souhaitez-vous donner une armure lourde à votre nain ? (oui/non): ");

    Nain nain = new Nain(nom, pv, nbDes, armureLourde);
    guerriersNains.Add(nain);
    Guerrier.guerriers.Add(nain);

    Console.WriteLine($"{nom} a été ajouté à la liste. il combattra désormais pour l'alliance des nains.");

    AppuyerSurUneTouche("\nAppuyez sur une touche pour continuer...");

    player.Stop();
}

void AjouterSorcier()
{
    var player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Menu.wav");
    player.PlayLooping(); // Joue la musique et bloque jusqu'à la fin
    string nom = DemanderTexte("Nom du Guerrier saint Nain: ");

    int pv = DemanderEntier("Points de vie(10 - 100): ", 10, 100);

    int nbDes = DemanderEntier("Nombre de dés d'attaque(1 - 10): ", 1, 10);

    int mana = DemanderEntier("Points de mana(10 - 75): ", 10, 75 );

    Sorcier sorcier = new Sorcier(nom, pv, nbDes, mana);
    sorciers.Add(sorcier);
    Guerrier.guerriers.Add(sorcier);

    Console.WriteLine($"{nom} a été ajouté à la liste. il combattra désormais pour la ligue des sorciers");

    AppuyerSurUneTouche("\nAppuyez sur une touche pour continuer...");

    player.Stop();
}

void AjouterElfe()
{
    var player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Menu.wav");
    player.PlayLooping(); // Joue la musique et bloque jusqu'à la fin
    string nom = DemanderTexte("Nom du saint Guerrier Elfe: ");

    int pv = DemanderEntier("Points de vie(10 - 100): ", 10, 100);

    int nbDes = DemanderEntier("Nombre de dés d'attaque (1-10): ", 1, 10);

    int magie = DemanderEntier("Points de magie(10 - 40): ", 10, 40);

    Elfe elfe = new Elfe(nom, pv, nbDes, magie);
    guerriersElfes.Add(elfe);
    Guerrier.guerriers.Add(elfe);

    Console.WriteLine($"{nom} a été ajouté à la liste. il combattra vaillamment afin de sauvegarder les forêts qui lui sont chères !");

    AppuyerSurUneTouche("\nAppuyez sur une touche pour continuer...");

    player.Stop();
}

void AfficherListeGuerriersNains()
{
    if (guerriersNains.Count == 0)
    {
        MessageAlerte("Aucun guerrier nain créé pour l’instant.");
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
        MessageAlerte("Aucun guerrier elfe créé pour l’instant.");
        return;
    }

    Console.WriteLine("--- Liste des Guerriers elfes ---");
    for (int i = 0; i < guerriersElfes.Count; i++)
    {
        Console.Write($"{i + 1}. ");
        guerriersElfes[i].AfficherInfos();
    }
}

void AfficherListeSorciers()
{
    if (sorciers.Count == 0)
    {
        MessageAlerte("Aucun sorcier créé pour l’instant.");
        return;
    }

    Console.WriteLine("--- Liste des Sorciers ---");
    for (int i = 0; i < sorciers.Count; i++)
    {
        Console.Write($"{i + 1}. ");
        sorciers[i].AfficherInfos();
    }
}

// Pose une question texte et valide la saisie
string DemanderTexte(string message, int longueurMin = 2, int longueurMax = 20)
{
    string texte;
    do
    {
        Console.Write(message);
        texte = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(texte))
        {
            MessageAlerte("Le texte ne peut pas être vide !");
        }
        else if (texte.Length < longueurMin)
        {
            MessageAlerte($"Le texte doit contenir au moins {longueurMin} caractères !");
        }
        else if (texte.Length > longueurMax)
        {
            MessageAlerte($"Le texte ne peut pas dépasser {longueurMax} caractères !");
        }
    } while (string.IsNullOrWhiteSpace(texte) || texte.Length < longueurMin || texte.Length > longueurMax);

    Console.Clear();

    return texte;
}

// Pose une question numérique et valide l’intervalle
int DemanderEntier(string message, int min, int max)
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
                MessageAlerte($"La valeur doit être entre {min} et {max} !");
            }
        }
        else
        {
            MessageAlerte("Veuillez entrer un nombre valide !");
            valeur = min - 1;
        }
    } while (valeur < min || valeur > max);

    Console.Clear();
    return valeur;
}

// Pose une question oui/non et retourne un booléen
bool DemanderBool(string message)
{
    string reponse;
    do
    {
        Console.Write(message);
        reponse = Console.ReadLine().ToLower().Trim();

        if (reponse != "oui" && reponse != "non" && reponse != "o" && reponse != "n")
        {
            MessageAlerte("Veuillez répondre par 'oui' ou 'non' !");
        }
    } while (reponse != "oui" && reponse != "non" && reponse != "o" && reponse != "n");

    Console.Clear();

    return (reponse == "oui" || reponse == "o");
}

void LancerDuel()
{
    AnimationChargement();
    var player = new SoundPlayer("Assets/Audio/Final Fantasy IX OST - Battle 1.wav");
    player.Play();

    if (Guerrier.guerriers.Count < 2)
    {
        MessageAlerte("Pas assez de combattants pour un duel !");
        return;
    }

    AfficherCombattant();

    Console.ForegroundColor = ConsoleColor.Cyan;
    int index1 = DemanderEntier("\nCombattant 1 (index) : ", 1, Guerrier.guerriers.Count) - 1;
    Console.ResetColor();

    AfficherCombattant();

    Console.ForegroundColor = ConsoleColor.Magenta;
    int index2 = DemanderEntier("\nCombattant 2 (index) : ", 1, Guerrier.guerriers.Count) - 1;
    Console.ResetColor();

    while (index1 == index2)
    {
        MessageAlerte("Vous devez choisir deux combattants différents !");
        index2 = DemanderEntier("Combattant 2 (index) : ", 1, Guerrier.guerriers.Count) - 1;
    }

    Icombattant gagnant = Combattre(Guerrier.guerriers[index1], Guerrier.guerriers[index2]);

    AjouterHistorique(gagnant, Guerrier.guerriers[index1], Guerrier.guerriers[index2]);

    Console.WriteLine($"\nLe gagnant est {gagnant.GetNom()} !");
    player.Stop();
}

void LancerTournoi()
{
    // Animation de chargement + musique d'intro du tournoi
    AnimationChargement();
    var player = new SoundPlayer("Assets/Audio/Tactics Ogre： Championship theme.wav");
    player.PlayLooping(); // On joue la musique UNE SEULE FOIS pour toute la durée du tournoi

    // Si on a moins de 2 combattants, on ne peut pas faire de tournoi
    if (Guerrier.guerriers.Count < 2)
    {
        MessageAlerte("Pas assez de combattants pour lancer un tournoi !");
        return;
    }

    // Introduction épique du tournoi
    Console.Clear();
    Console.WriteLine("\n --- Le Grand Tournoi des Royaumes débute !!!! ---");
    Console.WriteLine("Les guerriers vont s'affronter dans une série de duels épiques...");
    Console.WriteLine("Mais qui l'emportera ? Elfes ? Nains ? Ce tournoi le décidera !");
    Console.WriteLine("\n --- QUE LE GRAND TOURNOI COMMENCE !!!!!! ---");

    AppuyerSurUneTouche("Appuyez sur une touche pour commencer !");

    // Mélange aléatoire des combattants
    List<Icombattant> participants = Guerrier.guerriers.OrderBy(x => Guid.NewGuid()).ToList();

    int tour = 1;

    // Tant qu’il reste plus d’un combattant
    while (participants.Count > 1)
    {
        Console.Clear();
        Console.WriteLine($"\n--- Tour {tour} du tournoi ---");

        List<Icombattant> vainqueursTour = new List<Icombattant>();

        for (int i = 0; i < participants.Count; i += 2)
        {
            if (i + 1 >= participants.Count)
            {
                // Si on a un nombre impair de combattants, le dernier est qualifié d'office
                Console.WriteLine($"⚔️ {participants[i].GetNom()} est qualifié d'office !");
                vainqueursTour.Add(participants[i]);
                continue;
            }

            Icombattant c1 = participants[i];
            Icombattant c2 = participants[i + 1];

            // Affichage avant combat
            Console.WriteLine($"\nDuel : {c1.GetNom()} VS {c2.GetNom()}");
            Console.WriteLine($"{c1.GetNom()} est prêt à en découdre mais {c2.GetNom()} ne se laisse pas intimider !");
            Console.WriteLine("........... COMMENCEZ LE COMBAT !!!");

            AppuyerSurUneTouche("Appuyez sur une touche pour lancer le combat...");

            // Combat entre les deux
            Icombattant vainqueur = Combattre(c1, c2);

            AjouterHistorique(vainqueur, c1, c2);
            
            // Relancer musique de tournoi après la victoire
            player.PlayLooping();

            vainqueursTour.Add(vainqueur);
        }

        participants = vainqueursTour;
        tour++;

        AppuyerSurUneTouche("\nAppuyez sur une touche pour passer au tour suivant...");
    }

    // Fin du tournoi
    player.Stop(); // stop musique de tournoi
    Console.Clear();

    var player1 = new SoundPlayer("Assets/Audio/Tactics Ogre Glory.wav");
    player1.PlayLooping(); // musique de victoire finale

    // Annonce du gagnant
    Console.WriteLine("╔════════════════════════════════════════════════════╗");
    Console.WriteLine("║           !!!! LE TOURNOI EST TERMINÉ !!!!         ║");
    Console.WriteLine("╚════════════════════════════════════════════════════╝");

    Console.WriteLine($"Le grand champion des hautes terres est : ***{participants[0].GetNom()}*** !!!\n");

    Console.WriteLine("Dans l’arène du destin, face à l’acier, à la magie et au sang,");
    Console.WriteLine($"{participants[0].GetNom()} a triomphé avec bravoure, ruse et puissance.");
    Console.WriteLine("Son nom résonnera dans les montagnes comme dans les forêts éternelles.");
    Console.WriteLine("Il ne s’agit plus d’un simple combattant...");
    Console.WriteLine("C’est un **héros légendaire**, un symbole vivant de la gloire de son peuple !\n");

    AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
    player1.Stop();
}

// Gère un combat jusqu'à la victoire d’un combattant
Icombattant Combattre(Icombattant c1, Icombattant c2)
{
    c1.Reset();
    c2.Reset();

    Console.WriteLine($"\nDébut du duel : {c1.GetNom()} VS {c2.GetNom()}\n");

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

        tour++;
    }

    Icombattant vainqueur = c1.GetPointsDeVie() > 0 ? c1 : c2;
    Victoire(vainqueur);

    return vainqueur;
}

// Affiche un message de victoire après le combat
void Victoire(Icombattant gagnant)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n!!!!!! VICTOIRE !!!!!!\n");
    Console.WriteLine($"{gagnant.GetNom()} sort triomphant du combat ! Félicitation à ce fier guerrier !\n");
    Console.ResetColor();


    var player = new SoundPlayer("Assets/Audio/Final Fantasy Fanfare.wav");
    player.Play();

    AppuyerSurUneTouche("\nAppuyez sur une touche pour continuer...");
    player.Stop();
    Console.Clear();
}

// Animation ASCII pour l'attaque
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

// Animation ASCII pour les chargements
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
    Console.Clear();
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
        MessageAlerte("Aucun combat n’a encore été enregistré dans les annales...");
        return;
    }

    
    Console.WriteLine("\n *** HISTORIQUE DES COMBATS ***\n");
    var player = new SoundPlayer("Assets/Audio/page turn.wav");
    player.Play();
    Thread.Sleep(1000);

    int index = 1;
    var player1 = new SoundPlayer("Assets/Audio/Secunda.wav");
    player1.PlayLooping();
    foreach (string combat in historiqueCombats)
    {
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
    Console.WriteLine("Veuillez appuyer sur une touche pour continuer...");
    Console.ReadKey(true);
}

// Ajoute une ligne au journal de l'historique
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
    var player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Guide.wav");
    player.PlayLooping();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║                 GUIDE DU JOUEUR - GUERRES DES PEUPLES ANCESTRAUX        ║");
    Console.WriteLine("║              (Nains, Elfes, Sorciers... et l’Équilibre des Lames)       ║");
    Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝\n");
    Console.ResetColor();

    Console.WriteLine("Bienvenue dans le grand tournoi de la Chicanerie des Hautes Terres !");
    Console.WriteLine("Ce jeu console vous propose de créer des combattants et de les faire s'affronter\n" +
                      "dans des duels épiques ou dans un tournoi sans pitié.\n");

    Console.WriteLine("TYPES DE COMBATTANTS DISPONIBLES :");

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

    Console.WriteLine("\nRÈGLES DE CRÉATION :");
    Console.WriteLine("- Les points de vie (PV) doivent être compris entre 10 et 100.");
    Console.WriteLine("- Le nom du guerrier doit être unique et représentatif.");
    Console.WriteLine("- Vous pouvez créer autant de combattants que vous le souhaitez.");

    Console.WriteLine("\nAPRÈS CHAQUE ACTION :");
    Console.WriteLine("- Un message vous indique ce qui s’est passé.");
    Console.WriteLine("- Vous pouvez revenir au menu à tout moment.");
    Console.WriteLine("- Les combats sont automatiques et commentés.\n");

    Console.WriteLine("OBJECTIF :");
    Console.WriteLine("Créez vos champions, faites-les progresser, et imposez la suprématie de votre peuple\n" +
                      "dans le plus grand tournoi des Hautes Terres !");

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\nBonne chance, stratège. Que vos guerriers tombent avec gloire ou triomphent avec honneur !");
    Console.ResetColor();

    AppuyerSurUneTouche("\nAppuyez sur une touche pour revenir au menu principal...");
    Console.Clear();
}

void AppuyerSurUneTouche (string message)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(message);
    Console.ResetColor();
    Console.ReadKey(true);
}

void MessageAlerte (string alerte)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(alerte);
    Console.ResetColor();
}

void LancerCombatContreMonstre()
{
    AnimationChargement();
    var player = new SoundPlayer("Assets/Audio/Final Fantasy IX OST - Battle 1.wav");
    player.Play();

    if (Guerrier.guerriers.Count < 1)
    {
        MessageAlerte("Pas assez de combattants pour affronter un monstre !");
        return;
    }
    
    
    if (Monstre.monstres.Count == 0)
    {
        MessageAlerte("Aucun monstre disponible pour le combat !");
        Console.WriteLine($"Nombre de monstres disponibles : {Monstre.monstres.Count}");
        player.Stop();
        return;
    }

    AfficherCombattant();

    Console.ForegroundColor = ConsoleColor.Cyan;
    int indexGuerrier = DemanderEntier("\nCombattant 1 (index) : ", 1, Guerrier.guerriers.Count) - 1;
    Console.ResetColor();
    
    
    Random rnd = new Random();
    int indexMonstre = rnd.Next(Monstre.monstres.Count);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.ResetColor();
    
    Icombattant guerrier = Guerrier.guerriers[indexGuerrier];
    Icombattant monstre = Monstre.monstres[indexMonstre];

    Console.WriteLine($"\n Vous affrontez un {monstre.GetNom()} !");
    
    Icombattant gagnant = Combattre(guerrier, monstre);

    Console.WriteLine($"\nLe gagnant est {gagnant.GetNom()} !");
    player.Stop();
}

void LancerCombatContreMonstres()
{
    if (Guerrier.guerriers.Count < 1)
    {
        MessageAlerte("Pas assez de combattants pour affronter les vagues !");
        return;
    }

    AfficherCombattant();

    Console.ForegroundColor = ConsoleColor.Cyan;
    int indexGuerrier = DemanderEntier("\nChoisissez votre guerrier (index) : ", 1, Guerrier.guerriers.Count) - 1;
    Console.ResetColor();

    Icombattant guerrier = Guerrier.guerriers[indexGuerrier];

    int nombreVagues = 3;
    int monstresParVague = 3;

    for (int vague = 1; vague <= nombreVagues; vague++)
    {
        Console.WriteLine($"\n--- Vague {vague} ---");
        Thread.Sleep(500);

        for (int i = 0; i < monstresParVague; i++)
        {
            Random rnd = new Random();
            int indexMonstre = rnd.Next(Monstre.monstres.Count);
            Icombattant monstre = Monstre.monstres[indexMonstre];

            Console.WriteLine($"Votre guerrier {guerrier.GetNom()} affronte un {monstre.GetNom()} !");

            Icombattant gagnant = CombattreMonstre(guerrier, monstre);

            Console.WriteLine($"Le gagnant est {gagnant.GetNom()} !");
            Thread.Sleep(500);

            if (gagnant != guerrier)
            {
                Console.WriteLine("Votre guerrier est tombé au combat. Fin des vagues.");
                return;  // Le guerrier est mort, on arrête
            }
        }

        Console.WriteLine($"Bravo ! Vous avez terminé la vague {vague} sans perdre votre guerrier.");
        Thread.Sleep(700);
    }

    Console.WriteLine("\nFélicitations ! Toutes les vagues ont été vaincues.");
}

Icombattant CombattreMonstre(Icombattant c1, Icombattant c2)
{
    c2.Reset();

    Console.WriteLine($"\nDébut du duel : {c1.GetNom()} VS {c2.GetNom()}\n");

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

        tour++;
    }

    Icombattant vainqueur = c1.GetPointsDeVie() > 0 ? c1 : c2;
    Victoire(vainqueur);

    return vainqueur;
}