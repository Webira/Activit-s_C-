using P2C2._2;

Couleur couleurChoisie = Couleur.Vert;

// TODO : Remplacer la séquence if/else par une instruction switch équivalente
// qui fonctionne selon la valeur de couleurChoisie
if (couleurChoisie == Couleur.Bleu)
{
    Console.WriteLine("La couleur est bleue");
}
else if (couleurChoisie == Couleur.Vert)
{
    Console.WriteLine("La couleur est verte");
}
else if (couleurChoisie == Couleur.Rouge)
{
    Console.WriteLine("La couleur est rouge");
}
else if (couleurChoisie == Couleur.Jaune)
{
    Console.WriteLine("La couleur est jaune");
}
else
{
    Console.WriteLine("Cette couleur n'est pas connue !");
}
// switch
Couleur couleurChoisieSW = Couleur.Vert;
switch (couleurChoisieSW)
{
    case Couleur.Vert:
        Console.WriteLine("La couleur est vert");
        break;
    case Couleur.Bleu:
        Console.WriteLine("La couleur est Bleu");
        break;
    case Couleur.Rouge:
        Console.WriteLine("la couleur est Rouge");
        break;
    case Couleur.Jaune:
        Console.WriteLine("La couleur est Jaune");
        break;
}
// switch court
Couleur couleurChoisieSWC = Couleur.Vert;
switch (couleurChoisieSWC)
{
    case Couleur.Vert:
        Console.WriteLine("la couleur est vert foncé");
        break;
    default:
        Console.Write("Il n'y a pas des couleurs");
        break;
}
    
