using System;
using System.Reactive.Linq;
using System.Text.Json.Serialization;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

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

    public class CustomSoundsModel : ReactiveObject
    {
        public CustomSoundsModel()
        {
            this.WhenAnyValue(x => x.Type)
                .Subscribe(type => IsEnabled = type != ECustomSoundType.mod_skip.ToString());
        }

        public string? Name { get; set; }
        [Reactive] public string Type { get; set; } = ECustomSoundType.mod_sfx_2d.ToString();
        public string? File { get; set; }
        public decimal? Gain { get; set; } = 1.0m;
        public decimal? Pitch { get; set; } = 0.0m;

        [JsonIgnore]
        [Reactive] public bool IsEnabled { get; set; }

    }
}
