using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineConsumableParameterDouble : gamestateMachineActionParameterDouble
	{
		[Ordinal(2)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamestateMachineConsumableParameterDouble()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
