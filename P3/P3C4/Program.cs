// TODO : créer deux méthodes
using P3C4;
using System.Numerics;

namespace P3C4;

class Compte
{
    private String nomClient;
    private String numeroCompte;
    private float soldo;
    //private float montant;

    public Compte(String nomClient, String numeroCompte, float soldo)
    {
        this.nomClient = nomClient;
        this.numeroCompte = numeroCompte;
        this.soldo = soldo;
    }

    public float ConsulterSoldo()
    {
        Console.WriteLine("Le soldo de compte" + numeroCompte + "est : " + soldo);
        return soldo;
    }
    public void Depot(double montant)
    {
        soldo += (float)montant;
        Console.WriteLine("Un dépôt de " + montant + " a été effectué.");
    }

    // Méthode pour tester ConsulterSoldo
    public static void TestConsulterSoldo()
    {
        Compte compte = new Compte("Bover", "123456a789", 1000.00f);

        // Act : appeler la méthode à tester
        float solde1 = compte.ConsulterSoldo();
        // Assert : vérifier que le résultat est conforme aux attentes
        if (solde1 == 1000.00f)
        {
            Console.WriteLine("Test ConsulterSoldo : Succès");
        }
        else
        {
            Console.WriteLine("Test ConsulterSoldo : Échec");

        }
    }

    
    // Méthode pour tester Depot
    public static void TestDepot()
    {
        // Arrange : préparer les données pour le test
        Compte compte = new Compte("Bover", "123456a789", 1000.00f);

        // Act : appeler la méthode Depot
        compte.Depot(800.00);

        // Act : vérifier le solde après le dépôt
        float solde = compte.ConsulterSoldo();

        // Assert : vérifier que le solde est correct après le dépôt
        if (solde == 1800.00f)
        {
            Console.WriteLine("Test Depot : Succès");
        }
        else
        {
            Console.WriteLine("Test Depot : Échec - Solde attendu : 1800.00, obtenu : " + solde);
        }
    }

    // TODO : afficher le resultat de ces deux méthodes ici

    public static void Main(String[] args)
    {
                // Création d'un objet compte
              /*  Compte compte = new Compte("Bover", "123456a789", 1000.00f);

                // Consultation du solde initial
                compte.ConsulterSoldo();

                compte.Depot(500.00);

                // Consultation du solde après le dépôt
                Console.Write(compte.ConsulterSoldo());  */

        Compte.TestConsulterSoldo();
        Compte.TestDepot();

    }
    
    
    // TODO : exécuter les méthodes de test pour les deux méthodes de la classe Program.cs
   /*public static void TestConsulterSoldo()
    {
        Compte compte1 = new Compte("Jean Dupont", "123456", 4000.0f);
        float solde = compte1.ConsulterSoldo();
        //Assert.AreEqual(1000.0f, solde, "Le solde initial doit être de 4000");
        Console.WriteLine("Le solde initial est : " + solde);
    }*/
    
}

