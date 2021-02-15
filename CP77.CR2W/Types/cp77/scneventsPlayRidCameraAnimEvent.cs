using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayRidCameraAnimEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("cameraRef")] public NodeRef CameraRef { get; set; }
		[Ordinal(7)] [RED("cameraPlacement")] public CEnum<scneventsRidCameraPlacement> CameraPlacement { get; set; }
		[Ordinal(8)] [RED("animData")] public scneventsPlayAnimEventData AnimData { get; set; }
		[Ordinal(9)] [RED("animSRRefId")] public scnRidCameraAnimationSRRefId AnimSRRefId { get; set; }
		[Ordinal(10)] [RED("animOriginMarker")] public scnMarker AnimOriginMarker { get; set; }
		[Ordinal(11)] [RED("activateAsGameCamera")] public CBool ActivateAsGameCamera { get; set; }
		[Ordinal(12)] [RED("controlRenderToTextureState")] public CBool ControlRenderToTextureState { get; set; }

		public scneventsPlayRidCameraAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
