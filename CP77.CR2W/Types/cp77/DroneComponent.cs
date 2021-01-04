using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DroneComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("currentLocomotionWrapper")] public CName CurrentLocomotionWrapper { get; set; }
		[Ordinal(1)]  [RED("currentScanAnimation")] public CName CurrentScanAnimation { get; set; }
		[Ordinal(2)]  [RED("currentScanEffect")] public CHandle<gameEffectInstance> CurrentScanEffect { get; set; }
		[Ordinal(3)]  [RED("currentScanType")] public CEnum<MechanicalScanType> CurrentScanType { get; set; }
		[Ordinal(4)]  [RED("highLevelCb")] public CUInt32 HighLevelCb { get; set; }
		[Ordinal(5)]  [RED("isDetectionScanning")] public CBool IsDetectionScanning { get; set; }
		[Ordinal(6)]  [RED("npcCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcCollisionComponent { get; set; }
		[Ordinal(7)]  [RED("playerOnlyCollisionComponent")] public CHandle<entSimpleColliderComponent> PlayerOnlyCollisionComponent { get; set; }
		[Ordinal(8)]  [RED("senseComponent")] public CHandle<senseComponent> SenseComponent { get; set; }
		[Ordinal(9)]  [RED("trackedTarget")] public wCHandle<gameObject> TrackedTarget { get; set; }

		public DroneComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
