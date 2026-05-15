# Chapitre 2 : Encapsulation

## 2.1 Introduction

L’encapsulation est l’un des principes fondamentaux de la programmation orientée objet. Elle consiste à protéger l’état interne d’un objet et à contrôler l’accès à ses données via des méthodes ou des propriétés.

Elle permet de cacher les détails d’implémentation et d’exposer uniquement ce qui est nécessaire pour utiliser l’objet correctement.

---

## Objectifs principaux

- Empêcher un objet d’être modifié de manière incohérente
- Garantir la cohérence des données internes
- Masquer les détails internes de l’implémentation
- Contrôler l’accès aux données via des méthodes ou propriétés

---

## Exemple concret

Une classe `CompteBancaire` doit empêcher un solde négatif.

Au lieu de rendre le champ `solde` public, on le protège avec un accès contrôlé :

- lecture via une propriété ou une méthode
- modification via des méthodes comme `Deposer()` ou `Retirer()`

Cela permet de valider les opérations avant de modifier l’état de l’objet.

---

## 2.2 Modificateurs d’accès

C# fournit plusieurs modificateurs d’accès pour contrôler la visibilité des membres d’une classe.

| Modificateur         | Accessible depuis               | Description                               |
| -------------------- | ------------------------------- | ----------------------------------------- |
| `public`             | Partout                         | Accessible depuis n’importe quelle classe |
| `private`            | Uniquement dans la classe       | Niveau de restriction le plus fort        |
| `protected`          | Classe et classes dérivées      | Accessible uniquement via l’héritage      |
| `internal`           | Même assembly (projet)          | Accessible uniquement dans le même projet |
| `protected internal` | Classe dérivée ou même assembly | Combine `protected` et `internal`         |

---

## Importance de l’encapsulation

L’encapsulation est essentielle pour :

- protéger les données sensibles
- éviter les modifications directes non contrôlées
- faciliter la maintenance du code
- permettre l’évolution du code sans casser les autres parties du programme

---

## Exemple conceptuel

Dans une classe `CompteBancaire` :

- Le solde ne doit jamais être modifié directement
- Les opérations doivent passer par des méthodes contrôlées

Exemple de logique :

- `Deposer(montant)` ajoute de l’argent
- `Retirer(montant)` vérifie le solde avant de retirer
- `Solde` est accessible en lecture seule
