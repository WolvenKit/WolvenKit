using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiTooltipSlotData : inkUserData
	{
		[Ordinal(0)]  [RED("margin")] public inkMargin Margin { get; set; }
		[Ordinal(1)]  [RED("placement")] public CEnum<gameuiETooltipPlacement> Placement { get; set; }

		public gameuiTooltipSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
