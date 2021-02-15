using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePhotoModeBackgroundCameraComponent : entBaseCameraComponent
	{
		[Ordinal(10)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(11)] [RED("virtualCameraName")] public CName VirtualCameraName { get; set; }
		[Ordinal(12)] [RED("dynamicTextureRes")] public raRef<DynamicTexture> DynamicTextureRes { get; set; }
		[Ordinal(13)] [RED("env")] public rRef<worldEnvironmentAreaParameters> Env { get; set; }
		[Ordinal(14)] [RED("params")] public WorldRenderAreaSettings Params { get; set; }
		[Ordinal(15)] [RED("depthCutDistance")] public CFloat DepthCutDistance { get; set; }
		[Ordinal(16)] [RED("backgroundColor")] public CColor BackgroundColor { get; set; }
		[Ordinal(17)] [RED("overrideBackgroundColor")] public CBool OverrideBackgroundColor { get; set; }
		[Ordinal(18)] [RED("renderSceneLayer")] public CEnum<RenderSceneLayer> RenderSceneLayer { get; set; }
		[Ordinal(19)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }

		public gamePhotoModeBackgroundCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
