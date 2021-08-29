using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemDisplayEquipmentArea : inkWidgetLogicController
	{
		private CArray<CEnum<gamedataEquipmentArea>> _equipmentAreas;
		private CInt32 _numberOfSlots;

		[Ordinal(1)] 
		[RED("equipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipmentAreas
		{
			get => GetProperty(ref _equipmentAreas);
			set => SetProperty(ref _equipmentAreas, value);
		}

		[Ordinal(2)] 
		[RED("numberOfSlots")] 
		public CInt32 NumberOfSlots
		{
			get => GetProperty(ref _numberOfSlots);
			set => SetProperty(ref _numberOfSlots, value);
		}
	}
}
