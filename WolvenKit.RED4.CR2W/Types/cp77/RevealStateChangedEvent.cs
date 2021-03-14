using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealStateChangedEvent : redEvent
	{
		private CEnum<ERevealState> _state;
		private gameVisionModeSystemRevealIdentifier _reason;
		private CFloat _transitionTime;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<ERevealState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<ERevealState>) CR2WTypeManager.Create("ERevealState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public gameVisionModeSystemRevealIdentifier Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (gameVisionModeSystemRevealIdentifier) CR2WTypeManager.Create("gameVisionModeSystemRevealIdentifier", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get
			{
				if (_transitionTime == null)
				{
					_transitionTime = (CFloat) CR2WTypeManager.Create("Float", "transitionTime", cr2w, this);
				}
				return _transitionTime;
			}
			set
			{
				if (_transitionTime == value)
				{
					return;
				}
				_transitionTime = value;
				PropertySet(this);
			}
		}

		public RevealStateChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
