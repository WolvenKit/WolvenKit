using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributes_Logic : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("buttonRef")] public inkWidgetReference ButtonRef { get; set; }
		[Ordinal(1)]  [RED("connectorRef")] public inkWidgetReference ConnectorRef { get; set; }
		[Ordinal(2)]  [RED("textValue")] public inkTextWidgetReference TextValue { get; set; }
		[Ordinal(3)]  [RED("tooltipRef")] public inkWidgetReference TooltipRef { get; set; }

		public CyberwareAttributes_Logic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
