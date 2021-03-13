using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communitySpawnPhase : ISerializable
	{
		[Ordinal(0)] [RED("phaseName")] public CName PhaseName { get; set; }
		[Ordinal(1)] [RED("appearances")] public CArray<CName> Appearances { get; set; }
		[Ordinal(2)] [RED("timePeriods")] public CArray<communityPhaseTimePeriod> TimePeriods { get; set; }
		[Ordinal(3)] [RED("alwaysSpawned")] public CEnum<gameAlwaysSpawnedState> AlwaysSpawned { get; set; }
		[Ordinal(4)] [RED("prefetchAppearance")] public CBool PrefetchAppearance { get; set; }

		public communitySpawnPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
