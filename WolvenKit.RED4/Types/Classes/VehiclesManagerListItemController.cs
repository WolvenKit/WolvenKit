using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehiclesManagerListItemController : inkVirtualCompoundItemController
	{
		[Ordinal(18)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("repairTime")] 
		public inkTextWidgetReference RepairTime
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("vehicleData")] 
		public CHandle<VehicleListItemData> VehicleData
		{
			get => GetPropertyValue<CHandle<VehicleListItemData>>();
			set => SetPropertyValue<CHandle<VehicleListItemData>>(value);
		}

		public VehiclesManagerListItemController()
		{
			Label = new inkTextWidgetReference();
			TypeIcon = new inkImageWidgetReference();
			RepairTime = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
