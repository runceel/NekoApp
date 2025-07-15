namespace MyMonkeyApp.Services;

/// <summary>
/// Service for handling UI/UX elements including colors and ASCII art
/// </summary>
public static class UIService
{
    /// <summary>
    /// Display ASCII art welcome banner
    /// </summary>
    public static void DisplayWelcomeBanner()
    {
        Console.Clear();
        SetColor(ConsoleColor.Yellow);
        Console.WriteLine(@"
    ╔═══════════════════════════════════════════════════════════════════════════════╗
    ║                                                                               ║
    ║    🐵    ███╗   ███╗ ██████╗ ███╗   ██╗██╗  ██╗███████╗██╗   ██╗         🐵    ║
    ║         ████╗ ████║██╔═══██╗████╗  ██║██║ ██╔╝██╔════╝╚██╗ ██╔╝              ║
    ║    🦍    ██╔████╔██║██║   ██║██╔██╗ ██║█████╔╝ █████╗   ╚████╔╝          🦍    ║
    ║         ██║╚██╔╝██║██║   ██║██║╚██╗██║██╔═██╗ ██╔══╝    ╚██╔╝               ║
    ║    🐒    ██║ ╚═╝ ██║╚██████╔╝██║ ╚████║██║  ██╗███████╗   ██║           🐒    ║
    ║         ╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝╚══════╝   ╚═╝               ║
    ║                                                                               ║
    ║                            A P P L I C A T I O N                             ║
    ║                                                                               ║
    ╚═══════════════════════════════════════════════════════════════════════════════╝
");
        ResetColor();
    }

    /// <summary>
    /// Display a menu separator
    /// </summary>
    public static void DisplayMenuSeparator()
    {
        SetColor(ConsoleColor.Cyan);
        Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════");
        ResetColor();
    }

    /// <summary>
    /// Display a simple separator line
    /// </summary>
    public static void DisplaySeparator()
    {
        SetColor(ConsoleColor.DarkCyan);
        Console.WriteLine("───────────────────────────────────────────────────────────────────────────────");
        ResetColor();
    }

    /// <summary>
    /// Display monkey ASCII art
    /// </summary>
    public static void DisplayMonkeyAscii()
    {
        SetColor(ConsoleColor.Yellow);
        Console.WriteLine(@"
              .-""-.')
             /       \
            |  .-. .-.  |
            |  | O | O  |
            |  |   V   |  |
            |  |  (_)  |  |
            |  |       |  |
            |  '._____.'  |
            |             |
             \           /
              '._______.'
");
        ResetColor();
    }

    /// <summary>
    /// Set console foreground color
    /// </summary>
    /// <param name="color">Color to set</param>
    public static void SetColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    /// <summary>
    /// Reset console color to default
    /// </summary>
    public static void ResetColor()
    {
        Console.ResetColor();
    }

    /// <summary>
    /// Display error message in red
    /// </summary>
    /// <param name="message">Error message to display</param>
    public static void DisplayError(string message)
    {
        SetColor(ConsoleColor.Red);
        Console.WriteLine($"❌ {message}");
        ResetColor();
    }

    /// <summary>
    /// Display success message in green
    /// </summary>
    /// <param name="message">Success message to display</param>
    public static void DisplaySuccess(string message)
    {
        SetColor(ConsoleColor.Green);
        Console.WriteLine($"✅ {message}");
        ResetColor();
    }

    /// <summary>
    /// Display info message in blue
    /// </summary>
    /// <param name="message">Info message to display</param>
    public static void DisplayInfo(string message)
    {
        SetColor(ConsoleColor.Blue);
        Console.WriteLine($"ℹ️  {message}");
        ResetColor();
    }

    /// <summary>
    /// Display warning message in yellow
    /// </summary>
    /// <param name="message">Warning message to display</param>
    public static void DisplayWarning(string message)
    {
        SetColor(ConsoleColor.Yellow);
        Console.WriteLine($"⚠️  {message}");
        ResetColor();
    }

    /// <summary>
    /// Display a prompt message
    /// </summary>
    /// <param name="message">Prompt message</param>
    public static void DisplayPrompt(string message)
    {
        SetColor(ConsoleColor.Cyan);
        Console.Write($"➤ {message}");
        ResetColor();
    }
}