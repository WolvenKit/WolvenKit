using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributes_ResistancesStruct : CVariable
	{
		[Ordinal(0)] [RED("widgetHealth")] public inkFlexWidgetReference WidgetHealth { get; set; }
		[Ordinal(1)] [RED("widgetPhysical")] public inkFlexWidgetReference WidgetPhysical { get; set; }
		[Ordinal(2)] [RED("widgetThermal")] public inkFlexWidgetReference WidgetThermal { get; set; }
		[Ordinal(3)] [RED("widgetEMP")] public inkFlexWidgetReference WidgetEMP { get; set; }
		[Ordinal(4)] [RED("widgetChemical")] public inkFlexWidgetReference WidgetChemical { get; set; }
		[Ordinal(5)] [RED("resistanceTooltip")] public inkFlexWidgetReference ResistanceTooltip { get; set; }

		public CyberwareAttributes_ResistancesStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
