using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BuyItemFromVendor : ActionBool
	{
		[Ordinal(38)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public BuyItemFromVendor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
