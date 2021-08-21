using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerDeviceBodyGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _networkStatusText;
		private inkTextWidgetReference _deviceAuthorizationText;
		private inkCompoundWidgetReference _deviceAuthorizationRow;
		private inkCompoundWidgetReference _networkStatusRow;
		private CHandle<redCallbackObject> _networkStatusCallbackID;
		private CHandle<redCallbackObject> _deviceAuthorizationCallbackID;
		private CBool _isValidnetworkStatus;
		private CBool _isValidDeviceAuthorization;

		[Ordinal(5)] 
		[RED("networkStatusText")] 
		public inkTextWidgetReference NetworkStatusText
		{
			get => GetProperty(ref _networkStatusText);
			set => SetProperty(ref _networkStatusText, value);
		}

		[Ordinal(6)] 
		[RED("deviceAuthorizationText")] 
		public inkTextWidgetReference DeviceAuthorizationText
		{
			get => GetProperty(ref _deviceAuthorizationText);
			set => SetProperty(ref _deviceAuthorizationText, value);
		}

		[Ordinal(7)] 
		[RED("deviceAuthorizationRow")] 
		public inkCompoundWidgetReference DeviceAuthorizationRow
		{
			get => GetProperty(ref _deviceAuthorizationRow);
			set => SetProperty(ref _deviceAuthorizationRow, value);
		}

		[Ordinal(8)] 
		[RED("networkStatusRow")] 
		public inkCompoundWidgetReference NetworkStatusRow
		{
			get => GetProperty(ref _networkStatusRow);
			set => SetProperty(ref _networkStatusRow, value);
		}

		[Ordinal(9)] 
		[RED("networkStatusCallbackID")] 
		public CHandle<redCallbackObject> NetworkStatusCallbackID
		{
			get => GetProperty(ref _networkStatusCallbackID);
			set => SetProperty(ref _networkStatusCallbackID, value);
		}

		[Ordinal(10)] 
		[RED("deviceAuthorizationCallbackID")] 
		public CHandle<redCallbackObject> DeviceAuthorizationCallbackID
		{
			get => GetProperty(ref _deviceAuthorizationCallbackID);
			set => SetProperty(ref _deviceAuthorizationCallbackID, value);
		}

		[Ordinal(11)] 
		[RED("isValidnetworkStatus")] 
		public CBool IsValidnetworkStatus
		{
			get => GetProperty(ref _isValidnetworkStatus);
			set => SetProperty(ref _isValidnetworkStatus, value);
		}

		[Ordinal(12)] 
		[RED("isValidDeviceAuthorization")] 
		public CBool IsValidDeviceAuthorization
		{
			get => GetProperty(ref _isValidDeviceAuthorization);
			set => SetProperty(ref _isValidDeviceAuthorization, value);
		}

		public ScannerDeviceBodyGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
