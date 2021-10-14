using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DynamicData.Kernel;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Model;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4.Compiled;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.ViewModels.Documents
{
    public enum ERedDocumentItemType
    {
        MainFile,
        W2rcBuffer,
        Buffer,
        Editor
    }


    public class RedDocumentViewModel : DocumentViewModel
    {

        private readonly ILoggerService _loggerService;
        private readonly Red4ParserService _parser;
        private readonly IHashService _hashService;


        public RedDocumentViewModel(string path) : base(path)
        {
            _loggerService = Locator.Current.GetService<ILoggerService>();
            _parser = Locator.Current.GetService<Red4ParserService>();
            _hashService = Locator.Current.GetService<IHashService>();
        }

        #region properties

        [Reactive] public ObservableCollection<RedDocumentItemViewModel> TabItemViewModels { get; set; } = new();

        [Reactive] public int SelectedIndex { get; set; }

        #endregion


        #region methods

        public override void OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            using var bw = new BinaryWriter(fs);
            var file = GetMainFile();
            if (file.HasValue)
            {
                // TODO gather buffers


                file.Value.GetFile().Write(bw);
            }
        }

        public override async Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;

            try
            {
                await using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using var reader = new BinaryReader(stream);

                    var cr2w = _parser.TryReadCr2WFile(reader);
                    if (cr2w == null)
                    {
                        _loggerService.Error($"Failed to read cr2w file {path}");
                        return false;
                    }
                    cr2w.FileName = path;

                    ContentId = path;
                    FilePath = path;
                    IsDirty = false;
                    Title = FileName;
                    _isInitialized = true;

                    PopulateItems(cr2w);
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

        private Optional<W2rcFileViewModel> GetMainFile() => Optional<W2rcFileViewModel>.ToOptional(TabItemViewModels
            .OfType<W2rcFileViewModel>()
            .Where(x => x.DocumentItemType == ERedDocumentItemType.MainFile)
            .FirstOrDefault());

        private void PopulateItems(IWolvenkitFile w2rcFile)
        {
            TabItemViewModels.Add(new W2rcFileViewModel(w2rcFile));

            // TODO reactive?
            foreach (var b in w2rcFile.Buffers)
            {
                if (b is CR2WBufferWrapper buffer)
                {
                    var data = buffer.GetData();

                    using var uncompressedMS = new MemoryStream();
                    using (var compressedMs = new MemoryStream(data))
                    {
                        OodleHelper.DecompressAndCopySegment(compressedMs, uncompressedMS, b.DiskSize, b.MemSize);
                    }

                    // try reading as normal cr2w file
                    var cr2wbuffer = _parser.TryReadCr2WFile(uncompressedMS);
                    if (cr2wbuffer != null)
                    {
                        TabItemViewModels.Add(new W2rcBufferViewModel(b, cr2wbuffer));
                    }
                    // try reading as compiled package
                    else
                    {
                        var compiledbuffer = new CompiledPackage(_hashService);
                        uncompressedMS.Seek(0, SeekOrigin.Begin);
                        using var br = new BinaryReader(uncompressedMS);
                        compiledbuffer.Read(br);
                        TabItemViewModels.Add(new W2rcBufferViewModel(b, compiledbuffer));
                    }
                }

            }

            SelectedIndex = 0;
        }

        #endregion


    }
}
