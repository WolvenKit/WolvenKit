using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class panelApperanceSwitchEvent : redEvent
	{
		[Ordinal(0)]  [RED("newApperance")] public CName NewApperance { get; set; }

		public panelApperanceSwitchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
