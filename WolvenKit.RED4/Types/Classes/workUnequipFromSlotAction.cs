using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workUnequipFromSlotAction : workIWorkspotItemAction
	{
		[Ordinal(0)] 
		[RED("itemSlot")] 
		public TweakDBID ItemSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public workUnequipFromSlotAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
