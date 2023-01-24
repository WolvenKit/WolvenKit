using System.ComponentModel;
using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Core;

namespace WolvenKit.Modkit.RED4.Sounds
{
    public enum ECustomSoundType
    {
        mod_sfx_2d,
        mod_sfx_city,
        mod_sfx_low_occlusion,
        mod_sfx_occlusion,
        mod_sfx_radio,
        mod_sfx_room,
        mod_sfx_street,
        mod_skip
    }

    public class CustomSoundsModel : ObservableObject
    {
        private bool _isEnabled;
        private string _type = ECustomSoundType.mod_sfx_2d.ToString();

        public CustomSoundsModel()
        {
            PropertyChanged += delegate(object? sender, PropertyChangedEventArgs args)
            {
                if (args.PropertyName == nameof(Type))
                {
                    IsEnabled = Type != ECustomSoundType.mod_skip.ToString();
                }
            };
        }

        public string? Name { get; set; }

        public string Type
        {
            get => _type;
            set => SetProperty(ref _type, value);
        }

        public string? File { get; set; }
        public decimal? Gain { get; set; } = 1.0m;
        public decimal? Pitch { get; set; } = 0.0m;

        [JsonIgnore]
        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }
    }
}
