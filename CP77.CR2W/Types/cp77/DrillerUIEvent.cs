using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DrillerUIEvent : redEvent
	{
		[Ordinal(0)]  [RED("actionChosen")] public gameinteractionsChoice ActionChosen { get; set; }
		[Ordinal(1)]  [RED("activator")] public wCHandle<gameObject> Activator { get; set; }

		public DrillerUIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
