using System;
using System.IO;
using System.Threading;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>
/// Deletes a temp tree that a real <c>FileSystemWatcher</c> and its background polling tasks may
/// still hold handles on.
///
/// The previous teardown swallowed every exception, which turned the (frequent) race with the
/// watcher into unbounded temp-directory growth on CI agents. Retrying briefly lets the watcher
/// release its handles; if it still fails we say so rather than pretending it worked.
/// </summary>
public static class TempProjectDirectory
{
    public static void Delete(string path, Action<string>? onFailure = null)
    {
        if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
        {
            return;
        }

        const int attempts = 5;
        for (var attempt = 1; attempt <= attempts; attempt++)
        {
            try
            {
                Directory.Delete(path, recursive: true);
                return;
            }
            catch (Exception e) when (e is IOException or UnauthorizedAccessException)
            {
                if (attempt == attempts)
                {
                    onFailure?.Invoke($"Could not delete temp dir '{path}' after {attempts} attempts: {e.Message}");
                    return;
                }

                Thread.Sleep(20 * attempt);
            }
        }
    }
}
