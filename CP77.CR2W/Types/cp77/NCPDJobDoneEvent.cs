using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NCPDJobDoneEvent : redEvent
	{
		[Ordinal(0)]  [RED("levelXPAwarded")] public CInt32 LevelXPAwarded { get; set; }
		[Ordinal(1)]  [RED("streetCredXPAwarded")] public CInt32 StreetCredXPAwarded { get; set; }

		public NCPDJobDoneEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
