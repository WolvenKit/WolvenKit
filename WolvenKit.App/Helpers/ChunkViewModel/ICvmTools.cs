using System.Collections.Generic;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.Helpers;

public interface ICvmTools
{
    #region CvmMaterialTools

    void ConvertMaterialsFromPreload(ChunkViewModel? cvm);
    void ConvertMaterialsToPreload(ChunkViewModel? cvm);

    void DeleteUnusedMaterials(ChunkViewModel cvm, AppViewModel? appViewModel = null,
        bool suppressLogOutput = false);

    void GenerateMissingMaterials(ChunkViewModel cvm, string baseMaterial, bool isLocal,
        bool resolveSubstitutions);

    void AdjustSubmeshCount(ChunkViewModel cvm);
    void UnDynamifyMaterials(ChunkViewModel? cvm);
    void AddMaterialAndDefinition(ChunkViewModel cvm, string newName);
    int FindHighestMaterialIndex(ChunkViewModel materialDefinitionArray, bool isLocalInstance);
    void AddTagsToMeshAppearances(List<ChunkViewModel> chunks, List<string> tagList);

    void FlattenMiChain(ChunkViewModel? cvm, IAppArchiveManager archiveManager, Cp77Project? project);
    #endregion

    #region CvmDependencyTools

    public void RegenerateVisualControllers(ChunkViewModel? cvm);

    #endregion
}
