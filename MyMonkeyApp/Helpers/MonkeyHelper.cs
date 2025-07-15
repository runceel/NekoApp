using MyMonkeyApp.Models;

namespace MyMonkeyApp.Helpers;

/// <summary>
/// Helper class for managing monkey data
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> _monkeys = InitializeMonkeys();

    /// <summary>
    /// Get all monkeys
    /// </summary>
    /// <returns>List of all monkeys</returns>
    public static List<Monkey> GetAllMonkeys()
    {
        return _monkeys;
    }

    /// <summary>
    /// Get a monkey by name
    /// </summary>
    /// <param name="name">Name of the monkey to search for</param>
    /// <returns>Monkey if found, null otherwise</returns>
    public static Monkey? GetMonkeyByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return null;

        return _monkeys.FirstOrDefault(m => 
            m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Get a random monkey
    /// </summary>
    /// <returns>Random monkey</returns>
    public static Monkey GetRandomMonkey()
    {
        var random = new Random();
        return _monkeys[random.Next(_monkeys.Count)];
    }

    /// <summary>
    /// Get total monkey count
    /// </summary>
    /// <returns>Number of monkeys in the collection</returns>
    public static int GetMonkeyCount()
    {
        return _monkeys.Count;
    }

    /// <summary>
    /// Search monkeys by keyword
    /// </summary>
    /// <param name="keyword">Keyword to search for</param>
    /// <returns>List of matching monkeys</returns>
    public static List<Monkey> SearchMonkeys(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
            return new List<Monkey>();

        return _monkeys.Where(m => 
            m.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            m.Location.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            m.Details.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    /// <summary>
    /// Initialize the monkey data
    /// </summary>
    /// <returns>List of monkeys</returns>
    private static List<Monkey> InitializeMonkeys()
    {
        return new List<Monkey>
        {
            new Monkey
            {
                Name = "Japanese Macaque",
                Location = "Japan",
                Details = "Also known as snow monkeys, famous for bathing in hot springs",
                Population = 114000,
                Image = "japanese_macaque.jpg"
            },
            new Monkey
            {
                Name = "Chimpanzee",
                Location = "Central Africa",
                Details = "Our closest living relatives, highly intelligent tool users",
                Population = 300000,
                Image = "chimpanzee.jpg"
            },
            new Monkey
            {
                Name = "Bonobo",
                Location = "Democratic Republic of Congo",
                Details = "Peaceful and empathetic apes, known for conflict resolution",
                Population = 50000,
                Image = "bonobo.jpg"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Borneo and Sumatra",
                Details = "Highly intelligent red apes, excellent tree climbers",
                Population = 104000,
                Image = "orangutan.jpg"
            },
            new Monkey
            {
                Name = "Gorilla",
                Location = "Central Africa",
                Details = "Largest living primates, gentle giants of the forest",
                Population = 200000,
                Image = "gorilla.jpg"
            },
            new Monkey
            {
                Name = "Baboon",
                Location = "Africa and Arabia",
                Details = "Highly social primates living in large troops",
                Population = 2000000,
                Image = "baboon.jpg"
            },
            new Monkey
            {
                Name = "Rhesus Monkey",
                Location = "Asia",
                Details = "Adaptable macaques, important in medical research",
                Population = 1000000,
                Image = "rhesus_monkey.jpg"
            },
            new Monkey
            {
                Name = "Squirrel Monkey",
                Location = "South America",
                Details = "Small, agile primates with distinctive coloring",
                Population = 500000,
                Image = "squirrel_monkey.jpg"
            }
        };
    }
}