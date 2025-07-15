using MyMonkeyApp.Models;

namespace MyMonkeyApp.Services;

/// <summary>
/// Service for handling console interactions with enhanced UI
/// </summary>
public static class ConsoleService
{
    /// <summary>
    /// Display the main menu options with enhanced visuals
    /// </summary>
    public static void DisplayMenu()
    {
        Console.WriteLine();
        UIService.DisplayMenuSeparator();
        
        UIService.SetColor(ConsoleColor.Magenta);
        Console.WriteLine("  🐵 M O N K E Y   A P P   M E N U 🐵");
        UIService.ResetColor();
        
        UIService.DisplayMenuSeparator();
        Console.WriteLine();
        
        UIService.SetColor(ConsoleColor.White);
        Console.WriteLine("  1. 🐒 Show all monkeys");
        Console.WriteLine("  2. 🔍 Search monkey by name");
        Console.WriteLine("  3. 🎲 Get random monkey");
        Console.WriteLine("  4. 🚪 Exit");
        UIService.ResetColor();
        
        Console.WriteLine();
        UIService.DisplaySeparator();
        Console.WriteLine();
        
        UIService.DisplayPrompt("Select an option (1-4): ");
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
            UIService.DisplayError("Invalid choice. Please enter 1-4.");
            UIService.DisplayPrompt("Select an option (1-4): ");
        }
    }

    /// <summary>
    /// Display a single monkey's information with enhanced formatting
    /// </summary>
    /// <param name="monkey">Monkey to display</param>
    public static void DisplayMonkey(Monkey monkey)
    {
        Console.WriteLine();
        UIService.DisplaySeparator();
        
        UIService.SetColor(ConsoleColor.Yellow);
        Console.WriteLine($"  🐵 {monkey.Name.ToUpper()}");
        UIService.ResetColor();
        
        UIService.DisplaySeparator();
        
        UIService.SetColor(ConsoleColor.Cyan);
        Console.Write("  📍 Location: ");
        UIService.ResetColor();
        Console.WriteLine(monkey.Location);
        
        UIService.SetColor(ConsoleColor.Cyan);
        Console.Write("  📝 Details: ");
        UIService.ResetColor();
        Console.WriteLine(monkey.Details);
        
        UIService.SetColor(ConsoleColor.Cyan);
        Console.Write("  👥 Population: ");
        UIService.ResetColor();
        UIService.SetColor(ConsoleColor.Green);
        Console.WriteLine($"{monkey.Population:N0}");
        UIService.ResetColor();
        
        UIService.SetColor(ConsoleColor.Cyan);
        Console.Write("  🖼️  Image: ");
        UIService.ResetColor();
        UIService.SetColor(ConsoleColor.Gray);
        Console.WriteLine(monkey.Image);
        UIService.ResetColor();
        
        UIService.DisplaySeparator();
    }

    /// <summary>
    /// Display a table of monkeys with enhanced formatting
    /// </summary>
    /// <param name="monkeys">List of monkeys to display</param>
    public static void DisplayMonkeys(List<Monkey> monkeys)
    {
        if (monkeys.Count == 0)
        {
            UIService.DisplayWarning("No monkeys found in the collection.");
            return;
        }

        Console.WriteLine();
        UIService.DisplayInfo($"Found {monkeys.Count} monkey(s) in the collection:");
        Console.WriteLine();
        
        // Display table header
        DisplayTableHeader();
        
        // Display table rows
        for (int i = 0; i < monkeys.Count; i++)
        {
            DisplayTableRow(i + 1, monkeys[i]);
        }
        
        // Display table footer
        DisplayTableFooter();
        
        Console.WriteLine();
        UIService.DisplaySuccess($"Total monkeys displayed: {monkeys.Count}");
    }

    /// <summary>
    /// Display table header
    /// </summary>
    private static void DisplayTableHeader()
    {
        UIService.SetColor(ConsoleColor.Yellow);
        Console.WriteLine("┌─────┬─────────────────────┬─────────────────────┬─────────────┐");
        Console.WriteLine("│ No. │        Name         │      Location       │ Population  │");
        Console.WriteLine("├─────┼─────────────────────┼─────────────────────┼─────────────┤");
        UIService.ResetColor();
    }

    /// <summary>
    /// Display table row
    /// </summary>
    /// <param name="index">Row index</param>
    /// <param name="monkey">Monkey data</param>
    private static void DisplayTableRow(int index, Monkey monkey)
    {
        UIService.SetColor(ConsoleColor.White);
        Console.Write("│ ");
        UIService.SetColor(ConsoleColor.Cyan);
        Console.Write($"{index,2}");
        UIService.SetColor(ConsoleColor.White);
        Console.Write(" │ ");
        
        UIService.SetColor(ConsoleColor.Yellow);
        Console.Write($"{monkey.Name,-19}");
        UIService.SetColor(ConsoleColor.White);
        Console.Write(" │ ");
        
        UIService.SetColor(ConsoleColor.Green);
        Console.Write($"{monkey.Location,-19}");
        UIService.SetColor(ConsoleColor.White);
        Console.Write(" │ ");
        
        UIService.SetColor(ConsoleColor.Magenta);
        Console.Write($"{monkey.Population,11:N0}");
        UIService.SetColor(ConsoleColor.White);
        Console.WriteLine(" │");
        UIService.ResetColor();
    }

    /// <summary>
    /// Display table footer
    /// </summary>
    private static void DisplayTableFooter()
    {
        UIService.SetColor(ConsoleColor.Yellow);
        Console.WriteLine("└─────┴─────────────────────┴─────────────────────┴─────────────┘");
        UIService.ResetColor();
    }

    /// <summary>
    /// Get user input for monkey name search
    /// </summary>
    /// <returns>Monkey name to search for</returns>
    public static string GetMonkeyName()
    {
        Console.WriteLine();
        UIService.DisplayPrompt("Enter monkey name to search: ");
        return Console.ReadLine()?.Trim() ?? string.Empty;
    }

    /// <summary>
    /// Wait for user to press any key with enhanced prompt
    /// </summary>
    public static void WaitForKey()
    {
        Console.WriteLine();
        UIService.DisplaySeparator();
        UIService.SetColor(ConsoleColor.DarkGray);
        Console.WriteLine("  Press any key to continue...");
        UIService.ResetColor();
        Console.ReadKey();
    }
}