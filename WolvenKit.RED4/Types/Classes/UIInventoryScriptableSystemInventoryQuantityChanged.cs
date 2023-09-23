using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryScriptableSystemInventoryQuantityChanged : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public UIInventoryScriptableSystemInventoryQuantityChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
