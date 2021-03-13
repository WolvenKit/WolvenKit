using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareTooltip : AGenericTooltipController
	{
		[Ordinal(2)] [RED("slotList")] public inkCompoundWidgetReference SlotList { get; set; }
		[Ordinal(3)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(4)] [RED("data")] public CHandle<CyberwareTooltipData> Data { get; set; }

		public CyberwareTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
