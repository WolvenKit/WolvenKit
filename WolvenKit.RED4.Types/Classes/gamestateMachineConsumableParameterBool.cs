using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineConsumableParameterBool : gamestateMachineActionParameterBool
	{
		[Ordinal(2)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamestateMachineConsumableParameterBool()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
