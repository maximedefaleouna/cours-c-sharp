using System;

namespace c_poo.Encapsulation;

public class CompteBancaire
{

    private decimal solde ;
    public decimal Solde { get { return solde; } }
    private string? proprietaire;
    public string Proprietaire { get
        {
            return $"Mr ou Mme {proprietaire}";
        } 
        set { proprietaire = value; } }


    public string NumeroDeCompte { get; private set; } = $"CB-000001{NbComptes + 1}";
    public readonly DateTime DateCreation  = DateTime.Now; 

    private static int NbComptes ;// valeure par default 0
    public static int NombreDeComptes { get { return NbComptes; } }

    public string Agent { get;  set; } = "Achraf";

    public CompteBancaire(string proprietaire , decimal solde)
    {
        this.proprietaire = proprietaire;
        this.solde = solde;
        NbComptes++;
        

        Console.WriteLine("compte creer pour " + proprietaire + " avec un solde de " + solde + " euros" +" le  " + DateCreation +  " le numero de compte est " + NumeroDeCompte);
        
    }

   

    public void Deposer(decimal montant)
    {
        solde += montant;

    }

    public decimal ObtenirSolde()
    {
        return solde;
    }

}
