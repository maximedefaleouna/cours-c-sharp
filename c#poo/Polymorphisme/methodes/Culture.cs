using System;

namespace c_poo.Polymorphisme.methodes;

public class Culture
{

 public string Nom { get; set; }

 public virtual void Croitre()
    {
       Console.WriteLine($" Culture pousse."); 
    }
}

public class Ble : Culture
{
    public override void Croitre()
    {
        Console.WriteLine($"{Nom} (ble) pousse dans les champs sec .");
    }

    public void InfoBle()
    {
        Console.WriteLine($"Info ble");
    }
}

public class Mais : Culture
{
    public override void Croitre()
    {
        Console.WriteLine($"{Nom} (maïs) pousse avec beaucoup d’eau et de soleil.");
    }
}

public class Riz : Culture
{
    public override void Croitre()
    {
        Console.WriteLine($"{Nom} (riz) pousse dans les rizières inondées.");
    }
}