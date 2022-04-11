using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineTransitionDefinition : graphGraphConnectionDefinition
	{
		[Ordinal(2)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gamestateMachineTransitionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
