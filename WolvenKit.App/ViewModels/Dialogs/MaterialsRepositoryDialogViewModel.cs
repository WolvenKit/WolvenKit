using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.Archive;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public class MaterialsRepositoryViewModel : DialogWindowViewModel
    {
        public record class UncookExtensionViewModel(string Name, EUncookExtension Extension);

        private readonly ISettingsManager _settingsManager;
        private readonly ILoggerService _loggerService;
        private readonly IArchiveManager _archiveManager;
        private readonly IGameControllerFactory _gameControllerFactory;
        private readonly IProgressService<double> _progress;
        private readonly IModTools _modTools;

        public MaterialsRepositoryViewModel(
            ISettingsManager settingsManager,
            ILoggerService loggerService,
            IArchiveManager archiveManager,
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

            OpenMaterialRepositoryCommand = ReactiveCommand.Create(() => Commonfunctions.ShowFolderInExplorer(_settingsManager.MaterialRepositoryPath));
            UnbundleGameCommand = ReactiveCommand.CreateFromTask(UnbundleGame);
            GenerateMaterialRepoCommand = ReactiveCommand.CreateFromTask(GenerateMaterialRepoAsync);

            MaterialsDepotPath = _settingsManager.MaterialRepositoryPath;
            UncookExtensions = new();
            foreach (var item in Enum.GetValues<EUncookExtension>())
            {
                UncookExtensions.Add(new(item.ToString(), item));
            }
            UncookExtension = UncookExtensions.First(x => x.Extension == EUncookExtension.png);
        }

        #region Properties

        [Reactive] public string MaterialsDepotPath { get; set; }
        [Reactive] public UncookExtensionViewModel UncookExtension { get; set; }
        [Reactive] public List<UncookExtensionViewModel> UncookExtensions { get; set; }


        public string WikiHelpLink = "https://wiki.redmodding.org/wolvenkit/getting-started/setup";

        public readonly ReactiveCommand<string, Unit> OpenLinkCommand = ReactiveCommand.Create<string>(
            link =>
            {
                var ps = new ProcessStartInfo(link)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            });

        #endregion Properties

        #region Commands

        public ReactiveCommand<Unit, Unit> OpenMaterialRepositoryCommand { get; }
        public ReactiveCommand<Unit, Unit> GenerateMaterialRepoCommand { get; }
        public ReactiveCommand<Unit, Unit> UnbundleGameCommand { get; }

        #endregion Commands

        #region Methods

        private static readonly int _maxDoP = Environment.ProcessorCount > 1 ? Environment.ProcessorCount : 1;
        private readonly ParallelOptions _parallelOptions = new()
        {
            MaxDegreeOfParallelism = _maxDoP,
        };

        public static bool UseNewParallelism { get; set; } = true;

        private async Task GenerateMaterialRepoAsync()
        {
            DirectoryInfo materialRepoDir = new DirectoryInfo(MaterialsDepotPath);
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

                    ar.SetBulkExtract(true);

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
                                    await entry.ExtractAsync(fs);
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
                                        entry.Extract(fs);
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

                    ar.SetBulkExtract(false);
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

                    ar.SetBulkExtract(true);

                    if (UseNewParallelism)
                    {
                        async Task UncookAsync(IGameFile entry)
                        {
                            try
                            {
                                ArgumentNullException.ThrowIfNull(exportArgs); // TODO WHY???

                                exportArgs.Get<MlmaskExportArgs>().AsList = false;
                                await _modTools.UncookSingleAsync(entry.Archive, entry.Key, materialRepoDir, exportArgs);

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

                    ar.SetBulkExtract(false);
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

        private async Task UnbundleGame()
        {
            if (_settingsManager.MaterialRepositoryPath is null)
            {
                return;
            }    

            var depotPath = new DirectoryInfo(_settingsManager.MaterialRepositoryPath);
            if (depotPath.Exists)
            {
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

    
}
