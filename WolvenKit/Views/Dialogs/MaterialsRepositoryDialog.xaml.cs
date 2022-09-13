using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Dialogs;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.Views.Shell;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for MaterialsRepositoryDialog.xaml
    /// </summary>
    public partial class MaterialsRepositoryDialog : HandyControl.Controls.Window
    {
        private readonly ISettingsManager _settingsManager;
        private readonly IGameControllerFactory _gameControllerFactory;
        private readonly IProgressService<double> _progress;
        private readonly IModTools _modTools;
        private readonly ILoggerService _loggerService;

        public MaterialsRepositoryDialog()
        {
            InitializeComponent();

            _settingsManager = Locator.Current.GetService<ISettingsManager>();
            _gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
            _modTools = Locator.Current.GetService<IModTools>();
            _progress = Locator.Current.GetService<IProgressService<double>>();
            _loggerService = Locator.Current.GetService<ILoggerService>();

            ArchivesFolderPath = Path.Combine(_settingsManager.GetRED4GameRootDir(), "archive", "pc", "content");
            MaterialsDepotPath = _settingsManager.MaterialRepositoryPath;
            MaterialsTextBox.SetCurrentValue(System.Windows.Controls.TextBox.TextProperty, _settingsManager.MaterialRepositoryPath);
        }

        public string ArchivesFolderPath { get; }

        public string MaterialsDepotPath { get; set; }

        private async void GenerateButton_Click(object sender, System.Windows.RoutedEventArgs e) => await Task.Run(() => GenerateMaterialRepo(new DirectoryInfo(MaterialsDepotPath), EUncookExtension.png));

        private void GenerateMaterialRepo(DirectoryInfo materialRepoDir, EUncookExtension texturesExtension)
        {
            var bm = Locator.Current.GetService<IArchiveManager>();
            if (bm == null)
            {
                return;
            }

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
            var groupedFiles = bm.GetGroupedFiles();

            // unbundle
            foreach (var (key, fileEntries) in groupedFiles)
            {
                if (!unbundle.Contains(key))
                {
                    continue;
                }
                var fileslist = groupedFiles[key].GroupBy(x => x.Key).Select(x => x.First()).ToList();
                _loggerService.Info($"{key}: Found {fileslist.Count} entries to uncook");
                var progress = 0;
                _progress.Report(0);

                Parallel.ForEach(fileslist, entry =>
                    {
                        var endPath = Path.Combine(materialRepoDir.FullName, entry.Name);
                        var dirpath = Path.GetDirectoryName(endPath);
                        Directory.CreateDirectory(dirpath);
                        using (var fs = new FileStream(endPath, FileMode.Create, FileAccess.Write))
                        {
                            entry.Extract(fs);
                        }
                        Interlocked.Increment(ref progress);
                        _progress.Report(progress / (float)fileslist.Count);
                    }
                );

                _loggerService.Success($"{key}: Unbundled {fileslist.Count} files.");
            }

            // uncook
            var exportArgs =
                new GlobalExportArgs().Register(
                    new XbmExportArgs() { UncookExtension = texturesExtension },
                    new MlmaskExportArgs() { UncookExtension = texturesExtension.ToMlmaskUncookExtension() }
                );

            foreach (var (key, fileEntries) in groupedFiles)
            {
                if (!uncook.Contains(key))
                {
                    continue;
                }
                var fileslist = groupedFiles[key].ToList();
                _loggerService.Info($"{key}: Found {fileslist.Count} entries to uncook");
                var progress = 0;
                _progress.Report(0);

                Parallel.ForEach(fileslist, entry =>
                    {
                        _modTools.UncookSingle(entry.Archive as Archive, entry.Key, materialRepoDir, exportArgs);

                        Interlocked.Increment(ref progress);
                        _progress.Report(progress / (float)fileslist.Count);
                    }
                );

                _loggerService.Success($"{key}: Uncooked {fileslist.Count} files.");
            }
        }

        private void GenerateMaterials(object obj)
        {
        }

        private void MaterialsButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog { IsFolderPicker = true };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                MaterialsTextBox.SetCurrentValue(System.Windows.Controls.TextBox.TextProperty, dialog.FileName);
                MaterialsDepotPath = dialog.FileName;
                _settingsManager.MaterialRepositoryPath = dialog.FileName;
                _settingsManager.Save();
            }
        }

        private void ArchivesButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //disabled
            //CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            //dialog.IsFolderPicker = true;
            //if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            //{
            //    ArchivesTextBox.SetCurrentValue(System.Windows.Controls.TextBox.TextProperty, dialog.FileName);
            //}
        }

        private void Window_Closed(object sender, EventArgs e) => MenuBarView.MaterialsRepositoryDia = null;
    }
}
