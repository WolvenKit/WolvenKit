using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectInfoEvent : redEvent
	{
		[Ordinal(0)]  [RED("entitiesFiltered")] public CUInt32 EntitiesFiltered { get; set; }
		[Ordinal(1)]  [RED("entitiesGathered")] public CUInt32 EntitiesGathered { get; set; }
		[Ordinal(2)]  [RED("entitiesProcessed")] public CUInt32 EntitiesProcessed { get; set; }
		[Ordinal(3)]  [RED("tag")] public CString Tag { get; set; }

		public gameEffectInfoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
