using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatusEffectBasedTimeBankEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("playerEntityID")] 
		public entEntityID PlayerEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("statusEffectListener")] 
		public CHandle<TimeBankOnStatusEffectAppliedListener> StatusEffectListener
		{
			get => GetPropertyValue<CHandle<TimeBankOnStatusEffectAppliedListener>>();
			set => SetPropertyValue<CHandle<TimeBankOnStatusEffectAppliedListener>>(value);
		}

		[Ordinal(3)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		public StatusEffectBasedTimeBankEffector()
		{
			PlayerEntityID = new entEntityID();
			GameInstance = new ScriptGameInstance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
