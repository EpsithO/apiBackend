# MonProjetAPI

API en C# (ASP.NET Core) pour le back-end et une application front-end en Vue.js pour la gestion et l'affichage de produits.

## Table des matières

- [Aperçu](#aperçu)
- [Arborescence](#arborescence)
- [Prérequis](#prérequis)
- [Installation](#installation)
- [Lancer les serveurs](#lancer-les-serveurs)
- [Description des dossiers et fichiers](#description-des-dossiers-et-fichiers)
- [Contribuer](#contribuer)

## Aperçu

Ce projet est composé d'une API en C# pour gérer les données des produits et d'une interface utilisateur en Vue.js pour visualiser ces produits. La séparation entre le back-end et le front-end permet une meilleure modularité et évolutivité.

## Arborescence

```plaintext
MonProjet/
├── backend/                 
│   ├── Controllers/        
│   │   └── ProductsController.cs
│   ├── Models/             
│   │   └── Product.cs
│   ├── Services/           
│   │   └── ProductService.cs
│   ├── Repositories/       
│   │   └── ProductRepository.cs
│   ├── Program.cs          
│   ├── Startup.cs          
│   └── appsettings.json    
│
├── frontend/               
│   ├── public/             
│   │   └── index.html      
│   ├── src/                
│   │   ├── assets/         
│   │   ├── components/     
│   │   │   └── ProductList.vue
│   │   ├── views/          
│   │   │   └── Home.vue
│   │   ├── App.vue         
│   │   ├── main.js         
│   │   └── router.js       
│   ├── package.json        
│   └── vue.config.js       
│
└── README.md
```
               


## Prérequis

Assurez-vous d'avoir les outils suivants installés :

.NET SDK (version 6 ou plus récente) pour le back-end.
Node.js et npm pour le front-end en Vue.js.

## Installation

Clonez ce dépôt :
```
git clone https://github.com/EpsithO/apifront.git
cd apifront
```
Installation des dépendances pour le back-end :
  Accédez au dossier backend/ :
```
cd backend
dotnet restore
```
Installation des dépendances pour le front-end :
  Accédez au dossier frontend/ et exécutez :
```
  cd ../frontend
  npm install
```

## Lancer les serveurs

Back-end (API en C#)
Depuis le dossier backend, lancez le serveur :
 ``` dotnet run```
L’API est disponible sur http://localhost:5000 ou https://localhost:5001.



Front-end (Vue.js)
Depuis le dossier frontend, lancez le serveur :
 ``` npm run serve```
Le front-end est accessible à http://localhost:8080.


## Description des dossiers et fichiers
```
backend/
  Controllers/ : Contient les contrôleurs ASP.NET Core qui gèrent les requêtes API pour chaque entité. Par exemple, ProductsController.cs gère les produits.
  Models/ : Définit les classes de modèles, comme Product.cs.
  Services/ (optionnel) : Services pour encapsuler la logique métier, comme ProductService.cs.
  Repositories/ (optionnel) : Fournit une couche d'abstraction pour la gestion des données (e.g., ProductRepository.cs).
  Program.cs : Point d’entrée pour démarrer le serveur API.
  Startup.cs : Configure les services et le pipeline de requêtes (ex. : CORS, authentification).
  appsettings.json : Paramètres de configuration de l’application (ex. : connexion à la base de données).
```
```
frontend/
  public/ : Contient le fichier HTML principal (index.html) et des ressources publiques.
  src/ : Code source principal de l’application Vue.js.
  assets/ : Contient les ressources statiques (images, CSS).
  components/ : Composants réutilisables, comme ProductList.vue.
  views/ : Vues de haut niveau, comme Home.vue.
  App.vue : Composant racine.
  main.js : Initialise Vue et configure les plugins.
  router.js : Définit les routes pour l’application Vue.
  package.json : Dépendances et scripts pour le front-end.
  vue.config.js : Configuration spécifique à Vue.js (optionnel).
```


## Contribuer 

Les contributions sont les bienvenues ! Suivez ces étapes :

Forkez le projet.
Créez une branche : ```(git checkout -b feature/NouvelleFonctionnalité).```
Commitez vos changements : ```(git commit -m 'Ajoute nouvelle fonctionnalité').```
Poussez la branche : ```(git push origin feature/NouvelleFonctionnalité).```

Créez une pull request sur le dépôt principal.
