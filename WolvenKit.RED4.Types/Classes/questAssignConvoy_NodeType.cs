using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAssignConvoy_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("Followers")] 
		public CArray<gameEntityReference> Followers
		{
			get => GetPropertyValue<CArray<gameEntityReference>>();
			set => SetPropertyValue<CArray<gameEntityReference>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleLeaderRef")] 
		public gameEntityReference VehicleLeaderRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questAssignConvoy_NodeType()
		{
			Followers = new();
			VehicleLeaderRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
