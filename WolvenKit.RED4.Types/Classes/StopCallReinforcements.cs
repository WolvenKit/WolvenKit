using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StopCallReinforcements : AIbehaviortaskScript
	{
		private CWeakHandle<ScriptedPuppet> _puppet;
		private CHandle<PauseResumePhoneCallEvent> _pauseResumePhoneCallEvent;
		private CEnum<gamedataStatPoolType> _statPoolType;

		[Ordinal(0)] 
		[RED("puppet")] 
		public CWeakHandle<ScriptedPuppet> Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(1)] 
		[RED("pauseResumePhoneCallEvent")] 
		public CHandle<PauseResumePhoneCallEvent> PauseResumePhoneCallEvent
		{
			get => GetProperty(ref _pauseResumePhoneCallEvent);
			set => SetProperty(ref _pauseResumePhoneCallEvent, value);
		}

		[Ordinal(2)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		public StopCallReinforcements()
		{
			_statPoolType = new() { Value = Enums.gamedataStatPoolType.CallReinforcementProgress };
		}
	}
}
