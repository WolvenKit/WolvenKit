using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("cameraRef")] public NodeRef CameraRef { get; set; }
		[Ordinal(7)] [RED("isBlendIn")] public CBool IsBlendIn { get; set; }
		[Ordinal(8)] [RED("blendTime")] public CFloat BlendTime { get; set; }

		public scneventsCameraEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
