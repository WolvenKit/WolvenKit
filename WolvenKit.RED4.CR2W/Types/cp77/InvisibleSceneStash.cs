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

		[Ordinal(86)] 
		[RED("itemSlots")] 
		public CArray<CEnum<gamedataEquipmentArea>> ItemSlots
		{
			get
			{
				if (_itemSlots == null)
				{
					_itemSlots = (CArray<CEnum<gamedataEquipmentArea>>) CR2WTypeManager.Create("array:gamedataEquipmentArea", "itemSlots", cr2w, this);
				}
				return _itemSlots;
			}
			set
			{
				if (_itemSlots == value)
				{
					return;
				}
				_itemSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("equipmentData")] 
		public CHandle<EquipmentSystemPlayerData> EquipmentData
		{
			get
			{
				if (_equipmentData == null)
				{
					_equipmentData = (CHandle<EquipmentSystemPlayerData>) CR2WTypeManager.Create("handle:EquipmentSystemPlayerData", "equipmentData", cr2w, this);
				}
				return _equipmentData;
			}
			set
			{
				if (_equipmentData == value)
				{
					return;
				}
				_equipmentData = value;
				PropertySet(this);
			}
		}

		public InvisibleSceneStash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
