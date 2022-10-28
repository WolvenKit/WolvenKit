using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Reflection;
using System.Xml;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.DDS;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Other;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.Serialization;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using YamlDotNet.Serialization;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTTextViewModel : RedDocumentTabViewModel
    {
        protected readonly IRedType _data;

        public RDTTextViewModel(IRedType data, RedDocumentViewModel _) => throw new NotImplementedException();

        public RDTTextViewModel(Stream stream, RedDocumentViewModel file)
        {
            Header = "Source YAML";
            File = file;

            SetupText(stream);
        }

        private void SetupText(Stream stream)
        {
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

            var ext = Path.GetExtension(FilePath);
            var def = HighlightingManager.Instance.GetDefinitionByExtension("yaml");
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
    }
}
