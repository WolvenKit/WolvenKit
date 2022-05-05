using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineConsumableParameterVector : gamestateMachineActionParameterVector
	{
		[Ordinal(2)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamestateMachineConsumableParameterVector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
