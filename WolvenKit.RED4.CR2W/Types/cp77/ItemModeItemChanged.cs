using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemModeItemChanged : redEvent
	{
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CInt32 _slotIndex;
		private CEnum<gameEHotkey> _hotkey;

		[Ordinal(0)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get
			{
				if (_equipmentArea == null)
				{
					_equipmentArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipmentArea", cr2w, this);
				}
				return _equipmentArea;
			}
			set
			{
				if (_equipmentArea == value)
				{
					return;
				}
				_equipmentArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get
			{
				if (_slotIndex == null)
				{
					_slotIndex = (CInt32) CR2WTypeManager.Create("Int32", "slotIndex", cr2w, this);
				}
				return _slotIndex;
			}
			set
			{
				if (_slotIndex == value)
				{
					return;
				}
				_slotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get
			{
				if (_hotkey == null)
				{
					_hotkey = (CEnum<gameEHotkey>) CR2WTypeManager.Create("gameEHotkey", "hotkey", cr2w, this);
				}
				return _hotkey;
			}
			set
			{
				if (_hotkey == value)
				{
					return;
				}
				_hotkey = value;
				PropertySet(this);
			}
		}

		public ItemModeItemChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
