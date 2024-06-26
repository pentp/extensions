﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Options.Contextual;

/// <summary>
/// Provides functionality to retrieve configured <typeparamref name="TOptions"/> instances.
/// </summary>
/// <typeparam name="TOptions">The type of options being requested.</typeparam>
/// <typeparam name="TContext">A type that defines the context for this request.</typeparam>
public interface IContextualOptions<TOptions, TContext>
    where TOptions : class
    where TContext : IOptionsContext
{
    /// <summary>
    /// Gets the configured <typeparamref name="TOptions"/> instance.
    /// </summary>
    /// <param name="context">The context that will be used to create the options.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A configured instance of <typeparamref name="TOptions"/>.</returns>
    ValueTask<TOptions> GetAsync(in TContext context, CancellationToken cancellationToken);
}
