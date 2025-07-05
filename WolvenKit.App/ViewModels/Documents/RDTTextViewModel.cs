using System;
using System.IO;
using System.Reactive.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData.Binding;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTTextViewModel : RedDocumentTabViewModel
{
    //protected readonly IRedType _data;

    public RDTTextViewModel(Stream stream, RedDocumentViewModel parent) : base(parent, "Source YAML")
    {
        using var sr = new StreamReader(stream);
        _text = sr.ReadToEnd();

        this.WhenAnyPropertyChanged(nameof(IsDirty))
            .Do(x => x?.Parent.SetIsDirty(IsDirty))
            .Subscribe();
    }

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

    [ObservableProperty] private string _text;

    public string GetText() => Text;
    [ObservableProperty] private bool _isDirty;
}
