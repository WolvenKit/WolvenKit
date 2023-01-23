using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AssignHotkeyIfEmptySlot : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public AssignHotkeyIfEmptySlot()
		{
			ItemID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
