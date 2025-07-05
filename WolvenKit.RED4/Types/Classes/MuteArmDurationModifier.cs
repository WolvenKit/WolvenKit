using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MuteArmDurationModifier : gameEffectDurationModifier_Scripted
	{
		[Ordinal(0)] 
		[RED("initialDuration")] 
		public CFloat InitialDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public MuteArmDurationModifier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
