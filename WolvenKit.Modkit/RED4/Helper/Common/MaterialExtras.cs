using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Modkit.RED4.Materials.Types;
using System;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.Modkit.RED4.Materials.Extras
{
    public class Setup
    {
        public int LayerCount { get; set; }
        public SetupLayer[] Layers { get; set; }
        public string Ext = ".mlsetup";
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
        public Setup()
        {

        }
        public Setup(Multilayer_Setup setup)
        {
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
        public static CR2WFile Deserialize(Setup setup)
        {
            CR2WFile mlsetup = new CR2WFile();
            {
                var chunk = new Multilayer_Setup(mlsetup, null, "Multilayer_Setup") { IsSerialized = true };
                chunk.CookingPlatform = new CEnum<Enums.ECookingPlatform>(mlsetup, chunk, "cookingPlatform") { IsSerialized = true, Value = Enums.ECookingPlatform.PLATFORM_PC };
                chunk.CookingPlatform.EnumValueList.Add("PLATFORM_PC");
                chunk.Layers = new CArray<Multilayer_Layer>(mlsetup, chunk, "layers") { IsSerialized = true };

                for(int i = 0; i < setup.LayerCount; i++)
                {
                    var layer = new Multilayer_Layer(mlsetup, chunk.Layers, Convert.ToString(i)) { IsSerialized = true };
                    if(setup.Layers[i].MatTile != null)
                    {
                        layer.MatTile = new CFloat(mlsetup, layer, "matTile") { IsSerialized = true, Value = setup.Layers[i].MatTile.Value };
                    }
                    if (setup.Layers[i].MbTile != null)
                    {
                        layer.MbTile = new CFloat(mlsetup, layer, "mbTile") { IsSerialized = true, Value = setup.Layers[i].MbTile.Value };
                    }
                    if (setup.Layers[i].Microblend != null)
                    {
                        layer.Microblend = new rRef<CBitmapTexture>(mlsetup, layer, "microblend") { IsSerialized = true, DepotPath = setup.Layers[i].Microblend };
                    }
                    if (setup.Layers[i].MicroblendContrast != null)
                    {
                        layer.MicroblendContrast = new CFloat(mlsetup, layer, "microblendContrast") { IsSerialized = true, Value = setup.Layers[i].MicroblendContrast.Value };
                    }
                    if (setup.Layers[i].MicroblendNormalStrength != null)
                    {
                        layer.MicroblendNormalStrength = new CFloat(mlsetup, layer, "microblendNormalStrength") { IsSerialized = true, Value = setup.Layers[i].MicroblendNormalStrength.Value };
                    }
                    if (setup.Layers[i].MicroblendOffsetU != null)
                    {
                        layer.MicroblendOffsetU = new CFloat(mlsetup, layer, "microblendOffsetU") { IsSerialized = true, Value = setup.Layers[i].MicroblendOffsetU.Value };
                    }
                    if (setup.Layers[i].MicroblendOffsetV != null)
                    {
                        layer.MicroblendOffsetV = new CFloat(mlsetup, layer, "microblendOffsetV") { IsSerialized = true, Value = setup.Layers[i].MicroblendOffsetV.Value };
                    }
                    if (setup.Layers[i].Opacity != null)
                    {
                        layer.Opacity = new CFloat(mlsetup, layer, "opacity") { IsSerialized = true, Value = setup.Layers[i].Opacity.Value };
                    }
                    if (setup.Layers[i].OffsetU != null)
                    {
                        layer.OffsetU = new CFloat(mlsetup, layer, "offsetU") { IsSerialized = true, Value = setup.Layers[i].OffsetU.Value };
                    }
                    if (setup.Layers[i].OffsetV != null)
                    {
                        layer.OffsetV = new CFloat(mlsetup, layer, "offsetV") { IsSerialized = true, Value = setup.Layers[i].OffsetV.Value };
                    }
                    if (setup.Layers[i].Material != null)
                    {
                        layer.Material = new rRef<Multilayer_LayerTemplate>(mlsetup, layer, "material") { IsSerialized = true, DepotPath = setup.Layers[i].Material };
                    }
                    if (setup.Layers[i].ColorScale != null)
                    {
                        layer.ColorScale = new CName(mlsetup, layer, "colorScale") { IsSerialized = true, Value = setup.Layers[i].ColorScale };
                    }
                    if (setup.Layers[i].NormalStrength != null)
                    {
                        layer.NormalStrength = new CName(mlsetup, layer, "normalStrength") { IsSerialized = true, Value = setup.Layers[i].NormalStrength };
                    }
                    if (setup.Layers[i].RoughLevelsIn != null)
                    {
                        layer.RoughLevelsIn = new CName(mlsetup, layer, "roughLevelsIn") { IsSerialized = true, Value = setup.Layers[i].RoughLevelsIn };
                    }
                    if (setup.Layers[i].RoughLevelsOut != null)
                    {
                        layer.RoughLevelsOut = new CName(mlsetup, layer, "roughLevelsOut") { IsSerialized = true, Value = setup.Layers[i].RoughLevelsOut };
                    }
                    if (setup.Layers[i].MetalLevelsIn != null)
                    {
                        layer.MetalLevelsIn = new CName(mlsetup, layer, "metalLevelsIn") { IsSerialized = true, Value = setup.Layers[i].MetalLevelsIn };
                    }
                    if (setup.Layers[i].MetalLevelsOut != null)
                    {
                        layer.MetalLevelsOut = new CName(mlsetup, layer, "metalLevelsOut") { IsSerialized = true, Value = setup.Layers[i].MetalLevelsOut };
                    }
                    if (setup.Layers[i].Overrides != null)
                    {
                        layer.Overrides = new CName(mlsetup, layer, "overrides") { IsSerialized = true, Value = setup.Layers[i].Overrides };
                    }
                    chunk.Layers.Add(layer);
                }
                mlsetup.CreateChunk(chunk, 0);
            }
            return mlsetup;
        }
    }
    public class Template
    {
        public string ColorTexture { get; set; } = null;
        public string NormalTexture { get; set; } = null;
        public string RoughnessTexture { get; set; } = null;
        public string MetalnessTexture { get; set; } = null;
        public Nullable<float> TilingMultiplier { get; set; } = null;
        public Nullable<float>[] ColorMaskLevelsIn { get; set; } = null;
        public Nullable<float>[] ColorMaskLevelsOut { get; set; } = null;
        public TemplateDefaultOverrides DefaultOverrides { get; set; }
        public TemplateOverrides Overrides { get; set; }
        public string Ext = ".mltemplate";
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
        public Template(Multilayer_LayerTemplate template)
        {
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
        public Template()
        {

        }
        public static CR2WFile Deserialize(Template template)
        {
            CR2WFile mltemplate = new CR2WFile();
            {
                var chunk = new Multilayer_LayerTemplate(mltemplate, null, "Multilayer_LayerTemplate") { IsSerialized = true };
                chunk.CookingPlatform = new CEnum<Enums.ECookingPlatform>(mltemplate, chunk, "cookingPlatform") { IsSerialized = true, Value = Enums.ECookingPlatform.PLATFORM_PC };
                chunk.CookingPlatform.EnumValueList.Add("PLATFORM_PC");

                chunk.ColorTexture = new rRef<CBitmapTexture>(mltemplate, chunk, "colorTexture") { IsSerialized = true, DepotPath = template.ColorTexture };
                chunk.NormalTexture = new rRef<CBitmapTexture>(mltemplate, chunk, "normalTexture") { IsSerialized = true, DepotPath = template.NormalTexture };
                chunk.RoughnessTexture = new rRef<CBitmapTexture>(mltemplate, chunk, "roughnessTexture") { IsSerialized = true, DepotPath = template.RoughnessTexture };
                chunk.MetalnessTexture = new rRef<CBitmapTexture>(mltemplate, chunk, "metalnessTexture") { IsSerialized = true, DepotPath = template.MetalnessTexture };
                
                if (template.TilingMultiplier != null)
                {
                    chunk.TilingMultiplier = new CFloat(mltemplate, chunk, "tilingMultiplier") { IsSerialized = true, Value = template.TilingMultiplier.Value };
                }

                for (int i = 0; i < template.ColorMaskLevelsIn.Length; i++)
                {
                    chunk.ColorMaskLevelsIn.Add(new CFloat(mltemplate, chunk.ColorMaskLevelsIn, Convert.ToString(i)) { IsSerialized = true, Value = template.ColorMaskLevelsIn[i].Value });
                }
                
                for (int i = 0; i < template.ColorMaskLevelsOut.Length; i++)
                {
                    chunk.ColorMaskLevelsOut.Add(new CFloat(mltemplate, chunk.ColorMaskLevelsOut, Convert.ToString(i)) { IsSerialized = true, Value = template.ColorMaskLevelsOut[i].Value });
                }
                chunk.DefaultOverrides = new Multilayer_LayerOverrideSelection(mltemplate, chunk, "defaultOverrides");
                if(template.DefaultOverrides.ColorScale != "")
                {
                    chunk.DefaultOverrides.ColorScale = new CName(mltemplate, chunk.DefaultOverrides, "colorScale") { IsSerialized = true, Value = template.DefaultOverrides.ColorScale };
                    chunk.DefaultOverrides.IsSerialized = true;
                }
                if(template.DefaultOverrides.NormalStrength != "")
                {
                    chunk.DefaultOverrides.NormalStrength = new CName(mltemplate, chunk.DefaultOverrides, "normalStrength") { IsSerialized = true, Value = template.DefaultOverrides.NormalStrength };
                    chunk.DefaultOverrides.IsSerialized = true;
                }
                if (template.DefaultOverrides.RoughLevelsIn != "")
                {
                    chunk.DefaultOverrides.RoughLevelsIn = new CName(mltemplate, chunk.DefaultOverrides, "roughLevelsIn") { IsSerialized = true, Value = template.DefaultOverrides.RoughLevelsIn };
                    chunk.DefaultOverrides.IsSerialized = true;
                }

                if (template.DefaultOverrides.RoughLevelsOut != "")
                {
                    chunk.DefaultOverrides.RoughLevelsOut = new CName(mltemplate, chunk.DefaultOverrides, "roughLevelsOut") { IsSerialized = true, Value = template.DefaultOverrides.RoughLevelsOut };
                    chunk.DefaultOverrides.IsSerialized = true;
                }
                if (template.DefaultOverrides.MetalLevelsIn != "")
                {
                    chunk.DefaultOverrides.MetalLevelsIn = new CName(mltemplate, chunk.DefaultOverrides, "metalLevelsIn") { IsSerialized = true, Value = template.DefaultOverrides.MetalLevelsIn };
                    chunk.DefaultOverrides.IsSerialized = true;
                }
                if (template.DefaultOverrides.MetalLevelsOut != "")
                {
                    chunk.DefaultOverrides.MetalLevelsOut = new CName(mltemplate, chunk.DefaultOverrides, "metalLevelsOut") { IsSerialized = true, Value = template.DefaultOverrides.MetalLevelsOut };
                    chunk.DefaultOverrides.IsSerialized = true;
                }

                chunk.Overrides = new Multilayer_LayerTemplateOverrides(mltemplate, chunk, "overrides") { IsSerialized = true };
                
                chunk.Overrides.ColorScale = new CArray<Multilayer_LayerTemplateOverridesColor>(mltemplate, chunk.Overrides, "colorScale") { IsSerialized = true };
                for (int i = 0; i < template.Overrides.ColorScale.Length; i++)
                {
                    var colorScale = new Multilayer_LayerTemplateOverridesColor(mltemplate, chunk.Overrides.ColorScale, Convert.ToString(i)) { IsSerialized = true };
                    colorScale.N = new CName(mltemplate, colorScale, "n") { IsSerialized = true, Value = template.Overrides.ColorScale[i].N };
                    for (int j = 0; j < template.Overrides.ColorScale[i].V.Length; j++)
                    {
                        colorScale.V.Add(new CFloat(mltemplate, colorScale.V, Convert.ToString(j)) { IsSerialized = true, Value = template.Overrides.ColorScale[i].V[j].Value });
                    }
                    chunk.Overrides.ColorScale.Add(colorScale);
                }
                chunk.Overrides.RoughLevelsIn = new CArray<Multilayer_LayerTemplateOverridesLevels>(mltemplate, chunk.Overrides, "roughLevelsIn") { IsSerialized = true };
                for (int i = 0; i < template.Overrides.RoughLevelsIn.Length; i++)
                {
                    var roughLevelsIn = new Multilayer_LayerTemplateOverridesLevels(mltemplate, chunk.Overrides.RoughLevelsIn, Convert.ToString(i)) { IsSerialized = true };
                    roughLevelsIn.N = new CName(mltemplate, roughLevelsIn, "n") { IsSerialized = true, Value = template.Overrides.RoughLevelsIn[i].N };
                    for (int j = 0; j < template.Overrides.RoughLevelsIn[i].V.Length; j++)
                    {
                        roughLevelsIn.V.Add(new CFloat(mltemplate, roughLevelsIn.V, Convert.ToString(j)) { IsSerialized = true, Value = template.Overrides.RoughLevelsIn[i].V[j].Value });
                    }
                    chunk.Overrides.RoughLevelsIn.Add(roughLevelsIn);
                }
                chunk.Overrides.RoughLevelsOut = new CArray<Multilayer_LayerTemplateOverridesLevels>(mltemplate, chunk.Overrides, "roughLevelsOut") { IsSerialized = true };
                for (int i = 0; i < template.Overrides.RoughLevelsOut.Length; i++)
                {
                    var roughLevelsOut = new Multilayer_LayerTemplateOverridesLevels(mltemplate, chunk.Overrides.RoughLevelsOut, Convert.ToString(i)) { IsSerialized = true };
                    roughLevelsOut.N = new CName(mltemplate, roughLevelsOut, "n") { IsSerialized = true, Value = template.Overrides.RoughLevelsOut[i].N };
                    for (int j = 0; j < template.Overrides.RoughLevelsOut[i].V.Length; j++)
                    {
                        roughLevelsOut.V.Add(new CFloat(mltemplate, roughLevelsOut.V, Convert.ToString(j)) { IsSerialized = true, Value = template.Overrides.RoughLevelsOut[i].V[j].Value });
                    }
                    chunk.Overrides.RoughLevelsOut.Add(roughLevelsOut);
                }
                chunk.Overrides.MetalLevelsIn = new CArray<Multilayer_LayerTemplateOverridesLevels>(mltemplate, chunk.Overrides, "metalLevelsIn") { IsSerialized = true };
                for (int i = 0; i < template.Overrides.MetalLevelsIn.Length; i++)
                {
                    var metalLevelsIn = new Multilayer_LayerTemplateOverridesLevels(mltemplate, chunk.Overrides.MetalLevelsIn, Convert.ToString(i)) { IsSerialized = true };
                    metalLevelsIn.N = new CName(mltemplate, metalLevelsIn, "n") { IsSerialized = true, Value = template.Overrides.MetalLevelsIn[i].N };
                    for (int j = 0; j < template.Overrides.MetalLevelsIn[i].V.Length; j++)
                    {
                        metalLevelsIn.V.Add(new CFloat(mltemplate, metalLevelsIn.V, Convert.ToString(j)) { IsSerialized = true, Value = template.Overrides.MetalLevelsIn[i].V[j].Value });
                    }
                    chunk.Overrides.MetalLevelsIn.Add(metalLevelsIn);
                }
                chunk.Overrides.MetalLevelsOut = new CArray<Multilayer_LayerTemplateOverridesLevels>(mltemplate, chunk.Overrides, "metalLevelsOut") { IsSerialized = true };
                for (int i = 0; i < template.Overrides.MetalLevelsOut.Length; i++)
                {
                    var metalLevelsOut = new Multilayer_LayerTemplateOverridesLevels(mltemplate, chunk.Overrides.MetalLevelsOut, Convert.ToString(i)) { IsSerialized = true };
                    metalLevelsOut.N = new CName(mltemplate, metalLevelsOut, "n") { IsSerialized = true, Value = template.Overrides.MetalLevelsOut[i].N };
                    for (int j = 0; j < template.Overrides.MetalLevelsOut[i].V.Length; j++)
                    {
                        metalLevelsOut.V.Add(new CFloat(mltemplate, metalLevelsOut.V, Convert.ToString(j)) { IsSerialized = true, Value = template.Overrides.MetalLevelsOut[i].V[j].Value });
                    }
                    chunk.Overrides.MetalLevelsOut.Add(metalLevelsOut);
                }
                chunk.Overrides.NormalStrength = new CArray<Multilayer_LayerTemplateOverridesNormalStrength>(mltemplate, chunk.Overrides, "normalStrength") { IsSerialized = true };
                for (int i = 0; i < template.Overrides.NormalStrength.Length; i++)
                {
                    var normalStrength = new Multilayer_LayerTemplateOverridesNormalStrength(mltemplate, chunk.Overrides.NormalStrength, Convert.ToString(i)) { IsSerialized = true };
                    normalStrength.N = new CName(mltemplate, normalStrength, "n") { IsSerialized = true, Value = template.Overrides.NormalStrength[i].N };
                    if (template.Overrides.NormalStrength[i].V != null)
                    {
                        if(template.Overrides.NormalStrength[i].V[0].Value != 0f)
                        {
                            normalStrength.V = new CFloat(mltemplate, normalStrength, "v") { IsSerialized = true, Value = template.Overrides.NormalStrength[i].V[0].Value };
                        }
                    }
                    chunk.Overrides.NormalStrength.Add(normalStrength);
                }
                mltemplate.CreateChunk(chunk,0);
            }
            return mltemplate;
        }
    }
    public class HairProfile
    {
        public GradientEntry[] GradientEntriesID { get; set; }
        public GradientEntry[] GradientEntriesRootToTip { get; set; }
        public string Ext = ".hp";
        public class GradientEntry
        {
            public float Value;
            public Color Color;
            public GradientEntry(rendGradientEntry g)
            {
                Value = g.Value.Value;
                Color = new Color(g.Color);
            }
            public GradientEntry()
            {

            }
        }
        public HairProfile(CHairProfile c)
        {
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
        public HairProfile()
        {

        }
        public static CR2WFile Deserialize(HairProfile hp)
        {
            CR2WFile hairprofile = new CR2WFile();
            {
                var chunk = new CHairProfile(hairprofile, null, "CHairProfile") { IsSerialized = true };
                chunk.CookingPlatform = new CEnum<Enums.ECookingPlatform>(hairprofile, chunk, "cookingPlatform") { IsSerialized = true, Value = Enums.ECookingPlatform.PLATFORM_PC };
                chunk.CookingPlatform.EnumValueList.Add("PLATFORM_PC");
                
                chunk.GradientEntriesID = new CArray<rendGradientEntry>(hairprofile, chunk, "gradientEntriesID") { IsSerialized = true };
                
                for (int i = 0; i < hp.GradientEntriesID.Length; i++)
                {
                    var entry = new rendGradientEntry(hairprofile, chunk.GradientEntriesID, Convert.ToString(i)) { IsSerialized = true };
                    
                    if(hp.GradientEntriesID[i].Value !=0)
                    {
                        entry.Value = new CFloat(hairprofile, entry, "value") { IsSerialized = true, Value = hp.GradientEntriesID[i].Value };
                    }
                    
                    entry.Color = new CColor(hairprofile, entry, "color") { IsSerialized = true };
                    
                    entry.Color.Red = new CUInt8(hairprofile, entry.Color, "Red") { IsSerialized = true, Value = hp.GradientEntriesID[i].Color.Red };
                    entry.Color.Green = new CUInt8(hairprofile, entry.Color, "Green") { IsSerialized = true, Value = hp.GradientEntriesID[i].Color.Green };
                    entry.Color.Blue = new CUInt8(hairprofile, entry.Color, "Blue") { IsSerialized = true, Value = hp.GradientEntriesID[i].Color.Blue };
                    entry.Color.Alpha = new CUInt8(hairprofile, entry.Color, "Alpha") { IsSerialized = true, Value = hp.GradientEntriesID[i].Color.Alpha };

                    chunk.GradientEntriesID.Add(entry);
                }
                
                
                chunk.GradientEntriesRootToTip = new CArray<rendGradientEntry>(hairprofile, chunk, "gradientEntriesRootToTip") { IsSerialized = true };
                for (int i = 0; i < hp.GradientEntriesRootToTip.Length; i++)
                {
                    var entry = new rendGradientEntry(hairprofile, chunk.GradientEntriesRootToTip, Convert.ToString(i)) { IsSerialized = true };

                    if (hp.GradientEntriesRootToTip[i].Value != 0)
                    {
                        entry.Value = new CFloat(hairprofile, entry, "value") { IsSerialized = true, Value = hp.GradientEntriesRootToTip[i].Value };
                    }

                    entry.Color = new CColor(hairprofile, entry, "color") { IsSerialized = true };
                    entry.Color.Red = new CUInt8(hairprofile, entry.Color, "Red") { IsSerialized = true, Value = hp.GradientEntriesRootToTip[i].Color.Red };
                    entry.Color.Green = new CUInt8(hairprofile, entry.Color, "Green") { IsSerialized = true, Value = hp.GradientEntriesRootToTip[i].Color.Green };
                    entry.Color.Blue = new CUInt8(hairprofile, entry.Color, "Blue") { IsSerialized = true, Value = hp.GradientEntriesRootToTip[i].Color.Blue };
                    entry.Color.Alpha = new CUInt8(hairprofile, entry.Color, "Alpha") { IsSerialized = true, Value = hp.GradientEntriesRootToTip[i].Color.Alpha };

                    chunk.GradientEntriesRootToTip.Add(entry);
                }
                
                hairprofile.CreateChunk(chunk, 0);
            }
            return hairprofile;
        }
    }
}
