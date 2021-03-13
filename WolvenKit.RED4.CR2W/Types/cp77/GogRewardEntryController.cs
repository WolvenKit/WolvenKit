using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GogRewardEntryController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("nameWidget")] public inkWidgetReference NameWidget { get; set; }
		[Ordinal(2)] [RED("descriptionWidget")] public inkWidgetReference DescriptionWidget { get; set; }
		[Ordinal(3)] [RED("iconImage")] public inkImageWidgetReference IconImage { get; set; }

		public GogRewardEntryController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
