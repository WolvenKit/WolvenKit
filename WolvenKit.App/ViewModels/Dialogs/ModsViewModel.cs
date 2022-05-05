using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;

namespace WolvenKit.ViewModels.Dialogs
{
    public class ModsViewModel : DialogViewModel
    {
        private readonly ISettingsManager _settings;
        private readonly ILoggerService _logger;
        private readonly IProjectManager _projectManager;
        private readonly IGameControllerFactory _gameControllerFactory;

        private readonly JsonSerializerOptions _options = new JsonSerializerOptions
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
            _projectManager = Locator.Current.GetService<IProjectManager>();
            _gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();

            SaveCommand = ReactiveCommand.Create(() => Save());
            CancelCommand = ReactiveCommand.Create(() => FileHandler(null));

            RefreshCommand = ReactiveCommand.Create(() => Refresh());
            DeployCommand = ReactiveCommand.Create(() => Deploy());

            // load all mods
            LoadMods();


            _logger.Info($"Found {Mods.Count} mods.");

        }




        public delegate Task ReturnHandler(NewFileViewModel file);
        public ReturnHandler FileHandler;

        [Reactive] public ObservableCollection<ModInfoViewModel> Mods { get; set; } = new();

        #region commands

        public ICommand CancelCommand { get; private set; }

        public ICommand SaveCommand { get; private set; }
        private void Save()
        {

        }


        public ICommand DeployCommand { get; private set; }
        private async Task Deploy() => await _gameControllerFactory.GetController().DeployRedmod();

        public ICommand RefreshCommand { get; private set; }
        private void Refresh() => LoadMods();

        #endregion

        private void LoadMods()
        {
            var di = new DirectoryInfo(_settings.GetRED4GameModDir());
            var infos = di.GetFiles("info.json", SearchOption.AllDirectories);
            foreach (var item in infos)
            {
                try
                {
                    var info = JsonSerializer.Deserialize<ModInfo>(File.ReadAllText(item.FullName), _options);
                    var folder = item.Directory.Name;
                    Mods.Add(new ModInfoViewModel(info, folder));
                }
                catch (Exception)
                {
                    _logger.Warning($"Could not read mod file: {item.FullName}");
                }

            }

            // parse existing mods.info and update enabled
            // also update load order
            var modsInfoPath = Path.Combine(_settings.GetRED4GameRootDir(), "r6", "cache", "modded", "mods.json");
            ModsInfo modsInfo = null;
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
            }

            ArgumentNullException.ThrowIfNull(modsInfo);

            for (var i = 0; i < modsInfo.Mods.Count; i++)
            {
                var mod = modsInfo.Mods[i];
                var local = Mods.FirstOrDefault(x => x.Folder == mod.folder);
                if (local is not null)
                {
                    local.IsEnabled = mod.enabled;
                    local.LoadOrder = i;
                }
                else
                {
                    // when the user uninstalls mods
                    // TODO
                }
            }

        }
    }

    public class ModInfoViewModel
    {
        public ModInfoViewModel(ModInfo mod, string folder)
        {
            Mod = mod;
            Folder = folder;
        }

        public ModInfo Mod { get; init; }

        public string Folder { get; init; }

        public int LoadOrder { get; set; }

        public bool IsEnabled { get; set; }

        public string Name => Mod.Name;

    }
}
