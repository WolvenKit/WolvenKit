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
    public class TweakXLDocumentViewModel : RedDocumentViewModel
    {
        private readonly TweakDBService _tdbs;
        private readonly ISettingsManager _settingsManager;


        public TweakXLDocumentViewModel(CR2WFile file, string path) : base(file, path)
        {
            _tdbs = Locator.Current.GetService<TweakDBService>().NotNull();
            _settingsManager = Locator.Current.GetService<ISettingsManager>().NotNull();
        }

        private Task LoadTweakDB()
        {
            if (_tdbs.IsLoaded)
            {
                return Task.CompletedTask;
            }

            return _tdbs.LoadDB(Path.Combine(_settingsManager.GetRED4GameRootDir(), "r6", "cache", "tweakdb.bin"));
        }

        
    }
}
