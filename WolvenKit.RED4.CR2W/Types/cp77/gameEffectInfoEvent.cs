using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectInfoEvent : redEvent
	{
		[Ordinal(0)] [RED("tag")] public CString Tag { get; set; }
		[Ordinal(1)] [RED("entitiesGathered")] public CUInt32 EntitiesGathered { get; set; }
		[Ordinal(2)] [RED("entitiesFiltered")] public CUInt32 EntitiesFiltered { get; set; }
		[Ordinal(3)] [RED("entitiesProcessed")] public CUInt32 EntitiesProcessed { get; set; }

		public gameEffectInfoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
