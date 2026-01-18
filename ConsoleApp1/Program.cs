Console.WriteLine("Welcome Press S to start");
var key = Console.ReadKey();
if (key.Key == ConsoleKey.S)
{
    Console.WriteLine("\nStarting the process...");
    Console.Clear();
    Console.WriteLine($"Press 1 to edit Branch" +
        $"\tPress 2 to edit Brand" +
        $"\tPress 3 to edit City" +
        $"\tPress 4 to edit Model" +
        $"\tPress 5 to edit Product" +
        $"\tPress 6 to edit Product Category" +
        $"\tPress 7 to edit Product Title" +
        $"\tPress 8 to edit Street");
}
else
{
    Console.WriteLine("\nInvalid key pressed. Exiting...");
}