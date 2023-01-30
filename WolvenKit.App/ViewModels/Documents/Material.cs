using System.Collections.Generic;
using System.Drawing;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class Material
    {
        public Material(string name) => Name = name;
        public string Name { get; set; }
        public CMaterialInstance? Instance { get; set; }
        public Dictionary<string, object> Values { get; set; } = new();
        public Material? Base { get; set; }
        public Bitmap? ColorTexture { get; set; }
        public string? ColorTexturePath { get; set; }
        public string? TemplateName { get; set; }
        public float Metalness { get; set; } = 0.0f;
        public float Roughness { get; set; } = 0.75f;
    }
}
