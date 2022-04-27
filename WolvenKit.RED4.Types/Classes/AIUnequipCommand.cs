using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIUnequipCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("durationOverride")] 
		public CFloat DurationOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIUnequipCommand()
		{
			DurationOverride = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
