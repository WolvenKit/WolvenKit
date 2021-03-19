using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplayEquipmentArea : inkWidgetLogicController
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

		public InventoryItemDisplayEquipmentArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
