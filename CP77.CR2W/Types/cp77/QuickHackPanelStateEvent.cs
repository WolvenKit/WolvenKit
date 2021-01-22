using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickHackPanelStateEvent : redEvent
	{
		[Ordinal(0)]  [RED("isOpened")] public CBool IsOpened { get; set; }

		public QuickHackPanelStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
