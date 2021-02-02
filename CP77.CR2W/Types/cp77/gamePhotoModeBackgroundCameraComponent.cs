using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePhotoModeBackgroundCameraComponent : entBaseCameraComponent
	{
		[Ordinal(0)]  [RED("dynamicTextureRes")] public raRef<DynamicTexture> DynamicTextureRes { get; set; }
		[Ordinal(1)]  [RED("virtualCameraName")] public CName VirtualCameraName { get; set; }
		[Ordinal(2)]  [RED("env")] public rRef<worldEnvironmentAreaParameters> Env { get; set; }
		[Ordinal(3)]  [RED("params")] public WorldRenderAreaSettings Params { get; set; }
		[Ordinal(4)]  [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
		[Ordinal(5)]  [RED("backgroundColor")] public CColor BackgroundColor { get; set; }
		[Ordinal(6)]  [RED("depthCutDistance")] public CFloat DepthCutDistance { get; set; }
		[Ordinal(7)]  [RED("renderSceneLayer")] public CEnum<RenderSceneLayer> RenderSceneLayer { get; set; }
		[Ordinal(8)]  [RED("overrideBackgroundColor")] public CBool OverrideBackgroundColor { get; set; }

		public gamePhotoModeBackgroundCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
