using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTooltipSlotData : inkUserData
	{
		[Ordinal(0)] [RED("margin")] public inkMargin Margin { get; set; }
		[Ordinal(1)] [RED("placement")] public CEnum<gameuiETooltipPlacement> Placement { get; set; }

		public gameuiTooltipSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
