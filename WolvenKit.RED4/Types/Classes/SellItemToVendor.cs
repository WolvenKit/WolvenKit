using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SellItemToVendor : ActionBool
	{
		[Ordinal(38)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public SellItemToVendor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
