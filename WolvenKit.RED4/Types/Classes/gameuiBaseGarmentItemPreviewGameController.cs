using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBaseGarmentItemPreviewGameController : gameuiInventoryPuppetPreviewGameController
	{
		[Ordinal(14)] 
		[RED("placementSlot")] 
		public TweakDBID PlacementSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(15)] 
		[RED("givenItem")] 
		public gameItemID GivenItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(16)] 
		[RED("initialItem")] 
		public gameItemID InitialItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public gameuiBaseGarmentItemPreviewGameController()
		{
			GivenItem = new();
			InitialItem = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
