# Chapitre 3 : Héritage

## 3.1 Introduction

L’héritage est un principe fondamental de la programmation orientée objet.  
Il permet à une classe (appelée classe dérivée ou classe enfant) d’hériter des membres d’une autre classe (appelée classe de base ou classe parent).

Cela permet de créer des relations hiérarchiques entre les classes et de réutiliser du code existant.

---

## Avantages de l’héritage

- Réutilisation du code existant
- Réduction de la duplication de code
- Création de hiérarchies logiques entre les classes
- Possibilité de spécialiser ou d’étendre les fonctionnalités d’une classe
- Amélioration de la maintenabilité du code

---

## Exemple concret

- **Classe de base :** `Animal`  
  Elle contient les caractéristiques générales et comportements communs à tous les animaux :
  - Propriétés : `Nom`, `Age`
  - Méthodes : `Manger()`

- **Classe dérivée :** `Chien`  
  Elle hérite de `Animal` et ajoute des comportements spécifiques :
  - Méthodes : `Aboyer()`

---

## Principe de base

Lorsqu’une classe hérite d’une autre :

- Elle récupère automatiquement ses propriétés et méthodes publiques et protégées
- Elle peut ajouter ses propres membres
- Elle peut modifier certains comportements via le polymorphisme (override)

---

## Exemple conceptuel

Une classe `Animal` représente un concept général.

Une classe `Chien` est un type spécifique d’animal :

- Un chien **est un animal**
- Mais tous les animaux ne sont pas des chiens

---

## À retenir

- L’héritage permet de créer des relations "est-un"
- La classe enfant réutilise les fonctionnalités de la classe parent
- Elle peut également les étendre ou les modifier
