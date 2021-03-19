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
			get => GetProperty(ref _timeToFireTransition);
			set => SetProperty(ref _timeToFireTransition, value);
		}

		public animAnimStateTransitionCondition_Timed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
