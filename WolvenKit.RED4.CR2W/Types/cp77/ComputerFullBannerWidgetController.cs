using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerFullBannerWidgetController : ComputerBannerWidgetController
	{
		private inkWidgetReference _closeButtonWidget;

		[Ordinal(12)] 
		[RED("closeButtonWidget")] 
		public inkWidgetReference CloseButtonWidget
		{
			get => GetProperty(ref _closeButtonWidget);
			set => SetProperty(ref _closeButtonWidget, value);
		}

		public ComputerFullBannerWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
