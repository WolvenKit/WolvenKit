using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRequestNewHudEvent : redEvent
	{
		[Ordinal(0)] [RED("entriesResource")] public rRef<inkHudEntriesResource> EntriesResource { get; set; }

		public inkRequestNewHudEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
