using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAssignConvoy_NodeType : questIVehicleManagerNodeType
	{
		private CArray<gameEntityReference> _followers;
		private gameEntityReference _vehicleLeaderRef;

		[Ordinal(0)] 
		[RED("Followers")] 
		public CArray<gameEntityReference> Followers
		{
			get => GetProperty(ref _followers);
			set => SetProperty(ref _followers, value);
		}

		[Ordinal(1)] 
		[RED("vehicleLeaderRef")] 
		public gameEntityReference VehicleLeaderRef
		{
			get => GetProperty(ref _vehicleLeaderRef);
			set => SetProperty(ref _vehicleLeaderRef, value);
		}
	}
}
