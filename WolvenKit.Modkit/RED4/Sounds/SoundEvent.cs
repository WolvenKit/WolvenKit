using System.Collections.Generic;

namespace WolvenKit.Modkit.RED4.Sounds
{
    public class SoundEvent
    {
        public string? Name { get; set; }
        public List<string> Tags { get; set; } = new();
    }
}
