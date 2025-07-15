using MyMonkeyApp.Helpers;
using MyMonkeyApp.Models;
using MyMonkeyApp.Services;

namespace MyMonkeyApp;

/// <summary>
/// Main program class with enhanced UI/UX
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // Display welcome banner
        UIService.DisplayWelcomeBanner();
        
        // Display initial information
        Console.WriteLine();
        UIService.DisplayInfo($"Welcome to the Monkey Application!");
        UIService.DisplaySuccess($"We have {MonkeyHelper.GetMonkeyCount()} monkeys in our collection.");
        
        // Display a cute monkey ASCII art
        UIService.DisplayMonkeyAscii();
        
        // Main application loop
        while (true)
        {
            ConsoleService.DisplayMenu();
            
            int choice = ConsoleService.GetMenuSelection();
            
            switch (choice)
            {
                case 1:
                    ShowAllMonkeys();
                    break;
                case 2:
                    SearchMonkeyByName();
                    break;
                case 3:
                    ShowRandomMonkey();
                    break;
                case 4:
                    DisplayGoodbye();
                    return;
            }
            
            ConsoleService.WaitForKey();
        }
    }

    /// <summary>
    /// Display all monkeys in a table format
    /// </summary>
    private static void ShowAllMonkeys()
    {
        Console.WriteLine();
        UIService.DisplayInfo("Loading all monkeys...");
        
        var monkeys = MonkeyHelper.GetAllMonkeys();
        ConsoleService.DisplayMonkeys(monkeys);
        
        // Show detailed view option
        Console.WriteLine();
        UIService.DisplayPrompt("Would you like to see details for a specific monkey? (y/n): ");
        string response = Console.ReadLine()?.ToLower() ?? "";
        
        if (response == "y" || response == "yes")
        {
            ShowMonkeyDetails(monkeys);
        }
    }

    /// <summary>
    /// Show detailed view of a specific monkey
    /// </summary>
    /// <param name="monkeys">List of available monkeys</param>
    private static void ShowMonkeyDetails(List<Monkey> monkeys)
    {
        Console.WriteLine();
        UIService.DisplayPrompt("Enter the number of the monkey (1-" + monkeys.Count + "): ");
        
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= monkeys.Count)
        {
            var selectedMonkey = monkeys[index - 1];
            UIService.DisplaySuccess($"Showing details for {selectedMonkey.Name}:");
            ConsoleService.DisplayMonkey(selectedMonkey);
        }
        else
        {
            UIService.DisplayError("Invalid monkey number.");
        }
    }

    /// <summary>
    /// Search for a monkey by name
    /// </summary>
    private static void SearchMonkeyByName()
    {
        Console.WriteLine();
        UIService.DisplayInfo("Searching for a monkey by name...");
        
        string name = ConsoleService.GetMonkeyName();
        
        if (string.IsNullOrWhiteSpace(name))
        {
            UIService.DisplayError("Please enter a valid monkey name.");
            return;
        }
        
        var monkey = MonkeyHelper.GetMonkeyByName(name);
        
        if (monkey != null)
        {
            UIService.DisplaySuccess($"Found monkey: {monkey.Name}");
            ConsoleService.DisplayMonkey(monkey);
        }
        else
        {
            UIService.DisplayError($"Monkey '{name}' not found.");
            UIService.DisplayInfo("Try searching for: Japanese Macaque, Chimpanzee, Bonobo, Orangutan, Gorilla, Baboon, Rhesus Monkey, or Squirrel Monkey");
        }
    }

    /// <summary>
    /// Display a random monkey
    /// </summary>
    private static void ShowRandomMonkey()
    {
        Console.WriteLine();
        UIService.DisplayInfo("Selecting a random monkey...");
        
        var monkey = MonkeyHelper.GetRandomMonkey();
        
        Console.WriteLine();
        UIService.DisplaySuccess("Here's your random monkey:");
        ConsoleService.DisplayMonkey(monkey);
        
        // Add some fun elements
        UIService.DisplayInfo("Fun fact: Each monkey has unique characteristics!");
    }

    /// <summary>
    /// Display goodbye message
    /// </summary>
    private static void DisplayGoodbye()
    {
        Console.WriteLine();
        UIService.DisplayMenuSeparator();
        
        UIService.SetColor(ConsoleColor.Yellow);
        Console.WriteLine(@"
    🐵 Thank you for using the Monkey Application! 🐵
    
         .-""-.
        /       \
       |  o   o  |
       |    >    |
       |   ___   |
        \       /
         '-----'
         
    🐒 Come back anytime to learn more about monkeys! 🐒
");
        UIService.ResetColor();
        
        UIService.DisplayMenuSeparator();
        UIService.DisplaySuccess("Goodbye!");
        
        // Small delay for better UX
        System.Threading.Thread.Sleep(1000);
    }
}
