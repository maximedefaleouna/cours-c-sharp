using System;

namespace c_poo.Heritage;

public class Metal
{
    public string Nom {get; set;}
    public Metal(string nom)
    {
        this.Nom = nom;
    }

    public void FaireDuBruit()
    {
        Console.WriteLine($"Le Metal fait du bruit");
    }

    public virtual  void  Rouiller()
    {
        Console.WriteLine($"Le Metal se rouille");
    }

}

public class Fer : Metal
{
    public string description {get; set;}
    public Fer(string nom , string description) : base(nom)
    {
        this.description = description;
    }


    public void Info()
    {
        Console.WriteLine($" INFO : Nom - {this.Nom} , Description - {this.description}");
    }

    public new void FaireDuBruit() // methode hidding
    {
        Console.WriteLine($"Le Fer fait du bruit");
    }

    public override void Rouiller()
    {
        Console.WriteLine($"Le Fer se rouille");
    }

    public void Ferrer()
    {
        Console.WriteLine($"Le Fer ferre");
    }
}
