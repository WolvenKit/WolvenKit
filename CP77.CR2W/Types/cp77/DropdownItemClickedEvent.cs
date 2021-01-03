using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DropdownItemClickedEvent : redEvent
	{
		[Ordinal(0)]  [RED("identifier")] public CVariant Identifier { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<IScriptable> Owner { get; set; }
		[Ordinal(2)]  [RED("triggerButton")] public wCHandle<DropdownButtonController> TriggerButton { get; set; }

		public DropdownItemClickedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
