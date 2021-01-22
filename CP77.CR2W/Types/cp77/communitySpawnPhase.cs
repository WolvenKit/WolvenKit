using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class communitySpawnPhase : ISerializable
	{
		[Ordinal(0)]  [RED("alwaysSpawned")] public CEnum<gameAlwaysSpawnedState> AlwaysSpawned { get; set; }
		[Ordinal(1)]  [RED("appearances")] public CArray<CName> Appearances { get; set; }
		[Ordinal(2)]  [RED("phaseName")] public CName PhaseName { get; set; }
		[Ordinal(3)]  [RED("prefetchAppearance")] public CBool PrefetchAppearance { get; set; }
		[Ordinal(4)]  [RED("timePeriods")] public CArray<communityPhaseTimePeriod> TimePeriods { get; set; }

		public communitySpawnPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
