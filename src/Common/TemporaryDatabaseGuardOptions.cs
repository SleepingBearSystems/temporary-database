﻿namespace SleepingBearSystems.TemporaryDatabase.Common;

/// <summary>
/// Temporary database guard configuration options.
/// </summary>
public sealed class TemporaryDatabaseGuardOptions
{
    /// <summary>
    /// Prefix for the random database name.
    /// </summary>
    public string? DatabasePrefix { get; init; }

    /// <summary>
    /// Default options.
    /// </summary>
    public static readonly TemporaryDatabaseGuardOptions Defaults = new()
    {
        DatabasePrefix = "sbs_"
    };
}