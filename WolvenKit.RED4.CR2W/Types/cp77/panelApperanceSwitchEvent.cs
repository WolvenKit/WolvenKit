using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class panelApperanceSwitchEvent : redEvent
	{
		[Ordinal(0)] [RED("newApperance")] public CName NewApperance { get; set; }

		public panelApperanceSwitchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
