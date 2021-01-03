using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(1)]  [RED("cameraRef")] public NodeRef CameraRef { get; set; }
		[Ordinal(2)]  [RED("isBlendIn")] public CBool IsBlendIn { get; set; }

		public scneventsCameraEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
