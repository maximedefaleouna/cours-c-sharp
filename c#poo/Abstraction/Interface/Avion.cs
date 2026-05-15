using System;

namespace c_poo.Abstraction.Interface;

public class Avion : IVolant
{
     public void Voler()
    {
        Console.WriteLine("L'avion décolle et vole.");
    }

    public void Atterrir()
    {
        Console.WriteLine("L'avion atterrit sur la piste.");
    }

    public void Avancer()
    {
        Console.WriteLine("L'avion avance sur la piste.");
    }
}

public class Oiseau : IVolant
{
    public void Voler()
    {
        Console.WriteLine("L'oiseau bat des ailes et vole.");
    }

    public void Atterrir()
    {
        Console.WriteLine("L'oiseau se pose doucement.");
    }

    public void theOiseau()
    {
        Console.WriteLine("L'oiseau bat des ailes et vole.");
    }

    
}

public class Canard : Oiseau , IVolant , INageant 
{

     public void Voler()
    {
        Console.WriteLine("Le canard vole.");
    }

    public void Nager()
    {
        Console.WriteLine("Le canard nage.");
    }
    public void Atterrir()
    {
        Console.WriteLine("Le canard se pose doucement.");
    }
   
}