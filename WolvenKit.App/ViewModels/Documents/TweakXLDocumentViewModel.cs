using System;
using System.Threading.Tasks;

namespace WolvenKit.App.ViewModels.Documents;

public class TweakXLDocumentViewModel : DocumentViewModel
{
    public TweakXLDocumentViewModel(string path) : base(path)
    {
        //_isInitialized = OpenTweakFile(path);
    }

    public override Task Save(object parameter) => throw new NotImplementedException();
    public override void SaveAs(object parameter) => throw new NotImplementedException();
}
