using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipItemCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private wCHandle<AIEquipCommand> _equipCommand;
		private wCHandle<AIUnequipCommand> _unequipCommand;
		private TweakDBID _slotIdName;
		private TweakDBID _itemIdName;

		[Ordinal(0)] 
		[RED("equipCommand")] 
		public wCHandle<AIEquipCommand> EquipCommand
		{
			get
			{
				if (_equipCommand == null)
				{
					_equipCommand = (wCHandle<AIEquipCommand>) CR2WTypeManager.Create("whandle:AIEquipCommand", "equipCommand", cr2w, this);
				}
				return _equipCommand;
			}
			set
			{
				if (_equipCommand == value)
				{
					return;
				}
				_equipCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("unequipCommand")] 
		public wCHandle<AIUnequipCommand> UnequipCommand
		{
			get
			{
				if (_unequipCommand == null)
				{
					_unequipCommand = (wCHandle<AIUnequipCommand>) CR2WTypeManager.Create("whandle:AIUnequipCommand", "unequipCommand", cr2w, this);
				}
				return _unequipCommand;
			}
			set
			{
				if (_unequipCommand == value)
				{
					return;
				}
				_unequipCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotIdName")] 
		public TweakDBID SlotIdName
		{
			get
			{
				if (_slotIdName == null)
				{
					_slotIdName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotIdName", cr2w, this);
				}
				return _slotIdName;
			}
			set
			{
				if (_slotIdName == value)
				{
					return;
				}
				_slotIdName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemIdName")] 
		public TweakDBID ItemIdName
		{
			get
			{
				if (_itemIdName == null)
				{
					_itemIdName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemIdName", cr2w, this);
				}
				return _itemIdName;
			}
			set
			{
				if (_itemIdName == value)
				{
					return;
				}
				_itemIdName = value;
				PropertySet(this);
			}
		}

		public EquipItemCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
