using System;

namespace c_poo.Composition;

public class Voituree
{

    private Moteur _moteur;

    public Voituree()
    {
        this._moteur = new Moteur();
    }


    public void Demarrer()
    {
        _moteur.Demarrer();
        Console.WriteLine("La voiture demarre");
    }

}
