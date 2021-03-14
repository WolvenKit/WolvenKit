using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PauseResumePhoneCallEvent : redEvent
	{
		private CFloat _callDuration;
		private CBool _pauseCall;
		private CEnum<gamedataStatPoolType> _statPoolType;

		[Ordinal(0)] 
		[RED("callDuration")] 
		public CFloat CallDuration
		{
			get
			{
				if (_callDuration == null)
				{
					_callDuration = (CFloat) CR2WTypeManager.Create("Float", "callDuration", cr2w, this);
				}
				return _callDuration;
			}
			set
			{
				if (_callDuration == value)
				{
					return;
				}
				_callDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pauseCall")] 
		public CBool PauseCall
		{
			get
			{
				if (_pauseCall == null)
				{
					_pauseCall = (CBool) CR2WTypeManager.Create("Bool", "pauseCall", cr2w, this);
				}
				return _pauseCall;
			}
			set
			{
				if (_pauseCall == value)
				{
					return;
				}
				_pauseCall = value;
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

		public PauseResumePhoneCallEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
