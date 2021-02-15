using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SurveillanceCameraControllerPS : SensorDeviceControllerPS
	{
		[Ordinal(144)] [RED("cameraProperties")] public CameraSetup CameraProperties { get; set; }
		[Ordinal(145)] [RED("cameraQuestProperties")] public CameraQuestProperties CameraQuestProperties { get; set; }
		[Ordinal(146)] [RED("cameraState")] public CEnum<ESurveillanceCameraStatus> CameraState { get; set; }
		[Ordinal(147)] [RED("shouldStream")] public CBool ShouldStream { get; set; }
		[Ordinal(148)] [RED("isDetecting")] public CBool IsDetecting { get; set; }
		[Ordinal(149)] [RED("feedReceivers")] public CArray<entEntityID> FeedReceivers { get; set; }
		[Ordinal(150)] [RED("mostRecentRequester")] public entEntityID MostRecentRequester { get; set; }
		[Ordinal(151)] [RED("virtualComponentName")] public CName VirtualComponentName { get; set; }
		[Ordinal(152)] [RED("isFeedReplacedWithBink")] public CBool IsFeedReplacedWithBink { get; set; }
		[Ordinal(153)] [RED("binkVideoPath")] public redResourceReferenceScriptToken BinkVideoPath { get; set; }
		[Ordinal(154)] [RED("shouldRevealEnemies")] public CBool ShouldRevealEnemies { get; set; }
		[Ordinal(155)] [RED("cameraSkillChecks")] public CHandle<EngDemoContainer> CameraSkillChecks { get; set; }

		public SurveillanceCameraControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
