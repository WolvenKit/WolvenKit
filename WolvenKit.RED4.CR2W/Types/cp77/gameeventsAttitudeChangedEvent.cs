using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsAttitudeChangedEvent : redEvent
	{
		private wCHandle<gameAttitudeAgent> _otherAgent;
		private CEnum<EAIAttitude> _attitude;

		[Ordinal(0)] 
		[RED("otherAgent")] 
		public wCHandle<gameAttitudeAgent> OtherAgent
		{
			get
			{
				if (_otherAgent == null)
				{
					_otherAgent = (wCHandle<gameAttitudeAgent>) CR2WTypeManager.Create("whandle:gameAttitudeAgent", "otherAgent", cr2w, this);
				}
				return _otherAgent;
			}
			set
			{
				if (_otherAgent == value)
				{
					return;
				}
				_otherAgent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get
			{
				if (_attitude == null)
				{
					_attitude = (CEnum<EAIAttitude>) CR2WTypeManager.Create("EAIAttitude", "attitude", cr2w, this);
				}
				return _attitude;
			}
			set
			{
				if (_attitude == value)
				{
					return;
				}
				_attitude = value;
				PropertySet(this);
			}
		}

		public gameeventsAttitudeChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
