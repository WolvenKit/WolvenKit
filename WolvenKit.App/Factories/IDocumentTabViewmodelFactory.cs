using System.IO;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Factories;

public interface IDocumentTabViewmodelFactory
{
    public RDTInkTextureAtlasViewModel RDTInkTextureAtlasViewModel(inkTextureAtlas atlas, CBitmapTexture xbm, RedDocumentViewModel file);

    public RDTTextureViewModel RDTTextureViewModel(RedBaseClass data, RedDocumentViewModel file);
    public RDTTextureViewModel RDTTextureViewModel(Stream stream, RedDocumentViewModel file);

    public RDTDataViewModel RDTDataViewModel(IRedType data, RedDocumentViewModel parent, AppViewModel appViewModel, IChunkViewmodelFactory chunkViewmodelFactory);
    public RDTDataViewModel RDTDataViewModel(string header, IRedType data, RedDocumentViewModel file, AppViewModel appViewModel, IChunkViewmodelFactory chunkViewmodelFactory);

    public RDTMeshViewModel RDTMeshViewModel(CMesh data, RedDocumentViewModel file);
    public RDTMeshViewModel RDTMeshViewModel(worldStreamingSector data, RedDocumentViewModel file);
    public RDTMeshViewModel RDTMeshViewModel(worldStreamingBlock data, RedDocumentViewModel file);
    public RDTMeshViewModel RDTMeshViewModel(entEntityTemplate data, RedDocumentViewModel file);
}
