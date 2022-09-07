using System.Collections.Generic;

namespace WolvenKit.Modkit.RED4.Sounds
{
    public class SoundEventMetadata
    {
        public string GameVersion { get; set; } = "1.31";
        public List<SoundEvent> Events { get; set; } = new();
    }
}
