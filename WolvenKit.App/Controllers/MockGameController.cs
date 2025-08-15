using System;
using System.Threading.Tasks;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Controllers;

public class MockGameController : IGameController
{
    public bool AddToMod(IGameFile file) => throw new NotImplementedException();
    public Task<bool> AddFileToModModalAsync(IGameFile file) => throw new NotImplementedException();

    public Task<bool> AddFileToModModalAsync(IGameFile file, ArchiveManagerScope searchScope) =>
        throw new NotImplementedException();

    public Task<bool> AddFileToModModalAsync(ulong hash) => throw new NotImplementedException();

    public Task<bool> AddFileToModModalAsync(ulong hash, ArchiveManagerScope searchScope) =>
        throw new NotImplementedException();

    public bool AddToMod(ulong hash, ArchiveManagerScope searchScope) => throw new NotImplementedException();

    public bool AddToMod(IGameFile file, ArchiveManagerScope searchScope) => throw new NotImplementedException();
    public bool AddToMod(ulong hash) => throw new NotImplementedException();
    public async Task HandleStartup() => await Task.CompletedTask;
    public Task<bool> LaunchProjectAsync(LaunchProfile profile) => throw new NotImplementedException();
    public Task<bool> InstallProjectHotAsync() => throw new NotImplementedException();
    public bool CleanAll(bool isPostBuild = false) => throw new NotImplementedException();
}
