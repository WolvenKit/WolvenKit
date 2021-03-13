using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DrillerUIEvent : redEvent
	{
		[Ordinal(0)] [RED("actionChosen")] public gameinteractionsChoice ActionChosen { get; set; }
		[Ordinal(1)] [RED("activator")] public wCHandle<gameObject> Activator { get; set; }

		public DrillerUIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
