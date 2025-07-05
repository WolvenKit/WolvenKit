using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectAndDamageEventData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("hitevent")] 
		public CHandle<gameeventsHitEvent> Hitevent
		{
			get => GetPropertyValue<CHandle<gameeventsHitEvent>>();
			set => SetPropertyValue<CHandle<gameeventsHitEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("threats")] 
		public CArray<CWeakHandle<entEntity>> Threats
		{
			get => GetPropertyValue<CArray<CWeakHandle<entEntity>>>();
			set => SetPropertyValue<CArray<CWeakHandle<entEntity>>>(value);
		}

		[Ordinal(2)] 
		[RED("effectorInstance")] 
		public CHandle<TriggerAttackOnNearbyEnemiesEffector> EffectorInstance
		{
			get => GetPropertyValue<CHandle<TriggerAttackOnNearbyEnemiesEffector>>();
			set => SetPropertyValue<CHandle<TriggerAttackOnNearbyEnemiesEffector>>(value);
		}

		public EffectAndDamageEventData()
		{
			Threats = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
