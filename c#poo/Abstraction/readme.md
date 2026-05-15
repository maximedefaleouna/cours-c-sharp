# Chapitre 5 : Abstraction

## 5.1 Introduction

L’abstraction est un principe fondamental de la programmation orientée objet qui consiste à masquer les détails d’implémentation et à ne montrer que les fonctionnalités essentielles d’un objet.

Elle permet de se concentrer sur le “quoi faire” plutôt que sur le “comment le faire”.

En C#, l’abstraction est principalement réalisée à l’aide des classes abstraites et des interfaces.

---

## 5.2 Objectifs de l’abstraction

- Masquer la complexité interne
- Définir un comportement commun pour plusieurs classes
- Forcer les classes dérivées à implémenter certaines méthodes
- Améliorer la lisibilité et la maintenance du code
- Réduire le couplage entre les classes

---

## 5.3 Classe abstraite

Une classe abstraite est une classe qui :

- ne peut pas être instanciée directement
- peut contenir des méthodes concrètes (avec implémentation)
- peut contenir des méthodes abstraites (sans implémentation)

Une méthode abstraite doit obligatoirement être implémentée dans les classes dérivées.

---

## 5.4 Exemple de classe abstraite

```csharp
public abstract class Animal
{
    public string Nom { get; set; }

    public void Dormir()
    {
        Console.WriteLine($"{Nom} dort.");
    }

    public abstract void FaireDuBruit();
}
```
