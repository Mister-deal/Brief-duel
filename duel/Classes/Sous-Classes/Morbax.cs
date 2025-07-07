namespace duel.Classes.Sous_Classes;
public class Morbax : Monstre
    {
        private string titre;
        public Morbax(string nom, string titre, int pointsDeVie, int nbDesAttaque, int experience)
            : base(nom, pointsDeVie, nbDesAttaque, experience)
        {
            this.titre = titre;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($" l’Ombre Putréfiée {Nom} surgit des ténèbres, réanimé par des rituels interdits !");
            Console.ResetColor();
        }
    }
