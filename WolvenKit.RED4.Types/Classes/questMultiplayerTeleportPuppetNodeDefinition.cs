using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMultiplayerTeleportPuppetNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("params")] 
		public questMultiplayerTeleportPuppetParams Params
		{
			get => GetPropertyValue<questMultiplayerTeleportPuppetParams>();
			set => SetPropertyValue<questMultiplayerTeleportPuppetParams>(value);
		}

		public questMultiplayerTeleportPuppetNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Params = new() { DestinationRef = new() { Names = new() }, DestinationOffset = new(), AreaNodeTriggerRef = new() { Names = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
