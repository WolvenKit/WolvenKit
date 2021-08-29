using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResolveQualityRangeInteractionLayerEvent : redEvent
	{
		private CWeakHandle<gameItemData> _itemData;

		[Ordinal(0)] 
		[RED("itemData")] 
		public CWeakHandle<gameItemData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}
	}
}
