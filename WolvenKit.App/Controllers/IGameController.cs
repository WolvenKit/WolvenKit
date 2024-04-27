using System.Threading.Tasks;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Controllers;

public interface IGameController
{
    /// <summary>
    /// Finds a file in the currently active scope and adds it to the mod
    /// </summary>
    /// <param name="hash">Unique hash of the file</param>
    /// <returns>bool success</returns>
    public bool AddToMod(ulong hash);

    /// <summary>
    /// Finds a file in the dedicated search scope and adds it to the mod
    /// </summary>
    /// <param name="hash">Unique hash of the file</param>
    /// <param name="searchScope">Scope to search in. Defaults to Basegame</param>
    /// <returns>bool success</returns>
    public bool AddToMod(ulong hash, ArchiveManagerScope searchScope);

    /// <summary>
    /// Adds file to the mod's directory, creating the necessary folders. 
    /// </summary>
    /// <param name="file">the file in question</param>
    /// <param name="searchScope">Search scope. Defaults to ArchiveManagerScope.Basegame</param>
    /// <returns>bool success</returns>
    public bool AddToMod(IGameFile file, ArchiveManagerScope searchScope);

    /// <summary>
    /// Adds file to the mod's directory, creating the necessary folders. Will pass the currently active scope.
    /// </summary>
    /// <param name="file">the file in question</param>
    /// <returns>bool success</returns>
    public bool AddToMod(IGameFile file);

    /// <summary>
    /// Adds file to the current modal, using the active scope.
    /// </summary>
    /// <param name="file">the file in question</param>
    /// <returns>bool success</returns>
    Task<bool> AddFileToModModal(IGameFile file);

    /// <summary>
    /// Adds file from the selected search scope to the current modal
    /// </summary>
    /// <param name="file">the file in question</param>
    /// <param name="searchScope">search scope (basegame/mods/everywhere)</param>
    /// <returns>bool success</returns>
    Task<bool> AddFileToModModal(IGameFile file, ArchiveManagerScope searchScope);

    /// <summary>
    /// Resolves hash and adds file to the current modal, using the active scope.
    /// </summary>
    /// <param name="hash">unique hash of file</param>
    /// <returns>bool success</returns>
    Task<bool> AddFileToModModal(ulong hash);

    /// <summary>
    /// Resolves hash from search scope and adds file to the current modal.
    /// </summary>
    /// <param name="hash">unique hash of file</param>
    /// <param name="searchScope">search scope (basegame/mods/everywhere)</param>
    /// <returns>bool success</returns>
    Task<bool> AddFileToModModal(ulong hash, ArchiveManagerScope searchScope);

    public Task HandleStartup();

    Task<bool> LaunchProject(LaunchProfile profile);
    bool PackProjectHot();
    bool CleanAll();
}
