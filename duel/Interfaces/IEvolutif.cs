namespace duel.Interfaces;

public interface IEvolutif
{
    void GagnerExperience(int points);
    int GetNiveau();
    int GetExperience();
    int GetExperienceMax();
    void MonterNiveau();
}