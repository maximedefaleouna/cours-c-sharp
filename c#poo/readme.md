# Classes et Objets en Programmation Orientée Objet

En programmation orientée objet (POO), les classes et les objets sont les fondations de tout programme.

---

## Classe

Une classe est un modèle ou un plan qui décrit un type d’objet.  
Elle définit :

- des attributs (données ou propriétés)
- des méthodes (comportements ou actions)

Une classe peut être comparée à un moule ou un plan de construction.

---

## Objet

Un objet est une instance concrète d’une classe.  
C’est une entité créée à partir du modèle défini par la classe.

Chaque objet possède ses propres valeurs et est indépendant des autres objets.

---

## Exemple dans la vie réelle

### Classe : Voiture

Une classe Voiture définit les caractéristiques générales :

- Marque
- Modèle
- Couleur

Et les comportements :

- Démarrer
- Freiner
- Accélérer

---

### Objet : maVoiture

Un objet maVoiture est une voiture précise :

- Marque : Toyota
- Modèle : Corolla
- Couleur : Rouge

---

## Exemple en C#

```csharp
public class Voiture
{
    public string Marque { get; set; }
    public string Modele { get; set; }
    public string Couleur { get; set; }

    public void Demarrer()
    {
        Console.WriteLine("La voiture démarre.");
    }

    public void Freiner()
    {
        Console.WriteLine("La voiture freine.");
    }
}
```
