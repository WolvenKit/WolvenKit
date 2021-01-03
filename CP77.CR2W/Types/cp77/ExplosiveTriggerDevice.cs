using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ExplosiveTriggerDevice : ExplosiveDevice
	{
		[Ordinal(0)]  [RED("meshTrigger")] public CHandle<entMeshComponent> MeshTrigger { get; set; }
		[Ordinal(1)]  [RED("playerIsInSurroundingArea")] public CBool PlayerIsInSurroundingArea { get; set; }
		[Ordinal(2)]  [RED("proximityExplosionEventID")] public gameDelayID ProximityExplosionEventID { get; set; }
		[Ordinal(3)]  [RED("proximityExplosionEventSent")] public CBool ProximityExplosionEventSent { get; set; }
		[Ordinal(4)]  [RED("soundIsActive")] public CBool SoundIsActive { get; set; }
		[Ordinal(5)]  [RED("surroundingArea")] public CHandle<gameStaticTriggerAreaComponent> SurroundingArea { get; set; }
		[Ordinal(6)]  [RED("surroundingAreaName")] public CName SurroundingAreaName { get; set; }
		[Ordinal(7)]  [RED("trapTrigger")] public CHandle<gameStaticTriggerAreaComponent> TrapTrigger { get; set; }
		[Ordinal(8)]  [RED("triggerName")] public CName TriggerName { get; set; }

		public ExplosiveTriggerDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
