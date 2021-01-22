using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItem : effectBaseItem
	{
		[Ordinal(0)]  [RED("ruid")] public CRUID Ruid { get; set; }
		[Ordinal(1)]  [RED("timeBegin")] public CFloat TimeBegin { get; set; }
		[Ordinal(2)]  [RED("timeDuration")] public CFloat TimeDuration { get; set; }

		public effectTrackItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
