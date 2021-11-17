using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DynamicData.Kernel;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.RED4.Compiled;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

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

        [Reactive] public RedDocumentItemViewModel SelectedTabItemViewModel { get; set; }

        #endregion


        #region methods

        public override Task OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            var file = GetMainFile();
            if (file.HasValue)
            {
                // TODO gather buffers
                var resource = file.Value.GetFile();
                if (resource is CR2WFile cr2w)
                {
                    using var writer = new CR2WWriter(fs);
                    writer.WriteFile(cr2w);

                    SetIsDirty(false);
                    _loggerService.Success($"Saved file {FilePath}");
                }
                //throw new ArgumentException();
            }

            return Task.CompletedTask;
        }

        public override bool OpenFile(string path)
        {
            _isInitialized = false;

            try
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using var reader = new BinaryReader(stream);

                    var cr2w = _parser.TryReadRed4File(reader);
                    if (cr2w == null)
                    {
                        _loggerService.Error($"Failed to read cr2w file {path}");
                        return false;
                    }
                    //cr2w.FileName = path;

                    ContentId = path;
                    FilePath = path;
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

        public override async Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;

            try
            {
                await using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using var reader = new BinaryReader(stream);

                    var cr2w = _parser.TryReadRed4File(reader);
                    if (cr2w == null)
                    {
                        _loggerService.Error($"Failed to read cr2w file {path}");
                        return false;
                    }
                    //cr2w.FileName = path;

                    ContentId = path;
                    FilePath = path;
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

        private void PopulateItems(CR2WFile w2rcFile)
        {
            TabItemViewModels.Add(new W2rcFileViewModel(w2rcFile as Red4File));

            foreach (var buffer in w2rcFile.Buffers)
            {
                //if (b is CR2WBufferWrapper buffer)
                {
                    var data = buffer.Data;

                    using var uncompressedMS = new MemoryStream();
                    using (var compressedMs = new MemoryStream(data))
                    {
                        OodleHelper.DecompressAndCopySegment(compressedMs, uncompressedMS, (uint)data.Length, buffer.MemSize);

                        //dbg
                        //var bufferpath = $"{w2rcFile.FileName}.{(w2rcFile as CR2WFile).GetBufferIndex(b)}.buffer";
                        //using (var fs = new FileStream(bufferpath, FileMode.Create, FileAccess.Write))
                        //{
                        //    uncompressedMS.CopyTo(fs);
                        //}
                    }

                    // try reading as normal cr2w file
                    var cr2wbuffer = _parser.TryReadRed4File(uncompressedMS);
                    if (cr2wbuffer != null)
                    {
                        TabItemViewModels.Add(new W2rcBufferViewModel(buffer, cr2wbuffer, w2rcFile));
                    }
                    // try reading as compiled package
                    else
                    {
                        uncompressedMS.Seek(0, SeekOrigin.Begin);
                        var compiledPackage = _parser.TryReadCompiledPackage(uncompressedMS);
                        if (compiledPackage != null)
                        {
                            TabItemViewModels.Add(new W2rcBufferViewModel(buffer, compiledPackage, w2rcFile));
                        }
                    }
                }

            }

            SelectedIndex = 0;

            SelectedTabItemViewModel = TabItemViewModels.FirstOrDefault();
        }

        #endregion


    }
}
