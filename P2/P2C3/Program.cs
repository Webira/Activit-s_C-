//TODO : Créer une boucle for et while qui affiche à 5 reprises la phrase, « Je m'amuse comme un fou ! ».
//Créez une boucle qui affiche la phrase « Je m'amuse comme un fou ! » 5 fois dans le fichier Program.cs
//-Changez votre boucle « for » par une boucle « while ». Était-ce une bonne idée ?
//- Sautez l'affichage de la quatrième boucle.
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(" Je m'amuse comme un fou !");
}
//////
for(int j = 0; j< 5; j++)
{
    if(j == 4)
    {
        continue;
    }
    Console.WriteLine(" C'est une boucle For avec Continue !");
}
/////
int phrase = 0;
while(phrase < 5)
{
    phrase += 1;
    Console.WriteLine(" Je m'amuse comme un fouFou! ");
}
Console.WriteLine(phrase);

//////
bool phrase2 = false; 
while(phrase2)
{
    Console.WriteLine("Je m'amuse!");

}
Console.WriteLine("Fin!");

//////
do
{
    Console.WriteLine("C'est un boucle Do While");
} while (phrase2);

//////
int phrase1 = 0;
do
{
    Console.WriteLine("C'est une boucle Do While 1");
    phrase1 -= 1;
} while (phrase1 > 0);
Console.WriteLine("Fin de la boucle");

/////
string[] phrase4 = new string[] { "pomme", "orange", "banane" };
foreach (string s in phrase4)
{
    Console.WriteLine(s);
}