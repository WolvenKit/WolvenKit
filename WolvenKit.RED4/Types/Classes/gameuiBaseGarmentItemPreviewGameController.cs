using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBaseGarmentItemPreviewGameController : gameuiInventoryPuppetPreviewGameController
	{
		[Ordinal(15)] 
		[RED("placementSlot")] 
		public TweakDBID PlacementSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(16)] 
		[RED("givenItem")] 
		public gameItemID GivenItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(17)] 
		[RED("initialItem")] 
		public gameItemID InitialItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public gameuiBaseGarmentItemPreviewGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
