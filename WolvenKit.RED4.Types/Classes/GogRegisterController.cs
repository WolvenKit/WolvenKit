using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GogRegisterController : gameuiBaseGOGRegisterController
	{
		private inkWidgetReference _linkWidget;
		private inkWidgetReference _qrImageWidget;

		[Ordinal(1)] 
		[RED("linkWidget")] 
		public inkWidgetReference LinkWidget
		{
			get => GetProperty(ref _linkWidget);
			set => SetProperty(ref _linkWidget, value);
		}

		[Ordinal(2)] 
		[RED("qrImageWidget")] 
		public inkWidgetReference QrImageWidget
		{
			get => GetProperty(ref _qrImageWidget);
			set => SetProperty(ref _qrImageWidget, value);
		}
	}
}
