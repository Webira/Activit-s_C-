﻿namespace P3C2;

public class Animal
{
    //TODO. Il manque un mot-clé ici
    private static int total = 0;

    public static void Incrementer()
    {
        Animal.total += 1;
    }

    public static void AfficherNom()
    {
        string nom = "Rocky";
        Console.WriteLine(nom);
    }

} 
   