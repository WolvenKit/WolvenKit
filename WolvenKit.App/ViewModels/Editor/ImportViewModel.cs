using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Catel;
using Catel.Services;
using Catel.Threading;
using CsvHelper;
using WolvenKit.Common;
using WolvenKit.Functionality.Services;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Models;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED3.CR2W;
using WolvenKit.RED3.CR2W.Types;

namespace WolvenKit.ViewModels.Editor
{
    public class ImportViewModel : ToolViewModel
    {
        #region Fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "Import_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Import";

        private readonly ILoggerService _loggerService;
        private readonly IMessageService _messageService;
        private readonly IProjectManager _projectManager;
        private readonly ISettingsManager _settingsManager;
        private readonly IWccService _wccService;


        private readonly List<string> importableexts = Enum.GetNames(typeof(EImportable)).Select(_ => $".{_}".ToLower()).ToList();

        private readonly Dictionary<string, XBMDumpRecord> xbmdict;
        private DirectoryInfo importdepot;

        #endregion Fields

        #region constructors

        public ImportViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IMessageService messageService,
            IWccService wccService,
            ISettingsManager settingsManager
        ) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => wccService);
            Argument.IsNotNull(() => settingsManager);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            _wccService = wccService;
            _settingsManager = settingsManager;

            SetupCommands();
            SetupToolDefaults();

            Importableobjects = new BindingList<ImportableFile>();
            UseLocalResourcesCommand.SafeExecute();
            xbmdict = new Dictionary<string, XBMDumpRecord>();
            RegisterXBMDump();
        }

        #endregion constructors

        

        //void Importableobjects_ListChanged(object sender, ListChangedEventArgs e) => OnPropertyChanged(nameof(Importableobjects));

        #region Properties

        #region SelectedItem

        private BindingList<ImportableFile> _importableobjects = null;

        public BindingList<ImportableFile> Importableobjects
        {
            get => _importableobjects;
            set
            {
                if (_importableobjects != value)
                {
                    var oldValue = _importableobjects;
                    _importableobjects = value;
                    RaisePropertyChanged(() => Importableobjects, oldValue, value);
                }
            }
        }

        #endregion SelectedItem

        public bool UseWolvenKitImport { get; set; }

        #endregion Properties

        #region Commands

        public ICommand ImportCommand { get; private set; }
        public ICommand OpenFolderCommand { get; private set; }
        public ICommand TryGetTextureGroupsCommand { get; private set; }
        public ICommand UseLocalResourcesCommand { get; private set; }

        #endregion Commands

        #region Commands Implementation

        private bool CanImport() => Importableobjects != null;

        private bool CanOpenFolder() => _projectManager.ActiveProject != null;

        private bool CanTryGetTextureGroups() => Importableobjects != null;

        private bool CanUseLocalResources() => _projectManager.ActiveProject != null;

        private async void Import()
        {
            if (_projectManager.ActiveProject is not Tw3Project tw3Project)
            {
                return;
            }

            var filesToImport = Importableobjects.Where(_ => _.IsSelected).ToList();

            foreach (var file in filesToImport)
            {
                if (file.GetState() != ImportableFile.EObjectState.Ready)
                {
                    continue;
                }

                var fullpath = Path.Combine(importdepot.FullName, file.GetRelativePath());
                if (!File.Exists(fullpath))
                {
                    return;
                }

                var importext = $".{file.ImportType:G}";
                if (UseWolvenKitImport && importext == ".xbm")
                {
                    // experimental: import with wkit
                    var cr2w = CreateCr2wXbmFromImagePath(file);
                    if (cr2w != null)
                    {
                        var exNewpath = $"{GetNewPath(file)}";
                        // create directory
                        exNewpath.EnsureFolderExists();
                        using var fs = new FileStream(exNewpath, FileMode.Create, FileAccess.ReadWrite);
                        using var writer = new BinaryWriter(fs);
                        cr2w.Write(writer);
                        _loggerService.LogString($"Succesfully imported {fullpath}.", Logtype.Success);
                    }
                    else
                    {
                        _loggerService.LogString($"Failed to import {fullpath}.", Logtype.Error);
                    }
                }
                else
                {
                    // import with wcc_lite
                    await StartImport(file);
                }
            }

            async Task StartImport(ImportableFile file)
            {
                var newpath = GetNewPath(file);
                var filepath = Path.Combine(importdepot.FullName, file.GetRelativePath());

                var import = new Wcc_lite.import()
                {
                    File = filepath,
                    Out = newpath,
                    Depot = _settingsManager.DepotPath,
                    texturegroup = file.TextureGroup
                };
                await Task.Run(() => _wccService.RunCommand(import));
            }

            string GetNewPath(ImportableFile file)
            {
                var (relPath, isDlc) = file.GetREDRelativePath();
                var newpath = isDlc
                    ? Path.Combine(tw3Project.DlcUncookedDirectory, relPath)
                    : Path.Combine(tw3Project.ModUncookedDirectory, relPath);

                return newpath;
            }
        }

        private void OpenFolder()
        {
        }

        private void TryGetTextureGroup(ImportableFile importable)
        {
            // check for non-texture files
            if (importable.GetImportableType() != EImportable.bmp &&
                //importable.GetImportableType() != EImportable.dds &&
                importable.GetImportableType() != EImportable.jpg &&
                importable.GetImportableType() != EImportable.png &&
                importable.GetImportableType() != EImportable.tga
            )
            {
                return;
            }

            // try getting texture group from vanilla files
            //var hash = FNV1A64HashAlgorithm.HashString();
            var hash = Path.GetFileName(importable.GetREDRelativePath().Item1);
            if (xbmdict.ContainsKey(hash))
            {
                var record = xbmdict[hash];
                var stxtgroup = record.TextureGroup;
                if (string.IsNullOrEmpty(stxtgroup))
                {
                    //importable.TextureGroup = ETextureGroup.None;
                    importable.SetState(ImportableFile.EObjectState.NoTextureGroup);
                }
                else
                {
                    var etxtgroup = (ETextureGroup)Enum.Parse(typeof(ETextureGroup), stxtgroup);
                    importable.TextureGroup = etxtgroup;

                    importable.SetState(ImportableFile.EObjectState.Ready);
                    importable.IsSelected = true;
                }
            }
            else
            {
                importable.TextureGroup = ETextureGroup.Default;
                importable.SetState(ImportableFile.EObjectState.Ready);
                importable.IsSelected = true;
                //importable.SetState(ImportableFile.EObjectState.NoTextureGroup);
            }
        }

        private void TryGetTextureGroups()
        {
            foreach (var importable in Importableobjects)
            {
                TryGetTextureGroup(importable);
            }
        }

        private void UseLocalResources()
        {
            if (_projectManager.ActiveProject is not Tw3Project tw3Project)
            {
                return;
            }

            var importablefiles = new List<string>();
            foreach (var file in tw3Project.RawFiles)
            {
                var originalExt = Path.GetExtension(file);
                var lowerExt = originalExt.ToLower();
                if (importableexts.Contains(lowerExt))
                {
                    if (originalExt != lowerExt)
                    {
                        // rename file first because wcc can't handle uppercase file extensions
                        var oldpath = Path.Combine(_projectManager.ActiveProject.FileDirectory, file);
                        var newpath = Path.ChangeExtension(oldpath, lowerExt);
                        File.Move(oldpath, newpath);
                    }

                    importablefiles.Add(Path.ChangeExtension(file, lowerExt));
                }
            }
            AddObjects(importablefiles, _projectManager.ActiveProject.FileDirectory);

            //TryGetTextureGroupsCommand.SafeExecute();
            RaisePropertyChanged(nameof(Importableobjects));
        }

        #endregion Commands Implementation

        #region Methods

        private void AddObjects(IEnumerable<string> importablefiles, string dirpath)
        {
            Importableobjects.Clear();
            importdepot = new DirectoryInfo(dirpath);
            //List<ImportableFile> filestoAdd = new List<ImportableFile>();
            foreach (var f in importablefiles)
            {
                var ext = Path.GetExtension(f);
                var type = (EImportable)Enum.Parse(typeof(EImportable), ext.TrimStart('.').ToLower());

                var importableobj = new ImportableFile(
                    f,
                    type,
                    REDTypes.RawExtensionToEnum(ext)
                    );

                // non-texture imports are ready by default (no texture group must be set)
                if (importableobj.GetImportableType() == EImportable.apb ||
                    importableobj.GetImportableType() == EImportable.fbx ||
                    importableobj.GetImportableType() == EImportable.nxs
                    )
                {
                    importableobj.SetState(ImportableFile.EObjectState.Ready);
                    importableobj.IsSelected = true;
                }

                TryGetTextureGroup(importableobj);

                if (!Importableobjects.Contains(importableobj))
                {
                    Importableobjects.Add(importableobj);
                }
                else
                {
                }
            }
        }

        private CR2WFile CreateCr2wXbmFromImagePath(ImportableFile file)
        {
            var fullpath = Path.Combine(importdepot.FullName, file.GetRelativePath());

            // experimental: create uncooked xbm
            var compression = ImageUtility.GetTextureCompressionFromTextureGroup(file.TextureGroup);
            var tg = file.TextureGroup.ToString();

            // create mipmaps with texconv?
            // create a temporary dds
            var tempdir = IGameController.WorkDir;
            var textureformat = ImageUtility.GetEFormatFromCompression(compression);
            var ddsfile = TexconvWrapper.Convert(tempdir, fullpath, EUncookExtension.dds, textureformat);

            if (!File.Exists(ddsfile))
            {
                throw new NotImplementedException();
            }

            var metadata = DDSUtils.ReadHeader(ddsfile);
            var width = metadata.Width;
            var height = metadata.Height;

            // create cr2wfile
            var cr2w = new CR2WFile();
            var xbm = new CBitmapTexture(cr2w, null, "CBitmapTexture");
            xbm.Width = new CUInt32(cr2w, xbm, "width") { val = width, IsSerialized = true };
            xbm.Height = new CUInt32(cr2w, xbm, "height") { val = height, IsSerialized = true };
            xbm.Compression = new CEnum<Enums.ETextureCompression>(cr2w, xbm, "compression")
            { Value = compression, IsSerialized = true };
            xbm.TextureGroup = new CName(cr2w, xbm, "textureGroup") { Value = tg, IsSerialized = true };
            xbm.unk = new CUInt32(cr2w, xbm, "unk") { val = 0, IsSerialized = true };
            xbm.unk1 = new CUInt16(cr2w, xbm, "unk1") { val = 512, IsSerialized = true }; //TODO: find out what that is
            xbm.unk2 = new CUInt16(cr2w, xbm, "unk2") { val = 768, IsSerialized = true }; //TODO: find out what that is

            // read the mips
            // check if not a power of 2
            if (height % 2 != 0)
            {
                _loggerService.LogString("Texture dimensions not a power of 2. Please resize appropriately.", Logtype.Error);
                return null;
            }

            // funkiest way to calculate log2, the length of the bit array is also the number of mipmaps
            // height = 1024 = 2^10 = 11 mipmaps
            var b = System.Convert.ToString(Math.Max(height, width), 2);
            var mipcount = b.Length;

            xbm.Mipdata = new CCompressedBuffer<SMipData>(cr2w, xbm, "Mipdata") { IsSerialized = true };
            using (var fs = new FileStream(ddsfile, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                // skip dds header
                fs.Seek(128, SeekOrigin.Begin);

                var mipsizeH = height;
                var mipsizeW = width;
                // read data here
                for (var i = 0; i < mipcount; i++)
                {
                    var buffer = reader.ReadBytes((int)GetMipMapSize(mipsizeW, mipsizeH, textureformat));

                    var mipdata = new SMipData(cr2w, xbm.Mipdata, $"{i}") { IsSerialized = true };
                    mipdata.Height = new CUInt32(cr2w, mipdata, $"Height") { IsSerialized = true, val = mipsizeH };
                    mipdata.Width = new CUInt32(cr2w, mipdata, $"Width") { IsSerialized = true, val = mipsizeW };
                    mipdata.Blocksize = new CUInt32(cr2w, mipdata, $"Blocksize") { IsSerialized = true, val = GetBlockSize(mipsizeW, textureformat) };
                    mipdata.Mip = new CByteArray(cr2w, mipdata, $"Mip") { IsSerialized = true, Bytes = buffer };

                    xbm.Mipdata.AddVariable(mipdata);

                    mipsizeH = Math.Max(4, mipsizeH / 2);
                    mipsizeW = Math.Max(4, mipsizeW / 2);
                }
            }

            // residentmips

            cr2w.FromCResource(xbm);

            return cr2w;

            uint GetMipMapSize(uint _width, uint _height, EFormat _textureformat)
            {
                switch (_textureformat)
                {
                    case EFormat.BC1_UNORM:
                    case EFormat.BC4_UNORM:
                        return Math.Max(1, _height / 4) * Math.Max(1, _width / 4) * 8;

                    case EFormat.BC2_UNORM:
                    case EFormat.BC3_UNORM:
                    case EFormat.BC5_UNORM:
                        return Math.Max(1, _height / 4) * Math.Max(1, _width / 4) * 16;
                    //case EFormat.R32G32B32A32_FLOAT:
                    //case EFormat.R16G16B16A16_FLOAT:
                    //case EFormat.BC6H_UF16:
                    case EFormat.R8G8B8A8_UNORM:
                    case EFormat.BC7_UNORM:
                    default:
                        throw new ArgumentOutOfRangeException(nameof(_textureformat), _textureformat, null);
                }
            }

            uint GetBlockSize(uint _width, EFormat _textureformat)
            {
                switch (_textureformat)
                {
                    case EFormat.BC1_UNORM:
                    case EFormat.BC4_UNORM:
                        return Math.Max(1, _width / 4) * 8;

                    case EFormat.BC2_UNORM:
                    case EFormat.BC3_UNORM:
                    case EFormat.BC5_UNORM:
                        return Math.Max(1, _width / 4) * 16;
                    //case EFormat.R32G32B32A32_FLOAT:
                    //case EFormat.R16G16B16A16_FLOAT:
                    //case EFormat.BC6H_UF16:
                    case EFormat.R8G8B8A8_UNORM:
                    case EFormat.BC7_UNORM:
                    default:
                        throw new MissingFormatException($"Missing format: {_textureformat}");
                }
            }
        }

        private void RegisterXBMDump()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, IGameController.XBMDumpPath);
            using var fr = new FileStream(path, FileMode.Open, FileAccess.Read);
            using var sr = new StreamReader(fr);
            using var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<XBMDumpRecord>();
            foreach (var record in records)
            {
                //var hash = FNV1A64HashAlgorithm.HashString(record.RedName);
                var hash = Path.GetFileName(record.RedName);
                if (!xbmdict.ContainsKey(hash))
                {
                    xbmdict.Add(hash, record);
                }
            }
        }

        /// <summary>
        /// Initialize commands for this window.
        /// </summary>
        private void SetupCommands()
        {
            UseLocalResourcesCommand = new RelayCommand(UseLocalResources, CanUseLocalResources);
            OpenFolderCommand = new RelayCommand(OpenFolder, CanOpenFolder);
            TryGetTextureGroupsCommand = new RelayCommand(TryGetTextureGroups, CanTryGetTextureGroups);
            ImportCommand = new RelayCommand(Import, CanImport);
        }

        /// <summary>
        /// Initialize Avalondock specific defaults that are specific to this tool window.
        /// </summary>
        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion Methods
    }
}
