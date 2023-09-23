using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerDeviceBodyGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("networkStatusText")] 
		public inkTextWidgetReference NetworkStatusText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("deviceAuthorizationText")] 
		public inkTextWidgetReference DeviceAuthorizationText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("deviceAuthorizationRow")] 
		public inkCompoundWidgetReference DeviceAuthorizationRow
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("networkStatusRow")] 
		public inkCompoundWidgetReference NetworkStatusRow
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("networkStatusCallbackID")] 
		public CHandle<redCallbackObject> NetworkStatusCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("deviceAuthorizationCallbackID")] 
		public CHandle<redCallbackObject> DeviceAuthorizationCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("isValidnetworkStatus")] 
		public CBool IsValidnetworkStatus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("isValidDeviceAuthorization")] 
		public CBool IsValidDeviceAuthorization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScannerDeviceBodyGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
