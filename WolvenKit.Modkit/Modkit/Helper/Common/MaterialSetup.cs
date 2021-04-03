using WolvenKit.RED4.CR2W.Types;
using System;

namespace WolvenKit.RED4.MaterialSetupFile
{
    public class Setup
    {
        public string Name { get; set; }
        public int LayerCount { get; set; }
        public SetupLayer[] Layers { get; set; }

        public Setup(Multilayer_Setup setup, string name)
        {
            Name = name;
            LayerCount = setup.Layers.Count;
            Layers = new SetupLayer[LayerCount];

            for (int i = 0; i < LayerCount; i++)
            {
                Layers[i] = new SetupLayer();

                try
                {
                    Layers[i].MatTile = setup.Layers[i].MatTile.Value;
                    Layers[i].MbTile = setup.Layers[i].MbTile.Value;
                    Layers[i].Microblend = setup.Layers[i].Microblend.DepotPath;
                    Layers[i].MicroblendContrast = setup.Layers[i].MicroblendContrast.Value;
                    Layers[i].MicroblendNormalStrength = setup.Layers[i].MicroblendNormalStrength.Value;
                    Layers[i].MicroblendOffsetU = setup.Layers[i].MicroblendOffsetU.Value;
                    Layers[i].MicroblendOffsetV = setup.Layers[i].MicroblendOffsetV.Value;
                    Layers[i].Opacity = setup.Layers[i].Opacity.Value;
                    Layers[i].OffsetU = setup.Layers[i].OffsetU.Value;
                    Layers[i].OffsetV = setup.Layers[i].OffsetV.Value;
                    Layers[i].Material = setup.Layers[i].Material.DepotPath;
                    Layers[i].ColorScale = setup.Layers[i].ColorScale.Value;
                    Layers[i].NormalStrength = setup.Layers[i].NormalStrength.Value;
                    Layers[i].RoughLevelsIn = setup.Layers[i].RoughLevelsIn.Value;
                    Layers[i].RoughLevelsOut = setup.Layers[i].RoughLevelsOut.Value;
                    Layers[i].MetalLevelsIn = setup.Layers[i].MetalLevelsIn.Value;
                    Layers[i].MetalLevelsOut = setup.Layers[i].MetalLevelsOut.Value;
                    Layers[i].Overrides = setup.Layers[i].Overrides.Value;
                }
                catch{ }
            }
        }
    }
    public class SetupLayer
    {
        public Nullable<float> MatTile { get; set; } = null;
        public Nullable<float> MbTile { get; set; } = null;
        public string Microblend { get; set; } = null;
        public Nullable<float> MicroblendContrast { get; set; } = null;
        public Nullable<float> MicroblendNormalStrength { get; set; } = null;
        public Nullable<float> MicroblendOffsetU { get; set; } = null;
        public Nullable<float> MicroblendOffsetV { get; set; } = null;
        public Nullable<float> Opacity { get; set; } = null;
        public Nullable<float> OffsetU { get; set; } = null;
        public Nullable<float> OffsetV { get; set; } = null;
        public string Material { get; set; } = null;
        public string ColorScale { get; set; } = null;
        public string NormalStrength { get; set; } = null;
        public string RoughLevelsIn { get; set; } = null;
        public string RoughLevelsOut { get; set; } = null;
        public string MetalLevelsIn { get; set; } = null;
        public string MetalLevelsOut { get; set; } = null;
        public string Overrides { get; set; } = null;
    }
    public class Template
    {
        public string Name { get; set; }
        public string ColorTexture { get; set; }
        public string NormalTexture { get; set; }
        public string RoughnessTexture { get; set; }
        public string MetalnessTexture { get; set; }
        public float TilingMultiplier { get; set; }
        public float[] ColorMaskLevelsIn { get; set; }
        public float[] ColorMaskLevelsOut { get; set; }
        public TemplateDefaultOverrides DefaultOverrides { get; set; }
        public TemplateOverrides Overrides { get; set; }
        public Template(Multilayer_LayerTemplate template, string name)
        {
            int Count = 0;
            bool Zeroed = false;
            try
            {

                Name = name;
                ColorTexture = template.ColorTexture.DepotPath;
                NormalTexture = template.NormalTexture.DepotPath;
                RoughnessTexture = template.RoughnessTexture.DepotPath;
                MetalnessTexture = template.MetalnessTexture.DepotPath;
                TilingMultiplier = template.TilingMultiplier.Value;

                Count = template.ColorMaskLevelsIn.Count;

                if (Count == 0)
                {
                    Zeroed = true;
                    Count = 1;
                }

                ColorMaskLevelsIn = new float[Count];
                if (Zeroed)
                    ColorMaskLevelsIn[0] = 9999;

                for (int i = 0; i < template.ColorMaskLevelsIn.Count; i++)
                    ColorMaskLevelsIn[i] = template.ColorMaskLevelsIn[i].Value;

                Zeroed = false;

                Count = template.ColorMaskLevelsOut.Count;

                if (Count == 0)
                {
                    Zeroed = true;
                    Count = 1;
                }

                ColorMaskLevelsOut = new float[Count];
                if (Zeroed)
                    ColorMaskLevelsOut[0] = 9999;
                Zeroed = false;

                for (int i = 0; i < template.ColorMaskLevelsOut.Count; i++)
                    ColorMaskLevelsOut[i] = template.ColorMaskLevelsOut[i].Value;


                DefaultOverrides = new TemplateDefaultOverrides();
                DefaultOverrides.ColorScale = template.DefaultOverrides.ColorScale.Value;
                DefaultOverrides.NormalStrength = template.DefaultOverrides.NormalStrength.Value;
                DefaultOverrides.RoughLevelsIn = template.DefaultOverrides.RoughLevelsIn.Value;
                DefaultOverrides.RoughLevelsOut = template.DefaultOverrides.RoughLevelsOut.Value;
                DefaultOverrides.MetalLevelsIn = template.DefaultOverrides.MetalLevelsIn.Value;
                DefaultOverrides.MetalLevelsOut = template.DefaultOverrides.MetalLevelsOut.Value;

                Overrides = new TemplateOverrides();

                Overrides.ColorScale = new OverrideValue[template.Overrides.ColorScale.Count];
                for (int i = 0; i < template.Overrides.ColorScale.Count; i++)
                {
                    Overrides.ColorScale[i] = new OverrideValue();
                    Overrides.ColorScale[i].N = template.Overrides.ColorScale[i].N.Value;

                    Count = template.Overrides.ColorScale[i].V.Count;

                    if (Count == 0)
                    {
                        Zeroed = true;
                        Count = 1;
                    }
                    Overrides.ColorScale[i].V = new float[Count];

                    if (Zeroed)
                        Overrides.ColorScale[i].V[0] = 9999;
                    Zeroed = false;

                    for (int e = 0; e < template.Overrides.ColorScale[i].V.Count; e++)
                    {
                        Overrides.ColorScale[i].V[e] = template.Overrides.ColorScale[i].V[e].Value;
                    }
                }

                Overrides.RoughLevelsIn = new OverrideValue[template.Overrides.RoughLevelsIn.Count];
                for (int i = 0; i < template.Overrides.RoughLevelsIn.Count; i++)
                {
                    Overrides.RoughLevelsIn[i] = new OverrideValue();
                    Overrides.RoughLevelsIn[i].N = template.Overrides.RoughLevelsIn[i].N.Value;

                    Count = template.Overrides.RoughLevelsIn[i].V.Count;

                    if (Count == 0)
                    {
                        Zeroed = true;
                        Count = 1;

                    }
                    Overrides.RoughLevelsIn[i].V = new float[Count];

                    if (Zeroed)
                        Overrides.RoughLevelsIn[i].V[0] = 9999;
                    Zeroed = false;

                    for (int e = 0; e < template.Overrides.RoughLevelsIn[i].V.Count; e++)
                    {
                        Overrides.RoughLevelsIn[i].V[e] = template.Overrides.RoughLevelsIn[i].V[e].Value;
                    }
                }

                Overrides.RoughLevelsOut = new OverrideValue[template.Overrides.RoughLevelsOut.Count];
                for (int i = 0; i < template.Overrides.RoughLevelsOut.Count; i++)
                {
                    Overrides.RoughLevelsOut[i] = new OverrideValue();
                    Overrides.RoughLevelsOut[i].N = template.Overrides.RoughLevelsOut[i].N.Value;

                    Count = template.Overrides.RoughLevelsOut[i].V.Count;

                    if (Count == 0)
                    {
                        Zeroed = true;
                        Count = 1;

                    }
                    Overrides.RoughLevelsOut[i].V = new float[Count];

                    if (Zeroed)
                        Overrides.RoughLevelsOut[i].V[0] = 9999;
                    Zeroed = false;

                    for (int e = 0; e < template.Overrides.RoughLevelsOut[i].V.Count; e++)
                    {
                        Overrides.RoughLevelsOut[i].V[e] = template.Overrides.RoughLevelsOut[i].V[e].Value;
                    }
                }

                Overrides.MetalLevelsIn = new OverrideValue[template.Overrides.MetalLevelsIn.Count];
                for (int i = 0; i < template.Overrides.MetalLevelsIn.Count; i++)
                {
                    Overrides.MetalLevelsIn[i] = new OverrideValue();
                    Overrides.MetalLevelsIn[i].N = template.Overrides.MetalLevelsIn[i].N.Value;

                    Count = template.Overrides.MetalLevelsIn[i].V.Count;

                    if (Count == 0)
                    {
                        Zeroed = true;
                        Count = 1;

                    }
                    Overrides.MetalLevelsIn[i].V = new float[Count];

                    if (Zeroed)
                        Overrides.MetalLevelsIn[i].V[0] = 9999;
                    Zeroed = false;

                    for (int e = 0; e < template.Overrides.MetalLevelsIn[i].V.Count; e++)
                    {
                        Overrides.MetalLevelsIn[i].V[e] = template.Overrides.MetalLevelsIn[i].V[e].Value;
                    }
                }

                Overrides.MetalLevelsOut = new OverrideValue[template.Overrides.MetalLevelsOut.Count];
                for (int i = 0; i < template.Overrides.MetalLevelsOut.Count; i++)
                {
                    Overrides.MetalLevelsOut[i] = new OverrideValue();
                    Overrides.MetalLevelsOut[i].N = template.Overrides.MetalLevelsOut[i].N.Value;

                    Count = template.Overrides.MetalLevelsOut[i].V.Count;

                    if (Count == 0)
                    {
                        Zeroed = true;
                        Count = 1;

                    }
                    Overrides.MetalLevelsOut[i].V = new float[Count];

                    if (Zeroed)
                        Overrides.MetalLevelsOut[i].V[0] = 9999;
                    Zeroed = false;

                    for (int e = 0; e < template.Overrides.MetalLevelsOut[i].V.Count; e++)
                    {
                        Overrides.MetalLevelsOut[i].V[e] = template.Overrides.MetalLevelsOut[i].V[e].Value;
                    }
                }

                Overrides.NormalStrength = new OverrideValue[template.Overrides.NormalStrength.Count];
                for (int i = 0; i < template.Overrides.NormalStrength.Count; i++)
                {
                    Overrides.NormalStrength[i] = new OverrideValue();
                    Overrides.NormalStrength[i].N = template.Overrides.NormalStrength[i].N.Value;
                    Overrides.NormalStrength[i].V = new float[1];
                    Overrides.NormalStrength[i].V[0] = template.Overrides.NormalStrength[i].V.Value;
                }
            }
            catch {  }
        }
    }
    public class TemplateDefaultOverrides
    {
        public string ColorScale { get; set; }
        public string NormalStrength { get; set; }
        public string RoughLevelsIn { get; set; }
        public string RoughLevelsOut { get; set; }
        public string MetalLevelsIn { get; set; }
        public string MetalLevelsOut { get; set; }
    }
    public class TemplateOverrides
    {
        public OverrideValue[] ColorScale { get; set; }
        public OverrideValue[] RoughLevelsIn { get; set; }
        public OverrideValue[] RoughLevelsOut { get; set; }
        public OverrideValue[] MetalLevelsIn { get; set; }
        public OverrideValue[] MetalLevelsOut { get; set; }
        public OverrideValue[] NormalStrength { get; set; }
    }
    public class OverrideValue
    {
        public string N { get; set; }
        public float[] V { get; set; }
    }
}
