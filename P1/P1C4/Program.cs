// TODO, étape 1 : instancier un objet de la classe Livre et affecter cet objet à une variable nommée monLivre
using System.Runtime.CompilerServices;
using P1C4;

    Livre monLivre = new Livre();

    // TODO, étape 2 : affecter une valeur aux champs titre, auteur et nombre de pages de votre objet
    monLivre.titre = "ABCD";
 monLivre.auteur = "Compte";
 monLivre.nombreDePages = 250;
        
// Afficher le contenu des champs de cet objet 
Console.WriteLine("Le titre du livre est " + monLivre.titre);
Console.WriteLine("Son auteur est " + monLivre.auteur);
Console.WriteLine("Il compte " + monLivre.nombreDePages);
