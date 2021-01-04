using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entSpawnEffectEvent : redEvent
	{
		[Ordinal(0)]  [RED("blackboard")] public CHandle<worldEffectBlackboard> Blackboard { get; set; }
		[Ordinal(1)]  [RED("breakAllLoops")] public CBool BreakAllLoops { get; set; }
		[Ordinal(2)]  [RED("breakAllOnDestroy")] public CBool BreakAllOnDestroy { get; set; }
		[Ordinal(3)]  [RED("e3hackDeferCount")] public CUInt32 E3hackDeferCount { get; set; }
		[Ordinal(4)]  [RED("effectInstanceName")] public CName EffectInstanceName { get; set; }
		[Ordinal(5)]  [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(6)]  [RED("idForRandomizedEffect")] public CRUID IdForRandomizedEffect { get; set; }
		[Ordinal(7)]  [RED("persistOnDetach")] public CBool PersistOnDetach { get; set; }

		public entSpawnEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
