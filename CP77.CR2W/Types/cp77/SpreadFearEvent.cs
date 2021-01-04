using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SpreadFearEvent : redEvent
	{
		[Ordinal(0)]  [RED("phase")] public CInt32 Phase { get; set; }
		[Ordinal(1)]  [RED("player")] public CBool Player { get; set; }

		public SpreadFearEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
