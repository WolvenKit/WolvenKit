using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InvisibleSceneStash : Device
	{
		[Ordinal(84)] 
		[RED("itemSlots")] 
		public CArray<CEnum<gamedataEquipmentArea>> ItemSlots
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(85)] 
		[RED("equipmentData")] 
		public CHandle<EquipmentSystemPlayerData> EquipmentData
		{
			get => GetPropertyValue<CHandle<EquipmentSystemPlayerData>>();
			set => SetPropertyValue<CHandle<EquipmentSystemPlayerData>>(value);
		}

		public InvisibleSceneStash()
		{
			ControllerTypeName = "InvisibleSceneStashController";
			ItemSlots = new();
		}
	}
}
