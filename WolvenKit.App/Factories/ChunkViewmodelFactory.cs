using WolvenKit.App.Controllers;
using WolvenKit.App.Models.Nodify;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Services;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Core.Services;

namespace WolvenKit.App.Factories;

public interface IFactory<T> where T : class
{

}

public class ChunkViewmodelFactory(
    IDocumentTabViewmodelFactory tabViewmodelFactory,
    IHashService hashService,
    ILoggerService loggerService,
    IProjectManager projectManager,
    IGameControllerFactory gameController,
    ISettingsManager settingsManager,
    IAppArchiveManager archiveManager,
    ITweakDBService tweakDbService,
    ILocKeyService locKeyService,
    IModifierViewStateService modifierViewStateService,
    Red4ParserService parserService,
    CRUIDService cruidService)
    : IChunkViewmodelFactory, IFactory<ChunkViewModel>
{
    public ChunkViewModel ChunkViewModel(IRedType rootChunk, string name, AppViewModel appViewModel,
        EditorDifficultyLevel editorDifficultyLevel, ChunkViewModel? parent = null, bool isReadOnly = false) =>
        new ChunkViewModel(rootChunk, name, appViewModel,
            this,
            tabViewmodelFactory,
            hashService,
            loggerService,
            projectManager,
            gameController,
            settingsManager,
            archiveManager,
            tweakDbService,
            locKeyService,
            modifierViewStateService,
            parserService,
            cruidService,
            editorDifficultyLevel,
            parent,
            isReadOnly).SetInitialExpansionState();

    public ChunkViewModel ChunkViewModel(IRedType rootChunk, ReferenceSocket socket, AppViewModel appViewModel,
        EditorDifficultyLevel editorDifficultyLevel, bool isReadOnly = false) =>
        new ChunkViewModel(rootChunk, socket, appViewModel,
            this,
            tabViewmodelFactory,
            hashService,
            loggerService,
            projectManager,
            gameController,
            settingsManager,
            archiveManager,
            tweakDbService,
            locKeyService,
            modifierViewStateService,
            parserService,
            cruidService,
            editorDifficultyLevel,
            isReadOnly).SetInitialExpansionState();

    public ChunkViewModel ChunkViewModel(IRedType rootChunk, RDTDataViewModel tab, AppViewModel appViewModel,
        EditorDifficultyLevel editorDifficultyLevel, bool isReadOnly = false) =>
        new ChunkViewModel(rootChunk, tab, appViewModel,
            this,
            tabViewmodelFactory,
            hashService,
            loggerService,
            projectManager,
            gameController,
            settingsManager,
            archiveManager,
            tweakDbService,
            locKeyService,
            modifierViewStateService,
            parserService,
            cruidService,
            editorDifficultyLevel, 
            isReadOnly).SetInitialExpansionState();
}