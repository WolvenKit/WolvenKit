using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialAreaSpawnEvent : redEvent
	{
		[Ordinal(0)]  [RED("areaID")] public CUInt32 AreaID { get; set; }
		[Ordinal(1)]  [RED("bracketID")] public CName BracketID { get; set; }
		[Ordinal(2)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }

		public gameuiTutorialAreaSpawnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
