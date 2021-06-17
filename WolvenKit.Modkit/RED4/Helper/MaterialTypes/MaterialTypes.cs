using WolvenKit.RED4.CR2W.Types;
using System;

namespace WolvenKit.Modkit.RED4.Materials.Types
{
    public partial class _3d_map
    {
        public Color Color { get; set; }    //Color
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> Lighting { get; set; }    //Float
        public Nullable<float> ParticleSize { get; set; }    //Float
        public Nullable<float> WorldScale { get; set; }    //Float
        public string WorldColorTex { get; set; }    //rRef:ITexture
        public string WorldPosTex { get; set; }    //rRef:ITexture
        public string WorldNormalTex { get; set; }    //rRef:ITexture
        public string WorldDepthTex { get; set; }    //rRef:ITexture
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
    }
    public partial class _3d_map_cubes
    {
        public Nullable<float> PointCloudTextureHeight { get; set; }    //Float
        public Vec4 TransMin { get; set; }    //Vector4
        public Vec4 TransMax { get; set; }    //Vector4
        public string WorldPosTex { get; set; }    //rRef:ITexture
        public Nullable<float> CubeSize { get; set; }    //Float
        public Nullable<float> ColorGradient { get; set; }    //Float
        public Vec4 DebugScaleOffset { get; set; }    //Vector4
        public Nullable<float> DissolveDistance { get; set; }    //Float
        public Nullable<float> DissolveBandWidth { get; set; }    //Float
        public Nullable<float> DissolveCellSize { get; set; }    //Float
        public Color DissolveBurnColor { get; set; }    //Color
        public Nullable<float> DissolveBurnStrength { get; set; }    //Float
        public Nullable<float> DissolveBurnMinCameraSpeed { get; set; }    //Float
        public Vec4 MapEdgeDissolveCenter { get; set; }    //Vector4
        public Nullable<float> MapEdgeDissolveRadiusStart { get; set; }    //Float
        public Nullable<float> MapEdgeDissolveRadiusBand { get; set; }    //Float
        public Nullable<float> MapEdgeDissolveCellSize { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public Color EdgeColor { get; set; }    //Color
        public Nullable<float> EdgeThickness { get; set; }    //Float
        public Nullable<float> EdgeSharpnessPower { get; set; }    //Float
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _3d_map_solid
    {
        public Nullable<float> RenderOnTop { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color Color { get; set; }    //Color
    }
    public partial class _beyondblackwall
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string DiffuseMap { get; set; }    //rRef:ITexture
        public string HeightMap { get; set; }    //rRef:ITexture
        public Nullable<float> Height { get; set; }    //Float
        public Nullable<float> Intensity { get; set; }    //Float
        public Nullable<float> AnimBlend { get; set; }    //Float
        public Nullable<float> SmallDistortionStrenght { get; set; }    //Float
        public Nullable<float> BigDistortionStrenght { get; set; }    //Float
        public Nullable<float> SmallDistortionTime { get; set; }    //Float
        public Nullable<float> BigDistortionTime { get; set; }    //Float
        public Nullable<float> VignetteIntensity { get; set; }    //Float
        public Nullable<float> LuminancePower { get; set; }    //Float
        public Nullable<float> CompareValue { get; set; }    //Float
        public Nullable<float> PixelStretchBlend { get; set; }    //Float
    }
    public partial class _beyondblackwall_chars
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Nullable<float> TextureColorBlend { get; set; }    //Float
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> AtlasSize { get; set; }    //Float
        public Nullable<float> AtlasID { get; set; }    //Float
        public Nullable<float> SmallDistortionStrenght { get; set; }    //Float
        public Nullable<float> BigDistortionStrenght { get; set; }    //Float
        public Nullable<float> SmallDistortionTime { get; set; }    //Float
        public Nullable<float> BigDistortionTime { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _beyondblackwall_sky
    {
        public string SkyDiffuse { get; set; }    //rRef:ITexture
        public string SkySorted { get; set; }    //rRef:ITexture
        public string SkySortMask { get; set; }    //rRef:ITexture
        public string NoiseMap { get; set; }    //rRef:ITexture
        public string SilhouetteDiffuse { get; set; }    //rRef:ITexture
        public string SilhouetteMask { get; set; }    //rRef:ITexture
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> LightDirectionHorizontal { get; set; }    //Float
        public Nullable<float> LightDirectionVertical { get; set; }    //Float
        public Nullable<float> Wrap { get; set; }    //Float
        public Nullable<float> WrapIntensity { get; set; }    //Float
        public Vec4 FlashIntensity { get; set; }    //Vector4
        public Vec4 FlashTimeScale { get; set; }    //Vector4
        public Color LightColor { get; set; }    //Color
        public Nullable<float> SkyAmbient { get; set; }    //Float
        public Vec4 SkyParameter { get; set; }    //Vector4
        public Vec4 SilhouetteUV { get; set; }    //Vector4
        public Nullable<float> CompareValue { get; set; }    //Float
    }
    public partial class _beyondblackwall_sky_raymarch
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string NoiseTexture3D { get; set; }    //rRef:ITexture
        public string VolumeNoise { get; set; }    //rRef:ITexture
        public string ScreenNoise { get; set; }    //rRef:ITexture
        public Color LightColor { get; set; }    //Color
        public Nullable<float> LightIntensity { get; set; }    //Float
        public Nullable<float> LightVectorXY { get; set; }    //Float
        public Nullable<float> LightVectorZ { get; set; }    //Float
        public Color SkyColor { get; set; }    //Color
        public Nullable<float> VectorNoiseSize { get; set; }    //Float
        public Nullable<float> VectorNoiseIntensity { get; set; }    //Float
        public Color AmbientLightTop { get; set; }    //Color
        public Color AmbientLightBottom { get; set; }    //Color
        public Nullable<float> CoverageShift { get; set; }    //Float
        public Nullable<float> JitterIntensity { get; set; }    //Float
        public Nullable<float> EmisssivIntensity { get; set; }    //Float
        public Nullable<float> CloudScaleXY { get; set; }    //Float
        public Nullable<float> CloudScaleZ { get; set; }    //Float
        public Nullable<float> CloudPositionZ { get; set; }    //Float
        public Vec4 NoiseOffset { get; set; }    //Vector4
        public Vec4 FlashAreaOffset { get; set; }    //Vector4
        public Nullable<float> SphereOffsetZ { get; set; }    //Float
        public Nullable<float> SphereSize { get; set; }    //Float
        public Vec4 SphereOffsetVec { get; set; }    //Vector4
        public Nullable<float> NoiseSize { get; set; }    //Float
        public Nullable<float> CloudDensity { get; set; }    //Float
        public Nullable<float> DetailNoiseSize { get; set; }    //Float
        public Vec4 DetailNoiseOffset { get; set; }    //Vector4
        public Vec4 ScreenNoiseVec { get; set; }    //Vector4
        public Vec4 Samples { get; set; }    //Vector4
        public Vec4 SkyBlend { get; set; }    //Vector4
        public Vec4 Scatter { get; set; }    //Vector4
        public Vec4 SilverLightCone { get; set; }    //Vector4
    }
    public partial class _blood_puddle_decal
    {
        public string NoiseTexture { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> Squash { get; set; }    //Float
        public Nullable<float> Curls { get; set; }    //Float
        public Nullable<float> Details { get; set; }    //Float
        public Nullable<float> Thickness { get; set; }    //Float
        public Nullable<float> ProgressiveOpacity { get; set; }    //Float
    }
    public partial class _cable
    {
        public Nullable<float> VehicleDamageInfluence { get; set; }    //Float
        public Nullable<float> ThicknessStart { get; set; }    //Float
        public Nullable<float> ThicknessEnd { get; set; }    //Float
        public Nullable<float> RangeStart { get; set; }    //Float
        public Nullable<float> RangeEnd { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveLift { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _circuit_wires
    {
        public Nullable<float> PointCloudTextureRes { get; set; }    //Float
        public Nullable<float> TransMin { get; set; }    //Float
        public Nullable<float> TransMax { get; set; }    //Float
        public string WorldPosTex { get; set; }    //rRef:ITexture
        public Nullable<float> WireThickness { get; set; }    //Float
        public Vec4 InstanceOffset { get; set; }    //Vector4
        public Vec4 LocalNormal { get; set; }    //Vector4
        public Nullable<float> BevelStrenght { get; set; }    //Float
        public Nullable<float> DebugVC { get; set; }    //Float
        public Nullable<float> DebugID { get; set; }    //Float
        public Color BaseColor { get; set; }    //Color
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> Roughness { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _cloth_mov
    {
        public string vertex_paint_tex { get; set; }    //rRef:ITexture
        public Nullable<float> trans_min { get; set; }    //Float
        public Nullable<float> trans_max { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> n_pieces { get; set; }    //Float
        public Nullable<float> play_time { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _cloth_mov_multilayered
    {
        public string vertex_paint_tex { get; set; }    //rRef:ITexture
        public Nullable<float> trans_min { get; set; }    //Float
        public Nullable<float> trans_max { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> n_pieces { get; set; }    //Float
        public Nullable<float> play_time { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; }     //rRef:Multilayer_Setup
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public Nullable<float> SetupLayerMask { get; set; }    //Float
    }
    public partial class _cyberparticles_base
    {
        public Vec4 trans_extent { get; set; }    //Vector4
        public Nullable<float> Contrast { get; set; }    //Float
        public Nullable<float> AddSizeX { get; set; }    //Float
        public Nullable<float> AddSizeY { get; set; }    //Float
        public Nullable<float> Width { get; set; }    //Float
        public Nullable<float> Height { get; set; }    //Float
        public string WorldColorTex { get; set; }    //rRef:ITexture
        public string WorldPosTex { get; set; }    //rRef:ITexture
        public Nullable<float> WorldSize { get; set; }    //Float
        public Nullable<float> ParticleSize { get; set; }    //Float
        public Nullable<float> DissolveTime { get; set; }    //Float
        public Nullable<float> DissolveGlobalTime { get; set; }    //Float
        public Nullable<float> DissolveDeltaScale { get; set; }    //Float
        public Nullable<float> DissolveNoiseScale { get; set; }    //Float
        public Nullable<float> DissolveParticleSize { get; set; }    //Float
        public Nullable<float> WarpTime { get; set; }    //Float
        public Vec4 WarpLocation { get; set; }    //Vector4
        public Nullable<float> StretchMul { get; set; }    //Float
        public Nullable<float> StretchMax { get; set; }    //Float
        public Nullable<float> UnRevealTime { get; set; }    //Float
        public Nullable<float> Displace01 { get; set; }    //Float
        public Nullable<float> Displace02 { get; set; }    //Float
        public Nullable<float> GlobalNoiseScale { get; set; }    //Float
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public Color Tint { get; set; }    //Color
        public string Mask { get; set; }    //rRef:ITexture
    }
    public partial class _cyberparticles_blackwall
    {
        public string VideoRT { get; set; }    //rRef:ITexture
        public string GradientTex { get; set; }    //rRef:ITexture
        public string DisturbTex { get; set; }    //rRef:ITexture
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> UsesInstancing { get; set; }    //Float
        public Nullable<float> DisturbRadius { get; set; }    //Float
        public Nullable<float> DisturbCurveFrequency { get; set; }    //Float
        public Nullable<float> DisturbMul { get; set; }    //Float
        public Nullable<float> DisturbTime { get; set; }    //Float
        public Nullable<float> DisturbNoiseScale { get; set; }    //Float
        public Nullable<float> DisturbScale { get; set; }    //Float
        public Nullable<float> DisturbBrighten { get; set; }    //Float
        public Vec4 DisturbLocation1 { get; set; }    //Vector4
        public Vec4 DisturbLocation2 { get; set; }    //Vector4
        public Nullable<float> TimeFactor { get; set; }    //Float
        public Vec4 Scale { get; set; }    //Vector4
        public Vec4 Dimensions { get; set; }    //Vector4
        public Vec4 TexTiling { get; set; }    //Vector4
        public Nullable<float> Contrast { get; set; }    //Float
        public Nullable<float> AddSizeX { get; set; }    //Float
        public Nullable<float> AddSizeY { get; set; }    //Float
        public Nullable<float> ParticleSize { get; set; }    //Float
        public Nullable<float> WarpTime { get; set; }    //Float
        public Vec4 WarpLocation { get; set; }    //Vector4
        public Nullable<float> StretchMul { get; set; }    //Float
        public Nullable<float> StretchMax { get; set; }    //Float
        public Nullable<float> CNoiseAdjust { get; set; }    //Float
        public Nullable<float> Align { get; set; }    //Float
        public Vec4 HighFreqFade { get; set; }    //Vector4
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color Tint { get; set; }    //Color
    }
    public partial class _cyberparticles_blackwall_touch
    {
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> RippleSize { get; set; }    //Float
        public Nullable<float> RippleSpeed { get; set; }    //Float
        public Nullable<float> RippleNumber { get; set; }    //Float
        public Nullable<float> RippleHeight { get; set; }    //Float
        public Vec4 RipplePosition { get; set; }    //Vector4
        public Vec4 RippleDirection { get; set; }    //Vector4
        public Nullable<float> TimeFactor { get; set; }    //Float
        public Vec4 Scale { get; set; }    //Vector4
        public Vec4 Dimensions { get; set; }    //Vector4
        public Vec4 TexTiling { get; set; }    //Vector4
        public Nullable<float> Contrast { get; set; }    //Float
        public Nullable<float> AddSizeX { get; set; }    //Float
        public Nullable<float> AddSizeY { get; set; }    //Float
        public Nullable<float> ParticleSize { get; set; }    //Float
        public Nullable<float> WarpTime { get; set; }    //Float
        public Vec4 WarpLocation { get; set; }    //Vector4
        public Nullable<float> StretchMul { get; set; }    //Float
        public Nullable<float> StretchMax { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color Tint { get; set; }    //Color
        public Color TintPulse { get; set; }    //Color
    }
    public partial class _cyberparticles_braindance
    {
        public Nullable<float> DebugAlwaysShow { get; set; }    //Float
        public Nullable<float> DebugDisplayUV { get; set; }    //Float
        public Nullable<float> NumQuadsX { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> ParticleSize { get; set; }    //Float
        public string WorldPosTex { get; set; }    //rRef:ITexture
        public string RevealMask { get; set; }    //rRef:ITexture
        public Nullable<float> RevealMaskFramesY { get; set; }    //Float
        public Vec4 RevealMaskBoundsMin { get; set; }    //Vector4
        public Vec4 RevealMaskBoundsMax { get; set; }    //Vector4
        public string FlowMap0 { get; set; }    //rRef:ITexture
        public string CluesMap { get; set; }    //rRef:ITexture
        public Nullable<float> CharacterBlobRadius { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string MaskParticle { get; set; }    //rRef:ITexture
    }
    public partial class _cyberparticles_dynamic
    {
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> ParticleSize { get; set; }    //Float
        public Nullable<float> JitterStrength { get; set; }    //Float
        public string WorldPosTex { get; set; }    //rRef:ITexture
        public string NormalTex { get; set; }    //rRef:ITexture
        public Nullable<float> NumQuadsX { get; set; }    //Float
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; }    //Float
        public Vec4 VectorFieldTiling { get; set; }    //Vector4
        public Vec4 VectorFieldAnimSpeed { get; set; }    //Vector4
        public Vec4 VectorFieldDisplacementStrength { get; set; }    //Vector4
        public Nullable<float> Scale { get; set; }    //Float
        public Nullable<float> UsePivotAsOffset { get; set; }    //Float
        public Vec4 OriginalPivotWorldPosition { get; set; }    //Vector4
        public Color ColorMain { get; set; }    //Color
        public Nullable<float> Brightness { get; set; }    //Float
        public Nullable<float> BrightnessTop { get; set; }    //Float
        public Nullable<float> HACK_Q110_IsElder { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
    }
    public partial class _cyberparticles_platform
    {
        public string BlueNoise { get; set; }    //rRef:ITexture
        public string DataTex { get; set; }    //rRef:ITexture
        public string BlackTex { get; set; }    //rRef:ITexture
        public Nullable<float> UnRevealTime { get; set; }    //Float
        public Nullable<float> RevealDirection { get; set; }    //Float
        public Nullable<float> ColorMul { get; set; }    //Float
        public Nullable<float> MovementScale { get; set; }    //Float
        public Nullable<float> DistanceFade { get; set; }    //Float
        public Nullable<float> FloorScale { get; set; }    //Float
        public Vec4 BlockSize { get; set; }    //Vector4
        public Nullable<float> CityTilingX { get; set; }    //Float
        public Nullable<float> CityTilingY { get; set; }    //Float
        public Nullable<float> SideTilingX { get; set; }    //Float
        public Nullable<float> SideTilingY { get; set; }    //Float
        public Nullable<float> AddSizeX { get; set; }    //Float
        public Nullable<float> AddSizeY { get; set; }    //Float
        public Nullable<float> Width { get; set; }    //Float
        public Nullable<float> Height { get; set; }    //Float
        public Nullable<float> Depth { get; set; }    //Float
        public Vec4 NoiseScale { get; set; }    //Vector4
        public Vec4 NoiseSize { get; set; }    //Vector4
        public Nullable<float> TranslateTime { get; set; }    //Float
        public Vec4 TranslateDestination { get; set; }    //Vector4
        public Nullable<float> StretchMul { get; set; }    //Float
        public Nullable<float> StretchMax { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public Color Tint { get; set; }    //Color
    }
    public partial class _decal_emissive_color
    {
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveAlphaThreshold { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _decal_emissive_only
    {
        public string EmissiveMask { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> EmissiveAlphaThreshold { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _decal_forward
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public string Metalness { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> Alpha { get; set; }    //Float
    }
    public partial class _decal_gradientmap_recolor
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public string MaskTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public string GradientMap { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _decal_gradientmap_recolor_emissive
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public string MaskTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public string GradientMap { get; set; }    //rRef:ITexture
        public string EmissiveGradientMap { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _decal_normal_roughness
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _decal_normal_roughness_metalness
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _decal_normal_roughness_metalness_2
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Vec4 AtlasSize { get; set; }    //Vector4
        public Vec4 SubRegion { get; set; }    //Vector4
    }
    public partial class _decal_parallax
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Vec4 AtlasSize { get; set; }    //Vector4
        public Vec4 SubRegion { get; set; }    //Vector4
        public string HeightTexture { get; set; }    //rRef:ITexture
        public Nullable<float> HeightStrength { get; set; }    //Float
    }
    public partial class _decal_puddle
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public string NormalTexture { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _decal_roughness
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public Color DiffuseColor { get; set; }    //Color
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _decal_roughness_only
    {
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _decal_terrain_projected
    {
        public string AlphaMask { get; set; }    //rRef:ITexture
        public Nullable<float> AlphaMaskBlackPoint { get; set; }    //Float
        public Nullable<float> AlphaMaskWhitePoint { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Roughness { get; set; }    //rRef:ITexture
        public string SpecularIntensity { get; set; }    //rRef:ITexture
        public Vec4 RoughnessLevels { get; set; }    //Vector4
        public Vec4 SpecularIntensityLevels { get; set; }    //Vector4
        public Vec4 ColorMaskLevels { get; set; }    //Vector4
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Microblend { get; set; }    //rRef:ITexture
        public Nullable<float> MicroblendContrast { get; set; }    //Float
        public Nullable<float> MaterialTiling { get; set; }    //Float
        public Nullable<float> LayerTiling { get; set; }    //Float
        public Nullable<float> MicroblendTiling { get; set; }    //Float
    }
    public partial class _decal_tintable
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public string TintMaskTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Color MaskColorR { get; set; }    //Color
        public Color MaskColorG { get; set; }    //Color
        public Color MaskColorB { get; set; }    //Color
        public Vec4 AtlasSize { get; set; }    //Vector4
        public Vec4 SubRegion { get; set; }    //Vector4
    }
    public partial class _diode_sign
    {
        public Color ColorForeground { get; set; }    //Color
        public Color ColorMiddle { get; set; }    //Color
        public Color ColorBackground { get; set; }    //Color
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> HeightIndex { get; set; }    //Float
        public Nullable<float> WidthPixels { get; set; }    //Float
        public Vec4 StretchFactor { get; set; }    //Vector4
        public Nullable<float> ScrollSpeed { get; set; }    //Float
        public Nullable<float> DotSize { get; set; }    //Float
        public Nullable<float> Multiplier { get; set; }    //Float
        public Nullable<float> AmountOfLayers { get; set; }    //Float
        public Nullable<float> DotsSpacing { get; set; }    //Float
        public Nullable<float> FarDotMultiplier { get; set; }    //Float
        public Nullable<float> WidthPixelsStart { get; set; }    //Float
        public Nullable<float> AllWidthPixels { get; set; }    //Float
        public Nullable<float> AmountOfLines { get; set; }    //Float
        public string Text { get; set; }    //rRef:ITexture
    }
    public partial class _earth_globe
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; }     //rRef:Multilayer_Setup
        public Nullable<float> MultilayerBlendStrength { get; set; }    //Float
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public string CloudsMicroblend { get; set; }    //rRef:ITexture
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public string CityLightsMicroblend { get; set; }    //rRef:ITexture
        public Nullable<float> SetupLayerMask { get; set; }    //Float
        public Color BaseColorScale { get; set; }    //Color
        public Vec4 SunDirection { get; set; }    //Vector4
        public string WaterMask { get; set; }    //rRef:ITexture
        public string Clouds { get; set; }    //rRef:ITexture
        public string CityLights { get; set; }    //rRef:ITexture
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> CloudIntensity { get; set; }    //Float
        public Color CityLightsColor { get; set; }    //Color
        public string OceanDetailNormalMap { get; set; }    //rRef:ITexture
        public Nullable<float> OceanRoughness { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
    }
    public partial class _earth_globe_atmosphere
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color AtmosphereColor { get; set; }    //Color
        public Color AtmosphereOrangeColor { get; set; }    //Color
        public Nullable<float> Brigthness { get; set; }    //Float
        public Nullable<float> FresnelPower { get; set; }    //Float
        public Nullable<float> TransmissionBoost { get; set; }    //Float
        public Nullable<float> TransmissionBoostPower { get; set; }    //Float
        public Nullable<float> EarthRadius { get; set; }    //Float
        public Vec4 SunDirection { get; set; }    //Vector4
    }
    public partial class _earth_globe_lights
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Vec4 ScrollSpeed { get; set; }    //Vector4
        public Nullable<float> HardOrSoftTransition { get; set; }    //Float
        public Nullable<float> FullVisibilityFactor { get; set; }    //Float
        public Nullable<float> EnableAlternateUVcoord { get; set; }    //Float
        public Nullable<float> Preview2ndState { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
        public string CityLightsMicroblend { get; set; }    //rRef:ITexture
        public Vec4 SunDirection { get; set; }    //Vector4
    }
    public partial class _emissive_control
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _eye
    {
        public string Albedo { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public string Blick { get; set; }     //rRef:ITexture
        public string NormalBubble { get; set; }    //rRef:ITexture
        public Nullable<float> RefractionIndex { get; set; }    //Float
        public Nullable<float> RefractionAmount { get; set; }    //Float
        public Nullable<float> EyeRadius { get; set; }    //Float
        public Nullable<float> EyeHorizAngleRight { get; set; }    //Float
        public Nullable<float> EyeHorizAngleLeft { get; set; }    //Float
        public Nullable<float> EyeParallaxPlane { get; set; }    //Float
        public Nullable<float> IrisSize { get; set; }    //Float
        public Nullable<float> IrisCoordMargin { get; set; }    //Float
        public Nullable<float> IrisCoordFactor { get; set; }    //Float
        public Nullable<float> BlickScale { get; set; }    //Float
        public Nullable<float> BubbleNormalTile { get; set; }    //Float
        public Nullable<float> EggMarginExponent { get; set; }    //Float
        public Nullable<float> EggMarginFactor { get; set; }    //Float
        public Nullable<float> EggSubFactor { get; set; }    //Float
        public Nullable<float> EggFullRadius { get; set; }    //Float
        public Nullable<float> Specularity { get; set; }    //Float
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> SubsurfaceFactor { get; set; }    //Float
        public Nullable<float> AntiLightbleedValue { get; set; }    //Float
        public Nullable<float> AntiLightbleedUpOff { get; set; }    //Float
    }
    public partial class _eye_blendable
    {
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; }    //Float
        public Nullable<float> FadeOutOffset { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffset { get; set; }    //Float
        public Color FresnelColor { get; set; }    //Color
        public string Albedo { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public string Blick { get; set; }     //rRef:ITexture
        public string NormalBubble { get; set; }    //rRef:ITexture
        public Nullable<float> RefractionIndex { get; set; }    //Float
        public Nullable<float> RefractionAmount { get; set; }    //Float
        public Nullable<float> IrisSize { get; set; }    //Float
        public Nullable<float> EyeHorizAngleRight { get; set; }    //Float
        public Nullable<float> EyeHorizAngleLeft { get; set; }    //Float
        public Nullable<float> EyeRadius { get; set; }    //Float
        public Nullable<float> EyeParallaxPlane { get; set; }    //Float
        public Nullable<float> BubbleNormalTile { get; set; }    //Float
        public Nullable<float> EggFullRadius { get; set; }    //Float
        public Nullable<float> EggMarginExponent { get; set; }    //Float
        public Nullable<float> EggMarginFactor { get; set; }    //Float
        public Nullable<float> EggSubFactor { get; set; }    //Float
        public Nullable<float> IrisCoordFactor { get; set; }    //Float
        public Nullable<float> IrisCoordMargin { get; set; }    //Float
        public Nullable<float> BlickScale { get; set; }    //Float
        public Nullable<float> Specularity { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> SubsurfaceFactor { get; set; }    //Float
        public Nullable<float> AntiLightbleedValue { get; set; }    //Float
        public Nullable<float> AntiLightbleedUpOff { get; set; }    //Float
    }
    public partial class _eye_gradient
    {
        public string Albedo { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public string Blick { get; set; }     //rRef:ITexture
        public string NormalBubble { get; set; }    //rRef:ITexture
        public string IrisMask { get; set; }    //rRef:ITexture
        public string IrisColorGradient { get; set; }     //rRef:CGradient
        public Nullable<float> RefractionIndex { get; set; }    //Float
        public Nullable<float> RefractionAmount { get; set; }    //Float
        public Nullable<float> IrisSize { get; set; }    //Float
        public Nullable<float> EyeHorizAngleRight { get; set; }    //Float
        public Nullable<float> EyeHorizAngleLeft { get; set; }    //Float
        public Nullable<float> EyeRadius { get; set; }    //Float
        public Nullable<float> EyeParallaxPlane { get; set; }    //Float
        public Nullable<float> BubbleNormalTile { get; set; }    //Float
        public Nullable<float> EggFullRadius { get; set; }    //Float
        public Nullable<float> EggMarginExponent { get; set; }    //Float
        public Nullable<float> EggMarginFactor { get; set; }    //Float
        public Nullable<float> EggSubFactor { get; set; }    //Float
        public Nullable<float> IrisCoordFactor { get; set; }    //Float
        public Nullable<float> IrisCoordMargin { get; set; }    //Float
        public Nullable<float> BlickScale { get; set; }    //Float
        public Nullable<float> Specularity { get; set; }    //Float
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> SubsurfaceFactor { get; set; }    //Float
        public Nullable<float> AntiLightbleedValue { get; set; }    //Float
        public Nullable<float> AntiLightbleedUpOff { get; set; }    //Float
    }
    public partial class _eye_shadow
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color ShadowColor { get; set; }    //Color
        public Nullable<float> Exponent { get; set; }    //Float
        public Nullable<float> Intensity { get; set; }    //Float
        public string Mask { get; set; }    //rRef:ITexture
        public Nullable<float> WetnessRoughness { get; set; }    //Float
        public Nullable<float> WetnessStrength { get; set; }    //Float
        public Nullable<float> SubsurfaceBlur { get; set; }    //Float
    }
    public partial class _eye_shadow_blendable
    {
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; }    //Float
        public Nullable<float> FadeOutOffset { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffset { get; set; }    //Float
        public Color FresnelColor { get; set; }    //Color
        public Nullable<float> FresnelColorIntensity { get; set; }    //Float
        public Nullable<float> FresnelExponent { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color ShadowColor { get; set; }    //Color
        public Nullable<float> Exponent { get; set; }    //Float
        public Nullable<float> Intensity { get; set; }    //Float
        public string Mask { get; set; }    //rRef:ITexture
        public Nullable<float> WetnessRoughness { get; set; }    //Float
        public Nullable<float> WetnessStrength { get; set; }    //Float
        public Nullable<float> SubsurfaceBlur { get; set; }    //Float
    }
    public partial class _fake_occluder
    {
        public Nullable<float> DissolveDistance { get; set; }    //Float
        public Nullable<float> DissolveBandWidth { get; set; }    //Float
    }
    public partial class _fillable_fluid
    {
        public Vec4 FluidBoundingBoxMin { get; set; }    //Vector4
        public Vec4 FluidBoundingBoxMax { get; set; }    //Vector4
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color TintColor { get; set; }    //Color
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> ObjectSize { get; set; }    //Float
        public Nullable<float> ControlledByFx { get; set; }    //Float
        public Nullable<float> FillAmount { get; set; }    //Float
        public string Waves { get; set; }    //rRef:ITexture
        public Nullable<float> WaveAmplitude { get; set; }    //Float
        public Nullable<float> WaveSpeed { get; set; }    //Float
        public Nullable<float> WaveSize { get; set; }    //Float
    }
    public partial class _fillable_fluid_vertex
    {
        public Vec4 FluidBoundingBoxMin { get; set; }    //Vector4
        public Vec4 FluidBoundingBoxMax { get; set; }    //Vector4
        public Nullable<float> ControlledByFx { get; set; }    //Float
        public Nullable<float> ControlledByFxMode { get; set; }    //Float
        public Nullable<float> PinchDeformation { get; set; }    //Float
        public Nullable<float> FillAmount { get; set; }    //Float
        public string Waves { get; set; }    //rRef:ITexture
        public Nullable<float> WaveAmplitude { get; set; }    //Float
        public Nullable<float> WaveSpeed { get; set; }    //Float
        public Nullable<float> WaveSize { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public string GlassTint { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Nullable<float> FrontFacesReflectionPower { get; set; }    //Float
        public Nullable<float> IOR { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public Color GlassSpecularColor { get; set; }    //Color
        public Nullable<float> BlurRadius { get; set; }    //Float
    }
    public partial class _fluid_mov
    {
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> OpacityBackFace { get; set; }    //Float
        public Nullable<float> UvTilingX { get; set; }    //Float
        public Nullable<float> UvTilingY { get; set; }    //Float
        public Nullable<float> UvOffsetX { get; set; }    //Float
        public Nullable<float> UvOffsetY { get; set; }    //Float
        public Vec4 RoughnessTileAndOffset { get; set; }    //Vector4
        public Vec4 NormalTileAndOffset { get; set; }    //Vector4
        public Vec4 GlassTintTileAndOffset { get; set; }    //Vector4
        public string vertex_paint_tex { get; set; }    //rRef:ITexture
        public Nullable<float> IsControlledByDestruction { get; set; }    //Float
        public Nullable<float> trans_min { get; set; }    //Float
        public Nullable<float> trans_max { get; set; }    //Float
        public Nullable<float> rot_min { get; set; }    //Float
        public Nullable<float> rot_max { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> n_pieces { get; set; }    //Float
        public Nullable<float> play_time { get; set; }    //Float
        public Nullable<float> debug_familys { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public Nullable<float> YAxisUp { get; set; }    //Float
        public Nullable<float> z_min { get; set; }    //Float
        public Nullable<float> ground_offset { get; set; }    //Float
        public string GlassTint { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Nullable<float> TintFromVertexPaint { get; set; }    //Float
        public Nullable<float> FrontFacesReflectionPower { get; set; }    //Float
        public Nullable<float> BackFacesReflectionPower { get; set; }    //Float
        public Nullable<float> IOR { get; set; }    //Float
        public Nullable<float> RefractionDepth { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public Color GlassSpecularColor { get; set; }    //Color
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> NormalMapAffectsSpecular { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Nullable<float> GlassRoughnessBias { get; set; }    //Float
        public Nullable<float> MaskRoughnessBias { get; set; }    //Float
        public Nullable<float> BlurRadius { get; set; }    //Float
        public Nullable<float> BlurByRoughness { get; set; }    //Float
    }
    public partial class _frosted_glass
    {
        public Nullable<float> RenderBackFaces { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> UvTilingX { get; set; }    //Float
        public Nullable<float> UvTilingY { get; set; }    //Float
        public Nullable<float> UvOffsetX { get; set; }    //Float
        public Nullable<float> UvOffsetY { get; set; }    //Float
        public Vec4 RoughnessTileAndOffset { get; set; }    //Vector4
        public Vec4 NormalTileAndOffset { get; set; }    //Vector4
        public Vec4 GlassTintTileAndOffset { get; set; }    //Vector4
        public Nullable<float> RoughnessBase { get; set; }    //Float
        public Nullable<float> RoughnessAttenuation { get; set; }    //Float
        public Nullable<float> SurfaceOpacity { get; set; }    //Float
        public Color ColorMultiplier { get; set; }    //Color
        public string GlassTint { get; set; }    //rRef:ITexture
        public Color TintSurface { get; set; }    //Color
        public Color GlassSpecularColor { get; set; }    //Color
        public Nullable<float> FrontFacesReflectionPower { get; set; }    //Float
        public Nullable<float> BackFacesReflectionPower { get; set; }    //Float
        public Nullable<float> IOR { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Nullable<float> RefractionDepth { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public Nullable<float> SpecularPower { get; set; }    //Float
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> NormalMapAffectsSpecular { get; set; }    //Float
        public Nullable<float> BlurRadius { get; set; }    //Float
        public Nullable<float> BlurRoughness { get; set; }    //Float
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Nullable<float> MaskUseAlpha { get; set; }    //Float
        public Nullable<float> MaskAddSurface { get; set; }    //Float
        public Nullable<float> MaskAddOpacity { get; set; }    //Float
        public Nullable<float> MaskAddRoughness { get; set; }    //Float
    }
    public partial class _frosted_glass_curtain
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Nullable<float> RoughnessDirty { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public Color ColorMultiplier { get; set; }    //Color
        public Nullable<float> TintColorAttenuation { get; set; }    //Float
        public Nullable<float> RoughnessAttenuation { get; set; }    //Float
        public Nullable<float> FrontFacesReflectionPower { get; set; }    //Float
        public Nullable<float> BackFacesReflectionPower { get; set; }    //Float
        public Nullable<float> IOR { get; set; }    //Float
        public Nullable<float> blurRadius { get; set; }    //Float
        public Nullable<float> diffuseStrength { get; set; }    //Float
        public Nullable<float> SpecularPower { get; set; }    //Float
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
    }
    public partial class _glass
    {
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> OpacityBackFace { get; set; }    //Float
        public Nullable<float> UvTilingX { get; set; }    //Float
        public Nullable<float> UvTilingY { get; set; }    //Float
        public Nullable<float> UvOffsetX { get; set; }    //Float
        public Nullable<float> UvOffsetY { get; set; }    //Float
        public Vec4 RoughnessTileAndOffset { get; set; }    //Vector4
        public Vec4 NormalTileAndOffset { get; set; }    //Vector4
        public Vec4 GlassTintTileAndOffset { get; set; }    //Vector4
        public Color TintColor { get; set; }    //Color
        public string GlassTint { get; set; }    //rRef:ITexture
        public Nullable<float> TintFromVertexPaint { get; set; }    //Float
        public Nullable<float> FrontFacesReflectionPower { get; set; }    //Float
        public Nullable<float> BackFacesReflectionPower { get; set; }    //Float
        public Nullable<float> IOR { get; set; }    //Float
        public Nullable<float> RefractionDepth { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public Color GlassSpecularColor { get; set; }    //Color
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> NormalMapAffectsSpecular { get; set; }    //Float
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> GlassRoughnessBias { get; set; }    //Float
        public Nullable<float> MaskRoughnessBias { get; set; }    //Float
        public Nullable<float> BlurRadius { get; set; }    //Float
        public Nullable<float> BlurByRoughness { get; set; }    //Float
    }
    public partial class _glass_blendable
    {
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; }    //Float
        public Nullable<float> FadeOutOffset { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffset { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> OpacityBackFace { get; set; }    //Float
        public Color FresnelColor { get; set; }    //Color
        public Nullable<float> FresnelColorIntensity { get; set; }    //Float
        public Nullable<float> FresnelExponent { get; set; }    //Float
        public string GlassTint { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Nullable<float> TintFromVertexPaint { get; set; }    //Float
        public Nullable<float> FrontFacesReflectionPower { get; set; }    //Float
        public Nullable<float> BackFacesReflectionPower { get; set; }    //Float
        public Nullable<float> IOR { get; set; }    //Float
        public Nullable<float> RefractionDepth { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public Color GlassSpecularColor { get; set; }    //Color
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> NormalMapAffectsSpecular { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Nullable<float> GlassRoughnessBias { get; set; }    //Float
        public Nullable<float> MaskRoughnessBias { get; set; }    //Float
        public Nullable<float> BlurRadius { get; set; }    //Float
        public Nullable<float> BlurByRoughness { get; set; }    //Float
    }
    public partial class _glass_cracked_edge
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public Nullable<float> AlphaScale { get; set; }    //Float
        public Nullable<float> UseAlphaFromSkinning { get; set; }    //Float
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _glass_deferred
    {
        public Nullable<float> UvTilingX { get; set; }    //Float
        public Nullable<float> UvTilingY { get; set; }    //Float
        public Nullable<float> UvOffsetX { get; set; }    //Float
        public Nullable<float> UvOffsetY { get; set; }    //Float
        public Vec4 NormalTileAndOffset { get; set; }    //Vector4
        public string GlassTint { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Nullable<float> TintFromVertexPaint { get; set; }    //Float
        public Nullable<float> TintColorAttenuation { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public Nullable<float> GlassMetalness { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Nullable<float> MaskRoughnessBias { get; set; }    //Float
        public string Reflection { get; set; }     //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
    }
    public partial class _glass_scope
    {
        public Vec4 UvTilingOffset { get; set; }    //Vector4
        public Nullable<float> LensRoughness { get; set; }    //Float
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public Nullable<float> LensMetalness { get; set; }    //Float
        public string GlassTint { get; set; }    //rRef:ITexture
        public Color GlassTintMultiplier { get; set; }    //Color
        public Nullable<float> EmissiveTint { get; set; }    //Float
        public Color LensSpecularColor { get; set; }    //Color
        public Nullable<float> LensReflectionPower { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> SpecularPower { get; set; }    //Float
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Vec4 UseMask { get; set; }    //Vector4
        public Nullable<float> ScopeMaskFarDistance { get; set; }    //Float
        public string ScopeMaskClose { get; set; }    //rRef:ITexture
        public string ScopeMaskFar { get; set; }    //rRef:ITexture
        public string LensBulge { get; set; }    //rRef:ITexture
        public Color ScopeInside { get; set; }    //Color
        public Nullable<float> DistortionStrenght { get; set; }    //Float
        public Nullable<float> LensBulgeStrength { get; set; }    //Float
        public Nullable<float> AberrationStrenght { get; set; }    //Float
        public Nullable<float> SphereMaskCloseRadius { get; set; }    //Float
        public Nullable<float> SphereMaskCloseHardness { get; set; }    //Float
        public Nullable<float> LensBulgeRadius { get; set; }    //Float
        public Nullable<float> LensBulgeHardness { get; set; }    //Float
        public Nullable<float> SphereMaskFarRadius { get; set; }    //Float
        public Nullable<float> SphereMaskFarHardness { get; set; }    //Float
        public Nullable<float> SphereMaskDistortionRadius { get; set; }    //Float
        public Nullable<float> SphereMaskDistortionHardness { get; set; }    //Float
        public Vec4 EyeRelief { get; set; }    //Vector4
    }
    public partial class _glass_window_rain
    {
        public Nullable<float> UvTilingX { get; set; }    //Float
        public Nullable<float> UvTilingY { get; set; }    //Float
        public Nullable<float> UvOffsetX { get; set; }    //Float
        public Nullable<float> UvOffsetY { get; set; }    //Float
        public Vec4 RoughnessTileAndOffset { get; set; }    //Vector4
        public Vec4 GlassTintTileAndOffset { get; set; }    //Vector4
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> OpacityBackFace { get; set; }    //Float
        public string GlassTint { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Color TintSurface { get; set; }    //Color
        public Nullable<float> FrontFacesReflectionPower { get; set; }    //Float
        public Nullable<float> BackFacesReflectionPower { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public Color GlassSpecularColor { get; set; }    //Color
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Nullable<float> GlassRoughnessBias { get; set; }    //Float
        public Nullable<float> MaskRoughnessBias { get; set; }    //Float
        public Nullable<float> RainTiling { get; set; }    //Float
        public Nullable<float> FlowTiling { get; set; }    //Float
        public string DotsNormalTxt { get; set; }    //rRef:ITexture
        public string DotsTxt { get; set; }    //rRef:ITexture
        public string FlowTxt { get; set; }    //rRef:ITexture
    }
    public partial class _hair
    {
        public string Strand_Gradient { get; set; }    //rRef:ITexture
        public Nullable<float> Animation_AmplitudeScale { get; set; }    //Float
        public Nullable<float> Animation_PeriodScale { get; set; }    //Float
        public string Strand_ID { get; set; }    //rRef:ITexture
        public string Strand_Alpha { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> AlphaCutoff { get; set; }    //Float
        public string Flow { get; set; }    //rRef:ITexture
        public Nullable<float> FlowStrength { get; set; }    //Float
        public Nullable<float> VertexColorStrength { get; set; }    //Float
        public Nullable<float> Scattering { get; set; }    //Float
        public Nullable<float> ShadowStrength { get; set; }    //Float
        public Nullable<float> ShadowMin { get; set; }    //Float
        public Nullable<float> ShadowMax { get; set; }    //Float
        public Nullable<float> ShadowRoughness { get; set; }    //Float
        public Nullable<float> DebugHairColor { get; set; }    //Float
        public string HairProfile { get; set; }     //rRef:CHairProfile
    }
    public partial class _hair_blendable
    {
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; }    //Float
        public Nullable<float> FadeOutOffset { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffset { get; set; }    //Float
        public string Strand_Gradient { get; set; }    //rRef:ITexture
        public Nullable<float> Animation_AmplitudeScale { get; set; }    //Float
        public Nullable<float> Animation_PeriodScale { get; set; }    //Float
        public Color FresnelColor { get; set; }    //Color
        public Nullable<float> FresnelColorIntensity { get; set; }    //Float
        public Nullable<float> FresnelExponent { get; set; }    //Float
        public string Strand_ID { get; set; }    //rRef:ITexture
        public string Strand_Alpha { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> AlphaCutoff { get; set; }    //Float
        public string Flow { get; set; }    //rRef:ITexture
        public Nullable<float> FlowStrength { get; set; }    //Float
        public Nullable<float> VertexColorStrength { get; set; }    //Float
        public Nullable<float> Scattering { get; set; }    //Float
        public Nullable<float> ShadowStrength { get; set; }    //Float
        public Nullable<float> ShadowMin { get; set; }    //Float
        public Nullable<float> ShadowMax { get; set; }    //Float
        public Nullable<float> ShadowRoughness { get; set; }    //Float
        public Nullable<float> DebugHairColor { get; set; }    //Float
        public string HairProfile { get; set; }     //rRef:CHairProfile
    }
    public partial class _hair_proxy
    {
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Albedo { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Scattering { get; set; }    //Float
    }
    public partial class _ice_fluid_mov
    {
        public Nullable<float> WaveIdleNormalStrength { get; set; }    //Float
        public Vec4 WaveIdleTilingAndSpeed { get; set; }    //Vector4
        public Nullable<float> DebugTimeOverride { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public Nullable<float> SimulationAtlasFrameCountX { get; set; }    //Float
        public Nullable<float> SimulationAtlasFrameCountY { get; set; }    //Float
        public string SimulationAtlas { get; set; }    //rRef:ITexture
        public string WaveIdleMap { get; set; }    //rRef:ITexture
        public Nullable<float> WaveIdleHeight { get; set; }    //Float
        public Nullable<float> HeightMin { get; set; }    //Float
        public Nullable<float> HeightMax { get; set; }    //Float
        public Nullable<float> WaterRoughness { get; set; }    //Float
        public Nullable<float> WaterSpecF0 { get; set; }    //Float
        public Nullable<float> WaterSpecF90 { get; set; }    //Float
        public Color WaterColorShallow { get; set; }    //Color
        public Color WaterColorDeep { get; set; }    //Color
        public Color WaveColor0 { get; set; }    //Color
        public Color WaveColor1 { get; set; }    //Color
        public Nullable<float> WaveNoiseTiling { get; set; }    //Float
        public Nullable<float> WaveNoiseContrast { get; set; }    //Float
        public Nullable<float> WaveNoiseContrastOut { get; set; }    //Float
        public Nullable<float> RefractionStrength { get; set; }    //Float
        public Color IceColor1 { get; set; }    //Color
        public Color IceColor2 { get; set; }    //Color
        public Nullable<float> IceTiling { get; set; }    //Float
        public Nullable<float> UVRatio { get; set; }    //Float
        public Nullable<float> IceDepth { get; set; }    //Float
        public Nullable<float> IceNormalStrength { get; set; }    //Float
        public Color BloodColor { get; set; }    //Color
        public Nullable<float> BloodFadeStart { get; set; }    //Float
        public Nullable<float> BloodFadeEnd { get; set; }    //Float
        public string WaveNoiseMap { get; set; }    //rRef:ITexture
        public string IceMasksMap { get; set; }    //rRef:ITexture
        public string IceNormalMap { get; set; }    //rRef:ITexture
    }
    public partial class _ice_ver_mov_translucent
    {
        public string vertex_paint_tex { get; set; }    //rRef:ITexture
        public Nullable<float> trans_min { get; set; }    //Float
        public Nullable<float> trans_max { get; set; }    //Float
        public Nullable<float> rot_min { get; set; }    //Float
        public Nullable<float> rot_max { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> n_pieces { get; set; }    //Float
        public Nullable<float> play_time { get; set; }    //Float
        public Nullable<float> debug_familys { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public string WaveIdleMap { get; set; }    //rRef:ITexture
        public Nullable<float> WaveIdleHeight { get; set; }    //Float
        public Vec4 WaveIdleTilingAndSpeed { get; set; }    //Vector4
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Color RefractionTint { get; set; }    //Color
        public Nullable<float> IOR { get; set; }    //Float
    }
    public partial class _lights_interactive
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
        public Nullable<float> Zone0EmissiveEV { get; set; }    //Float
        public Nullable<float> Zone1EmissiveEV { get; set; }    //Float
        public Nullable<float> Zone2EmissiveEV { get; set; }    //Float
        public Nullable<float> Zone3EmissiveEV { get; set; }    //Float
        public Vec4 DebugLightsIntensity { get; set; }    //Vector4
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _loot_drop_highlight
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> Mode { get; set; }    //Float
        public Color HighlightColor { get; set; }    //Color
        public Nullable<float> HighlightIntensity { get; set; }    //Float
        public Nullable<float> SolidBlendingDistanceStart { get; set; }    //Float
        public Nullable<float> SolidBlendingDistanceEnd { get; set; }    //Float
    }
    public partial class _mesh_decal
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public Nullable<float> UVOffsetX { get; set; }    //Float
        public Nullable<float> UVOffsetY { get; set; }    //Float
        public Nullable<float> UVRotation { get; set; }    //Float
        public Nullable<float> UVScaleX { get; set; }    //Float
        public Nullable<float> UVScaleY { get; set; }    //Float
        public string SecondaryMask { get; set; }    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; }    //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public string NormalAlphaTex { get; set; }    //rRef:ITexture
        public Nullable<float> UseNormalAlphaTex { get; set; }    //Float
        public Nullable<float> NormalsBlendingMode { get; set; }    //Float
        public string NormalsBlendingModeAlpha { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
    }
    public partial class _mesh_decal_blendable
    {
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; }    //Float
        public Nullable<float> FadeOutOffset { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffset { get; set; }    //Float
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public Color FresnelColor { get; set; }    //Color
        public Nullable<float> FresnelColorIntensity { get; set; }    //Float
        public Nullable<float> FresnelExponent { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public Nullable<float> UVOffsetX { get; set; }    //Float
        public Nullable<float> UVOffsetY { get; set; }    //Float
        public Nullable<float> UVRotation { get; set; }    //Float
        public Nullable<float> UVScaleX { get; set; }    //Float
        public Nullable<float> UVScaleY { get; set; }    //Float
        public string SecondaryMask { get; set; }    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; }    //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public string NormalAlphaTex { get; set; }    //rRef:ITexture
        public Nullable<float> UseNormalAlphaTex { get; set; }    //Float
        public Nullable<float> NormalsBlendingMode { get; set; }    //Float
        public string NormalsBlendingModeAlpha { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
    }
    public partial class _mesh_decal_double_diffuse
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public string SecondaryDiffuseAlpha { get; set; }    //rRef:ITexture
        public Color SecondaryDiffuseColor { get; set; }    //Color
        public Nullable<float> SecondaryDiffuseAlphaIntensity { get; set; }    //Float
        public Nullable<float> UVOffsetX { get; set; }    //Float
        public Nullable<float> UVOffsetY { get; set; }    //Float
        public Nullable<float> UVRotation { get; set; }    //Float
        public Nullable<float> UVScaleX { get; set; }    //Float
        public Nullable<float> UVScaleY { get; set; }    //Float
        public string SecondaryMask { get; set; }    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; }    //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; }    //Float
        public string NormalsBlendingModeAlpha { get; set; }    //rRef:ITexture
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public string NormalAlphaTex { get; set; }    //rRef:ITexture
        public Nullable<float> UseNormalAlphaTex { get; set; }    //Float
        public Nullable<float> NormalsBlendingMode { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
    }
    public partial class _mesh_decal_emissive
    {
        public Nullable<float> DamageInfluence { get; set; }    //Float
        public Nullable<float> DamageInfluenceDebug { get; set; }    //Float
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Color DiffuseColor2 { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public Nullable<float> UVOffsetX { get; set; }    //Float
        public Nullable<float> UVOffsetY { get; set; }    //Float
        public Nullable<float> UVRotation { get; set; }    //Float
        public Nullable<float> UVScaleX { get; set; }    //Float
        public Nullable<float> UVScaleY { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Vec4 ScrollSpeed { get; set; }    //Vector4
        public Nullable<float> HardOrSoftTransition { get; set; }    //Float
        public Nullable<float> FullVisibilityFactor { get; set; }    //Float
        public Nullable<float> EnableAlternateColor { get; set; }    //Float
        public Nullable<float> EnableAlternateUVcoord { get; set; }    //Float
        public Nullable<float> Preview2ndState { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _mesh_decal_emissive_subsurface
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string EmissiveMask { get; set; }    //rRef:ITexture
        public string SecondaryMask { get; set; }    //rRef:ITexture
        public Vec4 EmissiveMaskChannel { get; set; }    //Vector4
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _mesh_decal_gradientmap_recolor
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public string MaskTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public string GradientMap { get; set; }    //rRef:ITexture
        public string SecondaryMask { get; set; }    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; }    //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public Nullable<float> NormalsBlendingMode { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
    }
    public partial class _mesh_decal_gradientmap_recolor_2
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public string MaskTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public string Gradient { get; set; }     //rRef:CGradient
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public Nullable<float> NormalsBlendingMode { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
    }
    public partial class _mesh_decal_gradientmap_recolor_emissive
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public string MaskTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public string GradientMap { get; set; }    //rRef:ITexture
        public string EmissiveGradientMap { get; set; }    //rRef:ITexture
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public Nullable<float> NormalsBlendingMode { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
    }
    public partial class _mesh_decal_multitinted
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
        public string TintMaskTexture { get; set; }    //rRef:ITexture
        public Color TintColor0 { get; set; }    //Color
        public Color TintColor1 { get; set; }    //Color
        public Color TintColor2 { get; set; }    //Color
        public Color TintColor3 { get; set; }    //Color
        public Color TintColor4 { get; set; }    //Color
        public Color TintColor5 { get; set; }    //Color
        public Color TintColor6 { get; set; }    //Color
        public Color TintColor7 { get; set; }    //Color
    }
    public partial class _mesh_decal_parallax
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public Nullable<float> UVOffsetX { get; set; }    //Float
        public Nullable<float> UVOffsetY { get; set; }    //Float
        public Nullable<float> UVRotation { get; set; }    //Float
        public Nullable<float> UVScaleX { get; set; }    //Float
        public Nullable<float> UVScaleY { get; set; }    //Float
        public string SecondaryMask { get; set; }    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; }    //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public string NormalAlphaTex { get; set; }    //rRef:ITexture
        public Nullable<float> UseNormalAlphaTex { get; set; }    //Float
        public Nullable<float> NormalsBlendingMode { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
        public string HeightTexture { get; set; }    //rRef:ITexture
        public Nullable<float> HeightStrength { get; set; }    //Float
    }
    public partial class _mesh_decal_revealed
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public Nullable<float> NormalsBlendingMode { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> TileNumber { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
        public string FlowTexture { get; set; }    //rRef:ITexture
    }
    public partial class _mesh_decal_wet_character
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public Nullable<float> UVOffsetX { get; set; }    //Float
        public Nullable<float> UVOffsetY { get; set; }    //Float
        public Nullable<float> UVRotation { get; set; }    //Float
        public Nullable<float> UVScaleX { get; set; }    //Float
        public Nullable<float> UVScaleY { get; set; }    //Float
        public string SecondaryMask { get; set; }    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; }    //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public string NormalAlphaTex { get; set; }    //rRef:ITexture
        public Nullable<float> UseNormalAlphaTex { get; set; }    //Float
        public Nullable<float> NormalsBlendingMode { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> AnimationSpeed { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
    }
    public partial class _metal_base_bink
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public string VideoCanvasName { get; set; }     //CName
        public string BinkY { get; set; }    //rRef:ITexture
        public string BinkCR { get; set; }    //rRef:ITexture
        public string BinkCB { get; set; }    //rRef:ITexture
        public string BinkA { get; set; }    //rRef:ITexture
        public DataBuffer BinkParams { get; set; }
    }
    public partial class _metal_base_det
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public string DetailColor { get; set; }    //rRef:ITexture
        public string DetailNormal { get; set; }    //rRef:ITexture
        public Nullable<float> DetailU { get; set; }    //Float
        public Nullable<float> DetailV { get; set; }    //Float
    }
    public partial class _metal_base_det_dithered
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public string DetailColor { get; set; }    //rRef:ITexture
        public string DetailNormal { get; set; }    //rRef:ITexture
        public Nullable<float> DetailU { get; set; }    //Float
        public Nullable<float> DetailV { get; set; }    //Float
    }
    public partial class _metal_base_dithered
    {
        public Nullable<float> VehicleDamageInfluence { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveLift { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _metal_base_gradientmap_recolor
    {
        public Nullable<float> VehicleDamageInfluence { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Mask { get; set; }    //rRef:ITexture
        public string GradientMap { get; set; }    //rRef:ITexture
        public string EmissiveGradientMap { get; set; }    //rRef:ITexture
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _metal_base_parallax
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveLift { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public string HeightTexture { get; set; }    //rRef:ITexture
        public Nullable<float> HeightStrength { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _metal_base_trafficlight_proxy
    {
        public Nullable<float> TrafficCellSize { get; set; }    //Float
        public Nullable<float> TrafficSpeed { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveLift { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _metal_base_ui
    {
        public string ScanlineTexture { get; set; }    //rRef:ITexture
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> FixToPbr { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> LayersSeparation { get; set; }    //Float
        public Vec4 IntensityPerLayer { get; set; }    //Vector4
        public Vec4 ScanlinesDensity { get; set; }    //Vector4
        public Nullable<float> ScanlinesIntensity { get; set; }    //Float
        public Nullable<float> IsBroken { get; set; }    //Float
        public Nullable<float> ImageScale { get; set; }    //Float
        public string UIRenderTexture { get; set; }    //rRef:ITexture
        public Vec4 RenderTextureScale { get; set; }    //Vector4
        public Nullable<float> VerticalFlipEnabled { get; set; }    //Float
        public Vec4 TexturePartUV { get; set; }    //Vector4
        public string DirtTexture { get; set; }    //rRef:ITexture
        public Color DirtColor { get; set; }    //Color
        public Nullable<float> DirtRoughness { get; set; }    //Float
        public Nullable<float> DirtEmissiveAttenuation { get; set; }    //Float
        public Nullable<float> DirtContrast { get; set; }    //Float
        public Color Tint { get; set; }    //Color
        public Nullable<float> FixForBlack { get; set; }    //Float
        public Nullable<float> FixForVerticalSlide { get; set; }    //Float
        public Color ForcedTint { get; set; }    //Color
    }
    public partial class _metal_base_vertexcolored
    {
    }
    public partial class _mikoshi_blocks_big
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Color EmissiveColor { get; set; }    //Color
        public string DataTex { get; set; }    //rRef:ITexture
        public string NoiseTex { get; set; }    //rRef:ITexture
        public string PcbTex { get; set; }    //rRef:ITexture
    }
    public partial class _mikoshi_blocks_medium
    {
        public Nullable<float> RandomSeed { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Color EmissiveColor { get; set; }    //Color
        public string DataTex { get; set; }    //rRef:ITexture
        public string NoiseTex { get; set; }    //rRef:ITexture
    }
    public partial class _mikoshi_blocks_small
    {
        public Nullable<float> RandomSeed { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Color EmissiveColor { get; set; }    //Color
        public string DataTex { get; set; }    //rRef:ITexture
        public string NoiseTex { get; set; }    //rRef:ITexture
    }
    public partial class _mikoshi_parallax
    {
        public string RoomAtlas { get; set; }    //rRef:ITexture
        public string LayerAtlas { get; set; }    //rRef:ITexture
        public Vec4 AtlasGridUvRatio { get; set; }    //Vector4
        public Nullable<float> AtlasDepth { get; set; }    //Float
        public Nullable<float> roomWidth { get; set; }    //Float
        public Nullable<float> roomHeight { get; set; }    //Float
        public Nullable<float> roomDepth { get; set; }    //Float
        public Nullable<float> positionXoffset { get; set; }    //Float
        public Nullable<float> positionYoffset { get; set; }    //Float
        public Nullable<float> LayerDepth { get; set; }    //Float
        public Nullable<float> Frostiness { get; set; }    //Float
        public string WindowTexture { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
    }
    public partial class _mikoshi_prison_cell
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> EdgeFalloff { get; set; }    //Float
        public Nullable<float> DepthAttenuation { get; set; }    //Float
        public Nullable<float> DepthAttenuationPower { get; set; }    //Float
        public Nullable<float> LightIntensity { get; set; }    //Float
        public Color LightColor { get; set; }    //Color
        public string SilhouetteTex { get; set; }    //rRef:ITexture
    }
    public partial class _multilayered_clear_coat
    {
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color CoatTintFwd { get; set; }    //Color
        public Color CoatTintSide { get; set; }    //Color
        public Nullable<float> CoatTintFresnelBias { get; set; }    //Float
        public Color CoatSpecularColor { get; set; }    //Color
        public Nullable<float> CoatNormalStrength { get; set; }    //Float
        public Nullable<float> CoatRoughnessBase { get; set; }    //Float
        public Nullable<float> CoatReflectionPower { get; set; }    //Float
        public Nullable<float> CoatFresnelBias { get; set; }    //Float
        public Nullable<float> CoatLayerMin { get; set; }    //Float
        public Nullable<float> CoatLayerMax { get; set; }    //Float
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; }     //rRef:Multilayer_Setup
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public Nullable<float> SetupLayerMask { get; set; }    //Float
    }
    public partial class _multilayered_terrain
    {
        public Nullable<float> UseOldVertexFormat { get; set; }    //Float
        public Vec4 UVGenScaleOffset { get; set; }    //Vector4
        public Nullable<float> DebugPreviewMasks { get; set; }    //Float
        public Nullable<float> UseGlobalNormal { get; set; }    //Float
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public string MultilayerSetup { get; set; }     //rRef:Multilayer_Setup
        public string BaseColor { get; set; }    //rRef:ITexture
        public string TilingMap { get; set; }    //rRef:ITexture
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public Nullable<float> SetupLayerMask { get; set; }    //Float
        public string TerrainSetup { get; set; }     //rRef:CTerrainSetup
        public DataBuffer TilingDataBuffer { get; set; }
        public string MaskFoliage { get; set; }    //rRef:ITexture
    }
    public partial class _neon_parallax
    {
        public Nullable<float> UvTilingX { get; set; }    //Float
        public Nullable<float> UvTilingY { get; set; }    //Float
        public Nullable<float> UvOffsetX { get; set; }    //Float
        public Nullable<float> UvOffsetY { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Nullable<float> UseGradientMapMode { get; set; }    //Float
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string GradientMap { get; set; }    //rRef:ITexture
        public Color BaseColorScaleEdgeStart { get; set; }    //Color
        public Color BaseColorScaleEdgeEnd { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> ParallaxDepth { get; set; }    //Float
        public Nullable<float> ParallaxFlip { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _presimulated_particles
    {
        public string vertex_paint_tex { get; set; }    //rRef:ITexture
        public Nullable<float> trans_min { get; set; }    //Float
        public Nullable<float> trans_max { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> n_pieces { get; set; }    //Float
        public Nullable<float> play_time { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public Nullable<float> ParticleScale { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _proxy_ad
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _proxy_crowd
    {
        public string Atlas { get; set; }    //rRef:ITexture
        public string BaseColor { get; set; }    //rRef:ITexture
        public string Metalness { get; set; }    //rRef:ITexture
        public Color Color1 { get; set; }    //Color
        public Color Color2 { get; set; }    //Color
        public Color Color3 { get; set; }    //Color
        public Color Color4 { get; set; }    //Color
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Vec4 AtlasSize { get; set; }    //Vector4
    }
    public partial class _q116_mikoshi_cubes
    {
        public Nullable<float> PointCloudTextureHeight { get; set; }    //Float
        public Vec4 TransMin { get; set; }    //Vector4
        public Vec4 TransMax { get; set; }    //Vector4
        public string WorldPosTex { get; set; }    //rRef:ITexture
        public Nullable<float> CubeSize { get; set; }    //Float
        public Nullable<float> Tiling { get; set; }    //Float
        public Nullable<float> DiffuseVariationUvScale { get; set; }    //Float
        public Nullable<float> ParallaxHeightScale { get; set; }    //Float
        public Nullable<float> ParallaxFlip { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public string ExtraMasks { get; set; }    //rRef:ITexture
        public string EdgeMask { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _q116_mikoshi_floor
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public Color EmissiveColor { get; set; }    //Color
        public string Emissive { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> FalloffDistanceStart { get; set; }    //Float
        public Nullable<float> FalloffDistanceEnd { get; set; }    //Float
        public Nullable<float> GlowBrightnessStart { get; set; }    //Float
        public Nullable<float> GlowBrightnessEnd { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public string VectorField1 { get; set; }    //rRef:ITexture
        public string VectorField2 { get; set; }    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; }    //Float
        public string Grain { get; set; }    //rRef:ITexture
    }
    public partial class _q202_lake_surface
    {
        public string Starmap { get; set; }     //rRef:ITexture
        public string Galaxy { get; set; }    //rRef:ITexture
        public Nullable<float> GalaxyIntensity { get; set; }    //Float
        public Nullable<float> StarmapIntensity { get; set; }    //Float
        public Nullable<float> DimScale { get; set; }    //Float
        public Nullable<float> BrightScale { get; set; }    //Float
        public Nullable<float> ConstelationScale { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _rain
    {
        public Nullable<float> RainType { get; set; }    //Float
        public string WindNoise { get; set; }    //rRef:ITexture
        public Nullable<float> Speed { get; set; }    //Float
        public Nullable<float> Scale { get; set; }    //Float
        public Nullable<float> WindSkew { get; set; }    //Float
        public Nullable<float> WindStrength { get; set; }    //Float
        public Nullable<float> WindDirectionMovement { get; set; }    //Float
        public Nullable<float> WindFrequency { get; set; }    //Float
        public Nullable<float> Height { get; set; }    //Float
        public Nullable<float> Distance { get; set; }    //Float
        public Nullable<float> Radius { get; set; }    //Float
        public Nullable<float> BrightnessCards { get; set; }    //Float
        public Nullable<float> BrightnessDrops { get; set; }    //Float
        public Nullable<float> MovementStrength { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> UvSpeed { get; set; }    //Float
        public string Mask { get; set; }    //rRef:ITexture
    }
    public partial class _road_debug_grid
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public Nullable<float> TransitionSize { get; set; }    //Float
        public Nullable<float> GridScale { get; set; }    //Float
        public Nullable<float> EnableWorldSpace { get; set; }    //Float
    }
    public partial class _set_stencil_3
    {
        public Nullable<float> ExtraThickness { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
    }
    public partial class _silverhand_overlay
    {
        public Nullable<float> DepthOffset { get; set; }    //Float
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffset { get; set; }    //Float
        public Nullable<float> GlitchTimeSeed { get; set; }    //Float
        public string FresnelMask { get; set; }    //rRef:ITexture
        public Nullable<float> FresnelMaskIntensity { get; set; }    //Float
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; }     //rRef:Multilayer_Setup
        public Nullable<float> Emissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> BayerScale { get; set; }    //Float
        public Nullable<float> BayerIntensity { get; set; }    //Float
        public Vec4 VertexColorSelection { get; set; }    //Vector4
        public Nullable<float> VectorFieldTiling { get; set; }    //Float
        public Nullable<float> VectorFieldIntensity { get; set; }    //Float
        public Vec4 VectorFieldAnim { get; set; }    //Vector4
        public Color FresnelColor { get; set; }    //Color
        public Nullable<float> FresnelColorIntensity { get; set; }    //Float
        public Nullable<float> FresnelExponent { get; set; }    //Float
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public Nullable<float> SetupLayerMask { get; set; }    //Float
    }
    public partial class _silverhand_overlay_blendable
    {
        public Nullable<float> FadeOutDistance { get; set; }    //Float
        public Nullable<float> FadeOutOffset { get; set; }    //Float
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffset { get; set; }    //Float
        public Nullable<float> GlitchTimeSeed { get; set; }    //Float
        public string FresnelMask { get; set; }    //rRef:ITexture
        public Nullable<float> FresnelMaskIntensity { get; set; }    //Float
        public Color FresnelColor { get; set; }    //Color
        public Nullable<float> FresnelColorIntensity { get; set; }    //Float
        public Nullable<float> FresnelExponent { get; set; }    //Float
        public Nullable<float> Emissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> BayerScale { get; set; }    //Float
        public Nullable<float> BayerIntensity { get; set; }    //Float
        public Vec4 VertexColorSelection { get; set; }    //Vector4
        public Nullable<float> VectorFieldTiling { get; set; }    //Float
        public Nullable<float> VectorFieldIntensity { get; set; }    //Float
        public Vec4 VectorFieldAnim { get; set; }    //Vector4
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; }     //rRef:Multilayer_Setup
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public Nullable<float> SetupLayerMask { get; set; }    //Float
    }
    public partial class _skin
    {
        public string Albedo { get; set; }    //rRef:ITexture
        public string SecondaryAlbedo { get; set; }    //rRef:ITexture
        public Nullable<float> SecondaryAlbedoInfluence { get; set; }    //Float
        public Nullable<float> SecondaryAlbedoTintColorInfluence { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string DetailNormal { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> DetailRoughnessBiasMin { get; set; }    //Float
        public Nullable<float> DetailRoughnessBiasMax { get; set; }    //Float
        public Nullable<float> MicroDetailUVScale01 { get; set; }    //Float
        public Nullable<float> MicroDetailUVScale02 { get; set; }    //Float
        public string MicroDetail { get; set; }    //rRef:ITexture
        public Nullable<float> MicroDetailInfluence { get; set; }    //Float
        public string TintColorMask { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Nullable<float> TintScale { get; set; }    //Float
        public string SkinProfile { get; set; }     //rRef:CSkinProfile
        public string Detailmap_Stretch { get; set; }    //rRef:ITexture
        public string EmissiveMask { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public string Detailmap_Squash { get; set; }    //rRef:ITexture
        public Nullable<float> CavityIntensity { get; set; }    //Float
        public string Bloodflow { get; set; }    //rRef:ITexture
        public Color BloodColor { get; set; }    //Color
        public Nullable<float> DetailNormalInfluence { get; set; }    //Float
    }
    public partial class _skin_blendable
    {
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; }    //Float
        public Nullable<float> FadeOutOffset { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffset { get; set; }    //Float
        public Color FresnelColor { get; set; }    //Color
        public Nullable<float> FresnelColorIntensity { get; set; }    //Float
        public Nullable<float> FresnelExponent { get; set; }    //Float
        public string Albedo { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public string DetailNormal { get; set; }    //rRef:ITexture
        public Nullable<float> DetailNormalInfluence { get; set; }    //Float
        public Nullable<float> CavityIntensity { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> DetailRoughnessBiasMin { get; set; }    //Float
        public Nullable<float> DetailRoughnessBiasMax { get; set; }    //Float
        public string MicroDetail { get; set; }    //rRef:ITexture
        public Nullable<float> MicroDetailUVScale01 { get; set; }    //Float
        public Nullable<float> MicroDetailUVScale02 { get; set; }    //Float
        public Nullable<float> MicroDetailInfluence { get; set; }    //Float
        public string TintColorMask { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Nullable<float> TintScale { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public string Detailmap_Stretch { get; set; }    //rRef:ITexture
        public string Detailmap_Squash { get; set; }    //rRef:ITexture
        public string Bloodflow { get; set; }    //rRef:ITexture
        public Color BloodColor { get; set; }    //Color
        public string SkinProfile { get; set; }     //rRef:CSkinProfile
    }
    public partial class _skybox
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string DiffuseDayTime { get; set; }    //rRef:ITexture
        public string DiffuseNightTime { get; set; }    //rRef:ITexture
    }
    public partial class _speedtree_3d_v8_billboard
    {
        public string WindNoise { get; set; }    //rRef:ITexture
        public Nullable<float> WindLodFlags { get; set; }    //Float
        public Nullable<float> WindDataAvailable { get; set; }    //Float
        public Nullable<float> HorizontalBillboardsCount { get; set; }    //Float
        public Nullable<float> ContainsTopBillboard { get; set; }    //Float
        public Nullable<float> TreeCrownRadius { get; set; }    //Float
        public string DiffuseMap { get; set; }    //rRef:ITexture
        public string NormalMap { get; set; }    //rRef:ITexture
        public string TransGlossMap { get; set; }    //rRef:ITexture
        public string FoliageProfileMap { get; set; }    //rRef:ITexture
        public string FoliageProfile { get; set; }     //rRef:CFoliageProfile
        public Nullable<float> MeshTotalHeight { get; set; }    //Float
        public Nullable<float> ForceTerrainBlend { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
    }
    public partial class _speedtree_3d_v8_onesided
    {
        public string WindNoise { get; set; }    //rRef:ITexture
        public string BonesPositionsMap { get; set; }    //rRef:ITexture
        public string BonesAdditionalDataMap { get; set; }    //rRef:ITexture
        public Vec4 BoneMapData { get; set; }    //Vector4
        public Nullable<float> WindLodFlags { get; set; }    //Float
        public Nullable<float> WindDataAvailable { get; set; }    //Float
        public string DiffuseMap { get; set; }    //rRef:ITexture
        public string NormalMap { get; set; }    //rRef:ITexture
        public string TransGlossMap { get; set; }    //rRef:ITexture
        public string FoliageProfileMap { get; set; }    //rRef:ITexture
        public string FoliageProfile { get; set; }     //rRef:CFoliageProfile
        public Nullable<float> MeshTotalHeight { get; set; }    //Float
        public Nullable<float> ForceTerrainBlend { get; set; }    //Float
    }
    public partial class _speedtree_3d_v8_onesided_gradient_recolor
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Mask { get; set; }    //rRef:ITexture
        public string GradientMap { get; set; }    //rRef:ITexture
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _speedtree_3d_v8_seams
    {
        public string WindNoise { get; set; }    //rRef:ITexture
        public string BoneMap { get; set; }    //rRef:ITexture
        public string BonesPositionsMap { get; set; }    //rRef:ITexture
        public string BonesAdditionalDataMap { get; set; }    //rRef:ITexture
        public Vec4 BoneMapData { get; set; }    //Vector4
        public Nullable<float> WindLodFlags { get; set; }    //Float
        public Nullable<float> WindDataAvailable { get; set; }    //Float
        public string DiffuseMap { get; set; }    //rRef:ITexture
        public string NormalMap { get; set; }    //rRef:ITexture
        public string TransGlossMap { get; set; }    //rRef:ITexture
        public string FoliageProfileMap { get; set; }    //rRef:ITexture
        public string FoliageProfile { get; set; }     //rRef:CFoliageProfile
        public Nullable<float> MeshTotalHeight { get; set; }    //Float
        public Nullable<float> ForceTerrainBlend { get; set; }    //Float
    }
    public partial class _speedtree_3d_v8_twosided
    {
        public string WindNoise { get; set; }    //rRef:ITexture
        public string BoneMap { get; set; }    //rRef:ITexture
        public string BonesPositionsMap { get; set; }    //rRef:ITexture
        public string BonesAdditionalDataMap { get; set; }    //rRef:ITexture
        public Vec4 BoneMapData { get; set; }    //Vector4
        public Nullable<float> WindLodFlags { get; set; }    //Float
        public Nullable<float> WindDataAvailable { get; set; }    //Float
        public Nullable<float> TwosidedFlipN { get; set; }    //Float
        public string DiffuseMap { get; set; }    //rRef:ITexture
        public string NormalMap { get; set; }    //rRef:ITexture
        public string TransGlossMap { get; set; }    //rRef:ITexture
        public string FoliageProfileMap { get; set; }    //rRef:ITexture
        public string FoliageProfile { get; set; }     //rRef:CFoliageProfile
        public Nullable<float> MeshTotalHeight { get; set; }    //Float
        public Nullable<float> ForceTerrainBlend { get; set; }    //Float
    }
    public partial class _spline_deformed_metal_base
    {
        public Nullable<float> SplineLength { get; set; }    //Float
        public Nullable<float> SpanCount { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _terrain_simple
    {
        public Vec4 UVGenScaleOffset { get; set; }    //Vector4
        public string BaseColor { get; set; }    //rRef:ITexture
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public string MaskFoliage { get; set; }    //rRef:ITexture
    }
    public partial class _top_down_car_proxy_depth
    {
    }
    public partial class _trail_decal
    {
        public Nullable<float> DepthOffset { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _trail_decal_normal
    {
        public Nullable<float> DepthOffset { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _trail_decal_normal_color
    {
        public Nullable<float> DepthOffset { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> Roughness { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _transparent_liquid
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public Color ScatteringColorThin { get; set; }    //Color
        public Color ScatteringColorThick { get; set; }    //Color
        public Color Albedo { get; set; }    //Color
        public Nullable<float> IOR { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> SpecularStrengthMultiplier { get; set; }    //Float
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Nullable<float> ThicknessMultiplier { get; set; }    //Float
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> InterpolateFrames { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Vec4 NormalTilingAndScrolling { get; set; }    //Vector4
        public string Distort { get; set; }    //rRef:ITexture
        public Nullable<float> DistortAmount { get; set; }    //Float
        public Vec4 DistortTilingAndScrolling { get; set; }    //Vector4
        public string Mask { get; set; }    //rRef:ITexture
        public Nullable<float> EnableRowAnimation { get; set; }    //Float
        public Nullable<float> UseOnStaticMeshes { get; set; }    //Float
    }
    public partial class _underwater_blood
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> DebugTimeOverride { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public Nullable<float> StartDelayFrames { get; set; }    //Float
        public Nullable<float> SimulationAtlasFrameCountX { get; set; }    //Float
        public Nullable<float> SimulationAtlasFrameCountY { get; set; }    //Float
        public string SimulationAtlas { get; set; }    //rRef:ITexture
        public Nullable<float> SpeedExponent { get; set; }    //Float
        public Color ColorScale { get; set; }    //Color
        public Color ColorScale1 { get; set; }    //Color
        public Color ColorScale2 { get; set; }    //Color
        public Vec4 ColorGradientPositions { get; set; }    //Vector4
        public Nullable<float> ColorMode { get; set; }    //Float
    }
    public partial class _vehicle_destr_blendshape
    {
        public Nullable<float> DamageInfluence { get; set; }    //Float
        public Nullable<float> DamageInfluenceDebug { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> TextureTiling { get; set; }    //Float
        public string BakedNormal { get; set; }    //rRef:ITexture
        public string ScratchMask { get; set; }    //rRef:ITexture
        public string DirtMap { get; set; }    //rRef:ITexture
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; }     //rRef:Multilayer_Setup
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public Nullable<float> ScratchResistance { get; set; }    //Float
        public Nullable<float> DirtOpacity { get; set; }    //Float
        public Color DirtColor { get; set; }    //Color
        public Vec4 DirtMaskOffsets { get; set; }    //Vector4
        public Color CoatTintFwd { get; set; }    //Color
        public Color CoatTintSide { get; set; }    //Color
        public Nullable<float> CoatTintFresnelBias { get; set; }    //Float
        public Color CoatSpecularColor { get; set; }    //Color
        public Nullable<float> CoatFresnelBias { get; set; }    //Float
        public Nullable<float> CoatLayerMin { get; set; }    //Float
        public Nullable<float> CoatLayerMax { get; set; }    //Float
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public Nullable<float> SetupLayerMask { get; set; }    //Float
    }
    public partial class _vehicle_glass
    {
        public Nullable<float> UvTilingX { get; set; }    //Float
        public Nullable<float> UvTilingY { get; set; }    //Float
        public Nullable<float> UvOffsetX { get; set; }    //Float
        public Nullable<float> UvOffsetY { get; set; }    //Float
        public Nullable<float> DamageInfluence { get; set; }    //Float
        public Nullable<float> DamageInfluenceDebug { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> OpacityBackFace { get; set; }    //Float
        public string GlassTint { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Color TintSurface { get; set; }    //Color
        public Nullable<float> FrontFacesReflectionPower { get; set; }    //Float
        public Nullable<float> BackFacesReflectionPower { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public Color GlassSpecularColor { get; set; }    //Color
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Nullable<float> MaskRoughnessBias { get; set; }    //Float
        public Nullable<float> UseDamageGrid { get; set; }    //Float
        public Nullable<float> UseShatterPoints { get; set; }    //Float
        public Color ShatterColor { get; set; }    //Color
        public string ShatterTexture { get; set; }    //rRef:ITexture
        public string ShatterNormal { get; set; }    //rRef:ITexture
        public Nullable<float> ShatterNormalStrength { get; set; }    //Float
        public Nullable<float> ShatterRadiusScale { get; set; }    //Float
        public Nullable<float> ShatterAspectRatio { get; set; }    //Float
        public Nullable<float> ShatterCutout { get; set; }    //Float
        public Nullable<float> DamageGridCutout { get; set; }    //Float
        public Vec4 DebugShatterPoint0 { get; set; }    //Vector4
        public string Cracks { get; set; }    //rRef:ITexture
        public Nullable<float> CracksTiling { get; set; }    //Float
        public string DotsNormalTxt { get; set; }    //rRef:ITexture
        public string DotsTxt { get; set; }    //rRef:ITexture
        public string FlowTxt { get; set; }    //rRef:ITexture
        public string WiperMask { get; set; }    //rRef:ITexture
    }
    public partial class _vehicle_glass_proxy
    {
        public Nullable<float> UvTilingX { get; set; }    //Float
        public Nullable<float> UvTilingY { get; set; }    //Float
        public Nullable<float> UvOffsetX { get; set; }    //Float
        public Nullable<float> UvOffsetY { get; set; }    //Float
        public string GlassTint { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Nullable<float> FrontFacesReflectionPower { get; set; }    //Float
        public Color GlassSpecularColor { get; set; }    //Color
    }
    public partial class _vehicle_lights
    {
        public Nullable<float> UvTilingX { get; set; }    //Float
        public Nullable<float> UvTilingY { get; set; }    //Float
        public Nullable<float> UvOffsetX { get; set; }    //Float
        public Nullable<float> UvOffsetY { get; set; }    //Float
        public Nullable<float> DamageInfluence { get; set; }    //Float
        public Nullable<float> DamageInfluenceDebug { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Nullable<float> EmissionTiling { get; set; }    //Float
        public Nullable<float> EmissionParallax { get; set; }    //Float
        public Nullable<float> Zone0EmissiveEV { get; set; }    //Float
        public Nullable<float> Zone1EmissiveEV { get; set; }    //Float
        public Nullable<float> Zone2EmissiveEV { get; set; }    //Float
        public Nullable<float> Zone3EmissiveEV { get; set; }    //Float
        public Vec4 DebugLightsIntensity { get; set; }    //Vector4
        public Color DebugLightsColor0 { get; set; }    //Color
        public Color DebugLightsColor1 { get; set; }    //Color
        public Color DebugLightsColor2 { get; set; }    //Color
        public Color DebugLightsColor3 { get; set; }    //Color
    }
    public partial class _vehicle_mesh_decal
    {
        public Nullable<float> DamageInfluence { get; set; }    //Float
        public Nullable<float> DamageInfluenceDebug { get; set; }    //Float
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string GradientMap { get; set; }    //rRef:ITexture
        public Nullable<float> UseGradientMap { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public Nullable<float> NormalsBlendingMode { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> DepthThreshold { get; set; }    //Float
        public string DirtMap { get; set; }    //rRef:ITexture
        public Nullable<float> DirtOpacity { get; set; }    //Float
        public Vec4 DirtMaskOffsets { get; set; }    //Vector4
    }
    public partial class _ver_mov
    {
        public Nullable<float> IsControlledByDestruction { get; set; }    //Float
        public string vertex_paint_tex { get; set; }    //rRef:ITexture
        public Nullable<float> trans_min { get; set; }    //Float
        public Nullable<float> trans_max { get; set; }    //Float
        public Nullable<float> rot_min { get; set; }    //Float
        public Nullable<float> rot_max { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> n_pieces { get; set; }    //Float
        public Nullable<float> play_time { get; set; }    //Float
        public Nullable<float> debug_familys { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public Nullable<float> YAxisUp { get; set; }    //Float
        public Nullable<float> z_min { get; set; }    //Float
        public Nullable<float> ground_offset { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Metalness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _ver_mov_glass
    {
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> OpacityBackFace { get; set; }    //Float
        public Nullable<float> UvTilingX { get; set; }    //Float
        public Nullable<float> UvTilingY { get; set; }    //Float
        public Nullable<float> UvOffsetX { get; set; }    //Float
        public Nullable<float> UvOffsetY { get; set; }    //Float
        public Vec4 RoughnessTileAndOffset { get; set; }    //Vector4
        public Vec4 NormalTileAndOffset { get; set; }    //Vector4
        public Vec4 GlassTintTileAndOffset { get; set; }    //Vector4
        public string vertex_paint_tex { get; set; }    //rRef:ITexture
        public Nullable<float> IsControlledByDestruction { get; set; }    //Float
        public Nullable<float> trans_min { get; set; }    //Float
        public Nullable<float> trans_max { get; set; }    //Float
        public Nullable<float> rot_min { get; set; }    //Float
        public Nullable<float> rot_max { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> n_pieces { get; set; }    //Float
        public Nullable<float> play_time { get; set; }    //Float
        public Nullable<float> debug_familys { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public Nullable<float> YAxisUp { get; set; }    //Float
        public Nullable<float> z_min { get; set; }    //Float
        public Nullable<float> ground_offset { get; set; }    //Float
        public string GlassTint { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Nullable<float> TintFromVertexPaint { get; set; }    //Float
        public Nullable<float> FrontFacesReflectionPower { get; set; }    //Float
        public Nullable<float> BackFacesReflectionPower { get; set; }    //Float
        public Nullable<float> IOR { get; set; }    //Float
        public Nullable<float> RefractionDepth { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public Color GlassSpecularColor { get; set; }    //Color
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> NormalMapAffectsSpecular { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Nullable<float> GlassRoughnessBias { get; set; }    //Float
        public Nullable<float> MaskRoughnessBias { get; set; }    //Float
        public Nullable<float> BlurRadius { get; set; }    //Float
        public Nullable<float> BlurByRoughness { get; set; }    //Float
    }
    public partial class _ver_mov_multilayered
    {
        public string vertex_paint_tex { get; set; }    //rRef:ITexture
        public Nullable<float> IsControlledByDestruction { get; set; }    //Float
        public Nullable<float> trans_min { get; set; }    //Float
        public Nullable<float> trans_max { get; set; }    //Float
        public Nullable<float> rot_min { get; set; }    //Float
        public Nullable<float> rot_max { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> n_pieces { get; set; }    //Float
        public Nullable<float> play_time { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public Nullable<float> z_min { get; set; }    //Float
        public Nullable<float> ground_offset { get; set; }    //Float
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; }     //rRef:Multilayer_Setup
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public Nullable<float> SetupLayerMask { get; set; }    //Float
    }
    public partial class _ver_skinned_mov
    {
        public string vertex_paint_tex { get; set; }    //rRef:ITexture
        public string vertex_paint_tex_z { get; set; }    //rRef:ITexture
        public Nullable<float> trans_min { get; set; }    //Float
        public Nullable<float> trans_max { get; set; }    //Float
        public Nullable<float> rot_min { get; set; }    //Float
        public Nullable<float> rot_max { get; set; }    //Float
        public Nullable<float> buffer_offset { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> n_pieces { get; set; }    //Float
        public Nullable<float> play_time { get; set; }    //Float
        public Nullable<float> debug_familys { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public Nullable<float> YAxisUp { get; set; }    //Float
        public Nullable<float> z_multiply { get; set; }    //Float
        public Nullable<float> ground_offset { get; set; }    //Float
        public Vec4 bounds_and_pivot { get; set; }    //Vector4
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public string FoliageProfileMap { get; set; }    //rRef:ITexture
        public string FoliageProfile { get; set; }     //rRef:CFoliageProfile
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _ver_skinned_mov_parade
    {
        public string vertex_paint_tex { get; set; }    //rRef:ITexture
        public Nullable<float> trans_min { get; set; }    //Float
        public Nullable<float> trans_max { get; set; }    //Float
        public Nullable<float> rot_min { get; set; }    //Float
        public Nullable<float> rot_max { get; set; }    //Float
        public Nullable<float> n_frames { get; set; }    //Float
        public Nullable<float> n_pieces { get; set; }    //Float
        public Nullable<float> frame_rate { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _window_interior_uv
    {
        public string Glass { get; set; }    //rRef:ITexture
        public Nullable<float> LightIntensity { get; set; }    //Float
        public Color LightColor { get; set; }    //Color
        public Color GlassColor { get; set; }    //Color
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalScale { get; set; }    //Float
        public Nullable<float> RoomHeight { get; set; }    //Float
        public Nullable<float> RoomWidth { get; set; }    //Float
        public Vec4 TextureTiling { get; set; }    //Vector4
        public Color CeilFloorColor { get; set; }    //Color
        public Color WallColor { get; set; }    //Color
        public string Ceiling { get; set; }    //rRef:ITexture
        public string WallsXY { get; set; }    //rRef:ITexture
        public string WallsZY { get; set; }    //rRef:ITexture
        public string Floor { get; set; }    //rRef:ITexture
    }
    public partial class _window_parallax_interior
    {
        public string RoomAtlas { get; set; }    //rRef:ITexture
        public string LayerAtlas { get; set; }    //rRef:ITexture
        public string Curtain { get; set; }    //rRef:ITexture
        public string ColorOverlayTexture { get; set; }    //rRef:ITexture
        public Vec4 AtlasGridUvRatio { get; set; }    //Vector4
        public Nullable<float> AtlasDepth { get; set; }    //Float
        public Nullable<float> roomWidth { get; set; }    //Float
        public Nullable<float> roomHeight { get; set; }    //Float
        public Nullable<float> roomDepth { get; set; }    //Float
        public Nullable<float> positionXoffset { get; set; }    //Float
        public Nullable<float> positionYoffset { get; set; }    //Float
        public Nullable<float> scaleXrandomization { get; set; }    //Float
        public Nullable<float> positionXrandomization { get; set; }    //Float
        public Nullable<float> LayerDepth { get; set; }    //Float
        public Nullable<float> CurtainDepth { get; set; }    //Float
        public Nullable<float> CurtainMaxCover { get; set; }    //Float
        public Nullable<float> CurtainCoverRandomize { get; set; }    //Float
        public Nullable<float> CurtainAlpha { get; set; }    //Float
        public Nullable<float> LightsTempVariationAtNight { get; set; }    //Float
        public Nullable<float> AmountTurnOffAtNight { get; set; }    //Float
        public string WindowTexture { get; set; }    //rRef:ITexture
        public Color TintColorAtNight { get; set; }    //Color
        public string Roughness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _window_parallax_interior_proxy
    {
        public string RoomAtlas { get; set; }    //rRef:ITexture
        public string Curtain { get; set; }    //rRef:ITexture
        public string ColorOverlayTexture { get; set; }    //rRef:ITexture
        public Vec4 AtlasGridUvRatio { get; set; }    //Vector4
        public Nullable<float> AtlasDepth { get; set; }    //Float
        public Nullable<float> roomWidth { get; set; }    //Float
        public Nullable<float> roomHeight { get; set; }    //Float
        public Nullable<float> roomDepth { get; set; }    //Float
        public Nullable<float> positionXoffset { get; set; }    //Float
        public Nullable<float> positionYoffset { get; set; }    //Float
        public Nullable<float> scaleXrandomization { get; set; }    //Float
        public Nullable<float> positionXrandomization { get; set; }    //Float
        public Nullable<float> LightsTempVariationAtNight { get; set; }    //Float
        public Nullable<float> CurtainDepth { get; set; }    //Float
        public Nullable<float> CurtainMaxCover { get; set; }    //Float
        public Nullable<float> CurtainCoverRandomize { get; set; }    //Float
        public Nullable<float> CurtainAlpha { get; set; }    //Float
        public Nullable<float> AmountTurnOffAtNight { get; set; }    //Float
        public Color TintColorAtNight { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
    }
    public partial class _window_parallax_interior_proxy_buffer
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _window_very_long_distance
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public string Mask { get; set; }    //rRef:ITexture
        public string ColorOverlayTexture { get; set; }    //rRef:ITexture
        public string WorldHeightMap { get; set; }    //rRef:ITexture
        public string WorldColorMap { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> WindowsSize { get; set; }    //Float
        public Nullable<float> Saturation { get; set; }    //Float
        public Nullable<float> TurnedOff { get; set; }    //Float
        public Nullable<float> FadeStart { get; set; }    //Float
        public Nullable<float> FadeEnd { get; set; }    //Float
        public Nullable<float> LightsFadeStart { get; set; }    //Float
        public Nullable<float> LightsFadeEnd { get; set; }    //Float
        public Nullable<float> LightsIntensityMultiplier { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
    }
    public partial class _worldspace_grid
    {
        public Nullable<float> GridScale { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public Nullable<float> EnableWorldSpace { get; set; }    //Float
        public Nullable<float> AbsoluteWorldSpace { get; set; }    //Float
    }
    public partial class _bink_simple
    {
        public Color ColorScale { get; set; }    //Color
        public string VideoCanvasName { get; set; }     //CName
        public string BinkY { get; set; }    //rRef:ITexture
        public string BinkCR { get; set; }    //rRef:ITexture
        public string BinkCB { get; set; }    //rRef:ITexture
        public string BinkA { get; set; }    //rRef:ITexture
        public DataBuffer BinkParams { get; set; }
    }
    public partial class _cable_strip
    {
        public Nullable<float> CableWidth { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _debugdraw_bias
    {
    }
    public partial class _debugdraw_wireframe
    {
    }
    public partial class _debugdraw_wireframe_bias
    {
    }
    public partial class _debug_coloring
    {
    }
    public partial class _font
    {
    }
    public partial class _global_water_patch
    {
        public string WaterFFT { get; set; }    //rRef:ITexture
        public string WaterMap { get; set; }    //rRef:ITexture
        public Nullable<float> WaterMapWeight { get; set; }    //Float
        public Nullable<float> WaterSize { get; set; }    //Float
        public Nullable<float> ShoreThreshold { get; set; }    //Float
        public Nullable<float> ShoreOffset { get; set; }    //Float
        public Vec4 Choppiness { get; set; }    //Vector4
        public Nullable<float> ScatteringDepth { get; set; }    //Float
        public Nullable<float> NormalDetailScale { get; set; }    //Float
        public Nullable<float> NormalDetailIntensity { get; set; }    //Float
        public Nullable<float> ScatteringSunRadius { get; set; }    //Float
        public Nullable<float> ScatteringSunIntensity { get; set; }    //Float
        public Color ScatteringColor { get; set; }    //Color
        public Nullable<float> BlurRadius { get; set; }    //Float
        public Nullable<float> ScatteringSlopeThreshold { get; set; }    //Float
        public Nullable<float> ScatteringSlopeIntensity { get; set; }    //Float
        public Nullable<float> WaterOpacity { get; set; }    //Float
        public Nullable<float> IndexOfRefraction { get; set; }    //Float
        public Nullable<float> RefractionNormalIntensity { get; set; }    //Float
        public Nullable<float> BlurStrength { get; set; }    //Float
        public string FoamTexture { get; set; }    //rRef:ITexture
        public Color FoamColor { get; set; }    //Color
        public Nullable<float> FoamSize { get; set; }    //Float
        public Nullable<float> FoamThreshold { get; set; }    //Float
        public Nullable<float> FoamIntensity { get; set; }    //Float
        public Nullable<float> EdgeBlend { get; set; }    //Float
    }
    public partial class _metal_base_animated_uv
    {
        public Nullable<float> UvPanningSpeedX { get; set; }    //Float
        public Nullable<float> UvPanningSpeedY { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveLift { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _metal_base_blendable
    {
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; }    //Float
        public Nullable<float> FadeOutOffset { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffset { get; set; }    //Float
        public Color FresnelColor { get; set; }    //Color
        public Nullable<float> FresnelColorIntensity { get; set; }    //Float
        public Nullable<float> FresnelExponent { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveLift { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _metal_base_fence
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _metal_base_garment
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _metal_base_packed
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string RoughMetal { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _metal_base_proxy
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public string WorldColorMap { get; set; }    //rRef:ITexture
        public string WorldHeightMap { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> FadeStart { get; set; }    //Float
        public Nullable<float> FadeEnd { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveLift { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _multilayered
    {
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; }     //rRef:Multilayer_Setup
        public Nullable<float> GlobalNormalIntensity { get; set; }    //Float
        public Vec4 GlobalNormalUVScale { get; set; }    //Vector4
        public Vec4 GlobalNormalUVBias { get; set; }    //Vector4
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public Nullable<float> SetupLayerMask { get; set; }    //Float
    }
    public partial class _multilayered_debug
    {
    }
    public partial class _pbr_simple
    {
        public Color Color { get; set; }    //Color
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> Metalness { get; set; }    //Float
    }
    public partial class _shadows_debug
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _transparent_notxaa_2
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
    }
    public partial class _ui_default_element
    {
    }
    public partial class _ui_default_nine_slice_element
    {
    }
    public partial class _ui_default_tile_element
    {
    }
    public partial class _ui_effect_box_blur
    {
    }
    public partial class _ui_effect_color_correction
    {
    }
    public partial class _ui_effect_color_fill
    {
    }
    public partial class _ui_effect_glitch
    {
    }
    public partial class _ui_effect_inner_glow
    {
    }
    public partial class _ui_effect_light_sweep
    {
    }
    public partial class _ui_effect_linear_wipe
    {
    }
    public partial class _ui_effect_mask
    {
    }
    public partial class _ui_effect_point_cloud
    {
    }
    public partial class _ui_effect_radial_wipe
    {
    }
    public partial class _ui_effect_swipe
    {
    }
    public partial class _ui_element_depth_texture
    {
    }
    public partial class _ui_panel
    {
        public string CameraName { get; set; }     //CName
    }
    public partial class _ui_text_element
    {
        public Nullable<float> hackParameterForUiBatcher { get; set; }    //Float
    }
    public partial class _alphablend_glass
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Vec4 TextureScaling { get; set; }    //Vector4
        public Nullable<float> InterlaceScale { get; set; }    //Float
        public Nullable<float> InterlaceIntensityLow { get; set; }    //Float
        public Nullable<float> InterlaceIntensityHigh { get; set; }    //Float
        public Nullable<float> UVdivisions { get; set; }    //Float
        public Nullable<float> UVoffset { get; set; }    //Float
        public Nullable<float> Emissive { get; set; }    //Float
    }
    public partial class _alpha_control_refraction
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string RefractionMap { get; set; }    //rRef:ITexture
        public string RecolorMap { get; set; }    //rRef:ITexture
        public Nullable<float> RefractionAmount { get; set; }    //Float
        public Nullable<float> RefractionSpeed { get; set; }    //Float
        public Nullable<float> JerkingSpeed { get; set; }    //Float
        public Nullable<float> JerkingAmount { get; set; }    //Float
        public Nullable<float> MaxAlpha { get; set; }    //Float
        public Nullable<float> RecolorAmount { get; set; }    //Float
        public Nullable<float> RecolorMultiplier { get; set; }    //Float
        public Color SpecularColor { get; set; }    //Color
    }
    public partial class _animated_decal
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseAlpha { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public string RevealMasks { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> AnimationFramesWidth { get; set; }    //Float
        public Nullable<float> AnimationFramesHeight { get; set; }    //Float
        public Nullable<float> FloatParam { get; set; }    //Float
    }
    public partial class _beam_particles
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string MainTexture { get; set; }    //rRef:ITexture
        public string AdditionalMask { get; set; }    //rRef:ITexture
        public Nullable<float> UseMaskROrA { get; set; }    //Float
        public string AdditionalMaskFlowmap { get; set; }    //rRef:ITexture
        public Color MainColor { get; set; }    //Color
        public Nullable<float> ColorMultiplier { get; set; }    //Float
        public Nullable<float> TextureScale { get; set; }    //Float
        public Nullable<float> TextureStretch { get; set; }    //Float
        public Nullable<float> TextureHasNoAlpha { get; set; }    //Float
        public Nullable<float> BlackbodyOrColor { get; set; }    //Float
        public Vec4 FlowmapControl { get; set; }    //Vector4
        public Vec4 AdditionalMaskControl { get; set; }    //Vector4
        public Nullable<float> FlowmapMultiplier { get; set; }    //Float
        public Nullable<float> TextureHasAlpha { get; set; }    //Float
    }
    public partial class _blackbodyradiation
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> Temperature { get; set; }    //Float
        public Nullable<float> subUVWidth { get; set; }    //Float
        public Nullable<float> AlphaExponent { get; set; }    //Float
        public Nullable<float> subUVHeight { get; set; }    //Float
        public Nullable<float> ScatterAmount { get; set; }    //Float
        public Nullable<float> ScatterPower { get; set; }    //Float
        public string FireScatterAlpha { get; set; }    //rRef:ITexture
        public Nullable<float> HueShift { get; set; }    //Float
        public Nullable<float> HueSpread { get; set; }    //Float
        public Nullable<float> maxAlpha { get; set; }    //Float
        public Color LightSmoke { get; set; }    //Color
        public Color DarkSmoke { get; set; }    //Color
        public Nullable<float> ExpensiveBlending { get; set; }    //Float
        public Nullable<float> Saturation { get; set; }    //Float
        public Nullable<float> SoftAlpha { get; set; }    //Float
        public Nullable<float> MultiplierExponent { get; set; }    //Float
        public Vec4 TexCoordDtortScale { get; set; }    //Vector4
        public Vec4 TexCoordDtortSpeed { get; set; }    //Vector4
        public string Distort { get; set; }    //rRef:ITexture
        public Nullable<float> NoAlphaOnTexture { get; set; }    //Float
        public Nullable<float> EatUpOrStraightAlpha { get; set; }    //Float
        public Nullable<float> DistortAmount { get; set; }    //Float
        public Nullable<float> EnableRowAnimation { get; set; }    //Float
        public Nullable<float> DoNotApplyLighting { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public Nullable<float> InvertMask { get; set; }    //Float
        public Vec4 MaskTilingAndSpeed { get; set; }    //Vector4
        public Nullable<float> MaskIntensity { get; set; }    //Float
        public Nullable<float> UseVertexAlpha { get; set; }    //Float
        public Nullable<float> DotWithLookAt { get; set; }    //Float
    }
    public partial class _blackbody_simple
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string TemperatureTexture { get; set; }    //rRef:ITexture
        public Nullable<float> Temperature { get; set; }    //Float
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> SoftAlpha { get; set; }    //Float
    }
    public partial class _blood_transparent
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color ColorThin { get; set; }    //Color
        public Color ColorThick { get; set; }    //Color
        public Nullable<float> BloodThickness { get; set; }    //Float
        public Nullable<float> LightingBleeding { get; set; }    //Float
        public Nullable<float> SpecularPower { get; set; }    //Float
        public Nullable<float> SpecularMultiplier { get; set; }    //Float
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> CurrentFrame { get; set; }    //Float
        public string NormalAndDensity { get; set; }    //rRef:ITexture
        public string VelocityMap { get; set; }    //rRef:ITexture
        public string SpecularMap { get; set; }    //rRef:ITexture
        public Nullable<float> FlowmapStrength { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> NormalPow { get; set; }    //Float
        public Nullable<float> EVCompensation { get; set; }    //Float
    }
    public partial class _braindance_fog
    {
        public Nullable<float> BrightnessNear { get; set; }    //Float
        public Nullable<float> BrightnessFar { get; set; }    //Float
        public string RevealMask { get; set; }    //rRef:ITexture
        public Nullable<float> RevealMaskFramesY { get; set; }    //Float
        public Vec4 RevealMaskBoundsMin { get; set; }    //Vector4
        public Vec4 RevealMaskBoundsMax { get; set; }    //Vector4
        public Nullable<float> TonemapExposure { get; set; }    //Float
        public Nullable<float> FarFogBrightness { get; set; }    //Float
        public Nullable<float> FarFogDistance { get; set; }    //Float
        public Nullable<float> UseHack_SQ021 { get; set; }    //Float
        public string CluesMap { get; set; }    //rRef:ITexture
        public Nullable<float> CluesBrightness { get; set; }    //Float
        public Nullable<float> UseClueDepthClipping { get; set; }    //Float
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; }    //Float
        public Nullable<float> VectorFieldTiling { get; set; }    //Float
        public Nullable<float> VectorFieldAnimSpeed { get; set; }    //Float
        public Nullable<float> VectorFieldStrength { get; set; }    //Float
    }
    public partial class _braindance_particle_thermal
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> Brightness { get; set; }    //Float
        public string FireScatterAlpha { get; set; }    //rRef:ITexture
        public Nullable<float> subUVWidth { get; set; }    //Float
        public Nullable<float> subUVHeight { get; set; }    //Float
        public Nullable<float> AlphaExponent { get; set; }    //Float
        public Nullable<float> maxAlpha { get; set; }    //Float
        public Nullable<float> EatUpOrStraightAlpha { get; set; }    //Float
        public Nullable<float> SoftAlpha { get; set; }    //Float
        public Nullable<float> UseVertexAlpha { get; set; }    //Float
    }
    public partial class _cloak
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Distortion { get; set; }    //rRef:ITexture
        public Vec4 DistortionUVScale { get; set; }    //Vector4
        public Nullable<float> DistortionVisibility { get; set; }    //Float
        public string IridescenceMask { get; set; }    //rRef:ITexture
        public Nullable<float> IridescenceSpeed { get; set; }    //Float
        public Nullable<float> IridescenceDim { get; set; }    //Float
        public Color Tinge { get; set; }    //Color
        public string DirtMask { get; set; }    //rRef:ITexture
        public Vec4 DirtMaskScaleAndOffset { get; set; }    //Vector4
        public Nullable<float> DirtMaskPower { get; set; }    //Float
        public Nullable<float> DirtMaskMultiplier { get; set; }    //Float
        public Color DirtColor { get; set; }    //Color
        public Nullable<float> UseOutline { get; set; }    //Float
        public Nullable<float> OutlineOpacity { get; set; }    //Float
        public Nullable<float> OutlineSize { get; set; }    //Float
    }
    public partial class _cyberspace_pixelsort_stencil
    {
        public Nullable<float> CameraOffsetZ { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
    }
    public partial class _cyberspace_pixelsort_stencil_0
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
    }
    public partial class _cyberware_animation
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string EmissiveMask { get; set; }    //rRef:ITexture
        public Nullable<float> UseTimeOrFloatParam { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
    }
    public partial class _damage_indicator
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Mask { get; set; }    //rRef:ITexture
        public string Noise { get; set; }    //rRef:ITexture
        public Nullable<float> DoubleDistortWithNoise { get; set; }    //Float
        public string Scanline { get; set; }    //rRef:ITexture
        public Vec4 NoiseScailingAndSpeed { get; set; }    //Vector4
        public Nullable<float> MinMaskExponent { get; set; }    //Float
        public Nullable<float> MaxMaskExponent { get; set; }    //Float
        public Nullable<float> MaskMultiplier { get; set; }    //Float
        public Color ThickScanlinesColor { get; set; }    //Color
        public Color ThinScanlinesColor { get; set; }    //Color
        public Nullable<float> ScanlineDensity { get; set; }    //Float
        public Nullable<float> ScanlineMinimumValue { get; set; }    //Float
        public Nullable<float> ThickScanlineMultiplier { get; set; }    //Float
        public Nullable<float> ThinScanlineExponent { get; set; }    //Float
        public Nullable<float> ThinScanlineMultiplier { get; set; }    //Float
        public Nullable<float> RefractionOffsetStrength { get; set; }    //Float
    }
    public partial class _device_diode
    {
        public Nullable<float> NormalOffset { get; set; }    //Float
        public Nullable<float> VehicleDamageInfluence { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> Blinking { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> BlinkingSpeed { get; set; }    //Float
        public Nullable<float> UseMaterialParameter { get; set; }    //Float
        public Color EmissiveColor1 { get; set; }    //Color
        public Color EmissiveColor2 { get; set; }    //Color
        public Nullable<float> EmissiveInitialState { get; set; }    //Float
        public Nullable<float> UseTwoEmissiveColors { get; set; }    //Float
        public Nullable<float> SwitchingTwoEmissiveColorsSpeed { get; set; }    //Float
        public Nullable<float> UseFresnel { get; set; }    //Float
    }
    public partial class _device_diode_multi_state
    {
        public Nullable<float> NormalOffset { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Emissive { get; set; }    //rRef:ITexture
        public Color EmissiveColor1 { get; set; }    //Color
        public Color EmissiveColor2 { get; set; }    //Color
        public Color EmissiveColor3 { get; set; }    //Color
        public Color EmissiveColor4 { get; set; }    //Color
        public Nullable<float> EmissiveColorSelector { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> Blinking { get; set; }    //Float
        public Nullable<float> BlinkingSpeed { get; set; }    //Float
        public Nullable<float> UseMaterialParameter { get; set; }    //Float
        public Nullable<float> EmissiveInitialState { get; set; }    //Float
    }
    public partial class _diode_pavements
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Nullable<float> Metalness { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public string DiodesMask { get; set; }    //rRef:ITexture
        public string SignTexture { get; set; }    //rRef:ITexture
        public Vec4 DiodesTilingAndScrollSpeed { get; set; }    //Vector4
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> UseMaskAsAlphaThreshold { get; set; }    //Float
        public Nullable<float> AmountOfGlitch { get; set; }    //Float
        public Nullable<float> GlitchSpeed { get; set; }    //Float
        public Nullable<float> NumberOfRows { get; set; }    //Float
        public Nullable<float> DisplayRow { get; set; }    //Float
        public Vec4 BaseColorRoughnessTiling { get; set; }    //Vector4
    }
    public partial class _drugged_sobel
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color DarkColor { get; set; }    //Color
        public Color BrightColor { get; set; }    //Color
        public Nullable<float> DarkColorPower { get; set; }    //Float
        public Nullable<float> KernelOffset { get; set; }    //Float
        public Nullable<float> UseInEngineSobel { get; set; }    //Float
    }
    public partial class _emissive_basic_transparent
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public string Mask { get; set; }    //rRef:ITexture
        public string AnimMask { get; set; }    //rRef:ITexture
        public Color EmissiveColor { get; set; }    //Color
    }
    public partial class _fog_laser
    {
        public Nullable<float> AdditionalThicnkess { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> TimeScale { get; set; }    //Float
        public string NoiseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DetailNoiseScale { get; set; }    //Float
        public Nullable<float> DetailNoiseBrighten { get; set; }    //Float
        public Nullable<float> GeneralNoiseScale { get; set; }    //Float
        public Color LaserColor { get; set; }    //Color
        public Nullable<float> SmokeExponent { get; set; }    //Float
        public Nullable<float> SmokeMultiplier { get; set; }    //Float
        public Nullable<float> LineThreshold { get; set; }    //Float
        public Nullable<float> LineMultiplier { get; set; }    //Float
        public Nullable<float> LineAddOrSubtract { get; set; }    //Float
        public Nullable<float> UseSoftAlpha { get; set; }    //Float
        public Nullable<float> SoftAlpha { get; set; }    //Float
        public Nullable<float> SoftAlphaMultiplier { get; set; }    //Float
        public Nullable<float> HorizontalGradientMultiplier { get; set; }    //Float
        public Nullable<float> FlipEdgeFade { get; set; }    //Float
        public Nullable<float> UseVertexColor { get; set; }    //Float
        public Nullable<float> TextureRatioU { get; set; }    //Float
        public Nullable<float> TextureRatioV { get; set; }    //Float
        public Nullable<float> IntensiveCore { get; set; }    //Float
        public Nullable<float> RotateUV { get; set; }    //Float
        public string VectorField { get; set; }    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; }    //Float
        public Nullable<float> UseWorldSpace { get; set; }    //Float
    }
    public partial class _hologram
    {
        public Vec4 ScaleReferencePosAndScale { get; set; }    //Vector4
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> OpaqueScanlineDensity { get; set; }    //Float
        public string Scanline { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public string DotsTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DotsSize { get; set; }    //Float
        public Color DotsColor { get; set; }    //Color
        public Vec4 Projector1Position { get; set; }    //Vector4
        public Color SurfaceColor { get; set; }    //Color
        public Color SurfaceShadows { get; set; }    //Color
        public Color FallofColor { get; set; }    //Color
        public string Diffuse { get; set; }    //rRef:ITexture
        public Nullable<float> GradientOffset { get; set; }    //Float
        public Nullable<float> GradientLength { get; set; }    //Float
        public Nullable<float> FresnelStrength { get; set; }    //Float
        public Nullable<float> DotsFresnelStrength { get; set; }    //Float
        public Nullable<float> GlowStrength { get; set; }    //Float
        public Nullable<float> DesaturationStrength { get; set; }    //Float
        public Nullable<float> FlickerThreshold { get; set; }    //Float
        public Nullable<float> FlickerChance { get; set; }    //Float
        public Nullable<float> ArtifactsChance { get; set; }    //Float
        public Nullable<float> LightBleed { get; set; }    //Float
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> ScreenSpaceFlicker { get; set; }    //Float
        public Nullable<float> UseIsobars { get; set; }    //Float
        public Nullable<float> EntropyThreshold { get; set; }    //Float
        public Nullable<float> UseMovingDots { get; set; }    //Float
        public Nullable<float> IsHair { get; set; }    //Float
        public Nullable<float> ScanlineThickness { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> GlobalTint { get; set; }    //Float
        public Nullable<float> SampledOrProceduralDots { get; set; }    //Float
        public Nullable<float> FullColorOrGrayscale { get; set; }    //Float
    }
    public partial class _hologram_two_sided
    {
        public Vec4 ScaleReferencePosAndScale { get; set; }    //Vector4
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string Diffuse { get; set; }    //rRef:ITexture
        public string Scanline { get; set; }    //rRef:ITexture
        public string DotsTexture { get; set; }    //rRef:ITexture
        public Vec4 Projector1Position { get; set; }    //Vector4
        public Nullable<float> OpaqueScanlineDensity { get; set; }    //Float
        public Nullable<float> DotsSize { get; set; }    //Float
        public Color DotsColor { get; set; }    //Color
        public Color SurfaceColor { get; set; }    //Color
        public Color SurfaceShadows { get; set; }    //Color
        public Color FallofColor { get; set; }    //Color
        public Nullable<float> GradientOffset { get; set; }    //Float
        public Nullable<float> GradientLength { get; set; }    //Float
        public Nullable<float> FresnelStrength { get; set; }    //Float
        public Nullable<float> DotsFresnelStrength { get; set; }    //Float
        public Nullable<float> GlowStrength { get; set; }    //Float
        public Nullable<float> DesaturationStrength { get; set; }    //Float
        public Nullable<float> FlickerThreshold { get; set; }    //Float
        public Nullable<float> FlickerChance { get; set; }    //Float
        public Nullable<float> ArtifactsChance { get; set; }    //Float
        public Nullable<float> LightBleed { get; set; }    //Float
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> ScreenSpaceFlicker { get; set; }    //Float
        public Nullable<float> UseIsobars { get; set; }    //Float
        public Nullable<float> EntropyThreshold { get; set; }    //Float
        public Nullable<float> UseMovingDots { get; set; }    //Float
        public Nullable<float> IsHair { get; set; }    //Float
        public Nullable<float> ScanlineThickness { get; set; }    //Float
        public Nullable<float> Opacity { get; set; }    //Float
        public Nullable<float> GlobalTint { get; set; }    //Float
        public Nullable<float> SampledOrProceduralDots { get; set; }    //Float
        public Nullable<float> FullColorOrGrayscale { get; set; }    //Float
    }
    public partial class _holo_projections
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> ColorMultiply { get; set; }    //Float
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> BrightnessNoiseStreght { get; set; }    //Float
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> FrameNum { get; set; }    //Float
        public Nullable<float> PlaySpeed { get; set; }    //Float
        public Nullable<float> InvertSoftAlpha { get; set; }    //Float
        public Vec4 UVScrollSpeed { get; set; }    //Vector4
        public Nullable<float> ScrollStepFactor { get; set; }    //Float
        public Nullable<float> ScrollMaskOrTexture { get; set; }    //Float
        public Nullable<float> RandomAnimation { get; set; }    //Float
        public Nullable<float> RandomFrameFrequency { get; set; }    //Float
        public Nullable<float> RandomFrameChangeSpeed { get; set; }    //Float
        public Nullable<float> FrameNumDisplayChance { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public string ScrollingMaskTexture { get; set; }    //rRef:ITexture
    }
    public partial class _hud_focus_mode_scanline
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> Progress { get; set; }    //Float
        public Nullable<float> vProgress { get; set; }    //Float
        public Nullable<float> ScanlineDensity { get; set; }    //Float
        public Nullable<float> ScanlineOffset { get; set; }    //Float
        public Nullable<float> ScanlineWidth { get; set; }    //Float
        public Nullable<float> EffectIntensity { get; set; }    //Float
        public Nullable<float> ScanlineDensityVertical { get; set; }    //Float
        public Nullable<float> ScanlineOffsetVertical { get; set; }    //Float
        public Nullable<float> ScanlineWidthVertical { get; set; }    //Float
        public Nullable<float> VerticalIntensity { get; set; }    //Float
        public Nullable<float> BarsWidth { get; set; }    //Float
        public Nullable<float> SideFadeWidth { get; set; }    //Float
        public Nullable<float> SideFadeFeather { get; set; }    //Float
    }
    public partial class _hud_markers_notxaa
    {
        public string Diffuse { get; set; }    //rRef:ITexture
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Color Second_Color { get; set; }    //Color
        public Nullable<float> ColorMultiplier { get; set; }    //Float
        public Nullable<float> ClampOrWrap { get; set; }    //Float
        public Nullable<float> TillingX { get; set; }    //Float
        public Nullable<float> TillingY { get; set; }    //Float
        public Nullable<float> OffsetX { get; set; }    //Float
        public Nullable<float> OffsetY { get; set; }    //Float
        public Nullable<float> WipeValue { get; set; }    //Float
        public Nullable<float> RotateUV90Deg { get; set; }    //Float
        public Nullable<float> SoftAlpha { get; set; }    //Float
        public Nullable<float> InverseSoftAlphaValue { get; set; }    //Float
        public Nullable<float> UseOnMeshes { get; set; }    //Float
        public Nullable<float> UseWorldSpaceNoise { get; set; }    //Float
        public string WorldSpaceNoise { get; set; }    //rRef:ITexture
        public Nullable<float> WorldSpaceNoiseTilling { get; set; }    //Float
        public Nullable<float> NoiseSpeed { get; set; }    //Float
        public Nullable<float> FresnelPower { get; set; }    //Float
        public Nullable<float> FresnelContrast { get; set; }    //Float
        public Nullable<float> SecondSoftAlpha { get; set; }    //Float
    }
    public partial class _hud_markers_transparent
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Color Second_Color { get; set; }    //Color
        public Nullable<float> ColorMultiplier { get; set; }    //Float
        public Nullable<float> ClampOrWrap { get; set; }    //Float
        public Nullable<float> TillingX { get; set; }    //Float
        public Nullable<float> TillingY { get; set; }    //Float
        public Nullable<float> OffsetX { get; set; }    //Float
        public Nullable<float> OffsetY { get; set; }    //Float
        public Nullable<float> RotateUV90Deg { get; set; }    //Float
        public Nullable<float> WipeValue { get; set; }    //Float
        public Nullable<float> SoftAlpha { get; set; }    //Float
        public Nullable<float> InverseSoftAlphaValue { get; set; }    //Float
        public Nullable<float> UseOnMeshes { get; set; }    //Float
        public Nullable<float> UseWorldSpaceNoise { get; set; }    //Float
        public string WorldSpaceNoise { get; set; }    //rRef:ITexture
        public Nullable<float> WorldSpaceNoiseTilling { get; set; }    //Float
        public Nullable<float> NoiseSpeed { get; set; }    //Float
        public Nullable<float> FresnelPower { get; set; }    //Float
        public Nullable<float> FresnelContrast { get; set; }    //Float
        public Nullable<float> SecondSoftAlpha { get; set; }    //Float
    }
    public partial class _hud_markers_vision
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Color Second_Color { get; set; }    //Color
        public Nullable<float> ColorMultiplier { get; set; }    //Float
        public Nullable<float> ClampOrWrap { get; set; }    //Float
        public Nullable<float> TillingX { get; set; }    //Float
        public Nullable<float> TillingY { get; set; }    //Float
        public Nullable<float> OffsetX { get; set; }    //Float
        public Nullable<float> OffsetY { get; set; }    //Float
        public Nullable<float> RotateUV90Deg { get; set; }    //Float
        public Nullable<float> WipeValue { get; set; }    //Float
        public Nullable<float> SoftAlpha { get; set; }    //Float
        public Nullable<float> InverseSoftAlphaValue { get; set; }    //Float
        public Nullable<float> UseOnMeshes { get; set; }    //Float
        public Nullable<float> UseWorldSpaceNoise { get; set; }    //Float
        public string WorldSpaceNoise { get; set; }    //rRef:ITexture
        public Nullable<float> WorldSpaceNoiseTilling { get; set; }    //Float
        public Nullable<float> NoiseSpeed { get; set; }    //Float
        public Nullable<float> FresnelPower { get; set; }    //Float
        public Nullable<float> FresnelContrast { get; set; }    //Float
        public Nullable<float> SecondSoftAlpha { get; set; }    //Float
    }
    public partial class _hud_ui_dot
    {
        public string Diffuse { get; set; }    //rRef:ITexture
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> TillingX { get; set; }    //Float
        public Nullable<float> TillingY { get; set; }    //Float
        public Nullable<float> OffsetX { get; set; }    //Float
        public Nullable<float> OffsetY { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> ColorMultiplier { get; set; }    //Float
    }
    public partial class _hud_vision_pass
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Vec4 TextureTilingAndSpeed { get; set; }    //Vector4
        public Color Color { get; set; }    //Color
        public Nullable<float> ColorMultiplier { get; set; }    //Float
        public Nullable<float> AlphaMultiplier { get; set; }    //Float
        public Nullable<float> SoftTransparencyAmount { get; set; }    //Float
        public Nullable<float> SoftContrast { get; set; }    //Float
        public Nullable<float> UseVertexColor { get; set; }    //Float
        public Nullable<float> Wipe { get; set; }    //Float
        public Nullable<float> TestForDepth { get; set; }    //Float
    }
    public partial class _johnny_effect
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Nullable<float> Tilling { get; set; }    //Float
        public Nullable<float> Contrast { get; set; }    //Float
    }
    public partial class _johnny_glitch
    {
        public Nullable<float> Offset { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Color BodyColor { get; set; }    //Color
        public Nullable<float> Tilling { get; set; }    //Float
        public Nullable<float> Contrast { get; set; }    //Float
        public Nullable<float> LineLength { get; set; }    //Float
        public Nullable<float> MinDistance { get; set; }    //Float
        public Nullable<float> MaxDistance { get; set; }    //Float
        public Nullable<float> MaxSteps { get; set; }    //Float
        public Nullable<float> NoiseSpeed { get; set; }    //Float
        public Nullable<float> BackgroundOffset { get; set; }    //Float
        public Nullable<float> BlurredIntensity { get; set; }    //Float
        public Nullable<float> NoiseSize { get; set; }    //Float
        public Nullable<float> TileSizeX1 { get; set; }    //Float
        public Nullable<float> TileSizeY1 { get; set; }    //Float
        public Nullable<float> TileSizeX2 { get; set; }    //Float
        public Nullable<float> TileSizeY2 { get; set; }    //Float
        public Nullable<float> GlitchSpeed { get; set; }    //Float
        public Nullable<float> UseHorizontal { get; set; }    //Float
        public string VectorField { get; set; }    //rRef:ITexture
    }
    public partial class _metal_base_atlas_animation
    {
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> LoopedAnimationSpeed { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _metal_base_blackbody
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public string Metalness { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public string EmissiveMask { get; set; }    //rRef:ITexture
        public string HeatDistribution { get; set; }    //rRef:ITexture
        public Nullable<float> MaskMinimum { get; set; }    //Float
        public Nullable<float> HeatTilingX { get; set; }    //Float
        public Nullable<float> HeatTilingY { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> MaxTemperature { get; set; }    //Float
        public Vec4 HSV_Mod { get; set; }    //Vector4
        public Nullable<float> DebugTemperature { get; set; }    //Float
        public Nullable<float> DebugOrExternalCurve { get; set; }    //Float
        public Nullable<float> HeatMoveSpeed { get; set; }    //Float
    }
    public partial class _metal_base_glitter
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> AlphaFromEmissive { get; set; }    //Float
        public string EmissiveMask { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> HistogramRange { get; set; }    //Float
        public Nullable<float> ScrollSpeed { get; set; }    //Float
        public Nullable<float> EmissiveTile { get; set; }    //Float
        public Nullable<float> Looped { get; set; }    //Float
    }
    public partial class _neon_tubes
    {
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EmissiveEdgeMult { get; set; }    //Float
        public Color color { get; set; }    //Color
        public string tex1 { get; set; }    //rRef:ITexture
        public Nullable<float> fresnelpower { get; set; }    //Float
        public Nullable<float> UseBlinkingNoise { get; set; }    //Float
        public Nullable<float> BlinkSpeed { get; set; }    //Float
        public Nullable<float> MinNoiseValue { get; set; }    //Float
        public Nullable<float> TimeSeed { get; set; }    //Float
        public Nullable<float> UseMatParamToCtrlNoise { get; set; }    //Float
        public Nullable<float> TextureU { get; set; }    //Float
        public Nullable<float> TextureV { get; set; }    //Float
        public Nullable<float> TextureIntensity { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
    }
    public partial class _noctovision_mode
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Vec4 NPC_HDRColor1 { get; set; }    //Vector4
        public Vec4 NPC_HDRColor2 { get; set; }    //Vector4
        public Vec4 Enemy_HDRColor1 { get; set; }    //Vector4
        public Vec4 Enemy_HDRColor2 { get; set; }    //Vector4
        public Nullable<float> Multiplier { get; set; }    //Float
        public string Distortion { get; set; }    //rRef:ITexture
        public Nullable<float> DistortionSpeed { get; set; }    //Float
        public Nullable<float> DistortionOffset { get; set; }    //Float
        public Nullable<float> EnemyAlphaMultiplier { get; set; }    //Float
        public Vec4 ScanlineValues { get; set; }    //Vector4
        public Nullable<float> ScanlineContrast { get; set; }    //Float
    }
    public partial class _parallaxscreen
    {
        public string ParalaxTexture { get; set; }    //rRef:ITexture
        public string ScanlineTexture { get; set; }    //rRef:ITexture
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> Emissive { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> ImageScale { get; set; }    //Float
        public Nullable<float> LayersSeparation { get; set; }    //Float
        public Vec4 IntensityPerLayer { get; set; }    //Vector4
        public Nullable<float> ScanlinesDensity { get; set; }    //Float
        public Nullable<float> ScanlinesIntensity { get; set; }    //Float
        public Nullable<float> BlinkingSpeed { get; set; }    //Float
        public string BlinkingMaskTexture { get; set; }    //rRef:ITexture
        public string ScrollMaskTexture { get; set; }    //rRef:ITexture
        public Nullable<float> ScrollVerticalOrHorizontal { get; set; }    //Float
        public Nullable<float> ScrollMaskStartPoint1 { get; set; }    //Float
        public Nullable<float> ScrollMaskHeight1 { get; set; }    //Float
        public Nullable<float> ScrollSpeed1 { get; set; }    //Float
        public Nullable<float> ScrollStepFactor1 { get; set; }    //Float
        public Nullable<float> ScrollMaskStartPoint2 { get; set; }    //Float
        public Nullable<float> ScrollMaskHeight2 { get; set; }    //Float
        public Nullable<float> ScrollSpeed2 { get; set; }    //Float
        public Nullable<float> ScrollStepFactor2 { get; set; }    //Float
        public Color EmissiveColor { get; set; }    //Color
        public Vec4 HSV_Mod { get; set; }    //Vector4
        public Nullable<float> IsBroken { get; set; }    //Float
        public Nullable<float> FixForBlack { get; set; }    //Float
    }
    public partial class _parallaxscreen_transparent
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string ParalaxTexture { get; set; }    //rRef:ITexture
        public Vec4 TexHSVControl { get; set; }    //Vector4
        public Color Color { get; set; }    //Color
        public Nullable<float> Emissive { get; set; }    //Float
        public Nullable<float> AdditiveOrAlphaBlened { get; set; }    //Float
        public Vec4 ImageScale { get; set; }    //Vector4
        public Nullable<float> TextureOffsetX { get; set; }    //Float
        public Nullable<float> TextureOffsetY { get; set; }    //Float
        public Nullable<float> TilesWidth { get; set; }    //Float
        public Nullable<float> TilesHeight { get; set; }    //Float
        public Nullable<float> PlaySpeed { get; set; }    //Float
        public Nullable<float> InterlaceLines { get; set; }    //Float
        public Nullable<float> SeparateLayersFromTexture { get; set; }    //Float
        public Nullable<float> LayersSeparation { get; set; }    //Float
        public Vec4 IntensityPerLayer { get; set; }    //Vector4
        public Nullable<float> ScanlinesDensity { get; set; }    //Float
        public Nullable<float> ScanlinesIntensity { get; set; }    //Float
        public Nullable<float> ScanlinesSpeed { get; set; }    //Float
        public Nullable<float> NoPostORPost { get; set; }    //Float
        public Nullable<float> EdgesMask { get; set; }    //Float
        public Nullable<float> ClampUV { get; set; }    //Float
        public string ScrollMaskTexture { get; set; }    //rRef:ITexture
        public Nullable<float> ScrollVerticalOrHorizontal { get; set; }    //Float
        public Nullable<float> ScrollMaskStartPoint1 { get; set; }    //Float
        public Nullable<float> ScrollMaskHeight1 { get; set; }    //Float
        public Nullable<float> ScrollSpeed1 { get; set; }    //Float
        public Nullable<float> ScrollStepFactor1 { get; set; }    //Float
        public Nullable<float> ScrollMaskStartPoint2 { get; set; }    //Float
        public Nullable<float> ScrollMaskHeight2 { get; set; }    //Float
        public Nullable<float> ScrollSpeed2 { get; set; }    //Float
        public Nullable<float> ScrollStepFactor2 { get; set; }    //Float
        public Vec4 LayersScrollSpeed { get; set; }    //Vector4
    }
    public partial class _parallaxscreen_transparent_ui
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string ScanlineTexture { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> ImageScale { get; set; }    //Float
        public Nullable<float> LayersSeparation { get; set; }    //Float
        public Vec4 IntensityPerLayer { get; set; }    //Vector4
        public Vec4 ScanlinesDensity { get; set; }    //Vector4
        public Nullable<float> IsBroken { get; set; }    //Float
        public Nullable<float> ScanlinesIntensity { get; set; }    //Float
        public string UIRenderTexture { get; set; }    //rRef:ITexture
        public Vec4 TexturePartUV { get; set; }    //Vector4
        public Nullable<float> FixToPbr { get; set; }    //Float
        public Vec4 RenderTextureScale { get; set; }    //Vector4
        public Nullable<float> VerticalFlipEnabled { get; set; }    //Float
        public Nullable<float> EdgeMask { get; set; }    //Float
        public Color Tint { get; set; }    //Color
        public Nullable<float> FixForVerticalSlide { get; set; }    //Float
        public Nullable<float> AlphaAsOne { get; set; }    //Float
        public Nullable<float> SaturationLift { get; set; }    //Float
    }
    public partial class _parallax_bink
    {
        public Color ColorScale { get; set; }    //Color
        public string VideoCanvasName { get; set; }     //CName
        public string BinkY { get; set; }    //rRef:ITexture
        public string BinkCR { get; set; }    //rRef:ITexture
        public string BinkCB { get; set; }    //rRef:ITexture
        public string BinkA { get; set; }    //rRef:ITexture
        public DataBuffer BinkParams { get; set; }
    }
    public partial class _particles_generic_expanded
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Nullable<float> ColorMultiplier { get; set; }    //Float
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> SoftUVInterpolate { get; set; }    //Float
        public Nullable<float> Desaturate { get; set; }    //Float
        public Nullable<float> ColorPower { get; set; }    //Float
        public Nullable<float> DistortAmount { get; set; }    //Float
        public Vec4 TexCoordScale { get; set; }    //Vector4
        public Vec4 TexCoordSpeed { get; set; }    //Vector4
        public Vec4 TexCoordDtortScale { get; set; }    //Vector4
        public Vec4 TexCoordDistortSpeed { get; set; }    //Vector4
        public Nullable<float> AlphaGlobal { get; set; }    //Float
        public Nullable<float> AlphaSoft { get; set; }    //Float
        public Nullable<float> AlphaFresnelPower { get; set; }    //Float
        public Nullable<float> UseAlphaFresnel { get; set; }    //Float
        public Nullable<float> UseAlphaMask { get; set; }    //Float
        public Nullable<float> UseOneChannel { get; set; }    //Float
        public Nullable<float> UseContrastAlpha { get; set; }    //Float
        public string AlphaMask { get; set; }    //rRef:ITexture
        public string Distortion { get; set; }    //rRef:ITexture
        public Nullable<float> UseAlphaFresnelInverted { get; set; }    //Float
        public Nullable<float> AlphaFresnelInvertedPower { get; set; }    //Float
        public Nullable<float> AlphaDistortAmount { get; set; }    //Float
        public Vec4 AlphaMaskDistortScale { get; set; }    //Vector4
        public Vec4 AlphaMaskDistortSpeed { get; set; }    //Vector4
        public Nullable<float> UseTimeOfDay { get; set; }    //Float
    }
    public partial class _particles_hologram
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> UseMaterialParam { get; set; }    //Float
        public Color ColorParam { get; set; }    //Color
        public Nullable<float> DotsCoords { get; set; }    //Float
        public Nullable<float> View_or_World { get; set; }    //Float
        public Nullable<float> ColorMultiplier { get; set; }    //Float
        public Nullable<float> AlphaSoft { get; set; }    //Float
        public Vec4 GlitchTexCoordSpeed { get; set; }    //Vector4
        public string Dots { get; set; }    //rRef:ITexture
        public string AlphaMask { get; set; }    //rRef:ITexture
        public string GlitchTex { get; set; }    //rRef:ITexture
        public Vec4 AlphaTexCoordSpeed { get; set; }    //Vector4
        public Nullable<float> AlphaSubUVWidth { get; set; }    //Float
        public Nullable<float> AlphaSubUVHeight { get; set; }    //Float
        public Nullable<float> SoftUVInterpolate { get; set; }    //Float
        public Nullable<float> AlphaGlobal { get; set; }    //Float
        public Nullable<float> UseOnMesh { get; set; }    //Float
    }
    public partial class _pointcloud_source_mesh
    {
        public Vec4 WorldPositionOffset { get; set; }    //Vector4
    }
    public partial class _postprocess
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> Gain { get; set; }    //Float
        public Color ReColor { get; set; }    //Color
        public Nullable<float> BlurredIntensity { get; set; }    //Float
        public Nullable<float> MaskContrast { get; set; }    //Float
        public Nullable<float> ReColorStrength { get; set; }    //Float
    }
    public partial class _postprocess_notxaa
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> Gain { get; set; }    //Float
        public Color ReColor { get; set; }    //Color
        public Nullable<float> BlurredIntensity { get; set; }    //Float
        public Nullable<float> MaskContrast { get; set; }    //Float
        public Nullable<float> NumberOfIterations { get; set; }    //Float
        public Nullable<float> UseMovingBlur { get; set; }    //Float
        public Nullable<float> ReColorStrength { get; set; }    //Float
    }
    public partial class _radial_blur
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string RedLinesMask { get; set; }    //rRef:ITexture
        public string BlurMask { get; set; }    //rRef:ITexture
        public Nullable<float> RedLinesDensity { get; set; }    //Float
        public Color RedLine1 { get; set; }    //Color
        public Color RedLine2 { get; set; }    //Color
        public Color BluringBackgroundRecolor { get; set; }    //Color
        public Nullable<float> AberationAmount { get; set; }    //Float
        public Nullable<float> BlurAmount { get; set; }    //Float
        public Nullable<float> LightupAmount { get; set; }    //Float
        public Nullable<float> MixAmount { get; set; }    //Float
        public Nullable<float> BlurOrAberration { get; set; }    //Float
        public Nullable<float> ChromaticOffsetSpeed { get; set; }    //Float
    }
    public partial class _reflex_buster
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> MaxDistortMulitiplier { get; set; }    //Float
        public Nullable<float> MinDistortMulitiplier { get; set; }    //Float
        public Nullable<float> ZoomMultiplier { get; set; }    //Float
        public Nullable<float> RelativeFStop { get; set; }    //Float
        public Nullable<float> GlobalTint { get; set; }    //Float
        public Nullable<float> Desaturate { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> UseAlphaOverEffect { get; set; }    //Float
    }
    public partial class _refraction
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Vec4 TexCoordDtortScaleSpeed { get; set; }    //Vector4
        public Nullable<float> DistortAmount { get; set; }    //Float
        public string Alpha { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> UseVertexAlpha { get; set; }    //Float
    }
    public partial class _sandevistan_trails
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string MainTexture { get; set; }    //rRef:ITexture
        public string MainAdditiveTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MainColorMultiplier { get; set; }    //Float
        public Color MainAdditiveColor { get; set; }    //Color
        public Nullable<float> MainAdditiveColorMultiplier { get; set; }    //Float
        public Nullable<float> SlowFactor { get; set; }    //Float
        public Nullable<float> MainAdditiveAlphaTimingExponent { get; set; }    //Float
        public Color MainColorStart { get; set; }    //Color
        public Color MainColorEnd { get; set; }    //Color
        public Nullable<float> HueSpread { get; set; }    //Float
        public Nullable<float> MainBlackBodyMultiplier { get; set; }    //Float
    }
    public partial class _screens
    {
        public Vec4 Tex1CoordMove { get; set; }    //Vector4
        public Vec4 Tex1Color { get; set; }    //Vector4
        public Vec4 Tex2CoordMove { get; set; }    //Vector4
        public Vec4 Tex2Color { get; set; }    //Vector4
        public Vec4 BackCoordMove { get; set; }    //Vector4
        public Vec4 BackColor { get; set; }    //Vector4
        public Nullable<float> Tex2AnimSpeed { get; set; }    //Float
        public string background { get; set; }    //rRef:ITexture
        public string Tex1 { get; set; }    //rRef:ITexture
        public string Tex2 { get; set; }    //rRef:ITexture
        public Vec4 Tex1UVSpeed { get; set; }    //Vector4
        public Nullable<float> DotsCoords { get; set; }    //Float
        public Nullable<float> BackFlatOrCube { get; set; }    //Float
        public string BackgroundCube { get; set; }     //rRef:ITexture
    }
    public partial class _screen_artifacts
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> Complexity { get; set; }    //Float
        public Nullable<float> Visiblity { get; set; }    //Float
        public Nullable<float> Disturbance { get; set; }    //Float
        public Nullable<float> Speed { get; set; }    //Float
        public Nullable<float> RandomNumber { get; set; }    //Float
        public Nullable<float> UseBlackBackground { get; set; }    //Float
        public Nullable<float> BraindanceArtifacts { get; set; }    //Float
        public Nullable<float> TillingVertical { get; set; }    //Float
        public Nullable<float> TillingHorizontal { get; set; }    //Float
        public Nullable<float> BendScreen { get; set; }    //Float
        public Nullable<float> AlphaClip { get; set; }    //Float
    }
    public partial class _screen_artifacts_vision
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> Complexity { get; set; }    //Float
        public Nullable<float> Visiblity { get; set; }    //Float
        public Nullable<float> Disturbance { get; set; }    //Float
        public Nullable<float> Speed { get; set; }    //Float
        public Nullable<float> RandomNumber { get; set; }    //Float
        public Nullable<float> UseBlackBackground { get; set; }    //Float
        public Nullable<float> BraindanceArtifacts { get; set; }    //Float
        public Nullable<float> TillingVertical { get; set; }    //Float
        public Nullable<float> TillingHorizontal { get; set; }    //Float
        public Nullable<float> BendScreen { get; set; }    //Float
        public Nullable<float> AlphaClip { get; set; }    //Float
    }
    public partial class _screen_black
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color Color { get; set; }    //Color
    }
    public partial class _screen_fast_travel_glitch
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> SingelColor { get; set; }    //Float
        public Nullable<float> ColorMultiplier { get; set; }    //Float
        public Nullable<float> Complexity { get; set; }    //Float
        public Nullable<float> Density { get; set; }    //Float
        public Nullable<float> Disturbance { get; set; }    //Float
        public Nullable<float> Speed { get; set; }    //Float
        public Nullable<float> TillingVertical { get; set; }    //Float
        public Nullable<float> TillingHorizontal { get; set; }    //Float
        public Nullable<float> BendScreen { get; set; }    //Float
        public Nullable<float> Vertical { get; set; }    //Float
    }
    public partial class _screen_glitch
    {
        public Nullable<float> Offset { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color GridColor { get; set; }    //Color
        public Nullable<float> BlurredIntensity { get; set; }    //Float
        public Nullable<float> NoiseSize { get; set; }    //Float
        public Nullable<float> TileSizeX1 { get; set; }    //Float
        public Nullable<float> TileSizeY1 { get; set; }    //Float
        public Nullable<float> TileSizeX2 { get; set; }    //Float
        public Nullable<float> TileSizeY2 { get; set; }    //Float
        public Nullable<float> GlitchSpeed { get; set; }    //Float
        public Nullable<float> GlitchSpeedOffset { get; set; }    //Float
        public Nullable<float> GlitchModTime { get; set; }    //Float
        public Nullable<float> GlitchDepth { get; set; }    //Float
        public Nullable<float> UseSquareMask { get; set; }    //Float
        public Nullable<float> UseScreenSpaceMask { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Color ArtifactColor { get; set; }    //Color
        public Nullable<float> ArtifactIntensity { get; set; }    //Float
        public Nullable<float> ArtifactNarrowness { get; set; }    //Float
        public Nullable<float> ArtifactMinimizer { get; set; }    //Float
        public Nullable<float> ArtifactSpeed { get; set; }    //Float
        public Nullable<float> ArtifactTimeOffset { get; set; }    //Float
        public Nullable<float> SmallArtifactsTileX { get; set; }    //Float
        public Nullable<float> SmallArtifactsTileY { get; set; }    //Float
        public Nullable<float> UseStencilMask { get; set; }    //Float
        public Nullable<float> UseSmallArtifacts { get; set; }    //Float
        public Nullable<float> UseBothSideBlur { get; set; }    //Float
        public Nullable<float> UseHorizontal { get; set; }    //Float
        public Nullable<float> UseAlphaOverEntireEffect { get; set; }    //Float
        public Nullable<float> ErrorIntensity { get; set; }    //Float
        public Nullable<float> InvertBrightnessMask { get; set; }    //Float
        public string DotTex { get; set; }    //rRef:ITexture
    }
    public partial class _screen_glitch_notxaa
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color GridColor { get; set; }    //Color
        public Nullable<float> BlurredIntensity { get; set; }    //Float
        public Nullable<float> NoiseSize { get; set; }    //Float
        public Nullable<float> TileSizeX1 { get; set; }    //Float
        public Nullable<float> TileSizeY1 { get; set; }    //Float
        public Nullable<float> TileSizeX2 { get; set; }    //Float
        public Nullable<float> TileSizeY2 { get; set; }    //Float
        public Nullable<float> GlitchSpeed { get; set; }    //Float
        public Nullable<float> GlitchSpeedOffset { get; set; }    //Float
        public Nullable<float> GlitchModTime { get; set; }    //Float
        public Nullable<float> GlitchDepth { get; set; }    //Float
        public Nullable<float> UseSquareMask { get; set; }    //Float
        public Nullable<float> UseScreenSpaceMask { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Color ArtifactColor { get; set; }    //Color
        public Nullable<float> ArtifactIntensity { get; set; }    //Float
        public Nullable<float> ArtifactNarrowness { get; set; }    //Float
        public Nullable<float> ArtifactMinimizer { get; set; }    //Float
        public Nullable<float> ArtifactSpeed { get; set; }    //Float
        public Nullable<float> ArtifactTimeOffset { get; set; }    //Float
        public Nullable<float> SmallArtifactsTileX { get; set; }    //Float
        public Nullable<float> SmallArtifactsTileY { get; set; }    //Float
        public Nullable<float> UseStencilMask { get; set; }    //Float
        public Nullable<float> UseSmallArtifacts { get; set; }    //Float
        public Nullable<float> UseBothSideBlur { get; set; }    //Float
        public Nullable<float> UseHorizontal { get; set; }    //Float
        public Nullable<float> UseAlphaOverEntireEffect { get; set; }    //Float
        public Nullable<float> ErrorIntensity { get; set; }    //Float
        public Nullable<float> InvertBrightnessMask { get; set; }    //Float
        public string ErrorTex { get; set; }    //rRef:ITexture
        public string DotTex { get; set; }    //rRef:ITexture
    }
    public partial class _screen_glitch_vision
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color GridColor { get; set; }    //Color
        public Nullable<float> BlurredIntensity { get; set; }    //Float
        public Nullable<float> NoiseSize { get; set; }    //Float
        public Nullable<float> TileSizeX1 { get; set; }    //Float
        public Nullable<float> TileSizeY1 { get; set; }    //Float
        public Nullable<float> TileSizeX2 { get; set; }    //Float
        public Nullable<float> TileSizeY2 { get; set; }    //Float
        public Nullable<float> GlitchSpeed { get; set; }    //Float
        public Nullable<float> GlitchSpeedOffset { get; set; }    //Float
        public Nullable<float> GlitchModTime { get; set; }    //Float
        public Nullable<float> GlitchDepth { get; set; }    //Float
        public Nullable<float> UseSquareMask { get; set; }    //Float
        public Nullable<float> UseScreenSpaceMask { get; set; }    //Float
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Color ArtifactColor { get; set; }    //Color
        public Nullable<float> ArtifactIntensity { get; set; }    //Float
        public Nullable<float> ArtifactNarrowness { get; set; }    //Float
        public Nullable<float> ArtifactMinimizer { get; set; }    //Float
        public Nullable<float> ArtifactSpeed { get; set; }    //Float
        public Nullable<float> ArtifactTimeOffset { get; set; }    //Float
        public Nullable<float> SmallArtifactsTileX { get; set; }    //Float
        public Nullable<float> SmallArtifactsTileY { get; set; }    //Float
        public Nullable<float> UseStencilMask { get; set; }    //Float
        public Nullable<float> UseSmallArtifacts { get; set; }    //Float
        public Nullable<float> UseBothSideBlur { get; set; }    //Float
        public Nullable<float> UseHorizontal { get; set; }    //Float
        public Nullable<float> UseAlphaOverEntireEffect { get; set; }    //Float
        public Nullable<float> ErrorIntensity { get; set; }    //Float
        public Nullable<float> InvertBrightnessMask { get; set; }    //Float
        public string ErrorTex { get; set; }    //rRef:ITexture
        public string DotTex { get; set; }    //rRef:ITexture
    }
    public partial class _signages
    {
        public string MainTexture { get; set; }    //rRef:ITexture
        public Nullable<float> UseRoughnessTexture { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> Roughness { get; set; }    //Float
        public Vec4 RoughnessTilingAndOffset { get; set; }    //Vector4
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> UniformColor { get; set; }    //Float
        public Nullable<float> UseVertexColorOrMap { get; set; }    //Float
        public Color ColorOneStart { get; set; }    //Color
        public Color ColorOneEnd { get; set; }    //Color
        public Nullable<float> ColorGradientScale { get; set; }    //Float
        public Nullable<float> HorizontalOrVerticalGradient { get; set; }    //Float
        public Nullable<float> GradientStartPosition { get; set; }    //Float
        public Color ColorTwo { get; set; }    //Color
        public Color ColorThree { get; set; }    //Color
        public Color ColorFour { get; set; }    //Color
        public Color ColorFive { get; set; }    //Color
        public Color ColorSix { get; set; }    //Color
        public string NoiseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> LightupDensity { get; set; }    //Float
        public Nullable<float> LightupMinimumValue { get; set; }    //Float
        public Nullable<float> LightupHorizontalOrVertical { get; set; }    //Float
        public Nullable<float> BlinkingSpeed { get; set; }    //Float
        public Nullable<float> BlinkingMinimumValue { get; set; }    //Float
        public Nullable<float> BlinkingPhase { get; set; }    //Float
        public Nullable<float> BlinkSmoothness { get; set; }    //Float
        public Nullable<float> FresnelAmount { get; set; }    //Float
    }
    public partial class _signages_transparent_no_txaa
    {
        public string MainTexture { get; set; }    //rRef:ITexture
        public Nullable<float> UseRoughnessTexture { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> Roughness { get; set; }    //Float
        public Vec4 RoughnessTilingAndOffset { get; set; }    //Vector4
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> UniformColor { get; set; }    //Float
        public Nullable<float> UseVertexColorOrMap { get; set; }    //Float
        public Color ColorOneStart { get; set; }    //Color
        public Color ColorOneEnd { get; set; }    //Color
        public Nullable<float> ColorGradientScale { get; set; }    //Float
        public Nullable<float> HorizontalOrVerticalGradient { get; set; }    //Float
        public Nullable<float> GradientStartPosition { get; set; }    //Float
        public Color ColorTwo { get; set; }    //Color
        public Color ColorThree { get; set; }    //Color
        public Color ColorFour { get; set; }    //Color
        public Color ColorFive { get; set; }    //Color
        public Color ColorSix { get; set; }    //Color
        public string NoiseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> LightupDensity { get; set; }    //Float
        public Nullable<float> LightupMinimumValue { get; set; }    //Float
        public Nullable<float> LightupHorizontalOrVertical { get; set; }    //Float
        public Nullable<float> BlinkingSpeed { get; set; }    //Float
        public Nullable<float> BlinkingMinimumValue { get; set; }    //Float
        public Nullable<float> BlinkingPhase { get; set; }    //Float
        public Nullable<float> BlinkSmoothness { get; set; }    //Float
        public Nullable<float> FresnelAmount { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
    }
    public partial class _silverhand_proxy
    {
        public string Color { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public Nullable<float> BayerScale { get; set; }    //Float
        public Nullable<float> BayerIntensity { get; set; }    //Float
        public Nullable<float> FresnelExponent { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
    }
    public partial class _simple_additive_ui
    {
        public string UIRenderTexture { get; set; }    //rRef:ITexture
        public Vec4 UvTilingAndOffset { get; set; }    //Vector4
        public Vec4 DirtTilingAndOffset { get; set; }    //Vector4
        public Vec4 TexturePartUV { get; set; }    //Vector4
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> PremultiplyByAlpha { get; set; }    //Float
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> Saturation { get; set; }    //Float
        public string DirtTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DirtOpacity { get; set; }    //Float
        public Color DirtColorScale { get; set; }    //Color
    }
    public partial class _simple_emissive_decals
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> ColorMultiply { get; set; }    //Float
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> FrameNum { get; set; }    //Float
        public Nullable<float> InvertSoftAlpha { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
    }
    public partial class _simple_fresnel
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Color FresnelColor { get; set; }    //Color
        public Nullable<float> FresnelPower { get; set; }    //Float
    }
    public partial class _simple_refraction
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> RefractionStrength { get; set; }    //Float
        public string Refraction { get; set; }    //rRef:ITexture
        public Nullable<float> UseDepth { get; set; }    //Float
        public Vec4 RefractionTextureOffset { get; set; }    //Vector4
        public Vec4 RefractionTextureSpeed { get; set; }    //Vector4
        public Nullable<float> SlowFactor { get; set; }    //Float
        public Nullable<float> RefractionStrengthSlowTime { get; set; }    //Float
    }
    public partial class _sound_clue
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Nullable<float> ColorMultiplier { get; set; }    //Float
    }
    public partial class _television_ad
    {
        public Nullable<float> TilesWidth { get; set; }    //Float
        public Nullable<float> TilesHeight { get; set; }    //Float
        public Nullable<float> PlaySpeed { get; set; }    //Float
        public Nullable<float> InterlaceLines { get; set; }    //Float
        public Nullable<float> PixelsHeight { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> BlackLinesRatio { get; set; }    //Float
        public Nullable<float> BlackLinesIntensity { get; set; }    //Float
        public string AdTexture { get; set; }    //rRef:ITexture
        public Nullable<float> BlackLinesSize { get; set; }    //Float
        public Nullable<float> LinesOrDots { get; set; }    //Float
        public Nullable<float> DistanceDivision { get; set; }    //Float
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> IsBroken { get; set; }    //Float
        public Nullable<float> UseFloatParameter { get; set; }    //Float
        public Nullable<float> UseFloatParameter1 { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public string DirtTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DirtOpacityScale { get; set; }    //Float
        public Nullable<float> DirtRoughness { get; set; }    //Float
        public Nullable<float> DirtUvScaleU { get; set; }    //Float
        public Nullable<float> DirtUvScaleV { get; set; }    //Float
        public Nullable<float> HUEChangeSpeed { get; set; }    //Float
    }
    public partial class _triplanar_projection
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Nullable<float> FirstValue { get; set; }    //Float
        public Nullable<float> SecondValue { get; set; }    //Float
        public Nullable<float> ThirdValue { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> Stretch { get; set; }    //Float
        public Nullable<float> ColorMultiplier { get; set; }    //Float
    }
    public partial class _water_test
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color TintColor { get; set; }    //Color
        public Color TintColorDeep { get; set; }    //Color
        public Vec4 TexCoordDtortScaleSpeed { get; set; }    //Vector4
        public Nullable<float> DistortAmount { get; set; }    //Float
        public Nullable<float> IOR { get; set; }    //Float
        public Nullable<float> ReflectionPower { get; set; }    //Float
        public Vec4 ReflectNormalMultiplier { get; set; }    //Vector4
        public string Normal { get; set; }    //rRef:ITexture
        public string Alpha { get; set; }    //rRef:ITexture
    }
    public partial class _zoom
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> Progress { get; set; }    //Float
        public Color OutlineColor { get; set; }    //Color
        public Nullable<float> OutlineThickness { get; set; }    //Float
        public Nullable<float> MinRange { get; set; }    //Float
        public Nullable<float> MaxRange { get; set; }    //Float
        public Nullable<float> MotionIntensity { get; set; }    //Float
        public Nullable<float> TransitionOrLoop { get; set; }    //Float
        public Nullable<float> IsBackwardEffect { get; set; }    //Float
        public Nullable<float> UseBrokenSobelPixels { get; set; }    //Float
    }
    public partial class _alt_halo
    {
        public Nullable<float> Offset { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Noise { get; set; }    //rRef:ITexture
        public string DistanceNoise { get; set; }    //rRef:ITexture
        public Nullable<float> DistanceNoiseScale { get; set; }    //Float
        public string Dot { get; set; }    //rRef:ITexture
        public Nullable<float> DotsLift { get; set; }    //Float
        public Nullable<float> DistPower { get; set; }    //Float
        public Nullable<float> NoiseScale { get; set; }    //Float
        public Nullable<float> NoiseSpeed { get; set; }    //Float
        public Nullable<float> DistanceNoiseAmount { get; set; }    //Float
        public Nullable<float> DotsMax { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> WorldOrLocalSpace { get; set; }    //Float
        public Nullable<float> DotsScale { get; set; }    //Float
        public Nullable<float> LocalSpaceRatio { get; set; }    //Float
        public Nullable<float> FadeOutDistance { get; set; }    //Float
        public Nullable<float> FadeOutDistanceMinimum { get; set; }    //Float
        public Nullable<float> UVOrScreenSpace { get; set; }    //Float
    }
    public partial class _blackbodyradiation_distant
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> Temperature { get; set; }    //Float
        public string FireScatterAlpha { get; set; }    //rRef:ITexture
        public Nullable<float> subUVWidth { get; set; }    //Float
        public Nullable<float> subUVHeight { get; set; }    //Float
        public Nullable<float> MultiplierExponent { get; set; }    //Float
        public Nullable<float> NoAlphaOnTexture { get; set; }    //Float
        public Nullable<float> AlphaExponent { get; set; }    //Float
        public Nullable<float> maxAlpha { get; set; }    //Float
        public Nullable<float> EatUpOrStraightAlpha { get; set; }    //Float
        public Nullable<float> ScatterAmount { get; set; }    //Float
        public Nullable<float> ScatterPower { get; set; }    //Float
        public Nullable<float> HueShift { get; set; }    //Float
        public Nullable<float> HueSpread { get; set; }    //Float
        public Nullable<float> Saturation { get; set; }    //Float
        public Nullable<float> ExpensiveBlending { get; set; }    //Float
        public Color LightSmoke { get; set; }    //Color
        public Color DarkSmoke { get; set; }    //Color
        public Nullable<float> SoftAlpha { get; set; }    //Float
        public string Distort { get; set; }    //rRef:ITexture
        public Vec4 TexCoordDtortScale { get; set; }    //Vector4
        public Vec4 TexCoordDtortSpeed { get; set; }    //Vector4
        public Nullable<float> DistortAmount { get; set; }    //Float
        public Nullable<float> EnableRowAnimation { get; set; }    //Float
        public Nullable<float> DoNotApplyLighting { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public Nullable<float> InvertMask { get; set; }    //Float
        public Vec4 MaskTilingAndSpeed { get; set; }    //Vector4
        public Nullable<float> MaskIntensity { get; set; }    //Float
        public Nullable<float> UseVertexAlpha { get; set; }    //Float
        public Nullable<float> DotWithLookAt { get; set; }    //Float
    }
    public partial class _blackbodyradiation_notxaa
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> Temperature { get; set; }    //Float
        public string FireScatterAlpha { get; set; }    //rRef:ITexture
        public Nullable<float> subUVWidth { get; set; }    //Float
        public Nullable<float> subUVHeight { get; set; }    //Float
        public Nullable<float> MultiplierExponent { get; set; }    //Float
        public Nullable<float> NoAlphaOnTexture { get; set; }    //Float
        public Nullable<float> AlphaExponent { get; set; }    //Float
        public Nullable<float> maxAlpha { get; set; }    //Float
        public Nullable<float> EatUpOrStraightAlpha { get; set; }    //Float
        public Nullable<float> ScatterAmount { get; set; }    //Float
        public Nullable<float> ScatterPower { get; set; }    //Float
        public Nullable<float> HueShift { get; set; }    //Float
        public Nullable<float> HueSpread { get; set; }    //Float
        public Nullable<float> Saturation { get; set; }    //Float
        public Nullable<float> ExpensiveBlending { get; set; }    //Float
        public Color LightSmoke { get; set; }    //Color
        public Color DarkSmoke { get; set; }    //Color
        public Nullable<float> SoftAlpha { get; set; }    //Float
        public string Distort { get; set; }    //rRef:ITexture
        public Vec4 TexCoordDtortScale { get; set; }    //Vector4
        public Vec4 TexCoordDtortSpeed { get; set; }    //Vector4
        public Nullable<float> DistortAmount { get; set; }    //Float
        public Nullable<float> EnableRowAnimation { get; set; }    //Float
        public Nullable<float> DoNotApplyLighting { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public Nullable<float> InvertMask { get; set; }    //Float
        public Vec4 MaskTilingAndSpeed { get; set; }    //Vector4
        public Nullable<float> MaskIntensity { get; set; }    //Float
        public Nullable<float> UseVertexAlpha { get; set; }    //Float
        public Nullable<float> DotWithLookAt { get; set; }    //Float
    }
    public partial class _blood_metal_base
    {
        public Color ColorThin { get; set; }    //Color
        public Color ColorThick { get; set; }    //Color
        public string NormalAndDensity { get; set; }    //rRef:ITexture
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> UseTimeFlowmap { get; set; }    //Float
        public Nullable<float> FlowMapSpeed { get; set; }    //Float
        public string VelocityMap { get; set; }    //rRef:ITexture
        public Nullable<float> FlowmapStrength { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> UseOnStaticMeshes { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
    }
    public partial class _caustics
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Distortion { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Nullable<float> Contrast { get; set; }    //Float
        public Nullable<float> Speed { get; set; }    //Float
        public Nullable<float> SmallMovementSpeed { get; set; }    //Float
        public Nullable<float> Multiplier { get; set; }    //Float
        public Nullable<float> Spread { get; set; }    //Float
        public Nullable<float> DistortionAmount { get; set; }    //Float
        public Nullable<float> DistortionUVScaling { get; set; }    //Float
        public Nullable<float> UVScaling { get; set; }    //Float
        public Nullable<float> EdgeWidth { get; set; }    //Float
        public Nullable<float> EdgeMultiplier { get; set; }    //Float
        public Nullable<float> MaxValue { get; set; }    //Float
    }
    public partial class _character_kerenzikov
    {
        public Nullable<float> VertexOffset { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Vec4 CenterPoint { get; set; }    //Vector4
        public Nullable<float> PixelOffset { get; set; }    //Float
        public Nullable<float> ComebackPixelOffset { get; set; }    //Float
        public Nullable<float> NoiseAmount { get; set; }    //Float
        public Nullable<float> Debug { get; set; }    //Float
    }
    public partial class _character_sandevistan
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> Iterations { get; set; }    //Float
        public Nullable<float> OffsetStrength { get; set; }    //Float
        public Nullable<float> InsideSoftAlpha { get; set; }    //Float
        public Nullable<float> TopDisplacePower { get; set; }    //Float
        public Nullable<float> TopDisplaceIntensity { get; set; }    //Float
    }
    public partial class _crystal_dome
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> ScanlineDensity { get; set; }    //Float
        public Nullable<float> GainMin { get; set; }    //Float
        public Nullable<float> GainMax { get; set; }    //Float
        public Nullable<float> NoiseMax { get; set; }    //Float
        public Nullable<float> NoiseBrightness { get; set; }    //Float
        public Nullable<float> IntialGradientTime { get; set; }    //Float
    }
    public partial class _crystal_dome_opaque
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Color PrimaryGlowColor { get; set; }    //Color
        public Color SecondaryGlowColor { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public string Roughness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Vec4 Tiling { get; set; }    //Vector4
        public Nullable<float> InitialTime { get; set; }    //Float
        public Nullable<float> MaxTimeOffset { get; set; }    //Float
        public Nullable<float> SwipeAngle { get; set; }    //Float
        public string FluffMask { get; set; }    //rRef:ITexture
        public string PatternMask { get; set; }    //rRef:ITexture
        public Nullable<float> UVDivision { get; set; }    //Float
        public Nullable<float> NoiseMax { get; set; }    //Float
        public Nullable<float> DebugValue { get; set; }    //Float
        public Nullable<float> Debug { get; set; }    //Float
        public Nullable<float> UVDivision_FluffMask { get; set; }    //Float
        public Nullable<float> MinUV { get; set; }    //Float
        public Nullable<float> MaxUV { get; set; }    //Float
        public string DistortionMap { get; set; }    //rRef:ITexture
        public Nullable<float> DistortionScale { get; set; }    //Float
    }
    public partial class _cyberspace_gradient
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> InitialGradientTiling { get; set; }    //Float
        public Nullable<float> InitialGradientDivisions { get; set; }    //Float
        public Nullable<float> RectangleRatio { get; set; }    //Float
        public string GradientPalette { get; set; }    //rRef:ITexture
        public string SecondaryGradientPalette { get; set; }    //rRef:ITexture
        public Nullable<float> Reveal { get; set; }    //Float
        public Nullable<float> ReveakMaskContrast { get; set; }    //Float
        public Nullable<float> RevealBiasMin { get; set; }    //Float
        public Nullable<float> RevealBiasMax { get; set; }    //Float
        public Nullable<float> ColorBias { get; set; }    //Float
        public Nullable<float> FloatOrParam { get; set; }    //Float
        public Nullable<float> FloatOrAlpha { get; set; }    //Float
        public Vec4 HSB { get; set; }    //Vector4
        public Nullable<float> BottomLinesAmount { get; set; }    //Float
        public Nullable<float> BottomLinesCuttoff { get; set; }    //Float
        public Nullable<float> BottomLinesWidth { get; set; }    //Float
        public Nullable<float> TowardsCameraSpeed { get; set; }    //Float
    }
    public partial class _cyberspace_teleport_glitch
    {
        public Nullable<float> DepthOffset { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string DistortionMap { get; set; }    //rRef:ITexture
        public Nullable<float> DistortionSize { get; set; }    //Float
        public Nullable<float> DistortionMultiplier { get; set; }    //Float
        public Nullable<float> ChangeChance { get; set; }    //Float
        public Nullable<float> LinesSize { get; set; }    //Float
        public Nullable<float> LinesSpeed { get; set; }    //Float
        public Nullable<float> LinesAmount { get; set; }    //Float
        public Nullable<float> LinesDistortion { get; set; }    //Float
        public Nullable<float> SampledDistortOFfset { get; set; }    //Float
        public Vec4 SampledDistortSize { get; set; }    //Vector4
        public Nullable<float> ColorMultiplier { get; set; }    //Float
    }
    public partial class _decal_caustics
    {
        public Color Color { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public string Distortion { get; set; }    //rRef:ITexture
        public Nullable<float> Contrast { get; set; }    //Float
        public Nullable<float> Speed { get; set; }    //Float
        public Nullable<float> SmallMovementSpeed { get; set; }    //Float
        public Nullable<float> Spread { get; set; }    //Float
        public Nullable<float> DistortionAmount { get; set; }    //Float
        public Nullable<float> DistortionUVScaling { get; set; }    //Float
        public Nullable<float> UVScaling { get; set; }    //Float
        public Nullable<float> EdgeWidth { get; set; }    //Float
        public Nullable<float> EdgeMultiplier { get; set; }    //Float
        public Nullable<float> MaxValue { get; set; }    //Float
        public Nullable<float> GradientStartPosition { get; set; }    //Float
        public Nullable<float> GradientLength { get; set; }    //Float
    }
    public partial class _decal_glitch
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string GradientMap { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
        public Nullable<float> GlitchScale { get; set; }    //Float
        public Nullable<float> GlitchStrength { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffOn { get; set; }    //Float
        public Nullable<float> DissapearingChance { get; set; }    //Float
        public Nullable<float> ColorChangeAmount { get; set; }    //Float
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> EmissiveEV { get; set; }    //Float
    }
    public partial class _decal_glitch_emissive
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string GradientMap { get; set; }    //rRef:ITexture
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
        public Nullable<float> GlitchScale { get; set; }    //Float
        public Nullable<float> GlitchStrength { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffOn { get; set; }    //Float
        public Nullable<float> DissapearingChance { get; set; }    //Float
        public Nullable<float> ColorChangeAmount { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Color DiffuseColor { get; set; }    //Color
    }
    public partial class _depth_based_sobel
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> ThinLinesThickness { get; set; }    //Float
        public Nullable<float> ThinLinesDistance { get; set; }    //Float
        public Nullable<float> ThickLinesThickness { get; set; }    //Float
        public Nullable<float> ThickLinesDistance { get; set; }    //Float
        public Nullable<float> OutlineThickness { get; set; }    //Float
        public Color LinesColor { get; set; }    //Color
        public Nullable<float> Brightness { get; set; }    //Float
        public Nullable<float> MinDistance { get; set; }    //Float
        public Nullable<float> MaxDistance { get; set; }    //Float
        public Nullable<float> MaskSizeX { get; set; }    //Float
        public Nullable<float> MaskSizeY { get; set; }    //Float
        public Nullable<float> SobelThreshold { get; set; }    //Float
        public Nullable<float> SobelStep { get; set; }    //Float
        public Nullable<float> SobelMinimumChange { get; set; }    //Float
    }
    public partial class _diode_pavements_ui
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public Nullable<float> Metalness { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public string DiodesMask { get; set; }    //rRef:ITexture
        public string SignTexture { get; set; }    //rRef:ITexture
        public Vec4 DiodesTilingAndScrollSpeed { get; set; }    //Vector4
        public Nullable<float> Emissive { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Nullable<float> UseMaskAsAlphaThreshold { get; set; }    //Float
        public string UIRenderTexture { get; set; }    //rRef:ITexture
        public Vec4 TexturePartUV { get; set; }    //Vector4
        public Vec4 RenderTextureScale { get; set; }    //Vector4
        public Nullable<float> VerticalFlipEnabled { get; set; }    //Float
        public Nullable<float> AmountOfGlitch { get; set; }    //Float
        public Nullable<float> GlitchSpeed { get; set; }    //Float
        public Vec4 BaseColorRoughnessTiling { get; set; }    //Vector4
    }
    public partial class _dirt_animated_masked
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Mask { get; set; }    //rRef:ITexture
        public string Dirt { get; set; }    //rRef:ITexture
        public string DirtSecond { get; set; }    //rRef:ITexture
        public Color DirtColor { get; set; }    //Color
        public Nullable<float> Multiplier { get; set; }    //Float
        public Nullable<float> WidthScaling { get; set; }    //Float
        public Nullable<float> HeightScaling { get; set; }    //Float
        public Nullable<float> RedChannelOrAlpha { get; set; }    //Float
    }
    public partial class _e3_prototype_mask
    {
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string HeatDistribution { get; set; }    //rRef:ITexture
        public Nullable<float> Temperature { get; set; }    //Float
        public Nullable<float> TemperatureMinimum { get; set; }    //Float
        public Nullable<float> HueShift { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveExponent { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Nullable<float> GradientWidth { get; set; }    //Float
        public Nullable<float> DebugValue { get; set; }    //Float
        public Nullable<float> UseFloatValue { get; set; }    //Float
    }
    public partial class _fake_flare
    {
        public Nullable<float> WidthScale { get; set; }    //Float
        public Nullable<float> HeightScale { get; set; }    //Float
        public Nullable<float> Promixity { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Nullable<float> Multiplier { get; set; }    //Float
        public Nullable<float> MultiplierPower { get; set; }    //Float
    }
    public partial class _fake_flare_simple
    {
        public Nullable<float> DistanceSizeFactor { get; set; }    //Float
        public Nullable<float> SizeScale { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public Nullable<float> RadialOrTexture { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> Multiplier { get; set; }    //Float
        public Nullable<float> FalloffPower { get; set; }    //Float
        public Nullable<float> MinimumDistanceVisibility { get; set; }    //Float
        public Nullable<float> DistanceVisibilityFadeIn { get; set; }    //Float
        public Nullable<float> MaximumRangeMin { get; set; }    //Float
        public Nullable<float> MaximumRangeMax { get; set; }    //Float
        public Nullable<float> BlinkSpeed { get; set; }    //Float
    }
    public partial class _flat_fog_masked
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string RefractionMask { get; set; }    //rRef:ITexture
        public Nullable<float> DebugValue { get; set; }    //Float
        public Nullable<float> Fogginess { get; set; }    //Float
        public Nullable<float> Crackness { get; set; }    //Float
        public Nullable<float> FogOrRefraction { get; set; }    //Float
        public Color CrackColor { get; set; }    //Color
    }
    public partial class _flat_fog_masked_notxaa
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string RefractionMask { get; set; }    //rRef:ITexture
        public Nullable<float> DebugValue { get; set; }    //Float
        public Nullable<float> Fogginess { get; set; }    //Float
        public Nullable<float> Crackness { get; set; }    //Float
        public Nullable<float> FogOrRefraction { get; set; }    //Float
        public Color CrackColor { get; set; }    //Color
    }
    public partial class _highlight_blocker
    {
        public Nullable<float> MeshGrow { get; set; }    //Float
    }
    public partial class _hologram_proxy
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Color { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> FresnelIntensity { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public Nullable<float> FresnelGamma { get; set; }    //Float
        public Nullable<float> Alpha { get; set; }    //Float
        public Nullable<float> DecayStart { get; set; }    //Float
        public Nullable<float> Decay { get; set; }    //Float
    }
    public partial class _holo_mask
    {
        public Nullable<float> VerticalDivisions { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchOffset { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public Nullable<float> ChangeSpeed { get; set; }    //Float
        public Nullable<float> HorizontalDivisions { get; set; }    //Float
        public Nullable<float> ScanlineDensity { get; set; }    //Float
        public Nullable<float> ScanlineMinimum { get; set; }    //Float
        public Color MinColor { get; set; }    //Color
        public Color MaxColor { get; set; }    //Color
        public Color EyesColor { get; set; }    //Color
        public Nullable<float> BrightnessBoost { get; set; }    //Float
        public Nullable<float> EyesBoost { get; set; }    //Float
        public Nullable<float> AmountOfHorizontalTear { get; set; }    //Float
        public Nullable<float> ULimit { get; set; }    //Float
        public Nullable<float> VLimit { get; set; }    //Float
    }
    public partial class _invisible
    {
    }
    public partial class _lightning_plasma
    {
        public Nullable<float> UseTimeOrAnimationFrame { get; set; }    //Float
        public string DisplaceAlongUV { get; set; }    //rRef:ITexture
        public Nullable<float> DisplaceAlongUVSpeed { get; set; }    //Float
        public Nullable<float> DisplaceAlongUVScale { get; set; }    //Float
        public Nullable<float> DisplaceAlongUVStrength { get; set; }    //Float
        public Nullable<float> DisplaceAlongUVStrengthPower { get; set; }    //Float
        public Nullable<float> DisplaceAlongUVAdjustWidth { get; set; }    //Float
        public Nullable<float> DisplaceSeed { get; set; }    //Float
        public Nullable<float> DisplaceSeedSPEED { get; set; }    //Float
        public Nullable<float> DisplaceSeedSPEEDProbability { get; set; }    //Float
        public Nullable<float> DisplaceAlongUVOffScale { get; set; }    //Float
        public Nullable<float> DisplaceAlongUVOffSpeed { get; set; }    //Float
        public Nullable<float> DisplaceAlongUVOffSTR { get; set; }    //Float
        public Nullable<float> WorldNoiseSTR { get; set; }    //Float
        public Nullable<float> WorldNoiseSize { get; set; }    //Float
        public Nullable<float> WorldNoiseSpeed { get; set; }    //Float
        public Nullable<float> WorldNoise_Up_extra { get; set; }    //Float
        public Nullable<float> SetWorldNoiseToLocal { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> FlipUVby90deg { get; set; }    //Float
        public string TemperatureTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MeshAnimationOnOff { get; set; }    //Float
        public Nullable<float> MeshPlaySpeed { get; set; }    //Float
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> TemperatureTextureScale { get; set; }    //Float
        public Nullable<float> TemperatureTextureSpeed { get; set; }    //Float
        public Nullable<float> Temperature { get; set; }    //Float
        public Nullable<float> TemperaturePow { get; set; }    //Float
        public Nullable<float> TemperatureFlickerSpeed { get; set; }    //Float
        public Nullable<float> TemperatureFlickerSTR { get; set; }    //Float
        public Nullable<float> HueShift { get; set; }    //Float
        public Nullable<float> HueSaturation { get; set; }    //Float
        public Nullable<float> ContactPointRange { get; set; }    //Float
        public Nullable<float> ContactPointSTR { get; set; }    //Float
        public Color Tint { get; set; }    //Color
        public Nullable<float> SoftAlpha { get; set; }    //Float
        public Nullable<float> maxAlpha { get; set; }    //Float
        public string DistortTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DistortAmount { get; set; }    //Float
        public Vec4 TexCoordDtortScale { get; set; }    //Vector4
        public Vec4 TexCoordDistortSpeed { get; set; }    //Vector4
    }
    public partial class _light_gradients
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color BottomColor { get; set; }    //Color
        public Color TopColor { get; set; }    //Color
        public Nullable<float> LerpGradient { get; set; }    //Float
        public Nullable<float> Multiplier { get; set; }    //Float
        public Nullable<float> MinProximityAlpha { get; set; }    //Float
        public Nullable<float> MaxProximityAlpha { get; set; }    //Float
        public Nullable<float> GroundPosition { get; set; }    //Float
        public Nullable<float> TopPosition { get; set; }    //Float
        public Nullable<float> GradientDirection { get; set; }    //Float
        public Nullable<float> RoundGradientPosition { get; set; }    //Float
        public Nullable<float> RoundGradientScale { get; set; }    //Float
        public Nullable<float> DistanceToSurfaceModifier { get; set; }    //Float
    }
    public partial class _low_health
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string MainPattern { get; set; }    //rRef:ITexture
        public string FluffText { get; set; }    //rRef:ITexture
        public string FluffPattern { get; set; }    //rRef:ITexture
        public Nullable<float> Rows { get; set; }    //Float
        public Nullable<float> MaximumSliding { get; set; }    //Float
        public Nullable<float> MaximumDistortion { get; set; }    //Float
        public Nullable<float> OffsetChangeSpeed { get; set; }    //Float
        public Nullable<float> OffsetAmount { get; set; }    //Float
        public Nullable<float> PatternTiling { get; set; }    //Float
        public Nullable<float> PatternVisibility { get; set; }    //Float
        public Nullable<float> FluffVisibility { get; set; }    //Float
        public Nullable<float> FluffTiling { get; set; }    //Float
        public Color VignetteColor { get; set; }    //Color
        public Color FluffTextColor { get; set; }    //Color
        public Nullable<float> VignetteMin { get; set; }    //Float
        public Nullable<float> Multiplier { get; set; }    //Float
        public Nullable<float> VignetteMax { get; set; }    //Float
        public Nullable<float> VignetteLength { get; set; }    //Float
        public Nullable<float> VignetteSteps { get; set; }    //Float
        public Nullable<float> VignetteContrast { get; set; }    //Float
        public Nullable<float> FinalContrast { get; set; }    //Float
        public Nullable<float> LinesMultiplier { get; set; }    //Float
    }
    public partial class _mesh_decal__blackbody
    {
        public Nullable<float> VertexOffsetFactor { get; set; }    //Float
        public string MaskTexture { get; set; }    //rRef:ITexture
        public string HeatDistribution { get; set; }    //rRef:ITexture
        public Vec4 HeatTiling { get; set; }    //Vector4
        public Nullable<float> Temperature { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> MaskMinimum { get; set; }    //Float
        public Vec4 HSV_Mod { get; set; }    //Vector4
        public Nullable<float> UseFloatParam { get; set; }    //Float
        public Nullable<float> EmissiveAlphaContrast { get; set; }    //Float
    }
    public partial class _metal_base_scrolling
    {
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> Roughness { get; set; }    //Float
        public Color Bright { get; set; }    //Color
        public Color Dark { get; set; }    //Color
        public string Normal { get; set; }    //rRef:ITexture
        public string Mask { get; set; }    //rRef:ITexture
        public Vec4 MaskTilingAndScrolling { get; set; }    //Vector4
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
    }
    public partial class _multilayer_blackbody_inject
    {
        public Nullable<float> Emissive { get; set; }    //Float
        public Nullable<float> Temperature { get; set; }    //Float
        public Nullable<float> MaximumTemperature { get; set; }    //Float
        public Nullable<float> ColorExponent { get; set; }    //Float
        public Nullable<float> Debug { get; set; }    //Float
        public Vec4 FireHSV { get; set; }    //Vector4
        public Vec4 PoisonHSV { get; set; }    //Vector4
        public Vec4 ElectricHSV { get; set; }    //Vector4
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public string DamageTypeRGBMask { get; set; }    //rRef:ITexture
        public string DamageTypeNoise { get; set; }    //rRef:ITexture
        public Nullable<float> DamageTypeNoiseIntesityAdd { get; set; }    //Float
        public Vec4 DamageTypeNoiseUV { get; set; }    //Vector4
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; }     //rRef:Multilayer_Setup
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public Nullable<float> SetupLayerMask { get; set; }    //Float
    }
    public partial class _nanowire_string
    {
        public Nullable<float> Thickness { get; set; }    //Float
        public Nullable<float> NoiseAmount { get; set; }    //Float
        public Nullable<float> NoiseScale { get; set; }    //Float
        public Nullable<float> MaxVelocity { get; set; }    //Float
        public Nullable<float> MaxVelocityExponent { get; set; }    //Float
        public Nullable<float> StartGradient { get; set; }    //Float
        public Nullable<float> GradientWidth { get; set; }    //Float
        public Nullable<float> MaxDistance { get; set; }    //Float
        public Color MainColor { get; set; }    //Color
        public string NormalMap { get; set; }    //rRef:ITexture
        public string MaskTexture { get; set; }    //rRef:ITexture
        public Vec4 NormalTiling { get; set; }    //Vector4
        public Nullable<float> Metalness { get; set; }    //Float
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> Temperature { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> MinimumEmissive { get; set; }    //Float
        public Nullable<float> EmissiveMaskPower { get; set; }    //Float
        public Nullable<float> TurnOffBrightness { get; set; }    //Float
        public Nullable<float> BlinkSpeed { get; set; }    //Float
        public Nullable<float> BlinkWidth { get; set; }    //Float
        public Nullable<float> BlinkMultiplier { get; set; }    //Float
        public Nullable<float> BlinkOffMultiplier { get; set; }    //Float
        public Vec4 HSVMod { get; set; }    //Vector4
    }
    public partial class _oda_helm
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public string Hologram { get; set; }    //rRef:ITexture
        public string NormalRoughnessMetalness { get; set; }    //rRef:ITexture
        public string ScanlineTexture { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVGlitched { get; set; }    //Float
        public Nullable<float> DotPower { get; set; }    //Float
        public Nullable<float> SecondaryDotPower { get; set; }    //Float
        public Nullable<float> LayersSeparation { get; set; }    //Float
        public Vec4 LayersIntensity { get; set; }    //Vector4
        public Vec4 ScanlineTilingAndSpeed { get; set; }    //Vector4
        public Nullable<float> ScanlinesIntensity { get; set; }    //Float
        public Vec4 NoiseScale { get; set; }    //Vector4
        public Color PrimaryColor { get; set; }    //Color
        public Color SecondaryColor { get; set; }    //Color
        public Color BackgroundColor { get; set; }    //Color
        public Color NoiseColor { get; set; }    //Color
        public Nullable<float> NormalOrBroken { get; set; }    //Float
    }
    public partial class _rift_noise
    {
        public Nullable<float> EmissiveEVMin { get; set; }    //Float
        public Nullable<float> EmissiveEVMax { get; set; }    //Float
        public Color EmissiveColor { get; set; }    //Color
        public string EmissiveMask { get; set; }    //rRef:ITexture
        public string Dot { get; set; }    //rRef:ITexture
        public string Noise { get; set; }    //rRef:ITexture
        public Nullable<float> NoiseSpeed { get; set; }    //Float
        public Nullable<float> NoiseScale { get; set; }    //Float
        public Vec4 NoiseScaleXY { get; set; }    //Vector4
        public string DistanceNoise { get; set; }    //rRef:ITexture
        public Nullable<float> DistanceNoiseScale { get; set; }    //Float
        public Vec4 DistanceNoiseScaleXY { get; set; }    //Vector4
        public Nullable<float> DistanceNoiseAmount { get; set; }    //Float
        public Nullable<float> DistPower { get; set; }    //Float
        public Nullable<float> DotsLift { get; set; }    //Float
        public Nullable<float> DotsMax { get; set; }    //Float
        public Nullable<float> DistanceNoiseSpeed { get; set; }    //Float
        public Nullable<float> MaxDistance { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
    }
    public partial class _screen_wave
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> DistortAmount { get; set; }    //Float
    }
    public partial class _simple_fog
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Mask { get; set; }    //rRef:ITexture
        public Color Color { get; set; }    //Color
        public Nullable<float> Brightness { get; set; }    //Float
        public Nullable<float> MinimumVisibilityDistance { get; set; }    //Float
        public Nullable<float> VisibilityFadeIn { get; set; }    //Float
        public Nullable<float> TextureFalloff { get; set; }    //Float
        public Nullable<float> MinimumBottonDistance { get; set; }    //Float
        public Nullable<float> BottomVisibilityFadeIn { get; set; }    //Float
        public Nullable<float> DepthDivision { get; set; }    //Float
        public Nullable<float> DepthContrast { get; set; }    //Float
        public Nullable<float> SoftAlpha { get; set; }    //Float
        public Nullable<float> SteepAngleBlend { get; set; }    //Float
        public Nullable<float> SteepAngleBlendLength { get; set; }    //Float
    }
    public partial class _simple_refraction_mask
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> RefractionStrength { get; set; }    //Float
        public Vec4 RefractionTextureOffset { get; set; }    //Vector4
        public Vec4 RefractionTextureSpeed { get; set; }    //Vector4
        public Vec4 RefractionTextureScale { get; set; }    //Vector4
        public string Refraction { get; set; }    //rRef:ITexture
        public Nullable<float> UseAlphaMask { get; set; }    //Float
        public string AlphaMask { get; set; }    //rRef:ITexture
        public Nullable<float> UseDepth { get; set; }    //Float
        public Nullable<float> SlowFactor { get; set; }    //Float
        public Nullable<float> RefractionStrengthSlowTime { get; set; }    //Float
        public Nullable<float> MaskGradientPower { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> SoftAlpha { get; set; }    //Float
    }
    public partial class _transparent_flowmap
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public string Flowmap { get; set; }    //rRef:ITexture
        public Nullable<float> FlowMapStrength { get; set; }    //Float
        public Nullable<float> FlowSpeed { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> Multiplier { get; set; }    //Float
        public Nullable<float> Power { get; set; }    //Float
    }
    public partial class _transparent_liquid_notxaa
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> SurfaceMetalness { get; set; }    //Float
        public Color ScatteringColorThin { get; set; }    //Color
        public Color ScatteringColorThick { get; set; }    //Color
        public Color Albedo { get; set; }    //Color
        public Nullable<float> IOR { get; set; }    //Float
        public Nullable<float> FresnelBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Roughness { get; set; }    //Float
        public Nullable<float> SpecularStrengthMultiplier { get; set; }    //Float
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> MaskOpacity { get; set; }    //Float
        public Nullable<float> ThicknessMultiplier { get; set; }    //Float
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> InterpolateFrames { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public Vec4 NormalTilingAndScrolling { get; set; }    //Vector4
        public string Distort { get; set; }    //rRef:ITexture
        public Nullable<float> DistortAmount { get; set; }    //Float
        public Vec4 DistortTilingAndScrolling { get; set; }    //Vector4
        public string Mask { get; set; }    //rRef:ITexture
        public Nullable<float> EnableRowAnimation { get; set; }    //Float
        public Nullable<float> UseOnStaticMeshes { get; set; }    //Float
    }
    public partial class _world_to_screen_glitch
    {
        public Nullable<float> OffsetAmount { get; set; }    //Float
        public Nullable<float> Spread { get; set; }    //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> DistortionAmount { get; set; }    //Float
        public Nullable<float> Divisions { get; set; }    //Float
        public Nullable<float> GlitchChance { get; set; }    //Float
        public Nullable<float> GlitchSpeed { get; set; }    //Float
        public Nullable<float> GlowMultipier { get; set; }    //Float
        public Nullable<float> DistortGlitchDivisions { get; set; }    //Float
        public Nullable<float> DistortGlitchSpeed { get; set; }    //Float
        public Nullable<float> MidMaskWidth { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
    }
    public partial class _hit_proxy
    {
    }
    public partial class _lod_coloring
    {
    }
    public partial class _overdraw
    {
    }
    public partial class _overdraw_seethrough
    {
    }
    public partial class _selection
    {
    }
    public partial class _uv_density
    {
    }
    public partial class _wireframe
    {
    }
    public partial class _editor_mlmask_preview
    {
        public string MultilayerMask { get; set; }     //rRef:Multilayer_Mask
        public string MaskAtlas { get; set; }    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; }    //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; }    //Float
        public Vec4 MaskToTileScale { get; set; }    //Vector4
        public Nullable<float> MaskTileSize { get; set; }    //Float
        public Vec4 MaskAtlasDims { get; set; }    //Vector4
        public Vec4 MaskBaseResolution { get; set; }    //Vector4
        public Nullable<float> EditorMaskLayerIndex { get; set; }    //Float
        public Nullable<float> EditorVisualizationModeIndex { get; set; }    //Float
        public Nullable<float> EditorShowValue { get; set; }    //Float
        public Vec4 EditorCursorPosition { get; set; }    //Vector4
    }
    public partial class _editor_mltemplate_preview
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Vec4 ColorScale { get; set; }    //Vector4
        public Nullable<float> NormalScale { get; set; }    //Float
        public string RoughnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScaleIn { get; set; }    //Float
        public Nullable<float> MetalnessBiasIn { get; set; }    //Float
        public Nullable<float> RoughnessScaleIn { get; set; }    //Float
        public Nullable<float> RoughnessBiasIn { get; set; }    //Float
        public Nullable<float> MetalnessScaleOut { get; set; }    //Float
        public Nullable<float> MetalnessBiasOut { get; set; }    //Float
        public Nullable<float> RoughnessScaleOut { get; set; }    //Float
        public Nullable<float> RoughnessBiasOut { get; set; }    //Float
        public Nullable<float> ColorMaskScaleIn { get; set; }    //Float
        public Nullable<float> ColorMaskBiasIn { get; set; }    //Float
        public Nullable<float> ColorMaskScaleOut { get; set; }    //Float
        public Nullable<float> ColorMaskBiasOut { get; set; }    //Float
        public string MetalnessTexture { get; set; }    //rRef:ITexture
        public Nullable<float> Tiling { get; set; }    //Float
    }
    public partial class _gi_backface_debug
    {
    }
    public partial class _multilayered_baked
    {
        public Nullable<float> SurfaceID { get; set; }    //Float
        public string Indirection { get; set; }    //rRef:ITexture
        public string BaseColorRough { get; set; }    //rRef:ITexture
        public string NormalMetal { get; set; }    //rRef:ITexture
    }
    public partial class _mikoshi_fullscr_transition
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public string Mask { get; set; }    //rRef:ITexture
    }
    public partial class _decal
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _decal_normal
    {
        public string DiffuseTexture { get; set; }    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; }    //Float
        public string NormalTexture { get; set; }    //rRef:ITexture
        public Color DiffuseColor { get; set; }    //Color
        public Nullable<float> AlphaMaskContrast { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; }    //Float
        public Nullable<float> SubUVx { get; set; }    //Float
        public Nullable<float> SubUVy { get; set; }    //Float
        public Nullable<float> Frame { get; set; }    //Float
    }
    public partial class _pbr_layer
    {
        public string Diffuse { get; set; }    //rRef:ITexture
        public string Mask { get; set; }    //rRef:ITexture
        public string GlobalNormal { get; set; }    //rRef:ITexture
        public string MicroBlends { get; set; }    //rRef:ITexture
        public string Normal { get; set; }    //rRef:ITexture
        public string RoughMetalBlend { get; set; }    //rRef:ITexture
        public Color TintColor { get; set; }    //Color
        public Nullable<float> LayerTile { get; set; }    //Float
        public Nullable<float> MicroblendTile { get; set; }    //Float
        public Nullable<float> MicroblendContrast { get; set; }    //Float
        public Nullable<float> MicroblendNormalStrength { get; set; }    //Float
        public Nullable<float> LayerOpacity { get; set; }    //Float
        public Nullable<float> LayerOffsetU { get; set; }    //Float
        public Nullable<float> LayerOffsetV { get; set; }    //Float
        public Nullable<float> is_df { get; set; }    //Float
    }
    public partial class _debugdraw
    {
    }
    public partial class _fallback
    {
    }
    public partial class _metal_base
    {
        public Nullable<float> VehicleDamageInfluence { get; set; }    //Float
        public string BaseColor { get; set; }    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; }    //Vector4
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; }    //Float
        public Nullable<float> AlphaThreshold { get; set; }    //Float
        public string Emissive { get; set; }    //rRef:ITexture
        public Nullable<float> EmissiveLift { get; set; }    //Float
        public Nullable<float> EmissiveEV { get; set; }    //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; }    //Float
        public Nullable<float> EmissiveDirectionality { get; set; }    //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; }    //Float
        public Color EmissiveColor { get; set; }    //Color
        public Nullable<float> LayerTile { get; set; }    //Float
    }
    public partial class _mirror
    {
        public string BaseColor { get; set; }    //rRef:ITexture
        public string BorderMask { get; set; }    //rRef:ITexture
        public Color BaseColorScale { get; set; }    //Color
        public string Metalness { get; set; }    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; }    //Float
        public Nullable<float> MetalnessBias { get; set; }    //Float
        public string Roughness { get; set; }    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; }    //Float
        public Nullable<float> RoughnessBias { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public Nullable<float> Translucency { get; set; }    //Float
        public Nullable<float> BorderThickness { get; set; }    //Float
        public Color BorderColor { get; set; }    //Color
    }
    public partial class _particles_generic
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Color Color { get; set; }    //Color
        public Nullable<float> ColorMultiplier { get; set; }    //Float
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> Desaturate { get; set; }    //Float
        public Nullable<float> ColorPower { get; set; }    //Float
        public Nullable<float> DistortAmount { get; set; }    //Float
        public Vec4 TexCoordScale { get; set; }    //Vector4
        public Vec4 TexCoordSpeed { get; set; }    //Vector4
        public Vec4 TexCoordDtortScale { get; set; }    //Vector4
        public Vec4 TexCoordDistortSpeed { get; set; }    //Vector4
        public Nullable<float> AlphaGlobal { get; set; }    //Float
        public Nullable<float> AlphaSoft { get; set; }    //Float
        public Nullable<float> AlphaFresnelPower { get; set; }    //Float
        public Nullable<float> UseAlphaFresnel { get; set; }    //Float
        public Nullable<float> UseAlphaMask { get; set; }    //Float
        public Nullable<float> UseOneChannel { get; set; }    //Float
        public string Diffuse { get; set; }    //rRef:ITexture
        public string AlphaMask { get; set; }    //rRef:ITexture
        public Nullable<float> FlipUVby90deg { get; set; }    //Float
        public Nullable<float> EVCompensation { get; set; }    //Float
        public string Distortion { get; set; }    //rRef:ITexture
        public Nullable<float> UseContrastAlpha { get; set; }    //Float
        public Nullable<float> SoftUVInterpolate { get; set; }    //Float
    }
    public partial class _particles_liquid
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; }    //Float
        public Nullable<float> SubUVWidth { get; set; }    //Float
        public Nullable<float> SubUVHeight { get; set; }    //Float
        public Nullable<float> Desaturate { get; set; }    //Float
        public Nullable<float> DistortAmount { get; set; }    //Float
        public Vec4 TexCoordScale { get; set; }    //Vector4
        public Vec4 TexCoordSpeed { get; set; }    //Vector4
        public Vec4 TexCoordDtortScale { get; set; }    //Vector4
        public Vec4 TexCoordDistortSpeed { get; set; }    //Vector4
        public Nullable<float> AlphaGlobal { get; set; }    //Float
        public Nullable<float> AlphaSoft { get; set; }    //Float
        public Nullable<float> AlphaFresnelPower { get; set; }    //Float
        public Nullable<float> UseAlphaFresnel { get; set; }    //Float
        public Nullable<float> UseAlphaMask { get; set; }    //Float
        public Vec4 NormalMultiplier { get; set; }    //Vector4
        public Nullable<float> ReflectionMultiplier { get; set; }    //Float
        public Nullable<float> ReflectionPower { get; set; }    //Float
        public Color ReflectionColor { get; set; }    //Color
        public Nullable<float> RefractionMultiplier { get; set; }    //Float
        public string Normal { get; set; }    //rRef:ITexture
        public string AlphaMask { get; set; }    //rRef:ITexture
        public string Distortion { get; set; }    //rRef:ITexture
        public string Reflection { get; set; }     //rRef:ITexture
        public Nullable<float> SoftUVInterpolate { get; set; }    //Float
        public Nullable<float> ReflectionEdge { get; set; }    //Float
        public Color MainColor { get; set; }    //Color
    }

    public class Color
    {
        public Byte Red { get; set; }
        public Byte Green { get; set; }
        public Byte Blue { get; set; }
        public Byte Alpha { get; set; }

        public Color(CColor c)
        {
            Red = c.Red.Value;
            Green = c.Green.Value;
            Blue = c.Blue.Value;
            Alpha = c.Alpha.Value;
        }
        public Color()
        {
            Red = 255;
            Green= 255;
            Blue = 255;
            Alpha = 255;
        }
    }
    public class Vec4
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W { get; set; }

        public Vec4(Vector4 v)
        {
            X = v.X.Value;
            Y = v.Y.Value;
            Z = v.Z.Value;
            W = v.W.Value;
        }
        public Vec4()
        {
            X = 0;
            Y = 0;
            Z = 0;
            W = 0;
        }
    }
}

