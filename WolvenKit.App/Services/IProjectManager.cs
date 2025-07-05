using System;
using System.ComponentModel;
using System.Threading.Tasks;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.Services;

public interface IProjectManager : INotifyPropertyChanged
{
    bool IsProjectLoaded { get; set; }

    Cp77Project? ActiveProject { get; set; }

    Task<bool> SaveAsync();

    Task<Cp77Project?> LoadAsync(string location);
}
