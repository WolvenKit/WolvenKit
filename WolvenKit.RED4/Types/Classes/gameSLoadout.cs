using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSLoadout : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("equipAreas")] 
		public CArray<gameSEquipArea> EquipAreas
		{
			get => GetPropertyValue<CArray<gameSEquipArea>>();
			set => SetPropertyValue<CArray<gameSEquipArea>>(value);
		}

		[Ordinal(1)] 
		[RED("equipmentSets")] 
		public CArray<gameSEquipmentSet> EquipmentSets
		{
			get => GetPropertyValue<CArray<gameSEquipmentSet>>();
			set => SetPropertyValue<CArray<gameSEquipmentSet>>(value);
		}

		public gameSLoadout()
		{
			EquipAreas = new();
			EquipmentSets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
