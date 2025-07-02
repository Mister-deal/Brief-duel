🛡️ Duels de Guerriers

Un petit projet en C# pour s’amuser avec de la POO, des combats tour par tour et une interface console. On y crée des guerriers, on les fait se battre, et on peut même lancer un tournoi jusqu’à ce qu’il n’en reste qu’un !
🎮 Principe du Jeu

Le joueur crée une équipe de combattants issus de différentes classes (Guerrier, Nain, Elfe, Sorcier), puis les fait s’affronter dans des duels ou tournois. Chaque type a ses spécificités : armure lourde, sorts magiques, ou attaques garanties. Le jeu se joue entièrement dans le terminal.
🔧 Fonctionnalités par Partie
✅ Partie I — Base : la classe Guerrier

    Création d'une classe Guerrier avec nom, points de vie (PV), et dés d'attaque.

    Méthodes disponibles :

        Attaquer() : lance les dés pour infliger des dégâts.

        SubirDegats(int) : réduit les PV du guerrier.

        AfficherInfos() : affiche les infos du guerrier.

🧝 Partie II — Héritage : Nain et Elfe

    Nain : possède une armure lourde qui réduit les dégâts subis.

    Elfe : attaque toujours avec un minimum garanti.

    Ces classes héritent de Guerrier et redéfinissent certains comportements.

🏆 Partie III — Duel et Tournoi

    Menu console pour :

        Créer et afficher des guerriers.

        Lancer des duels automatiques entre eux.

        Gérer une liste globale de tous les personnages créés.

🧙 Partie IV — Interface interactive + Sorcier

    Interface plus propre avec menu chiffré (1 à 6).

    Ajout du Sorcier :

        Dispose de mana et de sorts : Boule de Feu, Soin, Bouclier Magique.

        Gère les effets en combat (soin, réduction des dégâts…).

    Ajout de la suppression de guerriers.

    Guide utilisateur intégré.

💾 Partie V — Interface + Sauvegarde JSON

    Création de l’interface ICombattant pour uniformiser les classes.

    Historique des combats et classement des victoires.

    Sauvegarde / chargement des guerriers depuis un fichier JSON (guerriers.json).

    Amélioration de l’ambiance console avec couleurs.

    (Bonus possible : XP, multijoueur, progression…)


🚀 Lancer le Projet

    Ouvre le projet dans ton IDE (type Visual Studio, Rider...).

    Compile et exécute Program.cs.

    Suis les instructions dans le menu pour créer des guerriers et lancer des duels.

🤓 Pour les curieux

Ce projet peut servir de base pour :

    Apprendre l'héritage, le polymorphisme et les interfaces en C#.

    Manipuler des fichiers JSON.

    Créer un système de jeu tour par tour.

    Travailler la structuration et l’interactivité d’une appli console.
