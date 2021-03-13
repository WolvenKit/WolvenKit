using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRenderToTextureCameraComponent : entBaseCameraComponent
	{
		[Ordinal(10)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(11)] [RED("virtualCameraName")] public CName VirtualCameraName { get; set; }
		[Ordinal(12)] [RED("dynamicTextureRes")] public raRef<DynamicTexture> DynamicTextureRes { get; set; }
		[Ordinal(13)] [RED("depthDynamicTextureRes")] public rRef<DynamicTexture> DepthDynamicTextureRes { get; set; }
		[Ordinal(14)] [RED("albedoDynamicTextureRes")] public rRef<DynamicTexture> AlbedoDynamicTextureRes { get; set; }
		[Ordinal(15)] [RED("normalsDynamicTextureRes")] public rRef<DynamicTexture> NormalsDynamicTextureRes { get; set; }
		[Ordinal(16)] [RED("particlesDynamicTextureRes")] public rRef<DynamicTexture> ParticlesDynamicTextureRes { get; set; }
		[Ordinal(17)] [RED("resolutionWidth")] public CUInt32 ResolutionWidth { get; set; }
		[Ordinal(18)] [RED("resolutionHeight")] public CUInt32 ResolutionHeight { get; set; }
		[Ordinal(19)] [RED("aspectRatio")] public CFloat AspectRatio { get; set; }
		[Ordinal(20)] [RED("env")] public rRef<worldEnvironmentAreaParameters> Env { get; set; }
		[Ordinal(21)] [RED("params")] public WorldRenderAreaSettings Params { get; set; }
		[Ordinal(22)] [RED("renderingMode")] public CEnum<entRenderToTextureMode> RenderingMode { get; set; }
		[Ordinal(23)] [RED("depthCutDistance")] public CFloat DepthCutDistance { get; set; }
		[Ordinal(24)] [RED("backgroundColor")] public CColor BackgroundColor { get; set; }
		[Ordinal(25)] [RED("overrideBackgroundColor")] public CBool OverrideBackgroundColor { get; set; }
		[Ordinal(26)] [RED("renderSceneLayer")] public CEnum<RenderSceneLayer> RenderSceneLayer { get; set; }
		[Ordinal(27)] [RED("features")] public entRenderToTextureFeatures Features { get; set; }
		[Ordinal(28)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }

		public entRenderToTextureCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
