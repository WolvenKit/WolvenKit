using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TimeBankOnStatusEffectAppliedListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CWeakHandle<StatusEffectBasedTimeBankEffector> Effector
		{
			get => GetPropertyValue<CWeakHandle<StatusEffectBasedTimeBankEffector>>();
			set => SetPropertyValue<CWeakHandle<StatusEffectBasedTimeBankEffector>>(value);
		}

		public TimeBankOnStatusEffectAppliedListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
