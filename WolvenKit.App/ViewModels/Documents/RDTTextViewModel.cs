using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using DynamicData.Binding;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTTextViewModel : RedDocumentTabViewModel, INotifyPropertyChanged
    {
        //protected readonly IRedType _data;

        public RDTTextViewModel(Stream stream, RedDocumentViewModel file) : base(file, "Source YAML")
        {
            SetupText(stream);

            this.WhenAnyPropertyChanged(nameof(IsDirty))
                .Do(x =>
                {
                    x?.File.SetIsDirty(IsDirty);
                })
                .Subscribe();
        }

        [MemberNotNull(nameof(Document))]
        [MemberNotNull(nameof(HighlightingDefinition))]
        [MemberNotNull(nameof(TextEditorOptions))]
        private void SetupText(Stream stream)
        {
            using var sr = new StreamReader(stream);
            Document = new TextDocument(sr.ReadToEnd());
            TextEditorOptions = new TextEditorOptions
            {
                IndentationSize = 2,
                ConvertTabsToSpaces = true,
                EnableHyperlinks = false,
                EnableEmailHyperlinks = false
            };

            HighlightingDefinition = HighlightingManager.Instance.GetDefinitionByExtension(Path.GetExtension(FilePath));
        }

        public override void OnSelected()
        {
            // serialize from Data tab
            if (File is TweakXLDocumentViewModel tweakFile)
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

        [Reactive] public TextDocument Document { get; set; }
        [Reactive] public IHighlightingDefinition HighlightingDefinition { get; protected set; }
        public TextEditorOptions TextEditorOptions { get; protected set; }

        public string GetText() => Document.Text;
        [Reactive] public bool IsDirty { get; protected set; }
    }
}
