using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workEquipItemToSlotAction : workIWorkspotItemAction
	{
		[Ordinal(0)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("itemSlot")] 
		public TweakDBID ItemSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public workEquipItemToSlotAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
