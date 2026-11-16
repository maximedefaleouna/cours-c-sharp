# Guide Complet C# et Programmation Orientee Objet (.NET)

Formation pratique et progressive dediee a l'apprentissage du langage C# et des principes architecturaux de la Programmation Orientee Objet (POO) sous l'ecosysteme .NET.

Ce repertoire regroupe deux projets autonomes concus pour accompagner les developpeurs depuis les fondamentaux de la syntaxe jusqu'aux concepts avances de conception logicielle.

## Structure du Repertoire

Le depot est organise en deux sous-projets complementaires :

- `cours-c#` : Syntaxe de base, typage, chaines, collections generiques et gestion des erreurs.
- `c#poo` : Piliers de la POO (Encapsulation, Heritage, Polymorphisme, Abstraction et Composition).

## Module 1 : Fondamentaux du Langage C# (cours-c#)

Ce premier module pose les bases indispensables a la maitrise de C# et des fonctionnalites cles du runtime .NET :

### 1. Typage et Declarations
- Types primitifs a typage fort : entiers (`int`), booleens (`bool`), chaines (`string`), caracteres (`char`).
- Insequence de type locale avec le mot-cle `var`.
- Constantes immutables avec `const` (exemple : calcul et affichage de la superficie du Togo).

### 2. Securite des References Nullables
- Prise en charge des types nullables avec l'operateur `string?` pour prevenir les erreurs de reference nulle (`NullReferenceException`) lors de la saisie utilisateur via `Console.ReadLine()`.

### 3. Manipulation Avancee des Chaines de Caracteres
- Interpolation moderne avec `$"{nom} a {age} ans"` offrant lisibilite et performance.
- Concatenation classique via l'operateur `+`.
- Indexation positionnelle des caracteres (`str[i]`).
- Methodes de manipulation courantes : `ToUpper()`, `ToLower()`, `Contains()` et calcul de longueur avec `Length`.

### 4. Caracteres et Gestion Memoire
- Distinction entre type caractere (`char`) et chaine (`string`).
- Exploration de l'empreinte memoire avec `sizeof(char)` (2 octets / 16 bits en encodage Unicode UTF-16).
- Transtypage explicite vers le code numerique ASCII / Unicode : `(int)lettre`.

### 5. Collections et Tableaux
- Tableaux a dimension fixe : declaration, allocation (`int[] nums = new int[5]`) et initialisation directe (`int[] numbers = { 10, 20, 30, 40 }`).
- Listes dynamiques generiques (`List<T>`) :
  - Ajout (`Add`) et insertion a un index donne (`Insert`).
  - Suppression par valeur (`Remove`) ou par index (`RemoveAt`).
  - Consultation de la taille via la propriete `Count`.
  - Iterations comparatives avec boucle d'indexation `for` et boucle de parcours `foreach`.
- Dictionnaires associatifs (`Dictionary<TKey, TValue>`) :
  - Stockage sous forme de paires cle-valeur (exemple des pays et de leurs capitales : Togo -> Lome, Ghana -> Accra).
  - Verification d'existence prealable avec `ContainsKey()`.
  - Iteration structuree sur les paires `KeyValuePair`.

### 6. Gestion Structurée des Exceptions
- Encadrement securise des blocs de code a risque avec `try`, `catch (Exception ex)` et `finally`.
- Garantie de l'execution du bloc de nettoyage `finally` quel que soit le deroulement.

### 7. Introduction a l'Instanciation d'Objets
- Creation d'une premiere classe `Person` integrant des proprietes auto-implementees et des methodes simples (`Marcher()`).

## Module 2 : Programmation Orientee Objet Avancee (c#poo)

Ce second module traite en profondeur de la conception logicielle et des paradigmes de la POO :

### 1. Classes, Objets et Syntaxe Moderne
- Distinction fondamentale entre classe (moule ou plan abstrait) et objet (instance concrete independante).
- Utilisation des constructeurs cibles modernes de C# (`new()`).
- Initialiseurs d'objets pour declarer et affecter les proprietes de maniere concise :
  `var voiture = new Voiture { Marque = "Audi", Couleur = "Bleu" };`

### 2. Encapsulation et Modificateurs d'Acces (package Encapsulation)
- Protection de l'etat interne de l'objet via la classe `CompteBancaire`.
- Modificateurs de visibilite C# :
  - `public` : accessible sans restriction.
  - `private` : strictement confine a la classe declarante.
  - `protected` : accessible dans la classe et ses classes derivees.
  - `internal` : reserve aux classes du meme projet / assembly.
  - `protected internal` : combinaison accessible dans l'assembly ou les classes derivees.
- Proprietes C# avancees :
  - Lecture seule avec accesseur `get` pur (`DateCreation`).
  - Mutateur a visibilite restreinte (`public string NumeroDeCompte { get; private set; }`).
- Validation metier : les methodes `Deposer(montant)` et `Retirer(montant)` verifient la validite des montants avant toute alteration du solde.

### 3. Heritage et Relations Hierarchiques (package Heritage)
- Modelisation de relations "est-un" via la classe parente `Animal` et sa descendante `Chien`.
- Transmission des champs proteges (`protected`) et appel explicite du constructeur de la classe de base grace au mot-cle `base(nom)`.
- Reutilisation du code et elimination des redondances.
- Masquage de methodes avec le mot-cle `new` (method hiding dans la classe `Metal` et `Fer`) par opposition a la redefinition polymorphique.

### 4. Polymorphisme Statique et Dynamique (package Polymorphisme)
- Polymorphisme statique (Surcharge / Overloading) :
  - Resolu a la compilation.
  - Classe `Calculatrice` implementant plusieurs variantes de `Additionner` recevant des entiers, des nombres a virgule (`double`) ou des combinaisons mixtes.
- Polymorphisme dynamique (Redefinition / Overriding) :
  - Resolu a l'execution.
  - Utilisation des mots-cles `virtual` (dans la classe de base `Culture`) et `override` (dans les classes specialisees `Ble`, `Mais`, `Riz`).
  - Execution dynamique de la methode `Croitre()` propre au type effectif de l'objet en memoire.

### 5. Abstraction et Interfaces Multiples (package Abstraction)
- Classes abstraites (`abstract class Forme`) :
  - Definition d'une methode abstraite pure `public abstract double CalculerSurface();`.
  - Implementations obligatoires dans les sous-classes concretes `Cercle` et `Rectangle`.
- Interfaces et contrats de comportement :
  - Interfaces specifiques `IVolant` (`void Voler()`) et `INageant` (`void Nager()`).
  - Decouplage et implementations multiples dans la classe `Canard` qui implemente a la fois `IVolant` et `INageant`.
  - Demonstration du polymorphisme base sur les interfaces : `IVolant v = new Avion(); v.Voler();`.

### 6. Composition d'Objets vs Heritage (package Composition)
- Demonstration de la relation "a-un" (has-a) : la classe `Voituree` possede une instance privee de `Moteur`.
- Delegation des comportements : la voiture fait appel aux methodes du moteur sans heriter inutilement de ses proprietes internes, favorisant un faible couplage.

## Prerequis et Environnement de Developpement

- .NET SDK (version 8.0 ou superieure recommandee)
- Compatible avec Visual Studio, Visual Studio Code (avec extension C# Dev Kit) ou JetBrains Rider.

## Compilation et Execution en Ligne de Commande

1. Cloner le depot :

```bash
git clone https://github.com/maximedefaleouna/cours-c-.git
cd cours-c-
```

2. Executer le module des fondamentaux :

```bash
dotnet run --project cours-c#
```

3. Executer le module de Programmation Orientee Objet :

```bash
dotnet run --project c#poo
```

## Organisation des Sources

- `cours-c#/Program.cs` : Fichier principal demontrant les types primitifs, chaines, collections, nullables et exceptions.
- `cours-c#/Person.cs` : Premiere classe modele de demonstration.
- `c#poo/Encapsulation/CompteBancaire.cs` : Encapsulation, proprietes en lecture seule et validation du solde.
- `c#poo/Heritage/Animal.cs` : Heritage, constructeur parent `base()` et visibilite `protected`.
- `c#poo/Polymorphisme/Surcharge/Calculatrice.cs` : Surcharge de methodes compile-time.
- `c#poo/Polymorphisme/methodes/Culture.cs` : Redefinition dynamique run-time avec `virtual` et `override`.
- `c#poo/Abstraction/Forme.cs` : Classe abstraite et calculs de surface polymorphiques.
- `c#poo/Abstraction/Interface/` : Interfaces multiples (`IVolant`, `INageant`) et implementations concrètes.
- `c#poo/Composition/` : Principe de composition (Voiture possedant un Moteur).
- `c#poo/Program.cs` : Point d'entree orchestrant et validant l'ensemble des concepts.

## Auteur

- Concepteur : Maxime DEFALEOUNA ([@maximedefaleouna](https://github.com/maximedefaleouna))

## Licence

Ce projet est mis a disposition sous licence MIT. Il est libre d'utilisation a des fins pedagogiques et de formation professionnelle.
