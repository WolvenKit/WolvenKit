using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsStatusEffectEvent : redEvent
	{
		[Ordinal(0)] [RED("staticData")] public CHandle<gamedataStatusEffect_Record> StaticData { get; set; }
		[Ordinal(1)] [RED("stackCount")] public CUInt32 StackCount { get; set; }

		public gameeventsStatusEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
