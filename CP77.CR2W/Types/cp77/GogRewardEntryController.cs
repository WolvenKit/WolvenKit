using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GogRewardEntryController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("descriptionWidget")] public inkWidgetReference DescriptionWidget { get; set; }
		[Ordinal(1)]  [RED("iconImage")] public inkImageWidgetReference IconImage { get; set; }
		[Ordinal(2)]  [RED("nameWidget")] public inkWidgetReference NameWidget { get; set; }

		public GogRewardEntryController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
