using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SurveillanceCameraControllerPS : SensorDeviceControllerPS
	{
		[Ordinal(0)]  [RED("binkVideoPath")] public redResourceReferenceScriptToken BinkVideoPath { get; set; }
		[Ordinal(1)]  [RED("cameraProperties")] public CameraSetup CameraProperties { get; set; }
		[Ordinal(2)]  [RED("cameraQuestProperties")] public CameraQuestProperties CameraQuestProperties { get; set; }
		[Ordinal(3)]  [RED("cameraSkillChecks")] public CHandle<EngDemoContainer> CameraSkillChecks { get; set; }
		[Ordinal(4)]  [RED("cameraState")] public CEnum<ESurveillanceCameraStatus> CameraState { get; set; }
		[Ordinal(5)]  [RED("feedReceivers")] public CArray<entEntityID> FeedReceivers { get; set; }
		[Ordinal(6)]  [RED("isDetecting")] public CBool IsDetecting { get; set; }
		[Ordinal(7)]  [RED("isFeedReplacedWithBink")] public CBool IsFeedReplacedWithBink { get; set; }
		[Ordinal(8)]  [RED("mostRecentRequester")] public entEntityID MostRecentRequester { get; set; }
		[Ordinal(9)]  [RED("shouldRevealEnemies")] public CBool ShouldRevealEnemies { get; set; }
		[Ordinal(10)]  [RED("shouldStream")] public CBool ShouldStream { get; set; }
		[Ordinal(11)]  [RED("virtualComponentName")] public CName VirtualComponentName { get; set; }

		public SurveillanceCameraControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
