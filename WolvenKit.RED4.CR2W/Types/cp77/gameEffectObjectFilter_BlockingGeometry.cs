using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_BlockingGeometry : gameEffectObjectGroupFilter
	{
		[Ordinal(0)] [RED("inclusive")] public CBool Inclusive { get; set; }
		[Ordinal(1)] [RED("sortQueryResultsByDistance")] public CBool SortQueryResultsByDistance { get; set; }

		public gameEffectObjectFilter_BlockingGeometry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
