using System.Threading.Tasks;
using WolvenKit.App.Models;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Controllers;

public interface IGameController
{
    public bool AddToMod(ulong hash);
    public bool AddToMod(IGameFile file);
    Task<bool> AddFileToModModal(IGameFile file);
    Task<bool> AddFileToModModal(ulong hash);

    public Task HandleStartup();

    Task<bool> LaunchProject(LaunchProfile profile);
    bool PackProjectHot();
    bool CleanAll();
}
