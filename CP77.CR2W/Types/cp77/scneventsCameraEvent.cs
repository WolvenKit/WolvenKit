using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("cameraRef")] public NodeRef CameraRef { get; set; }
		[Ordinal(1)]  [RED("isBlendIn")] public CBool IsBlendIn { get; set; }
		[Ordinal(2)]  [RED("blendTime")] public CFloat BlendTime { get; set; }

		public scneventsCameraEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
