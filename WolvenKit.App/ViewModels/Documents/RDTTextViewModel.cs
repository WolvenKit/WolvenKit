using DynamicData.Binding;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reflection;
using System.Xml;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Models;
using WolvenKit.RED4.Types;
using YamlDotNet.Serialization;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTTextViewModel : RedDocumentTabViewModel, INotifyPropertyChanged
    {
        protected readonly IRedType _data;

        public RDTTextViewModel(IRedType data, RedDocumentViewModel _) => throw new NotImplementedException();

        public RDTTextViewModel(Stream stream, RedDocumentViewModel file)
        {
            Header = "Source YAML";
            File = file;
            FilePath = file.FilePath;

            SetupText(stream);

            this.WhenAnyPropertyChanged(nameof(IsDirty))
                .Do(x =>
                {
                    x.File.SetIsDirty(IsDirty);
                })
                .Subscribe();
        }

        private void SetupText(Stream stream)
        {
            // register the custom highlighting for YAML files
            using (var xshdStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"WolvenKit.App.Resources.YAML.xhsd"))
            {
                var xmlreader = XmlReader.Create(xshdStream);

                var hlManager = HighlightingManager.Instance;
                var hlXshdDef = HighlightingLoader.LoadXshd(xmlreader);
                var hlDef = HighlightingLoader.Load(hlXshdDef, hlManager);

                hlManager.RegisterHighlighting("yaml", new string[]
                {
                "yaml",
                "yml",
                "xl"
                }, hlDef);
            };

            using var sr = new StreamReader(stream);
            Document = new TextDocument(sr.ReadToEnd());

            var ext = Path.GetExtension(FilePath).Substring(1);
            var def = HighlightingManager.Instance.GetDefinitionByExtension(ext);
            if (def != null)
            {
                HighlightingDefinition = def;
            }
        }

        public override void OnSelected()
        {
            // serialize from Data tab
            if (File is TweakXLDocumentViewModel tweakFile)
            {
                // get data tab
                var tab = tweakFile.TabItemViewModels.OfType<RDTDataViewModel>().FirstOrDefault();
                var obj = tab.GetData();

                using var writer = new StringWriter();
                var serializer = new SerializerBuilder()
                    .WithTypeConverter(new TweakXLYamlTypeConverter())
                    .Build();
                //var file = serializer.Serialize(obj);

                // refresh

            }
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        [Reactive] public TextDocument Document { get; set; }
        [Reactive] public IHighlightingDefinition HighlightingDefinition { get; set; }

        public string GetText() => Document.Text;
        [Reactive] public bool IsDirty { get; protected set; }
    }
}
