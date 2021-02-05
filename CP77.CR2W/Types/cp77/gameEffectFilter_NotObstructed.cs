using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectFilter_NotObstructed : gameEffectObjectSingleFilter
	{
		[Ordinal(0)]  [RED("forwardOffset")] public CFloat ForwardOffset { get; set; }
		[Ordinal(1)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }

		public gameEffectFilter_NotObstructed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
