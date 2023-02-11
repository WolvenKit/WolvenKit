using System.IO;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Factories;

public interface ITabViewmodelFactory
{
    public RDTTextureViewModel RDTTextureViewModel(RedBaseClass data, RedDocumentViewModel file);
    public RDTTextureViewModel RDTTextureViewModel(Stream stream, RedDocumentViewModel file);

    public RDTDataViewModel RDTDataViewModel(IRedType data, RedDocumentViewModel parent, AppViewModel appViewModel);
    public RDTDataViewModel RDTDataViewModel(string header, IRedType data, RedDocumentViewModel file, AppViewModel appViewModel);

    public RDTMeshViewModel RDTMeshViewModel(CMesh data, RedDocumentViewModel file);
    public RDTMeshViewModel RDTMeshViewModel(worldStreamingSector data, RedDocumentViewModel file);
    public RDTMeshViewModel RDTMeshViewModel(worldStreamingBlock data, RedDocumentViewModel file);
    public RDTMeshViewModel RDTMeshViewModel(entEntityTemplate data, RedDocumentViewModel file);
}
