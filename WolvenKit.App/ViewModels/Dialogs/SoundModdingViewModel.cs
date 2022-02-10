using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text.Json;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Modkit.RED4.Sounds;

namespace WolvenKit.ViewModels.Dialogs
{
    public class SoundModdingViewModel : DialogViewModel
    {
        private readonly ISettingsManager _settings;
        private readonly ILoggerService _logger;
        private readonly IProjectManager _projectManager;

        private SoundEventMetadata _metadata;
        private ModInfo _info;

        private JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public SoundModdingViewModel()
        {
            _settings = Locator.Current.GetService<ISettingsManager>();
            _logger = Locator.Current.GetService<ILoggerService>();
            _projectManager = Locator.Current.GetService<IProjectManager>();

            _metadata = new SoundEventMetadata();

            SaveCommand = ReactiveCommand.Create(() => Save());
            CancelCommand = ReactiveCommand.Create(() =>
            {

            });

            AddCommand = new WolvenKit.Functionality.Commands.RelayCommand(AddEvents, CanAddEvents);


            // load events
            var path = Path.Combine(Environment.CurrentDirectory, "Resources", "soundEvents.json");

            if (File.Exists(path))
            {
                try
                {
                    _metadata = JsonSerializer.Deserialize<SoundEventMetadata>(File.ReadAllText(path), _options);
                    EventNames = _metadata.Events.OrderBy(x => x.Name);
                }
                catch (Exception e)
                {
                    _logger.Error(e);
                }
            }

            // load info.json
            var modInfoJsonPath = Path.Combine(_projectManager.ActiveProject.PackedModDirectory, "info.json");
            if (File.Exists(path))
            {
                try
                {
                    _info = JsonSerializer.Deserialize<ModInfo>(File.ReadAllText(path), _options);
                    foreach (var e in _info.CustomSounds)
                    {
                        Events.Add(e);
                    }

                }
                catch (Exception e)
                {
                    _logger.Error(e);
                }
            }

            // populate Files
            var modfiles = Directory.GetFiles(_projectManager.ActiveProject.RawDirectory, "*.wav", SearchOption.AllDirectories);
            foreach (var modfile in modfiles)
            {
                Files.Add(modfile);
            }
        }

        private bool CanAddEvents() => true;
        private void AddEvents()
        {
            foreach (var item in SelectedEvents)
            {
                if (!Events.Any(x => x.Name == item.Name))
                {
                    Events.Add(new CustomSoundsModel()
                    {
                        File = SelectedFile,
                        Name = item.Name
                    });
                }
            }
        }

        private void Save()
        {
            var modInfoJsonPath = Path.Combine(_projectManager.ActiveProject.PackedModDirectory, "info.json");
            if (!File.Exists(modInfoJsonPath))
            {
                var jsonString = JsonSerializer.Serialize(_projectManager.ActiveProject.GetInfo(), _options);
                File.WriteAllText(modInfoJsonPath, jsonString);
            }
            else
            {
                var info = _projectManager.ActiveProject.GetInfo();
                foreach (var e in Events)
                {
                    if (info.CustomSounds.Any(x => x.Name.Equals(e.Name)))
                    {
                        var existing = info.CustomSounds.First(x => x.Name.Equals(e.Name));
                        info.CustomSounds.Remove(existing);
                    }

                    if (string.IsNullOrEmpty(e.Name) || string.IsNullOrEmpty(e.File))
                    {
                        continue;
                    }
                    info.CustomSounds.Add(e);
                }
            }
        }


        [Reactive]
        public ObservableCollection<CustomSoundsModel> Events { get; set; } = new();
        [Reactive]
        public CustomSoundsModel SelectedEvent { get; set; }


        public List<string> Files { get; set; } = new();
        [Reactive]
        public string SelectedFile { get; set; }


        public IEnumerable<SoundEvent> EventNames { get; set; }

        public List<SoundEvent> SelectedEvents { get; set; } = new();


        public ICommand SaveCommand { get; private set; }

        public ReactiveCommand<Unit, Unit> CancelCommand { get; set; }

        public ICommand AddCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }
    }
}
