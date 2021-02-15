using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraPlacementEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("cameraRef")] public NodeRef CameraRef { get; set; }
		[Ordinal(7)] [RED("cameraTransformLS")] public Transform CameraTransformLS { get; set; }

		public scneventsCameraPlacementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
