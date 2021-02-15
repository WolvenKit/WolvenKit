using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipRequirementsModule : ItemTooltipModuleController
	{
		[Ordinal(2)] [RED("levelRequirementsWrapper")] public inkWidgetReference LevelRequirementsWrapper { get; set; }
		[Ordinal(3)] [RED("strenghtOrReflexWrapper")] public inkWidgetReference StrenghtOrReflexWrapper { get; set; }
		[Ordinal(4)] [RED("smartlinkGunWrapper")] public inkWidgetReference SmartlinkGunWrapper { get; set; }
		[Ordinal(5)] [RED("anyAttributeWrapper")] public inkWidgetReference AnyAttributeWrapper { get; set; }
		[Ordinal(6)] [RED("levelRequirementsText")] public inkTextWidgetReference LevelRequirementsText { get; set; }
		[Ordinal(7)] [RED("strenghtOrReflexText")] public inkTextWidgetReference StrenghtOrReflexText { get; set; }
		[Ordinal(8)] [RED("anyAttributeText")] public inkTextWidgetReference AnyAttributeText { get; set; }

		public ItemTooltipRequirementsModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
