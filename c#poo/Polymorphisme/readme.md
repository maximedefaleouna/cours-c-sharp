# Chapitre 4 : Polymorphisme

## 4.1 Introduction

Le polymorphisme est un principe fondamental de la programmation orientée objet qui permet à un même appel de méthode d’avoir des comportements différents selon l’objet réel utilisé.

Le mot “polymorphisme” signifie littéralement “plusieurs formes”.

En pratique, cela permet de manipuler des objets de différentes classes dérivées via une référence de type commun (classe de base), tout en obtenant un comportement spécifique à chaque classe.

---

## 4.2 Principe du polymorphisme

Le polymorphisme repose sur :

- Une classe de base qui définit un comportement général
- Des classes dérivées qui redéfinissent ce comportement
- L’utilisation de `virtual` et `override` en C#

Le choix de la méthode exécutée se fait à l’exécution (runtime) en fonction du type réel de l’objet.

---

## 4.3 Exemple conceptuel

Une classe `Forme` représente un concept général.

Chaque forme a une action commune : `Dessiner()`.

Mais chaque forme se dessine différemment :

- Un cercle ne se dessine pas comme un carré
- Un triangle ne se dessine pas comme un cercle

---

## 4.4 Exemple en C#

```csharp
public class Forme
{
    public string Nom { get; set; }

    public virtual void Dessiner()
    {
        Console.WriteLine("Dessiner une forme");
    }
}

public class Cercle : Forme
{
    public override void Dessiner()
    {
        Console.WriteLine($"{Nom} : dessiner un cercle");
    }
}

public class Carre : Forme
{
    public override void Dessiner()
    {
        Console.WriteLine($"{Nom} : dessiner un carré");
    }
}
```
