using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipItemCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] 
		[RED("equipCommand")] 
		public CWeakHandle<AIEquipCommand> EquipCommand
		{
			get => GetPropertyValue<CWeakHandle<AIEquipCommand>>();
			set => SetPropertyValue<CWeakHandle<AIEquipCommand>>(value);
		}

		[Ordinal(1)] 
		[RED("unequipCommand")] 
		public CWeakHandle<AIUnequipCommand> UnequipCommand
		{
			get => GetPropertyValue<CWeakHandle<AIUnequipCommand>>();
			set => SetPropertyValue<CWeakHandle<AIUnequipCommand>>(value);
		}

		[Ordinal(2)] 
		[RED("slotIdName")] 
		public TweakDBID SlotIdName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("itemIdName")] 
		public TweakDBID ItemIdName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public EquipItemCommandDelegate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
