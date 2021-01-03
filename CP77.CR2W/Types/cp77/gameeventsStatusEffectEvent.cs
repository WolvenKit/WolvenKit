using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameeventsStatusEffectEvent : redEvent
	{
		[Ordinal(0)]  [RED("stackCount")] public CUInt32 StackCount { get; set; }
		[Ordinal(1)]  [RED("staticData")] public CHandle<gamedataStatusEffect_Record> StaticData { get; set; }

		public gameeventsStatusEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
