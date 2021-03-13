using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkHoverOutEvent : redEvent
	{
		[Ordinal(0)] [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(1)] [RED("perkData")] public CHandle<BasePerkDisplayData> PerkData { get; set; }

		public PerkHoverOutEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
