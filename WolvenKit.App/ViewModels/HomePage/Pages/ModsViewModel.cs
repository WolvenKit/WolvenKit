using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Helpers;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.HomePage
{
    public class ModsViewModel : PageViewModel
    {
        private readonly ISettingsManager _settings;
        private readonly ILoggerService _logger;
        private readonly IPluginService _pluginService;
        private readonly IProgressService<double> _progressService;

        private readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            IgnoreReadOnlyProperties = true,
        };

        public ModsViewModel()
        {
            _settings = Locator.Current.GetService<ISettingsManager>();
            _logger = Locator.Current.GetService<ILoggerService>();
            _pluginService = Locator.Current.GetService<IPluginService>();
            _progressService = Locator.Current.GetService<IProgressService<double>>();

            RefreshCommand = ReactiveCommand.Create(() => Refresh());
            DeployCommand = ReactiveCommand.Create(() => Deploy());
            LaunchGameCommand = ReactiveCommand.Create(() => LaunchGame());
            CheckRedModCommand = ReactiveCommand.Create(() => CheckRedMod());
            OpenModFolderCommand = ReactiveCommand.Create(() => OpenModFolder());

            RemoveCommand = ReactiveCommand.Create(() => Remove());

            // LoadMods when we're good and ready
            _settings
                .WhenAnyValue(x => x.CP77ExecutablePath)
                .SkipWhile(x => string.IsNullOrWhiteSpace(x) || !File.Exists(x)) // -.-
                .Take(1)
                .Subscribe(x => LoadMods());

            _ = Observable.FromEventPattern<EventHandler<double>, double>(
                handler => _progressService.ProgressChanged += handler,
                handler => _progressService.ProgressChanged -= handler)
                .Select(_ => _.EventArgs * 100)
                .ToProperty(this, x => x.Progress, out _progress);
        }

        private readonly ObservableAsPropertyHelper<double> _progress;
        public double Progress => _progress.Value;

        [Reactive] public bool LoadOrderChanged { get; private set; }
        [Reactive] public ObservableCollection<ModInfoViewModel> Mods { get; set; } = new();
        [Reactive] public ModInfoViewModel SelectedMod { get; set; }
        [Reactive] public IEnumerable<ModInfoViewModel> SelectedMods { get; set; }
        [Reactive] public bool IsProcessing { get; set; }

        #region commands

        public ICommand DeployCommand { get; private set; }
        private async Task Deploy() => await DeployRedmod();
        private IEnumerable<ModInfoViewModel> GetEnabledMods() => Mods.Where(x => x.IsEnabled);
        private async Task<bool> DeployRedmod()
        {
            if (!_pluginService.IsInstalled(EPlugin.redmod))
            {
                _logger.Error("Redmod needs to be installed to deploy mods.");
                var response = await Interactions.ShowMessageBoxAsync("The RedMod tools are not installed. Would you like to install them?", "RedMod not found");

                switch (response)
                {
                    case WMessageBoxResult.OK:
                    case WMessageBoxResult.Yes:
                        _homePageViewModel.NavigateTo(EHomePage.Plugins);
                        break;
                }

                return false;
            }


            // compile with redmod
            var redmodPath = Path.Combine(_settings.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");
            if (!File.Exists(redmodPath))
            {
                _logger.Error("RedMod tools are not installed. Please go to WolvenKit plugins and install RedMod.");
                return false;
            }
            else
            {
                _progressService.Report(0);

                var enabledMods = GetEnabledMods().OrderBy(x => x.LoadOrder).ToList();

                IsProcessing = true;

                var rttiSchemaPath = Path.Combine(_settings.GetRED4GameRootDir(), "tools", "redmod", "metadata.json");
                var args = $"deploy -root=\"{_settings.GetRED4GameRootDir()}\"";

                if (LoadOrderChanged)
                {
                    args += " -force";
                }

                var modsStr = string.Join(' ', enabledMods.Select(x => $"\"{x.Folder}\""));
                args += $" -mod={modsStr}";

                _logger.Info($"WorkDir: {redmodPath}");
                _logger.Info($"Running commandlet: {args}");

                _progressService.Report(0.1);

                var workingDir = Path.Combine(_settings.GetRED4GameRootDir(), "tools", "redmod", "bin");
                var result = await ProcessUtil.RunRedmodAsync(redmodPath, args, workingDir, progress: _progressService);

                _progressService.Report(1.0);
                _progressService.Completed();
                IsProcessing = false;

                if (!result)
                {
                    await Interactions.ShowMessageBoxAsync(
                        "RedMod deploy failed. Please check the log for details.",
                        "RedMod",
                        WMessageBoxButtons.Ok,
                        WMessageBoxImage.Error);
                }
                else
                {
                    await Interactions.ShowMessageBoxAsync(
                        $"Deployed {enabledMods.Count} enabled mods with RedMod.",
                        "RedMod deploy",
                        WMessageBoxButtons.Ok,
                        WMessageBoxImage.Exclamation);

                    SetLoadOrderChanged(false);
                }

                return result;
            }
        }

        public ICommand RefreshCommand { get; private set; }
        private void Refresh() => LoadMods();

        public ICommand OpenModFolderCommand { get; private set; }
        private void OpenModFolder() => Commonfunctions.ShowFolderInExplorer(_settings.GetRED4GameModDir());

        public ICommand LaunchGameCommand { get; private set; }
        private void LaunchGame()
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = _settings.GetRED4GameLaunchCommand(),
                    Arguments = $"{_settings.GetRED4GameLaunchOptions()} -modded",
                    ErrorDialog = true,
                });
            }
            catch (Exception ex)
            {
                _logger.Error("Launch: error launching game! Please check your executable path in Settings.");
                _logger.Info($"Launch: error debug info: {ex.Message}");
            }
        }

        public ICommand CheckRedModCommand { get; private set; }
        private async Task CheckRedMod()
        {
            if (!_pluginService.IsInstalled(EPlugin.redmod))
            {
                var res = await Interactions
                    .ShowMessageBoxAsync("The RedMod tools are not installed and mod compilation will not work. Would you like to install the RedMod tools now?",
                    "RedMod not found");

                switch (res)
                {
                    case WMessageBoxResult.OK:
                    case WMessageBoxResult.Yes:
                        _homePageViewModel.NavigateTo(EHomePage.Plugins);
                        break;
                }
            }
        }

        public ICommand RemoveCommand { get; private set; }
        private void Remove()
        {
            if (SelectedMod is null)
            {
                return;
            }

            if (!Directory.Exists(SelectedMod.Path))
            {
                _logger.Warning($"Could not find mod: {SelectedMod.Path}");
            }

            try
            {
                Directory.Delete(SelectedMod.Path, true);

                Mods.Remove(SelectedMod);
            }
            catch (Exception)
            {
                _logger.Error($"Could not delete mod: {SelectedMod.Path}");
            }
        }

        #endregion

        private void LoadMods()
        {
            LoadModsInfo();

            ParseMods();
        }

        private void LoadModsInfo()
        {
            Mods.Clear();

            var di = new DirectoryInfo(_settings.GetRED4GameModDir());
            var infos = di.GetFiles("info.json", SearchOption.AllDirectories);
            foreach (var item in infos)
            {
                try
                {
                    var info = JsonSerializer.Deserialize<ModInfo>(File.ReadAllText(item.FullName), _options);
                    var folder = item.Directory.FullName;
                    Mods.Add(new ModInfoViewModel(info, folder, _logger));
                }
                catch (Exception)
                {
                    _logger.Warning($"Could not read mod file: {item.FullName}");
                }

            }
        }

        private void ParseMods()
        {
            // parse existing mods.info and update enabled
            // also update load order
            var modsInfoPath = Path.Combine(_settings.GetRED4GameRootDir(), "r6", "cache", "modded", "mods.json");
            ModsInfo modsInfo = null;
            var foundMods = new List<ModInfoViewModel>();
            if (File.Exists(modsInfoPath))
            {
                try
                {
                    modsInfo = JsonSerializer.Deserialize<ModsInfo>(File.ReadAllText(modsInfoPath), _options);
                }
                catch (Exception)
                {
                    _logger.Warning($"Could not read mods info file: {modsInfoPath}");
                    return;
                }


                for (var i = 0; i < modsInfo.Mods.Count; i++)
                {
                    var mod = modsInfo.Mods[i];

                    var local = Mods.FirstOrDefault(x => x.Folder == mod.folder);
                    if (local is not null)
                    {
                        local.IsEnabled = mod.enabled;
                        local.LoadOrder = i;
                        foundMods.Add(local);
                    }
                }
            }

            // loop through all existing mods
            // reorder according to modsInfo
            // first come all the mods in mods.info
            // then the rest
            var rest = Mods.Where(x => !foundMods.Contains(x)).ToList();
            for (var i = 0; i < rest.Count; i++)
            {
                var mod = rest[i];
                mod.LoadOrder = i + foundMods.Count;
            }

            _logger.Info($"Found {Mods.Count} REDmods.");
        }

        public void SetLoadOrderChanged(bool v) => LoadOrderChanged = v;
    }
}
