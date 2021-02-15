using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DropdownItemClickedEvent : redEvent
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<IScriptable> Owner { get; set; }
		[Ordinal(1)] [RED("triggerButton")] public wCHandle<DropdownButtonController> TriggerButton { get; set; }
		[Ordinal(2)] [RED("identifier")] public CVariant Identifier { get; set; }

		public DropdownItemClickedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
