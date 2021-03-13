using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiContextChangedEvent : redEvent
	{
		[Ordinal(0)] [RED("oldContext")] public CEnum<gameuiContext> OldContext { get; set; }
		[Ordinal(1)] [RED("newContext")] public CEnum<gameuiContext> NewContext { get; set; }

		public gameuiContextChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
