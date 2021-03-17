using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopCallReinforcements : AIbehaviortaskScript
	{
		private wCHandle<ScriptedPuppet> _puppet;
		private CHandle<PauseResumePhoneCallEvent> _pauseResumePhoneCallEvent;
		private CEnum<gamedataStatPoolType> _statPoolType;

		[Ordinal(0)] 
		[RED("puppet")] 
		public wCHandle<ScriptedPuppet> Puppet
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

		public StopCallReinforcements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
