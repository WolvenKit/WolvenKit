using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Models;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Documents;
using YamlDotNet.Serialization;

namespace WolvenKit.ViewModels.Documents
{
    public class TweakXLDocumentViewModel : RedDocumentViewModel
    {
        private TweakDBService _tdbs;

        public TweakXLDocumentViewModel(string path) : base(path) => _tdbs = Locator.Current.GetService<TweakDBService>();

        public override bool OpenFile(string path)
        {
            _isInitialized = false;

            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                FilePath = path;

                try
                {
                    // read tweakXL file
                    using var reader = new StreamReader(stream);
                    var deserializer = new DeserializerBuilder()
                        .WithTypeConverter(new TweakXLYamlTypeConverter())
                        .Build();
                    var file = deserializer.Deserialize<TweakXLFile>(reader);
                    TabItemViewModels.Add(new RDTDataViewModel(file, this));

                    // read text file
                    stream.Seek(0, SeekOrigin.Begin);
                    TabItemViewModels.Add(new RDTTextViewModel(stream, this));

                }
                catch (Exception ex)
                {
                    _loggerService.Error(ex);
                    return false;
                }

                _isInitialized = true;

                SelectedIndex = 0;
                SelectedTabItemViewModel = TabItemViewModels.FirstOrDefault();
            }

            return true;
        }
    }
}
