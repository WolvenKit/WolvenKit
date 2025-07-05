using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Shapes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Controllers;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W.JSON;
using Path = System.IO.Path;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class MaterialsRepositoryViewModel : DialogWindowViewModel
{
    public record class UncookExtensionViewModel(string Name, EUncookExtension Extension);

    private readonly ISettingsManager _settingsManager;
    private readonly ILoggerService _loggerService;
    private readonly IAppArchiveManager _archiveManager;
    private readonly IGameControllerFactory _gameControllerFactory;
    private readonly IProgressService<double> _progress;
    private readonly IModTools _modTools;

    public MaterialsRepositoryViewModel(
        ISettingsManager settingsManager,
        ILoggerService loggerService,
        IAppArchiveManager archiveManager,
        IGameControllerFactory gameControllerFactory,
        IProgressService<double> progress,
        IModTools modTools)
    {
        _settingsManager = settingsManager;
        _loggerService = loggerService;
        _archiveManager = archiveManager;
        _gameControllerFactory = gameControllerFactory;
        _progress = progress;
        _modTools = modTools;

        ArgumentNullException.ThrowIfNull(_settingsManager.MaterialRepositoryPath);

        _materialsDepotPath = _settingsManager.MaterialRepositoryPath;
        _uncookExtensions = new();
        foreach (var item in Enum.GetValues<EUncookExtension>())
        {
            _uncookExtensions.Add(new(item.ToString(), item));
        }
        _uncookExtension = _uncookExtensions.First(x => x.Extension == EUncookExtension.png);
    }

    #region Properties

    [ObservableProperty] private string _materialsDepotPath;
    [ObservableProperty] private UncookExtensionViewModel _uncookExtension;
    [ObservableProperty] private List<UncookExtensionViewModel> _uncookExtensions;

    public string WikiHelpLink = "https://wiki.redmodding.org/wolvenkit/getting-started/setup";

    [RelayCommand]
    private void OpenLink(string link)
    {
        var ps = new ProcessStartInfo(link)
        {
            UseShellExecute = true,
            Verb = "open"
        };
        Process.Start(ps);
    }

    #endregion Properties

    #region Commands

    [RelayCommand]
    private void OpenMaterialRepository()
    {
        var path = _settingsManager.MaterialRepositoryPath;
        if (path is not null)
        {
            Commonfunctions.ShowFolderInExplorer(path);
        }
    }

    [RelayCommand]
    private async Task MigrateDepot()
    {
        var files = Directory.GetFiles(MaterialsDepotPath, "*.json", SearchOption.AllDirectories);

        _loggerService.Info($"Found {files.Length} entries to migrate");

        var progress = 0;
        _progress.Report(progress);

        async Task UncookAsync(string filePath)
        {
            var text = await File.ReadAllTextAsync(filePath);
            if (RedJsonSerializer.TryDeserialize<RedFileDto>(text, out var redFileDto) && redFileDto != null)
            {
                await File.WriteAllTextAsync(filePath, RedJsonSerializer.Serialize(new RedFileDto(redFileDto.Data!, redFileDto.Header.DataType == DataTypes.CR2WFlat)));
            }

            Interlocked.Increment(ref progress);
            _progress.Report(progress / (float)files.Length);
        }
        await files.ParallelForEachAsync(UncookAsync, _maxDoP);

        _progress.Completed();
        _loggerService.Success($"Migrated {files.Length} files.");
    }

    [RelayCommand]
    private async Task GenerateMaterialRepo()
    {
        var materialRepoDir = new DirectoryInfo(MaterialsDepotPath);
        var textureExtension = UncookExtension.Extension;

        var unbundle = new List<string>()
        {
            ".gradient",
            ".w2mi",
            ".matlib",
            ".remt",
            ".sp",
            ".hp",
            ".fp",
            ".mi",
            ".mt",
            ".mlsetup",
            ".mltemplate",
            ".texarray",
        };
        var uncook = new List<string>()
        {
            ".xbm",
            ".mlmask"
        };

        await _gameControllerFactory.GetRed4Controller().HandleStartup();

        var groupedFiles = _archiveManager.GetGroupedFiles();

        await Task.Yield(); // Ensure the below is scheduled.

        // unbundle
        foreach (var (key, fileEntries) in groupedFiles)
        {
            if (!unbundle.Contains(key))
            {
                continue;
            }

            var filesList = groupedFiles[key].GroupBy(x => x.Key).Select(x => x.First()).ToList();
            var fileCount = filesList.Count;
            _loggerService.Info($"{key}: Found {fileCount} entries to unbundle");
            var progress = 0;
            _progress.Report(0);

            foreach (var archiveGroup in filesList.GroupBy(x => x.GetArchive<Archive>().ArchiveAbsolutePath))
            {
                var ar = (Archive)_archiveManager.Archives.Lookup(archiveGroup.Key).Value;

                if (UseNewParallelism)
                {
                    async Task UnbundleAsync(IGameFile entry)
                    {
                        var endPath = Path.Combine(materialRepoDir.FullName, entry.Name);
                        var dirpath = Path.GetDirectoryName(endPath).NotNull();
                        var dirInfo = Directory.CreateDirectory(dirpath);

                        try
                        {
                            if (dirInfo.Exists) // CreateDirectory sometimes is false even on success.
                            {
                                using var fs = new FileStream(endPath, FileMode.Create, FileAccess.Write);
                                await ar.ExtractFileAsync(entry, fs);
                            }
                            Interlocked.Increment(ref progress);
                            _progress.Report(progress / (float)fileCount);
                        }
                        catch (Exception ex)
                        {
                            _loggerService.Error($"Error unbundling [File: {endPath}] [Entry: {entry.Name}]");
                            _loggerService.Error(ex);
                        }
                    }

                    await archiveGroup.ParallelForEachAsync(UnbundleAsync, _maxDoP);
                }
                else
                {
                    Parallel.ForEach(
                        archiveGroup,
                        _parallelOptions,
                        entry =>
                        {
                            var endPath = Path.Combine(materialRepoDir.FullName, entry.Name);
                            var dirpath = Path.GetDirectoryName(endPath).NotNull();
                            var dirInfo = Directory.CreateDirectory(dirpath);

                            try
                            {
                                if (dirInfo.Exists) // CreateDirectory sometimes is false even on success.
                                {
                                    using var fs = new FileStream(endPath, FileMode.Create, FileAccess.Write);
                                    ar.ExtractFile(entry, fs);
                                }
                                Interlocked.Increment(ref progress);
                                _progress.Report(progress / (float)filesList.Count);
                            }
                            catch (Exception ex)
                            {
                                _loggerService.Error($"Error unbundling [File: {endPath}] [Key: {entry.Key}]");
                                _loggerService.Error(ex);
                            }
                        }
                    );
                }

                ar.ReleaseFileHandle();
            }

            // Temporary measure. As memory optimizations get made with streams
            // this should be removed.
            GC.WaitForPendingFinalizers();
            GC.Collect();

            _progress.Completed();
            _loggerService.Success($"{key}: Unbundled {fileCount} files.");
        }

        // uncook
        var exportArgs =
            new GlobalExportArgs().Register(
                new XbmExportArgs() { UncookExtension = textureExtension },
                new MlmaskExportArgs() { UncookExtension = textureExtension }
            );


        foreach (var (key, fileEntries) in groupedFiles)
        {
            if (!uncook.Contains(key))
            {
                continue;
            }

            var filesList = groupedFiles[key].ToList();
            var fileCount = filesList.Count;

            _loggerService.Info($"{key}: Found {fileCount} entries to uncook");
            var progress = 0;
            _progress.Report(0);

            foreach (var archiveGroup in filesList.GroupBy(x => x.GetArchive<Archive>().ArchiveAbsolutePath))
            {
                var ar = (Archive)_archiveManager.Archives.Lookup(archiveGroup.Key).Value;

                if (UseNewParallelism)
                {
                    async Task UncookAsync(IGameFile entry)
                    {
                        try
                        {
                            exportArgs.Get<MlmaskExportArgs>().AsList = false;
                            await _modTools.UncookSingleAsync(entry.GetArchive<ICyberGameArchive>(), entry.Key, materialRepoDir, exportArgs);

                            Interlocked.Increment(ref progress);
                            _progress.Report(progress / (float)fileCount);
                        }
                        catch (Exception ex)
                        {
                            _loggerService.Error($"Error uncooking [File: {entry.Name}] [Key: {entry.Key}]");
                            _loggerService.Error(ex);
                        }
                    }

                    await archiveGroup.ParallelForEachAsync(UncookAsync, _maxDoP);
                }
                else
                {
                    Parallel.ForEach(
                        archiveGroup,
                        _parallelOptions,
                        entry =>
                        {
                            try
                            {
                                exportArgs.Get<MlmaskExportArgs>().AsList = false;
                                _modTools.UncookSingle(entry.GetArchive<Archive>(), entry.Key, materialRepoDir, exportArgs);

                                Interlocked.Increment(ref progress);
                                _progress.Report(progress / (float)fileCount);
                            }
                            catch (Exception ex)
                            {
                                _loggerService.Error($"Error uncooking [File: {entry.Name}] [Key: {entry.Key}]");
                                _loggerService.Error(ex);
                            }
                        }
                    );
                }

                ar.ReleaseFileHandle();
            }

            // Temporary measure. As memory optimizations get made with streams
            // this should be removed.
            GC.WaitForPendingFinalizers();
            GC.Collect();

            _progress.Completed();
            _loggerService.Success($"{key}: Uncooked {fileCount} files.");
        }

        _loggerService.Success("Finished Generating Materials!");

        OpenDepotFolder();
    }

    [RelayCommand]
    private async Task UnbundleGame()
    {
        if (_settingsManager.MaterialRepositoryPath is null)
        {
            return;
        }

        var depotPath = new DirectoryInfo(_settingsManager.MaterialRepositoryPath);
        if (depotPath.Exists)
        {
            await _gameControllerFactory.GetRed4Controller().HandleStartup();

            await Task.Run(() =>
            {
                var archives = _archiveManager.Archives.KeyValues.Select(x => x.Value).ToList();

                var total = archives.Count;
                var progress = 0;
                _progress.Report(0);

                for (var i = 0; i < archives.Count; i++)
                {
                    if (archives[i] is not ICyberGameArchive archive)
                    {
                        throw new InvalidGameContextException();
                    }
                    _modTools.ExtractAll(archive, depotPath);

                    progress++;
                    _progress.Report(i / (float)total);
                }
                _progress.Completed();
            });
        }

        _loggerService.Success("Finished Unbundling Game!");

        OpenDepotFolder();
    }


    #endregion Commands

    #region Methods

    private static readonly int _maxDoP = Environment.ProcessorCount > 1 ? Environment.ProcessorCount : 1;
    private readonly ParallelOptions _parallelOptions = new()
    {
        MaxDegreeOfParallelism = _maxDoP,
    };

    public static bool UseNewParallelism { get; set; } = true;

   
    private void OpenDepotFolder()
    {
        if (_settingsManager.MaterialRepositoryPath is null)
        {
            return;
        }
        Commonfunctions.ShowFolderInExplorer(_settingsManager.MaterialRepositoryPath);
    }

    #endregion Methods
}
