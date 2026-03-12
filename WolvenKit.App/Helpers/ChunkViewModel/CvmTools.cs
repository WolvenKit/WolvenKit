using System.Collections.Generic;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Helpers;

public class CvmTools : ICvmTools
{
    private readonly CvmMaterialTools _cvmMaterialTools;
    private readonly CvmDependencyTools _cvmDependencyTools;

    public CvmTools(ILoggerService loggerService, INotificationService notificationService)
    {
        _cvmMaterialTools = new CvmMaterialTools(loggerService, notificationService);
        _cvmDependencyTools = new CvmDependencyTools(loggerService, notificationService);
    }

    #region CvmMaterialTools

    public void ConvertMaterialsFromPreload(ChunkViewModel? cvm) => _cvmMaterialTools.ConvertMaterialsFromPreload(cvm);

    public void ConvertMaterialsToPreload(ChunkViewModel? cvm) => _cvmMaterialTools.ConvertMaterialsToPreload(cvm);

    public void DeleteUnusedMaterials(ChunkViewModel cvm, AppViewModel? appViewModel = null,
        bool suppressLogOutput = false) =>
        _cvmMaterialTools.DeleteUnusedMaterials(cvm, appViewModel, suppressLogOutput);

    public void GenerateMissingMaterials(ChunkViewModel cvm, string baseMaterial, bool isLocal,
        bool resolveSubstitutions) =>
        _cvmMaterialTools.GenerateMissingMaterials(cvm, baseMaterial, isLocal, resolveSubstitutions);

    public void AdjustSubmeshCount(ChunkViewModel cvm) => _cvmMaterialTools.AdjustSubmeshCount(cvm);

    public void UnDynamifyMaterials(ChunkViewModel? cvm) => _cvmMaterialTools.UnDynamifyMaterials(cvm);

    public void AddMaterialAndDefinition(ChunkViewModel cvm, string newName) =>
        _cvmMaterialTools.AddMaterialAndDefinition(cvm, newName);

    public int FindHighestMaterialIndex(ChunkViewModel materialDefinitionArray, bool isLocalInstance) =>
        _cvmMaterialTools.FindHighestMaterialIndex(materialDefinitionArray, isLocalInstance);

    public void AddTagsToMeshAppearances(List<ChunkViewModel> chunks, List<string> tagList) =>
        _cvmMaterialTools.AddTagsToMeshAppearances(chunks, tagList);

    #endregion

    #region CvmDependencyTools

    public void RegenerateVisualControllers(ChunkViewModel? cvm)
    {
        cvm?.CalculatePropertiesRecursive();
        _cvmDependencyTools.RegenerateVisualControllers(cvm);
    }

    #endregion
}
