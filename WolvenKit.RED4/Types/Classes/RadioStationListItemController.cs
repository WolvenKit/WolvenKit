using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioStationListItemController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("stationData")] 
		public CHandle<RadioListItemData> StationData
		{
			get => GetPropertyValue<CHandle<RadioListItemData>>();
			set => SetPropertyValue<CHandle<RadioListItemData>>(value);
		}

		public RadioStationListItemController()
		{
			Label = new inkTextWidgetReference();
			TypeIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
