using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerFullBannerWidgetController : ComputerBannerWidgetController
	{
		[Ordinal(11)]  [RED("closeButtonWidget")] public inkWidgetReference CloseButtonWidget { get; set; }

		public ComputerFullBannerWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
