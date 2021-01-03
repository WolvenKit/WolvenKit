using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamePhotoModeBackgroundCameraComponent : entBaseCameraComponent
	{
		[Ordinal(0)]  [RED("backgroundColor")] public CColor BackgroundColor { get; set; }
		[Ordinal(1)]  [RED("depthCutDistance")] public CFloat DepthCutDistance { get; set; }
		[Ordinal(2)]  [RED("dynamicTextureRes")] public raRef<DynamicTexture> DynamicTextureRes { get; set; }
		[Ordinal(3)]  [RED("env")] public rRef<worldEnvironmentAreaParameters> Env { get; set; }
		[Ordinal(4)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(5)]  [RED("overrideBackgroundColor")] public CBool OverrideBackgroundColor { get; set; }
		[Ordinal(6)]  [RED("params")] public WorldRenderAreaSettings Params { get; set; }
		[Ordinal(7)]  [RED("renderSceneLayer")] public CEnum<RenderSceneLayer> RenderSceneLayer { get; set; }
		[Ordinal(8)]  [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
		[Ordinal(9)]  [RED("virtualCameraName")] public CName VirtualCameraName { get; set; }

		public gamePhotoModeBackgroundCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
