using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ExplosiveTriggerDevice : ExplosiveDevice
	{
		[Ordinal(107)]  [RED("meshTrigger")] public CHandle<entMeshComponent> MeshTrigger { get; set; }
		[Ordinal(108)]  [RED("trapTrigger")] public CHandle<gameStaticTriggerAreaComponent> TrapTrigger { get; set; }
		[Ordinal(109)]  [RED("triggerName")] public CName TriggerName { get; set; }
		[Ordinal(110)]  [RED("surroundingArea")] public CHandle<gameStaticTriggerAreaComponent> SurroundingArea { get; set; }
		[Ordinal(111)]  [RED("surroundingAreaName")] public CName SurroundingAreaName { get; set; }
		[Ordinal(112)]  [RED("soundIsActive")] public CBool SoundIsActive { get; set; }
		[Ordinal(113)]  [RED("playerIsInSurroundingArea")] public CBool PlayerIsInSurroundingArea { get; set; }
		[Ordinal(114)]  [RED("proximityExplosionEventID")] public gameDelayID ProximityExplosionEventID { get; set; }
		[Ordinal(115)]  [RED("proximityExplosionEventSent")] public CBool ProximityExplosionEventSent { get; set; }

		public ExplosiveTriggerDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
