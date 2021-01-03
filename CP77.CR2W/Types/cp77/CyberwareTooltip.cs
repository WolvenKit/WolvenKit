using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CyberwareTooltip : AGenericTooltipController
	{
		[Ordinal(0)]  [RED("data")] public CHandle<CyberwareTooltipData> Data { get; set; }
		[Ordinal(1)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(2)]  [RED("slotList")] public inkCompoundWidgetReference SlotList { get; set; }

		public CyberwareTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
