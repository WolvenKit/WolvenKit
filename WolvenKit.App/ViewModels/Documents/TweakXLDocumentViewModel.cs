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

            //_isInitialized = OpenTweakFile(path);
        }

        public override Task Save(object parameter) => throw new NotImplementedException();
        public override void SaveAs(object parameter) => throw new NotImplementedException();
    }
}
