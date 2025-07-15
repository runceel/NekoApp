using MyMonkeyApp.Models;

namespace MyMonkeyApp.Services;

/// <summary>
/// Service for handling console interactions
/// </summary>
public static class ConsoleService
{
    /// <summary>
    /// Display the main menu options
    /// </summary>
    public static void DisplayMenu()
    {
        Console.WriteLine("\n=== Monkey App Menu ===");
        Console.WriteLine("1. Show all monkeys");
        Console.WriteLine("2. Search monkey by name");
        Console.WriteLine("3. Get random monkey");
        Console.WriteLine("4. Exit");
        Console.Write("\nSelect an option (1-4): ");
    }

    /// <summary>
    /// Get user input for menu selection
    /// </summary>
    /// <returns>Selected menu option</returns>
    public static int GetMenuSelection()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
            {
                return choice;
            }
            Console.Write("Invalid choice. Please enter 1-4: ");
        }
    }

    /// <summary>
    /// Display a single monkey's information
    /// </summary>
    /// <param name="monkey">Monkey to display</param>
    public static void DisplayMonkey(Monkey monkey)
    {
        Console.WriteLine($"\n--- {monkey.Name} ---");
        Console.WriteLine($"Location: {monkey.Location}");
        Console.WriteLine($"Details: {monkey.Details}");
        Console.WriteLine($"Population: {monkey.Population:N0}");
        Console.WriteLine($"Image: {monkey.Image}");
    }

    /// <summary>
    /// Display a list of monkeys
    /// </summary>
    /// <param name="monkeys">List of monkeys to display</param>
    public static void DisplayMonkeys(List<Monkey> monkeys)
    {
        if (monkeys.Count == 0)
        {
            Console.WriteLine("No monkeys found.");
            return;
        }

        Console.WriteLine($"\nFound {monkeys.Count} monkey(s):");
        foreach (var monkey in monkeys)
        {
            DisplayMonkey(monkey);
        }
    }

    /// <summary>
    /// Get user input for monkey name search
    /// </summary>
    /// <returns>Monkey name to search for</returns>
    public static string GetMonkeyName()
    {
        Console.Write("Enter monkey name: ");
        return Console.ReadLine() ?? string.Empty;
    }

    /// <summary>
    /// Wait for user to press any key
    /// </summary>
    public static void WaitForKey()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}