using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPlayerLookAt_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(2)]  [RED("offsetPos")] public Vector3 OffsetPos { get; set; }
		[Ordinal(3)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(4)]  [RED("adjustPitch")] public CBool AdjustPitch { get; set; }
		[Ordinal(5)]  [RED("adjustYaw")] public CBool AdjustYaw { get; set; }
		[Ordinal(6)]  [RED("endOnTargetReached")] public CBool EndOnTargetReached { get; set; }
		[Ordinal(7)]  [RED("endOnCameraInputApplied")] public CBool EndOnCameraInputApplied { get; set; }
		[Ordinal(8)]  [RED("endOnTimeExceeded")] public CBool EndOnTimeExceeded { get; set; }
		[Ordinal(9)]  [RED("cameraInputMagToBreak")] public CFloat CameraInputMagToBreak { get; set; }
		[Ordinal(10)]  [RED("precision")] public CFloat Precision { get; set; }
		[Ordinal(11)]  [RED("maxDuration")] public CFloat MaxDuration { get; set; }
		[Ordinal(12)]  [RED("easeIn")] public CBool EaseIn { get; set; }
		[Ordinal(13)]  [RED("easeOut")] public CBool EaseOut { get; set; }

		public questPlayerLookAt_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
