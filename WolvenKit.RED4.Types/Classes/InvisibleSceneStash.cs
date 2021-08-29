using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InvisibleSceneStash : Device
	{
		private CArray<CEnum<gamedataEquipmentArea>> _itemSlots;
		private CHandle<EquipmentSystemPlayerData> _equipmentData;

		[Ordinal(87)] 
		[RED("itemSlots")] 
		public CArray<CEnum<gamedataEquipmentArea>> ItemSlots
		{
			get => GetProperty(ref _itemSlots);
			set => SetProperty(ref _itemSlots, value);
		}

		[Ordinal(88)] 
		[RED("equipmentData")] 
		public CHandle<EquipmentSystemPlayerData> EquipmentData
		{
			get => GetProperty(ref _equipmentData);
			set => SetProperty(ref _equipmentData, value);
		}
	}
}
