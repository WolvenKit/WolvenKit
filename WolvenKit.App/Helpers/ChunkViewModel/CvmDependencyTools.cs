using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

/// <summary>
/// Class holds
/// </summary>
public class CvmDependencyTools
{
    private readonly ILoggerService _loggerService;
    private readonly INotificationService _notificationService;

    public CvmDependencyTools(
        ILoggerService loggerService,
        INotificationService notificationService
    )
    {
        _notificationService = notificationService;
        _loggerService = loggerService;
    }

    public void RegenerateVisualControllers(ChunkViewModel? cvm)
    {
        if (cvm is null)
        {
            return;
        }

        if (cvm.ResolvedData is RedDummy)
        {
            cvm.CalculateProperties();
        }

        switch (cvm.ResolvedData)
        {
            case appearanceAppearanceDefinition when cvm.GetPropertyChild("components") is { } components:
                RegenerateVisualControllers(components);
                return;
            case appearanceAppearanceResource when cvm.GetPropertyChild("appearances") is { } appearances:
            {
                RegenerateVisualControllers(appearances);
                return;
            }
            case CArray<CHandle<appearanceAppearanceDefinition>>:
                foreach (var chunkViewModel in cvm.TVProperties)
                {
                    RegenerateVisualControllers(chunkViewModel);
                }

                return;
            case CArray<entIComponent> arr:
                Regenerate(arr);
                return;
            case RedDummy:
                // this shouldn't happen, but issue #2806 ran into a case where a component array kept being a
                // RedDummy despite TVProperties being correctly initialized. Adding the check just in case.
                if (cvm.Data is CArray<entIComponent> ary)
                {
                    Regenerate(ary);
                }

                return;
            default:
                _notificationService.Warning(
                    "Can't regenerate visual controllers. Please check the log for more detail.");
                _loggerService.Warning(
                    $"Failed to regenerate visual controllers on {cvm.ResolvedData.GetType().Name}. " +
                    "Select one or more appearances, the appearances array, or the root node.");

                return;
        }

        void Regenerate(CArray<entIComponent> arr)
        {
            entVisualControllerComponent? vc = null;
            var list = new CArray<entVisualControllerDependency>();

            var hasChange = false;
            foreach (var component in arr)
            {
                switch (component)
                {
                    case entMeshComponent mesh when
                        mesh.LODMode == Enums.entMeshComponentLODMode.Appearance &&
                        mesh.Mesh.DepotPath != ResourcePath.Empty:
                        list.Add(new entVisualControllerDependency()
                        {
                            AppearanceName = mesh.MeshAppearance, ComponentName = mesh.Name, Mesh = mesh.Mesh
                        });

                        hasChange = true;
                        break;
                    case entSkinnedMeshComponent skinnedMesh when
                        skinnedMesh.LODMode == Enums.entMeshComponentLODMode.Appearance &&
                        skinnedMesh.Mesh.DepotPath != ResourcePath.Empty:
                        list.Add(new entVisualControllerDependency()
                        {
                            AppearanceName = skinnedMesh.MeshAppearance,
                            ComponentName = skinnedMesh.Name,
                            Mesh = skinnedMesh.Mesh
                        });
                        hasChange = true;
                        break;
                    case entSkinnedClothComponent skinnedCloth when
                        skinnedCloth.LODMode == Enums.entMeshComponentLODMode.Appearance:
                        list.Add(new entVisualControllerDependency()
                        {
                            AppearanceName = skinnedCloth.MeshAppearance,
                            ComponentName = skinnedCloth.Name,
                            Mesh = skinnedCloth.GraphicsMesh
                        });

                        list.Add(new entVisualControllerDependency()
                        {
                            AppearanceName = "default",
                            ComponentName = skinnedCloth.Name,
                            Mesh = skinnedCloth.PhysicalMesh
                        });
                        hasChange = true;
                        break;
                    case entVisualControllerComponent c3:
                        vc = c3;
                        hasChange = true;
                        break;
                }
            }

            if (!hasChange)
            {
                return;
            }

            if (vc != null)
            {
                vc.AppearanceDependency = list;
                cvm.RecalculateProperties();
            }

            cvm.Tab?.Parent.SetIsDirty(true);
        }
    }
}
