using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questStartVehicle_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questStartVehicle_NodeType()
		{
			VehicleRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
