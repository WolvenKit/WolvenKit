using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.Archive.CR2W;
using YamlDotNet.Serialization;

namespace WolvenKit.ViewModels.Documents
{
    public class TweakXLDocumentViewModel : DocumentViewModel
    {
        private readonly TweakDBService _tdbs;
        private readonly ISettingsManager _settingsManager;


        public TweakXLDocumentViewModel(string path) : base(path)
        {
            _tdbs = Locator.Current.GetService<TweakDBService>().NotNull();
            _settingsManager = Locator.Current.GetService<ISettingsManager>().NotNull();

            _isInitialized = OpenTweakFile(path);
        }

        public override Task OnSave(object parameter) => throw new NotImplementedException();

        public bool OpenTweakFile(string path)
        {
            throw new NotImplementedException();

            //using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            //{
            //    try
            //    {
            //        // read tweakXL file
            //        using var reader = new StreamReader(stream);
            //        var deserializer = new DeserializerBuilder()
            //            .WithTypeConverter(new TweakXLYamlTypeConverter())
            //            .Build();
            //        var file = deserializer.Deserialize<TweakXLFile>(reader);
            //        // TODO: enable when working on ChunkViewModel
            //        //TabItemViewModels.Add(new RDTDataViewModel(file, this));

            //        // read text file
            //        stream.Seek(0, SeekOrigin.Begin);
            //        TabItemViewModels.Add(new RDTTextViewModel(stream, this));

            //    }
            //    catch (Exception ex)
            //    {
            //        _loggerService.Error(ex);
            //        return false;
            //    }

            //    SelectedIndex = 0;
            //    SelectedTabItemViewModel = TabItemViewModels.FirstOrDefault();
            //}

            //return true;
        }


    }
}
