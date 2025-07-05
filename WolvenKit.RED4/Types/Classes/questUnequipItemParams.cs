using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUnequipItemParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("unequipDurationOverride")] 
		public CFloat UnequipDurationOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questUnequipItemParams()
		{
			UnequipDurationOverride = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
