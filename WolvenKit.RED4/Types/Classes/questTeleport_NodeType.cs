using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTeleport_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("params")] 
		public questTeleportPuppetParams Params
		{
			get => GetPropertyValue<questTeleportPuppetParams>();
			set => SetPropertyValue<questTeleportPuppetParams>(value);
		}

		public questTeleport_NodeType()
		{
			EntityReference = new() { Names = new() };
			Params = new() { DestinationOffset = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
