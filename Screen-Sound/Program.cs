// Screen Sound
List<string> bandsList = new List<string> { "AC/DC", "Nirvana", "Gun's in Roses" };

void ShowMessage()
{
    Console.WriteLine(@"
        
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine("Welcome to the Screen Sound\n");
}

void ShowOptions()
{
    ShowMessage();
    Console.WriteLine("1 - Register a band");
    Console.WriteLine("2 - Show all bands");
    Console.WriteLine("3 - Rate a band");
    Console.WriteLine("4 - Show bands media");
    Console.WriteLine("5 - Exit Program");

    Console.Write("\nType your option: ");
    string userOption = Console.ReadLine()!;

    int userOptionInt = int.Parse(userOption);

    switch (userOptionInt)
    {
        case 1:
            RegisterBand();
            break;

        case 2:
            ShowAllBands();
            break;

        case 3:
            Console.WriteLine("You want rate a band");
            break;

        case 4:
            Console.WriteLine("You want show band media");
            break;

        case 5:
            Console.WriteLine("See you later!");
            break;

        default:
            Console.WriteLine("The option " + userOptionInt + " there isn't in Options List");
            Console.WriteLine("Type again!");
            break;

    }
}

void RegisterBand()
{
    Console.Clear();
    title("Band's Register");
    Console.Write("Type the band's name do you want register: ");
    string bandName = Console.ReadLine()!;
    bandsList.Add(bandName);
    Thread.Sleep(2000);
    Console.WriteLine($"The band {bandName} was succesfully registered");
    Thread.Sleep(2000);
    Console.Clear();
    ShowOptions();
}

void ShowAllBands()
{
    Console.Clear();
    title("Show All Bands");
    if (bandsList.Count <= 0)
    {
        Console.WriteLine("Not have any Bands Registered!");
        Console.WriteLine("Returning to menu in 5 secconds");
        Thread.Sleep(5000);
        Console.Clear();
        ShowOptions();
    } else
    {
        //for (int i = 0; i < bandsList.Count; i++)
        //{
        //    Console.WriteLine($"Band's Name: {bandsList[i]}");
        //}
        foreach (string bandName in bandsList)
        {
            Console.WriteLine($"Band's Name: {bandName}");
        }
        Console.WriteLine("Type any key to return to menu");
        Console.ReadKey();
        Console.Clear();
        ShowOptions();
    }
}

void title(string title)
{
    int qntTitle = title.Length;
    string symbols = string.Empty.PadLeft(qntTitle, '*');

    Console.WriteLine(symbols);
    Console.WriteLine(title);
    Console.WriteLine(symbols + "\n");
}

ShowOptions();