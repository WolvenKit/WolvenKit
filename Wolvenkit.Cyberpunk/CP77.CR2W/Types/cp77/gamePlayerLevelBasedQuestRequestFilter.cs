using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePlayerLevelBasedQuestRequestFilter : gameCustomRequestFilter
	{
		[Ordinal(0)]  [RED("percentMargin")] public CUInt32 PercentMargin { get; set; }

		public gamePlayerLevelBasedQuestRequestFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
