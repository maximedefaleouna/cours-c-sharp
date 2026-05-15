using System;

namespace c_poo.Abstraction;

public abstract class Forme
{

    public string Nom { get; set; }

    public abstract double CalculerSurface();

    public void AfficherNom()
    {
        Console.WriteLine($"Nom de la forme : {Nom}");
    }
}

public class Cercle : Forme
{
    public double Rayon { get; set; }

    public override double CalculerSurface()
    {
        return Math.PI * Rayon * Rayon;
    }
}

public class Rectangle : Forme
{
    public double Largeur { get; set; }
    public double Hauteur { get; set; }

    public override double CalculerSurface()
    {
        return Largeur * Hauteur;
    }
}