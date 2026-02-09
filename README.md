# Space Escape – Projet Unity3D

## 📌 Présentation
Jeu d’action développé sous **Unity3D**, réalisé dans le cadre de mes études.  
Le joueur contrôle un **vaisseau spatial** évoluant à l’intérieur d’un **bâtiment spatial fermé**, conçu comme un labyrinthe.

L’objectif est de **parcourir le niveau et trouver la sortie**, tout en évitant ou affrontant les ennemis présents dans la structure.

## 🎮 Gameplay
Le bâtiment spatial se présente comme un **labyrinthe**, obligeant le joueur à explorer, anticiper les déplacements ennemis et gérer ses ressources.

Deux types d’ennemis sont présents :
- **Vaisseaux utilisant le pathfinding Unity (NavMesh)** pour poursuivre le joueur
- **Vaisseaux à déplacement prédéfini**, effectuant des allers-retours entre un point A et un point B

Lorsque le joueur entre dans leur portée, les ennemis **tirent automatiquement** sur son vaisseau.

## ❤️ Système de survie
- Le vaisseau du joueur peut encaisser **5 tirs** avant d’être détruit
- Des **cœurs** sont disséminés dans le labyrinthe et peuvent être récupérés
- En cas de destruction du vaisseau :
  - Si le joueur possède au moins un cœur, celui-ci est **consommé**
  - Le vaisseau est alors **entièrement réparé**, permettant de continuer la partie

## 🚀 Système de déplacement
Les déplacements du vaisseau reposent sur un système **physique** afin d’obtenir des sensations réalistes :
- Utilisation de la **vélocité**
- Application de **forces de propulsion** pour l’avancée et la rotation
- Inertie volontaire pour renforcer le feeling spatial

## 🧰 Systèmes implémentés
- Contrôle d’un vaisseau avec **physique et inertie**
- IA ennemie :
  - Pathfinding avec **NavMesh**
  - Déplacements sur trajectoires prédéfinies
- Système de tir et détection de portée
- Gestion de la **vie**, destruction et réparation
- Collectibles (cœurs)
- Level design type **labyrinthe**

## 🛠️ Technologies
- **Moteur :** Unity3D
- **Langage :** C#
- **IA :** NavMesh
- **Genre :** Action / Exploration

## 👨‍💻 Objectifs pédagogiques
- Implémentation d’IA avec différents comportements
- Utilisation de la physique Unity pour des déplacements crédibles
- Gestion des états du joueur (vie, destruction, réparation)
- Conception de niveaux favorisant l’exploration
