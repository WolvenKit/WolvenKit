using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectDefinition : CVariable
	{
		[Ordinal(0)]  [RED("tag")] public CName Tag { get; set; }
		[Ordinal(1)]  [RED("objectProviders")] public CArray<CHandle<gameEffectObjectProvider>> ObjectProviders { get; set; }
		[Ordinal(2)]  [RED("objectFilters")] public CArray<CHandle<gameEffectObjectFilter>> ObjectFilters { get; set; }
		[Ordinal(3)]  [RED("effectExecutors")] public CArray<CHandle<gameEffectExecutor>> EffectExecutors { get; set; }
		[Ordinal(4)]  [RED("durationModifiers")] public CArray<CHandle<gameEffectDurationModifier>> DurationModifiers { get; set; }
		[Ordinal(5)]  [RED("preActions")] public CArray<CHandle<gameEffectPreAction>> PreActions { get; set; }
		[Ordinal(6)]  [RED("postActions")] public CArray<CHandle<gameEffectPostAction>> PostActions { get; set; }
		[Ordinal(7)]  [RED("noTargetsActions")] public CArray<CHandle<gameEffectAction>> NoTargetsActions { get; set; }
		[Ordinal(8)]  [RED("settings")] public gameEffectSettings Settings { get; set; }
		[Ordinal(9)]  [RED("debugSettings")] public gameEffectDebugSettings DebugSettings { get; set; }

		public gameEffectDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
