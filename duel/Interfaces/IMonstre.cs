namespace duel.Interfaces;

public interface IMonstre
{
    string GetNom();
    int GetPV();
    int Attaquer();
    int DonnerExperience();
    void SubirDegats(int degats);
    bool EstVivant();
}