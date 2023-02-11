using WolvenKit.App.Models.Nodify;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.App.Factories;

public interface IChunkViewmodelFactory
{
    ChunkViewModel ChunkViewModel(IRedType rootChunk, ReferenceSocket socket);
    ChunkViewModel ChunkViewModel(IRedType rootChunk, RDTDataViewModel tab);
    ChunkViewModel ChunkViewModel(IRedType rootChunk, string name, ChunkViewModel? parent = null, bool isReadOnly = false);
}
