using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipRequirementsModule : ItemTooltipModuleController
	{
		[Ordinal(0)]  [RED("anyAttributeText")] public inkTextWidgetReference AnyAttributeText { get; set; }
		[Ordinal(1)]  [RED("anyAttributeWrapper")] public inkWidgetReference AnyAttributeWrapper { get; set; }
		[Ordinal(2)]  [RED("levelRequirementsText")] public inkTextWidgetReference LevelRequirementsText { get; set; }
		[Ordinal(3)]  [RED("levelRequirementsWrapper")] public inkWidgetReference LevelRequirementsWrapper { get; set; }
		[Ordinal(4)]  [RED("smartlinkGunWrapper")] public inkWidgetReference SmartlinkGunWrapper { get; set; }
		[Ordinal(5)]  [RED("strenghtOrReflexText")] public inkTextWidgetReference StrenghtOrReflexText { get; set; }
		[Ordinal(6)]  [RED("strenghtOrReflexWrapper")] public inkWidgetReference StrenghtOrReflexWrapper { get; set; }

		public ItemTooltipRequirementsModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
