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
			Id = ushort.MaxValue;
			EntityReference = new gameEntityReference { Names = new() };
			Params = new questTeleportPuppetParams { DestinationOffset = new Vector3() };
			ResetVelocities = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
