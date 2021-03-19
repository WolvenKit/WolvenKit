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
			get => GetProperty(ref _equipCommand);
			set => SetProperty(ref _equipCommand, value);
		}

		[Ordinal(1)] 
		[RED("unequipCommand")] 
		public wCHandle<AIUnequipCommand> UnequipCommand
		{
			get => GetProperty(ref _unequipCommand);
			set => SetProperty(ref _unequipCommand, value);
		}

		[Ordinal(2)] 
		[RED("slotIdName")] 
		public TweakDBID SlotIdName
		{
			get => GetProperty(ref _slotIdName);
			set => SetProperty(ref _slotIdName, value);
		}

		[Ordinal(3)] 
		[RED("itemIdName")] 
		public TweakDBID ItemIdName
		{
			get => GetProperty(ref _itemIdName);
			set => SetProperty(ref _itemIdName, value);
		}

		public EquipItemCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
