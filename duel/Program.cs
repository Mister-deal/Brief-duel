// See https://aka.ms/new-console-template for more information

using duel.Classes;
using duel.Interfaces;
using System.Media;
using System.Text;
using System.Text.Json;
using duel;
using duel.Classes.Sous_Classes;


// Listes pour stocker les guerriers de chaque race
List<Nain> guerriersNains = new List<Nain>();
List<Elfe> guerriersElfes = new List<Elfe>();
List<Sorcier> sorciers = new List<Sorcier>();
List<Berserker> berserkers = new List<Berserker>();
List<Samourai> samourais = new List<Samourai>();

// Listes spécifiques pour catégories de monstres
List<Monstre> monstresClassiques = new List<Monstre>();
List<Monstre> SeigneurDevoreur = new List<Monstre>();
List<Monstre> Dragon = new List<Monstre>();
List<Monstre> Fleau = new List<Monstre>();
List<Monstre> MiniBoss = new List<Monstre>();

// Liste pour enregistrer les combats passés
List<string> historiqueCombats = new List<string>();

int choix = 0;
int choixClass = 0;

//chemin afin d'appeler guerriers.json
/*
string chemin = Path.Combine(AppContext.BaseDirectory, "guerriers.json");
Console.WriteLine($"Chemin utilisé : {chemin}");
*/

// Crée les combattants de départ pour chaque race (Nain, Elfe, Sorcier) en appelant un fichier Json
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
    
    //création des samourais
    Samourai takeshi = new Samourai("Takeshi", 120, 6);
    Samourai hiroshi = new Samourai("Hiroshi", 110, 7);

    // Création des Berserkers
    Berserker ragnar = new Berserker("Ragnar", 150, 7);
    Berserker bjorn = new Berserker("Bjorn", 140, 6);

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
    
    samourais.Add(takeshi);
    samourais.Add(hiroshi);
    
    berserkers.Add(ragnar);
    berserkers.Add(bjorn);

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
    Guerrier.guerriers.Add(takeshi);
    Guerrier.guerriers.Add(hiroshi);
    Guerrier.guerriers.Add(ragnar);
    Guerrier.guerriers.Add(bjorn);

    Console.WriteLine("Les champions sont prêts à en découdre.\n");
    Thread.Sleep(500);
    Console.Clear();
}

void InitialiserMonstres()
{
    Console.WriteLine("Invocation des créatures sauvages...");
    Thread.Sleep(500);

    // Instanciation monstres
    Slime slime = new Slime(); 
    Goblin goblinSimple = new Goblin();
    GoblinBrutal goblinBrutal = new GoblinBrutal(true);
    RatGeant ratGeantNormal = new RatGeant();
    Zombie zombieCommun = new Zombie();
    MortVivantDémoniaque mortVivantDémoniaque = new MortVivantDémoniaque();
    SerpentGéant serpentGéant = new SerpentGéant();
    ChauveSourisSanguinaire chauveSourisSanguinaire = new ChauveSourisSanguinaire();
    EspritDeBraise espritDeBraise = new EspritDeBraise();
    SpectreDuTrépas spectreDuTrépas = new SpectreDuTrépas();
    SqueletteArmé squeletteArmé = new SqueletteArmé();
    
    //Instanciation mini boss
    BrugLeBriseur brug = new BrugLeBriseur("Brugg le Briseur", "Un ogre massif à la peau écailleuse, dont chaque coup peut broyer un bouclier en deux.", 195, 6, 250);
    Morbax morbax = new Morbax("Morbax, l’Ombre Putréfiée", "Un être suintant de ténèbres, réanimé par des rituels interdits.", 240, 6, 350);
    GruikOrcGoblin gruikOrcGoblin = new GruikOrcGoblin("gruik l'orc goblin", "l'orc mi-goblin, mi-porcin horrible et dégoutant",150, 5, 150);
    
    //Instanciation Boss
    SeigneurDevoreur seigneurDevoreur = new SeigneurDevoreur("Zor'kath", "le dévoreur de chair", 400, 7, 700);
    DragonDeGlace dragonDeGlace = new DragonDeGlace("paarturnax dragon de glace", "ragnarok", 450, 7, 1000);
    AzarothLeFleau azarothLeFleau = new AzarothLeFleau("azaroth le fleau", "le faiseur de calamités", 900, 8, 2000);
    
    // Ajout dans les listes spécifiques monstres
    monstresClassiques.Add(slime);
    monstresClassiques.Add(goblinSimple);
    monstresClassiques.Add(goblinBrutal);
    monstresClassiques.Add(ratGeantNormal);
    monstresClassiques.Add(zombieCommun);
    monstresClassiques.Add(mortVivantDémoniaque);
    monstresClassiques.Add(serpentGéant);
    monstresClassiques.Add(chauveSourisSanguinaire);
    monstresClassiques.Add(espritDeBraise);
    monstresClassiques.Add(spectreDuTrépas);
    monstresClassiques.Add(squeletteArmé);
    
    // Ajout dans les listes spécifiques BOSS
    SeigneurDevoreur.Add(seigneurDevoreur);
    Dragon.Add(dragonDeGlace);
    Fleau.Add(azarothLeFleau);
    
    // Ajout dans les listes spécifiques mini BOSS
    MiniBoss.Add(gruikOrcGoblin);
    MiniBoss.Add(morbax);
    MiniBoss.Add(brug);
    
    //ajout boss
    Monstre.monstres.Add(seigneurDevoreur);
    Monstre.monstres.Add(dragonDeGlace);
    Monstre.monstres.Add(azarothLeFleau);
    
    //ajout mini boss
    Monstre.monstres.Add(gruikOrcGoblin);
    Monstre.monstres.Add(morbax);
    Monstre.monstres.Add(brug);
    
    //ajout monstres classiques
    Monstre.monstres.Add(slime);
    Monstre.monstres.Add(goblinBrutal);
    Monstre.monstres.Add(goblinBrutal);
    Monstre.monstres.Add(ratGeantNormal);
    Monstre.monstres.Add(zombieCommun);
    Monstre.monstres.Add(serpentGéant);
    Monstre.monstres.Add(espritDeBraise);
    Monstre.monstres.Add(mortVivantDémoniaque);
    Monstre.monstres.Add(squeletteArmé);
    Monstre.monstres.Add(chauveSourisSanguinaire);
    Monstre.monstres.Add(spectreDuTrépas);

    Console.WriteLine("Les monstres rôdent dans les environs.\n");
    Console.WriteLine("... des monstres extrêmement puissant rôdent également ! soyez sur vos gardes, combattants !");
    Thread.Sleep(1500);
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
    Console.WriteLine("║               LE TOURNOI DES CIMES : L'épopée des trois terres               ║");
    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝\n");

Console.WriteLine("  *Extrait du Codex des Hautes Arènes...*\n");

Console.WriteLine("« Nul ne se souvient de l'époque exacte.");
Console.WriteLine("Seuls les anciens, aux voix usées par le temps, murmurent encore les mots.");
Console.WriteLine("Il fut un âge où les peuples de ce monde vivaient côte à côte.");
Console.WriteLine("Non sans tensions, mais liés par un pacte plus fort que l'acier :");
Console.WriteLine("celui du respect mutuel, de la mémoire des origines, et de la paix sacrée des cimes. »\n");

Console.WriteLine("Mais le monde tourne, inlassable.");
Console.WriteLine("Les alliances se brisent comme des chaînes rouillées, et les vieilles rancunes,");
Console.WriteLine("enfouies sous des siècles de silence, s'élèvent à nouveau avec le vent des montagnes.\n");

Console.WriteLine("Les anciennes terres, jadis partagées entre les forêts elfes, les citadelles naines,");
Console.WriteLine("et les bastions des ordres mystiques, sont redevenues des zones de discorde.");
Console.WriteLine("Des mots de guerre ont été prononcés. Des serments oubliés ont été brisés.");
Console.WriteLine("Mais plutôt que de plonger le monde dans un bain de feu et de ruine… une voie fut choisie.\n");

Console.WriteLine("Une voie ancienne. Une voie sacrée.");
Console.WriteLine("Celle du **Tournoi des Cimes**.\n");

Console.WriteLine("Dans l’ombre de pics millénaires, un cercle d’arènes fut érigé.");
Console.WriteLine("Chaque peuple, chaque culture, chaque lignage fut appelé à désigner ses champions.");
Console.WriteLine("Guerriers et guerrières, mages et stratèges, lames silencieuses et bêtes rugissantes — tous convergent vers ce sommet interdit.");
Console.WriteLine("Non pour détruire. Mais pour vaincre.");
Console.WriteLine("Car ici, dans ces hauteurs gelées par le souffle des anciens dieux, le sort du monde sera décidé par l'épreuve rituelle.\n");

Console.WriteLine("Les Nains, aux marteaux aussi lourds que leur fierté.");
Console.WriteLine("Les Elfes, porteurs de magie et d’arrogance millénaire.");
Console.WriteLine("Les Sorciers, dont les yeux ont vu l’invisible.");
Console.WriteLine("Les Berserkers, que la rage consume plus vite que la peur.");
Console.WriteLine("Les Samouraïs, lames de l’honneur, silencieux comme la neige.");
Console.WriteLine("Tous ont répondu à l’appel ancestral.\n");

Console.WriteLine("Et toi, étranger, inconnu, peut-être élu… es-tu prêt à inscrire ton nom parmi eux ?");
Console.WriteLine("Es-tu prêt à embrasser la gloire ou à tomber pour l’éternité ?");
Console.WriteLine("Car ce tournoi ne couronne pas seulement des héros.");
Console.WriteLine("Il scelle des pactes, brise des lignées, et grave dans la pierre le destin des peuples.\n");

Console.WriteLine("Tu n'es plus un simple combattant.");
Console.WriteLine("Tu es un porteur de flamme. Un héraut du jugement.");
Console.WriteLine("Tu entres dans l’arène des légendes.\n");

Console.WriteLine("Bienvenue... dans le **Tournoi des Cimes**.");

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
                                  "  3. Ajouter un sorcier \n" +
                                  "  4. Ajouter un Berserker \n" +
                                  "  5. Ajouter un Samouraï\n");
                choixClass = DemanderEntier("Donnez un chiffre: ", 1, 5);

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

                    case 4:
                        // Ajoute un nouveau Berserker avec ses caractéristiques
                        AjouterBerserker();
                        Console.Clear();
                        break;

                    case 5:
                        // Ajoute un nouveau Samouraï avec ses caractéristiques
                        AjouterSamourai();
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
                AfficherListeBerserkers();
                AfficherListeSamourais();

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
                Console.Clear();
                break;
            case 6:
                // Affiche l’historique des duels passés
                AfficherHistorique();
                Console.Clear();
                break;
            case 7:
                // Affiche les règles et explications du jeu
                AfficherGuideUtilisateur();
                Console.Clear();
                break;
            case 8:
                Console.Clear();
                var player1 = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Painful Battle.wav");
                player1.PlayLooping();
                Console.WriteLine("==== Zone PvE ====");
                Console.WriteLine("1. Affronter un monstre");
                Console.WriteLine("2. Affronter un boss");
                Console.WriteLine("3. Affronter une vague de monstres");
                Console.WriteLine("4. Lancer tournoi des cimes");
                Console.WriteLine("5. Retour au menu principal");
                Console.Write("Votre choix : ");
                choix = DemanderEntier("Faites votre choix: ", 1, 5);
                switch (choix)
                {
                    case 1:
                        LancerCombatContreMonstre();
                        Console.Clear();
                        break;
                    case 2:
                        LancerCombatContreBoss();
                        Console.Clear();
                        break;
                    case 3:
                        LancerCombatContreMonstres();
                        Console.Clear();
                        break;
                    case 4:
                        LancerTournoiDesCimes();
                        break;
                    case 5:
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
    Console.WriteLine("\nQuel guerrier souhaitez-vous envoyer rejoindre ses ancêtres ?\n");

    // Affichage des guerriers disponibles
    for (int i = 0; i < Guerrier.guerriers.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Guerrier.guerriers[i].GetNom()}");
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    int index = DemanderEntier("\nCombattant à supprimer (index) : ", 1, Guerrier.guerriers.Count) - 1;
    Console.ResetColor();

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
void AjouterBerserker()
{
    var player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Menu.wav");
    player.PlayLooping();

    string nom = DemanderTexte("Nom du Berserker : ");

    int pv = DemanderEntier("Points de vie (10 - 150) : ", 10, 150);

    int nbDes = DemanderEntier("Nombre de dés d'attaque (1 - 10) : ", 1, 10);

    Berserker berserker = new Berserker(nom, pv, nbDes);
    berserkers.Add(berserker);
    Guerrier.guerriers.Add(berserker);

    Console.WriteLine($"{nom} a été ajouté à la liste des Berserkers et combattra avec rage !");

    AppuyerSurUneTouche("\nAppuyez sur une touche pour continuer...");

    player.Stop();
}

void AjouterSamourai()
{
    var player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Menu.wav");
    player.PlayLooping();

    string nom = DemanderTexte("Nom du Samouraï : ");

    int pv = DemanderEntier("Points de vie (10 - 120) : ", 10, 120);

    int nbDes = DemanderEntier("Nombre de dés d'attaque (1 - 10) : ", 1, 10);

    Samourai samourai = new Samourai(nom, pv, nbDes);
    samourais.Add(samourai);
    Guerrier.guerriers.Add(samourai);

    Console.WriteLine($"{nom} a été ajouté à la liste des Samouraïs et combattra avec honneur !");

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
void AfficherListeBerserkers()
{
    if (berserkers.Count == 0)
    {
        MessageAlerte("Aucun berserker créé pour l’instant.");
        return;
    }

    Console.WriteLine("--- Liste des Berserkers ---");
    for (int i = 0; i < berserkers.Count; i++)
    {
        Console.Write($"{i + 1}. ");
        berserkers[i].AfficherInfos();
    }
}

void AfficherListeSamourais()
{
    if (samourais.Count == 0)
    {
        MessageAlerte("Aucun samouraï créé pour l’instant.");
        return;
    }

    Console.WriteLine("--- Liste des Samouraïs ---");
    for (int i = 0; i < samourais.Count; i++)
    {
        Console.Write($"{i + 1}. ");
        samourais[i].AfficherInfos();
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
    player.PlayLooping();

    AppuyerSurUneTouche("\nAppuyez sur une touche pour continuer...");
    player.Stop();
    Console.Clear();
}

void VictoireMonstre(Guerrier guerrierGagnant, Monstre monstreVaincu)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n!!!!!! VICTOIRE !!!!!!\n");
    Console.WriteLine($"{guerrierGagnant.GetNom()} sort triomphant du combat ! Félicitation à ce fier guerrier !\n");
    Console.ResetColor();


    var player = new SoundPlayer("Assets/Audio/Final Fantasy Fanfare.wav");
    player.PlayLooping();

    guerrierGagnant.GagnerExperience(monstreVaincu.DonnerExperience());

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

        AppuyerSurUneTouche("\nVeuillez appuyer sur une touche pour continuer...");
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
    AppuyerSurUneTouche("Veuillez appuyer sur une touche pour continuer...");
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
    Console.WriteLine("║    (Nains, Elfes, Sorciers... et les Tournois de l'Équilibre Éternel)   ║");
    Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝\n");
    Console.ResetColor();

Console.WriteLine("Bienvenue dans l’arène ancestrale de la Chicanerie des Hautes Terres !");
Console.WriteLine("Ce jeu console vous permet de créer des combattants, d'explorer des zones PvE,\n" +
                  "et de vous mesurer à des adversaires redoutables dans des tournois épiques.\n");

Console.WriteLine("TYPES DE COMBATTANTS DISPONIBLES :");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("• Guerrier : Classe de base à attaque aléatoire.");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("• Nain : Tank robuste, subit moins de dégâts grâce à son armure lourde.");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("• Elfe : Agile et précis, garantit un minimum de dégâts à chaque attaque.");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("• Sorcier : Manipule la magie, utilise le feu, le soin et la protection via le mana.");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("• Berserker : Inflige d’énormes dégâts en contrepartie d’une défense faible.");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("• Samouraï : Maître du duel, riposte souvent et mise sur la précision létale.");
Console.ResetColor();

Console.WriteLine("\nNOUVEAUTÉS :");
Console.WriteLine("- Une zone **PvE** est désormais disponible : survivez à des vagues de monstres !");
Console.WriteLine("- Un mini-boss surgit parfois dans l’ombre après les combats classiques.");
Console.WriteLine("- Un **boss final** vous attend pour conclure les tournois les plus périlleux.");
Console.WriteLine("- Le **Tournoi des Cimes** a été ajouté : une épreuve extrême mêlant monstres,\n  mini-boss et boss final pour les combattants les plus téméraires.");

Console.WriteLine("\nRÈGLES DE CRÉATION :");
Console.WriteLine("- Les points de vie (PV) doivent être compris entre 10 et 150.");
Console.WriteLine("- Le nom du combattant doit être unique et refléter sa gloire future.");
Console.WriteLine("- Vous pouvez créer autant de combattants que vous le souhaitez.");

Console.WriteLine("\nAPRÈS CHAQUE ACTION :");
Console.WriteLine("- Un message décrit les événements marquants.");
Console.WriteLine("- Vous pouvez revenir au menu principal à tout moment.");
Console.WriteLine("- Les combats sont automatisés et richement commentés.\n");

Console.WriteLine("OBJECTIF :");
Console.WriteLine("Constituez votre armée de champions, affrontez d’autres peuples et monstres,\n" +
                  "et imposez la suprématie de votre lignée dans les Tournois des Hautes Terres !");

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nBonne chance, stratège. Que vos guerriers tombent avec panache ou triomphent avec honneur !");
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
    var player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Adventurer's knowledge.wav");
    player.PlayLooping();

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
    int indexMonstre = rnd.Next(monstresClassiques.Count);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.ResetColor();
    
    Icombattant guerrier = Guerrier.guerriers[indexGuerrier];
    Icombattant monstre = monstresClassiques[indexMonstre];

    Console.WriteLine($"\n Vous affrontez un {monstre.GetNom()} !");
    
    Icombattant gagnant = CombattreMonstre(guerrier, monstre);

    guerrier.Reset();

    if (gagnant != guerrier)
    {
        MessageAlerte("Votre guerrier est tombé au combat. Fin des vagues.");
        AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
    }
    player.Stop();
}

void LancerCombatContreMonstres()
{
    var player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Adventurer's knowledge.wav");
    player.PlayLooping();

    if (Guerrier.guerriers.Count < 1)
    {
        MessageAlerte("Pas assez de combattants pour affronter les vagues !");
        player.Stop();
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
        player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Adventurer's knowledge.wav");
        player.Play();

        for (int i = 0; i < monstresParVague; i++)
        {
            player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Adventurer's knowledge.wav");
            player.Play();
            Random rnd = new Random();
            int indexMonstre = rnd.Next(monstresClassiques.Count);
            Icombattant monstre = monstresClassiques[indexMonstre];

            Console.WriteLine($"Votre guerrier {guerrier.GetNom()} affronte un {monstre.GetNom()} !");

            Icombattant gagnant = CombattreMonstre(guerrier, monstre);

            if (gagnant != guerrier)
            {
                MessageAlerte("Votre guerrier est tombé au combat. Fin des vagues.");
                player.Stop();
                AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
                return;
            }

            Thread.Sleep(500);
        }

        Console.WriteLine($"Bravo ! Vous avez terminé la vague {vague} sans perdre votre guerrier.");
        Thread.Sleep(700);
    }

    // Stop la musique initiale en boucle avant d'en lancer une autre
    player.Stop();

    var player1 = new SoundPlayer("Assets/Audio/nature.wav");
    player1.Play();

    guerrier.Reset();
    Console.WriteLine("...Après une lutte acharnée, vous pensez enfin pouvoir souffler.");
    Thread.Sleep(2000);
    Console.WriteLine("Le calme semble revenir, les ombres se dissipent, et l’espoir renaît.");
    Thread.Sleep(2000);
    Console.WriteLine("Mais dans l’obscurité, un souffle furtif trahit une présence sournoise...");
    Thread.Sleep(3000);

    player1.Stop();
    var player2 = new SoundPlayer("Assets/Audio/roar.wav");
    player2.Play();

    Console.WriteLine("Un monstre grotesque et grand, guettant l’instant parfait pour porter un coup fatal.");
    Thread.Sleep(1500);
    Console.WriteLine("Prêt à profiter de votre faiblesse, il avance, impitoyable et opportuniste !!!!");
    Thread.Sleep(1000);

    Console.WriteLine("\nUn mini-boss surgit après les vagues !");
    Thread.Sleep(1000);
    Console.WriteLine("PREPAREZ VOUS AU COMBAT !");

    player2.Stop();
    var player3 = new SoundPlayer("Assets/Audio/Survival of the fittest.wav");
    player3.PlayLooping();

    AppuyerSurUneTouche("Appuyez sur une touche pour affronter le monstre abject !");
    Console.ReadKey(true);

    Console.WriteLine("Vous affrontez le pouilleux opportuniste ! Aucune Pitié face aux chiens !");

    if (MiniBoss.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Aucun mini boss n'est présent");
        player.Stop();
        return;
    }

    Icombattant miniBoss = MiniBoss[0];
    Icombattant gagnantBoss = CombattreMonstre(guerrier, miniBoss);

    if (gagnantBoss != guerrier)
    {
        MessageAlerte("Votre champion a été dévoré par le Seigneur... Fin.");
        player.Stop();
        AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
        return;
    }

    AjouterHistorique(gagnantBoss, guerrier, miniBoss);

    player.Stop();

    Console.WriteLine("\nFélicitations ! Vous avez vaincu toutes les vagues et le mini-boss !");
    AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
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

    if (vainqueur == c1)
    {
        var guerrierGagnant = (Guerrier)c1;
        var monstreVaincu = (Monstre)c2;
        VictoireMonstre(guerrierGagnant, monstreVaincu);
    } else
    {
        MessageAlerte("Votre guerrier est tombé au combat. Fin des vagues.");
        YouLose();
        AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
    }

    return vainqueur;
}

void LancerCombatContreBoss()
{
    Console.Clear();
    var player = new SoundPlayer("Assets/Audio/Tactics Ogre Catastrophe.wav");
    player.PlayLooping();
    Console.WriteLine("\n=== CHOISISSEZ VOTRE BOSS À AFFRONTER ===");
    Console.WriteLine("1. Seigneur Dévoreur");
    Console.WriteLine("2. Dragon de Glace");
    Console.WriteLine("3. Azaroth le Fléau");
    Console.WriteLine("4. retour");

    int choix = DemanderEntier("Votre choix : ", 1, 4);
    Console.WriteLine();

    switch (choix)
    {
        case 1:
            LancerCombatContreSeigneurDevoreur();
            break;
        case 2:
            LancerCombatContreDragon();
            break;
        case 3:
            LancerCombatContreAzaroth();
            break;
        case 4:
            Console.WriteLine("merci et au revoir.");
            Console.Clear();
            break;
        default:
            Console.WriteLine("Choix invalide. Retour au menu principal.");
            break;
    }
}
void LancerCombatContreSeigneurDevoreur()
{
    AnimationChargement();

    if (Guerrier.guerriers.Count < 1)
    {
        MessageAlerte("Pas assez de combattants pour affronter le Seigneur Dévoreur !");
        return;
    }

    if (SeigneurDevoreur.Count == 0)
    {
        MessageAlerte("Aucun Seigneur Dévoreur disponible !");
        return;
    }

    AfficherCombattant();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    int indexGuerrier = DemanderEntier("\nChoisissez votre héros pour affronter le Dévoreur : ", 1, Guerrier.guerriers.Count) - 1;
    Console.ResetColor();

    Icombattant guerrier = Guerrier.guerriers[indexGuerrier];
    Icombattant boss = SeigneurDevoreur[0];

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║                    L'HEURE DU JUGEMENT SONNE                   ║");
    Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
    Console.WriteLine($"{guerrier.GetNom().ToUpper()} s'avance lentement, porté par la rumeur des âmes déchues.");
    Thread.Sleep(3000);
    Console.WriteLine("Devant lui, un titan abject surgit d’un gouffre béant, vomissant cendres et flammes.");
    Thread.Sleep(3000);
    Console.WriteLine($"C’est le SEIGNEUR DÉVOREUR, fléau des royaumes et destructeur de mondes.");
    var player1 = new SoundPlayer("Assets/Audio/warrior roar.wav");
    player1.Play();
    Thread.Sleep(5000);
    Console.WriteLine();
    Console.WriteLine("Les terres frémissent, l’air se gorge de malédictions, et le ciel s’assombrit.");
    var player = new SoundPlayer("Assets/Audio/Winter Absolution.wav");
    player.Play();
    Thread.Sleep(2000);
    Console.WriteLine("Un seul faux pas... et c’est l’anéantissement.");
    Thread.Sleep(3000);
    Console.WriteLine($"\nDuel légendaire : {guerrier.GetNom().ToUpper()} VS {boss.GetNom()} !");
    Console.WriteLine("═════════════════════════════════════════════════════════════════");
    Console.ResetColor();
    AppuyerSurUneTouche("\nAppuyez sur une touche pour affronter le Dévoreur...");
    Icombattant gagnant = CombattreMonstre(guerrier, boss);

    guerrier.Reset();
    if (gagnant != guerrier)
    {
        MessageAlerte("Votre champion a été dévoré par le Seigneur... Fin.");
        AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
    }

    AjouterHistorique(gagnant, guerrier, boss);

    AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");

    player.Stop();
}
void LancerCombatContreDragon()
{
    AnimationChargement();

    if (Guerrier.guerriers.Count < 1)
    {
        MessageAlerte("Pas assez de combattants pour affronter le Dragon de Glace !");
        return;
    }

    if (Dragon.Count == 0)
    {
        MessageAlerte("Aucun Dragon de Glace n'a été trouvé !");
        return;
    }

    AfficherCombattant();
    Console.ForegroundColor = ConsoleColor.Cyan;
    int indexGuerrier = DemanderEntier("\nChoisissez un combattant pour défier le Dragon : ", 1, Guerrier.guerriers.Count) - 1;
    Console.ResetColor();

    Icombattant guerrier = Guerrier.guerriers[indexGuerrier];
    Icombattant boss = Dragon[0];

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║                AFFRONTEMENT DANS LES CIMES GLACÉES              ║");
    Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
    Console.WriteLine($"{guerrier.GetNom().ToUpper()} grimpe les falaises figées par le temps et le froid éternel...");
    Thread.Sleep(3000);
    Console.WriteLine("Au sommet, le ciel s’ouvre sur un hurlement venu d’ailleurs.");
    var player1 = new SoundPlayer("Assets/Audio/dragon roar.wav");
    player1.Play();
    Thread.Sleep(5000);
    Console.WriteLine($"LE DRAGON DE GLACE, millénaire et invincible, étend ses ailes gelées.");
    Thread.Sleep(2000);
    Console.WriteLine();
    var player = new SoundPlayer("Assets/Audio/Xenoblade Chronicles Dragon.wav");
    player.Play();
    Console.WriteLine("Son souffle glace la lumière elle-même. Même les dieux hésitent à s’en approcher.");
    Thread.Sleep(3000);
    Console.WriteLine("Mais {0} ne recule pas. Car aujourd’hui, c’est le feu contre la glace.", guerrier.GetNom());
    Thread.Sleep(2000);
    Console.WriteLine($"\n Le froid mord... {guerrier.GetNom()} affronte {boss.GetNom()} !");
    Console.WriteLine("═════════════════════════════════════════════════════════════════");
    Console.ResetColor();
    AppuyerSurUneTouche("\nAppuyez sur une touche pour défier le Dragon...");
    Icombattant gagnant = CombattreMonstre(guerrier, boss);

    guerrier.Reset();
    if (gagnant != guerrier)
    {
        MessageAlerte("Votre guerrier a été gelé à jamais...");
        AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
    }

    AjouterHistorique(gagnant, guerrier, boss);

    AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");

    player.Stop();
}
void LancerCombatContreAzaroth()
{
    AnimationChargement();

    if (Guerrier.guerriers.Count < 1)
    {
        MessageAlerte("Vous n'avez aucun guerrier pour affronter le Fléau du Néant !");
        return;
    }

    if (Fleau.Count == 0)
    {
        MessageAlerte("Azaroth est introuvable... Le Néant vous épargne cette fois.");
        return;
    }

    AfficherCombattant();
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    int indexGuerrier = DemanderEntier("\nQuel héros ose défier Azaroth ? : ", 1, Guerrier.guerriers.Count) - 1;
    Console.ResetColor();

    Icombattant guerrier = Guerrier.guerriers[indexGuerrier];
    Icombattant boss = Fleau[0];

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("═══════════════════════════════════════════════════════════════");
    Console.WriteLine($"{guerrier.GetNom().ToUpper()} s'avance, l'arme au poing, le regard brûlant de détermination !");
    Thread.Sleep(3000);
    Console.WriteLine("Devant lui, les cieux se fendent, le sol se fissure, et le Néant prend forme...");
    Thread.Sleep(3000);
    Console.WriteLine("Une silhouette monstrueuse émerge, noyée dans les ténèbres absolues.");
    Thread.Sleep(3000);
    Console.WriteLine($"  C’est AZAROTH, le Fléau du Néant — incarnation de la fin, tisseur du désespoir.");
    var player1 = new SoundPlayer("Assets/Audio/Boss roar.wav");
    player1.Play();
    Thread.Sleep(6000);
    
    Console.WriteLine();
    Console.WriteLine("Les étoiles s'éteignent, le vent se tait. Le monde retient son souffle.");
    Thread.Sleep(3000);
    var player = new SoundPlayer("Assets/Audio/Final Fantasy X.wav");
    player.Play();
    Console.WriteLine("C’est l’ultime combat. Il n’y aura ni fuite... ni seconde chance.");
    Thread.Sleep(1000);
    Console.WriteLine($"\n Le destin s'effondre... {guerrier.GetNom().ToUpper()} affronte {boss.GetNom()} !");
    Console.WriteLine("═══════════════════════════════════════════════════════════════");
    Console.ResetColor();
    Console.WriteLine($"\n Le destin s'effondre... {guerrier.GetNom().ToUpper()} affronte {boss.GetNom()} !");
    AppuyerSurUneTouche("Appuyez sur une touche pour affronter le faiseur de calamités...");
    Icombattant gagnant = CombattreMonstre(guerrier, boss);

    guerrier.Reset();
    if (gagnant != guerrier)
    {
        MessageAlerte("Le Néant a englouti votre espoir.");
        AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
    }

    AjouterHistorique(gagnant, guerrier, boss);

    //AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");

    player.Stop();
}


void YouLose()
{
    Console.Clear();
    var player = new SoundPlayer("Assets/Audio/Final Fantasy Tactics Game Over.wav");
    player.Play();
    Console.ForegroundColor = ConsoleColor.DarkRed;

    Console.WriteLine("\n VOUS ÊTES TOMBÉ AU COMBAT... \n");
    Thread.Sleep(1800);
    Console.WriteLine("Les ténèbres s'étendent...");
    Thread.Sleep(1800);
    Console.WriteLine("Votre nom s'efface dans les mémoires...");
    Thread.Sleep(1800);

    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("\n        GAME OVER        ");
    Console.ResetColor();

    Thread.Sleep(1500);
}
/*
List<Guerrier> ChargerGuerriersDepuisJson(string chemin)
{
    var options = new JsonSerializerOptions
    {
        Converters = { new GuerrierConverter() },
        PropertyNameCaseInsensitive = true
    };

    string json = File.ReadAllText(chemin);
    List<Guerrier> guerriers = JsonSerializer.Deserialize<List<Guerrier>>(json, options);
    return guerriers ?? new List<Guerrier>();
}
*/
void LancerTournoiDesCimes()
{
    var musiqueTournoi = new SoundPlayer("Assets/Audio/Tactics Ogre： Championship theme.wav");;
    musiqueTournoi.PlayLooping();

    if (Guerrier.guerriers.Count < 1)
    {
        MessageAlerte("Pas assez de combattants pour participer au tournoi !");
        musiqueTournoi.Stop();
        return;
    }

    AfficherCombattant();

    Console.ForegroundColor = ConsoleColor.Cyan;
    int indexGuerrier = DemanderEntier("\nChoisissez votre champion (index) : ", 1, Guerrier.guerriers.Count) - 1;
    Console.ResetColor();

    Icombattant guerrier = Guerrier.guerriers[indexGuerrier];

    int nombreRounds = 3;      // rounds = vagues de monstres
    int monstresParRound = 4;  // monstres par round

    for (int round = 1; round <= nombreRounds; round++)
    {
        Console.WriteLine($"\n=== Round {round} du Tournoi ===");
        Thread.Sleep(700);
        musiqueTournoi.Play();

        for (int i = 0; i < monstresParRound; i++)
        {
            musiqueTournoi.Play();
            Random rnd = new Random();
            int indexMonstre = rnd.Next(monstresClassiques.Count);
            Icombattant monstre = monstresClassiques[indexMonstre];

            Console.WriteLine($"Votre champion {guerrier.GetNom()} affronte un {monstre.GetNom()} !");
            Icombattant gagnant = CombattreMonstre(guerrier, monstre);

            if (gagnant != guerrier)
            {
                MessageAlerte("Votre champion est tombé. Le tournoi s'arrête ici.");
                musiqueTournoi.Stop();
                AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
                return;
            }

            Thread.Sleep(500);
        }

        Console.WriteLine($"Bravo ! Vous avez remporté le round {round}.");
        Thread.Sleep(800);
    }

    musiqueTournoi.Stop();

    Console.WriteLine("\nAprès ces combats acharnés, vous sentez le souffle du tournoi s'intensifier...");
    Thread.Sleep(2000);

    // Mini-boss opportuniste
    var musiqueMiniBoss = new SoundPlayer("Assets/Audio/roar.wav");
    musiqueMiniBoss.Play();

    Console.WriteLine("\nUn souffle sournois se fait entendre dans l'ombre...");
    Thread.Sleep(1500);
    Console.WriteLine("Un mini-boss surgit, prêt à frapper au moment où vous baissez la garde !");
    Thread.Sleep(1500);
    guerrier.Reset();
    Console.WriteLine("PREPAREZ-VOUS À CE COMBAT DÉCISIF !");

    musiqueMiniBoss.Stop();
    var musiqueCombatMiniBoss = new SoundPlayer("Assets/Audio/Survival of the fittest.wav");
    musiqueCombatMiniBoss.PlayLooping();

    AppuyerSurUneTouche("Appuyez sur une touche pour défier le mini-boss !");
    Console.ReadKey(true);

    if (MiniBoss.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Aucun mini-boss n'est disponible. Le tournoi continue...");
        Console.ResetColor();
    }
    else
    {
        Icombattant miniBoss = MiniBoss[0];
        Icombattant gagnantMiniBoss = CombattreMonstre(guerrier, miniBoss);

        if (gagnantMiniBoss != guerrier)
        {
            MessageAlerte("Votre champion a été vaincu par le mini-boss. Fin du tournoi.");
            musiqueCombatMiniBoss.Stop();
            AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
            return;
        }
        else
        {
            Console.WriteLine("\nVotre champion a terrassé le mini-boss !");
            Thread.Sleep(1500);
        }
    }

    musiqueCombatMiniBoss.Stop();

    // Combat final contre le boss du tournoi
    var musiqueBoss = new SoundPlayer("Assets/Audio/Winter Absolution.wav");
    musiqueBoss.PlayLooping();

    Console.WriteLine("\nL'arène tremble... Le champion du tournoi fait son entrée !");
    Thread.Sleep(2000);
    Console.WriteLine("Voici venu le moment décisif : le combat final contre le BOSS !");
    guerrier.Reset();
    Thread.Sleep(1500);

    if (SeigneurDevoreur.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erreur : Aucun boss final n'est défini !");
        musiqueBoss.Stop();
        return;
    }

    Icombattant bossFinal = SeigneurDevoreur[0];
    Icombattant gagnantBoss = CombattreMonstre(guerrier, bossFinal);

    if (gagnantBoss != guerrier)
    {
        MessageAlerte("Votre champion a été écrasé par le boss final... Fin du tournoi.");
        musiqueBoss.Stop();
        AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
        return;
    }

    musiqueBoss.Stop();

    var glory = new SoundPlayer("Assets/Audio/Tactics Ogre Glory.wav");
    glory.PlayLooping(); // musique de victoire finale

    // Annonce du gagnant
    Console.WriteLine("╔════════════════════════════════════════════════════╗");
    Console.WriteLine("║           !!!! LE TOURNOI EST TERMINÉ !!!!         ║");
    Console.WriteLine("╚════════════════════════════════════════════════════╝");
    Console.WriteLine("\n\nFélicitations ! Vous avez remporté le Tournoi des Cimes !");
    Console.WriteLine("Votre nom sera gravé dans les annales comme un héros légendaire !");
    Console.WriteLine("Il ne s’agit plus d’un simple combattant...");
    Console.WriteLine("C’est un **héros légendaire**, un symbole vivant de la gloire de son peuple !\n");

    AppuyerSurUneTouche("Appuyez sur une touche pour continuer...");
    glory.Stop();
}