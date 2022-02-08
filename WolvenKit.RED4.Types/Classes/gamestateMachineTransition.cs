using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineTransition : graphGraphConnectionDefinition
	{
		[Ordinal(2)] 
		[RED("transitionCondition")] 
		public CHandle<gamestateMachineFunctor> TransitionCondition
		{
			get => GetPropertyValue<CHandle<gamestateMachineFunctor>>();
			set => SetPropertyValue<CHandle<gamestateMachineFunctor>>(value);
		}
	}
}
