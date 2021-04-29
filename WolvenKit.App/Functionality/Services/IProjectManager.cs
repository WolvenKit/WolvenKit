using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.Functionality.Services
{
    public interface IProjectManager
    {
        public bool IsProjectLoaded { get; set; }

        EditorProject ActiveProject { get; }

        Task<bool> SaveAsync();

        Task<bool> LoadAsync(string location);
    }
}
