﻿namespace duel.Interfaces;

public interface Icombattant
{
    string GetNom();
    int GetPointsDeVie();
    void SetPointDeVie(int pointDeVie);
    int GetNbDesAttaques();
    void Reset();
    int Attaquer();
    void SubirDegats(int degats);
    void AfficherInfos();
    
}