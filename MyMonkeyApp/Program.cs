using MyMonkeyApp.Helpers;
using MyMonkeyApp.Services;

namespace MyMonkeyApp;

/// <summary>
/// Main program class
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Monkey App!");
        Console.WriteLine($"We have {MonkeyHelper.GetMonkeyCount()} monkeys in our collection.");

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
                    Console.WriteLine("Goodbye!");
                    return;
            }
            
            ConsoleService.WaitForKey();
        }
    }

    /// <summary>
    /// Display all monkeys
    /// </summary>
    private static void ShowAllMonkeys()
    {
        var monkeys = MonkeyHelper.GetAllMonkeys();
        ConsoleService.DisplayMonkeys(monkeys);
    }

    /// <summary>
    /// Search for a monkey by name
    /// </summary>
    private static void SearchMonkeyByName()
    {
        string name = ConsoleService.GetMonkeyName();
        var monkey = MonkeyHelper.GetMonkeyByName(name);
        
        if (monkey != null)
        {
            ConsoleService.DisplayMonkey(monkey);
        }
        else
        {
            Console.WriteLine($"Monkey '{name}' not found.");
        }
    }

    /// <summary>
    /// Display a random monkey
    /// </summary>
    private static void ShowRandomMonkey()
    {
        var monkey = MonkeyHelper.GetRandomMonkey();
        Console.WriteLine("Here's a random monkey:");
        ConsoleService.DisplayMonkey(monkey);
    }
}
