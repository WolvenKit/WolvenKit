using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;
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

    public int RegenerateVisualControllers(ChunkViewModel? cvm)
    {
        if (cvm is null)
        {
            return 0;
        }

        if (cvm.ResolvedData is RedDummy)
        {
            cvm.CalculateProperties();
        }

        switch (cvm.ResolvedData)
        {
            case appearanceAppearanceDefinition when cvm.GetPropertyChild("components") is { } components:
                return RegenerateVisualControllers(components);
            case appearanceAppearanceResource when cvm.GetPropertyChild("appearances") is { } appearances:
            {
                return RegenerateVisualControllers(appearances);
            }
            case CArray<CHandle<appearanceAppearanceDefinition>>:
                var totalChanges = 0;
                foreach (var chunkViewModel in cvm.TVProperties)
                {
                    totalChanges += RegenerateVisualControllers(chunkViewModel);
                }
                return totalChanges;

            case CArray<entIComponent> arr:
                var changedComponents = Regenerate(arr);
                _notificationService.Success($"Recalculated {changedComponents} dependencies");
                return changedComponents;
            case RedDummy:
                var numChanged = 0;

                // this shouldn't happen, but issue #2806 ran into a case where a component array kept being a
                // RedDummy despite TVProperties being correctly initialized. Adding the check just in case.
                if (cvm.Data is CArray<entIComponent> ary)
                {
                    numChanged = Regenerate(ary);
                    _notificationService.Success($"Recalculated {numChanged} dependencies");
                }

                return numChanged;
            default:
                throw new WolvenKitException(0, $"Failed to regenerate visual controllers on {cvm.ResolvedData.GetType().Name}. " +
                                                "Select one or more appearances, the appearances array, or the root node.");
        }

        int Regenerate(CArray<entIComponent> arr)
        {
            entVisualControllerComponent? vc = null;
            var list = new CArray<entVisualControllerDependency>();

            var numChanged = 0;
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

                        numChanged++;
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
                        numChanged++;
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
                        numChanged++;
                        break;
                    case entVisualControllerComponent c3:
                        vc = c3;
                        numChanged++;
                        break;
                }
            }

            if (numChanged == 0 && vc != null)
            {
                return 0;
            }

            if (vc == null)
            {
                vc = new entVisualControllerComponent();
                arr.Add(vc);
            }

            vc.AppearanceDependency = list;
            cvm.RecalculateProperties();

            cvm.Tab?.Parent.SetIsDirty(true);

            return numChanged;
        }
    }
}
