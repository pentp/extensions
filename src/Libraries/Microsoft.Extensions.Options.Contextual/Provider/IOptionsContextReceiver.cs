﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Extensions.Options.Contextual.Provider;

/// <summary>
/// Provides functionality for contextual options providers to collect context data.
/// </summary>
public interface IOptionsContextReceiver
{
    /// <summary>
    /// Adds a key-value pair to the context.
    /// </summary>
    /// <typeparam name="T">The type of the data.</typeparam>
    /// <param name="key">The name of the data.</param>
    /// <param name="value">The data used to determine how to populate contextual options.</param>
    void Receive<T>(string key, T value);
}
