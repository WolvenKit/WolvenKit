using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSEquipArea : RedBaseClass
	{
		private CEnum<gamedataEquipmentArea> _areaType;
		private CArray<gameSEquipSlot> _equipSlots;
		private CInt32 _activeIndex;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		[Ordinal(1)] 
		[RED("equipSlots")] 
		public CArray<gameSEquipSlot> EquipSlots
		{
			get => GetProperty(ref _equipSlots);
			set => SetProperty(ref _equipSlots, value);
		}

		[Ordinal(2)] 
		[RED("activeIndex")] 
		public CInt32 ActiveIndex
		{
			get => GetProperty(ref _activeIndex);
			set => SetProperty(ref _activeIndex, value);
		}
	}
}
