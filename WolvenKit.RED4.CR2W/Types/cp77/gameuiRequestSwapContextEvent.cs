using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRequestSwapContextEvent : redEvent
	{
		[Ordinal(0)] [RED("oldContext")] public CEnum<UIGameContext> OldContext { get; set; }
		[Ordinal(1)] [RED("newContext")] public CEnum<UIGameContext> NewContext { get; set; }

		public gameuiRequestSwapContextEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
