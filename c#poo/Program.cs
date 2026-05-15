using c_poo;
using c_poo.Abstraction;
using c_poo.Abstraction.Interface;
using c_poo.Encapsulation;
using c_poo.Heritage;
using c_poo.Polymorphisme.methodes;
using c_poo.Polymorphisme.Surcharge;

class Program
{
    static void Main()
    {
        Voiture voiture = new();
        Console.WriteLine("merci");
        voiture.Marque = "Toyota";
        voiture.Couleur = "Cendre";
        voiture.Demarrer();


        var car = new Voiture();
        car.Marque = "Audi";
        car.Couleur = "Blue";
        car.Demarrer();


        Voiture vehicule = new()
        {
            Marque = "Mazda",
            Couleur = "Orange"

        } ;
        vehicule.Demarrer();


        var caisse = new Voiture()
        {
            Marque = "Bugati",
            Couleur = "Rouge",
        };
        caisse.Demarrer();


        // Encapsulation

        var compte = new CompteBancaire("DEFALEOUNA", 0);
        compte.Deposer(1000);
        Console.WriteLine(compte.Solde); // via le getteur
        // Console.WriteLine(compte.solde); impossible attribue private
        // compte.Solde = 2000;  impossible de modifier un attribut dont le set n'est pas definit
        // compte.DateCreation = "2026"; // impossible readOnly
        // compte.NumeroDeCompte = "1234";  impossible de modifier un attribut dont le set est private
        Console.WriteLine($"Compte creer en {compte.DateCreation}");
        compte.Proprietaire = "DEFALEOUNA Maxime";
        Console.WriteLine($"Compte creer par {compte.Proprietaire}");
        // compte.NumeroDeCompte = "1234"; // impossible de modifier un attribut dont le set est private
        Console.WriteLine($"Numero de compte {compte.NumeroDeCompte}");
        compte.Agent = $"Mr {compte.Agent}";
        Console.WriteLine($"Compte creer par {compte.Agent}");

        Console.WriteLine($"Opération effectué sur le {CompteBancaire.NombreDeComptes}em compte de la banque");

        CompteBancaire account = new("DEFALEOUNA Maxime", 0);
        Console.WriteLine($"Compte creer en {account.DateCreation}");
        Console.WriteLine($"Compte creer par {account.Proprietaire}");
        Console.WriteLine($"Opération effectué sur le {CompteBancaire.NombreDeComptes}em compte de la banque");






        ///////////////// Héritage /////////////////

        Chien chien = new()
        {
            Nom = "Rex",
            Age = 3,
            Race = "Labrador"
        };
       
        chien.Aboyer();
        chien.Manger();
        chien.Info();

        Fer fer = new("Fer", "Metal utilisé pour fabriquer des armes et des armures");
        fer.Info();
        fer.FaireDuBruit();

        Metal metal = new Fer("Fer", "Metal utilisé pour fabriquer des armes et des armures");     
        metal.FaireDuBruit(); // methode hiding
        metal.Rouiller();    // polymorphisme
        // metal.Ferrer(); impossible d'acceder a la methode Ferrer car metal est de type Metal meme si Ferrer est defint dans fer






       /////////////////////////// Polymorphisme /////////////////////////////
     
       var calc = new Calculatrice();
       Console.WriteLine(calc.Additionner(1, 2));
       Console.WriteLine(calc.Additionner(1.0, 2.0));
       Console.WriteLine(calc.Additionner(1.0, 2));


    Culture c1 = new Ble { Nom = "Blé dur" };
    Culture c2 = new Mais { Nom = "Maïs jaune" };
    Culture c3 = new Riz { Nom = "Riz blanc" };

      c1.Croitre();
    //   c1.InfoBle(); lui il n'a pas acces a InfoBle()
      c2.Croitre();
      c3.Croitre();

    Ble ble = new();
    ble.InfoBle();









    ////////// Abastraction ////////////////
    
    Forme f1 = new Cercle { Nom = "Cercle1", Rayon = 3 };
    Forme f2 = new Rectangle { Nom = "Rect1", Largeur = 4, Hauteur = 5 };

    Console.WriteLine(f1.CalculerSurface()); // 28.27
    Console.WriteLine(f2.CalculerSurface()); // 20


    // Utilisation polymorphe
   IVolant v1 = new Avion();
   IVolant v2 = new Oiseau();

   v1.Voler(); // L'avion décolle et vole.
   v2.Voler(); // L'oiseau bat des ailes et vole.

    Avion avion = new();
    avion.Avancer();

    Canard d = new Canard();
    d.Voler();
    d.Nager();
    d.theOiseau();

    }
}


