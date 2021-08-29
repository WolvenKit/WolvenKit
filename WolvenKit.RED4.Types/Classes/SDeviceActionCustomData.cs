using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SDeviceActionCustomData : SDeviceActionData
	{
		private CName _actionID;
		private CBool _on;
		private CBool _off;
		private CBool _unpowered;
		private TweakDBID _displayNameRecord;
		private CString _displayName;
		private CInt32 _customClearance;
		private CBool _isEnabled;
		private CBool _disableOnUse;
		private CName _factToEnableName;
		private CInt32 _quickHackCost;
		private CUInt32 _callbackID;

		[Ordinal(10)] 
		[RED("actionID")] 
		public CName ActionID
		{
			get => GetProperty(ref _actionID);
			set => SetProperty(ref _actionID, value);
		}

		[Ordinal(11)] 
		[RED("On")] 
		public CBool On
		{
			get => GetProperty(ref _on);
			set => SetProperty(ref _on, value);
		}

		[Ordinal(12)] 
		[RED("Off")] 
		public CBool Off
		{
			get => GetProperty(ref _off);
			set => SetProperty(ref _off, value);
		}

		[Ordinal(13)] 
		[RED("Unpowered")] 
		public CBool Unpowered
		{
			get => GetProperty(ref _unpowered);
			set => SetProperty(ref _unpowered, value);
		}

		[Ordinal(14)] 
		[RED("displayNameRecord")] 
		public TweakDBID DisplayNameRecord
		{
			get => GetProperty(ref _displayNameRecord);
			set => SetProperty(ref _displayNameRecord, value);
		}

		[Ordinal(15)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(16)] 
		[RED("customClearance")] 
		public CInt32 CustomClearance
		{
			get => GetProperty(ref _customClearance);
			set => SetProperty(ref _customClearance, value);
		}

		[Ordinal(17)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(18)] 
		[RED("disableOnUse")] 
		public CBool DisableOnUse
		{
			get => GetProperty(ref _disableOnUse);
			set => SetProperty(ref _disableOnUse, value);
		}

		[Ordinal(19)] 
		[RED("factToEnableName")] 
		public CName FactToEnableName
		{
			get => GetProperty(ref _factToEnableName);
			set => SetProperty(ref _factToEnableName, value);
		}

		[Ordinal(20)] 
		[RED("quickHackCost")] 
		public CInt32 QuickHackCost
		{
			get => GetProperty(ref _quickHackCost);
			set => SetProperty(ref _quickHackCost, value);
		}

		[Ordinal(21)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}
	}
}
