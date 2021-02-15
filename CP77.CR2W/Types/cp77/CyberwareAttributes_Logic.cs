using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributes_Logic : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("textValue")] public inkTextWidgetReference TextValue { get; set; }
		[Ordinal(2)] [RED("buttonRef")] public inkWidgetReference ButtonRef { get; set; }
		[Ordinal(3)] [RED("tooltipRef")] public inkWidgetReference TooltipRef { get; set; }
		[Ordinal(4)] [RED("connectorRef")] public inkWidgetReference ConnectorRef { get; set; }

		public CyberwareAttributes_Logic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
