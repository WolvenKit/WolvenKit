using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemCraftedDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("targetItem")] 
		public gameItemID TargetItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ItemCraftedDataTrackingRequest()
		{
			TargetItem = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
