using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreRecord : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("nameWidget")] public inkTextWidgetReference NameWidget { get; set; }
		[Ordinal(1)]  [RED("scoreWidget")] public inkTextWidgetReference ScoreWidget { get; set; }

		public gameuiPanzerScoreRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
