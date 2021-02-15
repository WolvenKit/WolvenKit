using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerLevel : ScannerChunk
	{
		[Ordinal(0)] [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(1)] [RED("isHard")] public CBool IsHard { get; set; }

		public ScannerLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
