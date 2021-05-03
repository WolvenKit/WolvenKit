using WolvenKit.RED4.CR2W.Types;
using System;
namespace WolvenKit.RED4.MeshFile.Materials.MaterialTypes
{
    public enum MaterialType
    {
        MultiLayered, MeshDecal, HumanSkin
    }
    public class MultiLayered
    {
        public string MultilayerSetup { get; set; } = null;
        public string MultilayerMask { get; set; } = null;
        public string GlobalNormal { get; set; } = null;
        public MultiLayered(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MultilayerSetup")
                    MultilayerSetup = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<Multilayer_Setup>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MultilayerMask")
                    MultilayerMask = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<Multilayer_Mask>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "GlobalNormal")
                    GlobalNormal = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public class MeshDecal
    {
        public string DiffuseTexture { get; set; } = null;
        public Color DiffuseColor { get; set; }
        public Nullable<float> DiffuseAlpha { get; set; } = null;
        public Struct2D UVOffset { get; set; }
        public Nullable<float> UVRotation { get; set; } = null;
        public Struct2D UVScale { get; set; }
        public string SecondaryMask { get; set; } = null;
        public Nullable<float> SecondaryMaskUVScale { get; set; } = null;
        public Nullable<float> SecondaryMaskInfluence { get; set; } = null;
        public string NormalTexture { get; set; } = null;
        public Nullable<float> NormalAlpha { get; set; } = null;
        public string NormalAlphaTex { get; set; } = null;
        public Nullable<float> NormalsBlendingMode { get; set; } = null;
        public string RoughnessTexture { get; set; } = null;
        public string MetalnessTexture { get; set; } = null;
        public Nullable<float> AlphaMaskContrast { get; set; } = null;
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = null;
        public Nullable<float> AnimationSpeed { get; set; } = null;
        public Nullable<float> AnimationFramesWidth { get; set; } = null;
        public Nullable<float> AnimationFramesHeight { get; set; } = null;
        public Nullable<float> DepthThreshold { get; set; } = null;

        public MeshDecal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DiffuseTexture")
                    DiffuseTexture = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DiffuseColor")
                {
                    float x = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Red.Value / 255f;
                    float y = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Green.Value / 255f;
                    float z = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Blue.Value / 255f;
                    float w = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Alpha.Value / 255f;

                    DiffuseColor = new Color(x, y, z, w);
                }
                System.Numerics.Vector2 uvOff = new System.Numerics.Vector2();
                System.Numerics.Vector2 uvSca = new System.Numerics.Vector2();
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DiffuseAlpha")
                    DiffuseAlpha = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "UVOffsetX")
                    uvOff.X = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "UVOffsetY")
                    uvOff.Y = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "UVRotation")
                    UVRotation = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "UVScaleX")
                    uvSca.X = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "UVScaleY")
                    uvSca.Y = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "SecondaryMask")
                    SecondaryMask = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "SecondaryMaskUVScale")
                    SecondaryMaskUVScale = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "SecondaryMaskInfluence")
                    SecondaryMaskInfluence = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "NormalTexture")
                    NormalTexture = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "NormalAlpha")
                    NormalAlpha = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "NormalAlphaTex")
                    NormalAlphaTex = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "RoughnessTexture")
                    RoughnessTexture = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MetalnessTexture")
                    MetalnessTexture = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "AnimationSpeed")
                    AnimationSpeed = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "AnimationFramesWidth")
                    AnimationFramesWidth = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "AnimationFramesHeight")
                    AnimationFramesHeight = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DepthThreshold")
                    DepthThreshold = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

                UVScale = new Struct2D(uvSca.X, uvSca.Y);
                UVOffset = new Struct2D(uvSca.X, uvSca.Y);
            }
        }
    }
    public class HumanSkin
    {
        public string Roughness { get; set; } = null;
        public string DetailNormal { get; set; } = null;
        public Nullable<float> DetailNormalInfluence { get; set; } = null;
        public string Normal { get; set; } = null;
        public string Albedo { get; set; } = null;
        public string Detailmap_Squash { get; set; } = null;
        public string Detailmap_Stretch { get; set; } = null;
        public Nullable<float> DetailRoughnessBiasMin { get; set; } = null;
        public Nullable<float> DetailRoughnessBiasMax { get; set; } = null;
        public Color TintColor { get; set; }
        public Nullable<float> TintScale { get; set; } = null;
        public string SkinProfile { get; set; } = null;
        public string Bloodflow { get; set; } = null;
        public Color BloodColor { get; set; }
        public Nullable<float> MicroDetailUVScale01 { get; set; } = null;
        public Nullable<float> MicroDetailUVScale02 { get; set; } = null;
        public string TintColorMask { get; set; } = null;
        public Nullable<float> MicroDetailInfluence { get; set; } = null;
        public Nullable<float> CavityIntensity { get; set; } = null;

        public HumanSkin(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Roughness")
                    Roughness = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DetailNormal")
                    DetailNormal = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DetailNormalInfluence")
                    DetailNormalInfluence = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Normal")
                    Normal = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Albedo")
                    Albedo = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Detailmap_Squash")
                    Detailmap_Squash = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Detailmap_Stretch")
                    Detailmap_Stretch = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DetailRoughnessBiasMin")
                    DetailRoughnessBiasMin = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DetailRoughnessBiasMax")
                    DetailRoughnessBiasMax = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "TintColor")
                {
                    float x = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Red.Value / 255f;
                    float y = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Green.Value / 255f;
                    float z = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Blue.Value / 255f;
                    float w = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Alpha.Value / 255f;

                    TintColor = new Color(x, y, z, w);
                }
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "TintScale")
                    TintScale = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "SkinProfile")
                    SkinProfile = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<CSkinProfile>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Bloodflow")
                    Bloodflow = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "BloodColor")
                {
                    float x = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Red.Value / 255f;
                    float y = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Green.Value / 255f;
                    float z = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Blue.Value / 255f;
                    float w = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Alpha.Value / 255f;

                    BloodColor = new Color(x, y, z, w);
                }

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MicroDetailUVScale01")
                    MicroDetailUVScale01 = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MicroDetailUVScale02")
                    MicroDetailUVScale02 = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "TintColorMask")
                    TintColorMask = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MicroDetailInfluence")
                    MicroDetailInfluence = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "CavityIntensity")
                    CavityIntensity = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

            }
        }
        
    }
    public class Color
    {
        public float R { get; set; }
        public float G { get; set; }
        public float B { get; set; }
        public float A { get; set; }

        public Color(float x, float y, float z, float w)
        {
            this.R = x;
            this.G = y;
            this.B = z;
            this.A = w;
        }
    }
    public class Struct2D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Struct2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    public class Struct3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public Struct3D(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
