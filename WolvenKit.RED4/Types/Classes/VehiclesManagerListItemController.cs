using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehiclesManagerListItemController : inkVirtualCompoundItemController
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
		[RED("vehicleData")] 
		public CHandle<VehicleListItemData> VehicleData
		{
			get => GetPropertyValue<CHandle<VehicleListItemData>>();
			set => SetPropertyValue<CHandle<VehicleListItemData>>(value);
		}

		public VehiclesManagerListItemController()
		{
			Label = new();
			TypeIcon = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
