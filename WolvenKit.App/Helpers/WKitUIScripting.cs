using System;
using System.IO;
using Splat;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.Scripting;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;

namespace WolvenKit.App.Helpers;

public class WKitUIScripting : WKitScripting
{
    private readonly IProjectManager _projectManager;

    public WKitUIScripting(ILoggerService loggerService) : base(loggerService)
    {
        _projectManager = Locator.Current.GetService<IProjectManager>();
    }

    public virtual void SaveToProject(string path, CR2WFile cr2w)
    {
        var project = _projectManager.ActiveProject;
        if (project is Cp77Project cyberpunkProject)
        {
            FileInfo diskPathInfo = new(Path.Combine(cyberpunkProject.ModDirectory, path));
            if (diskPathInfo.Directory == null)
            {
                return;
            }

            if (!File.Exists(diskPathInfo.FullName))
            {
                Directory.CreateDirectory(diskPathInfo.Directory.FullName);
            }

            try
            {
                using FileStream fs = new(diskPathInfo.FullName, FileMode.Create);
                using CR2WWriter writer = new CR2WWriter(fs);
                writer.WriteFile(cr2w);
            }
            catch (Exception ex)
            {
                File.Delete(diskPathInfo.FullName);
                _loggerService.Error(ex);
            }
        }
    }

    public virtual void SaveToProject(string path, IGameFile gameFile)
    {
        var project = _projectManager.ActiveProject;
        if (project is Cp77Project cyberpunkProject)
        {
            FileInfo diskPathInfo = new(Path.Combine(cyberpunkProject.ModDirectory, path));
            if (diskPathInfo.Directory == null)
            {
                return;
            }

            if (!File.Exists(diskPathInfo.FullName))
            {
                Directory.CreateDirectory(diskPathInfo.Directory.FullName);
            }

            try
            {
                using FileStream fs = new(diskPathInfo.FullName, FileMode.Create);
                gameFile.Extract(fs);
            }
            catch (Exception ex)
            {
                File.Delete(diskPathInfo.FullName);
                _loggerService.Error(ex);
            }
        }
    }
}