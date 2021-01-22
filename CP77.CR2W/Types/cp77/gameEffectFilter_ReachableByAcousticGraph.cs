using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectFilter_ReachableByAcousticGraph : gameEffectObjectSingleFilter
	{
		[Ordinal(0)]  [RED("maxPathLength")] public gameEffectInputParameter_Float MaxPathLength { get; set; }

		public gameEffectFilter_ReachableByAcousticGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
