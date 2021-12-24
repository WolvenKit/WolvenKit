using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using DynamicData;
using DynamicData.Kernel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.RED4.Compiled;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
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
        public CR2WFile Cr2wFile;


        public RedDocumentViewModel(string path) : base(path)
        {
            _loggerService = Locator.Current.GetService<ILoggerService>();
            _parser = Locator.Current.GetService<Red4ParserService>();
            _hashService = Locator.Current.GetService<IHashService>();
            RelativePath = path;
            Extension = Path.GetExtension(path).Substring(1);
        }

        #region properties

        [Reactive] public ObservableCollection<RedDocumentItemViewModel> TabItemViewModels { get; set; } = new();

        [Reactive] public int SelectedIndex { get; set; }

        [Reactive] public RedDocumentItemViewModel SelectedTabItemViewModel { get; set; }

        [Reactive] public string RelativePath { get; set; }

        [Reactive] public string Extension { get; set; }

        #endregion


        #region methods

        public override Task OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            var file = GetMainFile();
            if (file.HasValue)
            {
                // TODO gather buffers
                var resource = Cr2wFile;
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

        public bool OpenStream(Stream stream, string path)
        {
            using var reader = new BinaryReader(stream);

            Cr2wFile = _parser.TryReadRed4File(reader);
            if (Cr2wFile == null)
            {
                _loggerService.Error($"Failed to read cr2w file {path}");
                return false;
            }
            //cr2w.FileName = path;

            // already set by base()?
            //ContentId = path;
            FilePath = path;
            _isInitialized = true;

            PopulateItems();
            return true;
        }

        public override bool OpenFile(string path)
        {
            _isInitialized = false;

            try
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    OpenStream(stream, path);
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
                    OpenStream(stream, path);
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

        private void PopulateItems()
        {
            TabItemViewModels.Add(new W2rcFileViewModel(Cr2wFile.RootChunk, this));
            if (Cr2wFile.RootChunk is CBitmapTexture xbm)
            {
                TabItemViewModels.Add(new TextureViewModel(xbm, this));
            }
            if (Cr2wFile.RootChunk is inkTextureAtlas atlas)
            {
                var xbmHash = FNV1A64HashAlgorithm.HashString(atlas.Slots[0].Texture.DepotPath.ToString());
                var file = GetFileFromHash(xbmHash);
                if (file != null)
                {
                    TabItemViewModels.Add(new InkTextureAtlasViewModel(atlas, (CBitmapTexture)file.RootChunk, this));
                }
            }

            SelectedIndex = 0;

            SelectedTabItemViewModel = TabItemViewModels.FirstOrDefault();
        }

        private CR2WFile GetFileFromHash(ulong hash)
        {
            // TODO: need to look locally first
            var _archiveManager = Locator.Current.GetService<IArchiveManager>();
            var file = _archiveManager.Lookup(hash);
            if (file.HasValue && file.Value is FileEntry fe)
            {
                CR2WFile cr2wFile = null;
                using (var stream = new MemoryStream())
                {
                    fe.Extract(stream);
                    using var reader = new BinaryReader(stream);
                    cr2wFile = _parser.TryReadRed4File(reader);
                }

                return cr2wFile;
            }
            return null;
        }

        #endregion

    }
}

