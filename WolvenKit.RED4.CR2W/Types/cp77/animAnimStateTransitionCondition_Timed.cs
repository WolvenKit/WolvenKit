using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_Timed : animIAnimStateTransitionCondition
	{
		private CFloat _timeToFireTransition;

		[Ordinal(0)] 
		[RED("timeToFireTransition")] 
		public CFloat TimeToFireTransition
		{
			get
			{
				if (_timeToFireTransition == null)
				{
					_timeToFireTransition = (CFloat) CR2WTypeManager.Create("Float", "timeToFireTransition", cr2w, this);
				}
				return _timeToFireTransition;
			}
			set
			{
				if (_timeToFireTransition == value)
				{
					return;
				}
				_timeToFireTransition = value;
				PropertySet(this);
			}
		}

		public animAnimStateTransitionCondition_Timed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
