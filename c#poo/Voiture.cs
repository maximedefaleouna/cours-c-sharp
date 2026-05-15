using System;

namespace c_poo;

public class Voiture
{

    public string? Marque ;
    public string? Couleur;


    public void Demarrer()
    {
        Console.WriteLine($"{Marque} {this.Couleur} demarre !");
    }

}
