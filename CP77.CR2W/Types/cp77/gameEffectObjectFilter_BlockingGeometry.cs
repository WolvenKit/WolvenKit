using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_BlockingGeometry : gameEffectObjectGroupFilter
	{
		[Ordinal(0)]  [RED("inclusive")] public CBool Inclusive { get; set; }
		[Ordinal(1)]  [RED("sortQueryResultsByDistance")] public CBool SortQueryResultsByDistance { get; set; }

		public gameEffectObjectFilter_BlockingGeometry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
