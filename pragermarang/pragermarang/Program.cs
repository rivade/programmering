Console.WriteLine("Välkommen till Den Fega Riddarens flykt!");
Console.WriteLine("Är du redo att börja?");
string start = Console.ReadLine().ToLower();
while (start != "ja" && start != "nej")
{
    Console.WriteLine("Du måste välja antingen ja eller nej");
    Console.WriteLine("Är du redo att börja?");
    start = Console.ReadLine().ToLower();
}

if (start == "ja")
{
    Console.WriteLine("Du befinner dig i ett slott, till höger och vänster om dig finns två dörrar.");
    Console.WriteLine("Vilken dörr tar du?");
    string valEtt = Console.ReadLine().ToLower();
    while (valEtt != "höger" && valEtt != "vänster")
    {
        Console.WriteLine("Du måste välja antingen höger eller vänster");
        Console.WriteLine("Vilken dörr tar du?");
        valEtt = Console.ReadLine().ToLower();
    }
    if (valEtt == "vänster")
    {
        Console.WriteLine("Du kommer ut i en hall, med en stor port längst fram och en dörr vid höger sida av hallen");
        Console.WriteLine("Tar du dörren till höger eller porten?");
        string valTvå = Console.ReadLine().ToLower();
        while (valTvå != "höger" && valTvå != "porten")
        {
            Console.WriteLine("Du måste välja antingen höger eller porten");
            Console.WriteLine("Tar du dörren till höger eller porten?");
            valTvå = Console.ReadLine().ToLower();
        }
        if (valTvå == "porten")
        {
            Console.WriteLine("Du kom ut ur slottet och vann spelet!");
            Console.WriteLine("Tryck enter för att stänga programmet");
            Console.ReadLine();
        }
        else if (valTvå == "höger")
        {
            Console.WriteLine("Bakom dörren fanns den arga kungen som avrättade dig!");
            Console.WriteLine("Du förlorade!");
            Console.WriteLine("Tryck enter för att stänga programmet");
            Console.ReadLine();
        }
    }
    else if (valEtt == "höger")
    {
        Console.WriteLine("Bakom den högra dörren fanns en drake som åt upp dig!");
        Console.WriteLine("Du förlorade!");
        Console.WriteLine("Tryck enter för att stänga programmet");
        Console.ReadLine();
    }
}

else if (start == "nej")
{
    Console.WriteLine("Nehepp varför startade du programmet då???? mongo");
    Console.WriteLine("Tryck enter för att stänga programmet");
    Console.ReadLine();
}