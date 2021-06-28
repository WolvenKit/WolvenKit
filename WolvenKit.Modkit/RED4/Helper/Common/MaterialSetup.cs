using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Modkit.RED4.Materials.Types;
using System;

namespace WolvenKit.Modkit.RED4.MaterialSetupFile
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
                var data = setup.Layers[i];
                Layers[i].MatTile = data.MatTile.IsSerialized ? data.MatTile.Value : null;

                Layers[i].MbTile = data.MbTile.IsSerialized ? data.MbTile.Value : null;

                Layers[i].Microblend = data.Microblend.DepotPath;

                Layers[i].MicroblendContrast = data.MicroblendContrast.IsSerialized ? data.MicroblendContrast.Value : null;

                Layers[i].MicroblendNormalStrength = data.MicroblendNormalStrength.IsSerialized ? data.MicroblendNormalStrength.Value : null;

                Layers[i].MicroblendOffsetU = data.MicroblendOffsetU.IsSerialized ? data.MicroblendOffsetU.Value : null;

                Layers[i].MicroblendOffsetV = data.MicroblendOffsetV.IsSerialized? data.MicroblendOffsetV.Value : null;

                Layers[i].Opacity = data.Opacity.IsSerialized? data.Opacity.Value : null;

                Layers[i].OffsetU = data.OffsetU.IsSerialized? data.OffsetU.Value : null;

                Layers[i].OffsetV = data.OffsetV.IsSerialized? data.OffsetV.Value : null;

                Layers[i].Material = data.Material.DepotPath;

                Layers[i].ColorScale = data.ColorScale.IsSerialized ? data.ColorScale.Value : null;

                Layers[i].NormalStrength = data.NormalStrength.IsSerialized ? data.NormalStrength.Value : null;

                Layers[i].RoughLevelsIn = data.RoughLevelsIn.IsSerialized ? data.RoughLevelsIn.Value : null;

                Layers[i].RoughLevelsOut = data.RoughLevelsOut.IsSerialized ? data.RoughLevelsOut.Value : null;

                Layers[i].MetalLevelsIn = data.MetalLevelsIn.IsSerialized ? data.MetalLevelsIn.Value : null;

                Layers[i].MetalLevelsOut = data.MetalLevelsOut.IsSerialized ? data.MetalLevelsOut.Value : null;

                Layers[i].Overrides = data.Overrides.IsSerialized ? data.Overrides.Value : null;
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
        public string ColorTexture { get; set; } = null;
        public string NormalTexture { get; set; } = null;
        public string RoughnessTexture { get; set; } = null;
        public string MetalnessTexture { get; set; } = null;
        public Nullable<float> TilingMultiplier { get; set; } = null;
        public Nullable<float>[] ColorMaskLevelsIn { get; set; } = null;
        public Nullable<float>[] ColorMaskLevelsOut { get; set; } = null;
        public TemplateDefaultOverrides DefaultOverrides { get; set; }
        public TemplateOverrides Overrides { get; set; }
        public Template(Multilayer_LayerTemplate template, string name)
        {
            Name = name;
            ColorTexture = template.ColorTexture.DepotPath;
            NormalTexture = template.NormalTexture.DepotPath;
            RoughnessTexture = template.RoughnessTexture.DepotPath;
            MetalnessTexture = template.MetalnessTexture.DepotPath;

            TilingMultiplier = template.TilingMultiplier.IsSerialized ? template.TilingMultiplier.Value : null;

            if (template.ColorMaskLevelsIn.Count > 0)
            {
                ColorMaskLevelsIn = new Nullable<float>[template.ColorMaskLevelsIn.Count];
                for (int i = 0; i < template.ColorMaskLevelsIn.Count; i++)
                    ColorMaskLevelsIn[i] = template.ColorMaskLevelsIn[i].Value;
            }

            if (template.ColorMaskLevelsOut.Count > 0)
            {
                ColorMaskLevelsOut = new Nullable<float>[template.ColorMaskLevelsOut.Count];
                for (int i = 0; i < template.ColorMaskLevelsOut.Count; i++)
                    ColorMaskLevelsOut[i] = template.ColorMaskLevelsOut[i].Value;
            }

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

                if (template.Overrides.ColorScale[i].V.Count > 0)
                {
                    Overrides.ColorScale[i].V = new Nullable<float>[template.Overrides.ColorScale[i].V.Count];
                    for (int e = 0; e < template.Overrides.ColorScale[i].V.Count; e++)
                    {
                        Overrides.ColorScale[i].V[e] = template.Overrides.ColorScale[i].V[e].Value;
                    }
                }

            }

            Overrides.RoughLevelsIn = new OverrideValue[template.Overrides.RoughLevelsIn.Count];
            for (int i = 0; i < template.Overrides.RoughLevelsIn.Count; i++)
            {
                Overrides.RoughLevelsIn[i] = new OverrideValue();
                Overrides.RoughLevelsIn[i].N = template.Overrides.RoughLevelsIn[i].N.Value;

                if (template.Overrides.RoughLevelsIn[i].V.Count > 0)
                {
                    Overrides.RoughLevelsIn[i].V = new Nullable<float>[template.Overrides.RoughLevelsIn[i].V.Count];
                    for (int e = 0; e < template.Overrides.RoughLevelsIn[i].V.Count; e++)
                    {
                        Overrides.RoughLevelsIn[i].V[e] = template.Overrides.RoughLevelsIn[i].V[e].Value;
                    }
                }

            }

            Overrides.RoughLevelsOut = new OverrideValue[template.Overrides.RoughLevelsOut.Count];
            for (int i = 0; i < template.Overrides.RoughLevelsOut.Count; i++)
            {
                Overrides.RoughLevelsOut[i] = new OverrideValue();
                Overrides.RoughLevelsOut[i].N = template.Overrides.RoughLevelsOut[i].N.Value;

                if (template.Overrides.RoughLevelsOut[i].V.Count > 0)
                {
                    Overrides.RoughLevelsOut[i].V = new Nullable<float>[template.Overrides.RoughLevelsOut[i].V.Count];
                    for (int e = 0; e < template.Overrides.RoughLevelsOut[i].V.Count; e++)
                    {
                        Overrides.RoughLevelsOut[i].V[e] = template.Overrides.RoughLevelsOut[i].V[e].Value;
                    }
                }

            }

            Overrides.MetalLevelsIn = new OverrideValue[template.Overrides.MetalLevelsIn.Count];
            for (int i = 0; i < template.Overrides.MetalLevelsIn.Count; i++)
            {
                Overrides.MetalLevelsIn[i] = new OverrideValue();
                Overrides.MetalLevelsIn[i].N = template.Overrides.MetalLevelsIn[i].N.Value;

                if (template.Overrides.MetalLevelsIn[i].V.Count > 0)
                {
                    Overrides.MetalLevelsIn[i].V = new Nullable<float>[template.Overrides.MetalLevelsIn[i].V.Count];
                    for (int e = 0; e < template.Overrides.MetalLevelsIn[i].V.Count; e++)
                    {
                        Overrides.MetalLevelsIn[i].V[e] = template.Overrides.MetalLevelsIn[i].V[e].Value;
                    }
                }

            }

            Overrides.MetalLevelsOut = new OverrideValue[template.Overrides.MetalLevelsOut.Count];
            for (int i = 0; i < template.Overrides.MetalLevelsOut.Count; i++)
            {
                Overrides.MetalLevelsOut[i] = new OverrideValue();
                Overrides.MetalLevelsOut[i].N = template.Overrides.MetalLevelsOut[i].N.Value;

                if (template.Overrides.MetalLevelsOut[i].V.Count > 0)
                {
                    Overrides.MetalLevelsOut[i].V = new Nullable<float>[template.Overrides.MetalLevelsOut[i].V.Count];
                    for (int e = 0; e < template.Overrides.MetalLevelsOut[i].V.Count; e++)
                    {
                        Overrides.MetalLevelsOut[i].V[e] = template.Overrides.MetalLevelsOut[i].V[e].Value;
                    }
                }

            }

            Overrides.NormalStrength = new OverrideValue[template.Overrides.NormalStrength.Count];
            for (int i = 0; i < template.Overrides.NormalStrength.Count; i++)
            {
                Overrides.NormalStrength[i] = new OverrideValue();
                Overrides.NormalStrength[i].N = template.Overrides.NormalStrength[i].N.Value;

                if(template.Overrides.NormalStrength[i].V.IsSerialized)
                {
                    Overrides.NormalStrength[i].V = new Nullable<float>[1];
                    Overrides.NormalStrength[i].V[0] = template.Overrides.NormalStrength[i].V.Value;
                }

            }
        }
    }
    public class TemplateDefaultOverrides
    {
        public string ColorScale { get; set; } = null;
        public string NormalStrength { get; set; } = null;
        public string RoughLevelsIn { get; set; } = null;
        public string RoughLevelsOut { get; set; } = null;
        public string MetalLevelsIn { get; set; } = null;
        public string MetalLevelsOut { get; set; } = null;
    }
    public class TemplateOverrides
    {
        public OverrideValue[] ColorScale { get; set; } = null;
        public OverrideValue[] RoughLevelsIn { get; set; } = null;
        public OverrideValue[] RoughLevelsOut { get; set; } = null;
        public OverrideValue[] MetalLevelsIn { get; set; } = null;
        public OverrideValue[] MetalLevelsOut { get; set; } = null;
        public OverrideValue[] NormalStrength { get; set; } = null;
    }
    public class OverrideValue
    {
        public string N { get; set; } = null;
        public Nullable<float>[] V { get; set; } = null;
    }
    public class HairProfile
    {
        public string Name { get; set; }
        public GradientEntry[] GradientEntriesID { get; set; }
        public GradientEntry[] GradientEntriesRootToTip { get; set; }
        public HairProfile(CHairProfile c, string name)
        {
            Name = name;
            GradientEntriesID = new GradientEntry[c.GradientEntriesID.Count];
            GradientEntriesRootToTip = new GradientEntry[c.GradientEntriesRootToTip.Count];

            for (int i = 0; i < c.GradientEntriesID.Count; i++)
            {
                GradientEntriesID[i] = new GradientEntry(c.GradientEntriesID[i]);
            }
            for (int i = 0; i < c.GradientEntriesRootToTip.Count; i++)
            {
                GradientEntriesRootToTip[i] = new GradientEntry(c.GradientEntriesRootToTip[i]);
            }
        }
    }
    public class GradientEntry
    {
        public float Value;
        public Color Color;
        public GradientEntry(rendGradientEntry g)
        {
            Value = g.Value.Value;
            Color = new Color(g.Color);
        }
    }
}
