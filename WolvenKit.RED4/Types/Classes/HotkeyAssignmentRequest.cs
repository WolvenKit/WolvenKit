using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HotkeyAssignmentRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get => GetPropertyValue<CEnum<gameEHotkey>>();
			set => SetPropertyValue<CEnum<gameEHotkey>>(value);
		}

		[Ordinal(3)] 
		[RED("requestType")] 
		public CEnum<EHotkeyRequestType> RequestType
		{
			get => GetPropertyValue<CEnum<EHotkeyRequestType>>();
			set => SetPropertyValue<CEnum<EHotkeyRequestType>>(value);
		}

		public HotkeyAssignmentRequest()
		{
			ItemID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
