MonProjetAPI

Un projet web avec une API en C# (ASP.NET Core) pour le back-end et une application front-end en Vue.js. Ce projet permet de gérer et d'afficher des produits.

Table des matières

Arborescence
Prérequis
Installation
Lancer les serveurs
Description des dossiers et fichiers
Contribuer
Arborescence

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

── frontend/               
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
Prérequis

Assurez-vous d'avoir les outils suivants installés sur votre système :

.NET SDK (version 6 ou ultérieure) pour le back-end.
Node.js et npm pour le front-end (Vue.js).
Installation

Clonez ce dépôt sur votre machine :
git clone https://github.com/EpsithO/apifront.git
cd apifront
Installation des dépendances pour le back-end :
Accédez au dossier backend et assurez-vous que les dépendances sont prêtes.
Installation des dépendances pour le front-end :
Accédez au dossier frontend et exécutez :
npm install
Lancer les serveurs

Back-end (API)
Depuis le dossier backend, lancez le serveur avec :
dotnet run
L’API sera accessible à http://localhost:5000 ou https://localhost:5001.
Front-end (Vue.js)
Depuis le dossier frontend, lancez le serveur de développement avec :
npm run serve
Le front-end sera accessible à http://localhost:8080.
Description des dossiers et fichiers

backend/
Controllers/ : Contient les contrôleurs ASP.NET Core qui gèrent les requêtes API pour différentes entités. Exemple : ProductsController.cs pour gérer les produits.
Models/ : Contient les modèles de données de l’application. Product.cs définit la structure d'un produit.
Services/ (optionnel) : Services pour la logique métier. Exemple : ProductService.cs gère les opérations sur les produits.
Repositories/ (optionnel) : Fournit une couche d'abstraction pour l'accès aux données (ex : interaction avec la base de données).
Program.cs : Point d’entrée de l’application. Configure le serveur et démarre l’application.
Startup.cs : Configure les services de l'application, le pipeline des requêtes, et la sécurité (ex. : CORS).
appsettings.json : Fichier de configuration contenant les paramètres de l'application, comme les connexions à la base de données.
frontend/
public/ : Contient le fichier HTML principal et les ressources publiques. index.html est le point d'entrée de l’application Vue.
src/ : Contient le code source de l'application Vue.
assets/ : Stocke les fichiers statiques comme les images et le CSS.
components/ : Contient les composants Vue réutilisables. ProductList.vue affiche une liste de produits.
views/ : Contient les vues pour les pages principales de l’application. Home.vue est la vue de la page d'accueil.
App.vue : Composant racine de l'application Vue.
main.js : Fichier principal où Vue est initialisé, avec la configuration du routeur et des autres modules.
router.js : Définit les routes de l’application Vue (ex. : /home).
package.json : Contient les informations et dépendances du projet Vue.
vue.config.js : Configuration personnalisée pour l'application Vue.js (optionnel).
Contribuer

Forkez le projet.
Créez votre branche de fonctionnalité (git checkout -b feature/NouvelleFonctionnalite).
Commitez vos modifications (git commit -m 'Ajoute nouvelle fonctionnalité').
Poussez votre branche (git push origin feature/NouvelleFonctionnalite).
Ouvrez une pull request.
