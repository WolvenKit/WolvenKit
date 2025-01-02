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
    protected override void SaveAs(SaveAsParameters saveParams) => throw new NotImplementedException();
    public override bool Reload(bool parameter) => throw new NotImplementedException();
}
