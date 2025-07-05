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
			Id = ushort.MaxValue;
			Params = new questMultiplayerTeleportPuppetParams { DestinationRef = new gameEntityReference { Names = new() }, DestinationOffset = new Vector3(), AreaNodeTriggerRef = new gameEntityReference { Names = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
