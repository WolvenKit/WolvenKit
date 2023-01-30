using System;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData.Binding;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTTextViewModel : RedDocumentTabViewModel
{
    //protected readonly IRedType _data;

    public RDTTextViewModel(Stream stream, RedDocumentViewModel parent) : base(parent, "Source YAML")
    {
        using var sr = new StreamReader(stream);
        _document = new TextDocument(sr.ReadToEnd());
        TextEditorOptions = new TextEditorOptions
        {
            IndentationSize = 2,
            ConvertTabsToSpaces = true,
            EnableHyperlinks = false,
            EnableEmailHyperlinks = false
        };

        _highlightingDefinition = HighlightingManager.Instance.GetDefinitionByExtension(Path.GetExtension(FilePath));

        this.WhenAnyPropertyChanged(nameof(IsDirty))
            .Do(x => x?.Parent.SetIsDirty(IsDirty))
            .Subscribe();
    }

    public override void OnSelected()
    {
        // serialize from Data tab
        //if (File is TweakXLDocumentViewModel tweakFile)
        {
            // TODO: enable when working on ChunkViewModel
            // get data tab
            //var tab = tweakFile.TabItemViewModels.OfType<RDTDataViewModel>().FirstOrDefault();
            //var obj = tab.GetData();
            //using var writer = new StringWriter();
            //var serializer = new SerializerBuilder()
            //    .WithTypeConverter(new TweakXLYamlTypeConverter())
            //    .Build();
            //var file = serializer.Serialize(obj);

            // refresh

        }
    }

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

    [ObservableProperty] private TextDocument _document;
    [ObservableProperty] private IHighlightingDefinition _highlightingDefinition;
    public TextEditorOptions TextEditorOptions { get; protected set; }

    public string GetText() => Document.Text;
    [ObservableProperty] private bool _isDirty;
}
