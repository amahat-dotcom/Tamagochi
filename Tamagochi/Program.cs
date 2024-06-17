/*Créez une application qui utilise une structure Tamagochi.
Votre tamagochi à plusieurs informations :
Son nom, son age (en nombre de jours), sa santé (en nombre de coeurs), son bonheur (en nombre de soleil) et
son nombre d'action (compte les actions par jours).

Dans la structure, créer une méthode Reset : elle initisialize la créature.
Son age, sa santé et son bonheur sont à 0, le nom est fournis par l'utilisateur en paramètre, et les actions
sont à 3.

Chaque fonction de gestion de la creature coute un point d'action.

Dans la structure, creer une methode Manger: elle permet de nourrir la creature, ce qui augmente la sante.
Donnez en paramètre une valeur entre 1 et 2. Si la valeur est 1, alors la santé augmente de 1. Si la valeur
est 2, la santé augmente de 2, mais le bonheur diminue de 1.

Dans la structure, creer une methode Jouer: elle permet de divertir la creature, ce qui augmente le bonheur.
Donnez en paramètre une valeur entre 1 et 2. Si la valeur est 1, alors le bonheur augmente de 1. Si la valeur
est 2, le bonheur augmente de 3, mais la sante diminue de 1 et coute un point d'action en plus.

Que ce soit pour Manger() ou Jouer(), si à la fin de la méthode, les points d'actions sont à Zéro, exécuter la
méthode Vieillir().

Dans la structure, créer une méthode Vieillir: elle représente le temps qui passe.
Aucun parametre. L'age augmente de 1, les points d'actions reviennent a 3, et la sante, comme le bonheur,
diminuent de 2.*/


using System.Security.Cryptography.X509Certificates;

public struct Tamagochi
{
    public string Nom;
    public int Age;
    public int Sante;
    public int Bonheur;
    public int Actions;

    public void Reset(string nom)
    {
        Nom = nom;
        Age = 0;
        Sante = 0;
        Bonheur = 0;
        Actions = 3;
    }

    // Méthode Manger 
    public void Manger(int valeur)
    {
        if (Actions <= 0)
        {
            Console.WriteLine("Pas assez de points d'action.");
            return;
        }

        if (valeur == 1)
        {
            Sante += 1;
        }
        else if (valeur == 2)
        {
            Sante += 2;
            Bonheur += -1;
        }

        Actions--;

        if (Actions == 0)
        {
            Vieillir();
        }
    }
 // Méthode Jouer
    Public void Jouer (int valeur) 
        { 
        if (Actions <= 0) 
        {
            Console.WriteLine("Il n' y a pas assez de points d'actions.")}
        return; 
        }
 // Méthode Vieillir
 Public void Vieillir () { }


