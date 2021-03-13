using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SpawnLaserAttackEvent : redEvent
	{
		[Ordinal(0)] [RED("attackRecord")] public CHandle<gamedataAttack_Record> AttackRecord { get; set; }
		[Ordinal(1)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(4)] [RED("playSlotAnimation")] public CBool PlaySlotAnimation { get; set; }

		public SpawnLaserAttackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
