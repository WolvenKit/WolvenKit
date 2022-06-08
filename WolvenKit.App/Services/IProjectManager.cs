using System.Threading.Tasks;
using WolvenKit.App.Functionality.ProjectManagement.Project;

namespace WolvenKit.App.Services
{
    public interface IProjectManager
    {
        public bool IsProjectLoaded { get; set; }

        EditorProject ActiveProject { get; set; }

        Task<bool> SaveAsync();

        Task<bool> LoadAsync(string location);

    }
}
