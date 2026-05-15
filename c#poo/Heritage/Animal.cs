using System;

namespace c_poo.Heritage;

public class Animal
{

    public string Nom { get; set; }
    public int Age { get; set; }

    public void Manger()
    {
        Console.WriteLine($" {this.Nom} mange");
    }

}


public class Chien : Animal
{
    public string Race { get; set; }
    public void Aboyer()
    {
        Console.WriteLine($" {this.Nom} aboie");
    }

    public void Info()
    {
        Console.WriteLine($"Nom : {this.Nom} Age : {this.Age} Race : {this.Race}");
    }

    
}
