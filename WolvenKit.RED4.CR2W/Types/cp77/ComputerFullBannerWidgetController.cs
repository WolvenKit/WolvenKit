using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerFullBannerWidgetController : ComputerBannerWidgetController
	{
		[Ordinal(12)] [RED("closeButtonWidget")] public inkWidgetReference CloseButtonWidget { get; set; }

		public ComputerFullBannerWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
