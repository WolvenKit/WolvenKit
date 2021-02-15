using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TooltipWidgetStyledReference : CVariable
	{
		[Ordinal(0)] [RED("identifier")] public CName Identifier { get; set; }
		[Ordinal(1)] [RED("widgetLibraryReference")] public inkWidgetLibraryReference WidgetLibraryReference { get; set; }
		[Ordinal(2)] [RED("menuTooltipStylePath")] public redResourceReferenceScriptToken MenuTooltipStylePath { get; set; }
		[Ordinal(3)] [RED("hudTooltipStylePath")] public redResourceReferenceScriptToken HudTooltipStylePath { get; set; }

		public TooltipWidgetStyledReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
