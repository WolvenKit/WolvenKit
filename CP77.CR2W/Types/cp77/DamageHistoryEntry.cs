using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DamageHistoryEntry : CVariable
	{
		[Ordinal(0)] [RED("hitEvent")] public CHandle<gameeventsHitEvent> HitEvent { get; set; }
		[Ordinal(1)] [RED("totalDamageReceived")] public CFloat TotalDamageReceived { get; set; }
		[Ordinal(2)] [RED("frameReceived")] public CUInt64 FrameReceived { get; set; }
		[Ordinal(3)] [RED("timestamp")] public CFloat Timestamp { get; set; }
		[Ordinal(4)] [RED("healthAtTheTime")] public CFloat HealthAtTheTime { get; set; }
		[Ordinal(5)] [RED("source")] public wCHandle<gameObject> Source { get; set; }
		[Ordinal(6)] [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public DamageHistoryEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
