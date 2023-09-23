using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TriggerAttackByChanceStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CWeakHandle<TriggerAttackByChanceEffector> Effector
		{
			get => GetPropertyValue<CWeakHandle<TriggerAttackByChanceEffector>>();
			set => SetPropertyValue<CWeakHandle<TriggerAttackByChanceEffector>>(value);
		}

		public TriggerAttackByChanceStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
