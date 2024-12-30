using System;
namespace Afficher
{

    public class Bonjour
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Bonjour tout le monde!");
            
            AfficherBonjour("Irina!");

        }

        //private string destinataire = "Irina";
        public static void AfficherBonjour(string destinataire)
        {
            
            Console.WriteLine("Bonjour  " + destinataire);
        }

    }
}