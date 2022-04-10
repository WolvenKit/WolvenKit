using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSEquipArea : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(1)] 
		[RED("equipSlots")] 
		public CArray<gameSEquipSlot> EquipSlots
		{
			get => GetPropertyValue<CArray<gameSEquipSlot>>();
			set => SetPropertyValue<CArray<gameSEquipSlot>>(value);
		}

		[Ordinal(2)] 
		[RED("activeIndex")] 
		public CInt32 ActiveIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameSEquipArea()
		{
			AreaType = Enums.gamedataEquipmentArea.Invalid;
			EquipSlots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
