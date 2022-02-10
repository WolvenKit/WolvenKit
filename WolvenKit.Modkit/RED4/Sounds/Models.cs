using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class CustomSoundsModel
    {
        public string Name { get;set;}
        public string File { get;set;}
        public ECustomSoundType Type { get;set;}
        public float Gain { get;set;}
        public float Pitch { get;set;}
    }

    public class SoundEventMetadata
    {
        public string GameVersion { get; set; } = "1.31";
        public List<SoundEvent> Events { get; set; } = new();
    }

    public class SoundEvent
    {
        public string Name { get; set; }
        public List<string> Tags { get; set; } = new();
    }
}
