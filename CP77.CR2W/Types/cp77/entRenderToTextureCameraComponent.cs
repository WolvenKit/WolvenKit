using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entRenderToTextureCameraComponent : entBaseCameraComponent
	{
		[Ordinal(0)]  [RED("virtualCameraName")] public CName VirtualCameraName { get; set; }
		[Ordinal(1)]  [RED("dynamicTextureRes")] public raRef<DynamicTexture> DynamicTextureRes { get; set; }
		[Ordinal(2)]  [RED("depthDynamicTextureRes")] public rRef<DynamicTexture> DepthDynamicTextureRes { get; set; }
		[Ordinal(3)]  [RED("albedoDynamicTextureRes")] public rRef<DynamicTexture> AlbedoDynamicTextureRes { get; set; }
		[Ordinal(4)]  [RED("normalsDynamicTextureRes")] public rRef<DynamicTexture> NormalsDynamicTextureRes { get; set; }
		[Ordinal(5)]  [RED("particlesDynamicTextureRes")] public rRef<DynamicTexture> ParticlesDynamicTextureRes { get; set; }
		[Ordinal(6)]  [RED("resolutionWidth")] public CUInt32 ResolutionWidth { get; set; }
		[Ordinal(7)]  [RED("resolutionHeight")] public CUInt32 ResolutionHeight { get; set; }
		[Ordinal(8)]  [RED("aspectRatio")] public CFloat AspectRatio { get; set; }
		[Ordinal(9)]  [RED("env")] public rRef<worldEnvironmentAreaParameters> Env { get; set; }
		[Ordinal(10)]  [RED("params")] public WorldRenderAreaSettings Params { get; set; }
		[Ordinal(11)]  [RED("renderingMode")] public CEnum<entRenderToTextureMode> RenderingMode { get; set; }
		[Ordinal(12)]  [RED("depthCutDistance")] public CFloat DepthCutDistance { get; set; }
		[Ordinal(13)]  [RED("backgroundColor")] public CColor BackgroundColor { get; set; }
		[Ordinal(14)]  [RED("overrideBackgroundColor")] public CBool OverrideBackgroundColor { get; set; }
		[Ordinal(15)]  [RED("renderSceneLayer")] public CEnum<RenderSceneLayer> RenderSceneLayer { get; set; }
		[Ordinal(16)]  [RED("features")] public entRenderToTextureFeatures Features { get; set; }
		[Ordinal(17)]  [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }

		public entRenderToTextureCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
