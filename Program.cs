bool invalidSelection = true;

Console.CursorVisible = false;

ConsoleKeyInfo userInput;

do
{
    Console.WriteLine("1. Search Product");
    Console.WriteLine("2. Create New Product");
    Console.WriteLine("3. Exit");

    userInput = Console.ReadKey(true);

    if (userInput.Key == ConsoleKey.D1)
    {
        Console.Clear();
        Console.CursorVisible = true;
        Console.Write("Enter Product Name: ");
        string searchTerm = Console.ReadLine();

        Console.Write("Searching... ");
        Thread.Sleep(500);
        Console.Clear();

        Console.WriteLine(searchTerm + " Found");
        Thread.Sleep(1000);
        Console.Clear();
    }
    else if (userInput.Key == ConsoleKey.D2)
    {
        Console.Clear();
        Console.CursorVisible = true;
        Console.Write("Create Product: ");
        string newProduct = Console.ReadLine();

        Console.Write("Creating... ");
        Thread.Sleep(500);
        Console.Clear();

        Console.WriteLine("New " + newProduct + " Created");
        Thread.Sleep(1000);
        Console.Clear();
    }
    else if (userInput.Key == ConsoleKey.D3)
    {
        Console.Write("Exiting... ");
        Thread.Sleep(1000);
        invalidSelection = false;
    }
}while (invalidSelection);