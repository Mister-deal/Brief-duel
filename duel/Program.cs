// See https://aka.ms/new-console-template for more information

using duel.Classes;

Guerrier lancelot = new Guerrier("Lancelot", 35, 3);
Guerrier galahad = new Guerrier("galahad", 30, 4);


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



