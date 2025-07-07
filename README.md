🛡️ Duels de Guerriers

Un projet en C# pour s’amuser avec de la programmation orientée objet, des combats tactiques tour par tour, et une interface console immersive.
Crée tes guerriers, fais-les s’affronter en duels ou en tournois, affronte des vagues de monstres sauvages, et découvre qui sera le dernier champion debout dans cette lutte ancestrale entre Nains, Elfes, Guerriers, Sorciers, Berserkers et Samouraïs !
🌍 Contexte & Lore

Dans les terres oubliées des Hautes Terres, les rivalités entre races millénaires n'ont jamais cessé.
Les Nains, maîtres des montagnes et forgerons légendaires, s'opposent farouchement aux Elfes, êtres gracieux et maîtres de la magie naturelle.
Les Guerriers humains, valeureux et aguerris, luttent pour honorer leurs terres, tandis que les mystérieux Sorciers gardiens des arcanes manipulent les forces occultes pour renverser le cours du combat.
Aux confins de ces conflits, les Berserkers rugissent en furie sauvage, prêts à tout pour la victoire, tandis que les Samouraïs, disciplinés et précis, incarnent l’honneur martial ultime.

À travers ce tournoi et ces combats contre des créatures terrifiantes, c’est la suprématie qui sera décidée, et la gloire immortalisée dans les chants des bardes.
🎮 Principe du Jeu

Le joueur crée une équipe de combattants issus de différentes classes, chacune avec ses spécificités et son style de combat, puis les fait s’affronter dans des duels, un grand tournoi ou des combats PVE contre des vagues de monstres et des boss puissants.
Tout se passe dans le terminal, avec un système de combat au tour par tour.
🔧 Fonctionnalités par Partie
✅ Partie I — Base : la classe Guerrier

    Création d'une classe Guerrier avec nom, points de vie (PV), et dés d'attaque.

    Méthodes :

        Attaquer() : lance les dés pour infliger des dégâts.

        SubirDegats(int) : réduit les PV du guerrier.

        AfficherInfos() : affiche les informations du guerrier.

🧝 Partie II — Héritage : Nain et Elfe

    Nain : robuste, équipé d'une armure lourde qui réduit les dégâts subis.

    Elfe : agile, avec une attaque assurée d’un minimum de dégâts.

🧙 Partie III — Les Sorciers

    Introduction de la classe Sorcier, maîtres de la magie.

    Disposent de mana et de sorts variés :

        Boule de Feu : attaque puissante infligeant des dégâts magiques.

        Soin : restaure les points de vie d’un allié ou de soi-même.

        Bouclier Magique : réduit les dégâts subis pendant plusieurs tours.

🏆 Partie IV — Duel et Tournoi

    Menu console interactif pour :

        Créer, afficher et supprimer des combattants (Nains, Elfes, Guerriers, Sorciers).

        Lancer des duels automatiques ou un tournoi complet.

        Gérer une liste globale de tous les combattants.

✨ Partie V — Amélioration du Tournoi

    Ajout de règles avancées :

        Gestion des rounds, élimination progressive.

        Suivi des statistiques (victoires, défaites).

        Mise en place d’animations textuelles et effets colorés en console.

        Meilleure interface utilisateur pour choisir les combattants et visualiser les résultats.

🐉 Partie VI — Zone PVE : vagues de monstres

    Affronte des vagues successives de monstres (Slimes, Gobelins, Rats Géants, Zombies).

    Chaque vague devient progressivement plus difficile.

    Repose-toi, soigne tes combattants et prépare ta stratégie.

👹 Partie VII — Combat contre les Boss

    Prépare-toi à combattre des boss redoutables tels que :

        Seigneur Dévoreur

        Dragon de Glace

        Azaroth le Fléau

    Ces combats testent ta maîtrise du système et la composition optimale de ton équipe.

⚔️ Partie VIII — Ajout des Berserkers et Samouraïs

    Introduction des classes Berserker et Samouraï :

        Berserker : guerrier sauvage, capable d’entrer en furie et infliger des dégâts massifs.

        Samouraï : combattant précis, agile et tactique avec des compétences spéciales.

    Ces classes apportent de nouvelles stratégies et du dynamisme au combat.

🚀 Lancer le Projet

    Ouvre le projet dans ton IDE préféré (Visual Studio, Rider, etc.).

    Compile et exécute Program.cs.

    Suis les instructions du menu pour créer tes combattants, affronter des monstres, et lancer des duels ou un tournoi.

🤓 Pour les Curieux

Ce projet est une excellente base pour apprendre et pratiquer :

    L’héritage, le polymorphisme, et les interfaces en C#.

    La manipulation des fichiers JSON.

    La conception d’un système de jeu tour par tour.

    La structuration et l’interactivité dans une application console.

Prêt à forger ta légende ? Que la bataille commence ! ⚔️