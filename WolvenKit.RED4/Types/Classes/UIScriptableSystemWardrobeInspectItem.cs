using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIScriptableSystemWardrobeInspectItem : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public UIScriptableSystemWardrobeInspectItem()
		{
			ItemID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
