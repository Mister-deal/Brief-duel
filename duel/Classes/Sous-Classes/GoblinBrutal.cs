﻿namespace duel.Classes.Sous_Classes;

public class GoblinBrutal: Monstre
{
    protected bool _armure;
    protected int _niveau = 5;
    public GoblinBrutal( bool armure) : base("GoblinBrutal", 40,  2, 15)
    {
        _niveau = niveau;
        _armure = armure;
    }
    

    public override void SubirDegats(int degats)
    {
        if (_armure != false)
        {
            degats /= 2;
        }
        base.SubirDegats(degats);
    }
}