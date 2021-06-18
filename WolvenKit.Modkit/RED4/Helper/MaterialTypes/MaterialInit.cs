using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.Modkit.RED4.Materials.Types
{
    public partial class _3d_map
    {
        public _3d_map() { }
        public _3d_map(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Lighting")
                    Lighting = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParticleSize")
                    ParticleSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldScale")
                    WorldScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldColorTex")
                    WorldColorTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldPosTex")
                    WorldPosTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldNormalTex")
                    WorldNormalTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldDepthTex")
                    WorldDepthTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _3d_map_cubes
    {
        public _3d_map_cubes() { }
        public _3d_map_cubes(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "PointCloudTextureHeight")
                    PointCloudTextureHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TransMin")
                    TransMin = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TransMax")
                    TransMax = new Vec4(data.Variant as Vector4);
                if (data.REDName == "WorldPosTex")
                    WorldPosTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "CubeSize")
                    CubeSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorGradient")
                    ColorGradient = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugScaleOffset")
                    DebugScaleOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DissolveDistance")
                    DissolveDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissolveBandWidth")
                    DissolveBandWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissolveCellSize")
                    DissolveCellSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissolveBurnColor")
                    DissolveBurnColor = new Color(data.Variant as CColor);
                if (data.REDName == "DissolveBurnStrength")
                    DissolveBurnStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissolveBurnMinCameraSpeed")
                    DissolveBurnMinCameraSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MapEdgeDissolveCenter")
                    MapEdgeDissolveCenter = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MapEdgeDissolveRadiusStart")
                    MapEdgeDissolveRadiusStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MapEdgeDissolveRadiusBand")
                    MapEdgeDissolveRadiusBand = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MapEdgeDissolveCellSize")
                    MapEdgeDissolveCellSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "EdgeColor")
                    EdgeColor = new Color(data.Variant as CColor);
                if (data.REDName == "EdgeThickness")
                    EdgeThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EdgeSharpnessPower")
                    EdgeSharpnessPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _3d_map_solid
    {
        public _3d_map_solid() { }
        public _3d_map_solid(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "RenderOnTop")
                    RenderOnTop = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _beyondblackwall
    {
        public _beyondblackwall() { }
        public _beyondblackwall(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseMap")
                    DiffuseMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "HeightMap")
                    HeightMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Height")
                    Height = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Intensity")
                    Intensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimBlend")
                    AnimBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallDistortionStrenght")
                    SmallDistortionStrenght = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BigDistortionStrenght")
                    BigDistortionStrenght = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallDistortionTime")
                    SmallDistortionTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BigDistortionTime")
                    BigDistortionTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VignetteIntensity")
                    VignetteIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LuminancePower")
                    LuminancePower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CompareValue")
                    CompareValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "PixelStretchBlend")
                    PixelStretchBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _beyondblackwall_chars
    {
        public _beyondblackwall_chars() { }
        public _beyondblackwall_chars(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "TextureColorBlend")
                    TextureColorBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AtlasSize")
                    AtlasSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AtlasID")
                    AtlasID = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallDistortionStrenght")
                    SmallDistortionStrenght = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BigDistortionStrenght")
                    BigDistortionStrenght = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallDistortionTime")
                    SmallDistortionTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BigDistortionTime")
                    BigDistortionTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _beyondblackwall_sky
    {
        public _beyondblackwall_sky() { }
        public _beyondblackwall_sky(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "SkyDiffuse")
                    SkyDiffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SkySorted")
                    SkySorted = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SkySortMask")
                    SkySortMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NoiseMap")
                    NoiseMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SilhouetteDiffuse")
                    SilhouetteDiffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SilhouetteMask")
                    SilhouetteMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightDirectionHorizontal")
                    LightDirectionHorizontal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightDirectionVertical")
                    LightDirectionVertical = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Wrap")
                    Wrap = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WrapIntensity")
                    WrapIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlashIntensity")
                    FlashIntensity = new Vec4(data.Variant as Vector4);
                if (data.REDName == "FlashTimeScale")
                    FlashTimeScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "LightColor")
                    LightColor = new Color(data.Variant as CColor);
                if (data.REDName == "SkyAmbient")
                    SkyAmbient = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SkyParameter")
                    SkyParameter = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SilhouetteUV")
                    SilhouetteUV = new Vec4(data.Variant as Vector4);
                if (data.REDName == "CompareValue")
                    CompareValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _beyondblackwall_sky_raymarch
    {
        public _beyondblackwall_sky_raymarch() { }
        public _beyondblackwall_sky_raymarch(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseTexture3D")
                    NoiseTexture3D = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "VolumeNoise")
                    VolumeNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScreenNoise")
                    ScreenNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LightColor")
                    LightColor = new Color(data.Variant as CColor);
                if (data.REDName == "LightIntensity")
                    LightIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightVectorXY")
                    LightVectorXY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightVectorZ")
                    LightVectorZ = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SkyColor")
                    SkyColor = new Color(data.Variant as CColor);
                if (data.REDName == "VectorNoiseSize")
                    VectorNoiseSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorNoiseIntensity")
                    VectorNoiseIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AmbientLightTop")
                    AmbientLightTop = new Color(data.Variant as CColor);
                if (data.REDName == "AmbientLightBottom")
                    AmbientLightBottom = new Color(data.Variant as CColor);
                if (data.REDName == "CoverageShift")
                    CoverageShift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "JitterIntensity")
                    JitterIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmisssivIntensity")
                    EmisssivIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CloudScaleXY")
                    CloudScaleXY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CloudScaleZ")
                    CloudScaleZ = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CloudPositionZ")
                    CloudPositionZ = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseOffset")
                    NoiseOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "FlashAreaOffset")
                    FlashAreaOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SphereOffsetZ")
                    SphereOffsetZ = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SphereSize")
                    SphereSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SphereOffsetVec")
                    SphereOffsetVec = new Vec4(data.Variant as Vector4);
                if (data.REDName == "NoiseSize")
                    NoiseSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CloudDensity")
                    CloudDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DetailNoiseSize")
                    DetailNoiseSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DetailNoiseOffset")
                    DetailNoiseOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScreenNoiseVec")
                    ScreenNoiseVec = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Samples")
                    Samples = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SkyBlend")
                    SkyBlend = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Scatter")
                    Scatter = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SilverLightCone")
                    SilverLightCone = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _blood_puddle_decal
    {
        public _blood_puddle_decal() { }
        public _blood_puddle_decal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "NoiseTexture")
                    NoiseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Squash")
                    Squash = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Curls")
                    Curls = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Details")
                    Details = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Thickness")
                    Thickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ProgressiveOpacity")
                    ProgressiveOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cable
    {
        public _cable() { }
        public _cable(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VehicleDamageInfluence")
                    VehicleDamageInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThicknessStart")
                    ThicknessStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThicknessEnd")
                    ThicknessEnd = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RangeStart")
                    RangeStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RangeEnd")
                    RangeEnd = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveLift")
                    EmissiveLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _circuit_wires
    {
        public _circuit_wires() { }
        public _circuit_wires(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "PointCloudTextureRes")
                    PointCloudTextureRes = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TransMin")
                    TransMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TransMax")
                    TransMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldPosTex")
                    WorldPosTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WireThickness")
                    WireThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InstanceOffset")
                    InstanceOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "LocalNormal")
                    LocalNormal = new Vec4(data.Variant as Vector4);
                if (data.REDName == "BevelStrenght")
                    BevelStrenght = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugVC")
                    DebugVC = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugID")
                    DebugID = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cloth_mov
    {
        public _cloth_mov() { }
        public _cloth_mov(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "vertex_paint_tex")
                    vertex_paint_tex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "trans_min")
                    trans_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_max")
                    trans_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_pieces")
                    n_pieces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "play_time")
                    play_time = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cloth_mov_multilayered
    {
        public _cloth_mov_multilayered() { }
        public _cloth_mov_multilayered(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "vertex_paint_tex")
                    vertex_paint_tex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "trans_min")
                    trans_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_max")
                    trans_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_pieces")
                    n_pieces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "play_time")
                    play_time = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SetupLayerMask")
                    SetupLayerMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cyberparticles_base
    {
        public _cyberparticles_base() { }
        public _cyberparticles_base(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "trans_extent")
                    trans_extent = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Contrast")
                    Contrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AddSizeX")
                    AddSizeX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AddSizeY")
                    AddSizeY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Width")
                    Width = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Height")
                    Height = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldColorTex")
                    WorldColorTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldPosTex")
                    WorldPosTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldSize")
                    WorldSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParticleSize")
                    ParticleSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissolveTime")
                    DissolveTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissolveGlobalTime")
                    DissolveGlobalTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissolveDeltaScale")
                    DissolveDeltaScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissolveNoiseScale")
                    DissolveNoiseScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissolveParticleSize")
                    DissolveParticleSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WarpTime")
                    WarpTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WarpLocation")
                    WarpLocation = new Vec4(data.Variant as Vector4);
                if (data.REDName == "StretchMul")
                    StretchMul = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "StretchMax")
                    StretchMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UnRevealTime")
                    UnRevealTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Displace01")
                    Displace01 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Displace02")
                    Displace02 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlobalNoiseScale")
                    GlobalNoiseScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "VectorFieldSliceCount")
                    VectorFieldSliceCount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Tint")
                    Tint = new Color(data.Variant as CColor);
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _cyberparticles_blackwall
    {
        public _cyberparticles_blackwall() { }
        public _cyberparticles_blackwall(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VideoRT")
                    VideoRT = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GradientTex")
                    GradientTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DisturbTex")
                    DisturbTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UsesInstancing")
                    UsesInstancing = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisturbRadius")
                    DisturbRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisturbCurveFrequency")
                    DisturbCurveFrequency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisturbMul")
                    DisturbMul = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisturbTime")
                    DisturbTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisturbNoiseScale")
                    DisturbNoiseScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisturbScale")
                    DisturbScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisturbBrighten")
                    DisturbBrighten = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisturbLocation1")
                    DisturbLocation1 = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DisturbLocation2")
                    DisturbLocation2 = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TimeFactor")
                    TimeFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Scale")
                    Scale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Dimensions")
                    Dimensions = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexTiling")
                    TexTiling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Contrast")
                    Contrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AddSizeX")
                    AddSizeX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AddSizeY")
                    AddSizeY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParticleSize")
                    ParticleSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WarpTime")
                    WarpTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WarpLocation")
                    WarpLocation = new Vec4(data.Variant as Vector4);
                if (data.REDName == "StretchMul")
                    StretchMul = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "StretchMax")
                    StretchMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CNoiseAdjust")
                    CNoiseAdjust = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Align")
                    Align = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HighFreqFade")
                    HighFreqFade = new Vec4(data.Variant as Vector4);
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "VectorFieldSliceCount")
                    VectorFieldSliceCount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Tint")
                    Tint = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _cyberparticles_blackwall_touch
    {
        public _cyberparticles_blackwall_touch() { }
        public _cyberparticles_blackwall_touch(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RippleSize")
                    RippleSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RippleSpeed")
                    RippleSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RippleNumber")
                    RippleNumber = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RippleHeight")
                    RippleHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RipplePosition")
                    RipplePosition = new Vec4(data.Variant as Vector4);
                if (data.REDName == "RippleDirection")
                    RippleDirection = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TimeFactor")
                    TimeFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Scale")
                    Scale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Dimensions")
                    Dimensions = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexTiling")
                    TexTiling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Contrast")
                    Contrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AddSizeX")
                    AddSizeX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AddSizeY")
                    AddSizeY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParticleSize")
                    ParticleSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WarpTime")
                    WarpTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WarpLocation")
                    WarpLocation = new Vec4(data.Variant as Vector4);
                if (data.REDName == "StretchMul")
                    StretchMul = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "StretchMax")
                    StretchMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Tint")
                    Tint = new Color(data.Variant as CColor);
                if (data.REDName == "TintPulse")
                    TintPulse = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _cyberparticles_braindance
    {
        public _cyberparticles_braindance() { }
        public _cyberparticles_braindance(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DebugAlwaysShow")
                    DebugAlwaysShow = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugDisplayUV")
                    DebugDisplayUV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NumQuadsX")
                    NumQuadsX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParticleSize")
                    ParticleSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldPosTex")
                    WorldPosTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RevealMask")
                    RevealMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RevealMaskFramesY")
                    RevealMaskFramesY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RevealMaskBoundsMin")
                    RevealMaskBoundsMin = new Vec4(data.Variant as Vector4);
                if (data.REDName == "RevealMaskBoundsMax")
                    RevealMaskBoundsMax = new Vec4(data.Variant as Vector4);
                if (data.REDName == "FlowMap0")
                    FlowMap0 = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "CluesMap")
                    CluesMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "CharacterBlobRadius")
                    CharacterBlobRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskParticle")
                    MaskParticle = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _cyberparticles_dynamic
    {
        public _cyberparticles_dynamic() { }
        public _cyberparticles_dynamic(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParticleSize")
                    ParticleSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "JitterStrength")
                    JitterStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldPosTex")
                    WorldPosTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalTex")
                    NormalTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NumQuadsX")
                    NumQuadsX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "VectorFieldSliceCount")
                    VectorFieldSliceCount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorFieldTiling")
                    VectorFieldTiling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "VectorFieldAnimSpeed")
                    VectorFieldAnimSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "VectorFieldDisplacementStrength")
                    VectorFieldDisplacementStrength = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Scale")
                    Scale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UsePivotAsOffset")
                    UsePivotAsOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OriginalPivotWorldPosition")
                    OriginalPivotWorldPosition = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ColorMain")
                    ColorMain = new Color(data.Variant as CColor);
                if (data.REDName == "Brightness")
                    Brightness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BrightnessTop")
                    BrightnessTop = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HACK_Q110_IsElder")
                    HACK_Q110_IsElder = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cyberparticles_platform
    {
        public _cyberparticles_platform() { }
        public _cyberparticles_platform(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BlueNoise")
                    BlueNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DataTex")
                    DataTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BlackTex")
                    BlackTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UnRevealTime")
                    UnRevealTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RevealDirection")
                    RevealDirection = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMul")
                    ColorMul = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MovementScale")
                    MovementScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistanceFade")
                    DistanceFade = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FloorScale")
                    FloorScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlockSize")
                    BlockSize = new Vec4(data.Variant as Vector4);
                if (data.REDName == "CityTilingX")
                    CityTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CityTilingY")
                    CityTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SideTilingX")
                    SideTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SideTilingY")
                    SideTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AddSizeX")
                    AddSizeX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AddSizeY")
                    AddSizeY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Width")
                    Width = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Height")
                    Height = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Depth")
                    Depth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseScale")
                    NoiseScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "NoiseSize")
                    NoiseSize = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TranslateTime")
                    TranslateTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TranslateDestination")
                    TranslateDestination = new Vec4(data.Variant as Vector4);
                if (data.REDName == "StretchMul")
                    StretchMul = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "StretchMax")
                    StretchMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Tint")
                    Tint = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _decal_emissive_color
    {
        public _decal_emissive_color() { }
        public _decal_emissive_color(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveAlphaThreshold")
                    EmissiveAlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_emissive_only
    {
        public _decal_emissive_only() { }
        public _decal_emissive_only(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "EmissiveMask")
                    EmissiveMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveAlphaThreshold")
                    EmissiveAlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_forward
    {
        public _decal_forward() { }
        public _decal_forward(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Alpha")
                    Alpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_gradientmap_recolor
    {
        public _decal_gradientmap_recolor() { }
        public _decal_gradientmap_recolor(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientMap")
                    GradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_gradientmap_recolor_emissive
    {
        public _decal_gradientmap_recolor_emissive() { }
        public _decal_gradientmap_recolor_emissive(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientMap")
                    GradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveGradientMap")
                    EmissiveGradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_normal_roughness
    {
        public _decal_normal_roughness() { }
        public _decal_normal_roughness(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_normal_roughness_metalness
    {
        public _decal_normal_roughness_metalness() { }
        public _decal_normal_roughness_metalness(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_normal_roughness_metalness_2
    {
        public _decal_normal_roughness_metalness_2() { }
        public _decal_normal_roughness_metalness_2(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AtlasSize")
                    AtlasSize = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SubRegion")
                    SubRegion = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _decal_parallax
    {
        public _decal_parallax() { }
        public _decal_parallax(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AtlasSize")
                    AtlasSize = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SubRegion")
                    SubRegion = new Vec4(data.Variant as Vector4);
                if (data.REDName == "HeightTexture")
                    HeightTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "HeightStrength")
                    HeightStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_puddle
    {
        public _decal_puddle() { }
        public _decal_puddle(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseAlpha")
                    DiffuseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_roughness
    {
        public _decal_roughness() { }
        public _decal_roughness(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_roughness_only
    {
        public _decal_roughness_only() { }
        public _decal_roughness_only(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_terrain_projected
    {
        public _decal_terrain_projected() { }
        public _decal_terrain_projected(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AlphaMask")
                    AlphaMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaMaskBlackPoint")
                    AlphaMaskBlackPoint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaMaskWhitePoint")
                    AlphaMaskWhitePoint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SpecularIntensity")
                    SpecularIntensity = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessLevels")
                    RoughnessLevels = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SpecularIntensityLevels")
                    SpecularIntensityLevels = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ColorMaskLevels")
                    ColorMaskLevels = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Microblend")
                    Microblend = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MicroblendContrast")
                    MicroblendContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaterialTiling")
                    MaterialTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTiling")
                    LayerTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MicroblendTiling")
                    MicroblendTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_tintable
    {
        public _decal_tintable() { }
        public _decal_tintable(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintMaskTexture")
                    TintMaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskColorR")
                    MaskColorR = new Color(data.Variant as CColor);
                if (data.REDName == "MaskColorG")
                    MaskColorG = new Color(data.Variant as CColor);
                if (data.REDName == "MaskColorB")
                    MaskColorB = new Color(data.Variant as CColor);
                if (data.REDName == "AtlasSize")
                    AtlasSize = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SubRegion")
                    SubRegion = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _diode_sign
    {
        public _diode_sign() { }
        public _diode_sign(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "ColorForeground")
                    ColorForeground = new Color(data.Variant as CColor);
                if (data.REDName == "ColorMiddle")
                    ColorMiddle = new Color(data.Variant as CColor);
                if (data.REDName == "ColorBackground")
                    ColorBackground = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HeightIndex")
                    HeightIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WidthPixels")
                    WidthPixels = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "StretchFactor")
                    StretchFactor = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScrollSpeed")
                    ScrollSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotSize")
                    DotSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Multiplier")
                    Multiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AmountOfLayers")
                    AmountOfLayers = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsSpacing")
                    DotsSpacing = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FarDotMultiplier")
                    FarDotMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WidthPixelsStart")
                    WidthPixelsStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AllWidthPixels")
                    AllWidthPixels = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AmountOfLines")
                    AmountOfLines = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Text")
                    Text = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _earth_globe
    {
        public _earth_globe() { }
        public _earth_globe(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;
                if (data.REDName == "MultilayerBlendStrength")
                    MultilayerBlendStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CloudsMicroblend")
                    CloudsMicroblend = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "CityLightsMicroblend")
                    CityLightsMicroblend = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SetupLayerMask")
                    SetupLayerMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "SunDirection")
                    SunDirection = new Vec4(data.Variant as Vector4);
                if (data.REDName == "WaterMask")
                    WaterMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Clouds")
                    Clouds = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "CityLights")
                    CityLights = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CloudIntensity")
                    CloudIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CityLightsColor")
                    CityLightsColor = new Color(data.Variant as CColor);
                if (data.REDName == "OceanDetailNormalMap")
                    OceanDetailNormalMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "OceanRoughness")
                    OceanRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _earth_globe_atmosphere
    {
        public _earth_globe_atmosphere() { }
        public _earth_globe_atmosphere(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AtmosphereColor")
                    AtmosphereColor = new Color(data.Variant as CColor);
                if (data.REDName == "AtmosphereOrangeColor")
                    AtmosphereOrangeColor = new Color(data.Variant as CColor);
                if (data.REDName == "Brigthness")
                    Brigthness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelPower")
                    FresnelPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TransmissionBoost")
                    TransmissionBoost = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TransmissionBoostPower")
                    TransmissionBoostPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EarthRadius")
                    EarthRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SunDirection")
                    SunDirection = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _earth_globe_lights
    {
        public _earth_globe_lights() { }
        public _earth_globe_lights(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationSpeed")
                    AnimationSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationFramesWidth")
                    AnimationFramesWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationFramesHeight")
                    AnimationFramesHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollSpeed")
                    ScrollSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "HardOrSoftTransition")
                    HardOrSoftTransition = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FullVisibilityFactor")
                    FullVisibilityFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableAlternateUVcoord")
                    EnableAlternateUVcoord = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Preview2ndState")
                    Preview2ndState = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CityLightsMicroblend")
                    CityLightsMicroblend = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SunDirection")
                    SunDirection = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _emissive_control
    {
        public _emissive_control() { }
        public _emissive_control(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _eye
    {
        public _eye() { }
        public _eye(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Albedo")
                    Albedo = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Blick")
                    Blick = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalBubble")
                    NormalBubble = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RefractionIndex")
                    RefractionIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionAmount")
                    RefractionAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeRadius")
                    EyeRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeHorizAngleRight")
                    EyeHorizAngleRight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeHorizAngleLeft")
                    EyeHorizAngleLeft = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeParallaxPlane")
                    EyeParallaxPlane = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IrisSize")
                    IrisSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IrisCoordMargin")
                    IrisCoordMargin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IrisCoordFactor")
                    IrisCoordFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlickScale")
                    BlickScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BubbleNormalTile")
                    BubbleNormalTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggMarginExponent")
                    EggMarginExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggMarginFactor")
                    EggMarginFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggSubFactor")
                    EggSubFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggFullRadius")
                    EggFullRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Specularity")
                    Specularity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubsurfaceFactor")
                    SubsurfaceFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AntiLightbleedValue")
                    AntiLightbleedValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AntiLightbleedUpOff")
                    AntiLightbleedUpOff = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _eye_blendable
    {
        public _eye_blendable() { }
        public _eye_blendable(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FadeOutDistance")
                    FadeOutDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeOutOffset")
                    FadeOutOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffset")
                    GlitchOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelColor")
                    FresnelColor = new Color(data.Variant as CColor);
                if (data.REDName == "Albedo")
                    Albedo = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Blick")
                    Blick = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalBubble")
                    NormalBubble = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RefractionIndex")
                    RefractionIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionAmount")
                    RefractionAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IrisSize")
                    IrisSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeHorizAngleRight")
                    EyeHorizAngleRight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeHorizAngleLeft")
                    EyeHorizAngleLeft = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeRadius")
                    EyeRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeParallaxPlane")
                    EyeParallaxPlane = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BubbleNormalTile")
                    BubbleNormalTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggFullRadius")
                    EggFullRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggMarginExponent")
                    EggMarginExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggMarginFactor")
                    EggMarginFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggSubFactor")
                    EggSubFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IrisCoordFactor")
                    IrisCoordFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IrisCoordMargin")
                    IrisCoordMargin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlickScale")
                    BlickScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Specularity")
                    Specularity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SubsurfaceFactor")
                    SubsurfaceFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AntiLightbleedValue")
                    AntiLightbleedValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AntiLightbleedUpOff")
                    AntiLightbleedUpOff = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _eye_gradient
    {
        public _eye_gradient() { }
        public _eye_gradient(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Albedo")
                    Albedo = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Blick")
                    Blick = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalBubble")
                    NormalBubble = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "IrisMask")
                    IrisMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "IrisColorGradient")
                    IrisColorGradient = (data.Variant as rRef<CGradient>).DepotPath;
                if (data.REDName == "RefractionIndex")
                    RefractionIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionAmount")
                    RefractionAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IrisSize")
                    IrisSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeHorizAngleRight")
                    EyeHorizAngleRight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeHorizAngleLeft")
                    EyeHorizAngleLeft = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeRadius")
                    EyeRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeParallaxPlane")
                    EyeParallaxPlane = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BubbleNormalTile")
                    BubbleNormalTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggFullRadius")
                    EggFullRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggMarginExponent")
                    EggMarginExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggMarginFactor")
                    EggMarginFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EggSubFactor")
                    EggSubFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IrisCoordFactor")
                    IrisCoordFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IrisCoordMargin")
                    IrisCoordMargin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlickScale")
                    BlickScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Specularity")
                    Specularity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubsurfaceFactor")
                    SubsurfaceFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AntiLightbleedValue")
                    AntiLightbleedValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AntiLightbleedUpOff")
                    AntiLightbleedUpOff = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _eye_shadow
    {
        public _eye_shadow() { }
        public _eye_shadow(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShadowColor")
                    ShadowColor = new Color(data.Variant as CColor);
                if (data.REDName == "Exponent")
                    Exponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Intensity")
                    Intensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WetnessRoughness")
                    WetnessRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WetnessStrength")
                    WetnessStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubsurfaceBlur")
                    SubsurfaceBlur = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _eye_shadow_blendable
    {
        public _eye_shadow_blendable() { }
        public _eye_shadow_blendable(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FadeOutDistance")
                    FadeOutDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeOutOffset")
                    FadeOutOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffset")
                    GlitchOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelColor")
                    FresnelColor = new Color(data.Variant as CColor);
                if (data.REDName == "FresnelColorIntensity")
                    FresnelColorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelExponent")
                    FresnelExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShadowColor")
                    ShadowColor = new Color(data.Variant as CColor);
                if (data.REDName == "Exponent")
                    Exponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Intensity")
                    Intensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WetnessRoughness")
                    WetnessRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WetnessStrength")
                    WetnessStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubsurfaceBlur")
                    SubsurfaceBlur = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _fake_occluder
    {
        public _fake_occluder() { }
        public _fake_occluder(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DissolveDistance")
                    DissolveDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissolveBandWidth")
                    DissolveBandWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _fillable_fluid
    {
        public _fillable_fluid() { }
        public _fillable_fluid(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "FluidBoundingBoxMin")
                    FluidBoundingBoxMin = new Vec4(data.Variant as Vector4);
                if (data.REDName == "FluidBoundingBoxMax")
                    FluidBoundingBoxMax = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ObjectSize")
                    ObjectSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ControlledByFx")
                    ControlledByFx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FillAmount")
                    FillAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Waves")
                    Waves = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WaveAmplitude")
                    WaveAmplitude = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaveSpeed")
                    WaveSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaveSize")
                    WaveSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _fillable_fluid_vertex
    {
        public _fillable_fluid_vertex() { }
        public _fillable_fluid_vertex(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "FluidBoundingBoxMin")
                    FluidBoundingBoxMin = new Vec4(data.Variant as Vector4);
                if (data.REDName == "FluidBoundingBoxMax")
                    FluidBoundingBoxMax = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ControlledByFx")
                    ControlledByFx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ControlledByFxMode")
                    ControlledByFxMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "PinchDeformation")
                    PinchDeformation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FillAmount")
                    FillAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Waves")
                    Waves = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WaveAmplitude")
                    WaveAmplitude = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaveSpeed")
                    WaveSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaveSize")
                    WaveSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "FrontFacesReflectionPower")
                    FrontFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassSpecularColor")
                    GlassSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "BlurRadius")
                    BlurRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _fluid_mov
    {
        public _fluid_mov() { }
        public _fluid_mov(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OpacityBackFace")
                    OpacityBackFace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingX")
                    UvTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingY")
                    UvTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetX")
                    UvOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetY")
                    UvOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTileAndOffset")
                    RoughnessTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "NormalTileAndOffset")
                    NormalTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlassTintTileAndOffset")
                    GlassTintTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "vertex_paint_tex")
                    vertex_paint_tex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "IsControlledByDestruction")
                    IsControlledByDestruction = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_min")
                    trans_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_max")
                    trans_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_min")
                    rot_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_max")
                    rot_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_pieces")
                    n_pieces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "play_time")
                    play_time = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "debug_familys")
                    debug_familys = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "YAxisUp")
                    YAxisUp = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "z_min")
                    z_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ground_offset")
                    ground_offset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "TintFromVertexPaint")
                    TintFromVertexPaint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FrontFacesReflectionPower")
                    FrontFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackFacesReflectionPower")
                    BackFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionDepth")
                    RefractionDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassSpecularColor")
                    GlassSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalMapAffectsSpecular")
                    NormalMapAffectsSpecular = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassRoughnessBias")
                    GlassRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskRoughnessBias")
                    MaskRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurRadius")
                    BlurRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurByRoughness")
                    BlurByRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _frosted_glass
    {
        public _frosted_glass() { }
        public _frosted_glass(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "RenderBackFaces")
                    RenderBackFaces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingX")
                    UvTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingY")
                    UvTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetX")
                    UvOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetY")
                    UvOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTileAndOffset")
                    RoughnessTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "NormalTileAndOffset")
                    NormalTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlassTintTileAndOffset")
                    GlassTintTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "RoughnessBase")
                    RoughnessBase = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessAttenuation")
                    RoughnessAttenuation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceOpacity")
                    SurfaceOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = new Color(data.Variant as CColor);
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintSurface")
                    TintSurface = new Color(data.Variant as CColor);
                if (data.REDName == "GlassSpecularColor")
                    GlassSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "FrontFacesReflectionPower")
                    FrontFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackFacesReflectionPower")
                    BackFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RefractionDepth")
                    RefractionDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SpecularPower")
                    SpecularPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalMapAffectsSpecular")
                    NormalMapAffectsSpecular = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurRadius")
                    BlurRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurRoughness")
                    BlurRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskUseAlpha")
                    MaskUseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAddSurface")
                    MaskAddSurface = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAddOpacity")
                    MaskAddOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAddRoughness")
                    MaskAddRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _frosted_glass_curtain
    {
        public _frosted_glass_curtain() { }
        public _frosted_glass_curtain(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessDirty")
                    RoughnessDirty = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = new Color(data.Variant as CColor);
                if (data.REDName == "TintColorAttenuation")
                    TintColorAttenuation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessAttenuation")
                    RoughnessAttenuation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FrontFacesReflectionPower")
                    FrontFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackFacesReflectionPower")
                    BackFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "blurRadius")
                    blurRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "diffuseStrength")
                    diffuseStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SpecularPower")
                    SpecularPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _glass
    {
        public _glass() { }
        public _glass(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OpacityBackFace")
                    OpacityBackFace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingX")
                    UvTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingY")
                    UvTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetX")
                    UvOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetY")
                    UvOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTileAndOffset")
                    RoughnessTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "NormalTileAndOffset")
                    NormalTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlassTintTileAndOffset")
                    GlassTintTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintFromVertexPaint")
                    TintFromVertexPaint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FrontFacesReflectionPower")
                    FrontFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackFacesReflectionPower")
                    BackFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionDepth")
                    RefractionDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassSpecularColor")
                    GlassSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalMapAffectsSpecular")
                    NormalMapAffectsSpecular = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GlassRoughnessBias")
                    GlassRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskRoughnessBias")
                    MaskRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurRadius")
                    BlurRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurByRoughness")
                    BlurByRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _glass_blendable
    {
        public _glass_blendable() { }
        public _glass_blendable(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FadeOutDistance")
                    FadeOutDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeOutOffset")
                    FadeOutOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffset")
                    GlitchOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OpacityBackFace")
                    OpacityBackFace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelColor")
                    FresnelColor = new Color(data.Variant as CColor);
                if (data.REDName == "FresnelColorIntensity")
                    FresnelColorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelExponent")
                    FresnelExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "TintFromVertexPaint")
                    TintFromVertexPaint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FrontFacesReflectionPower")
                    FrontFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackFacesReflectionPower")
                    BackFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionDepth")
                    RefractionDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassSpecularColor")
                    GlassSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalMapAffectsSpecular")
                    NormalMapAffectsSpecular = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassRoughnessBias")
                    GlassRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskRoughnessBias")
                    MaskRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurRadius")
                    BlurRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurByRoughness")
                    BlurByRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _glass_cracked_edge
    {
        public _glass_cracked_edge() { }
        public _glass_cracked_edge(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AlphaScale")
                    AlphaScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseAlphaFromSkinning")
                    UseAlphaFromSkinning = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _glass_deferred
    {
        public _glass_deferred() { }
        public _glass_deferred(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UvTilingX")
                    UvTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingY")
                    UvTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetX")
                    UvOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetY")
                    UvOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTileAndOffset")
                    NormalTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "TintFromVertexPaint")
                    TintFromVertexPaint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TintColorAttenuation")
                    TintColorAttenuation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassMetalness")
                    GlassMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskRoughnessBias")
                    MaskRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Reflection")
                    Reflection = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _glass_scope
    {
        public _glass_scope() { }
        public _glass_scope(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UvTilingOffset")
                    UvTilingOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "LensRoughness")
                    LensRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LensMetalness")
                    LensMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GlassTintMultiplier")
                    GlassTintMultiplier = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveTint")
                    EmissiveTint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LensSpecularColor")
                    LensSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "LensReflectionPower")
                    LensReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SpecularPower")
                    SpecularPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseMask")
                    UseMask = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScopeMaskFarDistance")
                    ScopeMaskFarDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScopeMaskClose")
                    ScopeMaskClose = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScopeMaskFar")
                    ScopeMaskFar = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LensBulge")
                    LensBulge = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScopeInside")
                    ScopeInside = new Color(data.Variant as CColor);
                if (data.REDName == "DistortionStrenght")
                    DistortionStrenght = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LensBulgeStrength")
                    LensBulgeStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AberrationStrenght")
                    AberrationStrenght = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SphereMaskCloseRadius")
                    SphereMaskCloseRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SphereMaskCloseHardness")
                    SphereMaskCloseHardness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LensBulgeRadius")
                    LensBulgeRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LensBulgeHardness")
                    LensBulgeHardness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SphereMaskFarRadius")
                    SphereMaskFarRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SphereMaskFarHardness")
                    SphereMaskFarHardness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SphereMaskDistortionRadius")
                    SphereMaskDistortionRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SphereMaskDistortionHardness")
                    SphereMaskDistortionHardness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyeRelief")
                    EyeRelief = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _glass_window_rain
    {
        public _glass_window_rain() { }
        public _glass_window_rain(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UvTilingX")
                    UvTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingY")
                    UvTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetX")
                    UvOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetY")
                    UvOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTileAndOffset")
                    RoughnessTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlassTintTileAndOffset")
                    GlassTintTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OpacityBackFace")
                    OpacityBackFace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "TintSurface")
                    TintSurface = new Color(data.Variant as CColor);
                if (data.REDName == "FrontFacesReflectionPower")
                    FrontFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackFacesReflectionPower")
                    BackFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassSpecularColor")
                    GlassSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassRoughnessBias")
                    GlassRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskRoughnessBias")
                    MaskRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RainTiling")
                    RainTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlowTiling")
                    FlowTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsNormalTxt")
                    DotsNormalTxt = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DotsTxt")
                    DotsTxt = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FlowTxt")
                    FlowTxt = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _hair
    {
        public _hair() { }
        public _hair(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Strand_Gradient")
                    Strand_Gradient = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Animation_AmplitudeScale")
                    Animation_AmplitudeScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Animation_PeriodScale")
                    Animation_PeriodScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Strand_ID")
                    Strand_ID = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Strand_Alpha")
                    Strand_Alpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaCutoff")
                    AlphaCutoff = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Flow")
                    Flow = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FlowStrength")
                    FlowStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VertexColorStrength")
                    VertexColorStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Scattering")
                    Scattering = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShadowStrength")
                    ShadowStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShadowMin")
                    ShadowMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShadowMax")
                    ShadowMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShadowRoughness")
                    ShadowRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugHairColor")
                    DebugHairColor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HairProfile")
                    HairProfile = (data.Variant as rRef<CHairProfile>).DepotPath;
            }
        }
    }
    public partial class _hair_blendable
    {
        public _hair_blendable() { }
        public _hair_blendable(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FadeOutDistance")
                    FadeOutDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeOutOffset")
                    FadeOutOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffset")
                    GlitchOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Strand_Gradient")
                    Strand_Gradient = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Animation_AmplitudeScale")
                    Animation_AmplitudeScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Animation_PeriodScale")
                    Animation_PeriodScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelColor")
                    FresnelColor = new Color(data.Variant as CColor);
                if (data.REDName == "FresnelColorIntensity")
                    FresnelColorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelExponent")
                    FresnelExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Strand_ID")
                    Strand_ID = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Strand_Alpha")
                    Strand_Alpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaCutoff")
                    AlphaCutoff = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Flow")
                    Flow = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FlowStrength")
                    FlowStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VertexColorStrength")
                    VertexColorStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Scattering")
                    Scattering = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShadowStrength")
                    ShadowStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShadowMin")
                    ShadowMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShadowMax")
                    ShadowMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShadowRoughness")
                    ShadowRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugHairColor")
                    DebugHairColor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HairProfile")
                    HairProfile = (data.Variant as rRef<CHairProfile>).DepotPath;
            }
        }
    }
    public partial class _hair_proxy
    {
        public _hair_proxy() { }
        public _hair_proxy(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Albedo")
                    Albedo = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Scattering")
                    Scattering = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _ice_fluid_mov
    {
        public _ice_fluid_mov() { }
        public _ice_fluid_mov(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "WaveIdleNormalStrength")
                    WaveIdleNormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaveIdleTilingAndSpeed")
                    WaveIdleTilingAndSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DebugTimeOverride")
                    DebugTimeOverride = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SimulationAtlasFrameCountX")
                    SimulationAtlasFrameCountX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SimulationAtlasFrameCountY")
                    SimulationAtlasFrameCountY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SimulationAtlas")
                    SimulationAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WaveIdleMap")
                    WaveIdleMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WaveIdleHeight")
                    WaveIdleHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HeightMin")
                    HeightMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HeightMax")
                    HeightMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaterRoughness")
                    WaterRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaterSpecF0")
                    WaterSpecF0 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaterSpecF90")
                    WaterSpecF90 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaterColorShallow")
                    WaterColorShallow = new Color(data.Variant as CColor);
                if (data.REDName == "WaterColorDeep")
                    WaterColorDeep = new Color(data.Variant as CColor);
                if (data.REDName == "WaveColor0")
                    WaveColor0 = new Color(data.Variant as CColor);
                if (data.REDName == "WaveColor1")
                    WaveColor1 = new Color(data.Variant as CColor);
                if (data.REDName == "WaveNoiseTiling")
                    WaveNoiseTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaveNoiseContrast")
                    WaveNoiseContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaveNoiseContrastOut")
                    WaveNoiseContrastOut = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionStrength")
                    RefractionStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IceColor1")
                    IceColor1 = new Color(data.Variant as CColor);
                if (data.REDName == "IceColor2")
                    IceColor2 = new Color(data.Variant as CColor);
                if (data.REDName == "IceTiling")
                    IceTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UVRatio")
                    UVRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IceDepth")
                    IceDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IceNormalStrength")
                    IceNormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BloodColor")
                    BloodColor = new Color(data.Variant as CColor);
                if (data.REDName == "BloodFadeStart")
                    BloodFadeStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BloodFadeEnd")
                    BloodFadeEnd = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaveNoiseMap")
                    WaveNoiseMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "IceMasksMap")
                    IceMasksMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "IceNormalMap")
                    IceNormalMap = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _ice_ver_mov_translucent
    {
        public _ice_ver_mov_translucent() { }
        public _ice_ver_mov_translucent(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "vertex_paint_tex")
                    vertex_paint_tex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "trans_min")
                    trans_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_max")
                    trans_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_min")
                    rot_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_max")
                    rot_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_pieces")
                    n_pieces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "play_time")
                    play_time = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "debug_familys")
                    debug_familys = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaveIdleMap")
                    WaveIdleMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WaveIdleHeight")
                    WaveIdleHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaveIdleTilingAndSpeed")
                    WaveIdleTilingAndSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionTint")
                    RefractionTint = new Color(data.Variant as CColor);
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _lights_interactive
    {
        public _lights_interactive() { }
        public _lights_interactive(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Zone0EmissiveEV")
                    Zone0EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Zone1EmissiveEV")
                    Zone1EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Zone2EmissiveEV")
                    Zone2EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Zone3EmissiveEV")
                    Zone3EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugLightsIntensity")
                    DebugLightsIntensity = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _loot_drop_highlight
    {
        public _loot_drop_highlight() { }
        public _loot_drop_highlight(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Mode")
                    Mode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HighlightColor")
                    HighlightColor = new Color(data.Variant as CColor);
                if (data.REDName == "HighlightIntensity")
                    HighlightIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SolidBlendingDistanceStart")
                    SolidBlendingDistanceStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SolidBlendingDistanceEnd")
                    SolidBlendingDistanceEnd = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _mesh_decal
    {
        public _mesh_decal() { }
        public _mesh_decal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
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
                if (data.REDName == "UseNormalAlphaTex")
                    UseNormalAlphaTex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalsBlendingModeAlpha")
                    NormalsBlendingModeAlpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
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
            }
        }
    }
    public partial class _mesh_decal_blendable
    {
        public _mesh_decal_blendable() { }
        public _mesh_decal_blendable(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FadeOutDistance")
                    FadeOutDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeOutOffset")
                    FadeOutOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffset")
                    GlitchOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelColor")
                    FresnelColor = new Color(data.Variant as CColor);
                if (data.REDName == "FresnelColorIntensity")
                    FresnelColorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelExponent")
                    FresnelExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
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
                if (data.REDName == "UseNormalAlphaTex")
                    UseNormalAlphaTex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalsBlendingModeAlpha")
                    NormalsBlendingModeAlpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
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
            }
        }
    }
    public partial class _mesh_decal_double_diffuse
    {
        public _mesh_decal_double_diffuse() { }
        public _mesh_decal_double_diffuse(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "DiffuseAlpha")
                    DiffuseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SecondaryDiffuseAlpha")
                    SecondaryDiffuseAlpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SecondaryDiffuseColor")
                    SecondaryDiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "SecondaryDiffuseAlphaIntensity")
                    SecondaryDiffuseAlphaIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
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
                if (data.REDName == "NormalsBlendingModeAlpha")
                    NormalsBlendingModeAlpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalAlpha")
                    NormalAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalAlphaTex")
                    NormalAlphaTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseNormalAlphaTex")
                    UseNormalAlphaTex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
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
            }
        }
    }
    public partial class _mesh_decal_emissive
    {
        public _mesh_decal_emissive() { }
        public _mesh_decal_emissive(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DamageInfluence")
                    DamageInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DamageInfluenceDebug")
                    DamageInfluenceDebug = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "DiffuseColor2")
                    DiffuseColor2 = new Color(data.Variant as CColor);
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
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationSpeed")
                    AnimationSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationFramesWidth")
                    AnimationFramesWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationFramesHeight")
                    AnimationFramesHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollSpeed")
                    ScrollSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "HardOrSoftTransition")
                    HardOrSoftTransition = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FullVisibilityFactor")
                    FullVisibilityFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableAlternateColor")
                    EnableAlternateColor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableAlternateUVcoord")
                    EnableAlternateUVcoord = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Preview2ndState")
                    Preview2ndState = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _mesh_decal_emissive_subsurface
    {
        public _mesh_decal_emissive_subsurface() { }
        public _mesh_decal_emissive_subsurface(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveMask")
                    EmissiveMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SecondaryMask")
                    SecondaryMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveMaskChannel")
                    EmissiveMaskChannel = new Vec4(data.Variant as Vector4);
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _mesh_decal_gradientmap_recolor
    {
        public _mesh_decal_gradientmap_recolor() { }
        public _mesh_decal_gradientmap_recolor(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "DiffuseAlpha")
                    DiffuseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientMap")
                    GradientMap = (data.Variant as rRef<ITexture>).DepotPath;
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
                if (data.REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
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
            }
        }
    }
    public partial class _mesh_decal_gradientmap_recolor_2
    {
        public _mesh_decal_gradientmap_recolor_2() { }
        public _mesh_decal_gradientmap_recolor_2(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "DiffuseAlpha")
                    DiffuseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Gradient")
                    Gradient = (data.Variant as rRef<CGradient>).DepotPath;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalAlpha")
                    NormalAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
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
            }
        }
    }
    public partial class _mesh_decal_gradientmap_recolor_emissive
    {
        public _mesh_decal_gradientmap_recolor_emissive() { }
        public _mesh_decal_gradientmap_recolor_emissive(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "DiffuseAlpha")
                    DiffuseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientMap")
                    GradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveGradientMap")
                    EmissiveGradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalAlpha")
                    NormalAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationSpeed")
                    AnimationSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationFramesWidth")
                    AnimationFramesWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationFramesHeight")
                    AnimationFramesHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DepthThreshold")
                    DepthThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _mesh_decal_multitinted
    {
        public _mesh_decal_multitinted() { }
        public _mesh_decal_multitinted(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "DiffuseAlpha")
                    DiffuseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalAlpha")
                    NormalAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
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
                if (data.REDName == "TintMaskTexture")
                    TintMaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor0")
                    TintColor0 = new Color(data.Variant as CColor);
                if (data.REDName == "TintColor1")
                    TintColor1 = new Color(data.Variant as CColor);
                if (data.REDName == "TintColor2")
                    TintColor2 = new Color(data.Variant as CColor);
                if (data.REDName == "TintColor3")
                    TintColor3 = new Color(data.Variant as CColor);
                if (data.REDName == "TintColor4")
                    TintColor4 = new Color(data.Variant as CColor);
                if (data.REDName == "TintColor5")
                    TintColor5 = new Color(data.Variant as CColor);
                if (data.REDName == "TintColor6")
                    TintColor6 = new Color(data.Variant as CColor);
                if (data.REDName == "TintColor7")
                    TintColor7 = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _mesh_decal_parallax
    {
        public _mesh_decal_parallax() { }
        public _mesh_decal_parallax(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
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
                if (data.REDName == "UseNormalAlphaTex")
                    UseNormalAlphaTex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
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
                if (data.REDName == "HeightTexture")
                    HeightTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "HeightStrength")
                    HeightStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _mesh_decal_revealed
    {
        public _mesh_decal_revealed() { }
        public _mesh_decal_revealed(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "DiffuseAlpha")
                    DiffuseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalAlpha")
                    NormalAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationSpeed")
                    AnimationSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationFramesWidth")
                    AnimationFramesWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationFramesHeight")
                    AnimationFramesHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileNumber")
                    TileNumber = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DepthThreshold")
                    DepthThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlowTexture")
                    FlowTexture = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _mesh_decal_wet_character
    {
        public _mesh_decal_wet_character() { }
        public _mesh_decal_wet_character(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
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
                if (data.REDName == "UseNormalAlphaTex")
                    UseNormalAlphaTex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
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
            }
        }
    }
    public partial class _metal_base_bink
    {
        public _metal_base_bink() { }
        public _metal_base_bink(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VideoCanvasName")
                    VideoCanvasName = (data.Variant as CName).Value;
                if (data.REDName == "BinkY")
                    BinkY = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BinkCR")
                    BinkCR = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BinkCB")
                    BinkCB = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BinkA")
                    BinkA = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _metal_base_det
    {
        public _metal_base_det() { }
        public _metal_base_det(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DetailColor")
                    DetailColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DetailNormal")
                    DetailNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DetailU")
                    DetailU = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DetailV")
                    DetailV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_det_dithered
    {
        public _metal_base_det_dithered() { }
        public _metal_base_det_dithered(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DetailColor")
                    DetailColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DetailNormal")
                    DetailNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DetailU")
                    DetailU = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DetailV")
                    DetailV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_dithered
    {
        public _metal_base_dithered() { }
        public _metal_base_dithered(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VehicleDamageInfluence")
                    VehicleDamageInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveLift")
                    EmissiveLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_gradientmap_recolor
    {
        public _metal_base_gradientmap_recolor() { }
        public _metal_base_gradientmap_recolor(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VehicleDamageInfluence")
                    VehicleDamageInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GradientMap")
                    GradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveGradientMap")
                    EmissiveGradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_parallax
    {
        public _metal_base_parallax() { }
        public _metal_base_parallax(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveLift")
                    EmissiveLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HeightTexture")
                    HeightTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "HeightStrength")
                    HeightStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_trafficlight_proxy
    {
        public _metal_base_trafficlight_proxy() { }
        public _metal_base_trafficlight_proxy(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "TrafficCellSize")
                    TrafficCellSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TrafficSpeed")
                    TrafficSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveLift")
                    EmissiveLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_ui
    {
        public _metal_base_ui() { }
        public _metal_base_ui(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "ScanlineTexture")
                    ScanlineTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FixToPbr")
                    FixToPbr = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayersSeparation")
                    LayersSeparation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IntensityPerLayer")
                    IntensityPerLayer = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScanlinesDensity")
                    ScanlinesDensity = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScanlinesIntensity")
                    ScanlinesIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IsBroken")
                    IsBroken = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ImageScale")
                    ImageScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UIRenderTexture")
                    UIRenderTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RenderTextureScale")
                    RenderTextureScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "VerticalFlipEnabled")
                    VerticalFlipEnabled = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TexturePartUV")
                    TexturePartUV = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DirtTexture")
                    DirtTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DirtColor")
                    DirtColor = new Color(data.Variant as CColor);
                if (data.REDName == "DirtRoughness")
                    DirtRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtEmissiveAttenuation")
                    DirtEmissiveAttenuation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtContrast")
                    DirtContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Tint")
                    Tint = new Color(data.Variant as CColor);
                if (data.REDName == "FixForBlack")
                    FixForBlack = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FixForVerticalSlide")
                    FixForVerticalSlide = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ForcedTint")
                    ForcedTint = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _metal_base_vertexcolored
    {
        public _metal_base_vertexcolored() { }
        public _metal_base_vertexcolored(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _mikoshi_blocks_big
    {
        public _mikoshi_blocks_big() { }
        public _mikoshi_blocks_big(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "DataTex")
                    DataTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NoiseTex")
                    NoiseTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "PcbTex")
                    PcbTex = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _mikoshi_blocks_medium
    {
        public _mikoshi_blocks_medium() { }
        public _mikoshi_blocks_medium(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "RandomSeed")
                    RandomSeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "DataTex")
                    DataTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NoiseTex")
                    NoiseTex = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _mikoshi_blocks_small
    {
        public _mikoshi_blocks_small() { }
        public _mikoshi_blocks_small(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "RandomSeed")
                    RandomSeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "DataTex")
                    DataTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NoiseTex")
                    NoiseTex = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _mikoshi_parallax
    {
        public _mikoshi_parallax() { }
        public _mikoshi_parallax(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "RoomAtlas")
                    RoomAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayerAtlas")
                    LayerAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AtlasGridUvRatio")
                    AtlasGridUvRatio = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AtlasDepth")
                    AtlasDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "roomWidth")
                    roomWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "roomHeight")
                    roomHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "roomDepth")
                    roomDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "positionXoffset")
                    positionXoffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "positionYoffset")
                    positionYoffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerDepth")
                    LayerDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frostiness")
                    Frostiness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindowTexture")
                    WindowTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _mikoshi_prison_cell
    {
        public _mikoshi_prison_cell() { }
        public _mikoshi_prison_cell(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EdgeFalloff")
                    EdgeFalloff = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DepthAttenuation")
                    DepthAttenuation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DepthAttenuationPower")
                    DepthAttenuationPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightIntensity")
                    LightIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightColor")
                    LightColor = new Color(data.Variant as CColor);
                if (data.REDName == "SilhouetteTex")
                    SilhouetteTex = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _multilayered_clear_coat
    {
        public _multilayered_clear_coat() { }
        public _multilayered_clear_coat(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CoatTintFwd")
                    CoatTintFwd = new Color(data.Variant as CColor);
                if (data.REDName == "CoatTintSide")
                    CoatTintSide = new Color(data.Variant as CColor);
                if (data.REDName == "CoatTintFresnelBias")
                    CoatTintFresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CoatSpecularColor")
                    CoatSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "CoatNormalStrength")
                    CoatNormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CoatRoughnessBase")
                    CoatRoughnessBase = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CoatReflectionPower")
                    CoatReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CoatFresnelBias")
                    CoatFresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CoatLayerMin")
                    CoatLayerMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CoatLayerMax")
                    CoatLayerMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SetupLayerMask")
                    SetupLayerMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _multilayered_terrain
    {
        public _multilayered_terrain() { }
        public _multilayered_terrain(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UseOldVertexFormat")
                    UseOldVertexFormat = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UVGenScaleOffset")
                    UVGenScaleOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DebugPreviewMasks")
                    DebugPreviewMasks = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseGlobalNormal")
                    UseGlobalNormal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TilingMap")
                    TilingMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SetupLayerMask")
                    SetupLayerMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TerrainSetup")
                    TerrainSetup = (data.Variant as rRef<CTerrainSetup>).DepotPath;
                if (data.REDName == "MaskFoliage")
                    MaskFoliage = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _neon_parallax
    {
        public _neon_parallax() { }
        public _neon_parallax(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UvTilingX")
                    UvTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingY")
                    UvTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetX")
                    UvOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetY")
                    UvOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseGradientMapMode")
                    UseGradientMapMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GradientMap")
                    GradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScaleEdgeStart")
                    BaseColorScaleEdgeStart = new Color(data.Variant as CColor);
                if (data.REDName == "BaseColorScaleEdgeEnd")
                    BaseColorScaleEdgeEnd = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParallaxDepth")
                    ParallaxDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParallaxFlip")
                    ParallaxFlip = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _presimulated_particles
    {
        public _presimulated_particles() { }
        public _presimulated_particles(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "vertex_paint_tex")
                    vertex_paint_tex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "trans_min")
                    trans_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_max")
                    trans_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_pieces")
                    n_pieces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "play_time")
                    play_time = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParticleScale")
                    ParticleScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _proxy_ad
    {
        public _proxy_ad() { }
        public _proxy_ad(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _proxy_crowd
    {
        public _proxy_crowd() { }
        public _proxy_crowd(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Atlas")
                    Atlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color1")
                    Color1 = new Color(data.Variant as CColor);
                if (data.REDName == "Color2")
                    Color2 = new Color(data.Variant as CColor);
                if (data.REDName == "Color3")
                    Color3 = new Color(data.Variant as CColor);
                if (data.REDName == "Color4")
                    Color4 = new Color(data.Variant as CColor);
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AtlasSize")
                    AtlasSize = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _q116_mikoshi_cubes
    {
        public _q116_mikoshi_cubes() { }
        public _q116_mikoshi_cubes(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "PointCloudTextureHeight")
                    PointCloudTextureHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TransMin")
                    TransMin = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TransMax")
                    TransMax = new Vec4(data.Variant as Vector4);
                if (data.REDName == "WorldPosTex")
                    WorldPosTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "CubeSize")
                    CubeSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Tiling")
                    Tiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseVariationUvScale")
                    DiffuseVariationUvScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParallaxHeightScale")
                    ParallaxHeightScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParallaxFlip")
                    ParallaxFlip = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ExtraMasks")
                    ExtraMasks = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EdgeMask")
                    EdgeMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _q116_mikoshi_floor
    {
        public _q116_mikoshi_floor() { }
        public _q116_mikoshi_floor(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FalloffDistanceStart")
                    FalloffDistanceStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FalloffDistanceEnd")
                    FalloffDistanceEnd = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlowBrightnessStart")
                    GlowBrightnessStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlowBrightnessEnd")
                    GlowBrightnessEnd = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorField1")
                    VectorField1 = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "VectorField2")
                    VectorField2 = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "VectorFieldSliceCount")
                    VectorFieldSliceCount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Grain")
                    Grain = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _q202_lake_surface
    {
        public _q202_lake_surface() { }
        public _q202_lake_surface(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Starmap")
                    Starmap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Galaxy")
                    Galaxy = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GalaxyIntensity")
                    GalaxyIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "StarmapIntensity")
                    StarmapIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DimScale")
                    DimScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BrightScale")
                    BrightScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ConstelationScale")
                    ConstelationScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _rain
    {
        public _rain() { }
        public _rain(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "RainType")
                    RainType = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindNoise")
                    WindNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Speed")
                    Speed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Scale")
                    Scale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindSkew")
                    WindSkew = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindStrength")
                    WindStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindDirectionMovement")
                    WindDirectionMovement = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindFrequency")
                    WindFrequency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Height")
                    Height = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Distance")
                    Distance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Radius")
                    Radius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BrightnessCards")
                    BrightnessCards = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BrightnessDrops")
                    BrightnessDrops = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MovementStrength")
                    MovementStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UvSpeed")
                    UvSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _road_debug_grid
    {
        public _road_debug_grid() { }
        public _road_debug_grid(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "TransitionSize")
                    TransitionSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GridScale")
                    GridScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableWorldSpace")
                    EnableWorldSpace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _set_stencil_3
    {
        public _set_stencil_3() { }
        public _set_stencil_3(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "ExtraThickness")
                    ExtraThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _silverhand_overlay
    {
        public _silverhand_overlay() { }
        public _silverhand_overlay(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DepthOffset")
                    DepthOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffset")
                    GlitchOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchTimeSeed")
                    GlitchTimeSeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelMask")
                    FresnelMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FresnelMaskIntensity")
                    FresnelMaskIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BayerScale")
                    BayerScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BayerIntensity")
                    BayerIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VertexColorSelection")
                    VertexColorSelection = new Vec4(data.Variant as Vector4);
                if (data.REDName == "VectorFieldTiling")
                    VectorFieldTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorFieldIntensity")
                    VectorFieldIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorFieldAnim")
                    VectorFieldAnim = new Vec4(data.Variant as Vector4);
                if (data.REDName == "FresnelColor")
                    FresnelColor = new Color(data.Variant as CColor);
                if (data.REDName == "FresnelColorIntensity")
                    FresnelColorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelExponent")
                    FresnelExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SetupLayerMask")
                    SetupLayerMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _silverhand_overlay_blendable
    {
        public _silverhand_overlay_blendable() { }
        public _silverhand_overlay_blendable(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "FadeOutDistance")
                    FadeOutDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeOutOffset")
                    FadeOutOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffset")
                    GlitchOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchTimeSeed")
                    GlitchTimeSeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelMask")
                    FresnelMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FresnelMaskIntensity")
                    FresnelMaskIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelColor")
                    FresnelColor = new Color(data.Variant as CColor);
                if (data.REDName == "FresnelColorIntensity")
                    FresnelColorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelExponent")
                    FresnelExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BayerScale")
                    BayerScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BayerIntensity")
                    BayerIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VertexColorSelection")
                    VertexColorSelection = new Vec4(data.Variant as Vector4);
                if (data.REDName == "VectorFieldTiling")
                    VectorFieldTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorFieldIntensity")
                    VectorFieldIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorFieldAnim")
                    VectorFieldAnim = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SetupLayerMask")
                    SetupLayerMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _skin
    {
        public _skin() { }
        public _skin(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Albedo")
                    Albedo = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SecondaryAlbedo")
                    SecondaryAlbedo = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SecondaryAlbedoInfluence")
                    SecondaryAlbedoInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SecondaryAlbedoTintColorInfluence")
                    SecondaryAlbedoTintColorInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DetailNormal")
                    DetailNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DetailRoughnessBiasMin")
                    DetailRoughnessBiasMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DetailRoughnessBiasMax")
                    DetailRoughnessBiasMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MicroDetailUVScale01")
                    MicroDetailUVScale01 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MicroDetailUVScale02")
                    MicroDetailUVScale02 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MicroDetail")
                    MicroDetail = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MicroDetailInfluence")
                    MicroDetailInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TintColorMask")
                    TintColorMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "TintScale")
                    TintScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SkinProfile")
                    SkinProfile = (data.Variant as rRef<CSkinProfile>).DepotPath;
                if (data.REDName == "Detailmap_Stretch")
                    Detailmap_Stretch = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveMask")
                    EmissiveMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Detailmap_Squash")
                    Detailmap_Squash = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "CavityIntensity")
                    CavityIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Bloodflow")
                    Bloodflow = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BloodColor")
                    BloodColor = new Color(data.Variant as CColor);
                if (data.REDName == "DetailNormalInfluence")
                    DetailNormalInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _skin_blendable
    {
        public _skin_blendable() { }
        public _skin_blendable(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FadeOutDistance")
                    FadeOutDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeOutOffset")
                    FadeOutOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffset")
                    GlitchOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelColor")
                    FresnelColor = new Color(data.Variant as CColor);
                if (data.REDName == "FresnelColorIntensity")
                    FresnelColorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelExponent")
                    FresnelExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Albedo")
                    Albedo = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DetailNormal")
                    DetailNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DetailNormalInfluence")
                    DetailNormalInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CavityIntensity")
                    CavityIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DetailRoughnessBiasMin")
                    DetailRoughnessBiasMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DetailRoughnessBiasMax")
                    DetailRoughnessBiasMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MicroDetail")
                    MicroDetail = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MicroDetailUVScale01")
                    MicroDetailUVScale01 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MicroDetailUVScale02")
                    MicroDetailUVScale02 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MicroDetailInfluence")
                    MicroDetailInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TintColorMask")
                    TintColorMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "TintScale")
                    TintScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Detailmap_Stretch")
                    Detailmap_Stretch = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Detailmap_Squash")
                    Detailmap_Squash = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Bloodflow")
                    Bloodflow = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BloodColor")
                    BloodColor = new Color(data.Variant as CColor);
                if (data.REDName == "SkinProfile")
                    SkinProfile = (data.Variant as rRef<CSkinProfile>).DepotPath;
            }
        }
    }
    public partial class _skybox
    {
        public _skybox() { }
        public _skybox(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseDayTime")
                    DiffuseDayTime = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseNightTime")
                    DiffuseNightTime = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _speedtree_3d_v8_billboard
    {
        public _speedtree_3d_v8_billboard() { }
        public _speedtree_3d_v8_billboard(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "WindNoise")
                    WindNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WindLodFlags")
                    WindLodFlags = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindDataAvailable")
                    WindDataAvailable = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HorizontalBillboardsCount")
                    HorizontalBillboardsCount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ContainsTopBillboard")
                    ContainsTopBillboard = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TreeCrownRadius")
                    TreeCrownRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseMap")
                    DiffuseMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalMap")
                    NormalMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TransGlossMap")
                    TransGlossMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoliageProfileMap")
                    FoliageProfileMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoliageProfile")
                    FoliageProfile = (data.Variant as rRef<CFoliageProfile>).DepotPath;
                if (data.REDName == "MeshTotalHeight")
                    MeshTotalHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ForceTerrainBlend")
                    ForceTerrainBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _speedtree_3d_v8_onesided
    {
        public _speedtree_3d_v8_onesided() { }
        public _speedtree_3d_v8_onesided(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "WindNoise")
                    WindNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BonesPositionsMap")
                    BonesPositionsMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BonesAdditionalDataMap")
                    BonesAdditionalDataMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BoneMapData")
                    BoneMapData = new Vec4(data.Variant as Vector4);
                if (data.REDName == "WindLodFlags")
                    WindLodFlags = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindDataAvailable")
                    WindDataAvailable = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseMap")
                    DiffuseMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalMap")
                    NormalMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TransGlossMap")
                    TransGlossMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoliageProfileMap")
                    FoliageProfileMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoliageProfile")
                    FoliageProfile = (data.Variant as rRef<CFoliageProfile>).DepotPath;
                if (data.REDName == "MeshTotalHeight")
                    MeshTotalHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ForceTerrainBlend")
                    ForceTerrainBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _speedtree_3d_v8_onesided_gradient_recolor
    {
        public _speedtree_3d_v8_onesided_gradient_recolor() { }
        public _speedtree_3d_v8_onesided_gradient_recolor(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GradientMap")
                    GradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _speedtree_3d_v8_seams
    {
        public _speedtree_3d_v8_seams() { }
        public _speedtree_3d_v8_seams(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "WindNoise")
                    WindNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BoneMap")
                    BoneMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BonesPositionsMap")
                    BonesPositionsMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BonesAdditionalDataMap")
                    BonesAdditionalDataMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BoneMapData")
                    BoneMapData = new Vec4(data.Variant as Vector4);
                if (data.REDName == "WindLodFlags")
                    WindLodFlags = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindDataAvailable")
                    WindDataAvailable = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseMap")
                    DiffuseMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalMap")
                    NormalMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TransGlossMap")
                    TransGlossMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoliageProfileMap")
                    FoliageProfileMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoliageProfile")
                    FoliageProfile = (data.Variant as rRef<CFoliageProfile>).DepotPath;
                if (data.REDName == "MeshTotalHeight")
                    MeshTotalHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ForceTerrainBlend")
                    ForceTerrainBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _speedtree_3d_v8_twosided
    {
        public _speedtree_3d_v8_twosided() { }
        public _speedtree_3d_v8_twosided(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "WindNoise")
                    WindNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BoneMap")
                    BoneMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BonesPositionsMap")
                    BonesPositionsMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BonesAdditionalDataMap")
                    BonesAdditionalDataMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BoneMapData")
                    BoneMapData = new Vec4(data.Variant as Vector4);
                if (data.REDName == "WindLodFlags")
                    WindLodFlags = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindDataAvailable")
                    WindDataAvailable = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TwosidedFlipN")
                    TwosidedFlipN = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseMap")
                    DiffuseMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalMap")
                    NormalMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TransGlossMap")
                    TransGlossMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoliageProfileMap")
                    FoliageProfileMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoliageProfile")
                    FoliageProfile = (data.Variant as rRef<CFoliageProfile>).DepotPath;
                if (data.REDName == "MeshTotalHeight")
                    MeshTotalHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ForceTerrainBlend")
                    ForceTerrainBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _spline_deformed_metal_base
    {
        public _spline_deformed_metal_base() { }
        public _spline_deformed_metal_base(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "SplineLength")
                    SplineLength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SpanCount")
                    SpanCount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _terrain_simple
    {
        public _terrain_simple() { }
        public _terrain_simple(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UVGenScaleOffset")
                    UVGenScaleOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskFoliage")
                    MaskFoliage = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _top_down_car_proxy_depth
    {
        public _top_down_car_proxy_depth() { }
        public _top_down_car_proxy_depth(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _trail_decal
    {
        public _trail_decal() { }
        public _trail_decal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DepthOffset")
                    DepthOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _trail_decal_normal
    {
        public _trail_decal_normal() { }
        public _trail_decal_normal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DepthOffset")
                    DepthOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _trail_decal_normal_color
    {
        public _trail_decal_normal_color() { }
        public _trail_decal_normal_color(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DepthOffset")
                    DepthOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _transparent_liquid
    {
        public _transparent_liquid() { }
        public _transparent_liquid(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatteringColorThin")
                    ScatteringColorThin = new Color(data.Variant as CColor);
                if (data.REDName == "ScatteringColorThick")
                    ScatteringColorThick = new Color(data.Variant as CColor);
                if (data.REDName == "Albedo")
                    Albedo = new Color(data.Variant as CColor);
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SpecularStrengthMultiplier")
                    SpecularStrengthMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThicknessMultiplier")
                    ThicknessMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InterpolateFrames")
                    InterpolateFrames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTilingAndScrolling")
                    NormalTilingAndScrolling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Distort")
                    Distort = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortTilingAndScrolling")
                    DistortTilingAndScrolling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EnableRowAnimation")
                    EnableRowAnimation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseOnStaticMeshes")
                    UseOnStaticMeshes = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _underwater_blood
    {
        public _underwater_blood() { }
        public _underwater_blood(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugTimeOverride")
                    DebugTimeOverride = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "StartDelayFrames")
                    StartDelayFrames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SimulationAtlasFrameCountX")
                    SimulationAtlasFrameCountX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SimulationAtlasFrameCountY")
                    SimulationAtlasFrameCountY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SimulationAtlas")
                    SimulationAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SpeedExponent")
                    SpeedExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorScale")
                    ColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "ColorScale1")
                    ColorScale1 = new Color(data.Variant as CColor);
                if (data.REDName == "ColorScale2")
                    ColorScale2 = new Color(data.Variant as CColor);
                if (data.REDName == "ColorGradientPositions")
                    ColorGradientPositions = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ColorMode")
                    ColorMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _vehicle_destr_blendshape
    {
        public _vehicle_destr_blendshape() { }
        public _vehicle_destr_blendshape(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DamageInfluence")
                    DamageInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DamageInfluenceDebug")
                    DamageInfluenceDebug = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureTiling")
                    TextureTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BakedNormal")
                    BakedNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScratchMask")
                    ScratchMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DirtMap")
                    DirtMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScratchResistance")
                    ScratchResistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtOpacity")
                    DirtOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtColor")
                    DirtColor = new Color(data.Variant as CColor);
                if (data.REDName == "DirtMaskOffsets")
                    DirtMaskOffsets = new Vec4(data.Variant as Vector4);
                if (data.REDName == "CoatTintFwd")
                    CoatTintFwd = new Color(data.Variant as CColor);
                if (data.REDName == "CoatTintSide")
                    CoatTintSide = new Color(data.Variant as CColor);
                if (data.REDName == "CoatTintFresnelBias")
                    CoatTintFresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CoatSpecularColor")
                    CoatSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "CoatFresnelBias")
                    CoatFresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CoatLayerMin")
                    CoatLayerMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CoatLayerMax")
                    CoatLayerMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SetupLayerMask")
                    SetupLayerMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _vehicle_glass
    {
        public _vehicle_glass() { }
        public _vehicle_glass(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UvTilingX")
                    UvTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingY")
                    UvTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetX")
                    UvOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetY")
                    UvOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DamageInfluence")
                    DamageInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DamageInfluenceDebug")
                    DamageInfluenceDebug = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OpacityBackFace")
                    OpacityBackFace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "TintSurface")
                    TintSurface = new Color(data.Variant as CColor);
                if (data.REDName == "FrontFacesReflectionPower")
                    FrontFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackFacesReflectionPower")
                    BackFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassSpecularColor")
                    GlassSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskRoughnessBias")
                    MaskRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseDamageGrid")
                    UseDamageGrid = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseShatterPoints")
                    UseShatterPoints = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShatterColor")
                    ShatterColor = new Color(data.Variant as CColor);
                if (data.REDName == "ShatterTexture")
                    ShatterTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ShatterNormal")
                    ShatterNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ShatterNormalStrength")
                    ShatterNormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShatterRadiusScale")
                    ShatterRadiusScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShatterAspectRatio")
                    ShatterAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShatterCutout")
                    ShatterCutout = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DamageGridCutout")
                    DamageGridCutout = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugShatterPoint0")
                    DebugShatterPoint0 = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Cracks")
                    Cracks = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "CracksTiling")
                    CracksTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsNormalTxt")
                    DotsNormalTxt = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DotsTxt")
                    DotsTxt = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FlowTxt")
                    FlowTxt = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WiperMask")
                    WiperMask = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _vehicle_glass_proxy
    {
        public _vehicle_glass_proxy() { }
        public _vehicle_glass_proxy(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UvTilingX")
                    UvTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingY")
                    UvTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetX")
                    UvOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetY")
                    UvOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "FrontFacesReflectionPower")
                    FrontFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassSpecularColor")
                    GlassSpecularColor = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _vehicle_lights
    {
        public _vehicle_lights() { }
        public _vehicle_lights(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UvTilingX")
                    UvTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingY")
                    UvTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetX")
                    UvOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetY")
                    UvOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DamageInfluence")
                    DamageInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DamageInfluenceDebug")
                    DamageInfluenceDebug = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissionTiling")
                    EmissionTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissionParallax")
                    EmissionParallax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Zone0EmissiveEV")
                    Zone0EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Zone1EmissiveEV")
                    Zone1EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Zone2EmissiveEV")
                    Zone2EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Zone3EmissiveEV")
                    Zone3EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugLightsIntensity")
                    DebugLightsIntensity = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DebugLightsColor0")
                    DebugLightsColor0 = new Color(data.Variant as CColor);
                if (data.REDName == "DebugLightsColor1")
                    DebugLightsColor1 = new Color(data.Variant as CColor);
                if (data.REDName == "DebugLightsColor2")
                    DebugLightsColor2 = new Color(data.Variant as CColor);
                if (data.REDName == "DebugLightsColor3")
                    DebugLightsColor3 = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _vehicle_mesh_decal
    {
        public _vehicle_mesh_decal() { }
        public _vehicle_mesh_decal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DamageInfluence")
                    DamageInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DamageInfluenceDebug")
                    DamageInfluenceDebug = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "DiffuseAlpha")
                    DiffuseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GradientMap")
                    GradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseGradientMap")
                    UseGradientMap = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalAlpha")
                    NormalAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalsBlendingMode")
                    NormalsBlendingMode = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DepthThreshold")
                    DepthThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtMap")
                    DirtMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DirtOpacity")
                    DirtOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtMaskOffsets")
                    DirtMaskOffsets = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _ver_mov
    {
        public _ver_mov() { }
        public _ver_mov(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "IsControlledByDestruction")
                    IsControlledByDestruction = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "vertex_paint_tex")
                    vertex_paint_tex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "trans_min")
                    trans_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_max")
                    trans_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_min")
                    rot_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_max")
                    rot_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_pieces")
                    n_pieces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "play_time")
                    play_time = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "debug_familys")
                    debug_familys = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "YAxisUp")
                    YAxisUp = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "z_min")
                    z_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ground_offset")
                    ground_offset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _ver_mov_glass
    {
        public _ver_mov_glass() { }
        public _ver_mov_glass(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OpacityBackFace")
                    OpacityBackFace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingX")
                    UvTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvTilingY")
                    UvTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetX")
                    UvOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvOffsetY")
                    UvOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTileAndOffset")
                    RoughnessTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "NormalTileAndOffset")
                    NormalTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlassTintTileAndOffset")
                    GlassTintTileAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "vertex_paint_tex")
                    vertex_paint_tex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "IsControlledByDestruction")
                    IsControlledByDestruction = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_min")
                    trans_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_max")
                    trans_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_min")
                    rot_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_max")
                    rot_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_pieces")
                    n_pieces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "play_time")
                    play_time = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "debug_familys")
                    debug_familys = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "YAxisUp")
                    YAxisUp = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "z_min")
                    z_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ground_offset")
                    ground_offset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassTint")
                    GlassTint = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "TintFromVertexPaint")
                    TintFromVertexPaint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FrontFacesReflectionPower")
                    FrontFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackFacesReflectionPower")
                    BackFacesReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionDepth")
                    RefractionDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassSpecularColor")
                    GlassSpecularColor = new Color(data.Variant as CColor);
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalMapAffectsSpecular")
                    NormalMapAffectsSpecular = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlassRoughnessBias")
                    GlassRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskRoughnessBias")
                    MaskRoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurRadius")
                    BlurRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurByRoughness")
                    BlurByRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _ver_mov_multilayered
    {
        public _ver_mov_multilayered() { }
        public _ver_mov_multilayered(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "vertex_paint_tex")
                    vertex_paint_tex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "IsControlledByDestruction")
                    IsControlledByDestruction = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_min")
                    trans_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_max")
                    trans_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_min")
                    rot_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_max")
                    rot_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_pieces")
                    n_pieces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "play_time")
                    play_time = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "z_min")
                    z_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ground_offset")
                    ground_offset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SetupLayerMask")
                    SetupLayerMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _ver_skinned_mov
    {
        public _ver_skinned_mov() { }
        public _ver_skinned_mov(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "vertex_paint_tex")
                    vertex_paint_tex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "vertex_paint_tex_z")
                    vertex_paint_tex_z = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "trans_min")
                    trans_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_max")
                    trans_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_min")
                    rot_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_max")
                    rot_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "buffer_offset")
                    buffer_offset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_pieces")
                    n_pieces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "play_time")
                    play_time = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "debug_familys")
                    debug_familys = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "YAxisUp")
                    YAxisUp = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "z_multiply")
                    z_multiply = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ground_offset")
                    ground_offset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "bounds_and_pivot")
                    bounds_and_pivot = new Vec4(data.Variant as Vector4);
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoliageProfileMap")
                    FoliageProfileMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoliageProfile")
                    FoliageProfile = (data.Variant as rRef<CFoliageProfile>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _ver_skinned_mov_parade
    {
        public _ver_skinned_mov_parade() { }
        public _ver_skinned_mov_parade(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "vertex_paint_tex")
                    vertex_paint_tex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "trans_min")
                    trans_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "trans_max")
                    trans_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_min")
                    rot_min = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "rot_max")
                    rot_max = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_frames")
                    n_frames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "n_pieces")
                    n_pieces = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "frame_rate")
                    frame_rate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _window_interior_uv
    {
        public _window_interior_uv() { }
        public _window_interior_uv(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Glass")
                    Glass = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LightIntensity")
                    LightIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightColor")
                    LightColor = new Color(data.Variant as CColor);
                if (data.REDName == "GlassColor")
                    GlassColor = new Color(data.Variant as CColor);
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalScale")
                    NormalScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoomHeight")
                    RoomHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoomWidth")
                    RoomWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureTiling")
                    TextureTiling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "CeilFloorColor")
                    CeilFloorColor = new Color(data.Variant as CColor);
                if (data.REDName == "WallColor")
                    WallColor = new Color(data.Variant as CColor);
                if (data.REDName == "Ceiling")
                    Ceiling = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WallsXY")
                    WallsXY = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WallsZY")
                    WallsZY = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Floor")
                    Floor = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _window_parallax_interior
    {
        public _window_parallax_interior() { }
        public _window_parallax_interior(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "RoomAtlas")
                    RoomAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayerAtlas")
                    LayerAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Curtain")
                    Curtain = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ColorOverlayTexture")
                    ColorOverlayTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AtlasGridUvRatio")
                    AtlasGridUvRatio = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AtlasDepth")
                    AtlasDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "roomWidth")
                    roomWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "roomHeight")
                    roomHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "roomDepth")
                    roomDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "positionXoffset")
                    positionXoffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "positionYoffset")
                    positionYoffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "scaleXrandomization")
                    scaleXrandomization = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "positionXrandomization")
                    positionXrandomization = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerDepth")
                    LayerDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CurtainDepth")
                    CurtainDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CurtainMaxCover")
                    CurtainMaxCover = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CurtainCoverRandomize")
                    CurtainCoverRandomize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CurtainAlpha")
                    CurtainAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightsTempVariationAtNight")
                    LightsTempVariationAtNight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AmountTurnOffAtNight")
                    AmountTurnOffAtNight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WindowTexture")
                    WindowTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColorAtNight")
                    TintColorAtNight = new Color(data.Variant as CColor);
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _window_parallax_interior_proxy
    {
        public _window_parallax_interior_proxy() { }
        public _window_parallax_interior_proxy(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "RoomAtlas")
                    RoomAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Curtain")
                    Curtain = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ColorOverlayTexture")
                    ColorOverlayTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AtlasGridUvRatio")
                    AtlasGridUvRatio = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AtlasDepth")
                    AtlasDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "roomWidth")
                    roomWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "roomHeight")
                    roomHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "roomDepth")
                    roomDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "positionXoffset")
                    positionXoffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "positionYoffset")
                    positionYoffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "scaleXrandomization")
                    scaleXrandomization = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "positionXrandomization")
                    positionXrandomization = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightsTempVariationAtNight")
                    LightsTempVariationAtNight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CurtainDepth")
                    CurtainDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CurtainMaxCover")
                    CurtainMaxCover = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CurtainCoverRandomize")
                    CurtainCoverRandomize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CurtainAlpha")
                    CurtainAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AmountTurnOffAtNight")
                    AmountTurnOffAtNight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TintColorAtNight")
                    TintColorAtNight = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _window_parallax_interior_proxy_buffer
    {
        public _window_parallax_interior_proxy_buffer() { }
        public _window_parallax_interior_proxy_buffer(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _window_very_long_distance
    {
        public _window_very_long_distance() { }
        public _window_very_long_distance(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ColorOverlayTexture")
                    ColorOverlayTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldHeightMap")
                    WorldHeightMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldColorMap")
                    WorldColorMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WindowsSize")
                    WindowsSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Saturation")
                    Saturation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TurnedOff")
                    TurnedOff = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeStart")
                    FadeStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeEnd")
                    FadeEnd = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightsFadeStart")
                    LightsFadeStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightsFadeEnd")
                    LightsFadeEnd = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightsIntensityMultiplier")
                    LightsIntensityMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _worldspace_grid
    {
        public _worldspace_grid() { }
        public _worldspace_grid(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "GridScale")
                    GridScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "EnableWorldSpace")
                    EnableWorldSpace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AbsoluteWorldSpace")
                    AbsoluteWorldSpace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _bink_simple
    {
        public _bink_simple() { }
        public _bink_simple(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "ColorScale")
                    ColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "VideoCanvasName")
                    VideoCanvasName = (data.Variant as CName).Value;
                if (data.REDName == "BinkY")
                    BinkY = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BinkCR")
                    BinkCR = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BinkCB")
                    BinkCB = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BinkA")
                    BinkA = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _cable_strip
    {
        public _cable_strip() { }
        public _cable_strip(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "CableWidth")
                    CableWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _debugdraw_bias
    {
        public _debugdraw_bias() { }
        public _debugdraw_bias(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _debugdraw_wireframe
    {
        public _debugdraw_wireframe() { }
        public _debugdraw_wireframe(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _debugdraw_wireframe_bias
    {
        public _debugdraw_wireframe_bias() { }
        public _debugdraw_wireframe_bias(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _debug_coloring
    {
        public _debug_coloring() { }
        public _debug_coloring(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _font
    {
        public _font() { }
        public _font(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _global_water_patch
    {
        public _global_water_patch() { }
        public _global_water_patch(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "WaterFFT")
                    WaterFFT = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WaterMap")
                    WaterMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WaterMapWeight")
                    WaterMapWeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaterSize")
                    WaterSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShoreThreshold")
                    ShoreThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ShoreOffset")
                    ShoreOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Choppiness")
                    Choppiness = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScatteringDepth")
                    ScatteringDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalDetailScale")
                    NormalDetailScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalDetailIntensity")
                    NormalDetailIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatteringSunRadius")
                    ScatteringSunRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatteringSunIntensity")
                    ScatteringSunIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatteringColor")
                    ScatteringColor = new Color(data.Variant as CColor);
                if (data.REDName == "BlurRadius")
                    BlurRadius = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatteringSlopeThreshold")
                    ScatteringSlopeThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatteringSlopeIntensity")
                    ScatteringSlopeIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WaterOpacity")
                    WaterOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IndexOfRefraction")
                    IndexOfRefraction = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionNormalIntensity")
                    RefractionNormalIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurStrength")
                    BlurStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FoamTexture")
                    FoamTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FoamColor")
                    FoamColor = new Color(data.Variant as CColor);
                if (data.REDName == "FoamSize")
                    FoamSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FoamThreshold")
                    FoamThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FoamIntensity")
                    FoamIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EdgeBlend")
                    EdgeBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_animated_uv
    {
        public _metal_base_animated_uv() { }
        public _metal_base_animated_uv(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UvPanningSpeedX")
                    UvPanningSpeedX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UvPanningSpeedY")
                    UvPanningSpeedY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveLift")
                    EmissiveLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_blendable
    {
        public _metal_base_blendable() { }
        public _metal_base_blendable(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FadeOutDistance")
                    FadeOutDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeOutOffset")
                    FadeOutOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffset")
                    GlitchOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelColor")
                    FresnelColor = new Color(data.Variant as CColor);
                if (data.REDName == "FresnelColorIntensity")
                    FresnelColorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelExponent")
                    FresnelExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveLift")
                    EmissiveLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_fence
    {
        public _metal_base_fence() { }
        public _metal_base_fence(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_garment
    {
        public _metal_base_garment() { }
        public _metal_base_garment(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_packed
    {
        public _metal_base_packed() { }
        public _metal_base_packed(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "RoughMetal")
                    RoughMetal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_proxy
    {
        public _metal_base_proxy() { }
        public _metal_base_proxy(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldColorMap")
                    WorldColorMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldHeightMap")
                    WorldHeightMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "FadeStart")
                    FadeStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeEnd")
                    FadeEnd = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveLift")
                    EmissiveLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _multilayered
    {
        public _multilayered() { }
        public _multilayered(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;
                if (data.REDName == "GlobalNormalIntensity")
                    GlobalNormalIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlobalNormalUVScale")
                    GlobalNormalUVScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlobalNormalUVBias")
                    GlobalNormalUVBias = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SetupLayerMask")
                    SetupLayerMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _multilayered_debug
    {
        public _multilayered_debug() { }
        public _multilayered_debug(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _pbr_simple
    {
        public _pbr_simple() { }
        public _pbr_simple(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _shadows_debug
    {
        public _shadows_debug() { }
        public _shadows_debug(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _transparent_notxaa_2
    {
        public _transparent_notxaa_2() { }
        public _transparent_notxaa_2(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _ui_default_element
    {
        public _ui_default_element() { }
        public _ui_default_element(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_default_nine_slice_element
    {
        public _ui_default_nine_slice_element() { }
        public _ui_default_nine_slice_element(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_default_tile_element
    {
        public _ui_default_tile_element() { }
        public _ui_default_tile_element(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_box_blur
    {
        public _ui_effect_box_blur() { }
        public _ui_effect_box_blur(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_color_correction
    {
        public _ui_effect_color_correction() { }
        public _ui_effect_color_correction(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_color_fill
    {
        public _ui_effect_color_fill() { }
        public _ui_effect_color_fill(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_glitch
    {
        public _ui_effect_glitch() { }
        public _ui_effect_glitch(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_inner_glow
    {
        public _ui_effect_inner_glow() { }
        public _ui_effect_inner_glow(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_light_sweep
    {
        public _ui_effect_light_sweep() { }
        public _ui_effect_light_sweep(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_linear_wipe
    {
        public _ui_effect_linear_wipe() { }
        public _ui_effect_linear_wipe(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_mask
    {
        public _ui_effect_mask() { }
        public _ui_effect_mask(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_point_cloud
    {
        public _ui_effect_point_cloud() { }
        public _ui_effect_point_cloud(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_radial_wipe
    {
        public _ui_effect_radial_wipe() { }
        public _ui_effect_radial_wipe(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_effect_swipe
    {
        public _ui_effect_swipe() { }
        public _ui_effect_swipe(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_element_depth_texture
    {
        public _ui_element_depth_texture() { }
        public _ui_element_depth_texture(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _ui_panel
    {
        public _ui_panel() { }
        public _ui_panel(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "CameraName")
                    CameraName = (data.Variant as CName).Value;
            }
        }
    }
    public partial class _ui_text_element
    {
        public _ui_text_element() { }
        public _ui_text_element(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "hackParameterForUiBatcher")
                    hackParameterForUiBatcher = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _alphablend_glass
    {
        public _alphablend_glass() { }
        public _alphablend_glass(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "TextureScaling")
                    TextureScaling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "InterlaceScale")
                    InterlaceScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InterlaceIntensityLow")
                    InterlaceIntensityLow = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InterlaceIntensityHigh")
                    InterlaceIntensityHigh = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UVdivisions")
                    UVdivisions = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UVoffset")
                    UVoffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _alpha_control_refraction
    {
        public _alpha_control_refraction() { }
        public _alpha_control_refraction(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionMap")
                    RefractionMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RecolorMap")
                    RecolorMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RefractionAmount")
                    RefractionAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionSpeed")
                    RefractionSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "JerkingSpeed")
                    JerkingSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "JerkingAmount")
                    JerkingAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxAlpha")
                    MaxAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RecolorAmount")
                    RecolorAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RecolorMultiplier")
                    RecolorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SpecularColor")
                    SpecularColor = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _animated_decal
    {
        public _animated_decal() { }
        public _animated_decal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseAlpha")
                    DiffuseAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalAlpha")
                    NormalAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RevealMasks")
                    RevealMasks = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationFramesWidth")
                    AnimationFramesWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AnimationFramesHeight")
                    AnimationFramesHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FloatParam")
                    FloatParam = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _beam_particles
    {
        public _beam_particles() { }
        public _beam_particles(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MainTexture")
                    MainTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AdditionalMask")
                    AdditionalMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseMaskROrA")
                    UseMaskROrA = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditionalMaskFlowmap")
                    AdditionalMaskFlowmap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MainColor")
                    MainColor = new Color(data.Variant as CColor);
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureScale")
                    TextureScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureStretch")
                    TextureStretch = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureHasNoAlpha")
                    TextureHasNoAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlackbodyOrColor")
                    BlackbodyOrColor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlowmapControl")
                    FlowmapControl = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AdditionalMaskControl")
                    AdditionalMaskControl = new Vec4(data.Variant as Vector4);
                if (data.REDName == "FlowmapMultiplier")
                    FlowmapMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureHasAlpha")
                    TextureHasAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _blackbodyradiation
    {
        public _blackbodyradiation() { }
        public _blackbodyradiation(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Temperature")
                    Temperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "subUVWidth")
                    subUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaExponent")
                    AlphaExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "subUVHeight")
                    subUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatterAmount")
                    ScatterAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatterPower")
                    ScatterPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FireScatterAlpha")
                    FireScatterAlpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "HueShift")
                    HueShift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HueSpread")
                    HueSpread = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "maxAlpha")
                    maxAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightSmoke")
                    LightSmoke = new Color(data.Variant as CColor);
                if (data.REDName == "DarkSmoke")
                    DarkSmoke = new Color(data.Variant as CColor);
                if (data.REDName == "ExpensiveBlending")
                    ExpensiveBlending = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Saturation")
                    Saturation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MultiplierExponent")
                    MultiplierExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TexCoordDtortScale")
                    TexCoordDtortScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordDtortSpeed")
                    TexCoordDtortSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Distort")
                    Distort = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NoAlphaOnTexture")
                    NoAlphaOnTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EatUpOrStraightAlpha")
                    EatUpOrStraightAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRowAnimation")
                    EnableRowAnimation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DoNotApplyLighting")
                    DoNotApplyLighting = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "InvertMask")
                    InvertMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTilingAndSpeed")
                    MaskTilingAndSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskIntensity")
                    MaskIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseVertexAlpha")
                    UseVertexAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotWithLookAt")
                    DotWithLookAt = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _blackbody_simple
    {
        public _blackbody_simple() { }
        public _blackbody_simple(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TemperatureTexture")
                    TemperatureTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Temperature")
                    Temperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _blood_transparent
    {
        public _blood_transparent() { }
        public _blood_transparent(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorThin")
                    ColorThin = new Color(data.Variant as CColor);
                if (data.REDName == "ColorThick")
                    ColorThick = new Color(data.Variant as CColor);
                if (data.REDName == "BloodThickness")
                    BloodThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightingBleeding")
                    LightingBleeding = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SpecularPower")
                    SpecularPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SpecularMultiplier")
                    SpecularMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CurrentFrame")
                    CurrentFrame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalAndDensity")
                    NormalAndDensity = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "VelocityMap")
                    VelocityMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SpecularMap")
                    SpecularMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FlowmapStrength")
                    FlowmapStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalPow")
                    NormalPow = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EVCompensation")
                    EVCompensation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _braindance_fog
    {
        public _braindance_fog() { }
        public _braindance_fog(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BrightnessNear")
                    BrightnessNear = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BrightnessFar")
                    BrightnessFar = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RevealMask")
                    RevealMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RevealMaskFramesY")
                    RevealMaskFramesY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RevealMaskBoundsMin")
                    RevealMaskBoundsMin = new Vec4(data.Variant as Vector4);
                if (data.REDName == "RevealMaskBoundsMax")
                    RevealMaskBoundsMax = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TonemapExposure")
                    TonemapExposure = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FarFogBrightness")
                    FarFogBrightness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FarFogDistance")
                    FarFogDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseHack_SQ021")
                    UseHack_SQ021 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CluesMap")
                    CluesMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "CluesBrightness")
                    CluesBrightness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseClueDepthClipping")
                    UseClueDepthClipping = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "VectorFieldSliceCount")
                    VectorFieldSliceCount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorFieldTiling")
                    VectorFieldTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorFieldAnimSpeed")
                    VectorFieldAnimSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorFieldStrength")
                    VectorFieldStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _braindance_particle_thermal
    {
        public _braindance_particle_thermal() { }
        public _braindance_particle_thermal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Brightness")
                    Brightness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FireScatterAlpha")
                    FireScatterAlpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "subUVWidth")
                    subUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "subUVHeight")
                    subUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaExponent")
                    AlphaExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "maxAlpha")
                    maxAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EatUpOrStraightAlpha")
                    EatUpOrStraightAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseVertexAlpha")
                    UseVertexAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cloak
    {
        public _cloak() { }
        public _cloak(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Distortion")
                    Distortion = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DistortionUVScale")
                    DistortionUVScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DistortionVisibility")
                    DistortionVisibility = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IridescenceMask")
                    IridescenceMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "IridescenceSpeed")
                    IridescenceSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IridescenceDim")
                    IridescenceDim = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Tinge")
                    Tinge = new Color(data.Variant as CColor);
                if (data.REDName == "DirtMask")
                    DirtMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DirtMaskScaleAndOffset")
                    DirtMaskScaleAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DirtMaskPower")
                    DirtMaskPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtMaskMultiplier")
                    DirtMaskMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtColor")
                    DirtColor = new Color(data.Variant as CColor);
                if (data.REDName == "UseOutline")
                    UseOutline = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OutlineOpacity")
                    OutlineOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OutlineSize")
                    OutlineSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cyberspace_pixelsort_stencil
    {
        public _cyberspace_pixelsort_stencil() { }
        public _cyberspace_pixelsort_stencil(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "CameraOffsetZ")
                    CameraOffsetZ = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cyberspace_pixelsort_stencil_0
    {
        public _cyberspace_pixelsort_stencil_0() { }
        public _cyberspace_pixelsort_stencil_0(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cyberware_animation
    {
        public _cyberware_animation() { }
        public _cyberware_animation(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveMask")
                    EmissiveMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseTimeOrFloatParam")
                    UseTimeOrFloatParam = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _damage_indicator
    {
        public _damage_indicator() { }
        public _damage_indicator(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Noise")
                    Noise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DoubleDistortWithNoise")
                    DoubleDistortWithNoise = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Scanline")
                    Scanline = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NoiseScailingAndSpeed")
                    NoiseScailingAndSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MinMaskExponent")
                    MinMaskExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxMaskExponent")
                    MaxMaskExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskMultiplier")
                    MaskMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThickScanlinesColor")
                    ThickScanlinesColor = new Color(data.Variant as CColor);
                if (data.REDName == "ThinScanlinesColor")
                    ThinScanlinesColor = new Color(data.Variant as CColor);
                if (data.REDName == "ScanlineDensity")
                    ScanlineDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineMinimumValue")
                    ScanlineMinimumValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThickScanlineMultiplier")
                    ThickScanlineMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThinScanlineExponent")
                    ThinScanlineExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThinScanlineMultiplier")
                    ThinScanlineMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionOffsetStrength")
                    RefractionOffsetStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _device_diode
    {
        public _device_diode() { }
        public _device_diode(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "NormalOffset")
                    NormalOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VehicleDamageInfluence")
                    VehicleDamageInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Blinking")
                    Blinking = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkingSpeed")
                    BlinkingSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseMaterialParameter")
                    UseMaterialParameter = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor1")
                    EmissiveColor1 = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveColor2")
                    EmissiveColor2 = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveInitialState")
                    EmissiveInitialState = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseTwoEmissiveColors")
                    UseTwoEmissiveColors = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SwitchingTwoEmissiveColorsSpeed")
                    SwitchingTwoEmissiveColorsSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseFresnel")
                    UseFresnel = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _device_diode_multi_state
    {
        public _device_diode_multi_state() { }
        public _device_diode_multi_state(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "NormalOffset")
                    NormalOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor1")
                    EmissiveColor1 = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveColor2")
                    EmissiveColor2 = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveColor3")
                    EmissiveColor3 = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveColor4")
                    EmissiveColor4 = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveColorSelector")
                    EmissiveColorSelector = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Blinking")
                    Blinking = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkingSpeed")
                    BlinkingSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseMaterialParameter")
                    UseMaterialParameter = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveInitialState")
                    EmissiveInitialState = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _diode_pavements
    {
        public _diode_pavements() { }
        public _diode_pavements(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiodesMask")
                    DiodesMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SignTexture")
                    SignTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiodesTilingAndScrollSpeed")
                    DiodesTilingAndScrollSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseMaskAsAlphaThreshold")
                    UseMaskAsAlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AmountOfGlitch")
                    AmountOfGlitch = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchSpeed")
                    GlitchSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NumberOfRows")
                    NumberOfRows = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplayRow")
                    DisplayRow = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColorRoughnessTiling")
                    BaseColorRoughnessTiling = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _drugged_sobel
    {
        public _drugged_sobel() { }
        public _drugged_sobel(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DarkColor")
                    DarkColor = new Color(data.Variant as CColor);
                if (data.REDName == "BrightColor")
                    BrightColor = new Color(data.Variant as CColor);
                if (data.REDName == "DarkColorPower")
                    DarkColorPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "KernelOffset")
                    KernelOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseInEngineSobel")
                    UseInEngineSobel = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _emissive_basic_transparent
    {
        public _emissive_basic_transparent() { }
        public _emissive_basic_transparent(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AnimMask")
                    AnimMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _fog_laser
    {
        public _fog_laser() { }
        public _fog_laser(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditionalThicnkess")
                    AdditionalThicnkess = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TimeScale")
                    TimeScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseTexture")
                    NoiseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DetailNoiseScale")
                    DetailNoiseScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DetailNoiseBrighten")
                    DetailNoiseBrighten = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GeneralNoiseScale")
                    GeneralNoiseScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LaserColor")
                    LaserColor = new Color(data.Variant as CColor);
                if (data.REDName == "SmokeExponent")
                    SmokeExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmokeMultiplier")
                    SmokeMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LineThreshold")
                    LineThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LineMultiplier")
                    LineMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LineAddOrSubtract")
                    LineAddOrSubtract = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseSoftAlpha")
                    UseSoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftAlphaMultiplier")
                    SoftAlphaMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HorizontalGradientMultiplier")
                    HorizontalGradientMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlipEdgeFade")
                    FlipEdgeFade = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseVertexColor")
                    UseVertexColor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureRatioU")
                    TextureRatioU = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureRatioV")
                    TextureRatioV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IntensiveCore")
                    IntensiveCore = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RotateUV")
                    RotateUV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "VectorFieldSliceCount")
                    VectorFieldSliceCount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseWorldSpace")
                    UseWorldSpace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _hologram
    {
        public _hologram() { }
        public _hologram(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "ScaleReferencePosAndScale")
                    ScaleReferencePosAndScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OpaqueScanlineDensity")
                    OpaqueScanlineDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Scanline")
                    Scanline = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DotsTexture")
                    DotsTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DotsSize")
                    DotsSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsColor")
                    DotsColor = new Color(data.Variant as CColor);
                if (data.REDName == "Projector1Position")
                    Projector1Position = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SurfaceColor")
                    SurfaceColor = new Color(data.Variant as CColor);
                if (data.REDName == "SurfaceShadows")
                    SurfaceShadows = new Color(data.Variant as CColor);
                if (data.REDName == "FallofColor")
                    FallofColor = new Color(data.Variant as CColor);
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GradientOffset")
                    GradientOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientLength")
                    GradientLength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelStrength")
                    FresnelStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsFresnelStrength")
                    DotsFresnelStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlowStrength")
                    GlowStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DesaturationStrength")
                    DesaturationStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlickerThreshold")
                    FlickerThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlickerChance")
                    FlickerChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactsChance")
                    ArtifactsChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightBleed")
                    LightBleed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScreenSpaceFlicker")
                    ScreenSpaceFlicker = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseIsobars")
                    UseIsobars = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EntropyThreshold")
                    EntropyThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseMovingDots")
                    UseMovingDots = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IsHair")
                    IsHair = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineThickness")
                    ScanlineThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlobalTint")
                    GlobalTint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SampledOrProceduralDots")
                    SampledOrProceduralDots = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FullColorOrGrayscale")
                    FullColorOrGrayscale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _hologram_two_sided
    {
        public _hologram_two_sided() { }
        public _hologram_two_sided(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "ScaleReferencePosAndScale")
                    ScaleReferencePosAndScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Scanline")
                    Scanline = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DotsTexture")
                    DotsTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Projector1Position")
                    Projector1Position = new Vec4(data.Variant as Vector4);
                if (data.REDName == "OpaqueScanlineDensity")
                    OpaqueScanlineDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsSize")
                    DotsSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsColor")
                    DotsColor = new Color(data.Variant as CColor);
                if (data.REDName == "SurfaceColor")
                    SurfaceColor = new Color(data.Variant as CColor);
                if (data.REDName == "SurfaceShadows")
                    SurfaceShadows = new Color(data.Variant as CColor);
                if (data.REDName == "FallofColor")
                    FallofColor = new Color(data.Variant as CColor);
                if (data.REDName == "GradientOffset")
                    GradientOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientLength")
                    GradientLength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelStrength")
                    FresnelStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsFresnelStrength")
                    DotsFresnelStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlowStrength")
                    GlowStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DesaturationStrength")
                    DesaturationStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlickerThreshold")
                    FlickerThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlickerChance")
                    FlickerChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactsChance")
                    ArtifactsChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightBleed")
                    LightBleed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScreenSpaceFlicker")
                    ScreenSpaceFlicker = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseIsobars")
                    UseIsobars = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EntropyThreshold")
                    EntropyThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseMovingDots")
                    UseMovingDots = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IsHair")
                    IsHair = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineThickness")
                    ScanlineThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Opacity")
                    Opacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlobalTint")
                    GlobalTint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SampledOrProceduralDots")
                    SampledOrProceduralDots = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FullColorOrGrayscale")
                    FullColorOrGrayscale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _holo_projections
    {
        public _holo_projections() { }
        public _holo_projections(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMultiply")
                    ColorMultiply = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "BrightnessNoiseStreght")
                    BrightnessNoiseStreght = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FrameNum")
                    FrameNum = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "PlaySpeed")
                    PlaySpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InvertSoftAlpha")
                    InvertSoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UVScrollSpeed")
                    UVScrollSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScrollStepFactor")
                    ScrollStepFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollMaskOrTexture")
                    ScrollMaskOrTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RandomAnimation")
                    RandomAnimation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RandomFrameFrequency")
                    RandomFrameFrequency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RandomFrameChangeSpeed")
                    RandomFrameChangeSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FrameNumDisplayChance")
                    FrameNumDisplayChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScrollingMaskTexture")
                    ScrollingMaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _hud_focus_mode_scanline
    {
        public _hud_focus_mode_scanline() { }
        public _hud_focus_mode_scanline(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Progress")
                    Progress = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "vProgress")
                    vProgress = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineDensity")
                    ScanlineDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineOffset")
                    ScanlineOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineWidth")
                    ScanlineWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EffectIntensity")
                    EffectIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineDensityVertical")
                    ScanlineDensityVertical = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineOffsetVertical")
                    ScanlineOffsetVertical = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineWidthVertical")
                    ScanlineWidthVertical = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VerticalIntensity")
                    VerticalIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BarsWidth")
                    BarsWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SideFadeWidth")
                    SideFadeWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SideFadeFeather")
                    SideFadeFeather = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _hud_markers_notxaa
    {
        public _hud_markers_notxaa() { }
        public _hud_markers_notxaa(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Second_Color")
                    Second_Color = new Color(data.Variant as CColor);
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ClampOrWrap")
                    ClampOrWrap = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingX")
                    TillingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingY")
                    TillingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetX")
                    OffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetY")
                    OffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WipeValue")
                    WipeValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RotateUV90Deg")
                    RotateUV90Deg = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InverseSoftAlphaValue")
                    InverseSoftAlphaValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseOnMeshes")
                    UseOnMeshes = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseWorldSpaceNoise")
                    UseWorldSpaceNoise = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldSpaceNoise")
                    WorldSpaceNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldSpaceNoiseTilling")
                    WorldSpaceNoiseTilling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseSpeed")
                    NoiseSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelPower")
                    FresnelPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelContrast")
                    FresnelContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SecondSoftAlpha")
                    SecondSoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _hud_markers_transparent
    {
        public _hud_markers_transparent() { }
        public _hud_markers_transparent(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Second_Color")
                    Second_Color = new Color(data.Variant as CColor);
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ClampOrWrap")
                    ClampOrWrap = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingX")
                    TillingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingY")
                    TillingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetX")
                    OffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetY")
                    OffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RotateUV90Deg")
                    RotateUV90Deg = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WipeValue")
                    WipeValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InverseSoftAlphaValue")
                    InverseSoftAlphaValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseOnMeshes")
                    UseOnMeshes = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseWorldSpaceNoise")
                    UseWorldSpaceNoise = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldSpaceNoise")
                    WorldSpaceNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldSpaceNoiseTilling")
                    WorldSpaceNoiseTilling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseSpeed")
                    NoiseSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelPower")
                    FresnelPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelContrast")
                    FresnelContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SecondSoftAlpha")
                    SecondSoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _hud_markers_vision
    {
        public _hud_markers_vision() { }
        public _hud_markers_vision(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Second_Color")
                    Second_Color = new Color(data.Variant as CColor);
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ClampOrWrap")
                    ClampOrWrap = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingX")
                    TillingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingY")
                    TillingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetX")
                    OffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetY")
                    OffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RotateUV90Deg")
                    RotateUV90Deg = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WipeValue")
                    WipeValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InverseSoftAlphaValue")
                    InverseSoftAlphaValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseOnMeshes")
                    UseOnMeshes = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseWorldSpaceNoise")
                    UseWorldSpaceNoise = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldSpaceNoise")
                    WorldSpaceNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "WorldSpaceNoiseTilling")
                    WorldSpaceNoiseTilling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseSpeed")
                    NoiseSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelPower")
                    FresnelPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelContrast")
                    FresnelContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SecondSoftAlpha")
                    SecondSoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _hud_ui_dot
    {
        public _hud_ui_dot() { }
        public _hud_ui_dot(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingX")
                    TillingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingY")
                    TillingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetX")
                    OffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetY")
                    OffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _hud_vision_pass
    {
        public _hud_vision_pass() { }
        public _hud_vision_pass(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TextureTilingAndSpeed")
                    TextureTilingAndSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaMultiplier")
                    AlphaMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftTransparencyAmount")
                    SoftTransparencyAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftContrast")
                    SoftContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseVertexColor")
                    UseVertexColor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Wipe")
                    Wipe = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TestForDepth")
                    TestForDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _johnny_effect
    {
        public _johnny_effect() { }
        public _johnny_effect(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Tilling")
                    Tilling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Contrast")
                    Contrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _johnny_glitch
    {
        public _johnny_glitch() { }
        public _johnny_glitch(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Offset")
                    Offset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "BodyColor")
                    BodyColor = new Color(data.Variant as CColor);
                if (data.REDName == "Tilling")
                    Tilling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Contrast")
                    Contrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LineLength")
                    LineLength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinDistance")
                    MinDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxDistance")
                    MaxDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxSteps")
                    MaxSteps = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseSpeed")
                    NoiseSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackgroundOffset")
                    BackgroundOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurredIntensity")
                    BlurredIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseSize")
                    NoiseSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeX1")
                    TileSizeX1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeY1")
                    TileSizeY1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeX2")
                    TileSizeX2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeY2")
                    TileSizeY2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchSpeed")
                    GlitchSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseHorizontal")
                    UseHorizontal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VectorField")
                    VectorField = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _metal_base_atlas_animation
    {
        public _metal_base_atlas_animation() { }
        public _metal_base_atlas_animation(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LoopedAnimationSpeed")
                    LoopedAnimationSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_blackbody
    {
        public _metal_base_blackbody() { }
        public _metal_base_blackbody(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveMask")
                    EmissiveMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "HeatDistribution")
                    HeatDistribution = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskMinimum")
                    MaskMinimum = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HeatTilingX")
                    HeatTilingX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HeatTilingY")
                    HeatTilingY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxTemperature")
                    MaxTemperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HSV_Mod")
                    HSV_Mod = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DebugTemperature")
                    DebugTemperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugOrExternalCurve")
                    DebugOrExternalCurve = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HeatMoveSpeed")
                    HeatMoveSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_glitter
    {
        public _metal_base_glitter() { }
        public _metal_base_glitter(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaFromEmissive")
                    AlphaFromEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveMask")
                    EmissiveMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "HistogramRange")
                    HistogramRange = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollSpeed")
                    ScrollSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveTile")
                    EmissiveTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Looped")
                    Looped = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _neon_tubes
    {
        public _neon_tubes() { }
        public _neon_tubes(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEdgeMult")
                    EmissiveEdgeMult = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "color")
                    color = new Color(data.Variant as CColor);
                if (data.REDName == "tex1")
                    tex1 = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "fresnelpower")
                    fresnelpower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseBlinkingNoise")
                    UseBlinkingNoise = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkSpeed")
                    BlinkSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinNoiseValue")
                    MinNoiseValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TimeSeed")
                    TimeSeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseMatParamToCtrlNoise")
                    UseMatParamToCtrlNoise = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureU")
                    TextureU = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureV")
                    TextureV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureIntensity")
                    TextureIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _noctovision_mode
    {
        public _noctovision_mode() { }
        public _noctovision_mode(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NPC_HDRColor1")
                    NPC_HDRColor1 = new Vec4(data.Variant as Vector4);
                if (data.REDName == "NPC_HDRColor2")
                    NPC_HDRColor2 = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Enemy_HDRColor1")
                    Enemy_HDRColor1 = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Enemy_HDRColor2")
                    Enemy_HDRColor2 = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Multiplier")
                    Multiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Distortion")
                    Distortion = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DistortionSpeed")
                    DistortionSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortionOffset")
                    DistortionOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnemyAlphaMultiplier")
                    EnemyAlphaMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineValues")
                    ScanlineValues = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScanlineContrast")
                    ScanlineContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _parallaxscreen
    {
        public _parallaxscreen() { }
        public _parallaxscreen(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "ParalaxTexture")
                    ParalaxTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScanlineTexture")
                    ScanlineTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ImageScale")
                    ImageScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayersSeparation")
                    LayersSeparation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IntensityPerLayer")
                    IntensityPerLayer = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScanlinesDensity")
                    ScanlinesDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlinesIntensity")
                    ScanlinesIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkingSpeed")
                    BlinkingSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkingMaskTexture")
                    BlinkingMaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScrollMaskTexture")
                    ScrollMaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScrollVerticalOrHorizontal")
                    ScrollVerticalOrHorizontal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollMaskStartPoint1")
                    ScrollMaskStartPoint1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollMaskHeight1")
                    ScrollMaskHeight1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollSpeed1")
                    ScrollSpeed1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollStepFactor1")
                    ScrollStepFactor1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollMaskStartPoint2")
                    ScrollMaskStartPoint2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollMaskHeight2")
                    ScrollMaskHeight2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollSpeed2")
                    ScrollSpeed2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollStepFactor2")
                    ScrollStepFactor2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "HSV_Mod")
                    HSV_Mod = new Vec4(data.Variant as Vector4);
                if (data.REDName == "IsBroken")
                    IsBroken = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FixForBlack")
                    FixForBlack = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _parallaxscreen_transparent
    {
        public _parallaxscreen_transparent() { }
        public _parallaxscreen_transparent(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ParalaxTexture")
                    ParalaxTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TexHSVControl")
                    TexHSVControl = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveOrAlphaBlened")
                    AdditiveOrAlphaBlened = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ImageScale")
                    ImageScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TextureOffsetX")
                    TextureOffsetX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureOffsetY")
                    TextureOffsetY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TilesWidth")
                    TilesWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TilesHeight")
                    TilesHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "PlaySpeed")
                    PlaySpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InterlaceLines")
                    InterlaceLines = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SeparateLayersFromTexture")
                    SeparateLayersFromTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayersSeparation")
                    LayersSeparation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IntensityPerLayer")
                    IntensityPerLayer = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScanlinesDensity")
                    ScanlinesDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlinesIntensity")
                    ScanlinesIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlinesSpeed")
                    ScanlinesSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoPostORPost")
                    NoPostORPost = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EdgesMask")
                    EdgesMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ClampUV")
                    ClampUV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollMaskTexture")
                    ScrollMaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScrollVerticalOrHorizontal")
                    ScrollVerticalOrHorizontal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollMaskStartPoint1")
                    ScrollMaskStartPoint1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollMaskHeight1")
                    ScrollMaskHeight1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollSpeed1")
                    ScrollSpeed1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollStepFactor1")
                    ScrollStepFactor1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollMaskStartPoint2")
                    ScrollMaskStartPoint2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollMaskHeight2")
                    ScrollMaskHeight2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollSpeed2")
                    ScrollSpeed2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScrollStepFactor2")
                    ScrollStepFactor2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayersScrollSpeed")
                    LayersScrollSpeed = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _parallaxscreen_transparent_ui
    {
        public _parallaxscreen_transparent_ui() { }
        public _parallaxscreen_transparent_ui(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineTexture")
                    ScanlineTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ImageScale")
                    ImageScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayersSeparation")
                    LayersSeparation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IntensityPerLayer")
                    IntensityPerLayer = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScanlinesDensity")
                    ScanlinesDensity = new Vec4(data.Variant as Vector4);
                if (data.REDName == "IsBroken")
                    IsBroken = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlinesIntensity")
                    ScanlinesIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UIRenderTexture")
                    UIRenderTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TexturePartUV")
                    TexturePartUV = new Vec4(data.Variant as Vector4);
                if (data.REDName == "FixToPbr")
                    FixToPbr = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RenderTextureScale")
                    RenderTextureScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "VerticalFlipEnabled")
                    VerticalFlipEnabled = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EdgeMask")
                    EdgeMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Tint")
                    Tint = new Color(data.Variant as CColor);
                if (data.REDName == "FixForVerticalSlide")
                    FixForVerticalSlide = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaAsOne")
                    AlphaAsOne = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SaturationLift")
                    SaturationLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _parallax_bink
    {
        public _parallax_bink() { }
        public _parallax_bink(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "ColorScale")
                    ColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "VideoCanvasName")
                    VideoCanvasName = (data.Variant as CName).Value;
                if (data.REDName == "BinkY")
                    BinkY = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BinkCR")
                    BinkCR = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BinkCB")
                    BinkCB = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BinkA")
                    BinkA = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _particles_generic_expanded
    {
        public _particles_generic_expanded() { }
        public _particles_generic_expanded(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftUVInterpolate")
                    SoftUVInterpolate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Desaturate")
                    Desaturate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorPower")
                    ColorPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TexCoordScale")
                    TexCoordScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordSpeed")
                    TexCoordSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordDtortScale")
                    TexCoordDtortScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordDistortSpeed")
                    TexCoordDistortSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AlphaGlobal")
                    AlphaGlobal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaSoft")
                    AlphaSoft = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaFresnelPower")
                    AlphaFresnelPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseAlphaFresnel")
                    UseAlphaFresnel = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseAlphaMask")
                    UseAlphaMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseOneChannel")
                    UseOneChannel = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseContrastAlpha")
                    UseContrastAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaMask")
                    AlphaMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Distortion")
                    Distortion = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseAlphaFresnelInverted")
                    UseAlphaFresnelInverted = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaFresnelInvertedPower")
                    AlphaFresnelInvertedPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaDistortAmount")
                    AlphaDistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaMaskDistortScale")
                    AlphaMaskDistortScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AlphaMaskDistortSpeed")
                    AlphaMaskDistortSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "UseTimeOfDay")
                    UseTimeOfDay = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _particles_hologram
    {
        public _particles_hologram() { }
        public _particles_hologram(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseMaterialParam")
                    UseMaterialParam = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorParam")
                    ColorParam = new Color(data.Variant as CColor);
                if (data.REDName == "DotsCoords")
                    DotsCoords = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "View_or_World")
                    View_or_World = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaSoft")
                    AlphaSoft = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchTexCoordSpeed")
                    GlitchTexCoordSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Dots")
                    Dots = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaMask")
                    AlphaMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GlitchTex")
                    GlitchTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaTexCoordSpeed")
                    AlphaTexCoordSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AlphaSubUVWidth")
                    AlphaSubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaSubUVHeight")
                    AlphaSubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftUVInterpolate")
                    SoftUVInterpolate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaGlobal")
                    AlphaGlobal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseOnMesh")
                    UseOnMesh = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _pointcloud_source_mesh
    {
        public _pointcloud_source_mesh() { }
        public _pointcloud_source_mesh(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "WorldPositionOffset")
                    WorldPositionOffset = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _postprocess
    {
        public _postprocess() { }
        public _postprocess(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Gain")
                    Gain = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ReColor")
                    ReColor = new Color(data.Variant as CColor);
                if (data.REDName == "BlurredIntensity")
                    BlurredIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskContrast")
                    MaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ReColorStrength")
                    ReColorStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _postprocess_notxaa
    {
        public _postprocess_notxaa() { }
        public _postprocess_notxaa(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Gain")
                    Gain = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ReColor")
                    ReColor = new Color(data.Variant as CColor);
                if (data.REDName == "BlurredIntensity")
                    BlurredIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskContrast")
                    MaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NumberOfIterations")
                    NumberOfIterations = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseMovingBlur")
                    UseMovingBlur = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ReColorStrength")
                    ReColorStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _radial_blur
    {
        public _radial_blur() { }
        public _radial_blur(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RedLinesMask")
                    RedLinesMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BlurMask")
                    BlurMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RedLinesDensity")
                    RedLinesDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RedLine1")
                    RedLine1 = new Color(data.Variant as CColor);
                if (data.REDName == "RedLine2")
                    RedLine2 = new Color(data.Variant as CColor);
                if (data.REDName == "BluringBackgroundRecolor")
                    BluringBackgroundRecolor = new Color(data.Variant as CColor);
                if (data.REDName == "AberationAmount")
                    AberationAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurAmount")
                    BlurAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightupAmount")
                    LightupAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MixAmount")
                    MixAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlurOrAberration")
                    BlurOrAberration = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ChromaticOffsetSpeed")
                    ChromaticOffsetSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _reflex_buster
    {
        public _reflex_buster() { }
        public _reflex_buster(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxDistortMulitiplier")
                    MaxDistortMulitiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinDistortMulitiplier")
                    MinDistortMulitiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ZoomMultiplier")
                    ZoomMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RelativeFStop")
                    RelativeFStop = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlobalTint")
                    GlobalTint = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Desaturate")
                    Desaturate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "UseAlphaOverEffect")
                    UseAlphaOverEffect = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _refraction
    {
        public _refraction() { }
        public _refraction(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TexCoordDtortScaleSpeed")
                    TexCoordDtortScaleSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Alpha")
                    Alpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseVertexAlpha")
                    UseVertexAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _sandevistan_trails
    {
        public _sandevistan_trails() { }
        public _sandevistan_trails(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MainTexture")
                    MainTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MainAdditiveTexture")
                    MainAdditiveTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MainColorMultiplier")
                    MainColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MainAdditiveColor")
                    MainAdditiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "MainAdditiveColorMultiplier")
                    MainAdditiveColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SlowFactor")
                    SlowFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MainAdditiveAlphaTimingExponent")
                    MainAdditiveAlphaTimingExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MainColorStart")
                    MainColorStart = new Color(data.Variant as CColor);
                if (data.REDName == "MainColorEnd")
                    MainColorEnd = new Color(data.Variant as CColor);
                if (data.REDName == "HueSpread")
                    HueSpread = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MainBlackBodyMultiplier")
                    MainBlackBodyMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _screens
    {
        public _screens() { }
        public _screens(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Tex1CoordMove")
                    Tex1CoordMove = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Tex1Color")
                    Tex1Color = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Tex2CoordMove")
                    Tex2CoordMove = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Tex2Color")
                    Tex2Color = new Vec4(data.Variant as Vector4);
                if (data.REDName == "BackCoordMove")
                    BackCoordMove = new Vec4(data.Variant as Vector4);
                if (data.REDName == "BackColor")
                    BackColor = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Tex2AnimSpeed")
                    Tex2AnimSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "background")
                    background = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Tex1")
                    Tex1 = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Tex2")
                    Tex2 = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Tex1UVSpeed")
                    Tex1UVSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DotsCoords")
                    DotsCoords = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackFlatOrCube")
                    BackFlatOrCube = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BackgroundCube")
                    BackgroundCube = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _screen_artifacts
    {
        public _screen_artifacts() { }
        public _screen_artifacts(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Complexity")
                    Complexity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Visiblity")
                    Visiblity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Disturbance")
                    Disturbance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Speed")
                    Speed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RandomNumber")
                    RandomNumber = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseBlackBackground")
                    UseBlackBackground = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BraindanceArtifacts")
                    BraindanceArtifacts = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingVertical")
                    TillingVertical = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingHorizontal")
                    TillingHorizontal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BendScreen")
                    BendScreen = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaClip")
                    AlphaClip = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _screen_artifacts_vision
    {
        public _screen_artifacts_vision() { }
        public _screen_artifacts_vision(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Complexity")
                    Complexity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Visiblity")
                    Visiblity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Disturbance")
                    Disturbance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Speed")
                    Speed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RandomNumber")
                    RandomNumber = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseBlackBackground")
                    UseBlackBackground = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BraindanceArtifacts")
                    BraindanceArtifacts = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingVertical")
                    TillingVertical = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingHorizontal")
                    TillingHorizontal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BendScreen")
                    BendScreen = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaClip")
                    AlphaClip = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _screen_black
    {
        public _screen_black() { }
        public _screen_black(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _screen_fast_travel_glitch
    {
        public _screen_fast_travel_glitch() { }
        public _screen_fast_travel_glitch(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "SingelColor")
                    SingelColor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Complexity")
                    Complexity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Density")
                    Density = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Disturbance")
                    Disturbance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Speed")
                    Speed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingVertical")
                    TillingVertical = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TillingHorizontal")
                    TillingHorizontal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BendScreen")
                    BendScreen = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Vertical")
                    Vertical = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _screen_glitch
    {
        public _screen_glitch() { }
        public _screen_glitch(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Offset")
                    Offset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GridColor")
                    GridColor = new Color(data.Variant as CColor);
                if (data.REDName == "BlurredIntensity")
                    BlurredIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseSize")
                    NoiseSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeX1")
                    TileSizeX1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeY1")
                    TileSizeY1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeX2")
                    TileSizeX2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeY2")
                    TileSizeY2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchSpeed")
                    GlitchSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchSpeedOffset")
                    GlitchSpeedOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchModTime")
                    GlitchModTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchDepth")
                    GlitchDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseSquareMask")
                    UseSquareMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseScreenSpaceMask")
                    UseScreenSpaceMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactColor")
                    ArtifactColor = new Color(data.Variant as CColor);
                if (data.REDName == "ArtifactIntensity")
                    ArtifactIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactNarrowness")
                    ArtifactNarrowness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactMinimizer")
                    ArtifactMinimizer = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactSpeed")
                    ArtifactSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactTimeOffset")
                    ArtifactTimeOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallArtifactsTileX")
                    SmallArtifactsTileX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallArtifactsTileY")
                    SmallArtifactsTileY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseStencilMask")
                    UseStencilMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseSmallArtifacts")
                    UseSmallArtifacts = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseBothSideBlur")
                    UseBothSideBlur = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseHorizontal")
                    UseHorizontal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseAlphaOverEntireEffect")
                    UseAlphaOverEntireEffect = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ErrorIntensity")
                    ErrorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InvertBrightnessMask")
                    InvertBrightnessMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotTex")
                    DotTex = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _screen_glitch_notxaa
    {
        public _screen_glitch_notxaa() { }
        public _screen_glitch_notxaa(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GridColor")
                    GridColor = new Color(data.Variant as CColor);
                if (data.REDName == "BlurredIntensity")
                    BlurredIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseSize")
                    NoiseSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeX1")
                    TileSizeX1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeY1")
                    TileSizeY1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeX2")
                    TileSizeX2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeY2")
                    TileSizeY2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchSpeed")
                    GlitchSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchSpeedOffset")
                    GlitchSpeedOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchModTime")
                    GlitchModTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchDepth")
                    GlitchDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseSquareMask")
                    UseSquareMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseScreenSpaceMask")
                    UseScreenSpaceMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactColor")
                    ArtifactColor = new Color(data.Variant as CColor);
                if (data.REDName == "ArtifactIntensity")
                    ArtifactIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactNarrowness")
                    ArtifactNarrowness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactMinimizer")
                    ArtifactMinimizer = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactSpeed")
                    ArtifactSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactTimeOffset")
                    ArtifactTimeOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallArtifactsTileX")
                    SmallArtifactsTileX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallArtifactsTileY")
                    SmallArtifactsTileY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseStencilMask")
                    UseStencilMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseSmallArtifacts")
                    UseSmallArtifacts = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseBothSideBlur")
                    UseBothSideBlur = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseHorizontal")
                    UseHorizontal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseAlphaOverEntireEffect")
                    UseAlphaOverEntireEffect = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ErrorIntensity")
                    ErrorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InvertBrightnessMask")
                    InvertBrightnessMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ErrorTex")
                    ErrorTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DotTex")
                    DotTex = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _screen_glitch_vision
    {
        public _screen_glitch_vision() { }
        public _screen_glitch_vision(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GridColor")
                    GridColor = new Color(data.Variant as CColor);
                if (data.REDName == "BlurredIntensity")
                    BlurredIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseSize")
                    NoiseSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeX1")
                    TileSizeX1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeY1")
                    TileSizeY1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeX2")
                    TileSizeX2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TileSizeY2")
                    TileSizeY2 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchSpeed")
                    GlitchSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchSpeedOffset")
                    GlitchSpeedOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchModTime")
                    GlitchModTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchDepth")
                    GlitchDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseSquareMask")
                    UseSquareMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseScreenSpaceMask")
                    UseScreenSpaceMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactColor")
                    ArtifactColor = new Color(data.Variant as CColor);
                if (data.REDName == "ArtifactIntensity")
                    ArtifactIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactNarrowness")
                    ArtifactNarrowness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactMinimizer")
                    ArtifactMinimizer = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactSpeed")
                    ArtifactSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ArtifactTimeOffset")
                    ArtifactTimeOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallArtifactsTileX")
                    SmallArtifactsTileX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallArtifactsTileY")
                    SmallArtifactsTileY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseStencilMask")
                    UseStencilMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseSmallArtifacts")
                    UseSmallArtifacts = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseBothSideBlur")
                    UseBothSideBlur = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseHorizontal")
                    UseHorizontal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseAlphaOverEntireEffect")
                    UseAlphaOverEntireEffect = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ErrorIntensity")
                    ErrorIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InvertBrightnessMask")
                    InvertBrightnessMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ErrorTex")
                    ErrorTex = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DotTex")
                    DotTex = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _signages
    {
        public _signages() { }
        public _signages(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "MainTexture")
                    MainTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseRoughnessTexture")
                    UseRoughnessTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTilingAndOffset")
                    RoughnessTilingAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UniformColor")
                    UniformColor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseVertexColorOrMap")
                    UseVertexColorOrMap = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorOneStart")
                    ColorOneStart = new Color(data.Variant as CColor);
                if (data.REDName == "ColorOneEnd")
                    ColorOneEnd = new Color(data.Variant as CColor);
                if (data.REDName == "ColorGradientScale")
                    ColorGradientScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HorizontalOrVerticalGradient")
                    HorizontalOrVerticalGradient = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientStartPosition")
                    GradientStartPosition = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorTwo")
                    ColorTwo = new Color(data.Variant as CColor);
                if (data.REDName == "ColorThree")
                    ColorThree = new Color(data.Variant as CColor);
                if (data.REDName == "ColorFour")
                    ColorFour = new Color(data.Variant as CColor);
                if (data.REDName == "ColorFive")
                    ColorFive = new Color(data.Variant as CColor);
                if (data.REDName == "ColorSix")
                    ColorSix = new Color(data.Variant as CColor);
                if (data.REDName == "NoiseTexture")
                    NoiseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LightupDensity")
                    LightupDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightupMinimumValue")
                    LightupMinimumValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightupHorizontalOrVertical")
                    LightupHorizontalOrVertical = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkingSpeed")
                    BlinkingSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkingMinimumValue")
                    BlinkingMinimumValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkingPhase")
                    BlinkingPhase = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkSmoothness")
                    BlinkSmoothness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelAmount")
                    FresnelAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _signages_transparent_no_txaa
    {
        public _signages_transparent_no_txaa() { }
        public _signages_transparent_no_txaa(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "MainTexture")
                    MainTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseRoughnessTexture")
                    UseRoughnessTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTilingAndOffset")
                    RoughnessTilingAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UniformColor")
                    UniformColor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseVertexColorOrMap")
                    UseVertexColorOrMap = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorOneStart")
                    ColorOneStart = new Color(data.Variant as CColor);
                if (data.REDName == "ColorOneEnd")
                    ColorOneEnd = new Color(data.Variant as CColor);
                if (data.REDName == "ColorGradientScale")
                    ColorGradientScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HorizontalOrVerticalGradient")
                    HorizontalOrVerticalGradient = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientStartPosition")
                    GradientStartPosition = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorTwo")
                    ColorTwo = new Color(data.Variant as CColor);
                if (data.REDName == "ColorThree")
                    ColorThree = new Color(data.Variant as CColor);
                if (data.REDName == "ColorFour")
                    ColorFour = new Color(data.Variant as CColor);
                if (data.REDName == "ColorFive")
                    ColorFive = new Color(data.Variant as CColor);
                if (data.REDName == "ColorSix")
                    ColorSix = new Color(data.Variant as CColor);
                if (data.REDName == "NoiseTexture")
                    NoiseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LightupDensity")
                    LightupDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightupMinimumValue")
                    LightupMinimumValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightupHorizontalOrVertical")
                    LightupHorizontalOrVertical = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkingSpeed")
                    BlinkingSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkingMinimumValue")
                    BlinkingMinimumValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkingPhase")
                    BlinkingPhase = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkSmoothness")
                    BlinkSmoothness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelAmount")
                    FresnelAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _silverhand_proxy
    {
        public _silverhand_proxy() { }
        public _silverhand_proxy(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Color")
                    Color = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BayerScale")
                    BayerScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BayerIntensity")
                    BayerIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelExponent")
                    FresnelExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _simple_additive_ui
    {
        public _simple_additive_ui() { }
        public _simple_additive_ui(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UIRenderTexture")
                    UIRenderTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UvTilingAndOffset")
                    UvTilingAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DirtTilingAndOffset")
                    DirtTilingAndOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexturePartUV")
                    TexturePartUV = new Vec4(data.Variant as Vector4);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "PremultiplyByAlpha")
                    PremultiplyByAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "Saturation")
                    Saturation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtTexture")
                    DirtTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DirtOpacity")
                    DirtOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtColorScale")
                    DirtColorScale = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _simple_emissive_decals
    {
        public _simple_emissive_decals() { }
        public _simple_emissive_decals(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMultiply")
                    ColorMultiply = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FrameNum")
                    FrameNum = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InvertSoftAlpha")
                    InvertSoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _simple_fresnel
    {
        public _simple_fresnel() { }
        public _simple_fresnel(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FresnelColor")
                    FresnelColor = new Color(data.Variant as CColor);
                if (data.REDName == "FresnelPower")
                    FresnelPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _simple_refraction
    {
        public _simple_refraction() { }
        public _simple_refraction(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionStrength")
                    RefractionStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Refraction")
                    Refraction = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseDepth")
                    UseDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionTextureOffset")
                    RefractionTextureOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "RefractionTextureSpeed")
                    RefractionTextureSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SlowFactor")
                    SlowFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionStrengthSlowTime")
                    RefractionStrengthSlowTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _sound_clue
    {
        public _sound_clue() { }
        public _sound_clue(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _television_ad
    {
        public _television_ad() { }
        public _television_ad(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "TilesWidth")
                    TilesWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TilesHeight")
                    TilesHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "PlaySpeed")
                    PlaySpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InterlaceLines")
                    InterlaceLines = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "PixelsHeight")
                    PixelsHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlackLinesRatio")
                    BlackLinesRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlackLinesIntensity")
                    BlackLinesIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdTexture")
                    AdTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BlackLinesSize")
                    BlackLinesSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LinesOrDots")
                    LinesOrDots = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistanceDivision")
                    DistanceDivision = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IsBroken")
                    IsBroken = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseFloatParameter")
                    UseFloatParameter = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseFloatParameter1")
                    UseFloatParameter1 = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtTexture")
                    DirtTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DirtOpacityScale")
                    DirtOpacityScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtRoughness")
                    DirtRoughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtUvScaleU")
                    DirtUvScaleU = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DirtUvScaleV")
                    DirtUvScaleV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HUEChangeSpeed")
                    HUEChangeSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _triplanar_projection
    {
        public _triplanar_projection() { }
        public _triplanar_projection(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FirstValue")
                    FirstValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SecondValue")
                    SecondValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThirdValue")
                    ThirdValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Stretch")
                    Stretch = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _water_test
    {
        public _water_test() { }
        public _water_test(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "TintColorDeep")
                    TintColorDeep = new Color(data.Variant as CColor);
                if (data.REDName == "TexCoordDtortScaleSpeed")
                    TexCoordDtortScaleSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ReflectionPower")
                    ReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ReflectNormalMultiplier")
                    ReflectNormalMultiplier = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Alpha")
                    Alpha = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _zoom
    {
        public _zoom() { }
        public _zoom(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Progress")
                    Progress = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OutlineColor")
                    OutlineColor = new Color(data.Variant as CColor);
                if (data.REDName == "OutlineThickness")
                    OutlineThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinRange")
                    MinRange = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxRange")
                    MaxRange = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MotionIntensity")
                    MotionIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TransitionOrLoop")
                    TransitionOrLoop = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IsBackwardEffect")
                    IsBackwardEffect = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseBrokenSobelPixels")
                    UseBrokenSobelPixels = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _alt_halo
    {
        public _alt_halo() { }
        public _alt_halo(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Offset")
                    Offset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Noise")
                    Noise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DistanceNoise")
                    DistanceNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DistanceNoiseScale")
                    DistanceNoiseScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Dot")
                    Dot = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DotsLift")
                    DotsLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistPower")
                    DistPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseScale")
                    NoiseScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseSpeed")
                    NoiseSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistanceNoiseAmount")
                    DistanceNoiseAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsMax")
                    DotsMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "WorldOrLocalSpace")
                    WorldOrLocalSpace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsScale")
                    DotsScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LocalSpaceRatio")
                    LocalSpaceRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeOutDistance")
                    FadeOutDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FadeOutDistanceMinimum")
                    FadeOutDistanceMinimum = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UVOrScreenSpace")
                    UVOrScreenSpace = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _blackbodyradiation_distant
    {
        public _blackbodyradiation_distant() { }
        public _blackbodyradiation_distant(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Temperature")
                    Temperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FireScatterAlpha")
                    FireScatterAlpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "subUVWidth")
                    subUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "subUVHeight")
                    subUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MultiplierExponent")
                    MultiplierExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoAlphaOnTexture")
                    NoAlphaOnTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaExponent")
                    AlphaExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "maxAlpha")
                    maxAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EatUpOrStraightAlpha")
                    EatUpOrStraightAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatterAmount")
                    ScatterAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatterPower")
                    ScatterPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HueShift")
                    HueShift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HueSpread")
                    HueSpread = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Saturation")
                    Saturation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ExpensiveBlending")
                    ExpensiveBlending = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightSmoke")
                    LightSmoke = new Color(data.Variant as CColor);
                if (data.REDName == "DarkSmoke")
                    DarkSmoke = new Color(data.Variant as CColor);
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Distort")
                    Distort = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TexCoordDtortScale")
                    TexCoordDtortScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordDtortSpeed")
                    TexCoordDtortSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRowAnimation")
                    EnableRowAnimation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DoNotApplyLighting")
                    DoNotApplyLighting = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "InvertMask")
                    InvertMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTilingAndSpeed")
                    MaskTilingAndSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskIntensity")
                    MaskIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseVertexAlpha")
                    UseVertexAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotWithLookAt")
                    DotWithLookAt = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _blackbodyradiation_notxaa
    {
        public _blackbodyradiation_notxaa() { }
        public _blackbodyradiation_notxaa(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Temperature")
                    Temperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FireScatterAlpha")
                    FireScatterAlpha = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "subUVWidth")
                    subUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "subUVHeight")
                    subUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MultiplierExponent")
                    MultiplierExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoAlphaOnTexture")
                    NoAlphaOnTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaExponent")
                    AlphaExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "maxAlpha")
                    maxAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EatUpOrStraightAlpha")
                    EatUpOrStraightAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatterAmount")
                    ScatterAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatterPower")
                    ScatterPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HueShift")
                    HueShift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HueSpread")
                    HueSpread = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Saturation")
                    Saturation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ExpensiveBlending")
                    ExpensiveBlending = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LightSmoke")
                    LightSmoke = new Color(data.Variant as CColor);
                if (data.REDName == "DarkSmoke")
                    DarkSmoke = new Color(data.Variant as CColor);
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Distort")
                    Distort = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TexCoordDtortScale")
                    TexCoordDtortScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordDtortSpeed")
                    TexCoordDtortSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRowAnimation")
                    EnableRowAnimation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DoNotApplyLighting")
                    DoNotApplyLighting = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "InvertMask")
                    InvertMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTilingAndSpeed")
                    MaskTilingAndSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskIntensity")
                    MaskIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseVertexAlpha")
                    UseVertexAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotWithLookAt")
                    DotWithLookAt = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _blood_metal_base
    {
        public _blood_metal_base() { }
        public _blood_metal_base(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "ColorThin")
                    ColorThin = new Color(data.Variant as CColor);
                if (data.REDName == "ColorThick")
                    ColorThick = new Color(data.Variant as CColor);
                if (data.REDName == "NormalAndDensity")
                    NormalAndDensity = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseTimeFlowmap")
                    UseTimeFlowmap = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlowMapSpeed")
                    FlowMapSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VelocityMap")
                    VelocityMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FlowmapStrength")
                    FlowmapStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseOnStaticMeshes")
                    UseOnStaticMeshes = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _caustics
    {
        public _caustics() { }
        public _caustics(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Distortion")
                    Distortion = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Contrast")
                    Contrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Speed")
                    Speed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallMovementSpeed")
                    SmallMovementSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Multiplier")
                    Multiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Spread")
                    Spread = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortionAmount")
                    DistortionAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortionUVScaling")
                    DistortionUVScaling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UVScaling")
                    UVScaling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EdgeWidth")
                    EdgeWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EdgeMultiplier")
                    EdgeMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxValue")
                    MaxValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _character_kerenzikov
    {
        public _character_kerenzikov() { }
        public _character_kerenzikov(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffset")
                    VertexOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "CenterPoint")
                    CenterPoint = new Vec4(data.Variant as Vector4);
                if (data.REDName == "PixelOffset")
                    PixelOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ComebackPixelOffset")
                    ComebackPixelOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseAmount")
                    NoiseAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Debug")
                    Debug = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _character_sandevistan
    {
        public _character_sandevistan() { }
        public _character_sandevistan(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Iterations")
                    Iterations = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetStrength")
                    OffsetStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InsideSoftAlpha")
                    InsideSoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TopDisplacePower")
                    TopDisplacePower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TopDisplaceIntensity")
                    TopDisplaceIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _crystal_dome
    {
        public _crystal_dome() { }
        public _crystal_dome(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineDensity")
                    ScanlineDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GainMin")
                    GainMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GainMax")
                    GainMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseMax")
                    NoiseMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseBrightness")
                    NoiseBrightness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "IntialGradientTime")
                    IntialGradientTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _crystal_dome_opaque
    {
        public _crystal_dome_opaque() { }
        public _crystal_dome_opaque(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "PrimaryGlowColor")
                    PrimaryGlowColor = new Color(data.Variant as CColor);
                if (data.REDName == "SecondaryGlowColor")
                    SecondaryGlowColor = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Tiling")
                    Tiling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "InitialTime")
                    InitialTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxTimeOffset")
                    MaxTimeOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SwipeAngle")
                    SwipeAngle = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FluffMask")
                    FluffMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "PatternMask")
                    PatternMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UVDivision")
                    UVDivision = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseMax")
                    NoiseMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugValue")
                    DebugValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Debug")
                    Debug = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UVDivision_FluffMask")
                    UVDivision_FluffMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinUV")
                    MinUV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxUV")
                    MaxUV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortionMap")
                    DistortionMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DistortionScale")
                    DistortionScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cyberspace_gradient
    {
        public _cyberspace_gradient() { }
        public _cyberspace_gradient(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InitialGradientTiling")
                    InitialGradientTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InitialGradientDivisions")
                    InitialGradientDivisions = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RectangleRatio")
                    RectangleRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientPalette")
                    GradientPalette = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SecondaryGradientPalette")
                    SecondaryGradientPalette = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Reveal")
                    Reveal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ReveakMaskContrast")
                    ReveakMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RevealBiasMin")
                    RevealBiasMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RevealBiasMax")
                    RevealBiasMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorBias")
                    ColorBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FloatOrParam")
                    FloatOrParam = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FloatOrAlpha")
                    FloatOrAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HSB")
                    HSB = new Vec4(data.Variant as Vector4);
                if (data.REDName == "BottomLinesAmount")
                    BottomLinesAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BottomLinesCuttoff")
                    BottomLinesCuttoff = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BottomLinesWidth")
                    BottomLinesWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TowardsCameraSpeed")
                    TowardsCameraSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _cyberspace_teleport_glitch
    {
        public _cyberspace_teleport_glitch() { }
        public _cyberspace_teleport_glitch(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DepthOffset")
                    DepthOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortionMap")
                    DistortionMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DistortionSize")
                    DistortionSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortionMultiplier")
                    DistortionMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ChangeChance")
                    ChangeChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LinesSize")
                    LinesSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LinesSpeed")
                    LinesSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LinesAmount")
                    LinesAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LinesDistortion")
                    LinesDistortion = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SampledDistortOFfset")
                    SampledDistortOFfset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SampledDistortSize")
                    SampledDistortSize = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_caustics
    {
        public _decal_caustics() { }
        public _decal_caustics(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Distortion")
                    Distortion = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Contrast")
                    Contrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Speed")
                    Speed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SmallMovementSpeed")
                    SmallMovementSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Spread")
                    Spread = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortionAmount")
                    DistortionAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortionUVScaling")
                    DistortionUVScaling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UVScaling")
                    UVScaling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EdgeWidth")
                    EdgeWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EdgeMultiplier")
                    EdgeMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxValue")
                    MaxValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientStartPosition")
                    GradientStartPosition = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientLength")
                    GradientLength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_glitch
    {
        public _decal_glitch() { }
        public _decal_glitch(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GradientMap")
                    GradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchScale")
                    GlitchScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchStrength")
                    GlitchStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffOn")
                    GlitchOffOn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissapearingChance")
                    DissapearingChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorChangeAmount")
                    ColorChangeAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_glitch_emissive
    {
        public _decal_glitch_emissive() { }
        public _decal_glitch_emissive(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GradientMap")
                    GradientMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchScale")
                    GlitchScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchStrength")
                    GlitchStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffOn")
                    GlitchOffOn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DissapearingChance")
                    DissapearingChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorChangeAmount")
                    ColorChangeAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _depth_based_sobel
    {
        public _depth_based_sobel() { }
        public _depth_based_sobel(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThinLinesThickness")
                    ThinLinesThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThinLinesDistance")
                    ThinLinesDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThickLinesThickness")
                    ThickLinesThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThickLinesDistance")
                    ThickLinesDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OutlineThickness")
                    OutlineThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LinesColor")
                    LinesColor = new Color(data.Variant as CColor);
                if (data.REDName == "Brightness")
                    Brightness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinDistance")
                    MinDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxDistance")
                    MaxDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskSizeX")
                    MaskSizeX = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskSizeY")
                    MaskSizeY = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SobelThreshold")
                    SobelThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SobelStep")
                    SobelStep = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SobelMinimumChange")
                    SobelMinimumChange = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _diode_pavements_ui
    {
        public _diode_pavements_ui() { }
        public _diode_pavements_ui(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiodesMask")
                    DiodesMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SignTexture")
                    SignTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiodesTilingAndScrollSpeed")
                    DiodesTilingAndScrollSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseMaskAsAlphaThreshold")
                    UseMaskAsAlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UIRenderTexture")
                    UIRenderTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TexturePartUV")
                    TexturePartUV = new Vec4(data.Variant as Vector4);
                if (data.REDName == "RenderTextureScale")
                    RenderTextureScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "VerticalFlipEnabled")
                    VerticalFlipEnabled = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AmountOfGlitch")
                    AmountOfGlitch = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchSpeed")
                    GlitchSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColorRoughnessTiling")
                    BaseColorRoughnessTiling = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _dirt_animated_masked
    {
        public _dirt_animated_masked() { }
        public _dirt_animated_masked(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Dirt")
                    Dirt = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DirtSecond")
                    DirtSecond = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DirtColor")
                    DirtColor = new Color(data.Variant as CColor);
                if (data.REDName == "Multiplier")
                    Multiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WidthScaling")
                    WidthScaling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HeightScaling")
                    HeightScaling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RedChannelOrAlpha")
                    RedChannelOrAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _e3_prototype_mask
    {
        public _e3_prototype_mask() { }
        public _e3_prototype_mask(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "HeatDistribution")
                    HeatDistribution = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Temperature")
                    Temperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TemperatureMinimum")
                    TemperatureMinimum = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HueShift")
                    HueShift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveExponent")
                    EmissiveExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientWidth")
                    GradientWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DebugValue")
                    DebugValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseFloatValue")
                    UseFloatValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _fake_flare
    {
        public _fake_flare() { }
        public _fake_flare(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "WidthScale")
                    WidthScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HeightScale")
                    HeightScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Promixity")
                    Promixity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Multiplier")
                    Multiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MultiplierPower")
                    MultiplierPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _fake_flare_simple
    {
        public _fake_flare_simple() { }
        public _fake_flare_simple(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DistanceSizeFactor")
                    DistanceSizeFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SizeScale")
                    SizeScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RadialOrTexture")
                    RadialOrTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Multiplier")
                    Multiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FalloffPower")
                    FalloffPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinimumDistanceVisibility")
                    MinimumDistanceVisibility = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistanceVisibilityFadeIn")
                    DistanceVisibilityFadeIn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaximumRangeMin")
                    MaximumRangeMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaximumRangeMax")
                    MaximumRangeMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkSpeed")
                    BlinkSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _flat_fog_masked
    {
        public _flat_fog_masked() { }
        public _flat_fog_masked(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionMask")
                    RefractionMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DebugValue")
                    DebugValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Fogginess")
                    Fogginess = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Crackness")
                    Crackness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FogOrRefraction")
                    FogOrRefraction = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CrackColor")
                    CrackColor = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _flat_fog_masked_notxaa
    {
        public _flat_fog_masked_notxaa() { }
        public _flat_fog_masked_notxaa(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionMask")
                    RefractionMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DebugValue")
                    DebugValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Fogginess")
                    Fogginess = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Crackness")
                    Crackness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FogOrRefraction")
                    FogOrRefraction = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "CrackColor")
                    CrackColor = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _highlight_blocker
    {
        public _highlight_blocker() { }
        public _highlight_blocker(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "MeshGrow")
                    MeshGrow = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _hologram_proxy
    {
        public _hologram_proxy() { }
        public _hologram_proxy(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelIntensity")
                    FresnelIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelGamma")
                    FresnelGamma = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Alpha")
                    Alpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DecayStart")
                    DecayStart = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Decay")
                    Decay = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _holo_mask
    {
        public _holo_mask() { }
        public _holo_mask(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VerticalDivisions")
                    VerticalDivisions = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchOffset")
                    GlitchOffset = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ChangeSpeed")
                    ChangeSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HorizontalDivisions")
                    HorizontalDivisions = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineDensity")
                    ScanlineDensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScanlineMinimum")
                    ScanlineMinimum = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinColor")
                    MinColor = new Color(data.Variant as CColor);
                if (data.REDName == "MaxColor")
                    MaxColor = new Color(data.Variant as CColor);
                if (data.REDName == "EyesColor")
                    EyesColor = new Color(data.Variant as CColor);
                if (data.REDName == "BrightnessBoost")
                    BrightnessBoost = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EyesBoost")
                    EyesBoost = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AmountOfHorizontalTear")
                    AmountOfHorizontalTear = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ULimit")
                    ULimit = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VLimit")
                    VLimit = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _invisible
    {
        public _invisible() { }
        public _invisible(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _lightning_plasma
    {
        public _lightning_plasma() { }
        public _lightning_plasma(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "UseTimeOrAnimationFrame")
                    UseTimeOrAnimationFrame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceAlongUV")
                    DisplaceAlongUV = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DisplaceAlongUVSpeed")
                    DisplaceAlongUVSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceAlongUVScale")
                    DisplaceAlongUVScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceAlongUVStrength")
                    DisplaceAlongUVStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceAlongUVStrengthPower")
                    DisplaceAlongUVStrengthPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceAlongUVAdjustWidth")
                    DisplaceAlongUVAdjustWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceSeed")
                    DisplaceSeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceSeedSPEED")
                    DisplaceSeedSPEED = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceSeedSPEEDProbability")
                    DisplaceSeedSPEEDProbability = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceAlongUVOffScale")
                    DisplaceAlongUVOffScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceAlongUVOffSpeed")
                    DisplaceAlongUVOffSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DisplaceAlongUVOffSTR")
                    DisplaceAlongUVOffSTR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldNoiseSTR")
                    WorldNoiseSTR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldNoiseSize")
                    WorldNoiseSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldNoiseSpeed")
                    WorldNoiseSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "WorldNoise_Up_extra")
                    WorldNoise_Up_extra = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SetWorldNoiseToLocal")
                    SetWorldNoiseToLocal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlipUVby90deg")
                    FlipUVby90deg = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TemperatureTexture")
                    TemperatureTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MeshAnimationOnOff")
                    MeshAnimationOnOff = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MeshPlaySpeed")
                    MeshPlaySpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TemperatureTextureScale")
                    TemperatureTextureScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TemperatureTextureSpeed")
                    TemperatureTextureSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Temperature")
                    Temperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TemperaturePow")
                    TemperaturePow = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TemperatureFlickerSpeed")
                    TemperatureFlickerSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TemperatureFlickerSTR")
                    TemperatureFlickerSTR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HueShift")
                    HueShift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HueSaturation")
                    HueSaturation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ContactPointRange")
                    ContactPointRange = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ContactPointSTR")
                    ContactPointSTR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Tint")
                    Tint = new Color(data.Variant as CColor);
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "maxAlpha")
                    maxAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortTexture")
                    DistortTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TexCoordDtortScale")
                    TexCoordDtortScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordDistortSpeed")
                    TexCoordDistortSpeed = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _light_gradients
    {
        public _light_gradients() { }
        public _light_gradients(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BottomColor")
                    BottomColor = new Color(data.Variant as CColor);
                if (data.REDName == "TopColor")
                    TopColor = new Color(data.Variant as CColor);
                if (data.REDName == "LerpGradient")
                    LerpGradient = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Multiplier")
                    Multiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinProximityAlpha")
                    MinProximityAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxProximityAlpha")
                    MaxProximityAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GroundPosition")
                    GroundPosition = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TopPosition")
                    TopPosition = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientDirection")
                    GradientDirection = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoundGradientPosition")
                    RoundGradientPosition = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoundGradientScale")
                    RoundGradientScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistanceToSurfaceModifier")
                    DistanceToSurfaceModifier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _low_health
    {
        public _low_health() { }
        public _low_health(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MainPattern")
                    MainPattern = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FluffText")
                    FluffText = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FluffPattern")
                    FluffPattern = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Rows")
                    Rows = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaximumSliding")
                    MaximumSliding = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaximumDistortion")
                    MaximumDistortion = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetChangeSpeed")
                    OffsetChangeSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "OffsetAmount")
                    OffsetAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "PatternTiling")
                    PatternTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "PatternVisibility")
                    PatternVisibility = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FluffVisibility")
                    FluffVisibility = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FluffTiling")
                    FluffTiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VignetteColor")
                    VignetteColor = new Color(data.Variant as CColor);
                if (data.REDName == "FluffTextColor")
                    FluffTextColor = new Color(data.Variant as CColor);
                if (data.REDName == "VignetteMin")
                    VignetteMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Multiplier")
                    Multiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VignetteMax")
                    VignetteMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VignetteLength")
                    VignetteLength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VignetteSteps")
                    VignetteSteps = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VignetteContrast")
                    VignetteContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FinalContrast")
                    FinalContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LinesMultiplier")
                    LinesMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _mesh_decal__blackbody
    {
        public _mesh_decal__blackbody() { }
        public _mesh_decal__blackbody(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VertexOffsetFactor")
                    VertexOffsetFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "HeatDistribution")
                    HeatDistribution = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "HeatTiling")
                    HeatTiling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Temperature")
                    Temperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskMinimum")
                    MaskMinimum = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HSV_Mod")
                    HSV_Mod = new Vec4(data.Variant as Vector4);
                if (data.REDName == "UseFloatParam")
                    UseFloatParam = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveAlphaContrast")
                    EmissiveAlphaContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _metal_base_scrolling
    {
        public _metal_base_scrolling() { }
        public _metal_base_scrolling(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Bright")
                    Bright = new Color(data.Variant as CColor);
                if (data.REDName == "Dark")
                    Dark = new Color(data.Variant as CColor);
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskTilingAndScrolling")
                    MaskTilingAndScrolling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _multilayer_blackbody_inject
    {
        public _multilayer_blackbody_inject() { }
        public _multilayer_blackbody_inject(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Temperature")
                    Temperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaximumTemperature")
                    MaximumTemperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorExponent")
                    ColorExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Debug")
                    Debug = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FireHSV")
                    FireHSV = new Vec4(data.Variant as Vector4);
                if (data.REDName == "PoisonHSV")
                    PoisonHSV = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ElectricHSV")
                    ElectricHSV = new Vec4(data.Variant as Vector4);
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DamageTypeRGBMask")
                    DamageTypeRGBMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DamageTypeNoise")
                    DamageTypeNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DamageTypeNoiseIntesityAdd")
                    DamageTypeNoiseIntesityAdd = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DamageTypeNoiseUV")
                    DamageTypeNoiseUV = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "MultilayerSetup")
                    MultilayerSetup = (data.Variant as rRef<Multilayer_Setup>).DepotPath;
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "SetupLayerMask")
                    SetupLayerMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _nanowire_string
    {
        public _nanowire_string() { }
        public _nanowire_string(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Thickness")
                    Thickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseAmount")
                    NoiseAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseScale")
                    NoiseScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxVelocity")
                    MaxVelocity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxVelocityExponent")
                    MaxVelocityExponent = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "StartGradient")
                    StartGradient = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GradientWidth")
                    GradientWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxDistance")
                    MaxDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MainColor")
                    MainColor = new Color(data.Variant as CColor);
                if (data.REDName == "NormalMap")
                    NormalMap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MaskTexture")
                    MaskTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalTiling")
                    NormalTiling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Temperature")
                    Temperature = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinimumEmissive")
                    MinimumEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveMaskPower")
                    EmissiveMaskPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TurnOffBrightness")
                    TurnOffBrightness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkSpeed")
                    BlinkSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkWidth")
                    BlinkWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkMultiplier")
                    BlinkMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BlinkOffMultiplier")
                    BlinkOffMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "HSVMod")
                    HSVMod = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _oda_helm
    {
        public _oda_helm() { }
        public _oda_helm(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Hologram")
                    Hologram = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalRoughnessMetalness")
                    NormalRoughnessMetalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ScanlineTexture")
                    ScanlineTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVGlitched")
                    EmissiveEVGlitched = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotPower")
                    DotPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SecondaryDotPower")
                    SecondaryDotPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayersSeparation")
                    LayersSeparation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayersIntensity")
                    LayersIntensity = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScanlineTilingAndSpeed")
                    ScanlineTilingAndSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ScanlinesIntensity")
                    ScanlinesIntensity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseScale")
                    NoiseScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "PrimaryColor")
                    PrimaryColor = new Color(data.Variant as CColor);
                if (data.REDName == "SecondaryColor")
                    SecondaryColor = new Color(data.Variant as CColor);
                if (data.REDName == "BackgroundColor")
                    BackgroundColor = new Color(data.Variant as CColor);
                if (data.REDName == "NoiseColor")
                    NoiseColor = new Color(data.Variant as CColor);
                if (data.REDName == "NormalOrBroken")
                    NormalOrBroken = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _rift_noise
    {
        public _rift_noise() { }
        public _rift_noise(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "EmissiveEVMin")
                    EmissiveEVMin = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVMax")
                    EmissiveEVMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "EmissiveMask")
                    EmissiveMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Dot")
                    Dot = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Noise")
                    Noise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NoiseSpeed")
                    NoiseSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseScale")
                    NoiseScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NoiseScaleXY")
                    NoiseScaleXY = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DistanceNoise")
                    DistanceNoise = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DistanceNoiseScale")
                    DistanceNoiseScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistanceNoiseScaleXY")
                    DistanceNoiseScaleXY = new Vec4(data.Variant as Vector4);
                if (data.REDName == "DistanceNoiseAmount")
                    DistanceNoiseAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistPower")
                    DistPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsLift")
                    DotsLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DotsMax")
                    DotsMax = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistanceNoiseSpeed")
                    DistanceNoiseSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaxDistance")
                    MaxDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _screen_wave
    {
        public _screen_wave() { }
        public _screen_wave(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _simple_fog
    {
        public _simple_fog() { }
        public _simple_fog(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Brightness")
                    Brightness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinimumVisibilityDistance")
                    MinimumVisibilityDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "VisibilityFadeIn")
                    VisibilityFadeIn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TextureFalloff")
                    TextureFalloff = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MinimumBottonDistance")
                    MinimumBottonDistance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BottomVisibilityFadeIn")
                    BottomVisibilityFadeIn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DepthDivision")
                    DepthDivision = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DepthContrast")
                    DepthContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SteepAngleBlend")
                    SteepAngleBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SteepAngleBlendLength")
                    SteepAngleBlendLength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _simple_refraction_mask
    {
        public _simple_refraction_mask() { }
        public _simple_refraction_mask(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionStrength")
                    RefractionStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionTextureOffset")
                    RefractionTextureOffset = new Vec4(data.Variant as Vector4);
                if (data.REDName == "RefractionTextureSpeed")
                    RefractionTextureSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "RefractionTextureScale")
                    RefractionTextureScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Refraction")
                    Refraction = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseAlphaMask")
                    UseAlphaMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaMask")
                    AlphaMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseDepth")
                    UseDepth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SlowFactor")
                    SlowFactor = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RefractionStrengthSlowTime")
                    RefractionStrengthSlowTime = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskGradientPower")
                    MaskGradientPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "SoftAlpha")
                    SoftAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _transparent_flowmap
    {
        public _transparent_flowmap() { }
        public _transparent_flowmap(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Flowmap")
                    Flowmap = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FlowMapStrength")
                    FlowMapStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FlowSpeed")
                    FlowSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "Multiplier")
                    Multiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Power")
                    Power = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _transparent_liquid_notxaa
    {
        public _transparent_liquid_notxaa() { }
        public _transparent_liquid_notxaa(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceMetalness")
                    SurfaceMetalness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ScatteringColorThin")
                    ScatteringColorThin = new Color(data.Variant as CColor);
                if (data.REDName == "ScatteringColorThick")
                    ScatteringColorThick = new Color(data.Variant as CColor);
                if (data.REDName == "Albedo")
                    Albedo = new Color(data.Variant as CColor);
                if (data.REDName == "IOR")
                    IOR = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "FresnelBias")
                    FresnelBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SpecularStrengthMultiplier")
                    SpecularStrengthMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskOpacity")
                    MaskOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ThicknessMultiplier")
                    ThicknessMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "InterpolateFrames")
                    InterpolateFrames = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTilingAndScrolling")
                    NormalTilingAndScrolling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Distort")
                    Distort = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortTilingAndScrolling")
                    DistortTilingAndScrolling = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EnableRowAnimation")
                    EnableRowAnimation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseOnStaticMeshes")
                    UseOnStaticMeshes = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _world_to_screen_glitch
    {
        public _world_to_screen_glitch() { }
        public _world_to_screen_glitch(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "OffsetAmount")
                    OffsetAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Spread")
                    Spread = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortionAmount")
                    DistortionAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Divisions")
                    Divisions = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchChance")
                    GlitchChance = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlitchSpeed")
                    GlitchSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "GlowMultipier")
                    GlowMultipier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortGlitchDivisions")
                    DistortGlitchDivisions = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortGlitchSpeed")
                    DistortGlitchSpeed = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MidMaskWidth")
                    MidMaskWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _hit_proxy
    {
        public _hit_proxy() { }
        public _hit_proxy(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _lod_coloring
    {
        public _lod_coloring() { }
        public _lod_coloring(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _overdraw
    {
        public _overdraw() { }
        public _overdraw(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _overdraw_seethrough
    {
        public _overdraw_seethrough() { }
        public _overdraw_seethrough(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _selection
    {
        public _selection() { }
        public _selection(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _uv_density
    {
        public _uv_density() { }
        public _uv_density(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _wireframe
    {
        public _wireframe() { }
        public _wireframe(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _editor_mlmask_preview
    {
        public _editor_mlmask_preview() { }
        public _editor_mlmask_preview(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "MultilayerMask")
                    MultilayerMask = (data.Variant as rRef<Multilayer_Mask>).DepotPath;
                if (data.REDName == "MaskAtlas")
                    MaskAtlas = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "LayersStartIndex")
                    LayersStartIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SurfaceTexAspectRatio")
                    SurfaceTexAspectRatio = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskToTileScale")
                    MaskToTileScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskTileSize")
                    MaskTileSize = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MaskAtlasDims")
                    MaskAtlasDims = new Vec4(data.Variant as Vector4);
                if (data.REDName == "MaskBaseResolution")
                    MaskBaseResolution = new Vec4(data.Variant as Vector4);
                if (data.REDName == "EditorMaskLayerIndex")
                    EditorMaskLayerIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EditorVisualizationModeIndex")
                    EditorVisualizationModeIndex = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EditorShowValue")
                    EditorShowValue = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EditorCursorPosition")
                    EditorCursorPosition = new Vec4(data.Variant as Vector4);
            }
        }
    }
    public partial class _editor_mltemplate_preview
    {
        public _editor_mltemplate_preview() { }
        public _editor_mltemplate_preview(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "ColorScale")
                    ColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "NormalScale")
                    NormalScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessTexture")
                    RoughnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScaleIn")
                    MetalnessScaleIn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBiasIn")
                    MetalnessBiasIn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessScaleIn")
                    RoughnessScaleIn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBiasIn")
                    RoughnessBiasIn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessScaleOut")
                    MetalnessScaleOut = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBiasOut")
                    MetalnessBiasOut = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessScaleOut")
                    RoughnessScaleOut = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBiasOut")
                    RoughnessBiasOut = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMaskScaleIn")
                    ColorMaskScaleIn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMaskBiasIn")
                    ColorMaskBiasIn = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMaskScaleOut")
                    ColorMaskScaleOut = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorMaskBiasOut")
                    ColorMaskBiasOut = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessTexture")
                    MetalnessTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Tiling")
                    Tiling = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _gi_backface_debug
    {
        public _gi_backface_debug() { }
        public _gi_backface_debug(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _multilayered_baked
    {
        public _multilayered_baked() { }
        public _multilayered_baked(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "SurfaceID")
                    SurfaceID = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Indirection")
                    Indirection = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorRough")
                    BaseColorRough = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalMetal")
                    NormalMetal = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _mikoshi_fullscr_transition
    {
        public _mikoshi_fullscr_transition() { }
        public _mikoshi_fullscr_transition(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
            }
        }
    }
    public partial class _decal
    {
        public _decal() { }
        public _decal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _decal_normal
    {
        public _decal_normal() { }
        public _decal_normal(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "DiffuseTexture")
                    DiffuseTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseTextureAsMaskTexture")
                    DiffuseTextureAsMaskTexture = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalTexture")
                    NormalTexture = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "DiffuseColor")
                    DiffuseColor = new Color(data.Variant as CColor);
                if (data.REDName == "AlphaMaskContrast")
                    AlphaMaskContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessMetalnessAlpha")
                    RoughnessMetalnessAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVx")
                    SubUVx = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVy")
                    SubUVy = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Frame")
                    Frame = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _pbr_layer
    {
        public _pbr_layer() { }
        public _pbr_layer(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Mask")
                    Mask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "GlobalNormal")
                    GlobalNormal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MicroBlends")
                    MicroBlends = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughMetalBlend")
                    RoughMetalBlend = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "TintColor")
                    TintColor = new Color(data.Variant as CColor);
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MicroblendTile")
                    MicroblendTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MicroblendContrast")
                    MicroblendContrast = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MicroblendNormalStrength")
                    MicroblendNormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerOpacity")
                    LayerOpacity = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerOffsetU")
                    LayerOffsetU = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "LayerOffsetV")
                    LayerOffsetV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "is_df")
                    is_df = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _debugdraw
    {
        public _debugdraw() { }
        public _debugdraw(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _fallback
    {
        public _fallback() { }
        public _fallback(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
            }
        }
    }
    public partial class _metal_base
    {
        public _metal_base() { }
        public _metal_base(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "VehicleDamageInfluence")
                    VehicleDamageInfluence = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "NormalStrength")
                    NormalStrength = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaThreshold")
                    AlphaThreshold = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Emissive")
                    Emissive = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "EmissiveLift")
                    EmissiveLift = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEV")
                    EmissiveEV = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveEVRaytracingBias")
                    EmissiveEVRaytracingBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveDirectionality")
                    EmissiveDirectionality = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EnableRaytracedEmissive")
                    EnableRaytracedEmissive = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EmissiveColor")
                    EmissiveColor = new Color(data.Variant as CColor);
                if (data.REDName == "LayerTile")
                    LayerTile = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _mirror
    {
        public _mirror() { }
        public _mirror(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "BaseColor")
                    BaseColor = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BorderMask")
                    BorderMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "BaseColorScale")
                    BaseColorScale = new Color(data.Variant as CColor);
                if (data.REDName == "Metalness")
                    Metalness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "MetalnessScale")
                    MetalnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MetalnessBias")
                    MetalnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Roughness")
                    Roughness = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "RoughnessScale")
                    RoughnessScale = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "RoughnessBias")
                    RoughnessBias = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Translucency")
                    Translucency = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BorderThickness")
                    BorderThickness = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "BorderColor")
                    BorderColor = new Color(data.Variant as CColor);
            }
        }
    }
    public partial class _particles_generic
    {
        public _particles_generic() { }
        public _particles_generic(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Color")
                    Color = new Color(data.Variant as CColor);
                if (data.REDName == "ColorMultiplier")
                    ColorMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Desaturate")
                    Desaturate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ColorPower")
                    ColorPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TexCoordScale")
                    TexCoordScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordSpeed")
                    TexCoordSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordDtortScale")
                    TexCoordDtortScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordDistortSpeed")
                    TexCoordDistortSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AlphaGlobal")
                    AlphaGlobal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaSoft")
                    AlphaSoft = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaFresnelPower")
                    AlphaFresnelPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseAlphaFresnel")
                    UseAlphaFresnel = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseAlphaMask")
                    UseAlphaMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseOneChannel")
                    UseOneChannel = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Diffuse")
                    Diffuse = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaMask")
                    AlphaMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "FlipUVby90deg")
                    FlipUVby90deg = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "EVCompensation")
                    EVCompensation = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Distortion")
                    Distortion = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "UseContrastAlpha")
                    UseContrastAlpha = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SoftUVInterpolate")
                    SoftUVInterpolate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
            }
        }
    }
    public partial class _particles_liquid
    {
        public _particles_liquid() { }
        public _particles_liquid(CMaterialInstance cMaterialInstance)
        {
            for (int i = 0; i < cMaterialInstance.CMaterialInstanceData.Count; i++)
            {
                var data = cMaterialInstance.CMaterialInstanceData[i];
                if (data.REDName == "AdditiveAlphaBlend")
                    AdditiveAlphaBlend = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVWidth")
                    SubUVWidth = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "SubUVHeight")
                    SubUVHeight = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Desaturate")
                    Desaturate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "DistortAmount")
                    DistortAmount = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "TexCoordScale")
                    TexCoordScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordSpeed")
                    TexCoordSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordDtortScale")
                    TexCoordDtortScale = new Vec4(data.Variant as Vector4);
                if (data.REDName == "TexCoordDistortSpeed")
                    TexCoordDistortSpeed = new Vec4(data.Variant as Vector4);
                if (data.REDName == "AlphaGlobal")
                    AlphaGlobal = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaSoft")
                    AlphaSoft = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "AlphaFresnelPower")
                    AlphaFresnelPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseAlphaFresnel")
                    UseAlphaFresnel = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "UseAlphaMask")
                    UseAlphaMask = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "NormalMultiplier")
                    NormalMultiplier = new Vec4(data.Variant as Vector4);
                if (data.REDName == "ReflectionMultiplier")
                    ReflectionMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ReflectionPower")
                    ReflectionPower = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ReflectionColor")
                    ReflectionColor = new Color(data.Variant as CColor);
                if (data.REDName == "RefractionMultiplier")
                    RefractionMultiplier = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "Normal")
                    Normal = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "AlphaMask")
                    AlphaMask = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Distortion")
                    Distortion = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "Reflection")
                    Reflection = (data.Variant as rRef<ITexture>).DepotPath;
                if (data.REDName == "SoftUVInterpolate")
                    SoftUVInterpolate = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "ReflectionEdge")
                    ReflectionEdge = (data.Variant as CFloat).IsSerialized ? (data.Variant as CFloat).Value : null;
                if (data.REDName == "MainColor")
                    MainColor = new Color(data.Variant as CColor);
            }
        }
    }
}