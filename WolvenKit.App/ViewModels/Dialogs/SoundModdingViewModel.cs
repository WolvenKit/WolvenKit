using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Modkit.RED4.Sounds;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public class SoundModdingViewModel : DialogViewModel
    {
        private readonly INotificationService _notificationService;
        private readonly ILoggerService _logger;
        private readonly IProjectManager _projectManager;

        private SoundEventMetadata _metadata;
        private ModInfo _info;

        private readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            IgnoreReadOnlyProperties = true,
        };

        public SoundModdingViewModel()
        {
            _notificationService = Locator.Current.GetService<INotificationService>();
            _logger = Locator.Current.GetService<ILoggerService>();
            _projectManager = Locator.Current.GetService<IProjectManager>();

            _metadata = new SoundEventMetadata();

            OkCommand = ReactiveCommand.Create(Save);
#pragma warning disable IDE0053 // Use expression body for lambda expressions
            CancelCommand = ReactiveCommand.Create(() => { FileHandler(null); });
#pragma warning restore IDE0053 // Use expression body for lambda expressions

            AddCommand = ReactiveCommand.Create(AddEvents);

            LoadEvents();
            LoadInfo();
            PopulateFiles();
        }

        private void LoadEvents()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Resources", "soundEvents.json");
            if (File.Exists(path))
            {
                try
                {
                    _metadata = JsonSerializer.Deserialize<SoundEventMetadata>(File.ReadAllText(path), _options);
                }
                catch (Exception e)
                {
                    _logger.Error(e);
                }


                foreach (var item in _metadata.Events.OrderBy(x => x.Name))
                {
                    SoundEvents.Add(item);
                }
                Tags = _metadata.Events.SelectMany(x => x.Tags).Distinct().OrderBy(x => x).ToList();
            }
        }

        private void LoadInfo()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Resources", "soundEvents.json");
            path = Path.Combine(_projectManager.ActiveProject.ResourcesDirectory, "info.json");
            if (File.Exists(path))
            {
                try
                {
                    _info = JsonSerializer.Deserialize<ModInfo>(File.ReadAllText(path), _options);
                    foreach (var e in _info.CustomSounds)
                    {
                        CustomEvents.Add(e);
                    }
                    if (CustomEvents.Count > 0)
                    {
                        SelectedObject = CustomEvents.First();
                    }
                }
                catch (Exception e)
                {
                    _logger.Error(e);
                }
            }
        }

        private void PopulateFiles()
        {
            var modProj = _projectManager.ActiveProject;
            var modfiles = Directory.GetFiles(modProj.SoundDirectory, "*.wav", SearchOption.AllDirectories);
            foreach (var modfile in modfiles)
            {
                var relPath = modfile[(modProj.SoundDirectory.Length + 1)..];
                Files.Add(relPath);
            }
        }

        public delegate Task ReturnHandler(SoundModdingViewModel file);
        public ReturnHandler FileHandler;

        public List<string> Files { get; set; } = new();
        public List<string> Types { get; set; } = Enum.GetNames<ECustomSoundType>().ToList();

        public List<SoundEvent> SelectedEvents { get; set; } = new();

        public IEnumerable<string> Tags { get; set; }

        [Reactive] public CustomSoundsModel SelectedObject { get; set; }
        [Reactive] public ObservableCollection<CustomSoundsModel> CustomEvents { get; set; } = new();
        [Reactive] public ObservableCollection<SoundEvent> SoundEvents { get; set; } = new();


        #region commands

        public override ReactiveCommand<Unit, Unit> CancelCommand { get; }

        public override ReactiveCommand<Unit, Unit> OkCommand { get; }

        private void Save()
        {
            var modInfoJsonPath = Path.Combine(_projectManager.ActiveProject.ResourcesDirectory, "info.json");
            if (!File.Exists(modInfoJsonPath))
            {
                var jsonString = JsonSerializer.Serialize(_projectManager.ActiveProject.GetInfo(), _options);
                File.WriteAllText(modInfoJsonPath, jsonString);
            }
            else
            {
                var info = _projectManager.ActiveProject.GetInfo();
                foreach (var e in CustomEvents)
                {
                    if (info.CustomSounds.Any(x => x.Name.Equals(e.Name)))
                    {
                        var existing = info.CustomSounds.First(x => x.Name.Equals(e.Name));
                        info.CustomSounds.Remove(existing);
                    }

                    if (string.IsNullOrEmpty(e.Name))
                    {
                        continue;
                    }
                    if (string.IsNullOrEmpty(e.Type))
                    {
                        continue;
                    }
                    if (e.Type != ECustomSoundType.mod_skip.ToString() && string.IsNullOrEmpty(e.File))
                    {
                        continue;
                    }

                    // use clear names
                    //e.Type = GetEngineType(e.Type);

                    // do not serialize skipped sounds
                    if (e.Type == ECustomSoundType.mod_skip.ToString())
                    {
                        e.File = null;
                        e.Pitch = null;
                        e.Gain = null;

                        _logger.Info($"Skipping sound event {e.Name}");
                    }
                    else
                    {
                        _logger.Info($"Added custom sound {e.File} for sound event {e.Name}");
                    }
                    info.CustomSounds.Add(e);


                }

                var jsonString = JsonSerializer.Serialize(info, _options);
                File.WriteAllText(modInfoJsonPath, jsonString);
                _notificationService.Success($"Saved sound configuration to {modInfoJsonPath}");
            }
        }

        //private static string GetEngineType(string type)
        //{
        //    if (Enum.TryParse<ECustomSoundType>(type, out var en))
        //    {
        //        var engineType = (ECustomSoundTypeEngine)en;
        //        return engineType.ToString();
        //    }
        //    // default
        //    return ECustomSoundTypeEngine.mod_sfx_2d.ToString();
        //}

        public ReactiveCommand<Unit, Unit> AddCommand { get; private set; }
        private void AddEvents()
        {
            foreach (var item in SelectedEvents)
            {
                if (!CustomEvents.Any(x => x.Name == item.Name))
                {
                    CustomEvents.Add(new CustomSoundsModel()
                    {
                        Name = item.Name
                    });
                }
            }
            if (CustomEvents.Count > 0)
            {
                SelectedObject = CustomEvents.Last();
            }
        }

        #endregion


    }
}
