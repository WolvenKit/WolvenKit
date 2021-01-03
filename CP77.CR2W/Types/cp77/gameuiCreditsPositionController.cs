using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsPositionController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("namesText")] public inkTextWidgetReference NamesText { get; set; }
		[Ordinal(1)]  [RED("titleText")] public inkTextWidgetReference TitleText { get; set; }

		public gameuiCreditsPositionController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
