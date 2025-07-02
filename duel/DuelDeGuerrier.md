## **DUELS DE GUERRIERS : PART I**

### **1. Création de la Classe Guerrier**
- **Objectif :** Créer une classe `Guerrier` qui servira de base pour notre duel.
- **Nom du fichier :** `Guerrier.cs`
- **Étapes détaillées :**
  1. **Définir les propriétés nécessaires :**
     - **Attributs :**
       - `private string nom` : Le nom du guerrier.
       - `private int pointsDeVie` : Les points de vie (PV) du guerrier.
       - `private int nbDesAttaque` : Le nombre de dés d’attaque.
  2. **Créer un constructeur :**
     - Nom : `Guerrier(string nom, int pointsDeVie, int nbDesAttaque)`
     - Fonction : Initialiser les attributs.
  3. **Ajouter des getters et setters :**
     - Méthodes publiques :
       - `public string GetNom()`
       - `public int GetPointsDeVie()`
       - `public void SetPointsDeVie(int pointsDeVie)`
       - `public int GetNbDesAttaque()`

---

### **2. Ajout des Méthodes Essentielles**
- **Objectif :** Ajouter les actions que le guerrier peut effectuer.
- **Nom des méthodes :**
  1. `public void AfficherInfos()` :
     - **But :** Afficher dans la console les informations du guerrier au format `Nom{PV=xx}`.
  2. `public int Attaquer()` :
     - **But :** Simuler une attaque en lançant des dés (valeurs aléatoires entre 1 et 6 pour chaque dé).
  3. `public void SubirDegats(int degats)` :
     - **But :** Réduire les points de vie du guerrier lorsque des dégâts sont reçus.
- **Sous-étapes :**
  1. Écrire chaque méthode dans `Guerrier.cs`.
  2. Tester chaque méthode indépendamment (par exemple, afficher les PV après avoir subi des dégâts).

---

### **3. Test de la Classe Guerrier**
- **Objectif :** Tester les fonctionnalités de la classe `Guerrier`.
- **Nom du fichier :** `Program.cs`
- **Sous-étapes :**
  1. Créer deux guerriers dans la méthode `Main` :
     - Exemple : `Guerrier lancelot = new Guerrier("Lancelot", 35, 3);`
     - Exemple : `Guerrier galahad = new Guerrier("Galahad", 30, 4);`
  2. Faire attaquer les guerriers à tour de rôle.
     - Appeler `Attaquer()` pour infliger des dégâts.
     - Appeler `SubirDegats(int degats)` pour appliquer les dégâts.
  3. Afficher l’état des guerriers après chaque attaque avec `AfficherInfos()`.

---

## **DUELS DE GUERRIERS : PART II**

### **1. Ajout de Classes Spécialisées**
- **Objectif :** Ajouter des variantes de guerriers avec des capacités uniques en utilisant la notion d'heritage.
- **Fichiers à créer :** 
  - `Nain.cs` pour la classe `Nain`
  - `Elfe.cs` pour la classe `Elfe`
- **Étapes détaillées :**
  1. **Créer la classe `Nain` :**
     - Hérite de : `Guerrier`
     - **Attribut spécifique :**
       - `private bool armureLourde` : Détermine si le Nain porte une armure lourde.
     - **Méthode spécifique :**
       - Redéfinir `SubirDegats(int degats)` :
         - Si `armureLourde` est activée, les dégâts sont divisés par 2.
  2. **Créer la classe `Elfe` :**
     - Hérite de : `Guerrier`
     - **Méthode spécifique :**
       - Redéfinir `Attaquer()` :
         - Toujours infliger au moins un minimum de dégâts (par exemple, le nombre de dés d'attaque).

---

### **2. Test des Classes Nain et Elfe**
- **Objectif :** Tester les spécificités des classes spécialisées.
- **Nom du fichier :** `Program.cs`
- **Sous-étapes :**
  1. Créer un Nain et un Elfe dans `Main` :
     - Exemple : `Nain gimli = new Nain("Gimli", 40, 2, true);`
     - Exemple : `Elfe legolas = new Elfe("Legolas", 25, 5);`
  2. Simuler un duel entre le Nain et l’Elfe.
     - Tester les règles spécifiques :
       - L’armure lourde du Nain réduit les dégâts.
       - L’Elfe inflige toujours des dégâts minimums.

---


## **DUELS DE GUERRIERS : PART III**

### **Objectifs**
1. Créer des guerriers depuis un menu.
2. Afficher la liste des guerriers.
3. Lancer un tournoi entre les guerriers.

---

### **Fichier : Program.cs**

#### **Étape 1 : Afficher le Menu Principal**
- Méthode : `AfficherMenuPrincipal()`
- Objectif : Afficher un menu avec des options et exécuter l’action correspondante.

---

#### **Étape 2 : Ajouter un Guerrier**
- Méthode : `AjouterGuerrier()`
- Objectif : Permettre la création de guerriers personnalisés.

---

#### **Étape 3 : Afficher la Liste des Guerriers**
- Méthode : `AfficherListeGuerriers()`
- Objectif : Afficher les informations de tous les guerriers créés.

---

#### **Étape 4 : Lancer un Tournoi**
- Méthode : `LancerTournoi()`
- Objectif : Faire combattre les guerriers jusqu’à ce qu’il en reste un.

---

### **Nouvel Attribut : Liste Globale**
- Ajouter cette liste globale pour stocker les guerriers créés :

---


## **DUELS DE GUERRIERS : PARTIE IV**

### **Objectifs**

* Créer une interface console interactive avec menu.
* Permettre création et suppression de guerriers avec validation.
* Ajouter une classe **Sorcier** avec mécaniques de sorts et mana.
* Fournir un guide utilisateur clair.

---

### 1. **Interface Utilisateur**

**Fichier** : `Program.cs`

* **Méthode** : `AfficherMenuPrincipal()`
* **Options du menu** (1–6) :

  1. Créer un guerrier
  2. Supprimer un guerrier
  3. Afficher la liste
  4. Lancer un tournoi
  5. Afficher l’historique
  6. Quitter
* **Sous‑étapes** :

  * Afficher le menu.
  * Lire le choix avec `LireChoixUtilisateur(min, max)` pour gérer les erreurs non numériques.

---

### 2. **Création & Suppression de Guerriers**

**Fichier** : `Program.cs`

#### 2.1 `AjouterGuerrier()`

* **Sous‑menu** pour choisir le type :`Guerrier`, `Nain`, `Elfe`, ou `Sorcier`.
* **Saisies** à demander et valider (`LireNomValide()`, `LireEntierValide()`):

  * nom (non vide, alphanumérique)
  * PV (10–100)
  * dés d’attaque (1–10)
  * paramètres spécifiques :

    * `armureLourde` (booleen) pour Nain
    * `mana` (10–100) pour Sorcier

#### 2.2 `SupprimerGuerrier()`

* Afficher la liste numérotée des guerriers.
* Lire un numéro valide (`LireChoixUtilisateur()`).
* Supprimer et afficher confirmation ou erreur.

---

### 3. **Classe Sorcier**

**Fichier** : `Sorcier.cs`

* **Attributs** :

  * `private int mana` (initialisé à 50, max 100)
  * `private List<string> sorts` = { `"Boule de Feu"`, `"Soin"`, `"Bouclier Magique"` }


* **Méthodes redéfinies** :

  * `Attaquer()` :

    * Si `mana >= 10`, choisir un sort aléatoire :

      * `"Boule de Feu"` : +10 dégâts
      * `"Soin"` : +5 PV
      * `"Bouclier Magique"` : active un bouclier
    * Consomme 10 mana
  * `SubirDegats(int degats)` :

    * Applique la réduction de 50 % si bouclier actif, puis désactive le bouclier.
  * `RegenererMana(int montant)` : ajoute du mana (ex. +5 par tour, sans dépasser 100).
  * `AfficherInfos()` : affiche nom, PV, mana.

---

### 4. **Guide Utilisateur**

**Fichier** : `Program.cs`
**Méthode** : `AfficherGuideUtilisateur()`

* Afficher un message d’accueil avec :

  * Explication des options du menu.
  * Présentation des types de guerriers et spécificités (ex. armure lourde, sorts).
  * Règles de saisie (PV 10–100, etc.).
* Afficher des messages contextuels après chaque action (création, suppression…).

---

## **DUELS DE GUERRIERS : PARTIE V**

### **Objectifs**

* Introduire une interface `ICombattant`.
* Améliorer le tournoi avec classement et historique.
* Ajouter sauvegarde/chargement JSON des guerriers.
* Enrichir l’expérience utilisateur.

---

### 1. **Interface `ICombattant`**

**Fichier** : `ICombattant.cs`

* **Méthodes** :

  * `GetNom()`, `GetPointsDeVie()`, `SetPointsDeVie(int)`
  * `Attaquer()`, `SubirDegats(int)`, `AfficherInfos()`
* Implémentée par : `Guerrier`, `Nain`, `Elfe`, `Sorcier`.
* Utiliser `List<ICombattant>` dans `Program.cs`.

---

### 2. **Tournoi Avancé**

**Fichier** : `Program.cs`
**Méthode** : `LancerTournoi()`

* **Améliorations** :

  * Chaque guerrier possède un attribut `victoires` (int).
  * Après le tournoi, afficher le classement (`AfficherClassement()`), trié par victoires décroissantes.
* **Historique** :

  * Stocker chaque combat dans `List<string> historiqueCombats`.
  * Option du menu : `AfficherHistorique()`.

---

### 3. **Sauvegarde & Chargement**

**Fichier** : `Program.cs`

* **Méthodes** :

  * `SauvegarderGuerriers()` : écriture JSON (`guerriers.json`) avec : type, nom, PV, dés, armure, mana...
  * `ChargerGuerriers()` : lecture JSON, recréation des objets selon leur type.

---

### 4. **Expérience Utilisateur**

* **Validation** : contrôler toutes les saisies.
* **Messages** : confirmations et erreurs claires.
* **Ambiance console** : utiliser `Console.ForegroundColor` pour colorer les textes.
* **Bonus créatifs (facultatif)** :

  * Mode multijoueur : deux utilisateurs contrôlent chacun un guerrier.
  * Système d’expérience : augmenter les stats après chaque victoire.

---
