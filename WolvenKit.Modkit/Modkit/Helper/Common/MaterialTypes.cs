using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.RED4.MeshFile.Materials.MaterialTypes
{
    public enum MaterialType
    {
        MultiLayered, MeshDecal, HoomanSkin
    }
    public class MultiLayered
    {
        public string multilayerSetup { get; set; } = null;
        public string multilayerMask { get; set; } = null;
        public string globalNormal { get; set; } = null;
        public MultiLayered(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MultilayerSetup")
                    multilayerSetup = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<Multilayer_Setup>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MultilayerMask")
                    multilayerMask = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<Multilayer_Mask>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "GlobalNormal")
                    globalNormal = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public class MeshDecal
    {
        public string diffuseTexture { get; set; } = null;
        public Color diffuseColor { get; set; }
        public float diffuseAlpha { get; set; } = 9999;
        public Struct2D uVOffset { get; set; }
        public float uVRotation { get; set; } = 9999;
        public Struct2D uVScale { get; set; }
        public string secondaryMask { get; set; } = null;
        public float secondaryMaskUVScale { get; set; } = 9999;
        public float secondaryMaskInfluence { get; set; } = 9999;
        public string normalTexture { get; set; } = null;
        public float normalAlpha { get; set; } = 9999;
        public string normalAlphaTex { get; set; } = null;
        public float normalsBlendingMode { get; set; } = 9999;
        public string roughnessTexture { get; set; } = null;
        public string metalnessTexture { get; set; } = null;
        public float alphaMaskContrast { get; set; } = 9999;
        public float roughnessMetalnessAlpha { get; set; } = 9999;
        public float animationSpeed { get; set; } = 9999;
        public float animationFramesWidth { get; set; } = 9999;
        public float animationFramesHeight { get; set; } = 9999;
        public float depthThreshold { get; set; } = 9999;

        public MeshDecal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DiffuseTexture")
                    diffuseTexture = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DiffuseColor")
                {
                    float x = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Red.Value / 255f;
                    float y = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Green.Value / 255f;
                    float z = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Blue.Value / 255f;
                    float w = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Alpha.Value / 255f;

                    diffuseColor = new Color(x, y, z, w);
                }
                System.Numerics.Vector2 uvOff = new System.Numerics.Vector2();
                System.Numerics.Vector2 uvSca = new System.Numerics.Vector2();
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DiffuseAlpha")
                    diffuseAlpha = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "UVOffsetX")
                    uvOff.X = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "UVOffsetY")
                    uvOff.Y = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "UVRotation")
                    uVRotation = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "UVScaleX")
                    uvSca.X = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "UVScaleY")
                    uvSca.Y = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "SecondaryMask")
                    secondaryMask = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "SecondaryMaskUVScale")
                    secondaryMaskUVScale = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "SecondaryMaskInfluence")
                    secondaryMaskInfluence = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "NormalTexture")
                    normalTexture = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "NormalAlpha")
                    normalAlpha = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "NormalAlphaTex")
                    normalAlphaTex = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "NormalsBlendingMode")
                    normalsBlendingMode = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "RoughnessTexture")
                    roughnessTexture = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MetalnessTexture")
                    metalnessTexture = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "AlphaMaskContrast")
                    alphaMaskContrast = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "RoughnessMetalnessAlpha")
                    roughnessMetalnessAlpha = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "AnimationSpeed")
                    animationSpeed = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "AnimationFramesWidth")
                    animationFramesWidth = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "AnimationFramesHeight")
                    animationFramesHeight = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DepthThreshold")
                    depthThreshold = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

                uVScale = new Struct2D(uvSca.X, uvSca.Y);
                uVOffset = new Struct2D(uvSca.X, uvSca.Y);
            }
        }
    }
    
    public class HumanSkin
    {
        public string roughness { get; set; } = null;
        public string detailNormal { get; set; } = null;
        public float detailNormalInfluence { get; set; } = 9999;
        public string normal { get; set; } = null;
        public string albedo { get; set; } = null;
        public string detailmap_Squash { get; set; } = null;
        public string detailmap_Stretch { get; set; } = null;
        public float detailRoughnessBiasMin { get; set; } = 9999;
        public float detailRoughnessBiasMax { get; set; } = 9999;
        public Color tintColor { get; set; }
        public float tintScale { get; set; } = 9999;
        public string skinProfile { get; set; } = null;
        public string bloodflow { get; set; } = null;
        public Color bloodColor { get; set; }
        public float microDetailUVScale01 { get; set; } = 9999;
        public float microDetailUVScale02 { get; set; } = 9999;
        public string tintColorMask { get; set; } = null;
        public float microDetailInfluence { get; set; } = 9999;
        public float cavityIntensity { get; set; } = 9999;

        public HumanSkin(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Roughness")
                    roughness = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DetailNormal")
                    detailNormal = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DetailNormalInfluence")
                    detailNormalInfluence = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Normal")
                    normal = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Albedo")
                    albedo = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Detailmap_Squash")
                    detailmap_Squash = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Detailmap_Stretch")
                    detailmap_Stretch = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DetailRoughnessBiasMin")
                    detailRoughnessBiasMin = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "DetailRoughnessBiasMax")
                    detailRoughnessBiasMax = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "TintColor")
                {
                    float x = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Red.Value / 255f;
                    float y = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Green.Value / 255f;
                    float z = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Blue.Value / 255f;
                    float w = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Alpha.Value / 255f;

                    tintColor = new Color(x, y, z, w);
                }
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "TintScale")
                    tintScale = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "SkinProfile")
                    skinProfile = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<CSkinProfile>).DepotPath;
                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "Bloodflow")
                    bloodflow = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "BloodColor")
                {
                    float x = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Red.Value / 255f;
                    float y = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Green.Value / 255f;
                    float z = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Blue.Value / 255f;
                    float w = (cMaterialInstance.CMaterialInstanceData[i].Variant as CColor).Alpha.Value / 255f;

                    bloodColor = new Color(x, y, z, w);
                }

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MicroDetailUVScale01")
                    microDetailUVScale01 = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MicroDetailUVScale02")
                    microDetailUVScale02 = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "TintColorMask")
                    tintColorMask = (cMaterialInstance.CMaterialInstanceData[i].Variant as rRef<ITexture>).DepotPath;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "MicroDetailInfluence")
                    microDetailInfluence = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

                if (cMaterialInstance.CMaterialInstanceData[i].REDName == "CavityIntensity")
                    cavityIntensity = (cMaterialInstance.CMaterialInstanceData[i].Variant as CFloat).Value;

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
