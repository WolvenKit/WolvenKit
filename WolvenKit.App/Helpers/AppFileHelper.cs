using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public class AppFileHelper
{
    /// <summary>
    /// Deletes mesh components from all .app files inside a project if they reference a certain mesh.
    /// </summary>
    /// <param name="cr2wTools"></param>
    /// <param name="activeProject"></param>
    /// <param name="loggerService"></param>
    /// <param name="filePaths"></param>
    public static List<string> DeleteMeshComponentsByReference(
        Cr2WTools cr2wTools,
        Cp77Project activeProject,
        List<string> filePaths
    )
    {
        List<string> changedFilePaths = new List<string>();
        foreach (var filePath in activeProject.ModFiles.Where(f => f.EndsWith(".app")))
        {
            var cr2w = cr2wTools.ReadCr2W(activeProject.GetAbsolutePath(filePath));
            if (cr2w?.RootChunk is not appearanceAppearanceResource appFile)
            {
                continue;
            }

            foreach (var appearance in appFile.Appearances
                         .Where(app => app.Chunk is not null)
                         .Select(app => app.Chunk!))
            {
                List<entIComponent> components = appearance.Components.Where(component =>
                {
                    switch (component)
                    {
                        case entSkinnedMeshComponent skinnedMeshComponent:
                            return skinnedMeshComponent.Mesh.DepotPath.GetResolvedText() is not string meshPath ||
                                   meshPath == "" || !filePaths.Contains(meshPath);

                        case entMeshComponent meshComponent:
                            return meshComponent.Mesh.DepotPath.GetResolvedText() is not string path ||
                                   path == "" || !filePaths.Contains(path);
                        default:
                            return true;
                    }
                }).ToList();
                if (components.Count() == appearance.Components.Count())
                {
                    continue;
                }

                appearance.Components.Clear();

                foreach (var component in components)
                {
                    appearance.Components.Add(component);
                }

                cr2wTools.WriteCr2W(cr2w, activeProject.GetAbsolutePath(filePath));

                changedFilePaths.Add(filePath);
            }
        }

        return changedFilePaths;
    }


    public static List<string> DeleteUnusedAnimComponents(Cr2WTools cr2wTools,
        Cp77Project activeProject,
        List<string> filePaths)
    {
        var changedFilePaths = new List<string>();
        foreach (var filePath in filePaths)
        {
            var cr2w = cr2wTools.ReadCr2W(activeProject.GetAbsolutePath(filePath));
            if (cr2w?.RootChunk is not appearanceAppearanceResource appFile)
            {
                continue;
            }

            HashSet<string> usedNames = [];
            var wasChanged = false;

            foreach (var appearance in appFile.Appearances
                         .Where(app => app.Chunk is not null)
                         .Select(app => app.Chunk!))
            {
                foreach (var component in appearance.Components.OfType<entSkinnedMeshComponent>())
                {
                    if (component.ParentTransform?.Chunk is entITransformBinding { BindName: var bindName } &&
                        bindName.GetResolvedText() is string s && s != "")
                    {
                        usedNames.Add(s);
                    }

                    if (component.Skinning?.Chunk is entSkinningBinding { BindName: var skinning } &&
                        skinning.GetResolvedText() is string st && st != "")
                    {
                        usedNames.Add(st);
                    }
                }

                var usedComponents = appearance.Components.Where(comp =>
                        comp is not entAnimatedComponent || comp.Name.GetResolvedText() is not string s ||
                        usedNames.Contains(s))
                    .ToList();

                if (usedComponents.Count() == appearance.Components.Count())
                {
                    continue;
                }

                wasChanged = true;
                appearance.Components.Clear();
                foreach (var entIComponent in usedComponents)
                {
                    appearance.Components.Add(entIComponent);
                }
            }

            if (!wasChanged)
            {
                continue;
            }

            changedFilePaths.Add(filePath);
            cr2wTools.WriteCr2W(cr2w, activeProject.GetAbsolutePath(filePath));
        }

        return changedFilePaths;
    }
}