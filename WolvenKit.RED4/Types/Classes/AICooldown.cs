using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AICooldown : AITimeCondition
	{
		[Ordinal(0)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AICooldown()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
