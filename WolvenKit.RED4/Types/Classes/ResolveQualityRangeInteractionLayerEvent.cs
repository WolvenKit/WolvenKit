using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResolveQualityRangeInteractionLayerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemData")] 
		public CWeakHandle<gameItemData> ItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		public ResolveQualityRangeInteractionLayerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
