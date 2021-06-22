using WolvenKit.RED4.CR2W.Types;
using System;

namespace WolvenKit.Modkit.RED4.Materials.Types
{
    public partial class _3d_map
    {
        public Color Color { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> Opacity { get; set; } = 0.2f;     //Float
        public Nullable<float> Lighting { get; set; } = 2f;     //Float
        public Nullable<float> ParticleSize { get; set; } = 1f;     //Float
        public Nullable<float> WorldScale { get; set; } = 1f;     //Float
        public string WorldColorTex { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public string WorldPosTex { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public string WorldNormalTex { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string WorldDepthTex { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0.9f;     //Float
    }
    public partial class _3d_map_cubes
    {
        public Nullable<float> PointCloudTextureHeight { get; set; } = 0f;     //Float
        public Vec4 TransMin { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 TransMax { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string WorldPosTex { get; set; } = @"base\fx\textures\techart\cyberparticles\cache1k_position_sphere.xbm";    //rRef:ITexture
        public Nullable<float> CubeSize { get; set; } = 100f;     //Float
        public Nullable<float> ColorGradient { get; set; } = 0f;     //Float
        public Vec4 DebugScaleOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> DissolveDistance { get; set; } = 180f;     //Float
        public Nullable<float> DissolveBandWidth { get; set; } = 25f;     //Float
        public Nullable<float> DissolveCellSize { get; set; } = 1f;     //Float
        public Color DissolveBurnColor { get; set; } = new Color(0, 153, 255, 255);      //Color
        public Nullable<float> DissolveBurnStrength { get; set; } = 0.6f;     //Float
        public Nullable<float> DissolveBurnMinCameraSpeed { get; set; } = 2f;     //Float
        public Vec4 MapEdgeDissolveCenter { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MapEdgeDissolveRadiusStart { get; set; } = 4500f;     //Float
        public Nullable<float> MapEdgeDissolveRadiusBand { get; set; } = 1500f;     //Float
        public Nullable<float> MapEdgeDissolveCellSize { get; set; } = 20f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 130, 137, 255);      //Color
        public Color EdgeColor { get; set; } = new Color(255, 145, 160, 255);      //Color
        public Nullable<float> EdgeThickness { get; set; } = 0.001f;     //Float
        public Nullable<float> EdgeSharpnessPower { get; set; } = 30f;     //Float
        public string Metalness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0.8f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _3d_map_solid
    {
        public Nullable<float> RenderOnTop { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Color Color { get; set; } = new Color(200, 200, 255, 10);      //Color
    }
    public partial class _beyondblackwall
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string DiffuseMap { get; set; } = @"base\worlds\03_night_city\sectors\c_pacifica\coastview\loc_q110_elders_lair\loc_q110_elders_lair_env\beyond_blackwall\beyondblackwall.xbm";    //rRef:ITexture
        public string HeightMap { get; set; } = @"base\worlds\03_night_city\sectors\c_pacifica\coastview\loc_q110_elders_lair\loc_q110_elders_lair_env\beyond_blackwall\beyondblackwall_height.xbm";    //rRef:ITexture
        public Nullable<float> Height { get; set; } = 7.708333f;     //Float
        public Nullable<float> Intensity { get; set; } = 4.6875f;     //Float
        public Nullable<float> AnimBlend { get; set; } = 0f;     //Float
        public Nullable<float> SmallDistortionStrenght { get; set; } = 0.104167f;     //Float
        public Nullable<float> BigDistortionStrenght { get; set; } = 0.05f;     //Float
        public Nullable<float> SmallDistortionTime { get; set; } = 0.08f;     //Float
        public Nullable<float> BigDistortionTime { get; set; } = 0.25f;     //Float
        public Nullable<float> VignetteIntensity { get; set; } = 4f;     //Float
        public Nullable<float> LuminancePower { get; set; } = 0.95f;     //Float
        public Nullable<float> CompareValue { get; set; } = -0.97f;     //Float
        public Nullable<float> PixelStretchBlend { get; set; } = 1f;     //Float
    }
    public partial class _beyondblackwall_chars
    {
        public string BaseColor { get; set; } = @"base\worlds\03_night_city\sectors\c_pacifica\coastview\loc_q110_elders_lair\loc_q110_elders_lair_env\beyond_blackwall\beyondblackwall_chars.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Nullable<float> TextureColorBlend { get; set; } = 0f;     //Float
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
        public Nullable<float> Roughness { get; set; } = 0.5f;     //Float
        public Nullable<float> AtlasSize { get; set; } = 4f;     //Float
        public Nullable<float> AtlasID { get; set; } = 0f;     //Float
        public Nullable<float> SmallDistortionStrenght { get; set; } = 2f;     //Float
        public Nullable<float> BigDistortionStrenght { get; set; } = 0.9f;     //Float
        public Nullable<float> SmallDistortionTime { get; set; } = 0.15f;     //Float
        public Nullable<float> BigDistortionTime { get; set; } = 0.66f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.5f;     //Float
    }
    public partial class _beyondblackwall_sky
    {
        public string SkyDiffuse { get; set; } = @"base\fx\_textures\masks\noise\fx_organic_noise_01_d.xbm";    //rRef:ITexture
        public string SkySorted { get; set; } = @"base\worlds\03_night_city\sectors\c_pacifica\coastview\loc_q110_elders_lair\loc_q110_elders_lair_env\beyond_blackwall\blackwall_sky_sorting.xbm";    //rRef:ITexture
        public string SkySortMask { get; set; } = @"base\worlds\03_night_city\sectors\c_pacifica\coastview\loc_q110_elders_lair\loc_q110_elders_lair_env\beyond_blackwall\blackwall_sky_sorting_mask.xbm";    //rRef:ITexture
        public string NoiseMap { get; set; } = @"base\fx\_textures\masks\noise\fx_perlin_noise_3d_01_d.xbm";    //rRef:ITexture
        public string SilhouetteDiffuse { get; set; } = @"base\worlds\03_night_city\sectors\c_pacifica\coastview\loc_q110_elders_lair\loc_q110_elders_lair_env\beyond_blackwall\beyondblackwall_chars.xbm";    //rRef:ITexture
        public string SilhouetteMask { get; set; } = @"base\worlds\03_night_city\sectors\c_pacifica\coastview\loc_q110_elders_lair\loc_q110_elders_lair_env\beyond_blackwall\beyondblackwall_chars_mask.xbm";    //rRef:ITexture
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> LightDirectionHorizontal { get; set; } = 0.225806f;     //Float
        public Nullable<float> LightDirectionVertical { get; set; } = 0.096774f;     //Float
        public Nullable<float> Wrap { get; set; } = 0.5f;     //Float
        public Nullable<float> WrapIntensity { get; set; } = 1f;     //Float
        public Vec4 FlashIntensity { get; set; } = new Vec4(100f, 10f, 10f, 10f);    //Vector4
        public Vec4 FlashTimeScale { get; set; } = new Vec4(1f, 1.33f, 2.66f, 4f);    //Vector4
        public Color LightColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> SkyAmbient { get; set; } = 0.05f;     //Float
        public Vec4 SkyParameter { get; set; } = new Vec4(10000f, 1f, 0f, 0f);    //Vector4
        public Vec4 SilhouetteUV { get; set; } = new Vec4(1.5f, 2f, 0f, 0.4f);    //Vector4
        public Nullable<float> CompareValue { get; set; } = -0.99f;     //Float
    }
    public partial class _beyondblackwall_sky_raymarch
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string NoiseTexture3D { get; set; } = @"base\worlds\03_night_city\sectors\c_pacifica\coastview\loc_q110_elders_lair\loc_q110_elders_lair_env\beyond_blackwall\blackwall_sky_cloud_noise.xbm";    //rRef:ITexture
        public string VolumeNoise { get; set; } = @"base\textures\clouds\cloud_noise.xbm";    //rRef:ITexture
        public string ScreenNoise { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_01_d.xbm";    //rRef:ITexture
        public Color LightColor { get; set; } = new Color(255, 18, 18, 255);      //Color
        public Nullable<float> LightIntensity { get; set; } = 2.5f;     //Float
        public Nullable<float> LightVectorXY { get; set; } = 0.8f;     //Float
        public Nullable<float> LightVectorZ { get; set; } = 0.6f;     //Float
        public Color SkyColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> VectorNoiseSize { get; set; } = 100f;     //Float
        public Nullable<float> VectorNoiseIntensity { get; set; } = 10f;     //Float
        public Color AmbientLightTop { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color AmbientLightBottom { get; set; } = new Color(182, 182, 182, 255);      //Color
        public Nullable<float> CoverageShift { get; set; } = 0.45f;     //Float
        public Nullable<float> JitterIntensity { get; set; } = 0.2f;     //Float
        public Nullable<float> EmisssivIntensity { get; set; } = 10f;     //Float
        public Nullable<float> CloudScaleXY { get; set; } = 10000f;     //Float
        public Nullable<float> CloudScaleZ { get; set; } = 2000f;     //Float
        public Nullable<float> CloudPositionZ { get; set; } = 0f;     //Float
        public Vec4 NoiseOffset { get; set; } = new Vec4(1f, 0f, 0f, 20f);    //Vector4
        public Vec4 FlashAreaOffset { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SphereOffsetZ { get; set; } = 0f;     //Float
        public Nullable<float> SphereSize { get; set; } = 0f;     //Float
        public Vec4 SphereOffsetVec { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> NoiseSize { get; set; } = 2500f;     //Float
        public Nullable<float> CloudDensity { get; set; } = 35f;     //Float
        public Nullable<float> DetailNoiseSize { get; set; } = 250f;     //Float
        public Vec4 DetailNoiseOffset { get; set; } = new Vec4(0f, 1f, 0f, 5f);    //Vector4
        public Vec4 ScreenNoiseVec { get; set; } = new Vec4(2f, 3f, 0.15f, 0.75f);    //Vector4
        public Vec4 Samples { get; set; } = new Vec4(64f, 24f, 0f, 8000f);    //Vector4
        public Vec4 SkyBlend { get; set; } = new Vec4(0.75f, 50000f, 50000f, 1500000f);    //Vector4
        public Vec4 Scatter { get; set; } = new Vec4(0.5f, 0.2f, 0.75f, 1f);    //Vector4
        public Vec4 SilverLightCone { get; set; } = new Vec4(5f, 0.75f, 100f, 200f);    //Vector4
    }
    public partial class _blood_puddle_decal
    {
        public string NoiseTexture { get; set; } = @"base\fx\_textures\masks\noise\fx_perlin_noise_01_d.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(102, 13, 13, 255);      //Color
        public Nullable<float> Roughness { get; set; } = 0f;     //Float
        public Nullable<float> Squash { get; set; } = 1.4f;     //Float
        public Nullable<float> Curls { get; set; } = 1.6f;     //Float
        public Nullable<float> Details { get; set; } = 0.5f;     //Float
        public Nullable<float> Thickness { get; set; } = 150f;     //Float
        public Nullable<float> ProgressiveOpacity { get; set; } = 0f;     //Float
    }
    public partial class _cable
    {
        public Nullable<float> VehicleDamageInfluence { get; set; } = 0f;     //Float
        public Nullable<float> ThicknessStart { get; set; } = 0.03f;     //Float
        public Nullable<float> ThicknessEnd { get; set; } = -0.01f;     //Float
        public Nullable<float> RangeStart { get; set; } = 25f;     //Float
        public Nullable<float> RangeEnd { get; set; } = 100f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(0.6431373f, 0.63529414f, 0.61960787f, 0.6431373f);    //Vector4
        public string Metalness { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0.2f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 1f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0.833856f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0.15047f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 0f;     //Float
        public string Emissive { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveLift { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 1f;     //Float
        public Nullable<float> LayerTile { get; set; } = 0f;     //Float
    }
    public partial class _circuit_wires
    {
        public Nullable<float> PointCloudTextureRes { get; set; } = 512f;     //Float
        public Nullable<float> TransMin { get; set; } = -100f;     //Float
        public Nullable<float> TransMax { get; set; } = 100f;     //Float
        public string WorldPosTex { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> WireThickness { get; set; } = 0.1f;     //Float
        public Vec4 InstanceOffset { get; set; } = new Vec4(0f, 100f, 0f, 0f);    //Vector4
        public Vec4 LocalNormal { get; set; } = new Vec4(0f, 0f, 1f, 0f);    //Vector4
        public Nullable<float> BevelStrenght { get; set; } = 2f;     //Float
        public Nullable<float> DebugVC { get; set; } = 0f;     //Float
        public Nullable<float> DebugID { get; set; } = 0f;     //Float
        public Color BaseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
        public Nullable<float> Roughness { get; set; } = 0.5f;     //Float
        public string Normal { get; set; } = @"base\surfaces\materials\default\default_n.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _cloth_mov
    {
        public string vertex_paint_tex { get; set; } = @"base\fx\textures\cache\gate_anim_data.xbm";    //rRef:ITexture
        public Nullable<float> trans_min { get; set; } = 0f;     //Float
        public Nullable<float> trans_max { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 0f;     //Float
        public Nullable<float> n_pieces { get; set; } = 0f;     //Float
        public Nullable<float> play_time { get; set; } = 0f;     //Float
        public Nullable<float> frame_rate { get; set; } = 24f;     //Float
        public string BaseColor { get; set; } = @"base\materials\placeholder\grey.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"base\materials\placeholder\grey.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public Nullable<float> LayerTile { get; set; } = 0f;     //Float
    }
    public partial class _cloth_mov_multilayered
    {
        public string vertex_paint_tex { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> trans_min { get; set; } = 0f;     //Float
        public Nullable<float> trans_max { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 0f;     //Float
        public Nullable<float> n_pieces { get; set; } = 0f;     //Float
        public Nullable<float> play_time { get; set; } = 0f;     //Float
        public Nullable<float> frame_rate { get; set; } = 24f;     //Float
        public string GlobalNormal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string MultilayerMask { get; set; } = @"engine\materials\defaults\multilayer_default.mlmask";     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; } = @"engine\materials\defaults\multilayer_default.mlsetup";     //rRef:Multilayer_Setup
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
    }
    public partial class _cyberparticles_base
    {
        public Vec4 trans_extent { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> Contrast { get; set; } = 1f;     //Float
        public Nullable<float> AddSizeX { get; set; } = 0f;     //Float
        public Nullable<float> AddSizeY { get; set; } = 0f;     //Float
        public Nullable<float> Width { get; set; } = 0f;     //Float
        public Nullable<float> Height { get; set; } = 0f;     //Float
        public string WorldColorTex { get; set; } = @"base\fx\textures\techart\cyberparticles\cache1k_position_sphere.xbm";    //rRef:ITexture
        public string WorldPosTex { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> WorldSize { get; set; } = 1f;     //Float
        public Nullable<float> ParticleSize { get; set; } = 0.01f;     //Float
        public Nullable<float> DissolveTime { get; set; } = 0f;     //Float
        public Nullable<float> DissolveGlobalTime { get; set; } = 1f;     //Float
        public Nullable<float> DissolveDeltaScale { get; set; } = 1f;     //Float
        public Nullable<float> DissolveNoiseScale { get; set; } = 1f;     //Float
        public Nullable<float> DissolveParticleSize { get; set; } = 0.3f;     //Float
        public Nullable<float> WarpTime { get; set; } = 0f;     //Float
        public Vec4 WarpLocation { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> StretchMul { get; set; } = 0f;     //Float
        public Nullable<float> StretchMax { get; set; } = 1f;     //Float
        public Nullable<float> UnRevealTime { get; set; } = 0f;     //Float
        public Nullable<float> Displace01 { get; set; } = 0f;     //Float
        public Nullable<float> Displace02 { get; set; } = 0f;     //Float
        public Nullable<float> GlobalNoiseScale { get; set; } = 0.24f;     //Float
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_03\braindance_noise3d_03.texarray";    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; } = 32f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> Opacity { get; set; } = 1f;     //Float
        public Color Tint { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string Mask { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\point_mask.xbm";    //rRef:ITexture
    }
    public partial class _cyberparticles_blackwall
    {
        public string VideoRT { get; set; } = @"base\fx\textures\techart\cyberparticles\blackwall_background.xbm";    //rRef:ITexture
        public string GradientTex { get; set; } = @"base\fx\textures\techart\cyberparticles\gradient.xbm";    //rRef:ITexture
        public string DisturbTex { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\disturb_hit.xbm";    //rRef:ITexture
        public Nullable<float> Opacity { get; set; } = 0.5f;     //Float
        public Nullable<float> UsesInstancing { get; set; } = 0f;     //Float
        public Nullable<float> DisturbRadius { get; set; } = 40f;     //Float
        public Nullable<float> DisturbCurveFrequency { get; set; } = 2f;     //Float
        public Nullable<float> DisturbMul { get; set; } = 1f;     //Float
        public Nullable<float> DisturbTime { get; set; } = 0f;     //Float
        public Nullable<float> DisturbNoiseScale { get; set; } = 0.04f;     //Float
        public Nullable<float> DisturbScale { get; set; } = 0.5f;     //Float
        public Nullable<float> DisturbBrighten { get; set; } = 40f;     //Float
        public Vec4 DisturbLocation1 { get; set; } = new Vec4(20f, -40f, 30f, 0f);    //Vector4
        public Vec4 DisturbLocation2 { get; set; } = new Vec4(30f, 0f, 20f, 0f);    //Vector4
        public Nullable<float> TimeFactor { get; set; } = 0.1f;     //Float
        public Vec4 Scale { get; set; } = new Vec4(120f, 45f, 4f, 0f);    //Vector4
        public Vec4 Dimensions { get; set; } = new Vec4(512f, 512f, 4f, 0f);    //Vector4
        public Vec4 TexTiling { get; set; } = new Vec4(2f, 2f, 0f, 0f);    //Vector4
        public Nullable<float> Contrast { get; set; } = 0.5f;     //Float
        public Nullable<float> AddSizeX { get; set; } = 0.01f;     //Float
        public Nullable<float> AddSizeY { get; set; } = 0.1f;     //Float
        public Nullable<float> ParticleSize { get; set; } = 0.01f;     //Float
        public Nullable<float> WarpTime { get; set; } = 0f;     //Float
        public Vec4 WarpLocation { get; set; } = new Vec4(0f, 600f, 0f, 0f);    //Vector4
        public Nullable<float> StretchMul { get; set; } = 1f;     //Float
        public Nullable<float> StretchMax { get; set; } = 40f;     //Float
        public Nullable<float> CNoiseAdjust { get; set; } = 1f;     //Float
        public Nullable<float> Align { get; set; } = 0f;     //Float
        public Vec4 HighFreqFade { get; set; } = new Vec4(1f, 4f, 2f, 1f);    //Vector4
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_03\braindance_noise3d_03.texarray";    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; } = 32f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Color Tint { get; set; } = new Color(70, 20, 25, 255);      //Color
    }
    public partial class _cyberparticles_blackwall_touch
    {
        public Nullable<float> Opacity { get; set; } = 0.5f;     //Float
        public Nullable<float> RippleSize { get; set; } = 1f;     //Float
        public Nullable<float> RippleSpeed { get; set; } = 1f;     //Float
        public Nullable<float> RippleNumber { get; set; } = 10f;     //Float
        public Nullable<float> RippleHeight { get; set; } = 0.2f;     //Float
        public Vec4 RipplePosition { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 RippleDirection { get; set; } = new Vec4(0f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> TimeFactor { get; set; } = 0.1f;     //Float
        public Vec4 Scale { get; set; } = new Vec4(120f, 45f, 4f, 0f);    //Vector4
        public Vec4 Dimensions { get; set; } = new Vec4(512f, 512f, 4f, 0f);    //Vector4
        public Vec4 TexTiling { get; set; } = new Vec4(2f, 2f, 0f, 0f);    //Vector4
        public Nullable<float> Contrast { get; set; } = 2f;     //Float
        public Nullable<float> AddSizeX { get; set; } = 0.01f;     //Float
        public Nullable<float> AddSizeY { get; set; } = 0.1f;     //Float
        public Nullable<float> ParticleSize { get; set; } = 0.01f;     //Float
        public Nullable<float> WarpTime { get; set; } = 1f;     //Float
        public Vec4 WarpLocation { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> StretchMul { get; set; } = 1f;     //Float
        public Nullable<float> StretchMax { get; set; } = 20f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Color Tint { get; set; } = new Color(59, 200, 255, 255);      //Color
        public Color TintPulse { get; set; } = new Color(206, 129, 181, 255);      //Color
    }
    public partial class _cyberparticles_braindance
    {
        public Nullable<float> DebugAlwaysShow { get; set; } = 1f;     //Float
        public Nullable<float> DebugDisplayUV { get; set; } = 0f;     //Float
        public Nullable<float> NumQuadsX { get; set; } = 512f;     //Float
        public Nullable<float> Opacity { get; set; } = 1f;     //Float
        public Nullable<float> ParticleSize { get; set; } = 0.015f;     //Float
        public string WorldPosTex { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public string RevealMask { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> RevealMaskFramesY { get; set; } = 4f;     //Float
        public Vec4 RevealMaskBoundsMin { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 RevealMaskBoundsMax { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public string FlowMap0 { get; set; } = @"base\fx\textures\braindance\braindance_noise_data.xbm";    //rRef:ITexture
        public string CluesMap { get; set; } = @"base\fx\textures\braindance\braindance_clue_default_data.xbm";    //rRef:ITexture
        public Nullable<float> CharacterBlobRadius { get; set; } = 10f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string MaskParticle { get; set; } = @"base\fx\textures\braindance\braindance_particle_masks_data.xbm";    //rRef:ITexture
    }
    public partial class _cyberparticles_dynamic
    {
        public Nullable<float> Opacity { get; set; } = 1f;     //Float
        public Nullable<float> ParticleSize { get; set; } = 0.0015f;     //Float
        public Nullable<float> JitterStrength { get; set; } = 0.8f;     //Float
        public string WorldPosTex { get; set; } = @"base\fx\textures\braindance\render_targets\braindance_rt_pos_00.dtex";    //rRef:ITexture
        public string NormalTex { get; set; } = @"base\fx\textures\braindance\render_targets\braindance_rt_normal_00.dtex";    //rRef:ITexture
        public Nullable<float> NumQuadsX { get; set; } = 256f;     //Float
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_00\braindance_noise3d_00.texarray";    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; } = 32f;     //Float
        public Vec4 VectorFieldTiling { get; set; } = new Vec4(1.4f, 1.4f, 1.4f, 0f);    //Vector4
        public Vec4 VectorFieldAnimSpeed { get; set; } = new Vec4(-0.4f, 0f, 0f, 0f);    //Vector4
        public Vec4 VectorFieldDisplacementStrength { get; set; } = new Vec4(0.2f, 0.03f, 0f, 0.1f);    //Vector4
        public Nullable<float> Scale { get; set; } = 1f;     //Float
        public Nullable<float> UsePivotAsOffset { get; set; } = 0f;     //Float
        public Vec4 OriginalPivotWorldPosition { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Color ColorMain { get; set; } = new Color(252, 25, 85, 255);      //Color
        public Nullable<float> Brightness { get; set; } = 0.7f;     //Float
        public Nullable<float> BrightnessTop { get; set; } = 2.5f;     //Float
        public Nullable<float> HACK_Q110_IsElder { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
    }
    public partial class _cyberparticles_platform
    {
        public string BlueNoise { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\blue_noise_256x256.xbm";    //rRef:ITexture
        public string DataTex { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\cyberplatform_datatex.xbm";    //rRef:ITexture
        public string BlackTex { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\cyberplatform_black.xbm";    //rRef:ITexture
        public Nullable<float> UnRevealTime { get; set; } = 5f;     //Float
        public Nullable<float> RevealDirection { get; set; } = -1f;     //Float
        public Nullable<float> ColorMul { get; set; } = 2f;     //Float
        public Nullable<float> MovementScale { get; set; } = 0.998873f;     //Float
        public Nullable<float> DistanceFade { get; set; } = 0.998873f;     //Float
        public Nullable<float> FloorScale { get; set; } = 2f;     //Float
        public Vec4 BlockSize { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Nullable<float> CityTilingX { get; set; } = 1f;     //Float
        public Nullable<float> CityTilingY { get; set; } = 1f;     //Float
        public Nullable<float> SideTilingX { get; set; } = 1f;     //Float
        public Nullable<float> SideTilingY { get; set; } = 1f;     //Float
        public Nullable<float> AddSizeX { get; set; } = 1f;     //Float
        public Nullable<float> AddSizeY { get; set; } = 1f;     //Float
        public Nullable<float> Width { get; set; } = 250f;     //Float
        public Nullable<float> Height { get; set; } = 250f;     //Float
        public Nullable<float> Depth { get; set; } = 250f;     //Float
        public Vec4 NoiseScale { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Vec4 NoiseSize { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Nullable<float> TranslateTime { get; set; } = 0f;     //Float
        public Vec4 TranslateDestination { get; set; } = new Vec4(0f, -5000f, 150f, 0f);    //Vector4
        public Nullable<float> StretchMul { get; set; } = 71.70237f;     //Float
        public Nullable<float> StretchMax { get; set; } = 95.38808f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> Opacity { get; set; } = 0.998873f;     //Float
        public Color Tint { get; set; } = new Color(255, 255, 255, 255);      //Color
    }
    public partial class _decal_emissive_color
    {
        public string Emissive { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(254, 254, 254, 254);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveAlphaThreshold { get; set; } = 0.005f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _decal_emissive_only
    {
        public string EmissiveMask { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveAlphaThreshold { get; set; } = 0.005f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _decal_forward
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessScale { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.01f;     //Float
        public Nullable<float> Alpha { get; set; } = 1f;     //Float
    }
    public partial class _decal_gradientmap_recolor
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string MaskTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public string GradientMap { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _decal_gradientmap_recolor_emissive
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string MaskTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public string GradientMap { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string EmissiveGradientMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _decal_normal_roughness
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _decal_normal_roughness_metalness
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _decal_normal_roughness_metalness_2
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 0);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Vec4 AtlasSize { get; set; } = new Vec4(1024f, 1024f, 0f, 0f);    //Vector4
        public Vec4 SubRegion { get; set; } = new Vec4(400f, 0f, 80f, 1024f);    //Vector4
    }
    public partial class _decal_parallax
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Vec4 AtlasSize { get; set; } = new Vec4(1024f, 1024f, 0f, 0f);    //Vector4
        public Vec4 SubRegion { get; set; } = new Vec4(400f, 0f, 80f, 0f);    //Vector4
        public string HeightTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> HeightStrength { get; set; } = 0f;     //Float
    }
    public partial class _decal_puddle
    {
        public string DiffuseTexture { get; set; } = @"base\surfaces\textures\decals\megabuiding\puddle\puddle_d.xbm";    //rRef:ITexture
        public string NormalTexture { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"base\surfaces\textures\decals\megabuiding\puddle\puddle_r.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public Nullable<float> DiffuseAlpha { get; set; } = 0.083333f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _decal_roughness
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _decal_roughness_only
    {
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _decal_terrain_projected
    {
        public string AlphaMask { get; set; } = @"base\environment\terrain\decals\textures\terrain_decal_mask_generic.xbm";    //rRef:ITexture
        public Nullable<float> AlphaMaskBlackPoint { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskWhitePoint { get; set; } = 1f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(0.5f, 0.5f, 0.5f, 0f);    //Vector4
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string SpecularIntensity { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Vec4 RoughnessLevels { get; set; } = new Vec4(1f, 0f, 1f, 0f);    //Vector4
        public Vec4 SpecularIntensityLevels { get; set; } = new Vec4(0f, 1f, 0f, 1f);    //Vector4
        public Vec4 ColorMaskLevels { get; set; } = new Vec4(1f, 0f, 1f, 0f);    //Vector4
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public string Microblend { get; set; } = @"base\surfaces\microblends\default.xbm";    //rRef:ITexture
        public Nullable<float> MicroblendContrast { get; set; } = 0.4f;     //Float
        public Nullable<float> MaterialTiling { get; set; } = 100f;     //Float
        public Nullable<float> LayerTiling { get; set; } = 1f;     //Float
        public Nullable<float> MicroblendTiling { get; set; } = 1f;     //Float
    }
    public partial class _decal_tintable
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string TintMaskTexture { get; set; } = @"test\env_test\masktest.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Color MaskColorR { get; set; } = new Color(192, 0, 1, 255);      //Color
        public Color MaskColorG { get; set; } = new Color(30, 189, 0, 255);      //Color
        public Color MaskColorB { get; set; } = new Color(0, 44, 226, 255);      //Color
        public Vec4 AtlasSize { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public Vec4 SubRegion { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
    }
    public partial class _diode_sign
    {
        public Color ColorForeground { get; set; } = new Color(255, 6, 0, 255);      //Color
        public Color ColorMiddle { get; set; } = new Color(255, 130, 3, 255);      //Color
        public Color ColorBackground { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
        public Nullable<float> Roughness { get; set; } = 0f;     //Float
        public Nullable<float> HeightIndex { get; set; } = 16f;     //Float
        public Nullable<float> WidthPixels { get; set; } = 512f;     //Float
        public Vec4 StretchFactor { get; set; } = new Vec4(1f, 5f, 0f, 0f);    //Vector4
        public Nullable<float> ScrollSpeed { get; set; } = 0.1f;     //Float
        public Nullable<float> DotSize { get; set; } = 0.464029f;     //Float
        public Nullable<float> Multiplier { get; set; } = 1f;     //Float
        public Nullable<float> AmountOfLayers { get; set; } = 1f;     //Float
        public Nullable<float> DotsSpacing { get; set; } = 0.5f;     //Float
        public Nullable<float> FarDotMultiplier { get; set; } = 0.1f;     //Float
        public Nullable<float> WidthPixelsStart { get; set; } = 0f;     //Float
        public Nullable<float> AllWidthPixels { get; set; } = 256f;     //Float
        public Nullable<float> AmountOfLines { get; set; } = 16f;     //Float
        public string Text { get; set; } = @"base\fx\textures\devices\advert.xbm";    //rRef:ITexture
    }
    public partial class _earth_globe
    {
        public string BaseColor { get; set; } = @"base\environment\decoration\unique\quest\q201_q203\textures\earth_base_color_4k.xbm";    //rRef:ITexture
        public string MultilayerMask { get; set; } = @"base\environment\decoration\unique\quest\q201_q203\textures\q201_q203_earth_globe.mlmask";     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; } = @"base\environment\decoration\unique\quest\q201_q203\textures\q201_q203_earth_globe.mlsetup";     //rRef:Multilayer_Setup
        public Nullable<float> MultilayerBlendStrength { get; set; } = 1f;     //Float
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public string CloudsMicroblend { get; set; } = @"base\surfaces\microblends\swirls_a.xbm";    //rRef:ITexture
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public string CityLightsMicroblend { get; set; } = @"base\surfaces\microblends\spots_and_scrapes.xbm";    //rRef:ITexture
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Vec4 SunDirection { get; set; } = new Vec4(1f, 0f, 0f, 0f);    //Vector4
        public string WaterMask { get; set; } = @"base\environment\decoration\unique\quest\q201_q203\textures\earth_water_4k.xbm";    //rRef:ITexture
        public string Clouds { get; set; } = @"base\environment\decoration\unique\quest\q201_q203\textures\earth_clouds_4k.xbm";    //rRef:ITexture
        public string CityLights { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> CloudIntensity { get; set; } = 1f;     //Float
        public Color CityLightsColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public string OceanDetailNormalMap { get; set; } = @"base\fx\textures\liquids\water_ocean_v01_0001.xbm";    //rRef:ITexture
        public Nullable<float> OceanRoughness { get; set; } = 0.2f;     //Float
        public string Normal { get; set; } = @"base\environment\decoration\unique\quest\q201_q203\textures\earth_normals_4k.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 0.4f;     //Float
    }
    public partial class _earth_globe_atmosphere
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Color AtmosphereColor { get; set; } = new Color(89, 165, 255, 255);      //Color
        public Color AtmosphereOrangeColor { get; set; } = new Color(255, 165, 89, 255);      //Color
        public Nullable<float> Brigthness { get; set; } = 2f;     //Float
        public Nullable<float> FresnelPower { get; set; } = 4f;     //Float
        public Nullable<float> TransmissionBoost { get; set; } = 2f;     //Float
        public Nullable<float> TransmissionBoostPower { get; set; } = 240f;     //Float
        public Nullable<float> EarthRadius { get; set; } = 1f;     //Float
        public Vec4 SunDirection { get; set; } = new Vec4(1f, 0f, 0f, 0f);    //Vector4
    }
    public partial class _earth_globe_lights
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Vec4 ScrollSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> HardOrSoftTransition { get; set; } = 0f;     //Float
        public Nullable<float> FullVisibilityFactor { get; set; } = 1f;     //Float
        public Nullable<float> EnableAlternateUVcoord { get; set; } = 0f;     //Float
        public Nullable<float> Preview2ndState { get; set; } = 0f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
        public string CityLightsMicroblend { get; set; } = @"base\surfaces\microblends\spots_and_scrapes.xbm";    //rRef:ITexture
        public Vec4 SunDirection { get; set; } = new Vec4(1f, 0f, 0f, 0f);    //Vector4
    }
    public partial class _emissive_control
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(0, 0, 0, 0);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public string Emissive { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _eye
    {
        public string Albedo { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"base\characters\common\eyes\textures\he_000_base_n01.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\characters\common\eyes\textures\he_000_base_rm01.xbm";    //rRef:ITexture
        public string Blick { get; set; } = @"base\characters\common\eyes\cube_blick_1.cubemap";     //rRef:ITexture
        public string NormalBubble { get; set; } = @"base\characters\common\eyes\textures\normal_bubble.xbm";    //rRef:ITexture
        public Nullable<float> RefractionIndex { get; set; } = 0.97f;     //Float
        public Nullable<float> RefractionAmount { get; set; } = 1f;     //Float
        public Nullable<float> EyeRadius { get; set; } = 0.0152f;     //Float
        public Nullable<float> EyeHorizAngleRight { get; set; } = 5f;     //Float
        public Nullable<float> EyeHorizAngleLeft { get; set; } = -5f;     //Float
        public Nullable<float> EyeParallaxPlane { get; set; } = 0.0134f;     //Float
        public Nullable<float> IrisSize { get; set; } = 0.737374f;     //Float
        public Nullable<float> IrisCoordMargin { get; set; } = 0.020202f;     //Float
        public Nullable<float> IrisCoordFactor { get; set; } = 0.164983f;     //Float
        public Nullable<float> BlickScale { get; set; } = 0.2f;     //Float
        public Nullable<float> BubbleNormalTile { get; set; } = 0.631313f;     //Float
        public Nullable<float> EggMarginExponent { get; set; } = 1f;     //Float
        public Nullable<float> EggMarginFactor { get; set; } = 0.4f;     //Float
        public Nullable<float> EggSubFactor { get; set; } = 0.2f;     //Float
        public Nullable<float> EggFullRadius { get; set; } = 1f;     //Float
        public Nullable<float> Specularity { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessScale { get; set; } = 0.493421f;     //Float
        public Nullable<float> SubsurfaceFactor { get; set; } = 0.2f;     //Float
        public Nullable<float> AntiLightbleedValue { get; set; } = 0.5f;     //Float
        public Nullable<float> AntiLightbleedUpOff { get; set; } = 0f;     //Float
    }
    public partial class _eye_blendable
    {
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_05\braindance_noise3d_05.texarray";    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; } = 0.5f;     //Float
        public Nullable<float> FadeOutOffset { get; set; } = 0.2f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 5f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 2f;     //Float
        public Color FresnelColor { get; set; } = new Color(0, 229, 255, 255);      //Color
        public string Albedo { get; set; } = @"base\characters\main_npc\silverhand\h0_001_ma_c__silverhand\textures\he_001_ma_c__silverhand_d01.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\characters\common\eyes\textures\he_000_base_rm01.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0.493421f;     //Float
        public string Blick { get; set; } = @"base\characters\common\eyes\cube_blick_1.cubemap";     //rRef:ITexture
        public string NormalBubble { get; set; } = @"base\characters\common\eyes\textures\normal_bubble.xbm";    //rRef:ITexture
        public Nullable<float> RefractionIndex { get; set; } = 0.97f;     //Float
        public Nullable<float> RefractionAmount { get; set; } = 1f;     //Float
        public Nullable<float> IrisSize { get; set; } = 0.737374f;     //Float
        public Nullable<float> EyeHorizAngleRight { get; set; } = 5f;     //Float
        public Nullable<float> EyeHorizAngleLeft { get; set; } = -5f;     //Float
        public Nullable<float> EyeRadius { get; set; } = 0.0152f;     //Float
        public Nullable<float> EyeParallaxPlane { get; set; } = 0.0134f;     //Float
        public Nullable<float> BubbleNormalTile { get; set; } = 0.631313f;     //Float
        public Nullable<float> EggFullRadius { get; set; } = 1f;     //Float
        public Nullable<float> EggMarginExponent { get; set; } = 1f;     //Float
        public Nullable<float> EggMarginFactor { get; set; } = 0.4f;     //Float
        public Nullable<float> EggSubFactor { get; set; } = 0.2f;     //Float
        public Nullable<float> IrisCoordFactor { get; set; } = 0.164983f;     //Float
        public Nullable<float> IrisCoordMargin { get; set; } = 0.020202f;     //Float
        public Nullable<float> BlickScale { get; set; } = 0.2f;     //Float
        public Nullable<float> Specularity { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"base\characters\common\eyes\textures\he_000_base_n01.xbm";    //rRef:ITexture
        public Nullable<float> SubsurfaceFactor { get; set; } = 0.2f;     //Float
        public Nullable<float> AntiLightbleedValue { get; set; } = 0.5f;     //Float
        public Nullable<float> AntiLightbleedUpOff { get; set; } = 0f;     //Float
    }
    public partial class _eye_gradient
    {
        public string Albedo { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"base\characters\common\eyes\textures\he_000_base_n01.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\characters\common\eyes\textures\he_000_base_rm01.xbm";    //rRef:ITexture
        public string Blick { get; set; } = @"base\characters\common\eyes\cube_blick_1.cubemap";     //rRef:ITexture
        public string NormalBubble { get; set; } = @"base\characters\common\eyes\textures\normal_bubble.xbm";    //rRef:ITexture
        public string IrisMask { get; set; } = @"base\characters\common\eyes\textures\eye_mask.xbm";    //rRef:ITexture
        public string IrisColorGradient { get; set; } = @"engine\materials\defaults\default.gradient";     //rRef:CGradient
        public Nullable<float> RefractionIndex { get; set; } = 0.97f;     //Float
        public Nullable<float> RefractionAmount { get; set; } = 1f;     //Float
        public Nullable<float> IrisSize { get; set; } = 0.737374f;     //Float
        public Nullable<float> EyeHorizAngleRight { get; set; } = 5f;     //Float
        public Nullable<float> EyeHorizAngleLeft { get; set; } = -5f;     //Float
        public Nullable<float> EyeRadius { get; set; } = 0.0152f;     //Float
        public Nullable<float> EyeParallaxPlane { get; set; } = 0.0134f;     //Float
        public Nullable<float> BubbleNormalTile { get; set; } = 0.631313f;     //Float
        public Nullable<float> EggFullRadius { get; set; } = 1f;     //Float
        public Nullable<float> EggMarginExponent { get; set; } = 1f;     //Float
        public Nullable<float> EggMarginFactor { get; set; } = 0.4f;     //Float
        public Nullable<float> EggSubFactor { get; set; } = 0.2f;     //Float
        public Nullable<float> IrisCoordFactor { get; set; } = 0.164983f;     //Float
        public Nullable<float> IrisCoordMargin { get; set; } = 0.020202f;     //Float
        public Nullable<float> BlickScale { get; set; } = 0.2f;     //Float
        public Nullable<float> Specularity { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessScale { get; set; } = 0.493421f;     //Float
        public Nullable<float> SubsurfaceFactor { get; set; } = 0.2f;     //Float
        public Nullable<float> AntiLightbleedValue { get; set; } = 0.5f;     //Float
        public Nullable<float> AntiLightbleedUpOff { get; set; } = 0f;     //Float
    }
    public partial class _eye_shadow
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color ShadowColor { get; set; } = new Color(255, 0, 0, 233);      //Color
        public Nullable<float> Exponent { get; set; } = 2.2f;     //Float
        public Nullable<float> Intensity { get; set; } = 1f;     //Float
        public string Mask { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> WetnessRoughness { get; set; } = 1f;     //Float
        public Nullable<float> WetnessStrength { get; set; } = 4f;     //Float
        public Nullable<float> SubsurfaceBlur { get; set; } = 1f;     //Float
    }
    public partial class _eye_shadow_blendable
    {
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_05\braindance_noise3d_05.texarray";    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; } = 0.5f;     //Float
        public Nullable<float> FadeOutOffset { get; set; } = 0.2f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 5f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 2f;     //Float
        public Color FresnelColor { get; set; } = new Color(0, 229, 255, 255);      //Color
        public Nullable<float> FresnelColorIntensity { get; set; } = 8f;     //Float
        public Nullable<float> FresnelExponent { get; set; } = 2f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color ShadowColor { get; set; } = new Color(125, 58, 58, 255);      //Color
        public Nullable<float> Exponent { get; set; } = 0.8f;     //Float
        public Nullable<float> Intensity { get; set; } = 0.7f;     //Float
        public string Mask { get; set; } = @"base\characters\common\eyes\textures\eye_shadow_mask.xbm";    //rRef:ITexture
        public Nullable<float> WetnessRoughness { get; set; } = 1f;     //Float
        public Nullable<float> WetnessStrength { get; set; } = 4f;     //Float
        public Nullable<float> SubsurfaceBlur { get; set; } = 1f;     //Float
    }
    public partial class _fake_occluder
    {
        public Nullable<float> DissolveDistance { get; set; } = 0f;     //Float
        public Nullable<float> DissolveBandWidth { get; set; } = 0f;     //Float
    }
    public partial class _fillable_fluid
    {
        public Vec4 FluidBoundingBoxMin { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 FluidBoundingBoxMax { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color TintColor { get; set; } = new Color(85, 55, 55, 255);      //Color
        public Nullable<float> RoughnessScale { get; set; } = 0.05f;     //Float
        public Nullable<float> MetalnessScale { get; set; } = 0.997567f;     //Float
        public Nullable<float> ObjectSize { get; set; } = 1f;     //Float
        public Nullable<float> ControlledByFx { get; set; } = 0f;     //Float
        public Nullable<float> FillAmount { get; set; } = 0.472019f;     //Float
        public string Waves { get; set; } = @"base\fx\textures\cache\q001_bathtub_wave_idle_displace.xbm";    //rRef:ITexture
        public Nullable<float> WaveAmplitude { get; set; } = 0.2f;     //Float
        public Nullable<float> WaveSpeed { get; set; } = 0.05f;     //Float
        public Nullable<float> WaveSize { get; set; } = 0.2f;     //Float
    }
    public partial class _fillable_fluid_vertex
    {
        public Vec4 FluidBoundingBoxMin { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 FluidBoundingBoxMax { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> ControlledByFx { get; set; } = 0f;     //Float
        public Nullable<float> ControlledByFxMode { get; set; } = 1f;     //Float
        public Nullable<float> PinchDeformation { get; set; } = 0f;     //Float
        public Nullable<float> FillAmount { get; set; } = 0.771318f;     //Float
        public string Waves { get; set; } = @"base\fx\textures\cache\q001_bathtub_wave_idle_displace.xbm";    //rRef:ITexture
        public Nullable<float> WaveAmplitude { get; set; } = 0.2f;     //Float
        public Nullable<float> WaveSpeed { get; set; } = 0.05f;     //Float
        public Nullable<float> WaveSize { get; set; } = 0.2f;     //Float
        public Nullable<float> Opacity { get; set; } = 1f;     //Float
        public string GlassTint { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> FrontFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> IOR { get; set; } = 1.33f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public Color GlassSpecularColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> BlurRadius { get; set; } = 0f;     //Float
    }
    public partial class _fluid_mov
    {
        public Nullable<float> Opacity { get; set; } = 1f;     //Float
        public Nullable<float> OpacityBackFace { get; set; } = 0f;     //Float
        public Nullable<float> UvTilingX { get; set; } = 1f;     //Float
        public Nullable<float> UvTilingY { get; set; } = 1f;     //Float
        public Nullable<float> UvOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UvOffsetY { get; set; } = 0f;     //Float
        public Vec4 RoughnessTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 NormalTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 GlassTintTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public string vertex_paint_tex { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> IsControlledByDestruction { get; set; } = 1f;     //Float
        public Nullable<float> trans_min { get; set; } = 0f;     //Float
        public Nullable<float> trans_max { get; set; } = 0f;     //Float
        public Nullable<float> rot_min { get; set; } = 0f;     //Float
        public Nullable<float> rot_max { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 0f;     //Float
        public Nullable<float> n_pieces { get; set; } = 0f;     //Float
        public Nullable<float> play_time { get; set; } = 0f;     //Float
        public Nullable<float> debug_familys { get; set; } = 0f;     //Float
        public Nullable<float> frame_rate { get; set; } = 24f;     //Float
        public Nullable<float> YAxisUp { get; set; } = 0f;     //Float
        public Nullable<float> z_min { get; set; } = 0f;     //Float
        public Nullable<float> ground_offset { get; set; } = 0f;     //Float
        public string GlassTint { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> TintFromVertexPaint { get; set; } = 0f;     //Float
        public Nullable<float> FrontFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> BackFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> IOR { get; set; } = 1f;     //Float
        public Nullable<float> RefractionDepth { get; set; } = 2.5f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public Color GlassSpecularColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> NormalMapAffectsSpecular { get; set; } = 1f;     //Float
        public string MaskTexture { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> MaskOpacity { get; set; } = 0f;     //Float
        public Nullable<float> GlassRoughnessBias { get; set; } = -1f;     //Float
        public Nullable<float> MaskRoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> BlurRadius { get; set; } = 0f;     //Float
        public Nullable<float> BlurByRoughness { get; set; } = 0f;     //Float
    }
    public partial class _frosted_glass
    {
        public Nullable<float> RenderBackFaces { get; set; } = 0f;     //Float
        public Nullable<float> Opacity { get; set; } = 0f;     //Float
        public Nullable<float> UvTilingX { get; set; } = 1f;     //Float
        public Nullable<float> UvTilingY { get; set; } = 1f;     //Float
        public Nullable<float> UvOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UvOffsetY { get; set; } = 0f;     //Float
        public Vec4 RoughnessTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 NormalTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 GlassTintTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> RoughnessBase { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessAttenuation { get; set; } = 1f;     //Float
        public Nullable<float> SurfaceOpacity { get; set; } = 0f;     //Float
        public Color ColorMultiplier { get; set; } = new Color(220, 220, 220, 255);      //Color
        public string GlassTint { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Color TintSurface { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color GlassSpecularColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> FrontFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> BackFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> IOR { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> RefractionDepth { get; set; } = 2.5f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; } = 0f;     //Float
        public Nullable<float> SpecularPower { get; set; } = 0.5f;     //Float
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> NormalMapAffectsSpecular { get; set; } = 1f;     //Float
        public Nullable<float> BlurRadius { get; set; } = 1.5f;     //Float
        public Nullable<float> BlurRoughness { get; set; } = 0f;     //Float
        public Nullable<float> MaskOpacity { get; set; } = 0f;     //Float
        public Nullable<float> MaskUseAlpha { get; set; } = 0f;     //Float
        public Nullable<float> MaskAddSurface { get; set; } = 0f;     //Float
        public Nullable<float> MaskAddOpacity { get; set; } = 0f;     //Float
        public Nullable<float> MaskAddRoughness { get; set; } = 0f;     //Float
    }
    public partial class _frosted_glass_curtain
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> MaskOpacity { get; set; } = 0.05f;     //Float
        public Nullable<float> RoughnessDirty { get; set; } = 0.5f;     //Float
        public Nullable<float> Opacity { get; set; } = 0.9f;     //Float
        public Color ColorMultiplier { get; set; } = new Color(200, 200, 200, 255);      //Color
        public Nullable<float> TintColorAttenuation { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessAttenuation { get; set; } = 0f;     //Float
        public Nullable<float> FrontFacesReflectionPower { get; set; } = 0.5f;     //Float
        public Nullable<float> BackFacesReflectionPower { get; set; } = 0.5f;     //Float
        public Nullable<float> IOR { get; set; } = 0f;     //Float
        public Nullable<float> blurRadius { get; set; } = 1f;     //Float
        public Nullable<float> diffuseStrength { get; set; } = 0f;     //Float
        public Nullable<float> SpecularPower { get; set; } = 1f;     //Float
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
    }
    public partial class _glass
    {
        public Nullable<float> Opacity { get; set; } = 0f;     //Float
        public Nullable<float> OpacityBackFace { get; set; } = 0f;     //Float
        public Nullable<float> UvTilingX { get; set; } = 1f;     //Float
        public Nullable<float> UvTilingY { get; set; } = 1f;     //Float
        public Nullable<float> UvOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UvOffsetY { get; set; } = 0f;     //Float
        public Vec4 RoughnessTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 NormalTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 GlassTintTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Color TintColor { get; set; } = new Color(229, 229, 229, 255);      //Color
        public string GlassTint { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> TintFromVertexPaint { get; set; } = 0f;     //Float
        public Nullable<float> FrontFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> BackFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> IOR { get; set; } = 1f;     //Float
        public Nullable<float> RefractionDepth { get; set; } = 2.5f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public Color GlassSpecularColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> NormalMapAffectsSpecular { get; set; } = 1f;     //Float
        public Nullable<float> SurfaceMetalness { get; set; } = 0f;     //Float
        public Nullable<float> MaskOpacity { get; set; } = 0f;     //Float
        public string MaskTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> GlassRoughnessBias { get; set; } = -1f;     //Float
        public Nullable<float> MaskRoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> BlurRadius { get; set; } = 0f;     //Float
        public Nullable<float> BlurByRoughness { get; set; } = 0f;     //Float
    }
    public partial class _glass_blendable
    {
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_05\braindance_noise3d_05.texarray";    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; } = 0.5f;     //Float
        public Nullable<float> FadeOutOffset { get; set; } = 0.2f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 5f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 2f;     //Float
        public Nullable<float> Opacity { get; set; } = 1f;     //Float
        public Nullable<float> OpacityBackFace { get; set; } = 1f;     //Float
        public Color FresnelColor { get; set; } = new Color(0, 229, 255, 255);      //Color
        public Nullable<float> FresnelColorIntensity { get; set; } = 8f;     //Float
        public Nullable<float> FresnelExponent { get; set; } = 2f;     //Float
        public string GlassTint { get; set; } = @"base\characters\main_npc\silverhand\textures\h1_001_ma_specs__silverhand_d01.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> TintFromVertexPaint { get; set; } = 0f;     //Float
        public Nullable<float> FrontFacesReflectionPower { get; set; } = 1.2f;     //Float
        public Nullable<float> BackFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> IOR { get; set; } = 1.05f;     //Float
        public Nullable<float> RefractionDepth { get; set; } = 0.05f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1.2f;     //Float
        public Color GlassSpecularColor { get; set; } = new Color(255, 252, 252, 255);      //Color
        public Nullable<float> NormalStrength { get; set; } = 1.2f;     //Float
        public Nullable<float> NormalMapAffectsSpecular { get; set; } = 1f;     //Float
        public string MaskTexture { get; set; } = @"base\characters\main_npc\silverhand\textures\h1_001_ma_specs__silverhand_d01.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; } = 0.2f;     //Float
        public string Normal { get; set; } = @"base\characters\main_npc\silverhand\textures\h1_001_ma_specs__silverhand_n01.xbm";    //rRef:ITexture
        public Nullable<float> MaskOpacity { get; set; } = 0f;     //Float
        public Nullable<float> GlassRoughnessBias { get; set; } = -1f;     //Float
        public Nullable<float> MaskRoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> BlurRadius { get; set; } = 0f;     //Float
        public Nullable<float> BlurByRoughness { get; set; } = 0f;     //Float
    }
    public partial class _glass_cracked_edge
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(0.349306f, 0.924935f, 0.76702f, 1f);    //Vector4
        public Nullable<float> AlphaScale { get; set; } = 1f;     //Float
        public Nullable<float> UseAlphaFromSkinning { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0.05f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> AlphaThreshold { get; set; } = 0.33f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
    }
    public partial class _glass_deferred
    {
        public Nullable<float> UvTilingX { get; set; } = 1f;     //Float
        public Nullable<float> UvTilingY { get; set; } = 1f;     //Float
        public Nullable<float> UvOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UvOffsetY { get; set; } = 0f;     //Float
        public Vec4 NormalTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public string GlassTint { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(220, 220, 220, 255);      //Color
        public Nullable<float> TintFromVertexPaint { get; set; } = 0f;     //Float
        public Nullable<float> TintColorAttenuation { get; set; } = 0f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public Nullable<float> NormalStrength { get; set; } = 0f;     //Float
        public string MaskTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; } = 0f;     //Float
        public Nullable<float> GlassMetalness { get; set; } = 0.8f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> MaskOpacity { get; set; } = 0f;     //Float
        public Nullable<float> MaskRoughnessBias { get; set; } = 0f;     //Float
        public string Reflection { get; set; } = @"base\surfaces\textures\hdri\reflections_cdp_parking_garage_1k.cubemap";     //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 0.5f;     //Float
    }
    public partial class _glass_scope
    {
        public Vec4 UvTilingOffset { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> LensRoughness { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceMetalness { get; set; } = 1f;     //Float
        public Nullable<float> LensMetalness { get; set; } = 0.5f;     //Float
        public string GlassTint { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Color GlassTintMultiplier { get; set; } = new Color(52, 255, 0, 255);      //Color
        public Nullable<float> EmissiveTint { get; set; } = 0f;     //Float
        public Color LensSpecularColor { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Nullable<float> LensReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> SpecularPower { get; set; } = 1f;     //Float
        public Nullable<float> MaskOpacity { get; set; } = 0f;     //Float
        public Vec4 UseMask { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> ScopeMaskFarDistance { get; set; } = 2f;     //Float
        public string ScopeMaskClose { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public string ScopeMaskFar { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public string LensBulge { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public Color ScopeInside { get; set; } = new Color(27, 51, 28, 255);      //Color
        public Nullable<float> DistortionStrenght { get; set; } = 1.5f;     //Float
        public Nullable<float> LensBulgeStrength { get; set; } = 1f;     //Float
        public Nullable<float> AberrationStrenght { get; set; } = 5f;     //Float
        public Nullable<float> SphereMaskCloseRadius { get; set; } = 0.5f;     //Float
        public Nullable<float> SphereMaskCloseHardness { get; set; } = 0.95f;     //Float
        public Nullable<float> LensBulgeRadius { get; set; } = 0.5f;     //Float
        public Nullable<float> LensBulgeHardness { get; set; } = 0f;     //Float
        public Nullable<float> SphereMaskFarRadius { get; set; } = 0.5f;     //Float
        public Nullable<float> SphereMaskFarHardness { get; set; } = 0.5f;     //Float
        public Nullable<float> SphereMaskDistortionRadius { get; set; } = 0.5f;     //Float
        public Nullable<float> SphereMaskDistortionHardness { get; set; } = 0.5f;     //Float
        public Vec4 EyeRelief { get; set; } = new Vec4(0.5f, 0.25f, 1f, 0f);    //Vector4
    }
    public partial class _glass_window_rain
    {
        public Nullable<float> UvTilingX { get; set; } = 1f;     //Float
        public Nullable<float> UvTilingY { get; set; } = 1f;     //Float
        public Nullable<float> UvOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UvOffsetY { get; set; } = 0f;     //Float
        public Vec4 RoughnessTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 GlassTintTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> Opacity { get; set; } = 1f;     //Float
        public Nullable<float> OpacityBackFace { get; set; } = 0f;     //Float
        public string GlassTint { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(162, 173, 180, 0);      //Color
        public Color TintSurface { get; set; } = new Color(129, 131, 106, 255);      //Color
        public Nullable<float> FrontFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> BackFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public Color GlassSpecularColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string MaskTexture { get; set; } = @"base\vehicles\common\textures\common_windows_dirt_d02.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> MaskOpacity { get; set; } = 0.1f;     //Float
        public Nullable<float> GlassRoughnessBias { get; set; } = -0.03f;     //Float
        public Nullable<float> MaskRoughnessBias { get; set; } = 1f;     //Float
        public Nullable<float> RainTiling { get; set; } = 1f;     //Float
        public Nullable<float> FlowTiling { get; set; } = 1.1f;     //Float
        public string DotsNormalTxt { get; set; } = @"base\vehicles\common\textures\vehicle_glass_rain_drops_n.xbm";    //rRef:ITexture
        public string DotsTxt { get; set; } = @"base\vehicles\common\textures\vehicle_glass_rain_drops.xbm";    //rRef:ITexture
        public string FlowTxt { get; set; } = @"base\vehicles\common\textures\vehicle_glass_rain_flow.xbm";    //rRef:ITexture
    }
    public partial class _hair
    {
        public string Strand_Gradient { get; set; } = @"base\materials\placeholder\grey.xbm";    //rRef:ITexture
        public Nullable<float> Animation_AmplitudeScale { get; set; } = 0f;     //Float
        public Nullable<float> Animation_PeriodScale { get; set; } = 0f;     //Float
        public string Strand_ID { get; set; } = @"base\materials\placeholder\grey.xbm";    //rRef:ITexture
        public string Strand_Alpha { get; set; } = @"base\materials\placeholder\grey.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> AlphaCutoff { get; set; } = 0.33f;     //Float
        public string Flow { get; set; } = @"engine\textures\editor\hairdefault_f.xbm";    //rRef:ITexture
        public Nullable<float> FlowStrength { get; set; } = 1f;     //Float
        public Nullable<float> VertexColorStrength { get; set; } = 0f;     //Float
        public Nullable<float> Scattering { get; set; } = 0.16f;     //Float
        public Nullable<float> ShadowStrength { get; set; } = 0f;     //Float
        public Nullable<float> ShadowMin { get; set; } = -0.5f;     //Float
        public Nullable<float> ShadowMax { get; set; } = 1f;     //Float
        public Nullable<float> ShadowRoughness { get; set; } = 1f;     //Float
        public Nullable<float> DebugHairColor { get; set; } = 0f;     //Float
        public string HairProfile { get; set; } = @"engine\materials\defaults\default.hp";     //rRef:CHairProfile
    }
    public partial class _hair_blendable
    {
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_05\braindance_noise3d_05.texarray";    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; } = 0.5f;     //Float
        public Nullable<float> FadeOutOffset { get; set; } = 0.2f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 5f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 2f;     //Float
        public string Strand_Gradient { get; set; } = @"base\characters\common\hair\textures\hh_long01_grad01_r.xbm";    //rRef:ITexture
        public Nullable<float> Animation_AmplitudeScale { get; set; } = 0f;     //Float
        public Nullable<float> Animation_PeriodScale { get; set; } = 0f;     //Float
        public Color FresnelColor { get; set; } = new Color(0, 229, 255, 255);      //Color
        public Nullable<float> FresnelColorIntensity { get; set; } = 8f;     //Float
        public Nullable<float> FresnelExponent { get; set; } = 2f;     //Float
        public string Strand_ID { get; set; } = @"base\characters\common\hair\textures\hh_long01_id01_r.xbm";    //rRef:ITexture
        public string Strand_Alpha { get; set; } = @"base\characters\common\hair\textures\hh_long01_alpha01_r.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0.25f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0.3f;     //Float
        public Nullable<float> AlphaCutoff { get; set; } = 0f;     //Float
        public string Flow { get; set; } = @"base\characters\common\hair\textures\hh_long01_flow01_d.xbm";    //rRef:ITexture
        public Nullable<float> FlowStrength { get; set; } = 1f;     //Float
        public Nullable<float> VertexColorStrength { get; set; } = 0f;     //Float
        public Nullable<float> Scattering { get; set; } = 0.16f;     //Float
        public Nullable<float> ShadowStrength { get; set; } = 1f;     //Float
        public Nullable<float> ShadowMin { get; set; } = -0.4f;     //Float
        public Nullable<float> ShadowMax { get; set; } = 1f;     //Float
        public Nullable<float> ShadowRoughness { get; set; } = 0.95f;     //Float
        public Nullable<float> DebugHairColor { get; set; } = 0f;     //Float
        public string HairProfile { get; set; } = @"base\characters\common\hair\textures\hair_profiles\custom_johnny.hp";     //rRef:CHairProfile
    }
    public partial class _hair_proxy
    {
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Albedo { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> Scattering { get; set; } = 0f;     //Float
    }
    public partial class _ice_fluid_mov
    {
        public Nullable<float> WaveIdleNormalStrength { get; set; } = 1f;     //Float
        public Vec4 WaveIdleTilingAndSpeed { get; set; } = new Vec4(1f, 1f, 0.05f, 0f);    //Vector4
        public Nullable<float> DebugTimeOverride { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 100f;     //Float
        public Nullable<float> frame_rate { get; set; } = 30f;     //Float
        public Nullable<float> SimulationAtlasFrameCountX { get; set; } = 8f;     //Float
        public Nullable<float> SimulationAtlasFrameCountY { get; set; } = 8f;     //Float
        public string SimulationAtlas { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string WaveIdleMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> WaveIdleHeight { get; set; } = 0.03f;     //Float
        public Nullable<float> HeightMin { get; set; } = 0f;     //Float
        public Nullable<float> HeightMax { get; set; } = 1f;     //Float
        public Nullable<float> WaterRoughness { get; set; } = 0.05f;     //Float
        public Nullable<float> WaterSpecF0 { get; set; } = 0f;     //Float
        public Nullable<float> WaterSpecF90 { get; set; } = 1f;     //Float
        public Color WaterColorShallow { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Color WaterColorDeep { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Color WaveColor0 { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Color WaveColor1 { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> WaveNoiseTiling { get; set; } = 3.5f;     //Float
        public Nullable<float> WaveNoiseContrast { get; set; } = 0.5f;     //Float
        public Nullable<float> WaveNoiseContrastOut { get; set; } = 1f;     //Float
        public Nullable<float> RefractionStrength { get; set; } = 150f;     //Float
        public Color IceColor1 { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Color IceColor2 { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> IceTiling { get; set; } = 1f;     //Float
        public Nullable<float> UVRatio { get; set; } = 1f;     //Float
        public Nullable<float> IceDepth { get; set; } = 0f;     //Float
        public Nullable<float> IceNormalStrength { get; set; } = 0f;     //Float
        public Color BloodColor { get; set; } = new Color(255, 5, 0, 0);      //Color
        public Nullable<float> BloodFadeStart { get; set; } = 0.99f;     //Float
        public Nullable<float> BloodFadeEnd { get; set; } = 1f;     //Float
        public string WaveNoiseMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string IceMasksMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string IceNormalMap { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
    }
    public partial class _ice_ver_mov_translucent
    {
        public string vertex_paint_tex { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> trans_min { get; set; } = 0f;     //Float
        public Nullable<float> trans_max { get; set; } = 0f;     //Float
        public Nullable<float> rot_min { get; set; } = 0f;     //Float
        public Nullable<float> rot_max { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 0f;     //Float
        public Nullable<float> n_pieces { get; set; } = 0f;     //Float
        public Nullable<float> play_time { get; set; } = 0f;     //Float
        public Nullable<float> debug_familys { get; set; } = 0f;     //Float
        public Nullable<float> frame_rate { get; set; } = 24f;     //Float
        public string WaveIdleMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> WaveIdleHeight { get; set; } = 0f;     //Float
        public Vec4 WaveIdleTilingAndSpeed { get; set; } = new Vec4(1f, 1f, 0.05f, 0.05f);    //Vector4
        public string BaseColor { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(187, 200, 206, 255);      //Color
        public string Roughness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0.35f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Color RefractionTint { get; set; } = new Color(203, 205, 216, 255);      //Color
        public Nullable<float> IOR { get; set; } = 1.52f;     //Float
    }
    public partial class _lights_interactive
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
        public Nullable<float> Zone0EmissiveEV { get; set; } = 5f;     //Float
        public Nullable<float> Zone1EmissiveEV { get; set; } = 5f;     //Float
        public Nullable<float> Zone2EmissiveEV { get; set; } = 5f;     //Float
        public Nullable<float> Zone3EmissiveEV { get; set; } = 5f;     //Float
        public Vec4 DebugLightsIntensity { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> AlphaThreshold { get; set; } = 0.33f;     //Float
    }
    public partial class _loot_drop_highlight
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> Mode { get; set; } = 0f;     //Float
        public Color HighlightColor { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Nullable<float> HighlightIntensity { get; set; } = 0.5f;     //Float
        public Nullable<float> SolidBlendingDistanceStart { get; set; } = 2f;     //Float
        public Nullable<float> SolidBlendingDistanceEnd { get; set; } = 50f;     //Float
    }
    public partial class _mesh_decal
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetY { get; set; } = 0f;     //Float
        public Nullable<float> UVRotation { get; set; } = 0f;     //Float
        public Nullable<float> UVScaleX { get; set; } = 1f;     //Float
        public Nullable<float> UVScaleY { get; set; } = 1f;     //Float
        public string SecondaryMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; } = 1f;     //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public string NormalAlphaTex { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> UseNormalAlphaTex { get; set; } = 0f;     //Float
        public Nullable<float> NormalsBlendingMode { get; set; } = 0f;     //Float
        public string NormalsBlendingModeAlpha { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0.5f;     //Float
    }
    public partial class _mesh_decal_blendable
    {
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_05\braindance_noise3d_05.texarray";    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; } = 0.5f;     //Float
        public Nullable<float> FadeOutOffset { get; set; } = 0f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 5f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 2f;     //Float
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public Color FresnelColor { get; set; } = new Color(0, 229, 255, 255);      //Color
        public Nullable<float> FresnelColorIntensity { get; set; } = 8f;     //Float
        public Nullable<float> FresnelExponent { get; set; } = 2f;     //Float
        public string DiffuseTexture { get; set; } = @"base\materials\placeholder\grey.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetY { get; set; } = 0f;     //Float
        public Nullable<float> UVRotation { get; set; } = 0f;     //Float
        public Nullable<float> UVScaleX { get; set; } = 1f;     //Float
        public Nullable<float> UVScaleY { get; set; } = 1f;     //Float
        public string SecondaryMask { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; } = 0f;     //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public string NormalAlphaTex { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> UseNormalAlphaTex { get; set; } = 0f;     //Float
        public Nullable<float> NormalsBlendingMode { get; set; } = 0f;     //Float
        public string NormalsBlendingModeAlpha { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"base\materials\placeholder\grey.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string MetalnessTexture { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0.5f;     //Float
    }
    public partial class _mesh_decal_double_diffuse
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public string SecondaryDiffuseAlpha { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color SecondaryDiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> SecondaryDiffuseAlphaIntensity { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetY { get; set; } = 0f;     //Float
        public Nullable<float> UVRotation { get; set; } = 0f;     //Float
        public Nullable<float> UVScaleX { get; set; } = 1f;     //Float
        public Nullable<float> UVScaleY { get; set; } = 1f;     //Float
        public string SecondaryMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; } = 0f;     //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; } = 0f;     //Float
        public string NormalsBlendingModeAlpha { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string NormalTexture { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public string NormalAlphaTex { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> UseNormalAlphaTex { get; set; } = 0f;     //Float
        public Nullable<float> NormalsBlendingMode { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0f;     //Float
    }
    public partial class _mesh_decal_emissive
    {
        public Nullable<float> DamageInfluence { get; set; } = 1f;     //Float
        public Nullable<float> DamageInfluenceDebug { get; set; } = 0f;     //Float
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color DiffuseColor2 { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetY { get; set; } = 0f;     //Float
        public Nullable<float> UVRotation { get; set; } = 0f;     //Float
        public Nullable<float> UVScaleX { get; set; } = 1f;     //Float
        public Nullable<float> UVScaleY { get; set; } = 1f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Vec4 ScrollSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> HardOrSoftTransition { get; set; } = 0f;     //Float
        public Nullable<float> FullVisibilityFactor { get; set; } = 1f;     //Float
        public Nullable<float> EnableAlternateColor { get; set; } = 0f;     //Float
        public Nullable<float> EnableAlternateUVcoord { get; set; } = 0f;     //Float
        public Nullable<float> Preview2ndState { get; set; } = 0f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
    }
    public partial class _mesh_decal_emissive_subsurface
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string EmissiveMask { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string SecondaryMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Vec4 EmissiveMaskChannel { get; set; } = new Vec4(1f, 0f, 0f, 0f);    //Vector4
        public Color EmissiveColor { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 2.076205f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _mesh_decal_gradientmap_recolor
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public string MaskTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public string GradientMap { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string SecondaryMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; } = 0f;     //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public Nullable<float> NormalsBlendingMode { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0.5f;     //Float
    }
    public partial class _mesh_decal_gradientmap_recolor_2
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public string MaskTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public string Gradient { get; set; } = @"engine\materials\defaults\default.gradient";     //rRef:CGradient
        public string NormalTexture { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public Nullable<float> NormalsBlendingMode { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0.5f;     //Float
    }
    public partial class _mesh_decal_gradientmap_recolor_emissive
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public string MaskTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(226, 226, 226, 255);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 1f;     //Float
        public string GradientMap { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string EmissiveGradientMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string NormalTexture { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public Nullable<float> NormalsBlendingMode { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 1f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0.5f;     //Float
    }
    public partial class _mesh_decal_multitinted
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0.997531f;     //Float
        public string TintMaskTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color TintColor0 { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color TintColor1 { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color TintColor2 { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color TintColor3 { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color TintColor4 { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color TintColor5 { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color TintColor6 { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color TintColor7 { get; set; } = new Color(255, 255, 255, 255);      //Color
    }
    public partial class _mesh_decal_parallax
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetY { get; set; } = 0f;     //Float
        public Nullable<float> UVRotation { get; set; } = 0f;     //Float
        public Nullable<float> UVScaleX { get; set; } = 1f;     //Float
        public Nullable<float> UVScaleY { get; set; } = 1f;     //Float
        public string SecondaryMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; } = 0f;     //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public string NormalAlphaTex { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> UseNormalAlphaTex { get; set; } = 0f;     //Float
        public Nullable<float> NormalsBlendingMode { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0.5f;     //Float
        public string HeightTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> HeightStrength { get; set; } = 0f;     //Float
    }
    public partial class _mesh_decal_revealed
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public Nullable<float> NormalsBlendingMode { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Nullable<float> TileNumber { get; set; } = 0f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0.5f;     //Float
        public string FlowTexture { get; set; } = @"base\fx\textures\gradients\fx_gradient_falloff.xbm";    //rRef:ITexture
    }
    public partial class _mesh_decal_wet_character
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UVOffsetY { get; set; } = 0f;     //Float
        public Nullable<float> UVRotation { get; set; } = 0f;     //Float
        public Nullable<float> UVScaleX { get; set; } = 1f;     //Float
        public Nullable<float> UVScaleY { get; set; } = 1f;     //Float
        public string SecondaryMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> SecondaryMaskUVScale { get; set; } = 1f;     //Float
        public Nullable<float> SecondaryMaskInfluence { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public string NormalAlphaTex { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> UseNormalAlphaTex { get; set; } = 0f;     //Float
        public Nullable<float> NormalsBlendingMode { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 0f;     //Float
        public Nullable<float> AnimationSpeed { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 1f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 1f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0.5f;     //Float
    }
    public partial class _metal_base_bink
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public string VideoCanvasName { get; set; } = @"";     //CName
        public string BinkY { get; set; } = @"";    //rRef:ITexture
        public string BinkCR { get; set; } = @"";    //rRef:ITexture
        public string BinkCB { get; set; } = @"";    //rRef:ITexture
        public string BinkA { get; set; } = @"";    //rRef:ITexture
        public DataBuffer BinkParams { get; set; }
    }
    public partial class _metal_base_det
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\checker_h.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"test\level_design\ld_kit\textures\ruler_checker_5m_road.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0.98f;     //Float
        public string Roughness { get; set; } = @"test\level_design\ld_kit\textures\ruler_checker_1m_wall.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\checker_n.xbm";    //rRef:ITexture
        public Nullable<float> AlphaThreshold { get; set; } = 0.3f;     //Float
        public string DetailColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string DetailNormal { get; set; } = @"engine\textures\editor\checker_n.xbm";    //rRef:ITexture
        public Nullable<float> DetailU { get; set; } = 10f;     //Float
        public Nullable<float> DetailV { get; set; } = 5f;     //Float
    }
    public partial class _metal_base_det_dithered
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\checker_h.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"test\level_design\ld_kit\textures\ruler_checker_5m_road.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0.98f;     //Float
        public string Roughness { get; set; } = @"test\level_design\ld_kit\textures\ruler_checker_1m_wall.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\checker_n.xbm";    //rRef:ITexture
        public Nullable<float> AlphaThreshold { get; set; } = 0.3f;     //Float
        public string DetailColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string DetailNormal { get; set; } = @"engine\textures\editor\checker_n.xbm";    //rRef:ITexture
        public Nullable<float> DetailU { get; set; } = 10f;     //Float
        public Nullable<float> DetailV { get; set; } = 5f;     //Float
    }
    public partial class _metal_base_dithered
    {
        public Nullable<float> VehicleDamageInfluence { get; set; } = 1f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public string Emissive { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveLift { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.05f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
    }
    public partial class _metal_base_gradientmap_recolor
    {
        public Nullable<float> VehicleDamageInfluence { get; set; } = 1f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Mask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string GradientMap { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public string EmissiveGradientMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public string Emissive { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.38f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
    }
    public partial class _metal_base_parallax
    {
        public string BaseColor { get; set; } = @"base\vehicles\common\textures\vehicles_decals_exterior_height.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"base\vehicles\common\textures\vehicles_decals_exterior_n01.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public string Emissive { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveLift { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public string HeightTexture { get; set; } = @"base\vehicles\common\textures\vehicles_decals_exterior_height.xbm";    //rRef:ITexture
        public Nullable<float> HeightStrength { get; set; } = 1f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
    }
    public partial class _metal_base_trafficlight_proxy
    {
        public Nullable<float> TrafficCellSize { get; set; } = 20f;     //Float
        public Nullable<float> TrafficSpeed { get; set; } = 0.5f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 5f;     //Float
        public string Emissive { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 4f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveLift { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.381818f;     //Float
        public Nullable<float> LayerTile { get; set; } = 0f;     //Float
    }
    public partial class _metal_base_ui
    {
        public string ScanlineTexture { get; set; } = @"base\fx\_textures\masks\gradients\fx_reflected_vertical_gradient_02_d.xbm";    //rRef:ITexture
        public Nullable<float> Metalness { get; set; } = 0.9f;     //Float
        public Nullable<float> RoughnessScale { get; set; } = 0.1f;     //Float
        public Nullable<float> FixToPbr { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 6.02741f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> LayersSeparation { get; set; } = 0.1f;     //Float
        public Vec4 IntensityPerLayer { get; set; } = new Vec4(1f, 0.1f, 0.075f, 0.05f);    //Vector4
        public Vec4 ScanlinesDensity { get; set; } = new Vec4(125f, 125f, 0f, 2f);    //Vector4
        public Nullable<float> ScanlinesIntensity { get; set; } = 0.25f;     //Float
        public Nullable<float> IsBroken { get; set; } = 0f;     //Float
        public Nullable<float> ImageScale { get; set; } = 1f;     //Float
        public string UIRenderTexture { get; set; } = @"engine\ink\textures\4x4_transparent.xbm";    //rRef:ITexture
        public Vec4 RenderTextureScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public Nullable<float> VerticalFlipEnabled { get; set; } = 0f;     //Float
        public Vec4 TexturePartUV { get; set; } = new Vec4(0f, 0f, 1f, 1f);    //Vector4
        public string DirtTexture { get; set; } = @"base\environment\decoration\alpha_empty.xbm";    //rRef:ITexture
        public Color DirtColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DirtRoughness { get; set; } = 0.564516f;     //Float
        public Nullable<float> DirtEmissiveAttenuation { get; set; } = 0.5f;     //Float
        public Nullable<float> DirtContrast { get; set; } = 1f;     //Float
        public Color Tint { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> FixForBlack { get; set; } = 1f;     //Float
        public Nullable<float> FixForVerticalSlide { get; set; } = 1f;     //Float
        public Color ForcedTint { get; set; } = new Color(255, 255, 255, 0);      //Color
    }
    public partial class _metal_base_vertexcolored
    {
    }
    public partial class _mikoshi_blocks_big
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 1f;     //Float
        public Color EmissiveColor { get; set; } = new Color(53, 205, 255, 255);      //Color
        public string DataTex { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\cyberplatform_datatex.xbm";    //rRef:ITexture
        public string NoiseTex { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\blue_noise_256x256.xbm";    //rRef:ITexture
        public string PcbTex { get; set; } = @"base\fx\textures\cyberspace\mikoshi\circuit_board.xbm";    //rRef:ITexture
    }
    public partial class _mikoshi_blocks_medium
    {
        public Nullable<float> RandomSeed { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0.4f;     //Float
        public Color EmissiveColor { get; set; } = new Color(53, 205, 255, 255);      //Color
        public string DataTex { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\cyberplatform_datatex.xbm";    //rRef:ITexture
        public string NoiseTex { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\blue_noise_256x256.xbm";    //rRef:ITexture
    }
    public partial class _mikoshi_blocks_small
    {
        public Nullable<float> RandomSeed { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 1f;     //Float
        public Color EmissiveColor { get; set; } = new Color(53, 205, 255, 255);      //Color
        public string DataTex { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\cyberplatform_datatex.xbm";    //rRef:ITexture
        public string NoiseTex { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\blue_noise_256x256.xbm";    //rRef:ITexture
    }
    public partial class _mikoshi_parallax
    {
        public string RoomAtlas { get; set; } = @"base\environment\decoration\unique\quest\q105\textures\1x1_dollhouse_paralax.xbm";    //rRef:ITexture
        public string LayerAtlas { get; set; } = @"base\environment\decoration\unique\quest\q105\textures\1x1_dollhouse_paralax_curtains.xbm";    //rRef:ITexture
        public Vec4 AtlasGridUvRatio { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public Nullable<float> AtlasDepth { get; set; } = 0f;     //Float
        public Nullable<float> roomWidth { get; set; } = 1f;     //Float
        public Nullable<float> roomHeight { get; set; } = 1f;     //Float
        public Nullable<float> roomDepth { get; set; } = 1f;     //Float
        public Nullable<float> positionXoffset { get; set; } = 0.5f;     //Float
        public Nullable<float> positionYoffset { get; set; } = 0.5f;     //Float
        public Nullable<float> LayerDepth { get; set; } = 0.3f;     //Float
        public Nullable<float> Frostiness { get; set; } = 0f;     //Float
        public string WindowTexture { get; set; } = @"base\surfaces\masks\simple_glass_transparency_m.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\surfaces\masks\glass_generic_01_200_r.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
    }
    public partial class _mikoshi_prison_cell
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> EdgeFalloff { get; set; } = 0.723684f;     //Float
        public Nullable<float> DepthAttenuation { get; set; } = 0.7f;     //Float
        public Nullable<float> DepthAttenuationPower { get; set; } = 3.5f;     //Float
        public Nullable<float> LightIntensity { get; set; } = 6f;     //Float
        public Color LightColor { get; set; } = new Color(53, 205, 255, 255);      //Color
        public string SilhouetteTex { get; set; } = @"base\fx\textures\cyberspace\mikoshi\prisoner.xbm";    //rRef:ITexture
    }
    public partial class _multilayered_clear_coat
    {
        public Nullable<float> Opacity { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color CoatTintFwd { get; set; } = new Color(191, 191, 191, 255);      //Color
        public Color CoatTintSide { get; set; } = new Color(127, 127, 127, 255);      //Color
        public Nullable<float> CoatTintFresnelBias { get; set; } = 2f;     //Float
        public Color CoatSpecularColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> CoatNormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> CoatRoughnessBase { get; set; } = 0.05f;     //Float
        public Nullable<float> CoatReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> CoatFresnelBias { get; set; } = 0.66f;     //Float
        public Nullable<float> CoatLayerMin { get; set; } = -1f;     //Float
        public Nullable<float> CoatLayerMax { get; set; } = 21f;     //Float
        public string GlobalNormal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string MultilayerMask { get; set; } = @"engine\materials\defaults\multilayer_default.mlmask";     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; } = @"engine\materials\defaults\multilayer_default.mlsetup";     //rRef:Multilayer_Setup
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
    }
    public partial class _multilayered_terrain
    {
        public Nullable<float> UseOldVertexFormat { get; set; } = 0f;     //Float
        public Vec4 UVGenScaleOffset { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> DebugPreviewMasks { get; set; } = 0f;     //Float
        public Nullable<float> UseGlobalNormal { get; set; } = 0f;     //Float
        public string MultilayerMask { get; set; } = @"engine\textures\terrain\multilayer_terrain.mlmask";     //rRef:Multilayer_Mask
        public string GlobalNormal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string MultilayerSetup { get; set; } = @"engine\textures\terrain\multilayer_terrain.mlsetup";     //rRef:Multilayer_Setup
        public string BaseColor { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string TilingMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
        public string TerrainSetup { get; set; } = @"base\worlds\03_night_city\multilayer_terrain.terrainsetup";     //rRef:CTerrainSetup
        public DataBuffer TilingDataBuffer { get; set; }
        public string MaskFoliage { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
    }
    public partial class _neon_parallax
    {
        public Nullable<float> UvTilingX { get; set; } = 1f;     //Float
        public Nullable<float> UvTilingY { get; set; } = 1f;     //Float
        public Nullable<float> UvOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UvOffsetY { get; set; } = 0f;     //Float
        public string BaseColor { get; set; } = @"base\environment\decoration\advertising\signage\city_generic\textures\signage_city_apparel_u_and_g.xbm";    //rRef:ITexture
        public Nullable<float> UseGradientMapMode { get; set; } = 0f;     //Float
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string GradientMap { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color BaseColorScaleEdgeStart { get; set; } = new Color(160, 160, 160, 0);      //Color
        public Color BaseColorScaleEdgeEnd { get; set; } = new Color(50, 50, 50, 0);      //Color
        public string Metalness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Emissive { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> ParallaxDepth { get; set; } = 0.05f;     //Float
        public Nullable<float> ParallaxFlip { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.5f;     //Float
    }
    public partial class _presimulated_particles
    {
        public string vertex_paint_tex { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> trans_min { get; set; } = 0f;     //Float
        public Nullable<float> trans_max { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 1f;     //Float
        public Nullable<float> n_pieces { get; set; } = 1f;     //Float
        public Nullable<float> play_time { get; set; } = 0f;     //Float
        public Nullable<float> frame_rate { get; set; } = 0f;     //Float
        public Nullable<float> ParticleScale { get; set; } = 1f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _proxy_ad
    {
        public string BaseColor { get; set; } = @"base\surfaces\ad_placeholder.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 0);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _proxy_crowd
    {
        public string Atlas { get; set; } = @"base\surfaces\textures\atlas.xbm";    //rRef:ITexture
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Metalness { get; set; } = @"engine\textures\editor\roughmetal.xbm";    //rRef:ITexture
        public Color Color1 { get; set; } = new Color(229, 209, 178, 0);      //Color
        public Color Color2 { get; set; } = new Color(255, 229, 62, 0);      //Color
        public Color Color3 { get; set; } = new Color(138, 167, 255, 0);      //Color
        public Color Color4 { get; set; } = new Color(92, 75, 52, 0);      //Color
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\roughmetal.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.5f;     //Float
        public Vec4 AtlasSize { get; set; } = new Vec4(24f, 12f, 0f, 0f);    //Vector4
    }
    public partial class _q116_mikoshi_cubes
    {
        public Nullable<float> PointCloudTextureHeight { get; set; } = 0f;     //Float
        public Vec4 TransMin { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 TransMax { get; set; } = new Vec4(1f, 0f, 1f, 1f);    //Vector4
        public string WorldPosTex { get; set; } = @"base\fx\textures\techart\cyberparticles\cache1k_position_sphere.xbm";    //rRef:ITexture
        public Nullable<float> CubeSize { get; set; } = 100f;     //Float
        public Nullable<float> Tiling { get; set; } = 0.1f;     //Float
        public Nullable<float> DiffuseVariationUvScale { get; set; } = 0.04f;     //Float
        public Nullable<float> ParallaxHeightScale { get; set; } = 0.08f;     //Float
        public Nullable<float> ParallaxFlip { get; set; } = 1f;     //Float
        public string Emissive { get; set; } = @"base\environment\quests\q116_mikoshi_cyberspace\textures\mikoshi_cs_prison_pattern_00.xbm";    //rRef:ITexture
        public string ExtraMasks { get; set; } = @"base\environment\quests\q116_mikoshi_cyberspace\textures\mikoshi_cs_prison_extra_masks_00.xbm";    //rRef:ITexture
        public string EdgeMask { get; set; } = @"base\environment\quests\q116_mikoshi_cyberspace\textures\mikoshi_cs_prison_pattern_00.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 1f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _q116_mikoshi_floor
    {
        public string BaseColor { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\mikoshi_platfroms_mask.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(5, 5, 5, 255);      //Color
        public Color EmissiveColor { get; set; } = new Color(26, 210, 215, 255);      //Color
        public string Emissive { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\mikoshi_platfroms_mask.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 0.06f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> FalloffDistanceStart { get; set; } = 0.5f;     //Float
        public Nullable<float> FalloffDistanceEnd { get; set; } = 16f;     //Float
        public Nullable<float> GlowBrightnessStart { get; set; } = 1f;     //Float
        public Nullable<float> GlowBrightnessEnd { get; set; } = 0.6f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public string VectorField1 { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_03\braindance_noise3d_03.texarray";    //rRef:ITexture
        public string VectorField2 { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_00\braindance_noise3d_00.texarray";    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; } = 32f;     //Float
        public string Grain { get; set; } = @"base\environment\quests\q116_mikoshi_cyberspace\textures\mikoshi_cs_prison_grain_00.xbm";    //rRef:ITexture
    }
    public partial class _q202_lake_surface
    {
        public string Starmap { get; set; } = @"base\textures\stars\starmap.cubemap";     //rRef:ITexture
        public string Galaxy { get; set; } = @"base\textures\stars\galaxy.xbm";    //rRef:ITexture
        public Nullable<float> GalaxyIntensity { get; set; } = 0.333f;     //Float
        public Nullable<float> StarmapIntensity { get; set; } = 0.35f;     //Float
        public Nullable<float> DimScale { get; set; } = 0.5f;     //Float
        public Nullable<float> BrightScale { get; set; } = 0.25f;     //Float
        public Nullable<float> ConstelationScale { get; set; } = 0.125f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(43, 43, 43, 255);      //Color
        public Nullable<float> AlphaThreshold { get; set; } = 0.33f;     //Float
    }
    public partial class _rain
    {
        public Nullable<float> RainType { get; set; } = 0f;     //Float
        public string WindNoise { get; set; } = @"engine\textures\game_wind_noise.xbm";    //rRef:ITexture
        public Nullable<float> Speed { get; set; } = 3f;     //Float
        public Nullable<float> Scale { get; set; } = 2.140468f;     //Float
        public Nullable<float> WindSkew { get; set; } = 0.5f;     //Float
        public Nullable<float> WindStrength { get; set; } = 0.3f;     //Float
        public Nullable<float> WindDirectionMovement { get; set; } = 0f;     //Float
        public Nullable<float> WindFrequency { get; set; } = 0f;     //Float
        public Nullable<float> Height { get; set; } = 10f;     //Float
        public Nullable<float> Distance { get; set; } = 12f;     //Float
        public Nullable<float> Radius { get; set; } = 10f;     //Float
        public Nullable<float> BrightnessCards { get; set; } = 3f;     //Float
        public Nullable<float> BrightnessDrops { get; set; } = 10f;     //Float
        public Nullable<float> MovementStrength { get; set; } = 0.1f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> UvSpeed { get; set; } = 1f;     //Float
        public string Mask { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
    }
    public partial class _road_debug_grid
    {
        public string BaseColor { get; set; } = @"test\level_design\ld_kit\textures\road_debug_grid.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> TransitionSize { get; set; } = 1.298429f;     //Float
        public Nullable<float> GridScale { get; set; } = 5f;     //Float
        public Nullable<float> EnableWorldSpace { get; set; } = 1f;     //Float
    }
    public partial class _set_stencil_3
    {
        public Nullable<float> ExtraThickness { get; set; } = 0.02f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
    }
    public partial class _silverhand_overlay
    {
        public Nullable<float> DepthOffset { get; set; } = 0f;     //Float
        public string VectorField { get; set; } = @"";    //rRef:ITexture
        public Nullable<float> GlitchChance { get; set; } = 0f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 0f;     //Float
        public Nullable<float> GlitchTimeSeed { get; set; } = 0f;     //Float
        public string FresnelMask { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> FresnelMaskIntensity { get; set; } = 1f;     //Float
        public string GlobalNormal { get; set; } = @"base\characters\main_npc\silverhand\textures\a0_001_ma_arms__silverhand_n01.xbm";    //rRef:ITexture
        public string MultilayerMask { get; set; } = @"base\characters\main_npc\silverhand\textures\ml_a0_001_ma_arms__silverhand_masksset.mlmask";     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; } = @"base\characters\main_npc\silverhand\textures\ml_a0_001_ma_arms__silverhand.mlsetup";     //rRef:Multilayer_Setup
        public Nullable<float> Emissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public Nullable<float> BayerScale { get; set; } = 1f;     //Float
        public Nullable<float> BayerIntensity { get; set; } = 0.5f;     //Float
        public Vec4 VertexColorSelection { get; set; } = new Vec4(1f, 0f, -0.1f, 0f);    //Vector4
        public Nullable<float> VectorFieldTiling { get; set; } = 2f;     //Float
        public Nullable<float> VectorFieldIntensity { get; set; } = 0.5f;     //Float
        public Vec4 VectorFieldAnim { get; set; } = new Vec4(0f, 0f, 0.1f, 0f);    //Vector4
        public Color FresnelColor { get; set; } = new Color(0, 176, 255, 255);      //Color
        public Nullable<float> FresnelColorIntensity { get; set; } = 1f;     //Float
        public Nullable<float> FresnelExponent { get; set; } = 3f;     //Float
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
    }
    public partial class _silverhand_overlay_blendable
    {
        public Nullable<float> FadeOutDistance { get; set; } = 0.5f;     //Float
        public Nullable<float> FadeOutOffset { get; set; } = 0.2f;     //Float
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_05\braindance_noise3d_05.texarray";    //rRef:ITexture
        public Nullable<float> GlitchChance { get; set; } = 5f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 2f;     //Float
        public Nullable<float> GlitchTimeSeed { get; set; } = 0f;     //Float
        public string FresnelMask { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> FresnelMaskIntensity { get; set; } = 0f;     //Float
        public Color FresnelColor { get; set; } = new Color(0, 228, 255, 255);      //Color
        public Nullable<float> FresnelColorIntensity { get; set; } = 8f;     //Float
        public Nullable<float> FresnelExponent { get; set; } = 2f;     //Float
        public Nullable<float> Emissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public Nullable<float> BayerScale { get; set; } = 1f;     //Float
        public Nullable<float> BayerIntensity { get; set; } = 0.25f;     //Float
        public Vec4 VertexColorSelection { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> VectorFieldTiling { get; set; } = 2f;     //Float
        public Nullable<float> VectorFieldIntensity { get; set; } = 0.5f;     //Float
        public Vec4 VectorFieldAnim { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public string GlobalNormal { get; set; } = @"base\characters\main_npc\silverhand\textures\t2_001_ma_vest__silverhand_n01.xbm";    //rRef:ITexture
        public string MultilayerMask { get; set; } = @"base\characters\main_npc\silverhand\textures\ml_t2_001_ma_vest__silverhand_masksset.mlmask";     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; } = @"base\characters\main_npc\silverhand\textures\ml_t2_001_ma_vest__silverhand.mlsetup";     //rRef:Multilayer_Setup
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
    }
    public partial class _skin
    {
        public string Albedo { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string SecondaryAlbedo { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> SecondaryAlbedoInfluence { get; set; } = 0f;     //Float
        public Nullable<float> SecondaryAlbedoTintColorInfluence { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string DetailNormal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> DetailRoughnessBiasMin { get; set; } = 1f;     //Float
        public Nullable<float> DetailRoughnessBiasMax { get; set; } = 0.68f;     //Float
        public Nullable<float> MicroDetailUVScale01 { get; set; } = 10f;     //Float
        public Nullable<float> MicroDetailUVScale02 { get; set; } = 10f;     //Float
        public string MicroDetail { get; set; } = @"base\characters\common\skin\face\microdetail_n.xbm";    //rRef:ITexture
        public Nullable<float> MicroDetailInfluence { get; set; } = 1f;     //Float
        public string TintColorMask { get; set; } = @"base\characters\common\skin\torso\i0_000_base__tintcolormask.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> TintScale { get; set; } = 0f;     //Float
        public string SkinProfile { get; set; } = @"engine\materials\defaults\default.sp";      //rRef:CSkinProfile
        public string Detailmap_Stretch { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string EmissiveMask { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public string Detailmap_Squash { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> CavityIntensity { get; set; } = 0.25f;     //Float
        public string Bloodflow { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color BloodColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> DetailNormalInfluence { get; set; } = 0f;     //Float
    }
    public partial class _skin_blendable
    {
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_05\braindance_noise3d_05.texarray";    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; } = 0.5f;     //Float
        public Nullable<float> FadeOutOffset { get; set; } = 0.2f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 5f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 2f;     //Float
        public Color FresnelColor { get; set; } = new Color(0, 229, 255, 255);      //Color
        public Nullable<float> FresnelColorIntensity { get; set; } = 8f;     //Float
        public Nullable<float> FresnelExponent { get; set; } = 2f;     //Float
        public string Albedo { get; set; } = @"base\characters\common\base_bodies\man_average\textures\t0_000_ma__c_base_d03.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\characters\common\base_bodies\man_average\textures\t0_000_ma__c_base_rm03.xbm";    //rRef:ITexture
        public string DetailNormal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public Nullable<float> DetailNormalInfluence { get; set; } = 0.8f;     //Float
        public Nullable<float> CavityIntensity { get; set; } = 0.25f;     //Float
        public string Normal { get; set; } = @"base\characters\common\base_bodies\man_average\textures\t0_000_ma__c_base_n03.xbm";    //rRef:ITexture
        public Nullable<float> DetailRoughnessBiasMin { get; set; } = 1f;     //Float
        public Nullable<float> DetailRoughnessBiasMax { get; set; } = 0.93f;     //Float
        public string MicroDetail { get; set; } = @"base\characters\common\skin\face\microdetail_n.xbm";    //rRef:ITexture
        public Nullable<float> MicroDetailUVScale01 { get; set; } = 45f;     //Float
        public Nullable<float> MicroDetailUVScale02 { get; set; } = 20f;     //Float
        public Nullable<float> MicroDetailInfluence { get; set; } = 0.8f;     //Float
        public string TintColorMask { get; set; } = @"base\characters\common\skin\torso\t0_000_base_c__tintcolormask.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(171, 155, 150, 255);      //Color
        public Nullable<float> TintScale { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public string Detailmap_Stretch { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string Detailmap_Squash { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string Bloodflow { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Color BloodColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public string SkinProfile { get; set; } = @"engine\materials\defaults\default.sp";      //rRef:CSkinProfile
    }
    public partial class _skybox
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string DiffuseDayTime { get; set; } = @"base\fx\textures\sky\gen_clouds_l01.xbm";    //rRef:ITexture
        public string DiffuseNightTime { get; set; } = @"base\fx\textures\sky\gen_clouds_l01_night.xbm";    //rRef:ITexture
    }
    public partial class _speedtree_3d_v8_billboard
    {
        public string WindNoise { get; set; } = @"engine\textures\game_wind_noise.xbm";    //rRef:ITexture
        public Nullable<float> WindLodFlags { get; set; } = 0f;     //Float
        public Nullable<float> WindDataAvailable { get; set; } = 0f;     //Float
        public Nullable<float> HorizontalBillboardsCount { get; set; } = 0f;     //Float
        public Nullable<float> ContainsTopBillboard { get; set; } = 0f;     //Float
        public Nullable<float> TreeCrownRadius { get; set; } = 0f;     //Float
        public string DiffuseMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string NormalMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string TransGlossMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string FoliageProfileMap { get; set; } = @"";    //rRef:ITexture
        public string FoliageProfile { get; set; } = @"engine\materials\defaults\default.fp";     //rRef:CFoliageProfile
        public Nullable<float> MeshTotalHeight { get; set; } = 0f;     //Float
        public Nullable<float> ForceTerrainBlend { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
    }
    public partial class _speedtree_3d_v8_onesided
    {
        public string WindNoise { get; set; } = @"engine\textures\game_wind_noise.xbm";    //rRef:ITexture
        public string BonesPositionsMap { get; set; } = @"";    //rRef:ITexture
        public string BonesAdditionalDataMap { get; set; } = @"";    //rRef:ITexture
        public Vec4 BoneMapData { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> WindLodFlags { get; set; } = 0f;     //Float
        public Nullable<float> WindDataAvailable { get; set; } = 0f;     //Float
        public string DiffuseMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string NormalMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string TransGlossMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string FoliageProfileMap { get; set; } = @"";    //rRef:ITexture
        public string FoliageProfile { get; set; } = @"engine\materials\defaults\default.fp";     //rRef:CFoliageProfile
        public Nullable<float> MeshTotalHeight { get; set; } = 0f;     //Float
        public Nullable<float> ForceTerrainBlend { get; set; } = 0f;     //Float
    }
    public partial class _speedtree_3d_v8_onesided_gradient_recolor
    {
        public string BaseColor { get; set; } = @"base\surfaces\atlases\wood\wood_bare\textures\wood_bare_01_300_d.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Mask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string GradientMap { get; set; } = @"base\surfaces\atlases\wood\wood_bare\textures\wood_bare_01_300_oak_g.xbm";    //rRef:ITexture
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"base\surfaces\atlases\wood\wood_bare\textures\wood_bare_01_300_d.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"base\surfaces\atlases\wood\wood_bare\textures\wood_bare_01_300_n.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.38f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
    }
    public partial class _speedtree_3d_v8_seams
    {
        public string WindNoise { get; set; } = @"engine\textures\game_wind_noise.xbm";    //rRef:ITexture
        public string BoneMap { get; set; } = @"";    //rRef:ITexture
        public string BonesPositionsMap { get; set; } = @"";    //rRef:ITexture
        public string BonesAdditionalDataMap { get; set; } = @"";    //rRef:ITexture
        public Vec4 BoneMapData { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> WindLodFlags { get; set; } = 0f;     //Float
        public Nullable<float> WindDataAvailable { get; set; } = 0f;     //Float
        public string DiffuseMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string NormalMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string TransGlossMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string FoliageProfileMap { get; set; } = @"";    //rRef:ITexture
        public string FoliageProfile { get; set; } = @"engine\materials\defaults\default.fp";     //rRef:CFoliageProfile
        public Nullable<float> MeshTotalHeight { get; set; } = 0f;     //Float
        public Nullable<float> ForceTerrainBlend { get; set; } = 0f;     //Float
    }
    public partial class _speedtree_3d_v8_twosided
    {
        public string WindNoise { get; set; } = @"engine\textures\game_wind_noise.xbm";    //rRef:ITexture
        public string BoneMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string BonesPositionsMap { get; set; } = @"";    //rRef:ITexture
        public string BonesAdditionalDataMap { get; set; } = @"";    //rRef:ITexture
        public Vec4 BoneMapData { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> WindLodFlags { get; set; } = 0f;     //Float
        public Nullable<float> WindDataAvailable { get; set; } = 0f;     //Float
        public Nullable<float> TwosidedFlipN { get; set; } = 1f;     //Float
        public string DiffuseMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string NormalMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string TransGlossMap { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string FoliageProfileMap { get; set; } = @"";    //rRef:ITexture
        public string FoliageProfile { get; set; } = @"engine\materials\defaults\default.fp";     //rRef:CFoliageProfile
        public Nullable<float> MeshTotalHeight { get; set; } = 0f;     //Float
        public Nullable<float> ForceTerrainBlend { get; set; } = 0f;     //Float
    }
    public partial class _spline_deformed_metal_base
    {
        public Nullable<float> SplineLength { get; set; } = 1f;     //Float
        public Nullable<float> SpanCount { get; set; } = 1f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.38f;     //Float
    }
    public partial class _terrain_simple
    {
        public Vec4 UVGenScaleOffset { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string GlobalNormal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string MaskFoliage { get; set; } = @"";    //rRef:ITexture
    }
    public partial class _top_down_car_proxy_depth
    {
    }
    public partial class _trail_decal
    {
        public Nullable<float> DepthOffset { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"base\fx\textures\fire\fire1.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> Roughness { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _trail_decal_normal
    {
        public Nullable<float> DepthOffset { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _trail_decal_normal_color
    {
        public Nullable<float> DepthOffset { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> Roughness { get; set; } = 1f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _transparent_liquid
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> SurfaceMetalness { get; set; } = 0f;     //Float
        public Color ScatteringColorThin { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color ScatteringColorThick { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color Albedo { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Nullable<float> IOR { get; set; } = 1.33f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public Nullable<float> Roughness { get; set; } = 0f;     //Float
        public Nullable<float> SpecularStrengthMultiplier { get; set; } = 0.5f;     //Float
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> MaskOpacity { get; set; } = 1f;     //Float
        public Nullable<float> ThicknessMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> SubUVWidth { get; set; } = 1f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> InterpolateFrames { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.05f;     //Float
        public Vec4 NormalTilingAndScrolling { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public string Distort { get; set; } = @"engine\ink\textures\4x4_black.xbm";    //rRef:ITexture
        public Nullable<float> DistortAmount { get; set; } = 0f;     //Float
        public Vec4 DistortTilingAndScrolling { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public string Mask { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> EnableRowAnimation { get; set; } = 0f;     //Float
        public Nullable<float> UseOnStaticMeshes { get; set; } = 0f;     //Float
    }
    public partial class _underwater_blood
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> DebugTimeOverride { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 120f;     //Float
        public Nullable<float> frame_rate { get; set; } = 30f;     //Float
        public Nullable<float> StartDelayFrames { get; set; } = 0f;     //Float
        public Nullable<float> SimulationAtlasFrameCountX { get; set; } = 16f;     //Float
        public Nullable<float> SimulationAtlasFrameCountY { get; set; } = 16f;     //Float
        public string SimulationAtlas { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> SpeedExponent { get; set; } = 1f;     //Float
        public Color ColorScale { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Color ColorScale1 { get; set; } = new Color(208, 0, 0, 255);      //Color
        public Color ColorScale2 { get; set; } = new Color(24, 0, 0, 255);      //Color
        public Vec4 ColorGradientPositions { get; set; } = new Vec4(0f, 0.5f, 1f, 1f);    //Vector4
        public Nullable<float> ColorMode { get; set; } = 1f;     //Float
    }
    public partial class _vehicle_destr_blendshape
    {
        public Nullable<float> DamageInfluence { get; set; } = 1f;     //Float
        public Nullable<float> DamageInfluenceDebug { get; set; } = 0f;     //Float
        public Nullable<float> Opacity { get; set; } = 0f;     //Float
        public Nullable<float> TextureTiling { get; set; } = 0.5f;     //Float
        public string BakedNormal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string ScratchMask { get; set; } = @"base\vehicles\common\textures\vehicles_destruction_01_mask.xbm";    //rRef:ITexture
        public string DirtMap { get; set; } = @"base\vehicles\common\textures\dust_fine.xbm";    //rRef:ITexture
        public string MultilayerMask { get; set; } = @"engine\materials\defaults\multilayer_default.mlmask";     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; } = @"engine\materials\defaults\multilayer_default.mlsetup";     //rRef:Multilayer_Setup
        public string GlobalNormal { get; set; } = @"base\vehicles\common\textures\vehicles_destruction_01_n.xbm";    //rRef:ITexture
        public Nullable<float> ScratchResistance { get; set; } = 0f;     //Float
        public Nullable<float> DirtOpacity { get; set; } = 0f;     //Float
        public Color DirtColor { get; set; } = new Color(131, 102, 77, 255);      //Color
        public Vec4 DirtMaskOffsets { get; set; } = new Vec4(1.5f, 1f, 0.5f, 3f);    //Vector4
        public Color CoatTintFwd { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color CoatTintSide { get; set; } = new Color(249, 249, 249, 255);      //Color
        public Nullable<float> CoatTintFresnelBias { get; set; } = 1f;     //Float
        public Color CoatSpecularColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> CoatFresnelBias { get; set; } = 1f;     //Float
        public Nullable<float> CoatLayerMin { get; set; } = 0f;     //Float
        public Nullable<float> CoatLayerMax { get; set; } = 0f;     //Float
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
    }
    public partial class _vehicle_glass
    {
        public Nullable<float> UvTilingX { get; set; } = 1f;     //Float
        public Nullable<float> UvTilingY { get; set; } = 1f;     //Float
        public Nullable<float> UvOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UvOffsetY { get; set; } = 0f;     //Float
        public Nullable<float> DamageInfluence { get; set; } = 0f;     //Float
        public Nullable<float> DamageInfluenceDebug { get; set; } = 0f;     //Float
        public Nullable<float> Opacity { get; set; } = 1f;     //Float
        public Nullable<float> OpacityBackFace { get; set; } = 0f;     //Float
        public string GlassTint { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(162, 173, 180, 0);      //Color
        public Color TintSurface { get; set; } = new Color(129, 131, 106, 255);      //Color
        public Nullable<float> FrontFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> BackFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public Color GlassSpecularColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public string MaskTexture { get; set; } = @"base\vehicles\common\textures\common_windows_dirt_d02.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; } = 0f;     //Float
        public Nullable<float> MaskOpacity { get; set; } = 1f;     //Float
        public Nullable<float> MaskRoughnessBias { get; set; } = -0.4f;     //Float
        public Nullable<float> UseDamageGrid { get; set; } = 1f;     //Float
        public Nullable<float> UseShatterPoints { get; set; } = 1f;     //Float
        public Color ShatterColor { get; set; } = new Color(141, 203, 211, 240);      //Color
        public string ShatterTexture { get; set; } = @"base\vehicles\common\textures\bullethole_mask.xbm";    //rRef:ITexture
        public string ShatterNormal { get; set; } = @"base\vehicles\common\textures\bullethole_n01.xbm";    //rRef:ITexture
        public Nullable<float> ShatterNormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> ShatterRadiusScale { get; set; } = 0.125f;     //Float
        public Nullable<float> ShatterAspectRatio { get; set; } = 0.5f;     //Float
        public Nullable<float> ShatterCutout { get; set; } = 0.7f;     //Float
        public Nullable<float> DamageGridCutout { get; set; } = 0.33f;     //Float
        public Vec4 DebugShatterPoint0 { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public string Cracks { get; set; } = @"base\vehicles\common\textures\cracked_glass_mask.xbm";    //rRef:ITexture
        public Nullable<float> CracksTiling { get; set; } = 14f;     //Float
        public string DotsNormalTxt { get; set; } = @"base\vehicles\common\textures\vehicle_glass_rain_drops_n.xbm";    //rRef:ITexture
        public string DotsTxt { get; set; } = @"base\vehicles\common\textures\vehicle_glass_rain_drops.xbm";    //rRef:ITexture
        public string FlowTxt { get; set; } = @"base\vehicles\common\textures\vehicle_glass_rain_flow.xbm";    //rRef:ITexture
        public string WiperMask { get; set; } = @"base\vehicles\common\textures\wipers_mask.xbm";    //rRef:ITexture
    }
    public partial class _vehicle_glass_proxy
    {
        public Nullable<float> UvTilingX { get; set; } = 1f;     //Float
        public Nullable<float> UvTilingY { get; set; } = 1f;     //Float
        public Nullable<float> UvOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UvOffsetY { get; set; } = 0f;     //Float
        public string GlassTint { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(162, 173, 180, 0);      //Color
        public Nullable<float> FrontFacesReflectionPower { get; set; } = 1f;     //Float
        public Color GlassSpecularColor { get; set; } = new Color(255, 255, 255, 255);      //Color
    }
    public partial class _vehicle_lights
    {
        public Nullable<float> UvTilingX { get; set; } = 1f;     //Float
        public Nullable<float> UvTilingY { get; set; } = 1f;     //Float
        public Nullable<float> UvOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UvOffsetY { get; set; } = 0f;     //Float
        public Nullable<float> DamageInfluence { get; set; } = 1f;     //Float
        public Nullable<float> DamageInfluenceDebug { get; set; } = 0f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public Nullable<float> AlphaThreshold { get; set; } = 0.3333f;     //Float
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public string Emissive { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> EmissionTiling { get; set; } = 1f;     //Float
        public Nullable<float> EmissionParallax { get; set; } = 0f;     //Float
        public Nullable<float> Zone0EmissiveEV { get; set; } = 5f;     //Float
        public Nullable<float> Zone1EmissiveEV { get; set; } = 5f;     //Float
        public Nullable<float> Zone2EmissiveEV { get; set; } = 5f;     //Float
        public Nullable<float> Zone3EmissiveEV { get; set; } = 5f;     //Float
        public Vec4 DebugLightsIntensity { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Color DebugLightsColor0 { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Color DebugLightsColor1 { get; set; } = new Color(0, 255, 0, 255);      //Color
        public Color DebugLightsColor2 { get; set; } = new Color(0, 30, 255, 255);      //Color
        public Color DebugLightsColor3 { get; set; } = new Color(255, 255, 255, 255);      //Color
    }
    public partial class _vehicle_mesh_decal
    {
        public Nullable<float> DamageInfluence { get; set; } = 1f;     //Float
        public Nullable<float> DamageInfluenceDebug { get; set; } = 0f;     //Float
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DiffuseAlpha { get; set; } = 1f;     //Float
        public string MaskTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string GradientMap { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> UseGradientMap { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 1f;     //Float
        public Nullable<float> NormalsBlendingMode { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string MetalnessTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Nullable<float> DepthThreshold { get; set; } = 0.5f;     //Float
        public string DirtMap { get; set; } = @"base\vehicles\common\textures\dust_fine.xbm";    //rRef:ITexture
        public Nullable<float> DirtOpacity { get; set; } = 0f;     //Float
        public Vec4 DirtMaskOffsets { get; set; } = new Vec4(1.5f, 1f, 0.5f, 3f);    //Vector4
    }
    public partial class _ver_mov
    {
        public Nullable<float> IsControlledByDestruction { get; set; } = 1f;     //Float
        public string vertex_paint_tex { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> trans_min { get; set; } = 0f;     //Float
        public Nullable<float> trans_max { get; set; } = 0f;     //Float
        public Nullable<float> rot_min { get; set; } = 0f;     //Float
        public Nullable<float> rot_max { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 0f;     //Float
        public Nullable<float> n_pieces { get; set; } = 0f;     //Float
        public Nullable<float> play_time { get; set; } = 0f;     //Float
        public Nullable<float> debug_familys { get; set; } = 0f;     //Float
        public Nullable<float> frame_rate { get; set; } = 24f;     //Float
        public Nullable<float> YAxisUp { get; set; } = 0f;     //Float
        public Nullable<float> z_min { get; set; } = 0f;     //Float
        public Nullable<float> ground_offset { get; set; } = 0f;     //Float
        public string BaseColor { get; set; } = @"base\materials\placeholder\grey.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(186, 186, 186, 255);      //Color
        public string Roughness { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0.08f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Metalness { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _ver_mov_glass
    {
        public Nullable<float> Opacity { get; set; } = 0f;     //Float
        public Nullable<float> OpacityBackFace { get; set; } = 0f;     //Float
        public Nullable<float> UvTilingX { get; set; } = 1f;     //Float
        public Nullable<float> UvTilingY { get; set; } = 1f;     //Float
        public Nullable<float> UvOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> UvOffsetY { get; set; } = 0f;     //Float
        public Vec4 RoughnessTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 NormalTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 GlassTintTileAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public string vertex_paint_tex { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> IsControlledByDestruction { get; set; } = 1f;     //Float
        public Nullable<float> trans_min { get; set; } = 0f;     //Float
        public Nullable<float> trans_max { get; set; } = 0f;     //Float
        public Nullable<float> rot_min { get; set; } = 0f;     //Float
        public Nullable<float> rot_max { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 0f;     //Float
        public Nullable<float> n_pieces { get; set; } = 0f;     //Float
        public Nullable<float> play_time { get; set; } = 0f;     //Float
        public Nullable<float> debug_familys { get; set; } = 0f;     //Float
        public Nullable<float> frame_rate { get; set; } = 24f;     //Float
        public Nullable<float> YAxisUp { get; set; } = 0f;     //Float
        public Nullable<float> z_min { get; set; } = 0f;     //Float
        public Nullable<float> ground_offset { get; set; } = 0f;     //Float
        public string GlassTint { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> TintFromVertexPaint { get; set; } = 0f;     //Float
        public Nullable<float> FrontFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> BackFacesReflectionPower { get; set; } = 1f;     //Float
        public Nullable<float> IOR { get; set; } = 1f;     //Float
        public Nullable<float> RefractionDepth { get; set; } = 2.5f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public Color GlassSpecularColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> NormalMapAffectsSpecular { get; set; } = 1f;     //Float
        public string MaskTexture { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> SurfaceMetalness { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> MaskOpacity { get; set; } = 0f;     //Float
        public Nullable<float> GlassRoughnessBias { get; set; } = -1f;     //Float
        public Nullable<float> MaskRoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> BlurRadius { get; set; } = 0f;     //Float
        public Nullable<float> BlurByRoughness { get; set; } = 0f;     //Float
    }
    public partial class _ver_mov_multilayered
    {
        public string vertex_paint_tex { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> IsControlledByDestruction { get; set; } = 1f;     //Float
        public Nullable<float> trans_min { get; set; } = 0f;     //Float
        public Nullable<float> trans_max { get; set; } = 0f;     //Float
        public Nullable<float> rot_min { get; set; } = 0f;     //Float
        public Nullable<float> rot_max { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 0f;     //Float
        public Nullable<float> n_pieces { get; set; } = 0f;     //Float
        public Nullable<float> play_time { get; set; } = 0f;     //Float
        public Nullable<float> frame_rate { get; set; } = 24f;     //Float
        public Nullable<float> z_min { get; set; } = 0f;     //Float
        public Nullable<float> ground_offset { get; set; } = 0f;     //Float
        public string GlobalNormal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string MultilayerMask { get; set; } = @"engine\materials\defaults\multilayer_default.mlmask";     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; } = @"engine\materials\defaults\multilayer_default.mlsetup";     //rRef:Multilayer_Setup
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
    }
    public partial class _ver_skinned_mov
    {
        public string vertex_paint_tex { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string vertex_paint_tex_z { get; set; } = @"base\worlds\03_night_city\sectors\c_city_center\corpo_plaza\loc_arasaka_tower\loc_arasaka_tower_env\interior\jungle_destruction_zmap.xbm";    //rRef:ITexture
        public Nullable<float> trans_min { get; set; } = 0f;     //Float
        public Nullable<float> trans_max { get; set; } = 0f;     //Float
        public Nullable<float> rot_min { get; set; } = 0f;     //Float
        public Nullable<float> rot_max { get; set; } = 0f;     //Float
        public Nullable<float> buffer_offset { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 0f;     //Float
        public Nullable<float> n_pieces { get; set; } = 0f;     //Float
        public Nullable<float> play_time { get; set; } = 0f;     //Float
        public Nullable<float> debug_familys { get; set; } = 0f;     //Float
        public Nullable<float> frame_rate { get; set; } = 24f;     //Float
        public Nullable<float> YAxisUp { get; set; } = 0f;     //Float
        public Nullable<float> z_multiply { get; set; } = 20f;     //Float
        public Nullable<float> ground_offset { get; set; } = 317.5759f;     //Float
        public Vec4 bounds_and_pivot { get; set; } = new Vec4(155.773f, 145.11f, -1450.6914f, 153.03485f);    //Vector4
        public string BaseColor { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 0);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string FoliageProfileMap { get; set; } = @"";    //rRef:ITexture
        public string FoliageProfile { get; set; } = @"";     //rRef:CFoliageProfile
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _ver_skinned_mov_parade
    {
        public string vertex_paint_tex { get; set; } = @"base\characters\garment\npc_blob\npc_blob_animation_data.xbm";    //rRef:ITexture
        public Nullable<float> trans_min { get; set; } = 0f;     //Float
        public Nullable<float> trans_max { get; set; } = 0f;     //Float
        public Nullable<float> rot_min { get; set; } = 0f;     //Float
        public Nullable<float> rot_max { get; set; } = 0f;     //Float
        public Nullable<float> n_frames { get; set; } = 0f;     //Float
        public Nullable<float> n_pieces { get; set; } = 0f;     //Float
        public Nullable<float> frame_rate { get; set; } = 24f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\checker_d.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 0);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _window_interior_uv
    {
        public string Glass { get; set; } = @"base\surfaces\masks\window_glass_a_mask.xbm";    //rRef:ITexture
        public Nullable<float> LightIntensity { get; set; } = 0f;     //Float
        public Color LightColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Color GlassColor { get; set; } = new Color(100, 100, 100, 100);      //Color
        public string Roughness { get; set; } = @"base\surfaces\masks\simple_glass_transparency_m.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalScale { get; set; } = 1f;     //Float
        public Nullable<float> RoomHeight { get; set; } = 1f;     //Float
        public Nullable<float> RoomWidth { get; set; } = 1f;     //Float
        public Vec4 TextureTiling { get; set; } = new Vec4(2f, 2f, 2f, 6f);    //Vector4
        public Color CeilFloorColor { get; set; } = new Color(177, 177, 177, 255);      //Color
        public Color WallColor { get; set; } = new Color(177, 177, 177, 255);      //Color
        public string Ceiling { get; set; } = @"test\env_test\wallatlas2.xbm";    //rRef:ITexture
        public string WallsXY { get; set; } = @"test\env_test\wallatlas2.xbm";    //rRef:ITexture
        public string WallsZY { get; set; } = @"test\env_test\wallatlas2.xbm";    //rRef:ITexture
        public string Floor { get; set; } = @"test\env_test\wallatlas2.xbm";    //rRef:ITexture
    }
    public partial class _window_parallax_interior
    {
        public string RoomAtlas { get; set; } = @"base\surfaces\parallax\placeholder\parallax_day.xbm";    //rRef:ITexture
        public string LayerAtlas { get; set; } = @"base\surfaces\parallax\placeholder\parallax_day_layer.xbm";    //rRef:ITexture
        public string Curtain { get; set; } = @"base\surfaces\parallax\placeholder\blinds.xbm";    //rRef:ITexture
        public string ColorOverlayTexture { get; set; } = @"base\surfaces\parallax\coloroverlay.xbm";    //rRef:ITexture
        public Vec4 AtlasGridUvRatio { get; set; } = new Vec4(1f, 4f, 1f, 1f);    //Vector4
        public Nullable<float> AtlasDepth { get; set; } = 1f;     //Float
        public Nullable<float> roomWidth { get; set; } = 6f;     //Float
        public Nullable<float> roomHeight { get; set; } = 4f;     //Float
        public Nullable<float> roomDepth { get; set; } = 4f;     //Float
        public Nullable<float> positionXoffset { get; set; } = 0f;     //Float
        public Nullable<float> positionYoffset { get; set; } = 0f;     //Float
        public Nullable<float> scaleXrandomization { get; set; } = 0f;     //Float
        public Nullable<float> positionXrandomization { get; set; } = 0f;     //Float
        public Nullable<float> LayerDepth { get; set; } = 0.4f;     //Float
        public Nullable<float> CurtainDepth { get; set; } = 0.3f;     //Float
        public Nullable<float> CurtainMaxCover { get; set; } = 0.4f;     //Float
        public Nullable<float> CurtainCoverRandomize { get; set; } = 0.5f;     //Float
        public Nullable<float> CurtainAlpha { get; set; } = 0.9f;     //Float
        public Nullable<float> LightsTempVariationAtNight { get; set; } = 0f;     //Float
        public Nullable<float> AmountTurnOffAtNight { get; set; } = 0.2f;     //Float
        public string WindowTexture { get; set; } = @"base\surfaces\masks\simple_glass_transparency_m.xbm";    //rRef:ITexture
        public Color TintColorAtNight { get; set; } = new Color(255, 255, 255, 0);      //Color
        public string Roughness { get; set; } = @"base\surfaces\masks\glass_generic_01_200_r.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"base\surfaces\masks\glass_generic_01_200_n.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 0.1f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 3.52741f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _window_parallax_interior_proxy
    {
        public string RoomAtlas { get; set; } = @"base\surfaces\parallax\placeholder\parallax_day.xbm";    //rRef:ITexture
        public string Curtain { get; set; } = @"base\surfaces\parallax\placeholder\blinds.xbm";    //rRef:ITexture
        public string ColorOverlayTexture { get; set; } = @"base\surfaces\parallax\coloroverlay.xbm";    //rRef:ITexture
        public Vec4 AtlasGridUvRatio { get; set; } = new Vec4(1f, 4f, 1f, 1f);    //Vector4
        public Nullable<float> AtlasDepth { get; set; } = 0f;     //Float
        public Nullable<float> roomWidth { get; set; } = 6f;     //Float
        public Nullable<float> roomHeight { get; set; } = 4f;     //Float
        public Nullable<float> roomDepth { get; set; } = 4f;     //Float
        public Nullable<float> positionXoffset { get; set; } = 0f;     //Float
        public Nullable<float> positionYoffset { get; set; } = 0f;     //Float
        public Nullable<float> scaleXrandomization { get; set; } = 0f;     //Float
        public Nullable<float> positionXrandomization { get; set; } = 0f;     //Float
        public Nullable<float> LightsTempVariationAtNight { get; set; } = 0f;     //Float
        public Nullable<float> CurtainDepth { get; set; } = 0.3f;     //Float
        public Nullable<float> CurtainMaxCover { get; set; } = 0.4f;     //Float
        public Nullable<float> CurtainCoverRandomize { get; set; } = 0.5f;     //Float
        public Nullable<float> CurtainAlpha { get; set; } = 0.9f;     //Float
        public Nullable<float> AmountTurnOffAtNight { get; set; } = 0.2f;     //Float
        public Color TintColorAtNight { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 4f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
    }
    public partial class _window_parallax_interior_proxy_buffer
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\checker_d.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 0);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _window_very_long_distance
    {
        public string BaseColor { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string Mask { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string ColorOverlayTexture { get; set; } = @"base\surfaces\parallax\coloroverlay.xbm";    //rRef:ITexture
        public string WorldHeightMap { get; set; } = @"base\surfaces\textures\city_depth_r.xbm";    //rRef:ITexture
        public string WorldColorMap { get; set; } = @"base\surfaces\textures\city_color_d.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> WindowsSize { get; set; } = 3f;     //Float
        public Nullable<float> Saturation { get; set; } = 0.75f;     //Float
        public Nullable<float> TurnedOff { get; set; } = 0.45f;     //Float
        public Nullable<float> FadeStart { get; set; } = 600f;     //Float
        public Nullable<float> FadeEnd { get; set; } = 1200f;     //Float
        public Nullable<float> LightsFadeStart { get; set; } = 600f;     //Float
        public Nullable<float> LightsFadeEnd { get; set; } = 1200f;     //Float
        public Nullable<float> LightsIntensityMultiplier { get; set; } = 10f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 1f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
    }
    public partial class _worldspace_grid
    {
        public Nullable<float> GridScale { get; set; } = 0f;     //Float
        public string BaseColor { get; set; } = @"test\level_design\ld_kit\textures\ruler_checker_1m_wall.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> EnableWorldSpace { get; set; } = 0f;     //Float
        public Nullable<float> AbsoluteWorldSpace { get; set; } = 1f;     //Float
    }
    public partial class _bink_simple
    {
        public Color ColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string VideoCanvasName { get; set; } = @"";     //CName
        public string BinkY { get; set; } = @"";    //rRef:ITexture
        public string BinkCR { get; set; } = @"";    //rRef:ITexture
        public string BinkCB { get; set; } = @"";    //rRef:ITexture
        public string BinkA { get; set; } = @"";    //rRef:ITexture
        public DataBuffer BinkParams { get; set; }
    }
    public partial class _cable_strip
    {
        public Nullable<float> CableWidth { get; set; } = 1f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
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
        public string WaterFFT { get; set; } = @"engine\textures\global_ocean_patch\water_patch_fft.dtex";    //rRef:ITexture
        public string WaterMap { get; set; } = @"engine\textures\global_ocean_patch\nc_water.xbm";    //rRef:ITexture
        public Nullable<float> WaterMapWeight { get; set; } = 0f;     //Float
        public Nullable<float> WaterSize { get; set; } = 0.25f;     //Float
        public Nullable<float> ShoreThreshold { get; set; } = 0f;     //Float
        public Nullable<float> ShoreOffset { get; set; } = 0f;     //Float
        public Vec4 Choppiness { get; set; } = new Vec4(-40f, -40f, 40f, 1f);    //Vector4
        public Nullable<float> ScatteringDepth { get; set; } = 2f;     //Float
        public Nullable<float> NormalDetailScale { get; set; } = 5f;     //Float
        public Nullable<float> NormalDetailIntensity { get; set; } = 1f;     //Float
        public Nullable<float> ScatteringSunRadius { get; set; } = 1.5f;     //Float
        public Nullable<float> ScatteringSunIntensity { get; set; } = 1.5f;     //Float
        public Color ScatteringColor { get; set; } = new Color(59, 153, 153, 51);      //Color
        public Nullable<float> BlurRadius { get; set; } = 1f;     //Float
        public Nullable<float> ScatteringSlopeThreshold { get; set; } = 0.025f;     //Float
        public Nullable<float> ScatteringSlopeIntensity { get; set; } = 5f;     //Float
        public Nullable<float> WaterOpacity { get; set; } = 1f;     //Float
        public Nullable<float> IndexOfRefraction { get; set; } = 1.33f;     //Float
        public Nullable<float> RefractionNormalIntensity { get; set; } = 2f;     //Float
        public Nullable<float> BlurStrength { get; set; } = 0f;     //Float
        public string FoamTexture { get; set; } = @"engine\textures\global_ocean_patch\sea_water_foam.xbm";    //rRef:ITexture
        public Color FoamColor { get; set; } = new Color(202, 202, 202, 255);      //Color
        public Nullable<float> FoamSize { get; set; } = 50f;     //Float
        public Nullable<float> FoamThreshold { get; set; } = 0.25f;     //Float
        public Nullable<float> FoamIntensity { get; set; } = 0.1f;     //Float
        public Nullable<float> EdgeBlend { get; set; } = 0.1f;     //Float
    }
    public partial class _metal_base_animated_uv
    {
        public Nullable<float> UvPanningSpeedX { get; set; } = 0f;     //Float
        public Nullable<float> UvPanningSpeedY { get; set; } = 0.2f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\checker_d.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public string Emissive { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveLift { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.38f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
    }
    public partial class _metal_base_blendable
    {
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_05\braindance_noise3d_05.texarray";    //rRef:ITexture
        public Nullable<float> FadeOutDistance { get; set; } = 0.5f;     //Float
        public Nullable<float> FadeOutOffset { get; set; } = 0f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 5f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 2f;     //Float
        public Color FresnelColor { get; set; } = new Color(0, 229, 255, 255);      //Color
        public Nullable<float> FresnelColorIntensity { get; set; } = 8f;     //Float
        public Nullable<float> FresnelExponent { get; set; } = 2f;     //Float
        public string BaseColor { get; set; } = @"base\materials\placeholder\grey.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"base\materials\placeholder\grey.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public string Emissive { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveLift { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.333f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
    }
    public partial class _metal_base_fence
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.5f;     //Float
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
    }
    public partial class _metal_base_garment
    {
        public string BaseColor { get; set; } = @"";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public Nullable<float> LayerTile { get; set; } = 0f;     //Float
    }
    public partial class _metal_base_packed
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string RoughMetal { get; set; } = @"engine\textures\editor\roughmetal.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.3f;     //Float
    }
    public partial class _metal_base_proxy
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public string WorldColorMap { get; set; } = @"base\surfaces\textures\city_color_d.xbm";    //rRef:ITexture
        public string WorldHeightMap { get; set; } = @"base\surfaces\textures\city_depth_r.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 5f;     //Float
        public string Emissive { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> FadeStart { get; set; } = 600f;     //Float
        public Nullable<float> FadeEnd { get; set; } = 1200f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveLift { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.381818f;     //Float
        public Nullable<float> LayerTile { get; set; } = 0f;     //Float
    }
    public partial class _multilayered
    {
        public string GlobalNormal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string MultilayerMask { get; set; } = @"engine\materials\defaults\multilayer_default.mlmask";     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; } = @"engine\materials\defaults\multilayer_default.mlsetup";     //rRef:Multilayer_Setup
        public Nullable<float> GlobalNormalIntensity { get; set; } = 1f;     //Float
        public Vec4 GlobalNormalUVScale { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 GlobalNormalUVBias { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
    }
    public partial class _multilayered_debug
    {
    }
    public partial class _pbr_simple
    {
        public Color Color { get; set; } = new Color(255, 142, 93, 255);      //Color
        public Nullable<float> Roughness { get; set; } = 1f;     //Float
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
    }
    public partial class _shadows_debug
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(0, 0, 0, 0);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
    }
    public partial class _transparent_notxaa_2
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string Diffuse { get; set; } = @"base\environment\decoration\stickers\textures\decal_wall_stickers_d.xbm";    //rRef:ITexture
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
        public string CameraName { get; set; } = @"";     //CName
    }
    public partial class _ui_text_element
    {
        public Nullable<float> hackParameterForUiBatcher { get; set; } = 0f;     //Float
    }
    public partial class _alphablend_glass
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string Diffuse { get; set; } = @"base\fx\textures\other\animals_advert.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Vec4 TextureScaling { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> InterlaceScale { get; set; } = 360f;     //Float
        public Nullable<float> InterlaceIntensityLow { get; set; } = 1f;     //Float
        public Nullable<float> InterlaceIntensityHigh { get; set; } = 1f;     //Float
        public Nullable<float> UVdivisions { get; set; } = 3f;     //Float
        public Nullable<float> UVoffset { get; set; } = 0.5f;     //Float
        public Nullable<float> Emissive { get; set; } = 150f;     //Float
    }
    public partial class _alpha_control_refraction
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string RefractionMap { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string RecolorMap { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RefractionAmount { get; set; } = 3f;     //Float
        public Nullable<float> RefractionSpeed { get; set; } = 0f;     //Float
        public Nullable<float> JerkingSpeed { get; set; } = 0f;     //Float
        public Nullable<float> JerkingAmount { get; set; } = 0f;     //Float
        public Nullable<float> MaxAlpha { get; set; } = 0f;     //Float
        public Nullable<float> RecolorAmount { get; set; } = 0f;     //Float
        public Nullable<float> RecolorMultiplier { get; set; } = 0f;     //Float
        public Color SpecularColor { get; set; } = new Color(0, 0, 0, 0);      //Color
    }
    public partial class _animated_decal
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseAlpha { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalAlpha { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string MetalnessTexture { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string RevealMasks { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 0f;     //Float
        public Nullable<float> AnimationFramesWidth { get; set; } = 0f;     //Float
        public Nullable<float> AnimationFramesHeight { get; set; } = 0f;     //Float
        public Nullable<float> FloatParam { get; set; } = 0f;     //Float
    }
    public partial class _beam_particles
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string MainTexture { get; set; } = @"base\fx\textures\smoke\smoke_exhaust_av_dif.xbm";    //rRef:ITexture
        public string AdditionalMask { get; set; } = @"base\fx\_textures\weapons\trails\fx_bullet_smoke_trail_02_d.xbm";    //rRef:ITexture
        public Nullable<float> UseMaskROrA { get; set; } = 1f;     //Float
        public string AdditionalMaskFlowmap { get; set; } = @"base\fx\_textures\weapons\trails\fx_trails_refraction_01_d.xbm";    //rRef:ITexture
        public Color MainColor { get; set; } = new Color(255, 160, 0, 255);      //Color
        public Nullable<float> ColorMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> TextureScale { get; set; } = 1f;     //Float
        public Nullable<float> TextureStretch { get; set; } = 0f;     //Float
        public Nullable<float> TextureHasNoAlpha { get; set; } = 0f;     //Float
        public Nullable<float> BlackbodyOrColor { get; set; } = 0f;     //Float
        public Vec4 FlowmapControl { get; set; } = new Vec4(1f, 1f, 0.2f, 0f);    //Vector4
        public Vec4 AdditionalMaskControl { get; set; } = new Vec4(1f, 1f, 0.5f, 0f);    //Vector4
        public Nullable<float> FlowmapMultiplier { get; set; } = 0.1f;     //Float
        public Nullable<float> TextureHasAlpha { get; set; } = 0f;     //Float
    }
    public partial class _blackbodyradiation
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> Temperature { get; set; } = 30.09901f;     //Float
        public Nullable<float> subUVWidth { get; set; } = 1f;     //Float
        public Nullable<float> AlphaExponent { get; set; } = 1f;     //Float
        public Nullable<float> subUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> ScatterAmount { get; set; } = 0f;     //Float
        public Nullable<float> ScatterPower { get; set; } = 0.730769f;     //Float
        public string FireScatterAlpha { get; set; } = @"base\fx\_textures\fire\fx_explosion_big_v001_8x8_d.xbm";    //rRef:ITexture
        public Nullable<float> HueShift { get; set; } = 1f;     //Float
        public Nullable<float> HueSpread { get; set; } = 1f;     //Float
        public Nullable<float> maxAlpha { get; set; } = 1f;     //Float
        public Color LightSmoke { get; set; } = new Color(117, 117, 117, 255);      //Color
        public Color DarkSmoke { get; set; } = new Color(75, 75, 75, 255);      //Color
        public Nullable<float> ExpensiveBlending { get; set; } = 1f;     //Float
        public Nullable<float> Saturation { get; set; } = 0f;     //Float
        public Nullable<float> SoftAlpha { get; set; } = 0f;     //Float
        public Nullable<float> MultiplierExponent { get; set; } = 1f;     //Float
        public Vec4 TexCoordDtortScale { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Vec4 TexCoordDtortSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public string Distort { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public Nullable<float> NoAlphaOnTexture { get; set; } = 0f;     //Float
        public Nullable<float> EatUpOrStraightAlpha { get; set; } = 1f;     //Float
        public Nullable<float> DistortAmount { get; set; } = 0f;     //Float
        public Nullable<float> EnableRowAnimation { get; set; } = 0f;     //Float
        public Nullable<float> DoNotApplyLighting { get; set; } = 0f;     //Float
        public string MaskTexture { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> InvertMask { get; set; } = 0f;     //Float
        public Vec4 MaskTilingAndSpeed { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> MaskIntensity { get; set; } = 1f;     //Float
        public Nullable<float> UseVertexAlpha { get; set; } = 0f;     //Float
        public Nullable<float> DotWithLookAt { get; set; } = 0f;     //Float
    }
    public partial class _blackbody_simple
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string TemperatureTexture { get; set; } = @"base\fx\_textures\sparks\fx_sparks_oblong_03_2x1_r.xbm";    //rRef:ITexture
        public Nullable<float> Temperature { get; set; } = 25f;     //Float
        public Nullable<float> SubUVWidth { get; set; } = 2f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> SoftAlpha { get; set; } = 5f;     //Float
    }
    public partial class _blood_transparent
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color ColorThin { get; set; } = new Color(144, 0, 0, 255);      //Color
        public Color ColorThick { get; set; } = new Color(71, 0, 0, 255);      //Color
        public Nullable<float> BloodThickness { get; set; } = 0f;     //Float
        public Nullable<float> LightingBleeding { get; set; } = 0.211356f;     //Float
        public Nullable<float> SpecularPower { get; set; } = 5f;     //Float
        public Nullable<float> SpecularMultiplier { get; set; } = 3f;     //Float
        public Nullable<float> SubUVWidth { get; set; } = 2f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 5f;     //Float
        public Nullable<float> CurrentFrame { get; set; } = 1f;     //Float
        public string NormalAndDensity { get; set; } = @"base\fx\textures\blood\blood_v002_normal.xbm";    //rRef:ITexture
        public string VelocityMap { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string SpecularMap { get; set; } = @"base\fx\textures\other\kitchen_hdri.xbm";    //rRef:ITexture
        public Nullable<float> FlowmapStrength { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public Nullable<float> NormalPow { get; set; } = 0f;     //Float
        public Nullable<float> EVCompensation { get; set; } = 1f;     //Float
    }
    public partial class _braindance_fog
    {
        public Nullable<float> BrightnessNear { get; set; } = 0.4f;     //Float
        public Nullable<float> BrightnessFar { get; set; } = 0.15f;     //Float
        public string RevealMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RevealMaskFramesY { get; set; } = 4f;     //Float
        public Vec4 RevealMaskBoundsMin { get; set; } = new Vec4(-10000f, -10000f, -10000f, 0f);    //Vector4
        public Vec4 RevealMaskBoundsMax { get; set; } = new Vec4(10000f, 10000f, 10000f, 0f);    //Vector4
        public Nullable<float> TonemapExposure { get; set; } = 4f;     //Float
        public Nullable<float> FarFogBrightness { get; set; } = 0.2f;     //Float
        public Nullable<float> FarFogDistance { get; set; } = 60f;     //Float
        public Nullable<float> UseHack_SQ021 { get; set; } = 0f;     //Float
        public string CluesMap { get; set; } = @"base\fx\textures\braindance\braindance_clue_default_data.xbm";    //rRef:ITexture
        public Nullable<float> CluesBrightness { get; set; } = 1f;     //Float
        public Nullable<float> UseClueDepthClipping { get; set; } = 1f;     //Float
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_03\braindance_noise3d_03.texarray";    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; } = 32f;     //Float
        public Nullable<float> VectorFieldTiling { get; set; } = 4f;     //Float
        public Nullable<float> VectorFieldAnimSpeed { get; set; } = 0.3f;     //Float
        public Nullable<float> VectorFieldStrength { get; set; } = 0.1f;     //Float
    }
    public partial class _braindance_particle_thermal
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color Color { get; set; } = new Color(17, 235, 255, 255);      //Color
        public Nullable<float> Brightness { get; set; } = 4f;     //Float
        public string FireScatterAlpha { get; set; } = @"base\fx\_textures\fire\fx_explosion_big_v001_8x8_d.xbm";    //rRef:ITexture
        public Nullable<float> subUVWidth { get; set; } = 8f;     //Float
        public Nullable<float> subUVHeight { get; set; } = 8f;     //Float
        public Nullable<float> AlphaExponent { get; set; } = 1f;     //Float
        public Nullable<float> maxAlpha { get; set; } = 0.9f;     //Float
        public Nullable<float> EatUpOrStraightAlpha { get; set; } = 1f;     //Float
        public Nullable<float> SoftAlpha { get; set; } = 0f;     //Float
        public Nullable<float> UseVertexAlpha { get; set; } = 0f;     //Float
    }
    public partial class _cloak
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Distortion { get; set; } = @"base\surfaces\microblends\carbon_fiber.xbm";    //rRef:ITexture
        public Vec4 DistortionUVScale { get; set; } = new Vec4(24f, 24f, 0f, 0f);    //Vector4
        public Nullable<float> DistortionVisibility { get; set; } = 15f;     //Float
        public string IridescenceMask { get; set; } = @"base\fx\_textures\masks\noise\fx_low_frequency_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> IridescenceSpeed { get; set; } = 0.2f;     //Float
        public Nullable<float> IridescenceDim { get; set; } = 3f;     //Float
        public Color Tinge { get; set; } = new Color(78, 126, 132, 255);      //Color
        public string DirtMask { get; set; } = @"base\fx\_textures\masks\noise\fx_organic_noise_01_d.xbm";    //rRef:ITexture
        public Vec4 DirtMaskScaleAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> DirtMaskPower { get; set; } = 1.5f;     //Float
        public Nullable<float> DirtMaskMultiplier { get; set; } = 1.5f;     //Float
        public Color DirtColor { get; set; } = new Color(188, 188, 188, 255);      //Color
        public Nullable<float> UseOutline { get; set; } = 0f;     //Float
        public Nullable<float> OutlineOpacity { get; set; } = 4.5f;     //Float
        public Nullable<float> OutlineSize { get; set; } = 2.5f;     //Float
    }
    public partial class _cyberspace_pixelsort_stencil
    {
        public Nullable<float> CameraOffsetZ { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
    }
    public partial class _cyberspace_pixelsort_stencil_0
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
    }
    public partial class _cyberware_animation
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(76, 0, 0, 255);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0.8f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0.025f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0.05f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0.075f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string EmissiveMask { get; set; } = @"base\fx\textures\other\checker.xbm";    //rRef:ITexture
        public Nullable<float> UseTimeOrFloatParam { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 10f;     //Float
    }
    public partial class _damage_indicator
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string Mask { get; set; } = @"base\fx\textures\gradients\radial_gradient.xbm";    //rRef:ITexture
        public string Noise { get; set; } = @"base\fx\_textures\masks\noise\fx_organic_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> DoubleDistortWithNoise { get; set; } = 0f;     //Float
        public string Scanline { get; set; } = @"base\fx\_textures\masks\gradients\fx_reflected_vertical_gradient_01_noise_d.xbm";    //rRef:ITexture
        public Vec4 NoiseScailingAndSpeed { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public Nullable<float> MinMaskExponent { get; set; } = 1f;     //Float
        public Nullable<float> MaxMaskExponent { get; set; } = 20f;     //Float
        public Nullable<float> MaskMultiplier { get; set; } = 1f;     //Float
        public Color ThickScanlinesColor { get; set; } = new Color(255, 41, 41, 255);      //Color
        public Color ThinScanlinesColor { get; set; } = new Color(255, 170, 113, 255);      //Color
        public Nullable<float> ScanlineDensity { get; set; } = 300f;     //Float
        public Nullable<float> ScanlineMinimumValue { get; set; } = 0f;     //Float
        public Nullable<float> ThickScanlineMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> ThinScanlineExponent { get; set; } = 3f;     //Float
        public Nullable<float> ThinScanlineMultiplier { get; set; } = 50f;     //Float
        public Nullable<float> RefractionOffsetStrength { get; set; } = 0f;     //Float
    }
    public partial class _device_diode
    {
        public Nullable<float> NormalOffset { get; set; } = 0f;     //Float
        public Nullable<float> VehicleDamageInfluence { get; set; } = 1f;     //Float
        public string BaseColor { get; set; } = @"base\surfaces\materials\common\plastic_common_01_300_d.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(150, 0, 0, 0);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"base\surfaces\materials\plastic\plastic_lightcover\plastic_lightcover_01_50_r.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"base\surfaces\materials\plastic\plastic_lightcover\plastic_lightcover_01_50_n.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"base\fx\_textures\masks\gradients\fx_reflected_vertical_gradient_01_d.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 5f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.33f;     //Float
        public Nullable<float> Blinking { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> BlinkingSpeed { get; set; } = 8f;     //Float
        public Nullable<float> UseMaterialParameter { get; set; } = 1f;     //Float
        public Color EmissiveColor1 { get; set; } = new Color(127, 0, 0, 255);      //Color
        public Color EmissiveColor2 { get; set; } = new Color(0, 12, 127, 255);      //Color
        public Nullable<float> EmissiveInitialState { get; set; } = 0f;     //Float
        public Nullable<float> UseTwoEmissiveColors { get; set; } = 0f;     //Float
        public Nullable<float> SwitchingTwoEmissiveColorsSpeed { get; set; } = 0f;     //Float
        public Nullable<float> UseFresnel { get; set; } = 0f;     //Float
    }
    public partial class _device_diode_multi_state
    {
        public Nullable<float> NormalOffset { get; set; } = 0f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(0, 0, 0, 255);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string Emissive { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color EmissiveColor1 { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Color EmissiveColor2 { get; set; } = new Color(127, 255, 0, 255);      //Color
        public Color EmissiveColor3 { get; set; } = new Color(0, 254, 255, 255);      //Color
        public Color EmissiveColor4 { get; set; } = new Color(127, 0, 255, 255);      //Color
        public Nullable<float> EmissiveColorSelector { get; set; } = 1f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 4.3168063f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public Nullable<float> Blinking { get; set; } = 0f;     //Float
        public Nullable<float> BlinkingSpeed { get; set; } = 0f;     //Float
        public Nullable<float> UseMaterialParameter { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveInitialState { get; set; } = 0f;     //Float
    }
    public partial class _diode_pavements
    {
        public string BaseColor { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string DiodesMask { get; set; } = @"base\fx\textures\ui\diode_mask_normal.xbm";    //rRef:ITexture
        public string SignTexture { get; set; } = @"base\fx\textures\ui\no_parking.xbm";    //rRef:ITexture
        public Vec4 DiodesTilingAndScrollSpeed { get; set; } = new Vec4(20f, 20f, 0.1f, 0f);    //Vector4
        public Nullable<float> EmissiveEV { get; set; } = 3f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> UseMaskAsAlphaThreshold { get; set; } = 1f;     //Float
        public Nullable<float> AmountOfGlitch { get; set; } = 0f;     //Float
        public Nullable<float> GlitchSpeed { get; set; } = 0f;     //Float
        public Nullable<float> NumberOfRows { get; set; } = 0f;     //Float
        public Nullable<float> DisplayRow { get; set; } = 0f;     //Float
        public Vec4 BaseColorRoughnessTiling { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
    }
    public partial class _drugged_sobel
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color DarkColor { get; set; } = new Color(255, 0, 150, 255);      //Color
        public Color BrightColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DarkColorPower { get; set; } = 0.1f;     //Float
        public Nullable<float> KernelOffset { get; set; } = 0f;     //Float
        public Nullable<float> UseInEngineSobel { get; set; } = 0f;     //Float
    }
    public partial class _emissive_basic_transparent
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string Diffuse { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Mask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string AnimMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 0);      //Color
    }
    public partial class _fog_laser
    {
        public Nullable<float> AdditionalThicnkess { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> TimeScale { get; set; } = 1f;     //Float
        public string NoiseTexture { get; set; } = @"base\fx\_textures\masks\noise\fx_perlin_noise_02_d.xbm";    //rRef:ITexture
        public Nullable<float> DetailNoiseScale { get; set; } = 1f;     //Float
        public Nullable<float> DetailNoiseBrighten { get; set; } = 1f;     //Float
        public Nullable<float> GeneralNoiseScale { get; set; } = 1f;     //Float
        public Color LaserColor { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Nullable<float> SmokeExponent { get; set; } = 1f;     //Float
        public Nullable<float> SmokeMultiplier { get; set; } = 10f;     //Float
        public Nullable<float> LineThreshold { get; set; } = 1f;     //Float
        public Nullable<float> LineMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> LineAddOrSubtract { get; set; } = 1f;     //Float
        public Nullable<float> UseSoftAlpha { get; set; } = 0f;     //Float
        public Nullable<float> SoftAlpha { get; set; } = 0f;     //Float
        public Nullable<float> SoftAlphaMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> HorizontalGradientMultiplier { get; set; } = 500f;     //Float
        public Nullable<float> FlipEdgeFade { get; set; } = 0f;     //Float
        public Nullable<float> UseVertexColor { get; set; } = 0f;     //Float
        public Nullable<float> TextureRatioU { get; set; } = 1f;     //Float
        public Nullable<float> TextureRatioV { get; set; } = 0.175f;     //Float
        public Nullable<float> IntensiveCore { get; set; } = 0f;     //Float
        public Nullable<float> RotateUV { get; set; } = 0f;     //Float
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_00\braindance_noise3d_00.texarray";    //rRef:ITexture
        public Nullable<float> VectorFieldSliceCount { get; set; } = 32f;     //Float
        public Nullable<float> UseWorldSpace { get; set; } = 0f;     //Float
    }
    public partial class _hologram
    {
        public Vec4 ScaleReferencePosAndScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> GlitchChance { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> OpaqueScanlineDensity { get; set; } = 400f;     //Float
        public string Scanline { get; set; } = @"base\fx\_textures\masks\gradients\fx_reflected_vertical_gradient_03_alpha_d.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string DotsTexture { get; set; } = @"base\fx\characters\hologram\hologram_pointcloud_dot.xbm";    //rRef:ITexture
        public Nullable<float> DotsSize { get; set; } = 100f;     //Float
        public Color DotsColor { get; set; } = new Color(73, 168, 246, 255);      //Color
        public Vec4 Projector1Position { get; set; } = new Vec4(0f, 0f, 1f, 0f);    //Vector4
        public Color SurfaceColor { get; set; } = new Color(73, 168, 246, 255);      //Color
        public Color SurfaceShadows { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Color FallofColor { get; set; } = new Color(0, 136, 163, 255);      //Color
        public string Diffuse { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> GradientOffset { get; set; } = -100f;     //Float
        public Nullable<float> GradientLength { get; set; } = 1f;     //Float
        public Nullable<float> FresnelStrength { get; set; } = 3.07393f;     //Float
        public Nullable<float> DotsFresnelStrength { get; set; } = 0.544747f;     //Float
        public Nullable<float> GlowStrength { get; set; } = 0.252918f;     //Float
        public Nullable<float> DesaturationStrength { get; set; } = 0f;     //Float
        public Nullable<float> FlickerThreshold { get; set; } = 0f;     //Float
        public Nullable<float> FlickerChance { get; set; } = 0f;     //Float
        public Nullable<float> ArtifactsChance { get; set; } = 0f;     //Float
        public Nullable<float> LightBleed { get; set; } = 0.291498f;     //Float
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> ScreenSpaceFlicker { get; set; } = 0f;     //Float
        public Nullable<float> UseIsobars { get; set; } = 0f;     //Float
        public Nullable<float> EntropyThreshold { get; set; } = 0f;     //Float
        public Nullable<float> UseMovingDots { get; set; } = 0f;     //Float
        public Nullable<float> IsHair { get; set; } = 0f;     //Float
        public Nullable<float> ScanlineThickness { get; set; } = -0.578947f;     //Float
        public Nullable<float> Opacity { get; set; } = 1f;     //Float
        public Nullable<float> GlobalTint { get; set; } = 0f;     //Float
        public Nullable<float> SampledOrProceduralDots { get; set; } = 1f;     //Float
        public Nullable<float> FullColorOrGrayscale { get; set; } = 0f;     //Float
    }
    public partial class _hologram_two_sided
    {
        public Vec4 ScaleReferencePosAndScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> GlitchChance { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string Diffuse { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string Scanline { get; set; } = @"base\fx\_textures\masks\gradients\fx_reflected_vertical_gradient_03_alpha_d.xbm";    //rRef:ITexture
        public string DotsTexture { get; set; } = @"base\fx\_textures\quests\q105\fx_pointcloud_dot.xbm";    //rRef:ITexture
        public Vec4 Projector1Position { get; set; } = new Vec4(0f, 0f, 1f, 0f);    //Vector4
        public Nullable<float> OpaqueScanlineDensity { get; set; } = 400f;     //Float
        public Nullable<float> DotsSize { get; set; } = 100f;     //Float
        public Color DotsColor { get; set; } = new Color(73, 168, 246, 255);      //Color
        public Color SurfaceColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color SurfaceShadows { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Color FallofColor { get; set; } = new Color(0, 136, 163, 255);      //Color
        public Nullable<float> GradientOffset { get; set; } = -100f;     //Float
        public Nullable<float> GradientLength { get; set; } = 1f;     //Float
        public Nullable<float> FresnelStrength { get; set; } = 0.931174f;     //Float
        public Nullable<float> DotsFresnelStrength { get; set; } = 2.292683f;     //Float
        public Nullable<float> GlowStrength { get; set; } = 0.256637f;     //Float
        public Nullable<float> DesaturationStrength { get; set; } = 0f;     //Float
        public Nullable<float> FlickerThreshold { get; set; } = 0f;     //Float
        public Nullable<float> FlickerChance { get; set; } = 0f;     //Float
        public Nullable<float> ArtifactsChance { get; set; } = 0f;     //Float
        public Nullable<float> LightBleed { get; set; } = 0.3f;     //Float
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> ScreenSpaceFlicker { get; set; } = 0f;     //Float
        public Nullable<float> UseIsobars { get; set; } = 0f;     //Float
        public Nullable<float> EntropyThreshold { get; set; } = 0f;     //Float
        public Nullable<float> UseMovingDots { get; set; } = 0f;     //Float
        public Nullable<float> IsHair { get; set; } = 0f;     //Float
        public Nullable<float> ScanlineThickness { get; set; } = 0f;     //Float
        public Nullable<float> Opacity { get; set; } = 1f;     //Float
        public Nullable<float> GlobalTint { get; set; } = 0f;     //Float
        public Nullable<float> SampledOrProceduralDots { get; set; } = 0f;     //Float
        public Nullable<float> FullColorOrGrayscale { get; set; } = 0f;     //Float
    }
    public partial class _holo_projections
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> ColorMultiply { get; set; } = 2f;     //Float
        public Color EmissiveColor { get; set; } = new Color(236, 35, 69, 255);      //Color
        public Nullable<float> BrightnessNoiseStreght { get; set; } = 0f;     //Float
        public Nullable<float> SubUVWidth { get; set; } = 2f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 2f;     //Float
        public Nullable<float> FrameNum { get; set; } = 0f;     //Float
        public Nullable<float> PlaySpeed { get; set; } = 0f;     //Float
        public Nullable<float> InvertSoftAlpha { get; set; } = 0f;     //Float
        public Vec4 UVScrollSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> ScrollStepFactor { get; set; } = 10f;     //Float
        public Nullable<float> ScrollMaskOrTexture { get; set; } = 0f;     //Float
        public Nullable<float> RandomAnimation { get; set; } = 0f;     //Float
        public Nullable<float> RandomFrameFrequency { get; set; } = 4f;     //Float
        public Nullable<float> RandomFrameChangeSpeed { get; set; } = 25f;     //Float
        public Nullable<float> FrameNumDisplayChance { get; set; } = 0.8f;     //Float
        public string Diffuse { get; set; } = @"base\fx\_textures\quests\q110\q110_voodoo_projections_skull_glitched_2x2.xbm";    //rRef:ITexture
        public string ScrollingMaskTexture { get; set; } = @"engine\ink\textures\4x4_white.xbm";    //rRef:ITexture
    }
    public partial class _hud_focus_mode_scanline
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> Progress { get; set; } = 0f;     //Float
        public Nullable<float> vProgress { get; set; } = 0f;     //Float
        public Nullable<float> ScanlineDensity { get; set; } = 0f;     //Float
        public Nullable<float> ScanlineOffset { get; set; } = 0f;     //Float
        public Nullable<float> ScanlineWidth { get; set; } = 0f;     //Float
        public Nullable<float> EffectIntensity { get; set; } = 0f;     //Float
        public Nullable<float> ScanlineDensityVertical { get; set; } = 0f;     //Float
        public Nullable<float> ScanlineOffsetVertical { get; set; } = 0f;     //Float
        public Nullable<float> ScanlineWidthVertical { get; set; } = 0f;     //Float
        public Nullable<float> VerticalIntensity { get; set; } = 0f;     //Float
        public Nullable<float> BarsWidth { get; set; } = 0.12f;     //Float
        public Nullable<float> SideFadeWidth { get; set; } = 0.173554f;     //Float
        public Nullable<float> SideFadeFeather { get; set; } = 0f;     //Float
    }
    public partial class _hud_markers_notxaa
    {
        public string Diffuse { get; set; } = @"base\fx\textures\ui\fx_network_vis_solidline.xbm";    //rRef:ITexture
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color Color { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Color Second_Color { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Nullable<float> ColorMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> ClampOrWrap { get; set; } = 0f;     //Float
        public Nullable<float> TillingX { get; set; } = 1f;     //Float
        public Nullable<float> TillingY { get; set; } = 0f;     //Float
        public Nullable<float> OffsetX { get; set; } = 0f;     //Float
        public Nullable<float> OffsetY { get; set; } = 0f;     //Float
        public Nullable<float> WipeValue { get; set; } = 0f;     //Float
        public Nullable<float> RotateUV90Deg { get; set; } = 0f;     //Float
        public Nullable<float> SoftAlpha { get; set; } = 1f;     //Float
        public Nullable<float> InverseSoftAlphaValue { get; set; } = 1f;     //Float
        public Nullable<float> UseOnMeshes { get; set; } = 0f;     //Float
        public Nullable<float> UseWorldSpaceNoise { get; set; } = 0f;     //Float
        public string WorldSpaceNoise { get; set; } = @"base\fx\_textures\masks\noise\fx_organic_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> WorldSpaceNoiseTilling { get; set; } = 0f;     //Float
        public Nullable<float> NoiseSpeed { get; set; } = 0f;     //Float
        public Nullable<float> FresnelPower { get; set; } = 0f;     //Float
        public Nullable<float> FresnelContrast { get; set; } = 0f;     //Float
        public Nullable<float> SecondSoftAlpha { get; set; } = 0f;     //Float
    }
    public partial class _hud_markers_transparent
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\fx\textures\ui\fx_network_vis_solidline.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Color Second_Color { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Nullable<float> ColorMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> ClampOrWrap { get; set; } = 0f;     //Float
        public Nullable<float> TillingX { get; set; } = 1f;     //Float
        public Nullable<float> TillingY { get; set; } = 1f;     //Float
        public Nullable<float> OffsetX { get; set; } = 0f;     //Float
        public Nullable<float> OffsetY { get; set; } = 0f;     //Float
        public Nullable<float> RotateUV90Deg { get; set; } = 0f;     //Float
        public Nullable<float> WipeValue { get; set; } = 0f;     //Float
        public Nullable<float> SoftAlpha { get; set; } = 1f;     //Float
        public Nullable<float> InverseSoftAlphaValue { get; set; } = 1f;     //Float
        public Nullable<float> UseOnMeshes { get; set; } = 0f;     //Float
        public Nullable<float> UseWorldSpaceNoise { get; set; } = 0f;     //Float
        public string WorldSpaceNoise { get; set; } = @"base\fx\_textures\masks\noise\fx_organic_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> WorldSpaceNoiseTilling { get; set; } = 1f;     //Float
        public Nullable<float> NoiseSpeed { get; set; } = 0f;     //Float
        public Nullable<float> FresnelPower { get; set; } = 0f;     //Float
        public Nullable<float> FresnelContrast { get; set; } = 0f;     //Float
        public Nullable<float> SecondSoftAlpha { get; set; } = 0f;     //Float
    }
    public partial class _hud_markers_vision
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\fx\_textures\masks\gradients\fx_reflected_vertical_gradient_02_alpha_d.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(4, 255, 193, 255);      //Color
        public Color Second_Color { get; set; } = new Color(4, 255, 193, 255);      //Color
        public Nullable<float> ColorMultiplier { get; set; } = 3f;     //Float
        public Nullable<float> ClampOrWrap { get; set; } = 0f;     //Float
        public Nullable<float> TillingX { get; set; } = 1f;     //Float
        public Nullable<float> TillingY { get; set; } = 4f;     //Float
        public Nullable<float> OffsetX { get; set; } = 0f;     //Float
        public Nullable<float> OffsetY { get; set; } = 0f;     //Float
        public Nullable<float> RotateUV90Deg { get; set; } = 0f;     //Float
        public Nullable<float> WipeValue { get; set; } = 0.143646f;     //Float
        public Nullable<float> SoftAlpha { get; set; } = 1f;     //Float
        public Nullable<float> InverseSoftAlphaValue { get; set; } = 1f;     //Float
        public Nullable<float> UseOnMeshes { get; set; } = 0f;     //Float
        public Nullable<float> UseWorldSpaceNoise { get; set; } = 0f;     //Float
        public string WorldSpaceNoise { get; set; } = @"base\fx\_textures\masks\noise\fx_organic_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> WorldSpaceNoiseTilling { get; set; } = 0f;     //Float
        public Nullable<float> NoiseSpeed { get; set; } = 0f;     //Float
        public Nullable<float> FresnelPower { get; set; } = 0f;     //Float
        public Nullable<float> FresnelContrast { get; set; } = 0f;     //Float
        public Nullable<float> SecondSoftAlpha { get; set; } = 1f;     //Float
    }
    public partial class _hud_ui_dot
    {
        public string Diffuse { get; set; } = @"base\fx\_textures\masks\shapes\fx_nade_area.xbm";    //rRef:ITexture
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> TillingX { get; set; } = 1f;     //Float
        public Nullable<float> TillingY { get; set; } = 0f;     //Float
        public Nullable<float> OffsetX { get; set; } = 0f;     //Float
        public Nullable<float> OffsetY { get; set; } = 0f;     //Float
        public Color Color { get; set; } = new Color(4, 255, 193, 255);      //Color
        public Nullable<float> ColorMultiplier { get; set; } = 1f;     //Float
    }
    public partial class _hud_vision_pass
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\fx\textures\ui\trajectory_arrow.xbm";    //rRef:ITexture
        public Vec4 TextureTilingAndSpeed { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Color Color { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> ColorMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> AlphaMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> SoftTransparencyAmount { get; set; } = 1f;     //Float
        public Nullable<float> SoftContrast { get; set; } = 0f;     //Float
        public Nullable<float> UseVertexColor { get; set; } = 1f;     //Float
        public Nullable<float> Wipe { get; set; } = 0f;     //Float
        public Nullable<float> TestForDepth { get; set; } = 0f;     //Float
    }
    public partial class _johnny_effect
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(16, 117, 206, 255);      //Color
        public Nullable<float> Tilling { get; set; } = 0.7f;     //Float
        public Nullable<float> Contrast { get; set; } = 1f;     //Float
    }
    public partial class _johnny_glitch
    {
        public Nullable<float> Offset { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(137, 196, 255, 255);      //Color
        public Color BodyColor { get; set; } = new Color(12, 182, 255, 81);      //Color
        public Nullable<float> Tilling { get; set; } = 1.4f;     //Float
        public Nullable<float> Contrast { get; set; } = 1.5f;     //Float
        public Nullable<float> LineLength { get; set; } = -750f;     //Float
        public Nullable<float> MinDistance { get; set; } = -0.1f;     //Float
        public Nullable<float> MaxDistance { get; set; } = 1f;     //Float
        public Nullable<float> MaxSteps { get; set; } = 5f;     //Float
        public Nullable<float> NoiseSpeed { get; set; } = 10f;     //Float
        public Nullable<float> BackgroundOffset { get; set; } = 10f;     //Float
        public Nullable<float> BlurredIntensity { get; set; } = 1f;     //Float
        public Nullable<float> NoiseSize { get; set; } = 601.9416f;     //Float
        public Nullable<float> TileSizeX1 { get; set; } = 0.014342f;     //Float
        public Nullable<float> TileSizeY1 { get; set; } = 0.034356f;     //Float
        public Nullable<float> TileSizeX2 { get; set; } = 0.011007f;     //Float
        public Nullable<float> TileSizeY2 { get; set; } = 0.024349f;     //Float
        public Nullable<float> GlitchSpeed { get; set; } = 0.3f;     //Float
        public Nullable<float> UseHorizontal { get; set; } = 0f;     //Float
        public string VectorField { get; set; } = @"base\fx\textures\braindance\braindance_noise3d_03\braindance_noise3d_03.texarray";    //rRef:ITexture
    }
    public partial class _metal_base_atlas_animation
    {
        public Nullable<float> SubUVWidth { get; set; } = 2f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> LoopedAnimationSpeed { get; set; } = 10f;     //Float
        public string BaseColor { get; set; } = @"base\fx\_textures\animals\cockroach_2x1_anim_d.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(153, 153, 153, 255);      //Color
        public string Metalness { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"base\fx\_textures\animals\cockroach_2x1_anim_r.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0.2f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0.2f;     //Float
        public string Normal { get; set; } = @"base\fx\_textures\animals\cockroach_2x1_anim_n.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.03f;     //Float
    }
    public partial class _metal_base_blackbody
    {
        public string BaseColor { get; set; } = @"base\materials\placeholder\black.xbm";    //rRef:ITexture
        public string Metalness { get; set; } = @"base\weapons\melee\w_melee_001__katana\textures\w_melee_001__katana_blade_m01.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\weapons\melee\w_melee_001__katana\textures\w_melee_001__katana_blade_r01.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string EmissiveMask { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public string HeatDistribution { get; set; } = @"base\fx\_textures\masks\noise\fx_organic_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> MaskMinimum { get; set; } = 0.3f;     //Float
        public Nullable<float> HeatTilingX { get; set; } = 2f;     //Float
        public Nullable<float> HeatTilingY { get; set; } = 2f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 10f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public Nullable<float> MaxTemperature { get; set; } = 12.903225f;     //Float
        public Vec4 HSV_Mod { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> DebugTemperature { get; set; } = 1f;     //Float
        public Nullable<float> DebugOrExternalCurve { get; set; } = 0f;     //Float
        public Nullable<float> HeatMoveSpeed { get; set; } = 0f;     //Float
    }
    public partial class _metal_base_glitter
    {
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(229, 36, 36, 255);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> AlphaFromEmissive { get; set; } = 1f;     //Float
        public string EmissiveMask { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 6.209678f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public Color EmissiveColor { get; set; } = new Color(254, 116, 15, 255);      //Color
        public Nullable<float> HistogramRange { get; set; } = 0.491935f;     //Float
        public Nullable<float> ScrollSpeed { get; set; } = 0.21371f;     //Float
        public Nullable<float> EmissiveTile { get; set; } = 1f;     //Float
        public Nullable<float> Looped { get; set; } = 0f;     //Float
    }
    public partial class _neon_tubes
    {
        public Nullable<float> EmissiveEV { get; set; } = 6f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEdgeMult { get; set; } = 0f;     //Float
        public Color color { get; set; } = new Color(232, 100, 39, 255);      //Color
        public string tex1 { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> fresnelpower { get; set; } = 1f;     //Float
        public Nullable<float> UseBlinkingNoise { get; set; } = 0f;     //Float
        public Nullable<float> BlinkSpeed { get; set; } = 100f;     //Float
        public Nullable<float> MinNoiseValue { get; set; } = 0.1f;     //Float
        public Nullable<float> TimeSeed { get; set; } = 12345f;     //Float
        public Nullable<float> UseMatParamToCtrlNoise { get; set; } = 0f;     //Float
        public Nullable<float> TextureU { get; set; } = 1f;     //Float
        public Nullable<float> TextureV { get; set; } = 1f;     //Float
        public Nullable<float> TextureIntensity { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0.01f;     //Float
    }
    public partial class _noctovision_mode
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Vec4 NPC_HDRColor1 { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 NPC_HDRColor2 { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 Enemy_HDRColor1 { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 Enemy_HDRColor2 { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> Multiplier { get; set; } = 350f;     //Float
        public string Distortion { get; set; } = @"base\fx\_textures\masks\patterns\fx_random_dots_blurred_01_d.xbm";    //rRef:ITexture
        public Nullable<float> DistortionSpeed { get; set; } = 21f;     //Float
        public Nullable<float> DistortionOffset { get; set; } = 0.0005f;     //Float
        public Nullable<float> EnemyAlphaMultiplier { get; set; } = 0f;     //Float
        public Vec4 ScanlineValues { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> ScanlineContrast { get; set; } = 0f;     //Float
    }
    public partial class _parallaxscreen
    {
        public string ParalaxTexture { get; set; } = @"base\surfaces\textures\screens\generic\display_block_02.xbm";    //rRef:ITexture
        public string ScanlineTexture { get; set; } = @"base\fx\_textures\masks\gradients\fx_reflected_vertical_gradient_02_d.xbm";    //rRef:ITexture
        public Nullable<float> Metalness { get; set; } = 0.9f;     //Float
        public Nullable<float> Roughness { get; set; } = 0.1f;     //Float
        public Nullable<float> Emissive { get; set; } = 7f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> ImageScale { get; set; } = 1.05f;     //Float
        public Nullable<float> LayersSeparation { get; set; } = 0.1f;     //Float
        public Vec4 IntensityPerLayer { get; set; } = new Vec4(1f, 0.25f, 0.06f, 0f);    //Vector4
        public Nullable<float> ScanlinesDensity { get; set; } = 125f;     //Float
        public Nullable<float> ScanlinesIntensity { get; set; } = 0.25f;     //Float
        public Nullable<float> BlinkingSpeed { get; set; } = 0f;     //Float
        public string BlinkingMaskTexture { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public string ScrollMaskTexture { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public Nullable<float> ScrollVerticalOrHorizontal { get; set; } = 0f;     //Float
        public Nullable<float> ScrollMaskStartPoint1 { get; set; } = 0.02f;     //Float
        public Nullable<float> ScrollMaskHeight1 { get; set; } = 0.5f;     //Float
        public Nullable<float> ScrollSpeed1 { get; set; } = 0.25f;     //Float
        public Nullable<float> ScrollStepFactor1 { get; set; } = 30f;     //Float
        public Nullable<float> ScrollMaskStartPoint2 { get; set; } = 0.4f;     //Float
        public Nullable<float> ScrollMaskHeight2 { get; set; } = 0.2f;     //Float
        public Nullable<float> ScrollSpeed2 { get; set; } = 1.5f;     //Float
        public Nullable<float> ScrollStepFactor2 { get; set; } = 10f;     //Float
        public Color EmissiveColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Vec4 HSV_Mod { get; set; } = new Vec4(0f, 1f, 0f, -1f);    //Vector4
        public Nullable<float> IsBroken { get; set; } = 0f;     //Float
        public Nullable<float> FixForBlack { get; set; } = 1f;     //Float
    }
    public partial class _parallaxscreen_transparent
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string ParalaxTexture { get; set; } = @"base\fx\textures\other\elevator_l1.xbm";    //rRef:ITexture
        public Vec4 TexHSVControl { get; set; } = new Vec4(0f, 1f, 1f, 0f);    //Vector4
        public Color Color { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> Emissive { get; set; } = 1f;     //Float
        public Nullable<float> AdditiveOrAlphaBlened { get; set; } = 0f;     //Float
        public Vec4 ImageScale { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> TextureOffsetX { get; set; } = 0f;     //Float
        public Nullable<float> TextureOffsetY { get; set; } = 0f;     //Float
        public Nullable<float> TilesWidth { get; set; } = 1f;     //Float
        public Nullable<float> TilesHeight { get; set; } = 1f;     //Float
        public Nullable<float> PlaySpeed { get; set; } = 0f;     //Float
        public Nullable<float> InterlaceLines { get; set; } = 0f;     //Float
        public Nullable<float> SeparateLayersFromTexture { get; set; } = 0f;     //Float
        public Nullable<float> LayersSeparation { get; set; } = 0.02f;     //Float
        public Vec4 IntensityPerLayer { get; set; } = new Vec4(1f, 0.35f, 0.12f, 0.05f);    //Vector4
        public Nullable<float> ScanlinesDensity { get; set; } = 0f;     //Float
        public Nullable<float> ScanlinesIntensity { get; set; } = 0f;     //Float
        public Nullable<float> ScanlinesSpeed { get; set; } = 0f;     //Float
        public Nullable<float> NoPostORPost { get; set; } = 0f;     //Float
        public Nullable<float> EdgesMask { get; set; } = 0f;     //Float
        public Nullable<float> ClampUV { get; set; } = 1f;     //Float
        public string ScrollMaskTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> ScrollVerticalOrHorizontal { get; set; } = 1f;     //Float
        public Nullable<float> ScrollMaskStartPoint1 { get; set; } = 0f;     //Float
        public Nullable<float> ScrollMaskHeight1 { get; set; } = 0.25f;     //Float
        public Nullable<float> ScrollSpeed1 { get; set; } = 0.5f;     //Float
        public Nullable<float> ScrollStepFactor1 { get; set; } = 60f;     //Float
        public Nullable<float> ScrollMaskStartPoint2 { get; set; } = 0f;     //Float
        public Nullable<float> ScrollMaskHeight2 { get; set; } = 0.1f;     //Float
        public Nullable<float> ScrollSpeed2 { get; set; } = 1f;     //Float
        public Nullable<float> ScrollStepFactor2 { get; set; } = 60f;     //Float
        public Vec4 LayersScrollSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
    }
    public partial class _parallaxscreen_transparent_ui
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string ScanlineTexture { get; set; } = @"base\fx\_textures\masks\gradients\fx_reflected_vertical_gradient_01_d.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 6f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> ImageScale { get; set; } = 1.05f;     //Float
        public Nullable<float> LayersSeparation { get; set; } = 0.1f;     //Float
        public Vec4 IntensityPerLayer { get; set; } = new Vec4(1f, 0.1f, 0.075f, 0.05f);    //Vector4
        public Vec4 ScanlinesDensity { get; set; } = new Vec4(125f, 125f, 0f, 2f);    //Vector4
        public Nullable<float> IsBroken { get; set; } = 0f;     //Float
        public Nullable<float> ScanlinesIntensity { get; set; } = 1f;     //Float
        public string UIRenderTexture { get; set; } = @"engine\ink\textures\4x4_transparent.xbm";    //rRef:ITexture
        public Vec4 TexturePartUV { get; set; } = new Vec4(0f, 0f, 1f, 1f);    //Vector4
        public Nullable<float> FixToPbr { get; set; } = 0f;     //Float
        public Vec4 RenderTextureScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public Nullable<float> VerticalFlipEnabled { get; set; } = 0f;     //Float
        public Nullable<float> EdgeMask { get; set; } = 0f;     //Float
        public Color Tint { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> FixForVerticalSlide { get; set; } = 1f;     //Float
        public Nullable<float> AlphaAsOne { get; set; } = 0f;     //Float
        public Nullable<float> SaturationLift { get; set; } = 0f;     //Float
    }
    public partial class _parallax_bink
    {
        public Color ColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string VideoCanvasName { get; set; } = @"";     //CName
        public string BinkY { get; set; } = @"";    //rRef:ITexture
        public string BinkCR { get; set; } = @"";    //rRef:ITexture
        public string BinkCB { get; set; } = @"";    //rRef:ITexture
        public string BinkA { get; set; } = @"";    //rRef:ITexture
        public DataBuffer BinkParams { get; set; }
    }
    public partial class _particles_generic_expanded
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string Diffuse { get; set; } = @"base\fx\_textures\sparks\fx_sparks_oblong_01_2x2_d.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> ColorMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> SubUVWidth { get; set; } = 2f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 2f;     //Float
        public Nullable<float> SoftUVInterpolate { get; set; } = 0f;     //Float
        public Nullable<float> Desaturate { get; set; } = 0f;     //Float
        public Nullable<float> ColorPower { get; set; } = 1f;     //Float
        public Nullable<float> DistortAmount { get; set; } = 0f;     //Float
        public Vec4 TexCoordScale { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 TexCoordSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 TexCoordDtortScale { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 TexCoordDistortSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> AlphaGlobal { get; set; } = 1f;     //Float
        public Nullable<float> AlphaSoft { get; set; } = 0.5f;     //Float
        public Nullable<float> AlphaFresnelPower { get; set; } = 1f;     //Float
        public Nullable<float> UseAlphaFresnel { get; set; } = 0f;     //Float
        public Nullable<float> UseAlphaMask { get; set; } = 1f;     //Float
        public Nullable<float> UseOneChannel { get; set; } = 0f;     //Float
        public Nullable<float> UseContrastAlpha { get; set; } = 0f;     //Float
        public string AlphaMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Distortion { get; set; } = @"base\fx\_textures\masks\noise\fx_perlin_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> UseAlphaFresnelInverted { get; set; } = 0f;     //Float
        public Nullable<float> AlphaFresnelInvertedPower { get; set; } = 1f;     //Float
        public Nullable<float> AlphaDistortAmount { get; set; } = 1f;     //Float
        public Vec4 AlphaMaskDistortScale { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 AlphaMaskDistortSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> UseTimeOfDay { get; set; } = 0f;     //Float
    }
    public partial class _particles_hologram
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> UseMaterialParam { get; set; } = 0f;     //Float
        public Color ColorParam { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> DotsCoords { get; set; } = 50f;     //Float
        public Nullable<float> View_or_World { get; set; } = 1f;     //Float
        public Nullable<float> ColorMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> AlphaSoft { get; set; } = 0f;     //Float
        public Vec4 GlitchTexCoordSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public string Dots { get; set; } = @"base\fx\_textures\masks\shapes\fx_dot_01_d.xbm";    //rRef:ITexture
        public string AlphaMask { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string GlitchTex { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_01_d.xbm";    //rRef:ITexture
        public Vec4 AlphaTexCoordSpeed { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> AlphaSubUVWidth { get; set; } = 1f;     //Float
        public Nullable<float> AlphaSubUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> SoftUVInterpolate { get; set; } = 0f;     //Float
        public Nullable<float> AlphaGlobal { get; set; } = 1f;     //Float
        public Nullable<float> UseOnMesh { get; set; } = 0f;     //Float
    }
    public partial class _pointcloud_source_mesh
    {
        public Vec4 WorldPositionOffset { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
    }
    public partial class _postprocess
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> Gain { get; set; } = 1f;     //Float
        public Color ReColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> BlurredIntensity { get; set; } = 0f;     //Float
        public Nullable<float> MaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> ReColorStrength { get; set; } = 1f;     //Float
    }
    public partial class _postprocess_notxaa
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> Gain { get; set; } = 0f;     //Float
        public Color ReColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> BlurredIntensity { get; set; } = 0f;     //Float
        public Nullable<float> MaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> NumberOfIterations { get; set; } = 0f;     //Float
        public Nullable<float> UseMovingBlur { get; set; } = 0f;     //Float
        public Nullable<float> ReColorStrength { get; set; } = 1f;     //Float
    }
    public partial class _radial_blur
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string RedLinesMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string BlurMask { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> RedLinesDensity { get; set; } = 0f;     //Float
        public Color RedLine1 { get; set; } = new Color(83, 0, 0, 255);      //Color
        public Color RedLine2 { get; set; } = new Color(56, 29, 0, 255);      //Color
        public Color BluringBackgroundRecolor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> AberationAmount { get; set; } = 1500f;     //Float
        public Nullable<float> BlurAmount { get; set; } = 50f;     //Float
        public Nullable<float> LightupAmount { get; set; } = 12f;     //Float
        public Nullable<float> MixAmount { get; set; } = 1f;     //Float
        public Nullable<float> BlurOrAberration { get; set; } = 1f;     //Float
        public Nullable<float> ChromaticOffsetSpeed { get; set; } = 0f;     //Float
    }
    public partial class _reflex_buster
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> MaxDistortMulitiplier { get; set; } = 50f;     //Float
        public Nullable<float> MinDistortMulitiplier { get; set; } = 0.5f;     //Float
        public Nullable<float> ZoomMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> RelativeFStop { get; set; } = 0f;     //Float
        public Nullable<float> GlobalTint { get; set; } = 0f;     //Float
        public Nullable<float> Desaturate { get; set; } = 0f;     //Float
        public Color Color { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> UseAlphaOverEffect { get; set; } = 0f;     //Float
    }
    public partial class _refraction
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Vec4 TexCoordDtortScaleSpeed { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> DistortAmount { get; set; } = 500f;     //Float
        public string Alpha { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> UseVertexAlpha { get; set; } = 0f;     //Float
    }
    public partial class _sandevistan_trails
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string MainTexture { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public string MainAdditiveTexture { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public Nullable<float> MainColorMultiplier { get; set; } = 150f;     //Float
        public Color MainAdditiveColor { get; set; } = new Color(255, 0, 255, 255);      //Color
        public Nullable<float> MainAdditiveColorMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> SlowFactor { get; set; } = 0.15f;     //Float
        public Nullable<float> MainAdditiveAlphaTimingExponent { get; set; } = 1f;     //Float
        public Color MainColorStart { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Color MainColorEnd { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> HueSpread { get; set; } = 0f;     //Float
        public Nullable<float> MainBlackBodyMultiplier { get; set; } = 1f;     //Float
    }
    public partial class _screens
    {
        public Vec4 Tex1CoordMove { get; set; } = new Vec4(2f, 2f, 0f, 0f);    //Vector4
        public Vec4 Tex1Color { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Vec4 Tex2CoordMove { get; set; } = new Vec4(2f, 2f, -0.5f, -0.5f);    //Vector4
        public Vec4 Tex2Color { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Vec4 BackCoordMove { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 BackColor { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Nullable<float> Tex2AnimSpeed { get; set; } = 1f;     //Float
        public string background { get; set; } = @"base\fx\environment\screens\monitors\background_logo1.xbm";    //rRef:ITexture
        public string Tex1 { get; set; } = @"base\fx\environment\screens\monitors\footage2.xbm";    //rRef:ITexture
        public string Tex2 { get; set; } = @"base\fx\environment\screens\monitors\graphs1.xbm";    //rRef:ITexture
        public Vec4 Tex1UVSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> DotsCoords { get; set; } = 1000f;     //Float
        public Nullable<float> BackFlatOrCube { get; set; } = 0f;     //Float
        public string BackgroundCube { get; set; } = @"";     //rRef:ITexture
    }
    public partial class _screen_artifacts
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color Color { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> Complexity { get; set; } = 14f;     //Float
        public Nullable<float> Visiblity { get; set; } = 0.5f;     //Float
        public Nullable<float> Disturbance { get; set; } = 1.97f;     //Float
        public Nullable<float> Speed { get; set; } = 100f;     //Float
        public Nullable<float> RandomNumber { get; set; } = 1.1035153E+09f;     //Float
        public Nullable<float> UseBlackBackground { get; set; } = 0f;     //Float
        public Nullable<float> BraindanceArtifacts { get; set; } = 0f;     //Float
        public Nullable<float> TillingVertical { get; set; } = 1f;     //Float
        public Nullable<float> TillingHorizontal { get; set; } = 1f;     //Float
        public Nullable<float> BendScreen { get; set; } = 0f;     //Float
        public Nullable<float> AlphaClip { get; set; } = 0f;     //Float
    }
    public partial class _screen_artifacts_vision
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color Color { get; set; } = new Color(94, 111, 255, 255);      //Color
        public Nullable<float> Complexity { get; set; } = 7f;     //Float
        public Nullable<float> Visiblity { get; set; } = 1f;     //Float
        public Nullable<float> Disturbance { get; set; } = 5f;     //Float
        public Nullable<float> Speed { get; set; } = 10f;     //Float
        public Nullable<float> RandomNumber { get; set; } = 1.1035153E+09f;     //Float
        public Nullable<float> UseBlackBackground { get; set; } = 0f;     //Float
        public Nullable<float> BraindanceArtifacts { get; set; } = 1f;     //Float
        public Nullable<float> TillingVertical { get; set; } = 1f;     //Float
        public Nullable<float> TillingHorizontal { get; set; } = 1f;     //Float
        public Nullable<float> BendScreen { get; set; } = 0f;     //Float
        public Nullable<float> AlphaClip { get; set; } = 0f;     //Float
    }
    public partial class _screen_black
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color Color { get; set; } = new Color(0, 0, 0, 255);      //Color
    }
    public partial class _screen_fast_travel_glitch
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color Color { get; set; } = new Color(0, 254, 255, 255);      //Color
        public Nullable<float> SingelColor { get; set; } = 0f;     //Float
        public Nullable<float> ColorMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> Complexity { get; set; } = 14f;     //Float
        public Nullable<float> Density { get; set; } = 0.2f;     //Float
        public Nullable<float> Disturbance { get; set; } = 0.2f;     //Float
        public Nullable<float> Speed { get; set; } = 0.2f;     //Float
        public Nullable<float> TillingVertical { get; set; } = 0f;     //Float
        public Nullable<float> TillingHorizontal { get; set; } = 0f;     //Float
        public Nullable<float> BendScreen { get; set; } = 0f;     //Float
        public Nullable<float> Vertical { get; set; } = 0f;     //Float
    }
    public partial class _screen_glitch
    {
        public Nullable<float> Offset { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color GridColor { get; set; } = new Color(0, 2, 32, 255);      //Color
        public Nullable<float> BlurredIntensity { get; set; } = 1f;     //Float
        public Nullable<float> NoiseSize { get; set; } = 1f;     //Float
        public Nullable<float> TileSizeX1 { get; set; } = 0.146652f;     //Float
        public Nullable<float> TileSizeY1 { get; set; } = 0f;     //Float
        public Nullable<float> TileSizeX2 { get; set; } = 0.2f;     //Float
        public Nullable<float> TileSizeY2 { get; set; } = 0f;     //Float
        public Nullable<float> GlitchSpeed { get; set; } = 0f;     //Float
        public Nullable<float> GlitchSpeedOffset { get; set; } = 0f;     //Float
        public Nullable<float> GlitchModTime { get; set; } = 100f;     //Float
        public Nullable<float> GlitchDepth { get; set; } = 0f;     //Float
        public Nullable<float> UseSquareMask { get; set; } = 0f;     //Float
        public Nullable<float> UseScreenSpaceMask { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 1f;     //Float
        public Color ArtifactColor { get; set; } = new Color(5, 48, 215, 255);      //Color
        public Nullable<float> ArtifactIntensity { get; set; } = 0f;     //Float
        public Nullable<float> ArtifactNarrowness { get; set; } = 5f;     //Float
        public Nullable<float> ArtifactMinimizer { get; set; } = 15f;     //Float
        public Nullable<float> ArtifactSpeed { get; set; } = 2f;     //Float
        public Nullable<float> ArtifactTimeOffset { get; set; } = 0f;     //Float
        public Nullable<float> SmallArtifactsTileX { get; set; } = 0.08f;     //Float
        public Nullable<float> SmallArtifactsTileY { get; set; } = 0.5f;     //Float
        public Nullable<float> UseStencilMask { get; set; } = 0f;     //Float
        public Nullable<float> UseSmallArtifacts { get; set; } = 0f;     //Float
        public Nullable<float> UseBothSideBlur { get; set; } = 0f;     //Float
        public Nullable<float> UseHorizontal { get; set; } = 0f;     //Float
        public Nullable<float> UseAlphaOverEntireEffect { get; set; } = 0f;     //Float
        public Nullable<float> ErrorIntensity { get; set; } = 0f;     //Float
        public Nullable<float> InvertBrightnessMask { get; set; } = 0f;     //Float
        public string DotTex { get; set; } = @"base\fx\_textures\masks\shapes\fx_dot_01_d.xbm";    //rRef:ITexture
    }
    public partial class _screen_glitch_notxaa
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color GridColor { get; set; } = new Color(0, 2, 32, 255);      //Color
        public Nullable<float> BlurredIntensity { get; set; } = 1f;     //Float
        public Nullable<float> NoiseSize { get; set; } = 1f;     //Float
        public Nullable<float> TileSizeX1 { get; set; } = 0.15f;     //Float
        public Nullable<float> TileSizeY1 { get; set; } = 0f;     //Float
        public Nullable<float> TileSizeX2 { get; set; } = 0.2f;     //Float
        public Nullable<float> TileSizeY2 { get; set; } = 0f;     //Float
        public Nullable<float> GlitchSpeed { get; set; } = 0f;     //Float
        public Nullable<float> GlitchSpeedOffset { get; set; } = 0f;     //Float
        public Nullable<float> GlitchModTime { get; set; } = 100f;     //Float
        public Nullable<float> GlitchDepth { get; set; } = 0f;     //Float
        public Nullable<float> UseSquareMask { get; set; } = 0f;     //Float
        public Nullable<float> UseScreenSpaceMask { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 1f;     //Float
        public Color ArtifactColor { get; set; } = new Color(5, 48, 215, 255);      //Color
        public Nullable<float> ArtifactIntensity { get; set; } = 0f;     //Float
        public Nullable<float> ArtifactNarrowness { get; set; } = 5f;     //Float
        public Nullable<float> ArtifactMinimizer { get; set; } = 15f;     //Float
        public Nullable<float> ArtifactSpeed { get; set; } = 2f;     //Float
        public Nullable<float> ArtifactTimeOffset { get; set; } = 0f;     //Float
        public Nullable<float> SmallArtifactsTileX { get; set; } = 0.08f;     //Float
        public Nullable<float> SmallArtifactsTileY { get; set; } = 0.5f;     //Float
        public Nullable<float> UseStencilMask { get; set; } = 0f;     //Float
        public Nullable<float> UseSmallArtifacts { get; set; } = 0f;     //Float
        public Nullable<float> UseBothSideBlur { get; set; } = 0f;     //Float
        public Nullable<float> UseHorizontal { get; set; } = 0f;     //Float
        public Nullable<float> UseAlphaOverEntireEffect { get; set; } = 0f;     //Float
        public Nullable<float> ErrorIntensity { get; set; } = 0f;     //Float
        public Nullable<float> InvertBrightnessMask { get; set; } = 0f;     //Float
        public string ErrorTex { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_01_d.xbm";    //rRef:ITexture
        public string DotTex { get; set; } = @"base\fx\_textures\masks\shapes\fx_dot_01_d.xbm";    //rRef:ITexture
    }
    public partial class _screen_glitch_vision
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Color GridColor { get; set; } = new Color(0, 2, 32, 255);      //Color
        public Nullable<float> BlurredIntensity { get; set; } = 1f;     //Float
        public Nullable<float> NoiseSize { get; set; } = 1f;     //Float
        public Nullable<float> TileSizeX1 { get; set; } = 0.15f;     //Float
        public Nullable<float> TileSizeY1 { get; set; } = 0f;     //Float
        public Nullable<float> TileSizeX2 { get; set; } = 0.2f;     //Float
        public Nullable<float> TileSizeY2 { get; set; } = 0f;     //Float
        public Nullable<float> GlitchSpeed { get; set; } = 0f;     //Float
        public Nullable<float> GlitchSpeedOffset { get; set; } = 0f;     //Float
        public Nullable<float> GlitchModTime { get; set; } = 100f;     //Float
        public Nullable<float> GlitchDepth { get; set; } = 0f;     //Float
        public Nullable<float> UseSquareMask { get; set; } = 0f;     //Float
        public Nullable<float> UseScreenSpaceMask { get; set; } = 0f;     //Float
        public Nullable<float> AlphaMaskContrast { get; set; } = 1f;     //Float
        public Color ArtifactColor { get; set; } = new Color(5, 48, 215, 255);      //Color
        public Nullable<float> ArtifactIntensity { get; set; } = 0f;     //Float
        public Nullable<float> ArtifactNarrowness { get; set; } = 5f;     //Float
        public Nullable<float> ArtifactMinimizer { get; set; } = 15f;     //Float
        public Nullable<float> ArtifactSpeed { get; set; } = 2f;     //Float
        public Nullable<float> ArtifactTimeOffset { get; set; } = 0f;     //Float
        public Nullable<float> SmallArtifactsTileX { get; set; } = 0.08f;     //Float
        public Nullable<float> SmallArtifactsTileY { get; set; } = 0.5f;     //Float
        public Nullable<float> UseStencilMask { get; set; } = 0f;     //Float
        public Nullable<float> UseSmallArtifacts { get; set; } = 0f;     //Float
        public Nullable<float> UseBothSideBlur { get; set; } = 0f;     //Float
        public Nullable<float> UseHorizontal { get; set; } = 0f;     //Float
        public Nullable<float> UseAlphaOverEntireEffect { get; set; } = 0f;     //Float
        public Nullable<float> ErrorIntensity { get; set; } = 0f;     //Float
        public Nullable<float> InvertBrightnessMask { get; set; } = 0f;     //Float
        public string ErrorTex { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_01_d.xbm";    //rRef:ITexture
        public string DotTex { get; set; } = @"base\fx\_textures\masks\shapes\fx_dot_01_d.xbm";    //rRef:ITexture
    }
    public partial class _signages
    {
        public string MainTexture { get; set; } = @"base\fx\textures\other\plazma_mask.xbm";    //rRef:ITexture
        public Nullable<float> UseRoughnessTexture { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
        public Nullable<float> Roughness { get; set; } = 0.151951f;     //Float
        public Vec4 RoughnessTilingAndOffset { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> EmissiveEV { get; set; } = 8.103615f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> UniformColor { get; set; } = 0f;     //Float
        public Nullable<float> UseVertexColorOrMap { get; set; } = 1f;     //Float
        public Color ColorOneStart { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Color ColorOneEnd { get; set; } = new Color(255, 135, 135, 255);      //Color
        public Nullable<float> ColorGradientScale { get; set; } = 1f;     //Float
        public Nullable<float> HorizontalOrVerticalGradient { get; set; } = 0f;     //Float
        public Nullable<float> GradientStartPosition { get; set; } = 0f;     //Float
        public Color ColorTwo { get; set; } = new Color(8, 255, 237, 255);      //Color
        public Color ColorThree { get; set; } = new Color(57, 170, 86, 255);      //Color
        public Color ColorFour { get; set; } = new Color(0, 145, 226, 255);      //Color
        public Color ColorFive { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Color ColorSix { get; set; } = new Color(92, 0, 122, 255);      //Color
        public string NoiseTexture { get; set; } = @"base\fx\_textures\masks\noise\fx_organic_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> LightupDensity { get; set; } = 0f;     //Float
        public Nullable<float> LightupMinimumValue { get; set; } = 0.5f;     //Float
        public Nullable<float> LightupHorizontalOrVertical { get; set; } = 0f;     //Float
        public Nullable<float> BlinkingSpeed { get; set; } = 0f;     //Float
        public Nullable<float> BlinkingMinimumValue { get; set; } = 0f;     //Float
        public Nullable<float> BlinkingPhase { get; set; } = 0f;     //Float
        public Nullable<float> BlinkSmoothness { get; set; } = 1f;     //Float
        public Nullable<float> FresnelAmount { get; set; } = 0f;     //Float
    }
    public partial class _signages_transparent_no_txaa
    {
        public string MainTexture { get; set; } = @"base\fx\textures\other\plazma_mask.xbm";    //rRef:ITexture
        public Nullable<float> UseRoughnessTexture { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
        public Nullable<float> Roughness { get; set; } = 0.151951f;     //Float
        public Vec4 RoughnessTilingAndOffset { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> EmissiveEV { get; set; } = 8.103615f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> UniformColor { get; set; } = 0f;     //Float
        public Nullable<float> UseVertexColorOrMap { get; set; } = 1f;     //Float
        public Color ColorOneStart { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Color ColorOneEnd { get; set; } = new Color(255, 135, 135, 255);      //Color
        public Nullable<float> ColorGradientScale { get; set; } = 1f;     //Float
        public Nullable<float> HorizontalOrVerticalGradient { get; set; } = 0f;     //Float
        public Nullable<float> GradientStartPosition { get; set; } = 0f;     //Float
        public Color ColorTwo { get; set; } = new Color(8, 255, 237, 255);      //Color
        public Color ColorThree { get; set; } = new Color(57, 170, 86, 255);      //Color
        public Color ColorFour { get; set; } = new Color(0, 145, 226, 255);      //Color
        public Color ColorFive { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Color ColorSix { get; set; } = new Color(92, 0, 122, 255);      //Color
        public string NoiseTexture { get; set; } = @"base\fx\_textures\masks\noise\fx_organic_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> LightupDensity { get; set; } = 0f;     //Float
        public Nullable<float> LightupMinimumValue { get; set; } = 0.5f;     //Float
        public Nullable<float> LightupHorizontalOrVertical { get; set; } = 0f;     //Float
        public Nullable<float> BlinkingSpeed { get; set; } = 0f;     //Float
        public Nullable<float> BlinkingMinimumValue { get; set; } = 0f;     //Float
        public Nullable<float> BlinkingPhase { get; set; } = 0f;     //Float
        public Nullable<float> BlinkSmoothness { get; set; } = 1f;     //Float
        public Nullable<float> FresnelAmount { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
    }
    public partial class _silverhand_proxy
    {
        public string Color { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 1f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 0f;     //Float
        public Nullable<float> BayerScale { get; set; } = 2f;     //Float
        public Nullable<float> BayerIntensity { get; set; } = 0.5f;     //Float
        public Nullable<float> FresnelExponent { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 1f;     //Float
    }
    public partial class _simple_additive_ui
    {
        public string UIRenderTexture { get; set; } = @"engine\textures\editor\debug.xbm";    //rRef:ITexture
        public Vec4 UvTilingAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 DirtTilingAndOffset { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 TexturePartUV { get; set; } = new Vec4(0f, 0f, 1f, 1f);    //Vector4
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> PremultiplyByAlpha { get; set; } = 0f;     //Float
        public Color EmissiveColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> Saturation { get; set; } = 1f;     //Float
        public string DirtTexture { get; set; } = @"engine\textures\editor\checker_d.xbm";    //rRef:ITexture
        public Nullable<float> DirtOpacity { get; set; } = 0f;     //Float
        public Color DirtColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
    }
    public partial class _simple_emissive_decals
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> ColorMultiply { get; set; } = 1f;     //Float
        public Color EmissiveColor { get; set; } = new Color(218, 141, 84, 255);      //Color
        public Nullable<float> SubUVWidth { get; set; } = 1f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> FrameNum { get; set; } = 0f;     //Float
        public Nullable<float> InvertSoftAlpha { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\fx\_textures\masks\gradients\fx_radial_gradient_01_alpha_d.xbm";    //rRef:ITexture
    }
    public partial class _simple_fresnel
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string Diffuse { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color FresnelColor { get; set; } = new Color(255, 114, 0, 255);      //Color
        public Nullable<float> FresnelPower { get; set; } = 2f;     //Float
    }
    public partial class _simple_refraction
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> RefractionStrength { get; set; } = 50f;     //Float
        public string Refraction { get; set; } = @"base\fx\_textures\weapons\trails\fx_trails_refraction_01_d.xbm";    //rRef:ITexture
        public Nullable<float> UseDepth { get; set; } = 0f;     //Float
        public Vec4 RefractionTextureOffset { get; set; } = new Vec4(0.75f, 0.75f, 0f, 0f);    //Vector4
        public Vec4 RefractionTextureSpeed { get; set; } = new Vec4(-0.025f, -0.01f, 0f, 0f);    //Vector4
        public Nullable<float> SlowFactor { get; set; } = 1f;     //Float
        public Nullable<float> RefractionStrengthSlowTime { get; set; } = 800f;     //Float
    }
    public partial class _sound_clue
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string Diffuse { get; set; } = @"base\fx\_textures\masks\shapes\fx_circle_01_d.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(80, 167, 255, 102);      //Color
        public Nullable<float> ColorMultiplier { get; set; } = 1f;     //Float
    }
    public partial class _television_ad
    {
        public Nullable<float> TilesWidth { get; set; } = 8f;     //Float
        public Nullable<float> TilesHeight { get; set; } = 4f;     //Float
        public Nullable<float> PlaySpeed { get; set; } = 10f;     //Float
        public Nullable<float> InterlaceLines { get; set; } = 1f;     //Float
        public Nullable<float> PixelsHeight { get; set; } = 512f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 6f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Nullable<float> BlackLinesRatio { get; set; } = 8f;     //Float
        public Nullable<float> BlackLinesIntensity { get; set; } = 0.886957f;     //Float
        public string AdTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> BlackLinesSize { get; set; } = 16f;     //Float
        public Nullable<float> LinesOrDots { get; set; } = 0f;     //Float
        public Nullable<float> DistanceDivision { get; set; } = 20f;     //Float
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
        public Nullable<float> Roughness { get; set; } = 0f;     //Float
        public Nullable<float> IsBroken { get; set; } = 0f;     //Float
        public Nullable<float> UseFloatParameter { get; set; } = 0f;     //Float
        public Nullable<float> UseFloatParameter1 { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public string DirtTexture { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> DirtOpacityScale { get; set; } = 0f;     //Float
        public Nullable<float> DirtRoughness { get; set; } = 0f;     //Float
        public Nullable<float> DirtUvScaleU { get; set; } = 1f;     //Float
        public Nullable<float> DirtUvScaleV { get; set; } = 1f;     //Float
        public Nullable<float> HUEChangeSpeed { get; set; } = 0f;     //Float
    }
    public partial class _triplanar_projection
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\surfaces\textures\test_checker.xbm";    //rRef:ITexture
        public Nullable<float> FirstValue { get; set; } = 0f;     //Float
        public Nullable<float> SecondValue { get; set; } = 0f;     //Float
        public Nullable<float> ThirdValue { get; set; } = 0f;     //Float
        public Color Color { get; set; } = new Color(255, 0, 47, 255);      //Color
        public Nullable<float> Stretch { get; set; } = 0.87963f;     //Float
        public Nullable<float> ColorMultiplier { get; set; } = 3f;     //Float
    }
    public partial class _water_plane
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Color TintColor { get; set; } = new Color(207, 219, 219, 255);      //Color
        public Color TintColorDeep { get; set; } = new Color(63, 80, 118, 255);      //Color
        public Vec4 TexCoordDtortScaleSpeed { get; set; } = new Vec4(2f, 2f, 0.05f, 0f);    //Vector4
        public Nullable<float> DistortAmount { get; set; } = 50f;     //Float
        public Nullable<float> IOR { get; set; } = 1.2f;     //Float
        public Nullable<float> ReflectionPower { get; set; } = 5f;     //Float
        public Vec4 ReflectNormalMultiplier { get; set; } = new Vec4(0.01f, 0.01f, 1f, 0f);    //Vector4
        public string Normal { get; set; } = @"base\fx\textures\liquids\wave_med_n.xbm";    //rRef:ITexture
        public string Alpha { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
    }
    public partial class _zoom
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> Progress { get; set; } = 1f;     //Float
        public Color OutlineColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> OutlineThickness { get; set; } = 0.5f;     //Float
        public Nullable<float> MinRange { get; set; } = 2f;     //Float
        public Nullable<float> MaxRange { get; set; } = 4f;     //Float
        public Nullable<float> MotionIntensity { get; set; } = 80f;     //Float
        public Nullable<float> TransitionOrLoop { get; set; } = 0f;     //Float
        public Nullable<float> IsBackwardEffect { get; set; } = 0f;     //Float
        public Nullable<float> UseBrokenSobelPixels { get; set; } = 0f;     //Float
    }
    public partial class _alt_halo
    {
        public Nullable<float> Offset { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Noise { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_01_d.xbm";    //rRef:ITexture
        public string DistanceNoise { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_3d_01_d.xbm";    //rRef:ITexture
        public Nullable<float> DistanceNoiseScale { get; set; } = 1.5f;     //Float
        public string Dot { get; set; } = @"base\fx\_textures\masks\shapes\fx_dot_01_d.xbm";    //rRef:ITexture
        public Nullable<float> DotsLift { get; set; } = 0.3f;     //Float
        public Nullable<float> DistPower { get; set; } = 2f;     //Float
        public Nullable<float> NoiseScale { get; set; } = 1.5f;     //Float
        public Nullable<float> NoiseSpeed { get; set; } = 0.03f;     //Float
        public Nullable<float> DistanceNoiseAmount { get; set; } = 0f;     //Float
        public Nullable<float> DotsMax { get; set; } = 5f;     //Float
        public Color Color { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Nullable<float> WorldOrLocalSpace { get; set; } = 0f;     //Float
        public Nullable<float> DotsScale { get; set; } = 1250f;     //Float
        public Nullable<float> LocalSpaceRatio { get; set; } = 0.65f;     //Float
        public Nullable<float> FadeOutDistance { get; set; } = 0f;     //Float
        public Nullable<float> FadeOutDistanceMinimum { get; set; } = 0f;     //Float
        public Nullable<float> UVOrScreenSpace { get; set; } = 0f;     //Float
    }
    public partial class _blackbodyradiation_distant
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> Temperature { get; set; } = 30.09901f;     //Float
        public string FireScatterAlpha { get; set; } = @"base\fx\_textures\fire\fx_explosion_big_v001_8x8_d.xbm";    //rRef:ITexture
        public Nullable<float> subUVWidth { get; set; } = 1f;     //Float
        public Nullable<float> subUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> MultiplierExponent { get; set; } = 1f;     //Float
        public Nullable<float> NoAlphaOnTexture { get; set; } = 0f;     //Float
        public Nullable<float> AlphaExponent { get; set; } = 1f;     //Float
        public Nullable<float> maxAlpha { get; set; } = 1f;     //Float
        public Nullable<float> EatUpOrStraightAlpha { get; set; } = 1f;     //Float
        public Nullable<float> ScatterAmount { get; set; } = 0f;     //Float
        public Nullable<float> ScatterPower { get; set; } = 0.730769f;     //Float
        public Nullable<float> HueShift { get; set; } = 1f;     //Float
        public Nullable<float> HueSpread { get; set; } = 1f;     //Float
        public Nullable<float> Saturation { get; set; } = 0f;     //Float
        public Nullable<float> ExpensiveBlending { get; set; } = 1f;     //Float
        public Color LightSmoke { get; set; } = new Color(117, 117, 117, 255);      //Color
        public Color DarkSmoke { get; set; } = new Color(75, 75, 75, 255);      //Color
        public Nullable<float> SoftAlpha { get; set; } = 0f;     //Float
        public string Distort { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public Vec4 TexCoordDtortScale { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Vec4 TexCoordDtortSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> DistortAmount { get; set; } = 0f;     //Float
        public Nullable<float> EnableRowAnimation { get; set; } = 0f;     //Float
        public Nullable<float> DoNotApplyLighting { get; set; } = 0f;     //Float
        public string MaskTexture { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> InvertMask { get; set; } = 0f;     //Float
        public Vec4 MaskTilingAndSpeed { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> MaskIntensity { get; set; } = 1f;     //Float
        public Nullable<float> UseVertexAlpha { get; set; } = 0f;     //Float
        public Nullable<float> DotWithLookAt { get; set; } = 0f;     //Float
    }
    public partial class _blackbodyradiation_notxaa
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> Temperature { get; set; } = 39.919357f;     //Float
        public string FireScatterAlpha { get; set; } = @"base\fx\_textures\fire\fx_explosion_big_v001_8x8_d.xbm";    //rRef:ITexture
        public Nullable<float> subUVWidth { get; set; } = 1f;     //Float
        public Nullable<float> subUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> MultiplierExponent { get; set; } = 0.150847f;     //Float
        public Nullable<float> NoAlphaOnTexture { get; set; } = 0f;     //Float
        public Nullable<float> AlphaExponent { get; set; } = 0.955685f;     //Float
        public Nullable<float> maxAlpha { get; set; } = 1f;     //Float
        public Nullable<float> EatUpOrStraightAlpha { get; set; } = 1f;     //Float
        public Nullable<float> ScatterAmount { get; set; } = 0f;     //Float
        public Nullable<float> ScatterPower { get; set; } = 0.730769f;     //Float
        public Nullable<float> HueShift { get; set; } = 1f;     //Float
        public Nullable<float> HueSpread { get; set; } = 1f;     //Float
        public Nullable<float> Saturation { get; set; } = 0f;     //Float
        public Nullable<float> ExpensiveBlending { get; set; } = 1f;     //Float
        public Color LightSmoke { get; set; } = new Color(117, 117, 117, 255);      //Color
        public Color DarkSmoke { get; set; } = new Color(75, 75, 75, 255);      //Color
        public Nullable<float> SoftAlpha { get; set; } = 0f;     //Float
        public string Distort { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public Vec4 TexCoordDtortScale { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Vec4 TexCoordDtortSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> DistortAmount { get; set; } = 0f;     //Float
        public Nullable<float> EnableRowAnimation { get; set; } = 0f;     //Float
        public Nullable<float> DoNotApplyLighting { get; set; } = 0f;     //Float
        public string MaskTexture { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> InvertMask { get; set; } = 0f;     //Float
        public Vec4 MaskTilingAndSpeed { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> MaskIntensity { get; set; } = 1f;     //Float
        public Nullable<float> UseVertexAlpha { get; set; } = 0f;     //Float
        public Nullable<float> DotWithLookAt { get; set; } = 0f;     //Float
    }
    public partial class _blood_metal_base
    {
        public Color ColorThin { get; set; } = new Color(89, 4, 4, 255);      //Color
        public Color ColorThick { get; set; } = new Color(48, 0, 0, 255);      //Color
        public string NormalAndDensity { get; set; } = @"base\fx\textures\blood\blood_radial_v001_normal.xbm";    //rRef:ITexture
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
        public Nullable<float> Roughness { get; set; } = 0.255388f;     //Float
        public Nullable<float> SubUVWidth { get; set; } = 1f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> UseTimeFlowmap { get; set; } = 0f;     //Float
        public Nullable<float> FlowMapSpeed { get; set; } = 0.3f;     //Float
        public string VelocityMap { get; set; } = @"base\fx\textures\blood\blood_radial_v001_velocity.xbm";    //rRef:ITexture
        public Nullable<float> FlowmapStrength { get; set; } = 0.05f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.044728f;     //Float
        public Nullable<float> UseOnStaticMeshes { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0.5f;     //Float
    }
    public partial class _caustics
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string Distortion { get; set; } = @"base\fx\_textures\masks\distortions\fx_noisenormal_03_n.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(152, 223, 255, 255);      //Color
        public Nullable<float> Contrast { get; set; } = 4f;     //Float
        public Nullable<float> Speed { get; set; } = 5f;     //Float
        public Nullable<float> SmallMovementSpeed { get; set; } = 1f;     //Float
        public Nullable<float> Multiplier { get; set; } = 120f;     //Float
        public Nullable<float> Spread { get; set; } = 17f;     //Float
        public Nullable<float> DistortionAmount { get; set; } = 0f;     //Float
        public Nullable<float> DistortionUVScaling { get; set; } = 1f;     //Float
        public Nullable<float> UVScaling { get; set; } = 7f;     //Float
        public Nullable<float> EdgeWidth { get; set; } = 10f;     //Float
        public Nullable<float> EdgeMultiplier { get; set; } = 5f;     //Float
        public Nullable<float> MaxValue { get; set; } = 1.2f;     //Float
    }
    public partial class _character_kerenzikov
    {
        public Nullable<float> VertexOffset { get; set; } = 0.35f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\fx\_textures\masks\gradients\fx_radial_gradient_01_inverted_d.xbm";    //rRef:ITexture
        public Vec4 CenterPoint { get; set; } = new Vec4(0.65f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> PixelOffset { get; set; } = 10f;     //Float
        public Nullable<float> ComebackPixelOffset { get; set; } = 10f;     //Float
        public Nullable<float> NoiseAmount { get; set; } = 45f;     //Float
        public Nullable<float> Debug { get; set; } = 0f;     //Float
    }
    public partial class _character_sandevistan
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> Iterations { get; set; } = 9f;     //Float
        public Nullable<float> OffsetStrength { get; set; } = 27f;     //Float
        public Nullable<float> InsideSoftAlpha { get; set; } = 0.883002f;     //Float
        public Nullable<float> TopDisplacePower { get; set; } = 1f;     //Float
        public Nullable<float> TopDisplaceIntensity { get; set; } = 1f;     //Float
    }
    public partial class _crystal_dome
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Nullable<float> ScanlineDensity { get; set; } = 140.10397f;     //Float
        public Nullable<float> GainMin { get; set; } = 0.015f;     //Float
        public Nullable<float> GainMax { get; set; } = 0.15f;     //Float
        public Nullable<float> NoiseMax { get; set; } = 0f;     //Float
        public Nullable<float> NoiseBrightness { get; set; } = 150f;     //Float
        public Nullable<float> IntialGradientTime { get; set; } = 0.1f;     //Float
    }
    public partial class _crystal_dome_opaque
    {
        public string BaseColor { get; set; } = @"base\surfaces\materials\metal\steel_galvanized\steel_galvanized_01_300_d.xbm";    //rRef:ITexture
        public Color PrimaryGlowColor { get; set; } = new Color(0, 159, 255, 255);      //Color
        public Color SecondaryGlowColor { get; set; } = new Color(193, 140, 0, 255);      //Color
        public string Metalness { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string Roughness { get; set; } = @"base\surfaces\materials\metal\steel_galvanized\steel_galvanized_01_300_r.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"base\surfaces\materials\metal\metal_generic\metal_generic_hard_01_300_n.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 10f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Vec4 Tiling { get; set; } = new Vec4(5f, 5f, 10f, 10f);    //Vector4
        public Nullable<float> InitialTime { get; set; } = 0.495652f;     //Float
        public Nullable<float> MaxTimeOffset { get; set; } = 0.326087f;     //Float
        public Nullable<float> SwipeAngle { get; set; } = 0f;     //Float
        public string FluffMask { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string PatternMask { get; set; } = @"base\fx\_textures\vehicles\fx_crystal_dome_mask.xbm";    //rRef:ITexture
        public Nullable<float> UVDivision { get; set; } = 500f;     //Float
        public Nullable<float> NoiseMax { get; set; } = 0f;     //Float
        public Nullable<float> DebugValue { get; set; } = 0f;     //Float
        public Nullable<float> Debug { get; set; } = 0f;     //Float
        public Nullable<float> UVDivision_FluffMask { get; set; } = 1f;     //Float
        public Nullable<float> MinUV { get; set; } = 0f;     //Float
        public Nullable<float> MaxUV { get; set; } = 1f;     //Float
        public string DistortionMap { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> DistortionScale { get; set; } = 2f;     //Float
    }
    public partial class _cyberspace_gradient
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> InitialGradientTiling { get; set; } = 30f;     //Float
        public Nullable<float> InitialGradientDivisions { get; set; } = 350f;     //Float
        public Nullable<float> RectangleRatio { get; set; } = 1f;     //Float
        public string GradientPalette { get; set; } = @"base\fx\_textures\quests\q116\q_rainbow_rift_palette_d.xbm";    //rRef:ITexture
        public string SecondaryGradientPalette { get; set; } = @"base\fx\_textures\quests\q116\q_rainbow_rift_palette_02_d.xbm";    //rRef:ITexture
        public Nullable<float> Reveal { get; set; } = 0.573643f;     //Float
        public Nullable<float> ReveakMaskContrast { get; set; } = 1.214575f;     //Float
        public Nullable<float> RevealBiasMin { get; set; } = 0.1f;     //Float
        public Nullable<float> RevealBiasMax { get; set; } = 0.1f;     //Float
        public Nullable<float> ColorBias { get; set; } = 0.728745f;     //Float
        public Nullable<float> FloatOrParam { get; set; } = 0f;     //Float
        public Nullable<float> FloatOrAlpha { get; set; } = 0f;     //Float
        public Vec4 HSB { get; set; } = new Vec4(0f, 0.035f, -0.23f, 0f);    //Vector4
        public Nullable<float> BottomLinesAmount { get; set; } = 1f;     //Float
        public Nullable<float> BottomLinesCuttoff { get; set; } = 0.255061f;     //Float
        public Nullable<float> BottomLinesWidth { get; set; } = 1f;     //Float
        public Nullable<float> TowardsCameraSpeed { get; set; } = 0f;     //Float
    }
    public partial class _cyberspace_teleport_glitch
    {
        public Nullable<float> DepthOffset { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string DistortionMap { get; set; } = @"base\fx\_textures\masks\patterns\digital_noise_02.xbm";    //rRef:ITexture
        public Nullable<float> DistortionSize { get; set; } = 2f;     //Float
        public Nullable<float> DistortionMultiplier { get; set; } = 0.03876f;     //Float
        public Nullable<float> ChangeChance { get; set; } = 15f;     //Float
        public Nullable<float> LinesSize { get; set; } = 75f;     //Float
        public Nullable<float> LinesSpeed { get; set; } = 40f;     //Float
        public Nullable<float> LinesAmount { get; set; } = 0.75f;     //Float
        public Nullable<float> LinesDistortion { get; set; } = 0.25f;     //Float
        public Nullable<float> SampledDistortOFfset { get; set; } = 0.025f;     //Float
        public Vec4 SampledDistortSize { get; set; } = new Vec4(1f, 1.5f, 0f, 0f);    //Vector4
        public Nullable<float> ColorMultiplier { get; set; } = 0.5f;     //Float
    }
    public partial class _decal_caustics
    {
        public Color Color { get; set; } = new Color(146, 238, 255, 255);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 8f;     //Float
        public string Distortion { get; set; } = @"base\fx\_textures\masks\distortions\fx_noisenormal_03_n.xbm";    //rRef:ITexture
        public Nullable<float> Contrast { get; set; } = 5f;     //Float
        public Nullable<float> Speed { get; set; } = 5f;     //Float
        public Nullable<float> SmallMovementSpeed { get; set; } = 1f;     //Float
        public Nullable<float> Spread { get; set; } = 17f;     //Float
        public Nullable<float> DistortionAmount { get; set; } = 0f;     //Float
        public Nullable<float> DistortionUVScaling { get; set; } = 1f;     //Float
        public Nullable<float> UVScaling { get; set; } = 7f;     //Float
        public Nullable<float> EdgeWidth { get; set; } = 10f;     //Float
        public Nullable<float> EdgeMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> MaxValue { get; set; } = 1.2f;     //Float
        public Nullable<float> GradientStartPosition { get; set; } = 2.3f;     //Float
        public Nullable<float> GradientLength { get; set; } = 2f;     //Float
    }
    public partial class _decal_glitch
    {
        public string DiffuseTexture { get; set; } = @"base\surfaces\textures\decals\graffiti\tarot\chariot_mural_d.xbm";    //rRef:ITexture
        public string MaskTexture { get; set; } = @"base\surfaces\textures\decals\graffiti\tarot\chariot_mural_m.xbm";    //rRef:ITexture
        public string GradientMap { get; set; } = @"base\surfaces\textures\decals\graffiti\tarot\chariot_mural_g.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
        public Nullable<float> GlitchScale { get; set; } = 20f;     //Float
        public Nullable<float> GlitchStrength { get; set; } = 0.28f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 0.25f;     //Float
        public Nullable<float> GlitchOffOn { get; set; } = 1f;     //Float
        public Nullable<float> DissapearingChance { get; set; } = 0f;     //Float
        public Nullable<float> ColorChangeAmount { get; set; } = 0f;     //Float
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
    }
    public partial class _decal_glitch_emissive
    {
        public string DiffuseTexture { get; set; } = @"base\surfaces\textures\decals\graffiti\tarot\chariot_mural_d.xbm";    //rRef:ITexture
        public string MaskTexture { get; set; } = @"base\surfaces\textures\decals\graffiti\tarot\chariot_mural_m.xbm";    //rRef:ITexture
        public string GradientMap { get; set; } = @"base\surfaces\textures\decals\graffiti\tarot\chariot_mural_g.xbm";    //rRef:ITexture
        public string RoughnessTexture { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
        public Nullable<float> GlitchScale { get; set; } = 20f;     //Float
        public Nullable<float> GlitchStrength { get; set; } = 0.28f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 0.25f;     //Float
        public Nullable<float> GlitchOffOn { get; set; } = 1f;     //Float
        public Nullable<float> DissapearingChance { get; set; } = 0f;     //Float
        public Nullable<float> ColorChangeAmount { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Color DiffuseColor { get; set; } = new Color(255, 0, 0, 255);      //Color
    }
    public partial class _depth_based_sobel
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> ThinLinesThickness { get; set; } = 0.995f;     //Float
        public Nullable<float> ThinLinesDistance { get; set; } = 0.25f;     //Float
        public Nullable<float> ThickLinesThickness { get; set; } = 0.994f;     //Float
        public Nullable<float> ThickLinesDistance { get; set; } = 1f;     //Float
        public Nullable<float> OutlineThickness { get; set; } = 1f;     //Float
        public Color LinesColor { get; set; } = new Color(255, 18, 124, 255);      //Color
        public Nullable<float> Brightness { get; set; } = 50f;     //Float
        public Nullable<float> MinDistance { get; set; } = 10f;     //Float
        public Nullable<float> MaxDistance { get; set; } = 50f;     //Float
        public Nullable<float> MaskSizeX { get; set; } = 0.3f;     //Float
        public Nullable<float> MaskSizeY { get; set; } = 0.3f;     //Float
        public Nullable<float> SobelThreshold { get; set; } = 0.1f;     //Float
        public Nullable<float> SobelStep { get; set; } = 1f;     //Float
        public Nullable<float> SobelMinimumChange { get; set; } = 0.005f;     //Float
    }
    public partial class _diode_pavements_ui
    {
        public string BaseColor { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"base\surfaces\materials\default\black.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string DiodesMask { get; set; } = @"base\fx\textures\ui\diode_mask_normal.xbm";    //rRef:ITexture
        public string SignTexture { get; set; } = @"base\fx\textures\ui\no_parking.xbm";    //rRef:ITexture
        public Vec4 DiodesTilingAndScrollSpeed { get; set; } = new Vec4(20f, 20f, 0f, 0f);    //Vector4
        public Nullable<float> Emissive { get; set; } = 5f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
        public Nullable<float> UseMaskAsAlphaThreshold { get; set; } = 1f;     //Float
        public string UIRenderTexture { get; set; } = @"engine\ink\textures\4x4_transparent.xbm";    //rRef:ITexture
        public Vec4 TexturePartUV { get; set; } = new Vec4(0f, 0f, 1f, 1f);    //Vector4
        public Vec4 RenderTextureScale { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public Nullable<float> VerticalFlipEnabled { get; set; } = 0f;     //Float
        public Nullable<float> AmountOfGlitch { get; set; } = 0f;     //Float
        public Nullable<float> GlitchSpeed { get; set; } = 10f;     //Float
        public Vec4 BaseColorRoughnessTiling { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
    }
    public partial class _dirt_animated_masked
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Mask { get; set; } = @"base\fx\_textures\quests\q000\fx_q000_mirror_swipe.xbm";    //rRef:ITexture
        public string Dirt { get; set; } = @"base\surfaces\materials\concrete\concrete_new\concrete_new_dirty_01_300_d.xbm";    //rRef:ITexture
        public string DirtSecond { get; set; } = @"base\fx\_textures\masks\noise\fx_low_frequency_noise_01_d.xbm";    //rRef:ITexture
        public Color DirtColor { get; set; } = new Color(124, 113, 103, 255);      //Color
        public Nullable<float> Multiplier { get; set; } = 2f;     //Float
        public Nullable<float> WidthScaling { get; set; } = 1f;     //Float
        public Nullable<float> HeightScaling { get; set; } = 0.8f;     //Float
        public Nullable<float> RedChannelOrAlpha { get; set; } = 0f;     //Float
    }
    public partial class _e3_prototype_mask
    {
        public string MaskTexture { get; set; } = @"base\fx\_textures\masks\noise\fx_distorted_noise_01_d.xbm";    //rRef:ITexture
        public string HeatDistribution { get; set; } = @"base\fx\_textures\masks\noise\fx_perlin_noise_02_d.xbm";    //rRef:ITexture
        public Nullable<float> Temperature { get; set; } = 30.316744f;     //Float
        public Nullable<float> TemperatureMinimum { get; set; } = 0.104072f;     //Float
        public Nullable<float> HueShift { get; set; } = 0.728507f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 5.030154f;     //Float
        public Nullable<float> EmissiveExponent { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public Nullable<float> GradientWidth { get; set; } = 1f;     //Float
        public Nullable<float> DebugValue { get; set; } = 0.457014f;     //Float
        public Nullable<float> UseFloatValue { get; set; } = 0f;     //Float
    }
    public partial class _fake_flare
    {
        public Nullable<float> WidthScale { get; set; } = 0.1f;     //Float
        public Nullable<float> HeightScale { get; set; } = 0.1f;     //Float
        public Nullable<float> Promixity { get; set; } = 0.1f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string Diffuse { get; set; } = @"base\fx\_textures\flares\fx_anamorphic_flare_02_d.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(255, 0, 0, 255);      //Color
        public Nullable<float> Multiplier { get; set; } = 20f;     //Float
        public Nullable<float> MultiplierPower { get; set; } = 1.5f;     //Float
    }
    public partial class _fake_flare_simple
    {
        public Nullable<float> DistanceSizeFactor { get; set; } = 0f;     //Float
        public Nullable<float> SizeScale { get; set; } = 0.1f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string MaskTexture { get; set; } = @"base\fx\_textures\flares\flare_01.xbm";    //rRef:ITexture
        public Nullable<float> RadialOrTexture { get; set; } = 0f;     //Float
        public Color Color { get; set; } = new Color(3, 255, 0, 255);      //Color
        public Nullable<float> Multiplier { get; set; } = 150f;     //Float
        public Nullable<float> FalloffPower { get; set; } = 5f;     //Float
        public Nullable<float> MinimumDistanceVisibility { get; set; } = 1f;     //Float
        public Nullable<float> DistanceVisibilityFadeIn { get; set; } = 1f;     //Float
        public Nullable<float> MaximumRangeMin { get; set; } = 1500f;     //Float
        public Nullable<float> MaximumRangeMax { get; set; } = 2000f;     //Float
        public Nullable<float> BlinkSpeed { get; set; } = 0f;     //Float
    }
    public partial class _flat_fog_masked
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string RefractionMask { get; set; } = @"base\vehicles\common\textures\vehicles_destruction_01_n.xbm";    //rRef:ITexture
        public Nullable<float> DebugValue { get; set; } = 5.576324f;     //Float
        public Nullable<float> Fogginess { get; set; } = 100f;     //Float
        public Nullable<float> Crackness { get; set; } = 200f;     //Float
        public Nullable<float> FogOrRefraction { get; set; } = 1f;     //Float
        public Color CrackColor { get; set; } = new Color(255, 0, 0, 255);      //Color
    }
    public partial class _flat_fog_masked_notxaa
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string RefractionMask { get; set; } = @"base\vehicles\common\textures\vehicles_destruction_01_n.xbm";    //rRef:ITexture
        public Nullable<float> DebugValue { get; set; } = 5.576324f;     //Float
        public Nullable<float> Fogginess { get; set; } = 100f;     //Float
        public Nullable<float> Crackness { get; set; } = 200f;     //Float
        public Nullable<float> FogOrRefraction { get; set; } = 1f;     //Float
        public Color CrackColor { get; set; } = new Color(255, 0, 0, 255);      //Color
    }
    public partial class _highlight_blocker
    {
        public Nullable<float> MeshGrow { get; set; } = 0f;     //Float
    }
    public partial class _hologram_proxy
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public string Color { get; set; } = @"base\fx\textures\blood\blood_radial_v001_velocity.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 2f;     //Float
        public Nullable<float> FresnelIntensity { get; set; } = 0.5f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 0.1f;     //Float
        public Nullable<float> FresnelGamma { get; set; } = 1f;     //Float
        public Nullable<float> Alpha { get; set; } = 0.3f;     //Float
        public Nullable<float> DecayStart { get; set; } = 1.992727f;     //Float
        public Nullable<float> Decay { get; set; } = 1f;     //Float
    }
    public partial class _holo_mask
    {
        public Nullable<float> VerticalDivisions { get; set; } = 6f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 1f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 0.065f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\characters\garment\gang_scavenger\head\h1_081_mask__holo\textures\h1_081_mask__holo_eyes_d01.xbm";    //rRef:ITexture
        public Nullable<float> ChangeSpeed { get; set; } = 3f;     //Float
        public Nullable<float> HorizontalDivisions { get; set; } = 6f;     //Float
        public Nullable<float> ScanlineDensity { get; set; } = 100f;     //Float
        public Nullable<float> ScanlineMinimum { get; set; } = 0.2f;     //Float
        public Color MinColor { get; set; } = new Color(229, 229, 229, 255);      //Color
        public Color MaxColor { get; set; } = new Color(0, 255, 168, 255);      //Color
        public Color EyesColor { get; set; } = new Color(175, 0, 0, 255);      //Color
        public Nullable<float> BrightnessBoost { get; set; } = 10f;     //Float
        public Nullable<float> EyesBoost { get; set; } = 1.5f;     //Float
        public Nullable<float> AmountOfHorizontalTear { get; set; } = 0.27907f;     //Float
        public Nullable<float> ULimit { get; set; } = 0.126904f;     //Float
        public Nullable<float> VLimit { get; set; } = 0.147208f;     //Float
    }
    public partial class _invisible
    {
    }
    public partial class _lightning_plasma
    {
        public Nullable<float> UseTimeOrAnimationFrame { get; set; } = 0f;     //Float
        public string DisplaceAlongUV { get; set; } = @"base\fx\_textures\masks\noise\fx_perlin_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> DisplaceAlongUVSpeed { get; set; } = 0.1f;     //Float
        public Nullable<float> DisplaceAlongUVScale { get; set; } = 1f;     //Float
        public Nullable<float> DisplaceAlongUVStrength { get; set; } = 0f;     //Float
        public Nullable<float> DisplaceAlongUVStrengthPower { get; set; } = 1f;     //Float
        public Nullable<float> DisplaceAlongUVAdjustWidth { get; set; } = 0f;     //Float
        public Nullable<float> DisplaceSeed { get; set; } = 1234f;     //Float
        public Nullable<float> DisplaceSeedSPEED { get; set; } = 0f;     //Float
        public Nullable<float> DisplaceSeedSPEEDProbability { get; set; } = 0f;     //Float
        public Nullable<float> DisplaceAlongUVOffScale { get; set; } = 0.5f;     //Float
        public Nullable<float> DisplaceAlongUVOffSpeed { get; set; } = 0.1f;     //Float
        public Nullable<float> DisplaceAlongUVOffSTR { get; set; } = 0f;     //Float
        public Nullable<float> WorldNoiseSTR { get; set; } = 0f;     //Float
        public Nullable<float> WorldNoiseSize { get; set; } = 1f;     //Float
        public Nullable<float> WorldNoiseSpeed { get; set; } = 0.1f;     //Float
        public Nullable<float> WorldNoise_Up_extra { get; set; } = 0f;     //Float
        public Nullable<float> SetWorldNoiseToLocal { get; set; } = 0f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> FlipUVby90deg { get; set; } = 0f;     //Float
        public string TemperatureTexture { get; set; } = @"base\fx\_textures\electricity\fx_lightning_plasma_01_d.xbm";    //rRef:ITexture
        public Nullable<float> MeshAnimationOnOff { get; set; } = 0f;     //Float
        public Nullable<float> MeshPlaySpeed { get; set; } = 0f;     //Float
        public Nullable<float> SubUVWidth { get; set; } = 1f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> TemperatureTextureScale { get; set; } = 1f;     //Float
        public Nullable<float> TemperatureTextureSpeed { get; set; } = 0f;     //Float
        public Nullable<float> Temperature { get; set; } = 30f;     //Float
        public Nullable<float> TemperaturePow { get; set; } = 1f;     //Float
        public Nullable<float> TemperatureFlickerSpeed { get; set; } = 20f;     //Float
        public Nullable<float> TemperatureFlickerSTR { get; set; } = 0f;     //Float
        public Nullable<float> HueShift { get; set; } = 0f;     //Float
        public Nullable<float> HueSaturation { get; set; } = 0f;     //Float
        public Nullable<float> ContactPointRange { get; set; } = 0f;     //Float
        public Nullable<float> ContactPointSTR { get; set; } = 0f;     //Float
        public Color Tint { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> SoftAlpha { get; set; } = 1f;     //Float
        public Nullable<float> maxAlpha { get; set; } = 1f;     //Float
        public string DistortTexture { get; set; } = @"base\fx\_textures\masks\noise\fx_perlin_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> DistortAmount { get; set; } = 0f;     //Float
        public Vec4 TexCoordDtortScale { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Vec4 TexCoordDistortSpeed { get; set; } = new Vec4(0.1f, 0.1f, 0f, 0f);    //Vector4
    }
    public partial class _light_gradients
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Color BottomColor { get; set; } = new Color(76, 194, 255, 255);      //Color
        public Color TopColor { get; set; } = new Color(0, 255, 163, 255);      //Color
        public Nullable<float> LerpGradient { get; set; } = 0f;     //Float
        public Nullable<float> Multiplier { get; set; } = 1f;     //Float
        public Nullable<float> MinProximityAlpha { get; set; } = 0.035f;     //Float
        public Nullable<float> MaxProximityAlpha { get; set; } = 0.05f;     //Float
        public Nullable<float> GroundPosition { get; set; } = 45f;     //Float
        public Nullable<float> TopPosition { get; set; } = 200f;     //Float
        public Nullable<float> GradientDirection { get; set; } = 0.704641f;     //Float
        public Nullable<float> RoundGradientPosition { get; set; } = 0.150591f;     //Float
        public Nullable<float> RoundGradientScale { get; set; } = 1f;     //Float
        public Nullable<float> DistanceToSurfaceModifier { get; set; } = 100f;     //Float
    }
    public partial class _low_health
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string MainPattern { get; set; } = @"base\fx\_textures\masks\patterns\fx_screen_pattern_r.xbm";    //rRef:ITexture
        public string FluffText { get; set; } = @"base\fx\_textures\masks\patterns\fx_fluff_text_r.xbm";    //rRef:ITexture
        public string FluffPattern { get; set; } = @"base\fx\_textures\masks\patterns\fx_fluff_pattern_d.xbm";    //rRef:ITexture
        public Nullable<float> Rows { get; set; } = 3f;     //Float
        public Nullable<float> MaximumSliding { get; set; } = 150f;     //Float
        public Nullable<float> MaximumDistortion { get; set; } = 0.1f;     //Float
        public Nullable<float> OffsetChangeSpeed { get; set; } = 4f;     //Float
        public Nullable<float> OffsetAmount { get; set; } = 1.5f;     //Float
        public Nullable<float> PatternTiling { get; set; } = 100f;     //Float
        public Nullable<float> PatternVisibility { get; set; } = 1f;     //Float
        public Nullable<float> FluffVisibility { get; set; } = 1f;     //Float
        public Nullable<float> FluffTiling { get; set; } = 1f;     //Float
        public Color VignetteColor { get; set; } = new Color(164, 0, 78, 255);      //Color
        public Color FluffTextColor { get; set; } = new Color(185, 38, 38, 255);      //Color
        public Nullable<float> VignetteMin { get; set; } = -0.316456f;     //Float
        public Nullable<float> Multiplier { get; set; } = 4.936709f;     //Float
        public Nullable<float> VignetteMax { get; set; } = 2.848101f;     //Float
        public Nullable<float> VignetteLength { get; set; } = 0.421941f;     //Float
        public Nullable<float> VignetteSteps { get; set; } = 15f;     //Float
        public Nullable<float> VignetteContrast { get; set; } = 1f;     //Float
        public Nullable<float> FinalContrast { get; set; } = 1f;     //Float
        public Nullable<float> LinesMultiplier { get; set; } = 0f;     //Float
    }
    public partial class _mesh_decal__blackbody
    {
        public Nullable<float> VertexOffsetFactor { get; set; } = 0f;     //Float
        public string MaskTexture { get; set; } = @"base\fx\_textures\masks\noise\fx_organic_noise_01_d.xbm";    //rRef:ITexture
        public string HeatDistribution { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Vec4 HeatTiling { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> Temperature { get; set; } = 30f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 1f;     //Float
        public Nullable<float> MaskMinimum { get; set; } = 0f;     //Float
        public Vec4 HSV_Mod { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public Nullable<float> UseFloatParam { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveAlphaContrast { get; set; } = 1f;     //Float
    }
    public partial class _metal_base_scrolling
    {
        public Nullable<float> Metalness { get; set; } = 0f;     //Float
        public Nullable<float> Roughness { get; set; } = 0.5f;     //Float
        public Color Bright { get; set; } = new Color(153, 0, 0, 255);      //Color
        public Color Dark { get; set; } = new Color(62, 0, 0, 255);      //Color
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public string Mask { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_01_d.xbm";    //rRef:ITexture
        public Vec4 MaskTilingAndScrolling { get; set; } = new Vec4(5f, 5f, 0f, 0.1f);    //Vector4
        public Nullable<float> EmissiveEV { get; set; } = 10f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
    }
    public partial class _multilayer_blackbody_inject
    {
        public Nullable<float> Emissive { get; set; } = 6.192894f;     //Float
        public Nullable<float> Temperature { get; set; } = 22.335026f;     //Float
        public Nullable<float> MaximumTemperature { get; set; } = 100f;     //Float
        public Nullable<float> ColorExponent { get; set; } = 1f;     //Float
        public Nullable<float> Debug { get; set; } = 0f;     //Float
        public Vec4 FireHSV { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 PoisonHSV { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 ElectricHSV { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public string GlobalNormal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string DamageTypeRGBMask { get; set; } = @"base\fx\_textures\masks\noise\fx_perlin_noise_3d_01_d.xbm";    //rRef:ITexture
        public string DamageTypeNoise { get; set; } = @"base\fx\_textures\masks\noise\fx_perlin_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> DamageTypeNoiseIntesityAdd { get; set; } = 0f;     //Float
        public Vec4 DamageTypeNoiseUV { get; set; } = new Vec4(1f, 1f, 0.05f, 0.05f);    //Vector4
        public string MultilayerMask { get; set; } = @"base\characters\cyberware\player\a0_003__mantisblade\textures\ml_a0_003_wa__mantisblade_midpoly2_masksset.mlmask";     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; } = @"base\characters\cyberware\player\a0_003__mantisblade\textures\ml_a0_003_wa__mantisblade_midpoly2.mlsetup";     //rRef:Multilayer_Setup
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
    }
    public partial class _nanowire_string
    {
        public Nullable<float> Thickness { get; set; } = 0.005f;     //Float
        public Nullable<float> NoiseAmount { get; set; } = 0.3f;     //Float
        public Nullable<float> NoiseScale { get; set; } = 5f;     //Float
        public Nullable<float> MaxVelocity { get; set; } = 1.5f;     //Float
        public Nullable<float> MaxVelocityExponent { get; set; } = 5f;     //Float
        public Nullable<float> StartGradient { get; set; } = 0.002f;     //Float
        public Nullable<float> GradientWidth { get; set; } = 0.005f;     //Float
        public Nullable<float> MaxDistance { get; set; } = 50f;     //Float
        public Color MainColor { get; set; } = new Color(63, 59, 58, 255);      //Color
        public string NormalMap { get; set; } = @"base\fx\_textures\weapons\w_monowire_string_twist_n.xbm";    //rRef:ITexture
        public string MaskTexture { get; set; } = @"base\fx\_textures\weapons\w_monowire_string_twist_height_d.xbm";    //rRef:ITexture
        public Vec4 NormalTiling { get; set; } = new Vec4(2f, 2f, 0f, 0f);    //Vector4
        public Nullable<float> Metalness { get; set; } = 0.339535f;     //Float
        public Nullable<float> Roughness { get; set; } = 0.655814f;     //Float
        public Nullable<float> Temperature { get; set; } = 15.282393f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 7.4756145f;     //Float
        public Nullable<float> MinimumEmissive { get; set; } = 0.5f;     //Float
        public Nullable<float> EmissiveMaskPower { get; set; } = 0.27907f;     //Float
        public Nullable<float> TurnOffBrightness { get; set; } = 0.996678f;     //Float
        public Nullable<float> BlinkSpeed { get; set; } = 0.5f;     //Float
        public Nullable<float> BlinkWidth { get; set; } = 1.395349f;     //Float
        public Nullable<float> BlinkMultiplier { get; set; } = 0f;     //Float
        public Nullable<float> BlinkOffMultiplier { get; set; } = 0f;     //Float
        public Vec4 HSVMod { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
    }
    public partial class _oda_helm
    {
        public string BaseColor { get; set; } = @"base\fx\_textures\quests\q112\fx_oda_mask_base.xbm";    //rRef:ITexture
        public string Hologram { get; set; } = @"base\fx\_textures\quests\q112\fx_oda_mask.xbm";    //rRef:ITexture
        public string NormalRoughnessMetalness { get; set; } = @"base\fx\_textures\quests\q112\fx_oda_mask_nrm.xbm";    //rRef:ITexture
        public string ScanlineTexture { get; set; } = @"";    //rRef:ITexture
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVGlitched { get; set; } = 0f;     //Float
        public Nullable<float> DotPower { get; set; } = 4.11811f;     //Float
        public Nullable<float> SecondaryDotPower { get; set; } = 0f;     //Float
        public Nullable<float> LayersSeparation { get; set; } = 0.01f;     //Float
        public Vec4 LayersIntensity { get; set; } = new Vec4(1f, 0.5f, 0.25f, 0f);    //Vector4
        public Vec4 ScanlineTilingAndSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> ScanlinesIntensity { get; set; } = 0f;     //Float
        public Vec4 NoiseScale { get; set; } = new Vec4(100f, 100f, 10f, 10f);    //Vector4
        public Color PrimaryColor { get; set; } = new Color(218, 0, 0, 255);      //Color
        public Color SecondaryColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color BackgroundColor { get; set; } = new Color(70, 70, 70, 255);      //Color
        public Color NoiseColor { get; set; } = new Color(172, 0, 226, 255);      //Color
        public Nullable<float> NormalOrBroken { get; set; } = 0f;     //Float
    }
    public partial class _rift_noise
    {
        public Nullable<float> EmissiveEVMin { get; set; } = 5f;     //Float
        public Nullable<float> EmissiveEVMax { get; set; } = 10f;     //Float
        public Color EmissiveColor { get; set; } = new Color(210, 240, 128, 255);      //Color
        public string EmissiveMask { get; set; } = @"base\fx\_textures\masks\gradients\fx_reflected_vertical_gradient_01_d.xbm";    //rRef:ITexture
        public string Dot { get; set; } = @"base\fx\_textures\masks\shapes\fx_dot_01_d.xbm";    //rRef:ITexture
        public string Noise { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_01_d.xbm";    //rRef:ITexture
        public Nullable<float> NoiseSpeed { get; set; } = 0.03f;     //Float
        public Nullable<float> NoiseScale { get; set; } = 0.5f;     //Float
        public Vec4 NoiseScaleXY { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public string DistanceNoise { get; set; } = @"base\fx\_textures\masks\noise\fx_digital_noise_3d_01_d.xbm";    //rRef:ITexture
        public Nullable<float> DistanceNoiseScale { get; set; } = 3f;     //Float
        public Vec4 DistanceNoiseScaleXY { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> DistanceNoiseAmount { get; set; } = 0.1f;     //Float
        public Nullable<float> DistPower { get; set; } = 3.5f;     //Float
        public Nullable<float> DotsLift { get; set; } = 1f;     //Float
        public Nullable<float> DotsMax { get; set; } = 1f;     //Float
        public Nullable<float> DistanceNoiseSpeed { get; set; } = 0.1f;     //Float
        public Nullable<float> MaxDistance { get; set; } = 10f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 0f;     //Float
    }
    public partial class _screen_wave
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> DistortAmount { get; set; } = 0.1f;     //Float
    }
    public partial class _simple_fog
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Mask { get; set; } = @"base\fx\_textures\masks\gradients\fx_radial_gradient_01_alpha_d.xbm";    //rRef:ITexture
        public Color Color { get; set; } = new Color(0, 140, 255, 255);      //Color
        public Nullable<float> Brightness { get; set; } = 1f;     //Float
        public Nullable<float> MinimumVisibilityDistance { get; set; } = 100f;     //Float
        public Nullable<float> VisibilityFadeIn { get; set; } = 10f;     //Float
        public Nullable<float> TextureFalloff { get; set; } = 3f;     //Float
        public Nullable<float> MinimumBottonDistance { get; set; } = 1f;     //Float
        public Nullable<float> BottomVisibilityFadeIn { get; set; } = 1f;     //Float
        public Nullable<float> DepthDivision { get; set; } = 1f;     //Float
        public Nullable<float> DepthContrast { get; set; } = 0f;     //Float
        public Nullable<float> SoftAlpha { get; set; } = 0.1f;     //Float
        public Nullable<float> SteepAngleBlend { get; set; } = 0f;     //Float
        public Nullable<float> SteepAngleBlendLength { get; set; } = 0f;     //Float
    }
    public partial class _simple_refraction_mask
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> RefractionStrength { get; set; } = 50f;     //Float
        public Vec4 RefractionTextureOffset { get; set; } = new Vec4(0.75f, 0.75f, 0f, 0f);    //Vector4
        public Vec4 RefractionTextureSpeed { get; set; } = new Vec4(-0.025f, -0.01f, 0f, 0f);    //Vector4
        public Vec4 RefractionTextureScale { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public string Refraction { get; set; } = @"base\fx\_textures\weapons\trails\fx_trails_refraction_01_d.xbm";    //rRef:ITexture
        public Nullable<float> UseAlphaMask { get; set; } = 0f;     //Float
        public string AlphaMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> UseDepth { get; set; } = 0f;     //Float
        public Nullable<float> SlowFactor { get; set; } = 1f;     //Float
        public Nullable<float> RefractionStrengthSlowTime { get; set; } = 800f;     //Float
        public Nullable<float> MaskGradientPower { get; set; } = 1f;     //Float
        public Color Color { get; set; } = new Color(255, 255, 255, 0);      //Color
        public Nullable<float> SoftAlpha { get; set; } = 0f;     //Float
    }
    public partial class _transparent_flowmap
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\characters\head\ma\h0_001_ma_c__basehead\textures\h0_001_ma_c__basehead_d03.xbm";    //rRef:ITexture
        public string Flowmap { get; set; } = @"base\fx\_textures\masks\distortions\fx_distortion_04_n.xbm";    //rRef:ITexture
        public Nullable<float> FlowMapStrength { get; set; } = 0.1f;     //Float
        public Nullable<float> FlowSpeed { get; set; } = 1.085271f;     //Float
        public Color Color { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> Multiplier { get; set; } = 1f;     //Float
        public Nullable<float> Power { get; set; } = 1f;     //Float
    }
    public partial class _transparent_liquid_notxaa
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> SurfaceMetalness { get; set; } = 0f;     //Float
        public Color ScatteringColorThin { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color ScatteringColorThick { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Color Albedo { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Nullable<float> IOR { get; set; } = 1.33f;     //Float
        public Nullable<float> FresnelBias { get; set; } = 1f;     //Float
        public string Normal { get; set; } = @"base\materials\placeholder\normal.xbm";    //rRef:ITexture
        public Nullable<float> Roughness { get; set; } = 0f;     //Float
        public Nullable<float> SpecularStrengthMultiplier { get; set; } = 0.5f;     //Float
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> MaskOpacity { get; set; } = 1f;     //Float
        public Nullable<float> ThicknessMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> SubUVWidth { get; set; } = 1f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> InterpolateFrames { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.05f;     //Float
        public Vec4 NormalTilingAndScrolling { get; set; } = new Vec4(1f, 1f, 0f, 0f);    //Vector4
        public string Distort { get; set; } = @"engine\ink\textures\4x4_black.xbm";    //rRef:ITexture
        public Nullable<float> DistortAmount { get; set; } = 0f;     //Float
        public Vec4 DistortTilingAndScrolling { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public string Mask { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> EnableRowAnimation { get; set; } = 0f;     //Float
        public Nullable<float> UseOnStaticMeshes { get; set; } = 0f;     //Float
    }
    public partial class _world_to_screen_glitch
    {
        public Nullable<float> OffsetAmount { get; set; } = 0.08502f;     //Float
        public Nullable<float> Spread { get; set; } = 4.251012f;     //Float
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> DistortionAmount { get; set; } = 0.076923f;     //Float
        public Nullable<float> Divisions { get; set; } = 9.716599f;     //Float
        public Nullable<float> GlitchChance { get; set; } = 0.052632f;     //Float
        public Nullable<float> GlitchSpeed { get; set; } = 8.744939f;     //Float
        public Nullable<float> GlowMultipier { get; set; } = 10f;     //Float
        public Nullable<float> DistortGlitchDivisions { get; set; } = 5.870445f;     //Float
        public Nullable<float> DistortGlitchSpeed { get; set; } = 11.174089f;     //Float
        public Nullable<float> MidMaskWidth { get; set; } = 0.093117f;     //Float
        public string Diffuse { get; set; } = @"";    //rRef:ITexture
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
        public string MultilayerMask { get; set; } = @"";     //rRef:Multilayer_Mask
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> LayersStartIndex { get; set; } = 0f;     //Float
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> EditorMaskLayerIndex { get; set; } = 0f;     //Float
        public Nullable<float> EditorVisualizationModeIndex { get; set; } = 0f;     //Float
        public Nullable<float> EditorShowValue { get; set; } = 0f;     //Float
        public Vec4 EditorCursorPosition { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
    }
    public partial class _editor_mltemplate_preview
    {
        public string DiffuseTexture { get; set; } = @"";    //rRef:ITexture
        public string NormalTexture { get; set; } = @"";    //rRef:ITexture
        public Vec4 ColorScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> NormalScale { get; set; } = 0f;     //Float
        public string RoughnessTexture { get; set; } = @"";    //rRef:ITexture
        public Nullable<float> MetalnessScaleIn { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBiasIn { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessScaleIn { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBiasIn { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessScaleOut { get; set; } = 0f;     //Float
        public Nullable<float> MetalnessBiasOut { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessScaleOut { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBiasOut { get; set; } = 0f;     //Float
        public Nullable<float> ColorMaskScaleIn { get; set; } = 0f;     //Float
        public Nullable<float> ColorMaskBiasIn { get; set; } = 0f;     //Float
        public Nullable<float> ColorMaskScaleOut { get; set; } = 0f;     //Float
        public Nullable<float> ColorMaskBiasOut { get; set; } = 0f;     //Float
        public string MetalnessTexture { get; set; } = @"";    //rRef:ITexture
        public Nullable<float> Tiling { get; set; } = 0f;     //Float
    }
    public partial class _gi_backface_debug
    {
    }
    public partial class _multilayered_baked
    {
        public Nullable<float> SurfaceID { get; set; } = 0f;     //Float
        public string Indirection { get; set; } = @"";    //rRef:ITexture
        public string BaseColorRough { get; set; } = @"";    //rRef:ITexture
        public string NormalMetal { get; set; } = @"";    //rRef:ITexture
    }
    public partial class _silverhand_props_overlay
    {
        public Nullable<float> DepthOffset { get; set; } = 0f;     //Float
        public string VectorField { get; set; } = @"";    //rRef:ITexture
        public Nullable<float> GlitchChance { get; set; } = 0f;     //Float
        public Nullable<float> GlitchOffset { get; set; } = 0f;     //Float
        public Nullable<float> GlitchTimeSeed { get; set; } = 0f;     //Float
        public string FresnelMask { get; set; } = @"base\materials\placeholder\white.xbm";    //rRef:ITexture
        public Nullable<float> FresnelMaskIntensity { get; set; } = 1f;     //Float
        public string GlobalNormal { get; set; } = @"base\characters\main_npc\silverhand\textures\a0_001_ma_arms__silverhand_n01.xbm";    //rRef:ITexture
        public string MultilayerMask { get; set; } = @"base\characters\main_npc\silverhand\textures\ml_a0_001_ma_arms__silverhand_masksset.mlmask";     //rRef:Multilayer_Mask
        public string MultilayerSetup { get; set; } = @"base\characters\main_npc\silverhand\textures\ml_a0_001_ma_arms__silverhand.mlsetup";     //rRef:Multilayer_Setup
        public Nullable<float> Emissive { get; set; } = 0f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0f;     //Float
        public Nullable<float> BayerScale { get; set; } = 2f;     //Float
        public Nullable<float> BayerIntensity { get; set; } = 0.5f;     //Float
        public Vec4 VertexColorSelection { get; set; } = new Vec4(1f, 0f, -0.1f, 0f);    //Vector4
        public Nullable<float> VectorFieldTiling { get; set; } = 2f;     //Float
        public Nullable<float> VectorFieldIntensity { get; set; } = 0.5f;     //Float
        public Vec4 VectorFieldAnim { get; set; } = new Vec4(0f, 0f, 0.1f, 0f);    //Vector4
        public Color FresnelColor { get; set; } = new Color(0, 176, 255, 255);      //Color
        public Nullable<float> FresnelColorIntensity { get; set; } = 1f;     //Float
        public Nullable<float> FresnelExponent { get; set; } = 3f;     //Float
        public string MaskAtlas { get; set; } = @"";    //rRef:ITexture
        public DataBuffer MaskTiles { get; set; }
        public DataBuffer Layers { get; set; }
        public Nullable<float> SurfaceTexAspectRatio { get; set; } = 0f;     //Float
        public Vec4 MaskToTileScale { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> MaskTileSize { get; set; } = 0f;     //Float
        public Vec4 MaskAtlasDims { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 MaskBaseResolution { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> SetupLayerMask { get; set; } = 0f;     //Float
    }
    public partial class _mikoshi_fullscr_transition
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public string Diffuse { get; set; } = @"base\fx\textures\3dmap\camera_01\map_color_01.dtex";    //rRef:ITexture
        public string Mask { get; set; } = @"base\fx\textures\cyberspace\cyberplatform\point_mask.xbm";    //rRef:ITexture
    }
    public partial class _decal
    {
        public string DiffuseTexture { get; set; } = @"base\fx\textures\fire\fire1.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _decal_normal
    {
        public string DiffuseTexture { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public Nullable<float> DiffuseTextureAsMaskTexture { get; set; } = 0f;     //Float
        public string NormalTexture { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Color DiffuseColor { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> AlphaMaskContrast { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public Nullable<float> RoughnessMetalnessAlpha { get; set; } = 1f;     //Float
        public Nullable<float> SubUVx { get; set; } = 1f;     //Float
        public Nullable<float> SubUVy { get; set; } = 1f;     //Float
        public Nullable<float> Frame { get; set; } = 0f;     //Float
    }
    public partial class _pbr_layer
    {
        public string Diffuse { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public string Mask { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public string GlobalNormal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string MicroBlends { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public string RoughMetalBlend { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Color TintColor { get; set; } = new Color(128, 128, 128, 255);      //Color
        public Nullable<float> LayerTile { get; set; } = 2f;     //Float
        public Nullable<float> MicroblendTile { get; set; } = 2f;     //Float
        public Nullable<float> MicroblendContrast { get; set; } = 0f;     //Float
        public Nullable<float> MicroblendNormalStrength { get; set; } = 0f;     //Float
        public Nullable<float> LayerOpacity { get; set; } = 1f;     //Float
        public Nullable<float> LayerOffsetU { get; set; } = 0f;     //Float
        public Nullable<float> LayerOffsetV { get; set; } = 0f;     //Float
        public Nullable<float> is_df { get; set; } = 0f;     //Float
    }
    public partial class _debugdraw
    {
    }
    public partial class _fallback
    {
    }
    public partial class _metal_base
    {
        public Nullable<float> VehicleDamageInfluence { get; set; } = 1f;     //Float
        public string BaseColor { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Vec4 BaseColorScale { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\editor\normal.xbm";    //rRef:ITexture
        public Nullable<float> NormalStrength { get; set; } = 1f;     //Float
        public Nullable<float> AlphaThreshold { get; set; } = 0.38f;     //Float
        public string Emissive { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> EmissiveLift { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEV { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveEVRaytracingBias { get; set; } = 0f;     //Float
        public Nullable<float> EmissiveDirectionality { get; set; } = 0f;     //Float
        public Nullable<float> EnableRaytracedEmissive { get; set; } = 1f;     //Float
        public Color EmissiveColor { get; set; } = new Color(0, 0, 0, 255);      //Color
        public Nullable<float> LayerTile { get; set; } = 1f;     //Float
    }
    public partial class _mirror
    {
        public string BaseColor { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string BorderMask { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Color BaseColorScale { get; set; } = new Color(255, 255, 255, 255);      //Color
        public string Metalness { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> MetalnessScale { get; set; } = 1f;     //Float
        public Nullable<float> MetalnessBias { get; set; } = 0f;     //Float
        public string Roughness { get; set; } = @"engine\textures\editor\grey.xbm";    //rRef:ITexture
        public Nullable<float> RoughnessScale { get; set; } = 1f;     //Float
        public Nullable<float> RoughnessBias { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public Nullable<float> Translucency { get; set; } = 0f;     //Float
        public Nullable<float> BorderThickness { get; set; } = 0f;     //Float
        public Color BorderColor { get; set; } = new Color(0, 0, 0, 0);      //Color
    }
    public partial class _particles_generic
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 0f;     //Float
        public Color Color { get; set; } = new Color(255, 255, 255, 255);      //Color
        public Nullable<float> ColorMultiplier { get; set; } = 1f;     //Float
        public Nullable<float> SubUVWidth { get; set; } = 2f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 2f;     //Float
        public Nullable<float> Desaturate { get; set; } = 0f;     //Float
        public Nullable<float> ColorPower { get; set; } = 1f;     //Float
        public Nullable<float> DistortAmount { get; set; } = 0f;     //Float
        public Vec4 TexCoordScale { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Vec4 TexCoordSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 TexCoordDtortScale { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Vec4 TexCoordDistortSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> AlphaGlobal { get; set; } = 1f;     //Float
        public Nullable<float> AlphaSoft { get; set; } = 0.5f;     //Float
        public Nullable<float> AlphaFresnelPower { get; set; } = 0f;     //Float
        public Nullable<float> UseAlphaFresnel { get; set; } = 0f;     //Float
        public Nullable<float> UseAlphaMask { get; set; } = 0f;     //Float
        public Nullable<float> UseOneChannel { get; set; } = 0f;     //Float
        public string Diffuse { get; set; } = @"base\fx\_textures\sparks\fx_sparks_oblong_01_2x2_d.xbm";    //rRef:ITexture
        public string AlphaMask { get; set; } = @"engine\textures\editor\white.xbm";    //rRef:ITexture
        public Nullable<float> FlipUVby90deg { get; set; } = 0f;     //Float
        public Nullable<float> EVCompensation { get; set; } = 0f;     //Float
        public string Distortion { get; set; } = @"engine\textures\editor\black.xbm";    //rRef:ITexture
        public Nullable<float> UseContrastAlpha { get; set; } = 0f;     //Float
        public Nullable<float> SoftUVInterpolate { get; set; } = 0f;     //Float
    }
    public partial class _particles_liquid
    {
        public Nullable<float> AdditiveAlphaBlend { get; set; } = 1f;     //Float
        public Nullable<float> SubUVWidth { get; set; } = 1f;     //Float
        public Nullable<float> SubUVHeight { get; set; } = 1f;     //Float
        public Nullable<float> Desaturate { get; set; } = 0f;     //Float
        public Nullable<float> DistortAmount { get; set; } = 0f;     //Float
        public Vec4 TexCoordScale { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Vec4 TexCoordSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Vec4 TexCoordDtortScale { get; set; } = new Vec4(1f, 1f, 1f, 0f);    //Vector4
        public Vec4 TexCoordDistortSpeed { get; set; } = new Vec4(0f, 0f, 0f, 0f);    //Vector4
        public Nullable<float> AlphaGlobal { get; set; } = 1f;     //Float
        public Nullable<float> AlphaSoft { get; set; } = 0.5f;     //Float
        public Nullable<float> AlphaFresnelPower { get; set; } = 0f;     //Float
        public Nullable<float> UseAlphaFresnel { get; set; } = 0f;     //Float
        public Nullable<float> UseAlphaMask { get; set; } = 0f;     //Float
        public Vec4 NormalMultiplier { get; set; } = new Vec4(1f, 1f, 1f, 1f);    //Vector4
        public Nullable<float> ReflectionMultiplier { get; set; } = 0f;     //Float
        public Nullable<float> ReflectionPower { get; set; } = 0f;     //Float
        public Color ReflectionColor { get; set; } = new Color(0, 0, 0, 0);      //Color
        public Nullable<float> RefractionMultiplier { get; set; } = 0f;     //Float
        public string Normal { get; set; } = @"engine\textures\small_flat_normal.xbm";    //rRef:ITexture
        public string AlphaMask { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string Distortion { get; set; } = @"engine\textures\small_white.xbm";    //rRef:ITexture
        public string Reflection { get; set; } = @"engine\textures\small_white.xbm";     //rRef:ITexture
        public Nullable<float> SoftUVInterpolate { get; set; } = 0f;     //Float
        public Nullable<float> ReflectionEdge { get; set; } = 0f;     //Float
        public Color MainColor { get; set; } = new Color(255, 0, 0, 0);      //Color
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
            Green = 255;
            Blue = 255;
            Alpha = 255;
        }
        public Color(Byte r, Byte g, Byte b, Byte a)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
        }
    }
    public class Vec4
    {
        public Nullable<float> X { get; set; }
        public Nullable<float> Y { get; set; }
        public Nullable<float> Z { get; set; }
        public Nullable<float> W { get; set; }

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
        public Vec4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
}

