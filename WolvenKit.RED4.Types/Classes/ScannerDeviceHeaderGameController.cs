using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerDeviceHeaderGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _nameText;
		private inkTextWidgetReference _fluffText;
		private inkRectangleWidgetReference _separator1;
		private inkRectangleWidgetReference _separator2;
		private inkTextWidgetReference _levelText;
		private inkTextWidgetReference _status;
		private inkImageWidgetReference _statusIcon;
		private inkWidgetReference _levelWrapper;
		private CHandle<redCallbackObject> _nameCallbackID;
		private CHandle<redCallbackObject> _networkLevelCallbackID;
		private CHandle<redCallbackObject> _networkStatusCallbackID;
		private CHandle<redCallbackObject> _deviceStatusCallbackID;
		private CHandle<redCallbackObject> _attitudeCallbackID;
		private CBool _isValidName;
		private CBool _isValidNetworkLevel;
		private CBool _isValidnetworkStatus;
		private CBool _isValidDeviceStatus;

		[Ordinal(5)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get => GetProperty(ref _nameText);
			set => SetProperty(ref _nameText, value);
		}

		[Ordinal(6)] 
		[RED("fluffText")] 
		public inkTextWidgetReference FluffText
		{
			get => GetProperty(ref _fluffText);
			set => SetProperty(ref _fluffText, value);
		}

		[Ordinal(7)] 
		[RED("separator1")] 
		public inkRectangleWidgetReference Separator1
		{
			get => GetProperty(ref _separator1);
			set => SetProperty(ref _separator1, value);
		}

		[Ordinal(8)] 
		[RED("separator2")] 
		public inkRectangleWidgetReference Separator2
		{
			get => GetProperty(ref _separator2);
			set => SetProperty(ref _separator2, value);
		}

		[Ordinal(9)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetProperty(ref _levelText);
			set => SetProperty(ref _levelText, value);
		}

		[Ordinal(10)] 
		[RED("status")] 
		public inkTextWidgetReference Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(11)] 
		[RED("statusIcon")] 
		public inkImageWidgetReference StatusIcon
		{
			get => GetProperty(ref _statusIcon);
			set => SetProperty(ref _statusIcon, value);
		}

		[Ordinal(12)] 
		[RED("levelWrapper")] 
		public inkWidgetReference LevelWrapper
		{
			get => GetProperty(ref _levelWrapper);
			set => SetProperty(ref _levelWrapper, value);
		}

		[Ordinal(13)] 
		[RED("nameCallbackID")] 
		public CHandle<redCallbackObject> NameCallbackID
		{
			get => GetProperty(ref _nameCallbackID);
			set => SetProperty(ref _nameCallbackID, value);
		}

		[Ordinal(14)] 
		[RED("networkLevelCallbackID")] 
		public CHandle<redCallbackObject> NetworkLevelCallbackID
		{
			get => GetProperty(ref _networkLevelCallbackID);
			set => SetProperty(ref _networkLevelCallbackID, value);
		}

		[Ordinal(15)] 
		[RED("networkStatusCallbackID")] 
		public CHandle<redCallbackObject> NetworkStatusCallbackID
		{
			get => GetProperty(ref _networkStatusCallbackID);
			set => SetProperty(ref _networkStatusCallbackID, value);
		}

		[Ordinal(16)] 
		[RED("deviceStatusCallbackID")] 
		public CHandle<redCallbackObject> DeviceStatusCallbackID
		{
			get => GetProperty(ref _deviceStatusCallbackID);
			set => SetProperty(ref _deviceStatusCallbackID, value);
		}

		[Ordinal(17)] 
		[RED("attitudeCallbackID")] 
		public CHandle<redCallbackObject> AttitudeCallbackID
		{
			get => GetProperty(ref _attitudeCallbackID);
			set => SetProperty(ref _attitudeCallbackID, value);
		}

		[Ordinal(18)] 
		[RED("isValidName")] 
		public CBool IsValidName
		{
			get => GetProperty(ref _isValidName);
			set => SetProperty(ref _isValidName, value);
		}

		[Ordinal(19)] 
		[RED("isValidNetworkLevel")] 
		public CBool IsValidNetworkLevel
		{
			get => GetProperty(ref _isValidNetworkLevel);
			set => SetProperty(ref _isValidNetworkLevel, value);
		}

		[Ordinal(20)] 
		[RED("isValidnetworkStatus")] 
		public CBool IsValidnetworkStatus
		{
			get => GetProperty(ref _isValidnetworkStatus);
			set => SetProperty(ref _isValidnetworkStatus, value);
		}

		[Ordinal(21)] 
		[RED("isValidDeviceStatus")] 
		public CBool IsValidDeviceStatus
		{
			get => GetProperty(ref _isValidDeviceStatus);
			set => SetProperty(ref _isValidDeviceStatus, value);
		}
	}
}
