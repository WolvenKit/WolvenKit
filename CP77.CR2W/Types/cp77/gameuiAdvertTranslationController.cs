using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiAdvertTranslationController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("advertText")] public inkTextWidgetReference AdvertText { get; set; }

		public gameuiAdvertTranslationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
