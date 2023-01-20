using System.Threading.Tasks;
using ReactiveUI.Fody.Helpers;
using WolvenKit.ProjectManagement.Project;

namespace WolvenKit.Functionality.Services
{
    public interface IProjectManager
    {
        [Reactive]
        bool IsProjectLoaded { get; set; }

        Cp77Project? ActiveProject { get; set; }

        Task<bool> SaveAsync();

        Task<Cp77Project?> LoadAsync(string location);

    }
}
