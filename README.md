🛡️ Duels de Guerriers

Un projet en C# pour s’amuser avec de la programmation orientée objet, des combats tactiques tour par tour, et une interface console immersive.
Crée tes guerriers, fais-les s’affronter en duels ou en tournois, et découvre qui sera le dernier champion debout dans cette lutte ancestrale entre Nains, Elfes, Guerriers et Sorciers !
🌍 Contexte & Lore

Dans les terres oubliées des Hautes Terres, les rivalités entre races millénaires n'ont jamais cessé.
Les Nains, maîtres des montagnes et forgerons légendaires, s'opposent farouchement aux Elfes, êtres gracieux et maîtres de la magie naturelle.
Les Guerriers humains, valeureux et aguerris, luttent pour honorer leurs terres, tandis que les mystérieux Sorcier·ère·s, gardiens des arcanes, manipulent les forces occultes pour renverser le cours du combat.

À travers ce tournoi, c’est la suprématie qui sera décidée, et la gloire immortalisée dans les chants des bardes.
🎮 Principe du Jeu

Le joueur crée une équipe de combattants issus de différentes classes, chacune avec ses spécificités et son style de combat, puis les fait s’affronter dans des duels ou un grand tournoi.
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

    Elfe : agile, avec une attaque toujours assurée d'un minimum de dégâts.

    Ces classes héritent de Guerrier et redéfinissent certains comportements pour plus de stratégie.

🧙 Partie III — Les Sorciers

    Introduction de la classe Sorcier, maîtres de la magie.

    Disposent de mana et de sorts variés :

        Boule de Feu : attaque puissante infligeant des dégâts magiques.

        Soin : restaure les points de vie d’un allié ou de soi-même.

        Bouclier Magique : réduit les dégâts subis pendant plusieurs tours.

    Les effets magiques apportent une couche tactique supplémentaire en combat.

🏆 Partie IV — Duel et Tournoi

    Menu console interactif pour :

        Créer, afficher et supprimer des combattants.

        Lancer des duels automatiques ou un tournoi complet.

        Gérer une liste globale de tous les combattants.

💾 Partie V — Interface + Sauvegarde JSON

    Interface améliorée avec menus chiffrés clairs (options 1 à 6).

    Implémentation d’une interface ICombattant pour uniformiser les comportements.

    Historique des combats, classement des victoires.

    Sauvegarde et chargement des combattants via un fichier JSON (guerriers.json).

    Ambiance console enrichie par l’usage des couleurs.

🚀 Lancer le Projet

    Ouvre le projet dans ton IDE préféré (Visual Studio, Rider, etc.).

    Compile et exécute Program.cs.

    Suis les instructions du menu pour créer tes combattants et lancer des duels ou un tournoi.

🤓 Pour les Curieux

Ce projet est une excellente base pour apprendre et pratiquer :

    L’héritage, le polymorphisme, et les interfaces en C#.

    La manipulation des fichiers JSON.

    La conception d’un système de jeu tour par tour.

    La structuration et l’interactivité dans une application console.

Prêt à forger ta légende ? Que la bataille commence ! ⚔️