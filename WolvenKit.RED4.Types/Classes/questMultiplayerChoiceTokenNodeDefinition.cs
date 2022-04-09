using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMultiplayerChoiceTokenNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("params")] 
		public questMultiplayerChoiceTokenParams Params
		{
			get => GetPropertyValue<questMultiplayerChoiceTokenParams>();
			set => SetPropertyValue<questMultiplayerChoiceTokenParams>(value);
		}

		public questMultiplayerChoiceTokenNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Params = new() { Timeout = 15 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
