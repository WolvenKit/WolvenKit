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

		public ItemCraftedDataTrackingRequest()
		{
			TargetItem = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
