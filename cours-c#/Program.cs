
using cours_c_;

Console.WriteLine("Hello, World!");
Console.WriteLine("Salut maxime");
Console.WriteLine("hello evryone");


int age = 21 ;
bool verite = false;
string nom = "DEFALEOUNA";

Console.WriteLine(age);
Console.WriteLine(verite);
Console.WriteLine(nom);

var variable = 5.9 ;
Console.WriteLine(variable);

const int superfice_togo = 56600 ;
Console.WriteLine("la superficie du Togo est de : " + superfice_togo + " Km²");


//les chaines de caractere en csharp

string str = "jfjflllls";
Console.WriteLine(str[3]);


                // interpolation 

string texte ;
if (verite)
{
    texte = $"Salut moi c'est {nom} , j'ai {age} ans et je dis la verité";
}
else
{
    texte = $"Salut moi c'est {nom} , j'ai {age}ans et je dis pas la verité";
    
}
Console.WriteLine(texte);


                // concatenation

System.Console.WriteLine("Saisisez votre prenom svp : ");
string prenom = Console.ReadLine(); // on essais d'affecter un nullable a un string qui est non nullable , d'ou le warning
// string? prenoms = Console.ReadLine(); //bonne maniere
System.Console.WriteLine("Bonjour " + prenom); // concatenation

                // les methodes sur les chaines

string pays = "toGo";
Console.WriteLine(pays.Length);

string TOGO = pays.ToUpper();
Console.WriteLine(TOGO);
string togo = pays.ToLower();
Console.WriteLine(togo);

Console.WriteLine(pays.Contains('G'));
 

// les caracteres en csharp

char car = 'A';      // un caractère
string s = "A";    // une chaîne
Console.WriteLine(car + s);
char lettre = 'B';

Console.WriteLine(lettre);
Console.WriteLine(sizeof(char)); // =2 ca dire un char fait 16bytes ou 2 octets
Console.WriteLine((int)lettre); // code unicode asci de  B 


// Les tableau en csharp

int[] nums = new int[5]; // on declarre un tableau d'entier de taille 5 valeure par defaut 0 a chaque indice
int[] numbers = { 10, 20, 30, 40 }; // initialisation directe


Console.WriteLine(numbers); // affiche la reference
Console.WriteLine(numbers[0]); // 10
Console.WriteLine(numbers[1]); // 20
Console.WriteLine(nums[4]); // 0

// Les listes e csharp

List<string> countries = new List<string>
{
    "Togo",
    "Ghana",
    "Benin"
}; // liste avec valeure directes

bool existe = countries.Contains("Togo");
Console.WriteLine(existe);

countries.Insert(1, "Nigeria");

foreach (string country in countries)
{
    Console.WriteLine(country);
}


List<int> nombres = new List<int>();


nombres.Add(10);
nombres.Add(20);
nombres.Add(30);

Console.WriteLine(nombres); // la reference
Console.WriteLine(nombres[0]); // 10
Console.WriteLine(nombres[1]); // 20

Console.WriteLine(nombres.Count); // Taille de la liste

nombres[1] = 100; //modifier
nombres.Remove(10); // supprime la valeur 10
nombres.RemoveAt(0); // supprime le premier élément , suppression par index
    // parcours de la liste avec foreach 
foreach (int n in nombres)
{
    Console.WriteLine(n);
}

    // parcour de la liste avec for
for (int i = 0; i < nombres.Count; i++)
{
    Console.WriteLine(nombres[i]);
}


// les dictionnaires en csharp

Dictionary<string, string> capitales = new Dictionary<string, string>();
capitales.Add("Togo", "Lomé");
capitales.Add("Ghana", "Accra");
capitales.Add("Benin", "Porto-Novo");

Console.WriteLine(capitales["Togo"]); // acceder a une valeure

if (capitales.ContainsKey("Ghana"))
{
    Console.WriteLine("Existe !");
} //  verfier si cette clé existe

foreach (var item in capitales)
{
    Console.WriteLine(item.Key + " -> " + item.Value);
} // on accede au clé valeures

capitales.Remove("Benin"); // supprimer un element


// le try et catch gestion des erreurs 
try
{
    int[] t = { 1, 2, 3 };
    Console.WriteLine(t[5]); // erreur
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Toujours executer avec les try et catch si on veut ");
}

var p = new Person
{
    Nom = "15"
};
Console.WriteLine(p.Nom);
p.Marcher();





 