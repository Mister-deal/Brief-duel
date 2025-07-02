// See https://aka.ms/new-console-template for more information

using duel.Classes;

Guerrier lancelot = new Guerrier("Lancelot", 35, 3);
Guerrier galahad = new Guerrier("galahad", 30, 4);
Elfe legolas = new Elfe("legolas", 25, 5, 5);
Nain gimli = new Nain("gimli", 38, 3, true);

while (lancelot.GetPointsDeVie() > 0 || galahad.GetPointsDeVie() > 0)
{
    galahad.SubirDegats(lancelot.Attaquer());
    galahad.AfficherInfos();

    lancelot.SubirDegats(galahad.Attaquer());
    lancelot.AfficherInfos();
    if (galahad.GetPointsDeVie() == 0 && legolas.GetPointsDeVie() == 0)
    {
        Console.Write($"{galahad.GetPointsDeVie()}");
        Console.Write($"{legolas.GetPointsDeVie()}");
        break;
    }
}
/*
lancelot.AfficherInfos();
galahad.AfficherInfos();

galahad.SubirDegats(lancelot.Attaquer());
galahad.AfficherInfos();

lancelot.SubirDegats(galahad.Attaquer());
lancelot.AfficherInfos();

galahad.SubirDegats(lancelot.Attaquer());
galahad.AfficherInfos();

lancelot.SubirDegats(galahad.Attaquer());
lancelot.AfficherInfos();

galahad.SubirDegats(lancelot.Attaquer());
galahad.AfficherInfos();

lancelot.SubirDegats(galahad.Attaquer());
lancelot.AfficherInfos();

*/

