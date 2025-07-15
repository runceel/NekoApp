namespace MyMonkeyApp.Models;

/// <summary>
/// Represents a monkey with basic information
/// </summary>
public class Monkey
{
    /// <summary>
    /// Name of the monkey species
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Location where the monkey is found
    /// </summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>
    /// Details about the monkey
    /// </summary>
    public string Details { get; set; } = string.Empty;

    /// <summary>
    /// Population count of the species
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Image reference for the monkey
    /// </summary>
    public string Image { get; set; } = string.Empty;
}