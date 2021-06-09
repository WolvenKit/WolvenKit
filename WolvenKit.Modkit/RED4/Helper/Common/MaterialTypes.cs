using WolvenKit.RED4.CR2W.Types;
using System;
using WolvenKit.Modkit.RED4.GeneralStructs;

namespace WolvenKit.Modkit.RED4.Materials.Types
{
    public enum MaterialType
    {
        Unknown, MultiLayered, MeshDecal, HumanSkin, MetalBase
    }
    public class MaterialInstanceData
    {
        public string MultilayerSetup { get; set; } = null;
        public string MultilayerMask { get; set; } = null;
        public string GlobalNormal { get; set; } = null;
        public string DiffuseTexture { get; set; } = null;
        public Vec4 DiffuseColor { get; set; }
        public Nullable<float> DiffuseAlpha { get; set; } = null;
        public Nullable<float> UVOffsetX { get; set; }
        public Nullable<float> UVOffsetY { get; set; }
        public Nullable<float> UVScaleX { get; set; }
        public Nullable<float> UVScaleY { get; set; }
        public Nullable<float> UVRotation { get; set; } = null;
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
        public string Roughness { get; set; } = null;
        public string DetailNormal { get; set; } = null;
        public Nullable<float> DetailNormalInfluence { get; set; } = null;
        public string Normal { get; set; } = null;
        public string Albedo { get; set; } = null;
        public string Detailmap_Squash { get; set; } = null;
        public string Detailmap_Stretch { get; set; } = null;
        public Nullable<float> DetailRoughnessBiasMin { get; set; } = null;
        public Nullable<float> DetailRoughnessBiasMax { get; set; } = null;
        public Vec4 TintColor { get; set; }
        public Nullable<float> TintScale { get; set; } = null;
        public string SkinProfile { get; set; } = null;
        public string Bloodflow { get; set; } = null;
        public Vec4 BloodColor { get; set; }
        public Nullable<float> MicroDetailUVScale01 { get; set; } = null;
        public Nullable<float> MicroDetailUVScale02 { get; set; } = null;
        public string TintColorMask { get; set; } = null;
        public Nullable<float> MicroDetailInfluence { get; set; } = null;
        public Nullable<float> CavityIntensity { get; set; } = null;
        public string BaseColor { get; set; } = null;
        public Vec4 BaseColorScale { get; set; }
        public Nullable<float> AlphaThreshold { get; set; } = null;
        public MaterialInstanceData(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];

                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;

                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;

                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "DiffuseColor")
                {
                    float x = (data.Variant as CColor).Red.Value / 255f;
                    float y = (data.Variant as CColor).Green.Value / 255f;
                    float z = (data.Variant as CColor).Blue.Value / 255f;
                    float w = (data.Variant as CColor).Alpha.Value / 255f;

                    DiffuseColor = new Vec4(x, y, z, w);
                }

                if (data.REDName == "DiffuseAlpha")
                    DiffuseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "UVOffsetX")
                    UVOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "UVOffsetY")
                    UVOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "UVRotation")
                    UVRotation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "UVScaleX")
                    UVScaleX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "UVScaleY")
                    UVScaleY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "SecondaryMask")
                    SecondaryMask = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "SecondaryMaskUVScale")
                    SecondaryMaskUVScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "SecondaryMaskInfluence")
                    SecondaryMaskInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "NormalAlpha")
                    NormalAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "NormalAlphaTex")
                    NormalAlphaTex = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "AnimationSpeed")
                    AnimationSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "AnimationFramesWidth")
                    AnimationFramesWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "AnimationFramesHeight")
                    AnimationFramesHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "DepthThreshold")
                    DepthThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "DetailNormal")
                    DetailNormal = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "DetailNormalInfluence")
                    DetailNormalInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "Albedo")
                    Albedo = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "Detailmap_Squash")
                    Detailmap_Squash = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "Detailmap_Stretch")
                    Detailmap_Stretch = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "DetailRoughnessBiasMin")
                    DetailRoughnessBiasMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "DetailRoughnessBiasMax")
                    DetailRoughnessBiasMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "TintColor")
                {
                    float x = (data.Variant as CColor).Red.Value / 255f;
                    float y = (data.Variant as CColor).Green.Value / 255f;
                    float z = (data.Variant as CColor).Blue.Value / 255f;
                    float w = (data.Variant as CColor).Alpha.Value / 255f;

                    TintColor = new Vec4(x, y, z, w);
                }
                if (data.REDName == "TintScale")
                    TintScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "SkinProfile")
                    SkinProfile = (data.Variant as rRef<CSkinProfile>).DepotPath;
                if (data.REDName == "Bloodflow")
                    Bloodflow = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "BloodColor")
                {
                    float x = (data.Variant as CColor).Red.Value / 255f;
                    float y = (data.Variant as CColor).Green.Value / 255f;
                    float z = (data.Variant as CColor).Blue.Value / 255f;
                    float w = (data.Variant as CColor).Alpha.Value / 255f;

                    BloodColor = new Vec4(x, y, z, w);
                }

                if (data.REDName == "MicroDetailUVScale01")
                    MicroDetailUVScale01 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "MicroDetailUVScale02")
                    MicroDetailUVScale02 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "TintColorMask")
                    TintColorMask = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "MicroDetailInfluence")
                    MicroDetailInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "CavityIntensity")
                    CavityIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;

                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;

                if (data.REDName == "BaseColorScale")
                {
                    float x = (data.Variant as Vector4).X.Value;
                    float y = (data.Variant as Vector4).Y.Value;
                    float z = (data.Variant as Vector4).Z.Value;
                    float w = (data.Variant as Vector4).W.Value;

                    BaseColorScale = new Vec4(x, y, z, w);
                }
            }
        }
    }
    public class Vec4
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W { get; set; }

        public Vec4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
}
