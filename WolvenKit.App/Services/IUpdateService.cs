using System.Threading.Tasks;
using WolvenKit.App.Models;

namespace WolvenKit.App.Services;

public interface IUpdateService
{
    public Task<bool> IsUpdateAvailable(MinimalGithubRelease? release = null);
    public Task UpdateToNewestVersion();
    public Task<string> GetLatestVersionTag();
}