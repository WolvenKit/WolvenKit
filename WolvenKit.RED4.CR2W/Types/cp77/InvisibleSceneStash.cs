using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InvisibleSceneStash : Device
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

		public InvisibleSceneStash(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
