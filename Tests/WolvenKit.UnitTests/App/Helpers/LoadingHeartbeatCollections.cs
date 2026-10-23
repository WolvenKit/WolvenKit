using Xunit;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>
/// Tests that drive the shared <see cref="WolvenKit.App.ViewModels.Tools.ProjectExplorerViewModel.LoadProjectPurpose"/>
/// heartbeat.
///
/// That purpose is a process-wide constant baked into the view model, so these tests would
/// otherwise observe each other's registrations. Sharing one xunit collection makes them run
/// sequentially <em>with respect to each other</em>.
///
/// Deliberately does NOT set <c>DisableParallelization</c>: that would serialize this collection
/// against the whole assembly. Collections run in parallel with one another by default, which is
/// all we need — tests that use a purpose unique to the test need no collection at all.
/// </summary>
[CollectionDefinition(Name)]
public class ProjectLoadHeartbeatCollection
{
    public const string Name = "ProjectLoadHeartbeat";
}

/// <summary>
/// Same rationale for the shared
/// <see cref="WolvenKit.App.Controllers.RED4Controller.ArchiveLoadingPurpose"/> heartbeat.
/// It is a different purpose string, so this collection runs in parallel with
/// <see cref="ProjectLoadHeartbeatCollection"/>.
/// </summary>
[CollectionDefinition(Name)]
public class ArchiveLoadHeartbeatCollection
{
    public const string Name = "ArchiveLoadHeartbeat";
}
