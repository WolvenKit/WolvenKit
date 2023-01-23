using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineConsumableParameterFloat : gamestateMachineActionParameterFloat
	{
		[Ordinal(2)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamestateMachineConsumableParameterFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
