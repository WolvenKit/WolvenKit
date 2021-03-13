using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DroneComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("senseComponent")] public CHandle<senseComponent> SenseComponent { get; set; }
		[Ordinal(6)] [RED("npcCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcCollisionComponent { get; set; }
		[Ordinal(7)] [RED("playerOnlyCollisionComponent")] public CHandle<entSimpleColliderComponent> PlayerOnlyCollisionComponent { get; set; }
		[Ordinal(8)] [RED("highLevelCb")] public CUInt32 HighLevelCb { get; set; }
		[Ordinal(9)] [RED("currentScanType")] public CEnum<MechanicalScanType> CurrentScanType { get; set; }
		[Ordinal(10)] [RED("currentScanEffect")] public CHandle<gameEffectInstance> CurrentScanEffect { get; set; }
		[Ordinal(11)] [RED("currentScanAnimation")] public CName CurrentScanAnimation { get; set; }
		[Ordinal(12)] [RED("isDetectionScanning")] public CBool IsDetectionScanning { get; set; }
		[Ordinal(13)] [RED("trackedTarget")] public wCHandle<gameObject> TrackedTarget { get; set; }
		[Ordinal(14)] [RED("currentLocomotionWrapper")] public CName CurrentLocomotionWrapper { get; set; }

		public DroneComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
