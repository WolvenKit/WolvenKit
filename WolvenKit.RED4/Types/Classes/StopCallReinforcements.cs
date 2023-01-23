using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StopCallReinforcements : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("puppet")] 
		public CWeakHandle<ScriptedPuppet> Puppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("pauseResumePhoneCallEvent")] 
		public CHandle<PauseResumePhoneCallEvent> PauseResumePhoneCallEvent
		{
			get => GetPropertyValue<CHandle<PauseResumePhoneCallEvent>>();
			set => SetPropertyValue<CHandle<PauseResumePhoneCallEvent>>(value);
		}

		[Ordinal(2)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		public StopCallReinforcements()
		{
			StatPoolType = Enums.gamedataStatPoolType.CallReinforcementProgress;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
