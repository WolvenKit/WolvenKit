using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Archive.CR2W;

namespace WolvenKit.App.Factories;
public interface IDocumentViewmodelFactory
{
    public RedDocumentViewModel RedDocumentViewModel(CR2WFile file, string path, AppViewModel appViewModel);

    public WScriptDocumentViewModel WScriptDocumentViewModel(string path);

    public TweakXLDocumentViewModel TweakXLDocumentViewModel(string path);
}
