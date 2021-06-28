using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAssignConvoy_NodeType : questIVehicleManagerNodeType
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

		public questAssignConvoy_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
