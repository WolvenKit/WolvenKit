using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Documents;
using YamlDotNet.Serialization;

namespace WolvenKit.ViewModels.Documents
{
    public class TweakYAMLDocumentViewModel : RedDocumentViewModel
    {
        public TweakYAMLDocumentViewModel(string path) : base(path)
        {

        }

        public override bool OpenFile(string path)
        {
            _isInitialized = false;

            try
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    //using var reader = new StreamReader(stream);

                    //var deserializer = new DeserializerBuilder().Build();

                    //deserializer.Deserialize(reader);


                    FilePath = path;
                    _isInitialized = true;

                    TabItemViewModels.Add(new RDTDataViewModel((TweakDBID)"Vehicle.v_sport2_quadra_type66", this));

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
