using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questResetMovement_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questResetMovement_NodeType()
		{
			VehicleRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
