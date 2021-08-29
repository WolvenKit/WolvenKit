using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineTransition : graphGraphConnectionDefinition
	{
		private CHandle<gamestateMachineFunctor> _transitionCondition;

		[Ordinal(2)] 
		[RED("transitionCondition")] 
		public CHandle<gamestateMachineFunctor> TransitionCondition
		{
			get => GetProperty(ref _transitionCondition);
			set => SetProperty(ref _transitionCondition, value);
		}
	}
}
