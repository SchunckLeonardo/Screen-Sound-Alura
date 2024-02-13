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
            Console.WriteLine("You want register a band");
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

ShowMessage();
ShowOptions();