using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SThumbnailWidgetPackage : SWidgetPackage
	{
		[Ordinal(18)] 
		[RED("thumbnailAction")] 
		public CHandle<ThumbnailUI> ThumbnailAction
		{
			get => GetPropertyValue<CHandle<ThumbnailUI>>();
			set => SetPropertyValue<CHandle<ThumbnailUI>>(value);
		}

		[Ordinal(19)] 
		[RED("deviceStatus")] 
		public CString DeviceStatus
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SThumbnailWidgetPackage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
