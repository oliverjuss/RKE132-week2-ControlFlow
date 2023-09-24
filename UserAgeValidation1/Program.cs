// See https://aka.ms/new-console-template for more information

// rakendus küisib kasutajal sisestada tema vanuse


Console.WriteLine("Please enter your age");

string userAge = Console.ReadLine();
int UserAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out UserAgeNum);




// kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
if (isAgeNumber)
{
    if (UserAgeNum < 13)
    {
        Console.WriteLine("You are too young to use Instagram");
    }

    //muul juhul
    // konsoolis kuvatakse "Welocome to Instagram"

    else
    {
        Console.WriteLine("Welocome to Instagram");
    }
}
else
{
    Console.WriteLine("Could not read your age");
}





