using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_Timed : animIAnimStateTransitionCondition
	{
		private CFloat _timeToFireTransition;

		[Ordinal(0)] 
		[RED("timeToFireTransition")] 
		public CFloat TimeToFireTransition
		{
			get => GetProperty(ref _timeToFireTransition);
			set => SetProperty(ref _timeToFireTransition, value);
		}
	}
}
