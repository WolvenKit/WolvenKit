using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HotkeyAssignmentRequest : gamePlayerScriptableSystemRequest
	{
		private gameItemID _itemID;
		private CEnum<gameEHotkey> _hotkey;
		private CEnum<EHotkeyRequestType> _requestType;

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(2)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get => GetProperty(ref _hotkey);
			set => SetProperty(ref _hotkey, value);
		}

		[Ordinal(3)] 
		[RED("requestType")] 
		public CEnum<EHotkeyRequestType> RequestType
		{
			get => GetProperty(ref _requestType);
			set => SetProperty(ref _requestType, value);
		}
	}
}
