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
			Params = new questMultiplayerTeleportPuppetParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
