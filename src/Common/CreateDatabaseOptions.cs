namespace SleepingBearSystems.TemporaryDatabase.Common;

/// <summary>
/// Temporary database guard configuration options.
/// </summary>
public sealed class CreateDatabaseOptions
{
    /// <summary>
    /// Database collation.
    /// </summary>
    public string? Collation { get; init; }

    /// <summary>
    /// Default options.
    /// </summary>
    public static readonly CreateDatabaseOptions Defaults = new()
    {
        Collation = default
    };
}
