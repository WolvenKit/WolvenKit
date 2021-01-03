using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectDefinition : CVariable
	{
		[Ordinal(0)]  [RED("debugSettings")] public gameEffectDebugSettings DebugSettings { get; set; }
		[Ordinal(1)]  [RED("durationModifiers")] public CArray<CHandle<gameEffectDurationModifier>> DurationModifiers { get; set; }
		[Ordinal(2)]  [RED("effectExecutors")] public CArray<CHandle<gameEffectExecutor>> EffectExecutors { get; set; }
		[Ordinal(3)]  [RED("noTargetsActions")] public CArray<CHandle<gameEffectAction>> NoTargetsActions { get; set; }
		[Ordinal(4)]  [RED("objectFilters")] public CArray<CHandle<gameEffectObjectFilter>> ObjectFilters { get; set; }
		[Ordinal(5)]  [RED("objectProviders")] public CArray<CHandle<gameEffectObjectProvider>> ObjectProviders { get; set; }
		[Ordinal(6)]  [RED("postActions")] public CArray<CHandle<gameEffectPostAction>> PostActions { get; set; }
		[Ordinal(7)]  [RED("preActions")] public CArray<CHandle<gameEffectPreAction>> PreActions { get; set; }
		[Ordinal(8)]  [RED("settings")] public gameEffectSettings Settings { get; set; }
		[Ordinal(9)]  [RED("tag")] public CName Tag { get; set; }

		public gameEffectDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
