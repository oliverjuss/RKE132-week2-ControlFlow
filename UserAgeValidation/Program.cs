// See https://aka.ms/new-console-template for more information

// rakendus küsib kasutaja valida tema sugu (m/f)

using System.ComponentModel.Design;

Console.WriteLine("Plese write your gender (m/f)");

char gender = Char.Parse(Console.ReadLine());

// rakendus kõsib kasudajal sisestata tema perekonnanime
Console.WriteLine("Plese write your surename");

string userName = Console.ReadLine();

// lähtudes kasutaja valikust, rakendus tervitab kasutajat Järgmiselt:
// "Welcome, Mr. [kasutaja perekonnanimi]/ Ms. [kasutaja perekonnanimi]"
if (gender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userName}");
}
    
else if (gender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userName}");
}
else
{
    Console.WriteLine($"Welcome {userName}");
}
