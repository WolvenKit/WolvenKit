using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSLoadout : RedBaseClass
	{
		private CArray<gameSEquipArea> _equipAreas;
		private CArray<gameSEquipmentSet> _equipmentSets;

		[Ordinal(0)] 
		[RED("equipAreas")] 
		public CArray<gameSEquipArea> EquipAreas
		{
			get => GetProperty(ref _equipAreas);
			set => SetProperty(ref _equipAreas, value);
		}

		[Ordinal(1)] 
		[RED("equipmentSets")] 
		public CArray<gameSEquipmentSet> EquipmentSets
		{
			get => GetProperty(ref _equipmentSets);
			set => SetProperty(ref _equipmentSets, value);
		}
	}
}
