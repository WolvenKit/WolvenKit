using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLogger : CVariable
	{
		[Ordinal(0)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)]  [RED("entries")] public CArray<CHandle<animPoseInfoLoggerEntry>> Entries { get; set; }
		[Ordinal(2)]  [RED("showStackTracksCount")] public CBool ShowStackTracksCount { get; set; }
		[Ordinal(3)]  [RED("showStackTransformsCount")] public CBool ShowStackTransformsCount { get; set; }

		public animPoseInfoLogger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
