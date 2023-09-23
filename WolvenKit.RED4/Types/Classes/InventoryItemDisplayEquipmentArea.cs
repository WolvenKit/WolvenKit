using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemDisplayEquipmentArea : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("equipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipmentAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(2)] 
		[RED("numberOfSlots")] 
		public CInt32 NumberOfSlots
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public InventoryItemDisplayEquipmentArea()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
