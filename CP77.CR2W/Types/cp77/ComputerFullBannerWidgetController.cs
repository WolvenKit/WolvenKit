using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ComputerFullBannerWidgetController : ComputerBannerWidgetController
	{
		[Ordinal(0)]  [RED("closeButtonWidget")] public inkWidgetReference CloseButtonWidget { get; set; }

		public ComputerFullBannerWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
