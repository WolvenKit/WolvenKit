using System.Threading.Tasks;

namespace WolvenKit.App.Services;

public interface IUpdateService
{
    public Task<bool> IsUpdateAvailable();
    public Task UpdateToNewestVersion();
    public Task<string> GetLatestVersionString();
}