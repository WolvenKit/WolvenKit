using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StealthStimThresholdEvent : redEvent
	{
		private CBool _reset;
		private CFloat _timeThreshold;

		[Ordinal(0)] 
		[RED("reset")] 
		public CBool Reset
		{
			get
			{
				if (_reset == null)
				{
					_reset = (CBool) CR2WTypeManager.Create("Bool", "reset", cr2w, this);
				}
				return _reset;
			}
			set
			{
				if (_reset == value)
				{
					return;
				}
				_reset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeThreshold")] 
		public CFloat TimeThreshold
		{
			get
			{
				if (_timeThreshold == null)
				{
					_timeThreshold = (CFloat) CR2WTypeManager.Create("Float", "timeThreshold", cr2w, this);
				}
				return _timeThreshold;
			}
			set
			{
				if (_timeThreshold == value)
				{
					return;
				}
				_timeThreshold = value;
				PropertySet(this);
			}
		}

		public StealthStimThresholdEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
