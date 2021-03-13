using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_OnlyNearest : gameEffectObjectGroupFilter
	{
		[Ordinal(0)] [RED("count")] public CUInt32 Count { get; set; }

		public gameEffectObjectFilter_OnlyNearest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
