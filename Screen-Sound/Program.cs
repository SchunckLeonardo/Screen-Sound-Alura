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
            Console.WriteLine("You want show all bands");
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
    Console.WriteLine("Band's Register");
    Console.Write("Type the band's name do you want register: ");
    string bandName = Console.ReadLine()!;
    Thread.Sleep(2000);
    Console.WriteLine($"The band {bandName} was succesfully registered");
    Thread.Sleep(2000);
    Console.Clear();
    ShowOptions();
}

ShowOptions();