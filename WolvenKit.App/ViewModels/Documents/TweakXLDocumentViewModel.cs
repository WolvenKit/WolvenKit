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

            try
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using var reader = new StreamReader(stream);

                    var deserializer = new DeserializerBuilder()
                        .WithTypeConverter(new TweakXLYamlTypeConverter())
                        .Build();

                    var file = deserializer.Deserialize<TweakXLFile>(reader);
                    if (file == null)
                    {
                        return false;
                    }

                    FilePath = path;
                    _isInitialized = true;

                    TabItemViewModels.Add(new RDTDataViewModel(file, this));

                    SelectedIndex = 0;

                    SelectedTabItemViewModel = TabItemViewModels.FirstOrDefault();
                }

                return true;
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
                // Not processing this catch in any other way than rejecting to initialize this
                _isInitialized = false;
            }

            return false;
        }
    }
}
