using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TooltipWidgetReference : CVariable
	{
		[Ordinal(0)] [RED("identifier")] public CName Identifier { get; set; }
		[Ordinal(1)] [RED("widgetLibraryReference")] public inkWidgetLibraryReference WidgetLibraryReference { get; set; }

		public TooltipWidgetReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
