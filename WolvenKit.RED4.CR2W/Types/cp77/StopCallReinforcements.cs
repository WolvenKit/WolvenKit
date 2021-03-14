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
			get
			{
				if (_puppet == null)
				{
					_puppet = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "puppet", cr2w, this);
				}
				return _puppet;
			}
			set
			{
				if (_puppet == value)
				{
					return;
				}
				_puppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pauseResumePhoneCallEvent")] 
		public CHandle<PauseResumePhoneCallEvent> PauseResumePhoneCallEvent
		{
			get
			{
				if (_pauseResumePhoneCallEvent == null)
				{
					_pauseResumePhoneCallEvent = (CHandle<PauseResumePhoneCallEvent>) CR2WTypeManager.Create("handle:PauseResumePhoneCallEvent", "pauseResumePhoneCallEvent", cr2w, this);
				}
				return _pauseResumePhoneCallEvent;
			}
			set
			{
				if (_pauseResumePhoneCallEvent == value)
				{
					return;
				}
				_pauseResumePhoneCallEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get
			{
				if (_statPoolType == null)
				{
					_statPoolType = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolType", cr2w, this);
				}
				return _statPoolType;
			}
			set
			{
				if (_statPoolType == value)
				{
					return;
				}
				_statPoolType = value;
				PropertySet(this);
			}
		}

		public StopCallReinforcements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
