using Xunit;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>
/// DispatcherHelper repeating actions are process-global. Tests that use fixed purpose
/// strings (or share the purpose map) must not run in parallel with each other.
/// </summary>
[CollectionDefinition(Name, DisableParallelization = true)]
public class DispatcherTimerTestCollection
{
    public const string Name = "DispatcherTimerTests";
}
