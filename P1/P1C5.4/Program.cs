IDictionary<string, int> mois = new Dictionary<string, int>();

// TODO : Remplacer les noms par des constantes de type chaine de caractères
/*mois.Add("Juin", 6);
mois.Add("Septembre", 9);
mois.Add("Mars", 5);*/

const string cleJuin = "Juin";
const string cleSept = "Septembre";
const string cleMars = "Mars";

mois.Add(cleJuin, 6);
mois.Add(cleSept, 9);
mois.Add(cleMars, 5);


// TODO : Corriger la valeur de Mars avec (3)

//mois.Add(cleMars, 3);
mois[cleMars] = 3;

// TODO : Retirer Juin
mois.Remove(cleJuin);

// Afficher le contenu du dictionnaire
Console.WriteLine("La liste des mois est :");
foreach (KeyValuePair<string, int> clePaire in mois)
{
    Console.WriteLine(clePaire.Key.ToString() + " est le numéro du mois de " + clePaire.Value + " de l'année ");
}