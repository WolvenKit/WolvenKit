using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTeleportVehicleNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public questTeleportPuppetParams Params
		{
			get => GetPropertyValue<questTeleportPuppetParams>();
			set => SetPropertyValue<questTeleportPuppetParams>(value);
		}

		[Ordinal(4)] 
		[RED("resetVelocities")] 
		public CBool ResetVelocities
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questTeleportVehicleNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			EntityReference = new() { Names = new() };
			Params = new() { DestinationOffset = new() };
			ResetVelocities = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
