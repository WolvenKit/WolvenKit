using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.ViewModels.Documents
{
    public enum ERedDocumentItemType
    {
        MainFile,
        W2rcBuffer,
        PackageBuffer,
        Editor
    }


    public class RedDocumentViewModel : DocumentViewModel
    {
        
        private readonly ILoggerService _loggerService;
        private readonly Red4ParserService _wolvenkitFileService;
        

        public RedDocumentViewModel(string path) : base(path)
        {
            _loggerService = Locator.Current.GetService<ILoggerService>();
            _wolvenkitFileService = Locator.Current.GetService<Red4ParserService>();
        }

        #region properties

        [Reactive] public ObservableCollection<RedDocumentItemViewModel> TabItemViewModels { get; set; } = new();

        [Reactive] public IWolvenkitFile File { get; set; }

        #endregion


        #region methods

        public override void OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            using var bw = new BinaryWriter(fs);
            File.Write(bw);
        }

        public override async Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;

            try
            {
                await using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using var reader = new BinaryReader(stream);

                    var cr2w = _wolvenkitFileService.TryReadCr2WFile(reader);
                    if (cr2w == null)
                    {
                        _loggerService.Error($"Failed to read cr2w file {path}");
                        return false;
                    }
                    cr2w.FileName = path;

                    File = cr2w;

                    ContentId = path;
                    FilePath = path;
                    IsDirty = false;
                    Title = FileName;
                    _isInitialized = true;

                    PopulateItems();
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

        private void PopulateItems()
        {
            TabItemViewModels.Add(new MainFileViewModel(File));

            // TODO reactive?
            foreach (var buffer in File.Buffers)
            {
                TabItemViewModels.Add(new W2rcBufferViewModel(buffer));
            }
        }

        #endregion


    }
}
