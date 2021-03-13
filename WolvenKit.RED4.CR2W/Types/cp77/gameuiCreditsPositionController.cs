using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsPositionController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("titleText")] public inkTextWidgetReference TitleText { get; set; }
		[Ordinal(2)] [RED("namesText")] public inkTextWidgetReference NamesText { get; set; }

		public gameuiCreditsPositionController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
