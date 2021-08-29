using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipItemCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CWeakHandle<AIEquipCommand> _equipCommand;
		private CWeakHandle<AIUnequipCommand> _unequipCommand;
		private TweakDBID _slotIdName;
		private TweakDBID _itemIdName;

		[Ordinal(0)] 
		[RED("equipCommand")] 
		public CWeakHandle<AIEquipCommand> EquipCommand
		{
			get => GetProperty(ref _equipCommand);
			set => SetProperty(ref _equipCommand, value);
		}

		[Ordinal(1)] 
		[RED("unequipCommand")] 
		public CWeakHandle<AIUnequipCommand> UnequipCommand
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
	}
}
