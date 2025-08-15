using WolvenKit.App.Models.Nodify;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.App.Factories;

public interface IChunkViewmodelFactory
{
    ChunkViewModel ChunkViewModel(IRedType rootChunk, string name, AppViewModel appViewModel,
        ChunkViewModel? parent = null, bool isReadOnly = false);

    ChunkViewModel ChunkViewModel(IRedType rootChunk, ReferenceSocket socket, AppViewModel appViewModel,
        bool isReadOnly = false);

    ChunkViewModel ChunkViewModel(IRedType rootChunk, RDTDataViewModel tab, AppViewModel appViewModel,
        bool isReadOnly = false);
}
